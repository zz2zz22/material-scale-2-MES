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

namespace MaterialScale2MES
{
    public partial class MainForm : Form
    {
        DataTable tempMat = new DataTable();
        string dataIn;
        double totalScaleWeight = 0;
        double totalScanWeight = 0;
        int scaleTimes = 0;
        bool isLoad2DTGV = false;
        public MainForm()
        {
            InitializeComponent();
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
            cbComPort.SelectedIndex = -1;
            cbBaudRate.SelectedIndex = 2;
            cbDataBits.SelectedIndex = 2;
            cbStopBits.SelectedIndex = 0;
            cbParityBits.SelectedIndex = 0;
        }
        //////////
        //////////
        //////////Kết nối với cân / Scale Connect
        //////////
        //////////
        #region ScaleConnect
        private void showData(object sender, EventArgs e)
        {
            double returnValue;
            if (double.TryParse(dataIn, out returnValue))
            {

            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (scaleTimes == 0)
            {
                MessageBox.Show("Xin hãy quét QR liệu trước khi cân!");
            }
            if (scaleTimes == 1)
            {
                dataIn = serialPort1.ReadLine().Replace("kg", "").Trim();
                this.Invoke(new EventHandler(showData));
            } 
        }

        private void btOpen_Click(object sender, EventArgs e)
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
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbComPort.Text))
            {
            }
            else
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

        private void btn_portRefresh_Click(object sender, EventArgs e)
        {
            cbComPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);
            txtQR.Focus();
        }
        #endregion

        //////////
        //////////
        //////////Xử lý quét QR / QR scan logic
        //////////
        //////////
        private void txtQR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string QRtext = txtQR.Text;
                txtQR.Text = null;
                string[] matCode = null;
                if (!String.IsNullOrEmpty(QRtext))
                {
                    matCode = QRtext.Split(';');
                    //Xét QR là mã liệu hay mã nhân viên nếu mã nhân viên thì lưu lên MES
                    if (QRtext.Substring(0, 1) == "s" && matCode[0] != "setting")
                    {
                        if (!String.IsNullOrEmpty(matCode[1]))
                        {
                            lb_matCode.Text = matCode[1]; 
                            if (!isLoad2DTGV)
                            {
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
                                        DataTable dtgvWOData = new DataTable();
                                        for (int i = 0; i < cbxWOUUID_.Items.Count; i++)
                                        {
                                            StringBuilder sqlGetDTGVData = new StringBuilder();
                                            sqlGetDTGVData.Append(@"SELECT a.order_uuid AS ID,a.order_no AS orderNo, a.product_no AS prodNo, a.product_name AS prodName, 
 a.sales_order_no AS saleNo, b.plan_quantity AS orderQty, b.dispatch_quantity AS dispatchQty, b.finish_quantity AS finishQty,
 (b.dispatch_quantity - b.finish_quantity) AS remainQty, a.create_date AS createDate
 FROM work_order AS a
 JOIN work_order_process AS b ON a.order_uuid = b.work_order_uuid
 WHERE a.delete_flag = '0' AND b.delete_flag = '0'
 AND a.order_uuid LIKE '" + cbxWOUUID_.Items[i].ToString() + "' AND a.order_no LIKE '%SEMI%'");
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
                                            isLoad2DTGV = true; // test
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Không có đơn nào có mã liệu này được sinh quản phát đơn!");
                                    }
                                }
                                txtQR.Focus();
                            }
                            else
                            {
                                VariablesSave.matCode = matCode[1].Trim();
                                VariablesSave.matScanQuantity = double.Parse(matCode[2]);
                                VariablesSave.matExpDate = matCode[3];
                                VariablesSave.matLotNo = matCode[4];
                                scaleTimes = 1;
                                MessageBox.Show("Bắt đầu cân liệu");
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
                        if (matCode[0] != "setting" && String.IsNullOrEmpty(matCode[4]))
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
                            }else
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
                            MessageBox.Show("Không thể nhận diện mã!");
                            
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
        }

        private void btn_reselectWO_Click(object sender, EventArgs e)
        {
            lb_matCode.Text = "...";
            isLoad2DTGV = false;
            dtgv_chooseWO.DataSource = null;
            dtgv_chooseWO.Enabled = false;
            txtQR.Focus();
            if (!String.IsNullOrEmpty(VariablesSave.deptUUID))
            {
                lb_orderNo.Text = "";
                lb_matCode.Text = "";
                lb_orderQty.Text = "";
                lb_dispatchQty.Text = "";
                lb_finishQty.Text = "";
                lb_remainQty.Text = "";
            }
            tempMat.Clear();
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

        private void dtgv_chooseWO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_chooseWO.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgv_chooseWO.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgv_chooseWO.Rows[selectedrowindex];
                VariablesSave.deptUUID = Convert.ToString(selectedRow.Cells["ID"].Value);
                lb_orderNo.Text = Convert.ToString(selectedRow.Cells["orderNo"].Value);
                lb_prodCode.Text = Convert.ToString(selectedRow.Cells["prodNo"].Value);
                lb_orderQty.Text = Convert.ToString(selectedRow.Cells["orderQty"].Value);
                lb_dispatchQty.Text = Convert.ToString(selectedRow.Cells["dispatchQty"].Value);
                lb_finishQty.Text = Convert.ToString(selectedRow.Cells["finishQty"].Value);
                lb_remainQty.Text = Convert.ToString(selectedRow.Cells["remainQty"].Value);
            }
        }

        
    }
}
