using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using Quartz;
using Quartz.Impl;

namespace MaterialScale2MES
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initialization Zone (Create datatable, Init variables, Load form... )
        /// </summary>
        #region Initialization 
        //Init variables
        DataTable tempMat = new DataTable();
        DataTable dtgvWOData = new DataTable();

        string dataIn;
        double totalScaleWeight = 0;
        string tempMatCode;
        double tempScaleQty, returnValue;
        int scaleTimes = 0;
        int subRowIndex = -1;
        bool isLoad2DTGV = false;
        bool isAddSubMat = false;

        public MainForm()
        {
            InitializeComponent();

            //Load tempMat datatable to form
            addTempMatColumn();
            SupportClass.LoadData2DTGVScannedMat(dtgv_allScannedMat, tempMat);

            //Adding 2 button column to add Subtitute Material & delete row action
            var editButtonColumn = new DataGridViewButtonColumn(); // Adding subtitute material
            editButtonColumn.Text = "Liệu phụ";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dtgv_allScannedMat.Columns.Add(editButtonColumn);
            

            var deleteButtonColumn = new DataGridViewButtonColumn(); // Delete row 
            deleteButtonColumn.Text = "X";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Width = 25;
            dtgv_allScannedMat.Columns.Add(deleteButtonColumn);
        }

        public void addTempMatColumn() //Init columns into tempMat datatable to add scale data for saving to MES system
        {
            DataColumn tempMatCol;
            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.String");
            tempMatCol.ColumnName = "MatCode";//2
            tempMat.Columns.Add(tempMatCol);
            
            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.String");
            tempMatCol.ColumnName = "MatUUID";//3
            tempMat.Columns.Add(tempMatCol);

            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.String");
            tempMatCol.ColumnName = "SubMat";//4
            tempMat.Columns.Add(tempMatCol);
            
            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.String");
            tempMatCol.ColumnName = "SubMatUUID";//5
            tempMat.Columns.Add(tempMatCol);

            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.String");
            tempMatCol.ColumnName = "ExpDate";
            tempMat.Columns.Add(tempMatCol);

            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.String");
            tempMatCol.ColumnName = "LOT";
            tempMat.Columns.Add(tempMatCol);

            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.Decimal");
            tempMatCol.ColumnName = "SumScale";
            tempMat.Columns.Add(tempMatCol);

            tempMatCol = new DataColumn();
            tempMatCol.DataType = Type.GetType("System.String");
            tempMatCol.ColumnName = "JOMatUUID";
            tempMat.Columns.Add(tempMatCol);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            cbComPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);
            txtQR.Focus();
            txtQR.Multiline = false;
            txtQR.Width = 0;
            txtQR.Height = 0;
            cbx_chooseReplenishmentType.SelectedIndex = -1;
            cbComPort.SelectedIndex = -1;
            cbBaudRate.SelectedIndex = 2;
            cbDataBits.SelectedIndex = 2;
            cbStopBits.SelectedIndex = 0;
            cbParityBits.SelectedIndex = 0;

            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler().Result;
            scheduler.Start();
            IJobDetail job = JobBuilder.Create<EmailJob>().Build();
            ITrigger trigger = TriggerBuilder.Create()
             .WithIdentity("IDGJob", "IDG")
               .WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(13, 30))
               .Build();
            scheduler.ScheduleJob(job, trigger);
        }
        #endregion

        /// <summary>
        /// Electronic Scale Logic (Connect logic, Scale data logic, ... ) - Kết nối với cân điện tử
        /// </summary>
        #region Electronic Scale Logic
        private void showData(object sender, EventArgs e)
        {
            if (double.TryParse(dataIn, out returnValue))
            {
                tempScaleQty = totalScaleWeight;
                returnValue = double.Parse(dataIn);
            }
            if (returnValue != 0)
            {
                totalScaleWeight += returnValue;
                lb_scaleQty.Text = returnValue.ToString();
                lb_sumScaleQty.Text = totalScaleWeight.ToString();
                scaleTimes = 0; // --> Not allow user to scale another time without scan material QR code
                pnl_scaleWait.BackColor = Color.Black;
                this.Invoke(new EventHandler(add2tempMat));
                SupportClass.LoadData2DTGVScannedMat(dtgv_allScannedMat, tempMat);
            }
        }

        private void add2tempMat (object sender, EventArgs e)
        {
            //Check & adding scaled data to tempMat datatable
            if (tempMat.Rows.Count > 0)
            {
                bool checkExistMat = false;
                for (int i = 0; i < tempMat.Rows.Count; i ++)
                {
                    if ((tempMat.Rows[i]["MatCode"].ToString() == VariablesSave.matCode || tempMat.Rows[i]["SubMat"].ToString() == VariablesSave.matCode))
                    {
                        tempMat.Rows[i]["SumScale"] = totalScaleWeight;
                        checkExistMat = true;
                    }
                }
                if(!checkExistMat)
                {
                    tempMat.Rows.Add(VariablesSave.matCode, "" , "", "" , VariablesSave.matExpDate, VariablesSave.matLotNo, totalScaleWeight, "");
                }
            }
            else
            {
                tempMat.Rows.Add(VariablesSave.matCode, "", "", "", VariablesSave.matExpDate, VariablesSave.matLotNo, totalScaleWeight, "");
            }
            tempMatCode = VariablesSave.matCode;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (scaleTimes == 1)
            {
                dataIn = serialPort1.ReadExisting().Replace("kg", "").Trim();
                //Problem about scale latency --> Config scale mode --> HOLD mode 0 --> Kinda ok when test multiple time ( must wait for COM port to finalizing conneection )
                this.Invoke(new EventHandler(showData)); 
            }
        }

        private void btOpen_Click(object sender, EventArgs e) //Open COM port to scale
        {
            try
            {
                serialPort1.PortName = cbComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cbDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbParityBits.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
                if (serialPort1.IsOpen)
                {
                    if (btOpen.Enabled)
                    {
                        if (progressBar1.Value == 100)
                        {
                            btOpen.Enabled = false;
                            btClose.Enabled = true;
                        }
                        else
                        {
                            btOpen.Enabled = true;
                            btClose.Enabled = false;
                        }
                    }
                    else
                    {
                        btClose.Enabled = false;
                    }
                    cbComPort.Enabled = false;

                }
                txtQR.Focus();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtQR.Focus();
        }

        private void btClose_Click(object sender, EventArgs e) //Close COM port to scale
        {
            if (!String.IsNullOrEmpty(cbComPort.Text))
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    progressBar1.Value = 0;
                }
                if (btClose.Enabled)
                {
                    btOpen.Enabled = true;
                    btClose.Enabled = false;
                }
                else
                {
                    btOpen.Enabled = false;
                }
                cbComPort.Enabled = true;
            }
            txtQR.Focus();
        }

        private void btn_portRefresh_Click(object sender, EventArgs e) //Refresh COM port list
        {
            cbComPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                if (!btOpen.Enabled)
                {
                    btOpen.Enabled = true;
                }
            }
            cbComPort.Enabled = true;
            txtQR.Focus();
        }
        #endregion


        #region QR scan logic / Main logic / Event logic
        public bool checkExistMatOrder (string jobOrdUUID) // Check if Job order have Import material order
        {
            VariablesSave.ResetJobOrdMat();
            ComboBox cbx_checkExMat = new ComboBox();
            sqlMesPlanningExcutionCon sqlMesPlanning = new sqlMesPlanningExcutionCon();
            StringBuilder getAllMatOrdUUID = new StringBuilder();
            getAllMatOrdUUID.Append(@" SELECT DISTINCT UUID FROM job_order_material
 WHERE job_order_uuid = '" + jobOrdUUID + "' AND delete_flag = '0'");
            sqlMesPlanning.getComboBoxData(getAllMatOrdUUID.ToString(), ref cbx_checkExMat);
            if (cbx_checkExMat.Items.Count > 0)
            {
                //If job order exist material orders --> Save all uuid of job_order_material to later update task --> return true
                string tempMatOrdUUIDs = "";
                for (int i = 0; i < cbx_checkExMat.Items.Count; i++)
                {
                    if (i == 0)
                    {
                        tempMatOrdUUIDs = cbx_checkExMat.Items[i].ToString();
                    }
                    else
                    {
                        tempMatOrdUUIDs = tempMatOrdUUIDs + ";" + cbx_checkExMat.Items[i].ToString();
                    }
                }
                VariablesSave.MatOrder = tempMatOrdUUIDs.Split(';');
                return true;
                
            }
            else
            {
                //If nothing exist --> Not save --> return false
                return false;
            }
        }

        private void txtQR_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (e.KeyChar == (char)13)
            {
                if (serialPort1.IsOpen) // Also check scale connection when scan QR code
                {
                    string QRtext = txtQR.Text;
                    txtQR.Text = null;
                    string[] matCode = null;
                    if (!String.IsNullOrEmpty(QRtext))
                    {
                        matCode = QRtext.Split(';');
                        //
                        //Begin check logic to see if QR code just scan is material QR or Employee QR or else ...
                        //
                        if (QRtext.Substring(0, 1) == "s" && matCode[0] != "setting")
                        {
                            if (!String.IsNullOrEmpty(matCode[1]))
                            {
                                if (!isLoad2DTGV)
                                {
                                    lb_matCode.Text = matCode[1];
                                    DialogResult dialogResultConfirmMatCode = MessageBox.Show("Use \"" + matCode[1] + "\" material code to find oders ?", "", MessageBoxButtons.OKCancel);
                                    if (dialogResultConfirmMatCode == DialogResult.OK)
                                    {
                                        sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
                                        dtgv_chooseWO.Enabled = true;
                                        ComboBox cbxWOUUID_ = new ComboBox();
                                        StringBuilder sqlGetWOfromMatCode = new StringBuilder();
                                        sqlGetWOfromMatCode.Append(@"SELECT DISTINCT a.work_order_uuid 
 FROM work_order_material AS a
 JOIN work_order_process AS b ON a.work_order_uuid = b.work_order_uuid
 WHERE (b.dispatch_quantity - b.finish_quantity) > 0 
 AND a.delete_flag = '0' AND b.delete_flag = '0'
 AND a.material_no LIKE '" + matCode[1].Trim() + "'");
                                        sqlMesPlanningExcution.getComboBoxData(sqlGetWOfromMatCode.ToString(), ref cbxWOUUID_);
                                        if (cbxWOUUID_.Items.Count > 0)
                                        {
                                            for (int i = 0; i < cbxWOUUID_.Items.Count; i++)
                                            {
                                                StringBuilder sqlGetDTGVData = new StringBuilder();
                                                sqlGetDTGVData.Append(@"SELECT c.uuid AS jobOrdUUID, a.order_uuid AS ID,a.order_no AS orderNo, c.job_no AS jobNo, a.product_no AS prodNo, c.job_quantity AS orderQty, c.actual_finish_qty AS finishQty, c.create_date AS createDate 
 FROM work_order AS a
 JOIN work_order_process AS b ON a.order_uuid = b.work_order_uuid
 JOIN job_order AS c ON a.order_uuid = c.work_order_uuid
 WHERE a.delete_flag = '0' AND b.delete_flag = '0' AND c.delete_flag = '0'
 AND a.order_uuid LIKE '" + cbxWOUUID_.Items[i].ToString() + "' AND a.order_no LIKE '%SEMI%' AND c.job_status < 4");
                                                sqlMesPlanningExcution.sqlDataAdapterFillDatatable(sqlGetDTGVData.ToString(), ref dtgvWOData);
                                            }
                                            if (dtgvWOData.Rows.Count > 0)
                                            {
                                                SupportClass.LoadData2DTGVChooseWO(dtgv_chooseWO, dtgvWOData);
                                                isLoad2DTGV = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Không có đơn bán thành phẩm nào cần làm của mã liệu này!");
                                                isLoad2DTGV = false;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Không có đơn nào có mã liệu này được sinh quản phát đơn!");
                                            isLoad2DTGV = false;
                                        }
                                    }
                                    txtQR.Focus();
                                }
                                else
                                {
                                    //
                                    //
                                    //
                                    //Code xử lý cân liệu // Logic for scaling material 
                                    //
                                    //
                                    //
                                    if (!String.IsNullOrEmpty(VariablesSave.deptUUID))
                                    {
                                        sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
                                        ComboBox cbx_matCodeList = new ComboBox();
                                        StringBuilder getMatCode = new StringBuilder();
                                        getMatCode.Append(@"SELECT DISTINCT material_no FROM mes_planning_excution.work_order_material
where work_order_uuid = '" + VariablesSave.deptUUID + "' AND delete_flag = '0'");
                                        sqlMesPlanningExcution.getComboBoxData(getMatCode.ToString(), ref cbx_matCodeList);
                                        if (isAddSubMat == true)
                                        {
                                            DialogResult dialogResult;
                                            if (!cbx_matCodeList.Items.Contains(matCode[1].Trim()))
                                            {
                                                dialogResult = MessageBox.Show("Mã liệu "+matCode[1]+"vừa quét không có trong đơn làm việc, chắc chắn muốn lưu ?", "Warning", MessageBoxButtons.OKCancel);
                                            }
                                            else
                                            {
                                                dialogResult = MessageBox.Show("Thêm mã liệu "+matCode[1]+" thành liệu phụ ?", "Warning", MessageBoxButtons.OKCancel);
                                            }

                                            if (dialogResult == DialogResult.OK)
                                            {
                                                if (subRowIndex != -1 && tempMat.Rows[subRowIndex]["MatCode"].ToString() != matCode[1].Trim())
                                                {
                                                    tempMat.Rows[subRowIndex]["SubMat"] = matCode[1].Trim();

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Lỗi không bắt được mã hoặc mã trùng với mã liệu chính!");
                                                }
                                                isAddSubMat = false;
                                            }
                                            txtQR.Focus();
                                        }
                                        else
                                        {
                                            bool checkSubMat = false;
                                            if (tempMat.Rows.Count > 0)
                                            {
                                                for (int k = 0; k < tempMat.Rows.Count; k++)
                                                {
                                                    if (tempMat.Rows[k]["SubMat"].ToString() == matCode[1].Trim())
                                                        checkSubMat = true;
                                                }
                                            }
                                            if (cbx_matCodeList.Items.Contains(matCode[1].Trim()) || checkSubMat == true)
                                            {
                                                if (scaleTimes == 0)
                                                {
                                                    int flag = 0;
                                                    lb_matCode.Text = "...";
                                                    txb_searchOrder.Text = "";
                                                    dtgv_chooseWO.DataSource = null;
                                                    dtgv_chooseWO.Enabled = false;
                                                    //Show scanned material info and save to temporary variable
                                                    lb_scanMatCode.Text = matCode[1].Trim();
                                                    VariablesSave.matCode = matCode[1].Trim();
                                                    lb_scanMatExpiryDate.Text = matCode[3].Trim();
                                                    VariablesSave.matExpDate = matCode[3].Trim();
                                                    lb_scanLOTPO.Text = matCode[4].Trim();
                                                    VariablesSave.matLotNo = matCode[4].Trim();
                                                    totalScaleWeight = 0;
                                                    if (tempMat.Rows.Count > 0)
                                                    {
                                                        for (int j = 0; j < tempMat.Rows.Count; j++)
                                                        {
                                                            if (tempMat.Rows[j]["MatCode"].ToString() == matCode[1])
                                                            {
                                                                flag = j;
                                                                totalScaleWeight = double.Parse(tempMat.Rows[j]["SumScale"].ToString());
                                                            }
                                                        }
                                                    }
                                                    
                                                    scaleTimes = 1;
                                                    pnl_scaleWait.BackColor = Color.ForestGreen;
                                                    lb_scaleQty.Text = "0";
                                                    lb_sumScaleQty.Text = "0";
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Mã đã quét vui lòng cân liệu!");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Mã liệu vừa quét không thuộc đơn đã chọn vui lòng thử lại!");
                                            }
                                        }
                                    }
                                    txtQR.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không thể đọc được mã liệu xin hãy quét lại!");
                            }
                            txtQR.Focus();
                        }
                        else
                        {
                            if (matCode[0] != "setting")
                            {
                                string UUID = null;
                                sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
                                if (VariablesSave.empID != null)
                                {
                                    DialogResult dialogResultCheckExistEmp = MessageBox.Show("Bạn có muốn thay đổi nhân viên ? Hiện tại đang là " + VariablesSave.empName, "Cảnh báo", MessageBoxButtons.OKCancel);
                                    if (dialogResultCheckExistEmp == DialogResult.OK)
                                    {
                                        UUID = QRtext.ToString().Substring(1, QRtext.IndexOf(';') - 1);
                                        VariablesSave.empID = UUID;
                                        VariablesSave.empName = sqlMesBaseData.sqlExecuteScalarString("select name from employee_info where uuid = '" + UUID.Trim() + "'");
                                        VariablesSave.empCode = sqlMesBaseData.sqlExecuteScalarString("select code from employee_info where uuid = '" + UUID.Trim() + "'");
                                    }
                                }
                                else
                                {
                                    UUID = QRtext.ToString().Substring(1, QRtext.IndexOf(';') - 1);
                                    VariablesSave.empID = UUID;
                                    VariablesSave.empName = sqlMesBaseData.sqlExecuteScalarString("select name from employee_info where uuid = '" + UUID.Trim() + "'");
                                    VariablesSave.empCode = sqlMesBaseData.sqlExecuteScalarString("select code from employee_info where uuid = '" + UUID.Trim() + "'");
                                }
                                lb_empCode.Text = VariablesSave.empCode;
                                lb_empName.Text = VariablesSave.empName;
                            }
                            else
                            {
                                //MessageBox
                            }
                            txtQR.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể đọc được mã QR xin hãy kiểm tra USB port và quét lại!");
                    }
                    txtQR.Focus();
                }
                else
                {
                    MessageBox.Show("Vui lòng kết nối cân điện tử!");
                }
            }
            txtQR.Focus();
        }

        /// <summary>
        /// Important logic (Save MES button click, Select orders, ... )
        /// </summary>
        #region Important event logic 

        private void dtgv_chooseWO_CellClick(object sender, DataGridViewCellEventArgs e) //Select job order
        {
            if (dtgv_chooseWO.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgv_chooseWO.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgv_chooseWO.Rows[selectedrowindex];
                VariablesSave.deptUUID = Convert.ToString(selectedRow.Cells["ID"].Value);
                VariablesSave.JobOrdUUID = Convert.ToString(selectedRow.Cells["jobOrdUUID"].Value);
                lb_erpNo.Text = Convert.ToString(selectedRow.Cells["orderNo"].Value);
                lb_jobNo.Text = Convert.ToString(selectedRow.Cells["jobNo"].Value);
                lb_finishQty.Text = Convert.ToString(selectedRow.Cells["finishQty"].Value);
                lb_prodNo.Text = Convert.ToString(selectedRow.Cells["prodNo"].Value);
                lb_createDate.Text = Convert.ToString(selectedRow.Cells["createDate"].Value);
                lb_orderQty.Text = Convert.ToString(selectedRow.Cells["orderQty"].Value);
            }
            txtQR.Focus();
        }

        private void txb_searchOrder_KeyPress(object sender, KeyPressEventArgs e) //Search in result datatable when scan material QR
        {
            if (e.KeyChar == (char)13)
            {
                this.dtgv_chooseWO.ClearSelection();
                if (txb_searchOrder.Text.Trim() != "")
                {
                    DataTable dt = new DataTable();
                    string selectExpression = "orderNo LIKE '%" + txb_searchOrder.Text.Trim() + "%' OR jobNo like '%" + txb_searchOrder.Text.Trim() + "%' OR prodNo like '%" + txb_searchOrder.Text.Trim() + "%'";
                    dtgv_chooseWO.DataSource = null;
                    if (dtgvWOData.Rows.Count > 0)
                    {
                        DataRow[] rows = dtgvWOData.Select(selectExpression);
                        if (rows.Count() > 0)
                        {
                            dt = rows.CopyToDataTable();
                            SupportClass.LoadData2DTGVChooseWO(dtgv_chooseWO, dt);
                        }
                    }
                }
                else
                {
                    SupportClass.LoadData2DTGVChooseWO(dtgv_chooseWO, dtgvWOData);
                }
                txtQR.Focus();
            }
        }

        private void dtgv_allScannedMat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0) // Lưu cột button = index 0 do thêm = hard code :v 
                {
                    subRowIndex = e.RowIndex;
                    isAddSubMat = true;
                    MessageBox.Show("Mã liệu quét tiếp theo sẽ được lưu thành liệu phụ!");
                }
                if (e.ColumnIndex == 1) // Lưu cột button = index 1 do thêm = hard code :v 
                {
                    DataRow dr = tempMat.Rows[e.RowIndex];
                    dr.Delete();
                    tempMat.AcceptChanges();
                    SupportClass.LoadData2DTGVScannedMat(dtgv_allScannedMat, tempMat);
                }
                if (e.ColumnIndex == 3) // 2 3 4 5 ... 0 1 --> thứ tự cột khi thêm = hard code
                {
                    DialogResult dialogResult = MessageBox.Show("Xóa thông tin liệu phụ ?", "Warning", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        tempMat.Rows[e.RowIndex]["SubMat"] = "";
                        SupportClass.LoadData2DTGVScannedMat(dtgv_allScannedMat, tempMat);
                    }
                }
            }
            txtQR.Focus();
        }

        private void btn_save2MES_Click(object sender, EventArgs e)
        {
            //Call save logic in UploadMain.cs
            bool isReadyToSave = true;
            if (String.IsNullOrEmpty(VariablesSave.replenishmentType))
            {
                MessageBox.Show("Hãy chọn loại bổ sung vật liệu trước khi lưu!");
                isReadyToSave = false;
            }
            if (tempMat.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nguyên liệu để lưu hãy tiến hành quét và cân liệu trước!");
                isReadyToSave = false;
            }
            if (String.IsNullOrEmpty(VariablesSave.empCode))
            {
                MessageBox.Show("Xin hãy quét code nhân viên!");
                isReadyToSave = false;
            }
            if (isReadyToSave) //isReadyToSave true --> Save to MES.
            {
                UploadMain.Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //Save logic in UploadMain.cs
                UploadMain.transactionSupportUploadData(tempMat);
                //Save mail logic
            }
            txtQR.Focus();
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if (tempMat.Rows.Count > 0)
            {
                for (int i = 0; i < tempMat.Rows.Count; i++)
                {
                    if (tempMat.Rows[i]["MatCode"].ToString() == tempMatCode || tempMat.Rows[i]["SubMat"].ToString() == tempMatCode)
                    {
                        tempMat.Rows[i]["SumScale"] = tempScaleQty;
                    }
                }
            }
            txtQR.Focus();
        }

        private void cbx_chooseReplenishmentType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch(cbx_chooseReplenishmentType.SelectedIndex)
            {
                case 0:
                    VariablesSave.replenishmentType = "领料";
                    txtQR.Focus();
                    break;
                case 1:
                    VariablesSave.replenishmentType = "补料";
                    txtQR.Focus();
                    break;
                case 2:
                    VariablesSave.replenishmentType = "退料"; 
                    txtQR.Focus();
                    break;
                default:
                    VariablesSave.replenishmentType = null;
                    txtQR.Focus();
                    break;
            }

            txtQR.Focus();
        }
        #endregion

        private void btn_reselectWO_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cảnh báo", "Bạn có muốn chọn lại đơn khác và xóa các dữ liệu đã cân?", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                //label quét liệu lần đầu
                lb_matCode.Text = "...";
                isLoad2DTGV = false; // khởi tạo lại để cho quét liệu tìm đơn
                dtgv_chooseWO.DataSource = null;
                dtgv_chooseWO.Enabled = false;
                //Nếu chỉ clear() thì vẫn còn column ==> bug ==> nên tạo thành table mới 
                dtgvWOData = new DataTable();
                tempMat = new DataTable();
                addTempMatColumn();
                this.dtgv_allScannedMat.DataSource = tempMat;

                VariablesSave.ResetDept();
                VariablesSave.ResetMaterial();
                VariablesSave.ResetJobOrdMat();
                VariablesSave.ResetMaterial();
                
                //Các label lúc chọn liệu
                lb_erpNo.Text = "...";
                lb_jobNo.Text = "...";
                lb_prodNo.Text = "...";
                lb_createDate.Text = "...";
                lb_finishQty.Text = "...";
                lb_orderQty.Text = "...";

                //Các label lúc cân liệu
                lb_scanMatCode.Text = "...";
                lb_scanMatExpiryDate.Text = "...";
                lb_scanLOTPO.Text = "...";
                lb_scaleQty.Text = "0";
                lb_sumScaleQty.Text = "0";

                scaleTimes = 0;
                pnl_scaleWait.BackColor = Color.Black;
                cbx_chooseReplenishmentType.SelectedIndex = -1;
            }
            txtQR.Text = null;
            txtQR.Focus();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            VariablesSave.ResetEmployee();
            VariablesSave.ResetDept();
            VariablesSave.ResetMaterial();
            this.Dispose();
        }
        private void cbComPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtQR.Focus();
            }
        }
        private void cbBaudRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtQR.Focus();
            }
        }
        private void cbDataBits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtQR.Focus();
            }
        }
        private void cbStopBits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtQR.Focus();
            }
        }
        private void cbParityBits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtQR.Focus();
            }
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            txtQR.Focus();
        }
        private void txb_searchOrder_TextChanged(object sender, EventArgs e)
        {
            if (txb_searchOrder.Text.Trim() == "")
            {
                SupportClass.LoadData2DTGVChooseWO(dtgv_chooseWO, dtgvWOData);
                txtQR.Focus();
            }
        }
        #endregion
    }
}
