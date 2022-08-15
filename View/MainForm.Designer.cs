
namespace MaterialScale2MES
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtQR = new System.Windows.Forms.TextBox();
            this.dtgv_chooseWO = new System.Windows.Forms.DataGridView();
            this.lb_empCode = new System.Windows.Forms.Label();
            this.lb_empName = new System.Windows.Forms.Label();
            this.lb_lbEmpCode = new System.Windows.Forms.Label();
            this.lb_lbEmpName = new System.Windows.Forms.Label();
            this.gbx_chooseWO = new System.Windows.Forms.GroupBox();
            this.txb_searchOrder = new System.Windows.Forms.TextBox();
            this.btn_reselectWO = new System.Windows.Forms.Button();
            this.lb_matCode = new System.Windows.Forms.Label();
            this.lb_lbMatCode = new System.Windows.Forms.Label();
            this.lb_lbChooseWOInstruction = new System.Windows.Forms.Label();
            this.gbx_informationWO = new System.Windows.Forms.GroupBox();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.pnl_scaleWait = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_lbScaleQuantity = new System.Windows.Forms.Label();
            this.lb_lbSumScaleQuantity = new System.Windows.Forms.Label();
            this.lb_sumScaleQty = new System.Windows.Forms.Label();
            this.lb_scaleQty = new System.Windows.Forms.Label();
            this.lb_finishQty = new System.Windows.Forms.Label();
            this.lb_lbFinishQuantity = new System.Windows.Forms.Label();
            this.lb_scanLOTPO = new System.Windows.Forms.Label();
            this.lb_scanMatExpiryDate = new System.Windows.Forms.Label();
            this.lb_scanMatCode = new System.Windows.Forms.Label();
            this.btn_save2MES = new System.Windows.Forms.Button();
            this.lb_lbLOTPO = new System.Windows.Forms.Label();
            this.lb_lbExpiryDate = new System.Windows.Forms.Label();
            this.lb_lbScanMaterialCode = new System.Windows.Forms.Label();
            this.dtgv_allScannedMat = new System.Windows.Forms.DataGridView();
            this.lb_createDate = new System.Windows.Forms.Label();
            this.lb_lbCreateDate = new System.Windows.Forms.Label();
            this.lb_orderQty = new System.Windows.Forms.Label();
            this.lb_prodNo = new System.Windows.Forms.Label();
            this.lb_jobNo = new System.Windows.Forms.Label();
            this.lb_erpNo = new System.Windows.Forms.Label();
            this.lb_lbOrderQty = new System.Windows.Forms.Label();
            this.lb_lbProdNo = new System.Windows.Forms.Label();
            this.lb_lbJobNo = new System.Windows.Forms.Label();
            this.lb_lbERPNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_portRefresh = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbParityBits = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbx_chooseReplenishmentType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_chooseWO)).BeginInit();
            this.gbx_chooseWO.SuspendLayout();
            this.gbx_informationWO.SuspendLayout();
            this.pnl_scaleWait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_allScannedMat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // txtQR
            // 
            this.txtQR.Location = new System.Drawing.Point(12, 800);
            this.txtQR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(100, 22);
            this.txtQR.TabIndex = 0;
            this.txtQR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQR_KeyPress);
            // 
            // dtgv_chooseWO
            // 
            this.dtgv_chooseWO.AllowUserToAddRows = false;
            this.dtgv_chooseWO.AllowUserToDeleteRows = false;
            this.dtgv_chooseWO.AllowUserToOrderColumns = true;
            this.dtgv_chooseWO.AllowUserToResizeRows = false;
            this.dtgv_chooseWO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv_chooseWO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_chooseWO.Enabled = false;
            this.dtgv_chooseWO.Location = new System.Drawing.Point(7, 103);
            this.dtgv_chooseWO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_chooseWO.MultiSelect = false;
            this.dtgv_chooseWO.Name = "dtgv_chooseWO";
            this.dtgv_chooseWO.ReadOnly = true;
            this.dtgv_chooseWO.RowHeadersVisible = false;
            this.dtgv_chooseWO.RowHeadersWidth = 51;
            this.dtgv_chooseWO.RowTemplate.Height = 24;
            this.dtgv_chooseWO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_chooseWO.Size = new System.Drawing.Size(761, 342);
            this.dtgv_chooseWO.TabIndex = 1;
            this.dtgv_chooseWO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_chooseWO_CellClick);
            // 
            // lb_empCode
            // 
            this.lb_empCode.AutoSize = true;
            this.lb_empCode.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empCode.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_empCode.Location = new System.Drawing.Point(219, 28);
            this.lb_empCode.Name = "lb_empCode";
            this.lb_empCode.Size = new System.Drawing.Size(35, 31);
            this.lb_empCode.TabIndex = 2;
            this.lb_empCode.Text = "...";
            // 
            // lb_empName
            // 
            this.lb_empName.AutoSize = true;
            this.lb_empName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empName.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_empName.Location = new System.Drawing.Point(219, 72);
            this.lb_empName.Name = "lb_empName";
            this.lb_empName.Size = new System.Drawing.Size(35, 31);
            this.lb_empName.TabIndex = 3;
            this.lb_empName.Text = "...";
            // 
            // lb_lbEmpCode
            // 
            this.lb_lbEmpCode.AutoSize = true;
            this.lb_lbEmpCode.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbEmpCode.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_lbEmpCode.Location = new System.Drawing.Point(4, 28);
            this.lb_lbEmpCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbEmpCode.Name = "lb_lbEmpCode";
            this.lb_lbEmpCode.Size = new System.Drawing.Size(191, 31);
            this.lb_lbEmpCode.TabIndex = 5;
            this.lb_lbEmpCode.Text = "Mã nhân viên :";
            // 
            // lb_lbEmpName
            // 
            this.lb_lbEmpName.AutoSize = true;
            this.lb_lbEmpName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbEmpName.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_lbEmpName.Location = new System.Drawing.Point(4, 72);
            this.lb_lbEmpName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbEmpName.Name = "lb_lbEmpName";
            this.lb_lbEmpName.Size = new System.Drawing.Size(197, 31);
            this.lb_lbEmpName.TabIndex = 6;
            this.lb_lbEmpName.Text = "Tên nhân viên :";
            // 
            // gbx_chooseWO
            // 
            this.gbx_chooseWO.Controls.Add(this.txb_searchOrder);
            this.gbx_chooseWO.Controls.Add(this.btn_reselectWO);
            this.gbx_chooseWO.Controls.Add(this.lb_matCode);
            this.gbx_chooseWO.Controls.Add(this.lb_lbMatCode);
            this.gbx_chooseWO.Controls.Add(this.dtgv_chooseWO);
            this.gbx_chooseWO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_chooseWO.Location = new System.Drawing.Point(16, 127);
            this.gbx_chooseWO.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_chooseWO.Name = "gbx_chooseWO";
            this.gbx_chooseWO.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_chooseWO.Size = new System.Drawing.Size(777, 452);
            this.gbx_chooseWO.TabIndex = 7;
            this.gbx_chooseWO.TabStop = false;
            this.gbx_chooseWO.Text = "CHỌN ĐƠN";
            // 
            // txb_searchOrder
            // 
            this.txb_searchOrder.Location = new System.Drawing.Point(533, 68);
            this.txb_searchOrder.Name = "txb_searchOrder";
            this.txb_searchOrder.Size = new System.Drawing.Size(237, 30);
            this.txb_searchOrder.TabIndex = 6;
            this.txb_searchOrder.TextChanged += new System.EventHandler(this.txb_searchOrder_TextChanged);
            this.txb_searchOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_searchOrder_KeyPress);
            // 
            // btn_reselectWO
            // 
            this.btn_reselectWO.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reselectWO.Location = new System.Drawing.Point(348, 22);
            this.btn_reselectWO.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reselectWO.Name = "btn_reselectWO";
            this.btn_reselectWO.Size = new System.Drawing.Size(100, 44);
            this.btn_reselectWO.TabIndex = 5;
            this.btn_reselectWO.Text = "Chọn lại";
            this.btn_reselectWO.UseVisualStyleBackColor = true;
            this.btn_reselectWO.Click += new System.EventHandler(this.btn_reselectWO_Click);
            // 
            // lb_matCode
            // 
            this.lb_matCode.AutoSize = true;
            this.lb_matCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matCode.Location = new System.Drawing.Point(64, 74);
            this.lb_matCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_matCode.Name = "lb_matCode";
            this.lb_matCode.Size = new System.Drawing.Size(30, 26);
            this.lb_matCode.TabIndex = 4;
            this.lb_matCode.Text = "...";
            // 
            // lb_lbMatCode
            // 
            this.lb_lbMatCode.AutoSize = true;
            this.lb_lbMatCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbMatCode.Location = new System.Drawing.Point(15, 33);
            this.lb_lbMatCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbMatCode.Name = "lb_lbMatCode";
            this.lb_lbMatCode.Size = new System.Drawing.Size(311, 23);
            this.lb_lbMatCode.TabIndex = 3;
            this.lb_lbMatCode.Text = "Các đơn hiện đang tìm theo mã liệu:";
            // 
            // lb_lbChooseWOInstruction
            // 
            this.lb_lbChooseWOInstruction.AutoSize = true;
            this.lb_lbChooseWOInstruction.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbChooseWOInstruction.ForeColor = System.Drawing.Color.Red;
            this.lb_lbChooseWOInstruction.Location = new System.Drawing.Point(1079, 9);
            this.lb_lbChooseWOInstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbChooseWOInstruction.Name = "lb_lbChooseWOInstruction";
            this.lb_lbChooseWOInstruction.Size = new System.Drawing.Size(553, 46);
            this.lb_lbChooseWOInstruction.TabIndex = 2;
            this.lb_lbChooseWOInstruction.Text = "Vui lòng kết nối cân rồi quét mã QR của vật liệu để hiện các đơn \r\nbán thành phẩm" +
    " được sinh quản phát và có số lượng cần làm.";
            // 
            // gbx_informationWO
            // 
            this.gbx_informationWO.Controls.Add(this.cbx_chooseReplenishmentType);
            this.gbx_informationWO.Controls.Add(this.btn_Undo);
            this.gbx_informationWO.Controls.Add(this.pnl_scaleWait);
            this.gbx_informationWO.Controls.Add(this.lb_finishQty);
            this.gbx_informationWO.Controls.Add(this.lb_lbFinishQuantity);
            this.gbx_informationWO.Controls.Add(this.lb_scanLOTPO);
            this.gbx_informationWO.Controls.Add(this.lb_scanMatExpiryDate);
            this.gbx_informationWO.Controls.Add(this.lb_scanMatCode);
            this.gbx_informationWO.Controls.Add(this.btn_save2MES);
            this.gbx_informationWO.Controls.Add(this.lb_lbLOTPO);
            this.gbx_informationWO.Controls.Add(this.lb_lbExpiryDate);
            this.gbx_informationWO.Controls.Add(this.lb_lbScanMaterialCode);
            this.gbx_informationWO.Controls.Add(this.dtgv_allScannedMat);
            this.gbx_informationWO.Controls.Add(this.lb_createDate);
            this.gbx_informationWO.Controls.Add(this.lb_lbCreateDate);
            this.gbx_informationWO.Controls.Add(this.lb_orderQty);
            this.gbx_informationWO.Controls.Add(this.lb_prodNo);
            this.gbx_informationWO.Controls.Add(this.lb_jobNo);
            this.gbx_informationWO.Controls.Add(this.lb_erpNo);
            this.gbx_informationWO.Controls.Add(this.lb_lbOrderQty);
            this.gbx_informationWO.Controls.Add(this.lb_lbProdNo);
            this.gbx_informationWO.Controls.Add(this.lb_lbJobNo);
            this.gbx_informationWO.Controls.Add(this.lb_lbERPNo);
            this.gbx_informationWO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_informationWO.Location = new System.Drawing.Point(801, 127);
            this.gbx_informationWO.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_informationWO.Name = "gbx_informationWO";
            this.gbx_informationWO.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_informationWO.Size = new System.Drawing.Size(868, 708);
            this.gbx_informationWO.TabIndex = 8;
            this.gbx_informationWO.TabStop = false;
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackColor = System.Drawing.Color.Red;
            this.btn_Undo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Undo.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Undo.Location = new System.Drawing.Point(727, 429);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(134, 43);
            this.btn_Undo.TabIndex = 34;
            this.btn_Undo.Text = "UNDO";
            this.btn_Undo.UseVisualStyleBackColor = false;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // pnl_scaleWait
            // 
            this.pnl_scaleWait.BackColor = System.Drawing.Color.Black;
            this.pnl_scaleWait.Controls.Add(this.label7);
            this.pnl_scaleWait.Controls.Add(this.label6);
            this.pnl_scaleWait.Controls.Add(this.lb_lbScaleQuantity);
            this.pnl_scaleWait.Controls.Add(this.lb_lbSumScaleQuantity);
            this.pnl_scaleWait.Controls.Add(this.lb_sumScaleQty);
            this.pnl_scaleWait.Controls.Add(this.lb_scaleQty);
            this.pnl_scaleWait.Location = new System.Drawing.Point(8, 566);
            this.pnl_scaleWait.Name = "pnl_scaleWait";
            this.pnl_scaleWait.Size = new System.Drawing.Size(852, 129);
            this.pnl_scaleWait.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(728, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 26);
            this.label7.TabIndex = 32;
            this.label7.Text = "KG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(269, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 26);
            this.label6.TabIndex = 31;
            this.label6.Text = "KG";
            // 
            // lb_lbScaleQuantity
            // 
            this.lb_lbScaleQuantity.AutoSize = true;
            this.lb_lbScaleQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbScaleQuantity.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_lbScaleQuantity.Location = new System.Drawing.Point(16, 19);
            this.lb_lbScaleQuantity.Name = "lb_lbScaleQuantity";
            this.lb_lbScaleQuantity.Size = new System.Drawing.Size(292, 23);
            this.lb_lbScaleQuantity.TabIndex = 19;
            this.lb_lbScaleQuantity.Text = "Khối lượng thực tế vừa cân được:";
            // 
            // lb_lbSumScaleQuantity
            // 
            this.lb_lbSumScaleQuantity.AutoSize = true;
            this.lb_lbSumScaleQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbSumScaleQuantity.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_lbSumScaleQuantity.Location = new System.Drawing.Point(411, 19);
            this.lb_lbSumScaleQuantity.Name = "lb_lbSumScaleQuantity";
            this.lb_lbSumScaleQuantity.Size = new System.Drawing.Size(317, 23);
            this.lb_lbSumScaleQuantity.TabIndex = 21;
            this.lb_lbSumScaleQuantity.Text = "Tổng khối lượng thực tế sau khi cân:";
            // 
            // lb_sumScaleQty
            // 
            this.lb_sumScaleQty.AutoSize = true;
            this.lb_sumScaleQty.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sumScaleQty.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_sumScaleQty.Location = new System.Drawing.Point(482, 61);
            this.lb_sumScaleQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sumScaleQty.Name = "lb_sumScaleQty";
            this.lb_sumScaleQty.Size = new System.Drawing.Size(48, 55);
            this.lb_sumScaleQty.TabIndex = 29;
            this.lb_sumScaleQty.Text = "0";
            // 
            // lb_scaleQty
            // 
            this.lb_scaleQty.AutoSize = true;
            this.lb_scaleQty.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_scaleQty.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_scaleQty.Location = new System.Drawing.Point(50, 61);
            this.lb_scaleQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_scaleQty.Name = "lb_scaleQty";
            this.lb_scaleQty.Size = new System.Drawing.Size(48, 55);
            this.lb_scaleQty.TabIndex = 28;
            this.lb_scaleQty.Text = "0";
            // 
            // lb_finishQty
            // 
            this.lb_finishQty.AutoSize = true;
            this.lb_finishQty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_finishQty.Location = new System.Drawing.Point(187, 149);
            this.lb_finishQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_finishQty.Name = "lb_finishQty";
            this.lb_finishQty.Size = new System.Drawing.Size(25, 23);
            this.lb_finishQty.TabIndex = 32;
            this.lb_finishQty.Text = "...";
            // 
            // lb_lbFinishQuantity
            // 
            this.lb_lbFinishQuantity.AutoSize = true;
            this.lb_lbFinishQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbFinishQuantity.Location = new System.Drawing.Point(19, 150);
            this.lb_lbFinishQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbFinishQuantity.Name = "lb_lbFinishQuantity";
            this.lb_lbFinishQuantity.Size = new System.Drawing.Size(151, 22);
            this.lb_lbFinishQuantity.TabIndex = 31;
            this.lb_lbFinishQuantity.Text = "Số lượng đã làm :";
            // 
            // lb_scanLOTPO
            // 
            this.lb_scanLOTPO.AutoSize = true;
            this.lb_scanLOTPO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_scanLOTPO.Location = new System.Drawing.Point(479, 529);
            this.lb_scanLOTPO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_scanLOTPO.Name = "lb_scanLOTPO";
            this.lb_scanLOTPO.Size = new System.Drawing.Size(25, 23);
            this.lb_scanLOTPO.TabIndex = 26;
            this.lb_scanLOTPO.Text = "...";
            // 
            // lb_scanMatExpiryDate
            // 
            this.lb_scanMatExpiryDate.AutoSize = true;
            this.lb_scanMatExpiryDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_scanMatExpiryDate.Location = new System.Drawing.Point(148, 529);
            this.lb_scanMatExpiryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_scanMatExpiryDate.Name = "lb_scanMatExpiryDate";
            this.lb_scanMatExpiryDate.Size = new System.Drawing.Size(25, 23);
            this.lb_scanMatExpiryDate.TabIndex = 25;
            this.lb_scanMatExpiryDate.Text = "...";
            // 
            // lb_scanMatCode
            // 
            this.lb_scanMatCode.AutoSize = true;
            this.lb_scanMatCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_scanMatCode.Location = new System.Drawing.Point(186, 493);
            this.lb_scanMatCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_scanMatCode.Name = "lb_scanMatCode";
            this.lb_scanMatCode.Size = new System.Drawing.Size(25, 23);
            this.lb_scanMatCode.TabIndex = 24;
            this.lb_scanMatCode.Text = "...";
            // 
            // btn_save2MES
            // 
            this.btn_save2MES.BackColor = System.Drawing.Color.Yellow;
            this.btn_save2MES.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save2MES.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_save2MES.Location = new System.Drawing.Point(716, 114);
            this.btn_save2MES.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save2MES.Name = "btn_save2MES";
            this.btn_save2MES.Size = new System.Drawing.Size(144, 66);
            this.btn_save2MES.TabIndex = 7;
            this.btn_save2MES.Text = "LƯU MES";
            this.btn_save2MES.UseVisualStyleBackColor = false;
            this.btn_save2MES.Click += new System.EventHandler(this.btn_save2MES_Click);
            // 
            // lb_lbLOTPO
            // 
            this.lb_lbLOTPO.AutoSize = true;
            this.lb_lbLOTPO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbLOTPO.Location = new System.Drawing.Point(362, 530);
            this.lb_lbLOTPO.Name = "lb_lbLOTPO";
            this.lb_lbLOTPO.Size = new System.Drawing.Size(110, 22);
            this.lb_lbLOTPO.TabIndex = 23;
            this.lb_lbLOTPO.Text = "Số LOT/PO:";
            // 
            // lb_lbExpiryDate
            // 
            this.lb_lbExpiryDate.AutoSize = true;
            this.lb_lbExpiryDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbExpiryDate.Location = new System.Drawing.Point(24, 530);
            this.lb_lbExpiryDate.Name = "lb_lbExpiryDate";
            this.lb_lbExpiryDate.Size = new System.Drawing.Size(117, 22);
            this.lb_lbExpiryDate.TabIndex = 22;
            this.lb_lbExpiryDate.Text = "Ngày hết hạn:";
            // 
            // lb_lbScanMaterialCode
            // 
            this.lb_lbScanMaterialCode.AutoSize = true;
            this.lb_lbScanMaterialCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbScanMaterialCode.Location = new System.Drawing.Point(22, 494);
            this.lb_lbScanMaterialCode.Name = "lb_lbScanMaterialCode";
            this.lb_lbScanMaterialCode.Size = new System.Drawing.Size(157, 22);
            this.lb_lbScanMaterialCode.TabIndex = 17;
            this.lb_lbScanMaterialCode.Text = "Mã liệu đang quét:";
            // 
            // dtgv_allScannedMat
            // 
            this.dtgv_allScannedMat.AllowUserToAddRows = false;
            this.dtgv_allScannedMat.AllowUserToDeleteRows = false;
            this.dtgv_allScannedMat.AllowUserToOrderColumns = true;
            this.dtgv_allScannedMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_allScannedMat.Location = new System.Drawing.Point(8, 188);
            this.dtgv_allScannedMat.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_allScannedMat.MultiSelect = false;
            this.dtgv_allScannedMat.Name = "dtgv_allScannedMat";
            this.dtgv_allScannedMat.ReadOnly = true;
            this.dtgv_allScannedMat.RowHeadersVisible = false;
            this.dtgv_allScannedMat.RowHeadersWidth = 51;
            this.dtgv_allScannedMat.Size = new System.Drawing.Size(852, 234);
            this.dtgv_allScannedMat.TabIndex = 16;
            this.dtgv_allScannedMat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_allScannedMat_CellContentClick);
            // 
            // lb_createDate
            // 
            this.lb_createDate.AutoSize = true;
            this.lb_createDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_createDate.Location = new System.Drawing.Point(438, 112);
            this.lb_createDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_createDate.Name = "lb_createDate";
            this.lb_createDate.Size = new System.Drawing.Size(25, 23);
            this.lb_createDate.TabIndex = 15;
            this.lb_createDate.Text = "...";
            // 
            // lb_lbCreateDate
            // 
            this.lb_lbCreateDate.AutoSize = true;
            this.lb_lbCreateDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbCreateDate.Location = new System.Drawing.Point(339, 113);
            this.lb_lbCreateDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbCreateDate.Name = "lb_lbCreateDate";
            this.lb_lbCreateDate.Size = new System.Drawing.Size(91, 22);
            this.lb_lbCreateDate.TabIndex = 14;
            this.lb_lbCreateDate.Text = "Ngày tạo :";
            // 
            // lb_orderQty
            // 
            this.lb_orderQty.AutoSize = true;
            this.lb_orderQty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_orderQty.Location = new System.Drawing.Point(187, 112);
            this.lb_orderQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_orderQty.Name = "lb_orderQty";
            this.lb_orderQty.Size = new System.Drawing.Size(25, 23);
            this.lb_orderQty.TabIndex = 12;
            this.lb_orderQty.Text = "...";
            // 
            // lb_prodNo
            // 
            this.lb_prodNo.AutoSize = true;
            this.lb_prodNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prodNo.Location = new System.Drawing.Point(200, 71);
            this.lb_prodNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_prodNo.Name = "lb_prodNo";
            this.lb_prodNo.Size = new System.Drawing.Size(25, 23);
            this.lb_prodNo.TabIndex = 10;
            this.lb_prodNo.Text = "...";
            // 
            // lb_jobNo
            // 
            this.lb_jobNo.AutoSize = true;
            this.lb_jobNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_jobNo.Location = new System.Drawing.Point(529, 32);
            this.lb_jobNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_jobNo.Name = "lb_jobNo";
            this.lb_jobNo.Size = new System.Drawing.Size(25, 23);
            this.lb_jobNo.TabIndex = 8;
            this.lb_jobNo.Text = "...";
            // 
            // lb_erpNo
            // 
            this.lb_erpNo.AutoSize = true;
            this.lb_erpNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_erpNo.Location = new System.Drawing.Point(114, 32);
            this.lb_erpNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_erpNo.Name = "lb_erpNo";
            this.lb_erpNo.Size = new System.Drawing.Size(25, 23);
            this.lb_erpNo.TabIndex = 7;
            this.lb_erpNo.Text = "...";
            // 
            // lb_lbOrderQty
            // 
            this.lb_lbOrderQty.AutoSize = true;
            this.lb_lbOrderQty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbOrderQty.Location = new System.Drawing.Point(19, 113);
            this.lb_lbOrderQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbOrderQty.Name = "lb_lbOrderQty";
            this.lb_lbOrderQty.Size = new System.Drawing.Size(160, 22);
            this.lb_lbOrderQty.TabIndex = 5;
            this.lb_lbOrderQty.Text = "Số lượng của đơn :";
            // 
            // lb_lbProdNo
            // 
            this.lb_lbProdNo.AutoSize = true;
            this.lb_lbProdNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbProdNo.Location = new System.Drawing.Point(19, 72);
            this.lb_lbProdNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbProdNo.Name = "lb_lbProdNo";
            this.lb_lbProdNo.Size = new System.Drawing.Size(173, 22);
            this.lb_lbProdNo.TabIndex = 4;
            this.lb_lbProdNo.Text = "Mã bán thành phẩm :";
            // 
            // lb_lbJobNo
            // 
            this.lb_lbJobNo.AutoSize = true;
            this.lb_lbJobNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbJobNo.Location = new System.Drawing.Point(439, 34);
            this.lb_lbJobNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbJobNo.Name = "lb_lbJobNo";
            this.lb_lbJobNo.Size = new System.Drawing.Size(82, 22);
            this.lb_lbJobNo.TabIndex = 2;
            this.lb_lbJobNo.Text = "Mã đơn :";
            // 
            // lb_lbERPNo
            // 
            this.lb_lbERPNo.AutoSize = true;
            this.lb_lbERPNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbERPNo.Location = new System.Drawing.Point(19, 33);
            this.lb_lbERPNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbERPNo.Name = "lb_lbERPNo";
            this.lb_lbERPNo.Size = new System.Drawing.Size(87, 22);
            this.lb_lbERPNo.TabIndex = 0;
            this.lb_lbERPNo.Text = "Mã ERP :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_portRefresh);
            this.groupBox1.Controls.Add(this.btClose);
            this.groupBox1.Controls.Add(this.btOpen);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(16, 586);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(777, 249);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btn_portRefresh
            // 
            this.btn_portRefresh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_portRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_portRefresh.Location = new System.Drawing.Point(409, 22);
            this.btn_portRefresh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_portRefresh.Name = "btn_portRefresh";
            this.btn_portRefresh.Size = new System.Drawing.Size(223, 52);
            this.btn_portRefresh.TabIndex = 8;
            this.btn_portRefresh.Text = "Làm mới cổng vào";
            this.btn_portRefresh.UseVisualStyleBackColor = true;
            this.btn_portRefresh.Click += new System.EventHandler(this.btn_portRefresh_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btClose.Location = new System.Drawing.Point(587, 107);
            this.btClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(157, 52);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Đóng kết nối";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btOpen
            // 
            this.btOpen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btOpen.Location = new System.Drawing.Point(411, 107);
            this.btOpen.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(156, 52);
            this.btOpen.TabIndex = 6;
            this.btOpen.Text = "Kết nối";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar1.Location = new System.Drawing.Point(411, 175);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(333, 28);
            this.progressBar1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbParityBits);
            this.groupBox2.Controls.Add(this.cbStopBits);
            this.groupBox2.Controls.Add(this.cbBaudRate);
            this.groupBox2.Controls.Add(this.cbDataBits);
            this.groupBox2.Controls.Add(this.cbComPort);
            this.groupBox2.Location = new System.Drawing.Point(8, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Size = new System.Drawing.Size(356, 218);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM Port Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(23, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(23, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(23, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "PORT NAME";
            // 
            // cbParityBits
            // 
            this.cbParityBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParityBits.FormattingEnabled = true;
            this.cbParityBits.Items.AddRange(new object[] {
            "None",
            "Old",
            "Even"});
            this.cbParityBits.Location = new System.Drawing.Point(175, 175);
            this.cbParityBits.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbParityBits.Name = "cbParityBits";
            this.cbParityBits.Size = new System.Drawing.Size(160, 24);
            this.cbParityBits.TabIndex = 4;
            this.cbParityBits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbParityBits_KeyPress);
            // 
            // cbStopBits
            // 
            this.cbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbStopBits.Location = new System.Drawing.Point(175, 137);
            this.cbStopBits.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(160, 24);
            this.cbStopBits.TabIndex = 3;
            this.cbStopBits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbStopBits_KeyPress);
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cbBaudRate.Location = new System.Drawing.Point(175, 62);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(160, 24);
            this.cbBaudRate.TabIndex = 2;
            this.cbBaudRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBaudRate_KeyPress);
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(175, 100);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(160, 24);
            this.cbDataBits.TabIndex = 1;
            this.cbDataBits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDataBits_KeyPress);
            // 
            // cbComPort
            // 
            this.cbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(175, 26);
            this.cbComPort.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(160, 24);
            this.cbComPort.TabIndex = 0;
            this.cbComPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbComPort_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Controls.Add(this.lb_lbEmpCode);
            this.panel2.Controls.Add(this.lb_empCode);
            this.panel2.Controls.Add(this.lb_empName);
            this.panel2.Controls.Add(this.lb_lbEmpName);
            this.panel2.Location = new System.Drawing.Point(398, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 127);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaterialScale2MES.Properties.Resources.logoTechlinkFix;
            this.pictureBox1.Location = new System.Drawing.Point(-32, -54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cbx_chooseReplenishmentType
            // 
            this.cbx_chooseReplenishmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_chooseReplenishmentType.FormattingEnabled = true;
            this.cbx_chooseReplenishmentType.Items.AddRange(new object[] {
            "领料 - Picking Material",
            "补料 - Feed Material",
            "退料 - Return Material"});
            this.cbx_chooseReplenishmentType.Location = new System.Drawing.Point(343, 146);
            this.cbx_chooseReplenishmentType.Name = "cbx_chooseReplenishmentType";
            this.cbx_chooseReplenishmentType.Size = new System.Drawing.Size(357, 31);
            this.cbx_chooseReplenishmentType.TabIndex = 35;
            this.cbx_chooseReplenishmentType.SelectionChangeCommitted += new System.EventHandler(this.cbx_chooseReplenishmentType_SelectionChangeCommitted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_informationWO);
            this.Controls.Add(this.lb_lbChooseWOInstruction);
            this.Controls.Add(this.gbx_chooseWO);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtQR);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actual Material Info -- MES system";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_chooseWO)).EndInit();
            this.gbx_chooseWO.ResumeLayout(false);
            this.gbx_chooseWO.PerformLayout();
            this.gbx_informationWO.ResumeLayout(false);
            this.gbx_informationWO.PerformLayout();
            this.pnl_scaleWait.ResumeLayout(false);
            this.pnl_scaleWait.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_allScannedMat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.DataGridView dtgv_chooseWO;
        private System.Windows.Forms.Label lb_empCode;
        private System.Windows.Forms.Label lb_empName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_lbEmpCode;
        private System.Windows.Forms.Label lb_lbEmpName;
        private System.Windows.Forms.GroupBox gbx_chooseWO;
        private System.Windows.Forms.Label lb_lbChooseWOInstruction;
        private System.Windows.Forms.Label lb_matCode;
        private System.Windows.Forms.Label lb_lbMatCode;
        private System.Windows.Forms.GroupBox gbx_informationWO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_portRefresh;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbParityBits;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Button btn_reselectWO;
        private System.Windows.Forms.Label lb_lbERPNo;
        private System.Windows.Forms.Label lb_orderQty;
        private System.Windows.Forms.Label lb_prodNo;
        private System.Windows.Forms.Label lb_jobNo;
        private System.Windows.Forms.Label lb_erpNo;
        private System.Windows.Forms.Label lb_lbOrderQty;
        private System.Windows.Forms.Label lb_lbProdNo;
        private System.Windows.Forms.Label lb_lbJobNo;
        private System.Windows.Forms.Label lb_createDate;
        private System.Windows.Forms.Label lb_lbCreateDate;
        private System.Windows.Forms.DataGridView dtgv_allScannedMat;
        private System.Windows.Forms.TextBox txb_searchOrder;
        private System.Windows.Forms.Button btn_save2MES;
        private System.Windows.Forms.Label lb_lbLOTPO;
        private System.Windows.Forms.Label lb_lbExpiryDate;
        private System.Windows.Forms.Label lb_lbSumScaleQuantity;
        private System.Windows.Forms.Label lb_lbScaleQuantity;
        private System.Windows.Forms.Label lb_lbScanMaterialCode;
        private System.Windows.Forms.Label lb_sumScaleQty;
        private System.Windows.Forms.Label lb_scaleQty;
        private System.Windows.Forms.Label lb_scanLOTPO;
        private System.Windows.Forms.Label lb_scanMatExpiryDate;
        private System.Windows.Forms.Label lb_scanMatCode;
        private System.Windows.Forms.Label lb_finishQty;
        private System.Windows.Forms.Label lb_lbFinishQuantity;
        private System.Windows.Forms.Panel pnl_scaleWait;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.ComboBox cbx_chooseReplenishmentType;
    }
}

