
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
            this.btn_reselectWO = new System.Windows.Forms.Button();
            this.lb_matCode = new System.Windows.Forms.Label();
            this.lb_lbMatCode = new System.Windows.Forms.Label();
            this.lb_lbChooseWOInstruction = new System.Windows.Forms.Label();
            this.gbx_informationWO = new System.Windows.Forms.GroupBox();
            this.dtgv_allScannedMat = new System.Windows.Forms.DataGridView();
            this.lb_dispatchQty = new System.Windows.Forms.Label();
            this.lb_lbDispatchQuantity = new System.Windows.Forms.Label();
            this.lb_remainQty = new System.Windows.Forms.Label();
            this.lb_finishQty = new System.Windows.Forms.Label();
            this.lb_orderQty = new System.Windows.Forms.Label();
            this.lb_prodCode = new System.Windows.Forms.Label();
            this.lb_orderNo = new System.Windows.Forms.Label();
            this.lb_lbOrderRemainQuantity = new System.Windows.Forms.Label();
            this.lb_lbOrderFinishQty = new System.Windows.Forms.Label();
            this.lb_lbOrderQuantity = new System.Windows.Forms.Label();
            this.lb_lbProdCode = new System.Windows.Forms.Label();
            this.lb_lbOrderNo = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_chooseWO)).BeginInit();
            this.gbx_chooseWO.SuspendLayout();
            this.gbx_informationWO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_allScannedMat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.dtgv_chooseWO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_chooseWO.Enabled = false;
            this.dtgv_chooseWO.Location = new System.Drawing.Point(7, 103);
            this.dtgv_chooseWO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lb_empCode.Location = new System.Drawing.Point(684, 30);
            this.lb_empCode.Name = "lb_empCode";
            this.lb_empCode.Size = new System.Drawing.Size(35, 31);
            this.lb_empCode.TabIndex = 2;
            this.lb_empCode.Text = "...";
            // 
            // lb_empName
            // 
            this.lb_empName.AutoSize = true;
            this.lb_empName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empName.Location = new System.Drawing.Point(684, 74);
            this.lb_empName.Name = "lb_empName";
            this.lb_empName.Size = new System.Drawing.Size(35, 31);
            this.lb_empName.TabIndex = 3;
            this.lb_empName.Text = "...";
            // 
            // lb_lbEmpCode
            // 
            this.lb_lbEmpCode.AutoSize = true;
            this.lb_lbEmpCode.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbEmpCode.Location = new System.Drawing.Point(469, 30);
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
            this.lb_lbEmpName.Location = new System.Drawing.Point(469, 74);
            this.lb_lbEmpName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbEmpName.Name = "lb_lbEmpName";
            this.lb_lbEmpName.Size = new System.Drawing.Size(197, 31);
            this.lb_lbEmpName.TabIndex = 6;
            this.lb_lbEmpName.Text = "Tên nhân viên :";
            // 
            // gbx_chooseWO
            // 
            this.gbx_chooseWO.Controls.Add(this.btn_reselectWO);
            this.gbx_chooseWO.Controls.Add(this.lb_matCode);
            this.gbx_chooseWO.Controls.Add(this.lb_lbMatCode);
            this.gbx_chooseWO.Controls.Add(this.dtgv_chooseWO);
            this.gbx_chooseWO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_chooseWO.Location = new System.Drawing.Point(16, 127);
            this.gbx_chooseWO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_chooseWO.Name = "gbx_chooseWO";
            this.gbx_chooseWO.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_chooseWO.Size = new System.Drawing.Size(777, 452);
            this.gbx_chooseWO.TabIndex = 7;
            this.gbx_chooseWO.TabStop = false;
            this.gbx_chooseWO.Text = "CHỌN ĐƠN";
            // 
            // btn_reselectWO
            // 
            this.btn_reselectWO.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reselectWO.Location = new System.Drawing.Point(668, 33);
            this.btn_reselectWO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.lb_lbChooseWOInstruction.Location = new System.Drawing.Point(1073, 12);
            this.lb_lbChooseWOInstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbChooseWOInstruction.Name = "lb_lbChooseWOInstruction";
            this.lb_lbChooseWOInstruction.Size = new System.Drawing.Size(553, 46);
            this.lb_lbChooseWOInstruction.TabIndex = 2;
            this.lb_lbChooseWOInstruction.Text = "Vui lòng kết nối cân rồi quét mã QR của vật liệu để hiện các đơn \r\nbán thành phẩm" +
    " được sinh quản phát và có số lượng cần làm.";
            // 
            // gbx_informationWO
            // 
            this.gbx_informationWO.Controls.Add(this.dtgv_allScannedMat);
            this.gbx_informationWO.Controls.Add(this.lb_dispatchQty);
            this.gbx_informationWO.Controls.Add(this.lb_lbDispatchQuantity);
            this.gbx_informationWO.Controls.Add(this.lb_remainQty);
            this.gbx_informationWO.Controls.Add(this.lb_finishQty);
            this.gbx_informationWO.Controls.Add(this.lb_orderQty);
            this.gbx_informationWO.Controls.Add(this.lb_prodCode);
            this.gbx_informationWO.Controls.Add(this.lb_orderNo);
            this.gbx_informationWO.Controls.Add(this.lb_lbOrderRemainQuantity);
            this.gbx_informationWO.Controls.Add(this.lb_lbOrderFinishQty);
            this.gbx_informationWO.Controls.Add(this.lb_lbOrderQuantity);
            this.gbx_informationWO.Controls.Add(this.lb_lbProdCode);
            this.gbx_informationWO.Controls.Add(this.lb_lbOrderNo);
            this.gbx_informationWO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_informationWO.Location = new System.Drawing.Point(801, 127);
            this.gbx_informationWO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_informationWO.Name = "gbx_informationWO";
            this.gbx_informationWO.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_informationWO.Size = new System.Drawing.Size(868, 708);
            this.gbx_informationWO.TabIndex = 8;
            this.gbx_informationWO.TabStop = false;
            // 
            // dtgv_allScannedMat
            // 
            this.dtgv_allScannedMat.AllowUserToAddRows = false;
            this.dtgv_allScannedMat.AllowUserToDeleteRows = false;
            this.dtgv_allScannedMat.AllowUserToOrderColumns = true;
            this.dtgv_allScannedMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_allScannedMat.Location = new System.Drawing.Point(24, 224);
            this.dtgv_allScannedMat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgv_allScannedMat.Name = "dtgv_allScannedMat";
            this.dtgv_allScannedMat.RowHeadersWidth = 51;
            this.dtgv_allScannedMat.Size = new System.Drawing.Size(836, 222);
            this.dtgv_allScannedMat.TabIndex = 16;
            // 
            // lb_dispatchQty
            // 
            this.lb_dispatchQty.AutoSize = true;
            this.lb_dispatchQty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dispatchQty.Location = new System.Drawing.Point(241, 170);
            this.lb_dispatchQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_dispatchQty.Name = "lb_dispatchQty";
            this.lb_dispatchQty.Size = new System.Drawing.Size(25, 23);
            this.lb_dispatchQty.TabIndex = 15;
            this.lb_dispatchQty.Text = "...";
            // 
            // lb_lbDispatchQuantity
            // 
            this.lb_lbDispatchQuantity.AutoSize = true;
            this.lb_lbDispatchQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbDispatchQuantity.Location = new System.Drawing.Point(19, 170);
            this.lb_lbDispatchQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbDispatchQuantity.Name = "lb_lbDispatchQuantity";
            this.lb_lbDispatchQuantity.Size = new System.Drawing.Size(210, 22);
            this.lb_lbDispatchQuantity.TabIndex = 14;
            this.lb_lbDispatchQuantity.Text = "Số lượng sinh quản phát :";
            // 
            // lb_remainQty
            // 
            this.lb_remainQty.AutoSize = true;
            this.lb_remainQty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_remainQty.Location = new System.Drawing.Point(657, 170);
            this.lb_remainQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_remainQty.Name = "lb_remainQty";
            this.lb_remainQty.Size = new System.Drawing.Size(25, 23);
            this.lb_remainQty.TabIndex = 13;
            this.lb_remainQty.Text = "...";
            // 
            // lb_finishQty
            // 
            this.lb_finishQty.AutoSize = true;
            this.lb_finishQty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_finishQty.Location = new System.Drawing.Point(657, 126);
            this.lb_finishQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_finishQty.Name = "lb_finishQty";
            this.lb_finishQty.Size = new System.Drawing.Size(25, 23);
            this.lb_finishQty.TabIndex = 12;
            this.lb_finishQty.Text = "...";
            // 
            // lb_orderQty
            // 
            this.lb_orderQty.AutoSize = true;
            this.lb_orderQty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_orderQty.Location = new System.Drawing.Point(241, 126);
            this.lb_orderQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_orderQty.Name = "lb_orderQty";
            this.lb_orderQty.Size = new System.Drawing.Size(25, 23);
            this.lb_orderQty.TabIndex = 10;
            this.lb_orderQty.Text = "...";
            // 
            // lb_prodCode
            // 
            this.lb_prodCode.AutoSize = true;
            this.lb_prodCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prodCode.Location = new System.Drawing.Point(215, 78);
            this.lb_prodCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_prodCode.Name = "lb_prodCode";
            this.lb_prodCode.Size = new System.Drawing.Size(25, 23);
            this.lb_prodCode.TabIndex = 8;
            this.lb_prodCode.Text = "...";
            // 
            // lb_orderNo
            // 
            this.lb_orderNo.AutoSize = true;
            this.lb_orderNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_orderNo.Location = new System.Drawing.Point(215, 33);
            this.lb_orderNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_orderNo.Name = "lb_orderNo";
            this.lb_orderNo.Size = new System.Drawing.Size(25, 23);
            this.lb_orderNo.TabIndex = 7;
            this.lb_orderNo.Text = "...";
            // 
            // lb_lbOrderRemainQuantity
            // 
            this.lb_lbOrderRemainQuantity.AutoSize = true;
            this.lb_lbOrderRemainQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbOrderRemainQuantity.Location = new System.Drawing.Point(437, 170);
            this.lb_lbOrderRemainQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbOrderRemainQuantity.Name = "lb_lbOrderRemainQuantity";
            this.lb_lbOrderRemainQuantity.Size = new System.Drawing.Size(152, 22);
            this.lb_lbOrderRemainQuantity.TabIndex = 6;
            this.lb_lbOrderRemainQuantity.Text = "Số lượng còn lại :";
            // 
            // lb_lbOrderFinishQty
            // 
            this.lb_lbOrderFinishQty.AutoSize = true;
            this.lb_lbOrderFinishQty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbOrderFinishQty.Location = new System.Drawing.Point(437, 126);
            this.lb_lbOrderFinishQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbOrderFinishQty.Name = "lb_lbOrderFinishQty";
            this.lb_lbOrderFinishQty.Size = new System.Drawing.Size(205, 22);
            this.lb_lbOrderFinishQty.TabIndex = 5;
            this.lb_lbOrderFinishQty.Text = "Số lượng đã hoàn thành :";
            // 
            // lb_lbOrderQuantity
            // 
            this.lb_lbOrderQuantity.AutoSize = true;
            this.lb_lbOrderQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbOrderQuantity.Location = new System.Drawing.Point(19, 126);
            this.lb_lbOrderQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbOrderQuantity.Name = "lb_lbOrderQuantity";
            this.lb_lbOrderQuantity.Size = new System.Drawing.Size(160, 22);
            this.lb_lbOrderQuantity.TabIndex = 4;
            this.lb_lbOrderQuantity.Text = "Số lượng của đơn :";
            // 
            // lb_lbProdCode
            // 
            this.lb_lbProdCode.AutoSize = true;
            this.lb_lbProdCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbProdCode.Location = new System.Drawing.Point(19, 78);
            this.lb_lbProdCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbProdCode.Name = "lb_lbProdCode";
            this.lb_lbProdCode.Size = new System.Drawing.Size(173, 22);
            this.lb_lbProdCode.TabIndex = 2;
            this.lb_lbProdCode.Text = "Mã bán thành phẩm :";
            // 
            // lb_lbOrderNo
            // 
            this.lb_lbOrderNo.AutoSize = true;
            this.lb_lbOrderNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lbOrderNo.Location = new System.Drawing.Point(19, 33);
            this.lb_lbOrderNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lbOrderNo.Name = "lb_lbOrderNo";
            this.lb_lbOrderNo.Size = new System.Drawing.Size(166, 22);
            this.lb_lbOrderNo.TabIndex = 0;
            this.lb_lbOrderNo.Text = "Mã đơn đang chọn :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_portRefresh);
            this.groupBox1.Controls.Add(this.btClose);
            this.groupBox1.Controls.Add(this.btOpen);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(16, 586);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaterialScale2MES.Properties.Resources.logoTechlinkFix;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_informationWO);
            this.Controls.Add(this.lb_lbChooseWOInstruction);
            this.Controls.Add(this.gbx_chooseWO);
            this.Controls.Add(this.lb_lbEmpName);
            this.Controls.Add(this.lb_lbEmpCode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_empName);
            this.Controls.Add(this.lb_empCode);
            this.Controls.Add(this.txtQR);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_chooseWO)).EndInit();
            this.gbx_chooseWO.ResumeLayout(false);
            this.gbx_chooseWO.PerformLayout();
            this.gbx_informationWO.ResumeLayout(false);
            this.gbx_informationWO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_allScannedMat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label lb_lbOrderNo;
        private System.Windows.Forms.Label lb_remainQty;
        private System.Windows.Forms.Label lb_finishQty;
        private System.Windows.Forms.Label lb_orderQty;
        private System.Windows.Forms.Label lb_prodCode;
        private System.Windows.Forms.Label lb_orderNo;
        private System.Windows.Forms.Label lb_lbOrderRemainQuantity;
        private System.Windows.Forms.Label lb_lbOrderFinishQty;
        private System.Windows.Forms.Label lb_lbOrderQuantity;
        private System.Windows.Forms.Label lb_lbProdCode;
        private System.Windows.Forms.Label lb_dispatchQty;
        private System.Windows.Forms.Label lb_lbDispatchQuantity;
        private System.Windows.Forms.DataGridView dtgv_allScannedMat;
    }
}

