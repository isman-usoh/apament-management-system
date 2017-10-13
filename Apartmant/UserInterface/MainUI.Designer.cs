namespace UI
{
    partial class MainUI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.mtpMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogoutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCloseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePasswordItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOption = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConfigItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStaffManager = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRoomManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomTypeManager = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDataOption = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRoomList = new System.Windows.Forms.DataGridView();
            this.checkInIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startStayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInByStaffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKCheckInsCustomerTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet = new Apartmant.Database.ApartmentDataSet();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRoomNO = new System.Windows.Forms.Label();
            this.tbxRoomNO = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCustomerType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnServiceCharge = new System.Windows.Forms.Button();
            this.btnUtility = new System.Windows.Forms.Button();
            this.btnBookingMgn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalRoom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUseRoom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUse1 = new System.Windows.Forms.Label();
            this.lblUse2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRoomEmtry = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.customerTypesTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.CustomerTypesTableAdapter();
            this.checkInsTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.CheckInsTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mtpMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCheckInsCustomerTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.mtpMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 75);
            this.panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(10);
            this.lblHeader.Size = new System.Drawing.Size(784, 51);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Apartment Manager System";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtpMain
            // 
            this.mtpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiStaff,
            this.tsmiOption,
            this.tsmiManager,
            this.tsmiHelp});
            this.mtpMain.Location = new System.Drawing.Point(0, 0);
            this.mtpMain.Name = "mtpMain";
            this.mtpMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mtpMain.Size = new System.Drawing.Size(784, 24);
            this.mtpMain.TabIndex = 1;
            this.mtpMain.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogoutItem,
            this.toolStripSeparator1,
            this.tsmiCloseItem});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(38, 20);
            this.tsmiFile.Text = "ไฟล์";
            // 
            // tsmiLogoutItem
            // 
            this.tsmiLogoutItem.Name = "tsmiLogoutItem";
            this.tsmiLogoutItem.Size = new System.Drawing.Size(134, 22);
            this.tsmiLogoutItem.Text = "ออกจากระบบ";
            this.tsmiLogoutItem.Click += new System.EventHandler(this.tsmiLogoutItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // tsmiCloseItem
            // 
            this.tsmiCloseItem.Name = "tsmiCloseItem";
            this.tsmiCloseItem.Size = new System.Drawing.Size(134, 22);
            this.tsmiCloseItem.Text = "ปิดการทำงาน";
            this.tsmiCloseItem.Click += new System.EventHandler(this.tsmiCloseItem_Click);
            // 
            // tsmiStaff
            // 
            this.tsmiStaff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangePasswordItem});
            this.tsmiStaff.Name = "tsmiStaff";
            this.tsmiStaff.Size = new System.Drawing.Size(38, 20);
            this.tsmiStaff.Text = "ผู้ใช้";
            // 
            // tsmiChangePasswordItem
            // 
            this.tsmiChangePasswordItem.Name = "tsmiChangePasswordItem";
            this.tsmiChangePasswordItem.Size = new System.Drawing.Size(140, 22);
            this.tsmiChangePasswordItem.Text = "เปลี่ยนรหัสผ่าน";
            this.tsmiChangePasswordItem.Click += new System.EventHandler(this.tsmiChangePasswordItem_Click);
            // 
            // tsmiOption
            // 
            this.tsmiOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConfigItem});
            this.tsmiOption.Name = "tsmiOption";
            this.tsmiOption.Size = new System.Drawing.Size(43, 20);
            this.tsmiOption.Text = "ตั้งค่า";
            this.tsmiOption.Visible = false;
            // 
            // tsmiConfigItem
            // 
            this.tsmiConfigItem.Name = "tsmiConfigItem";
            this.tsmiConfigItem.Size = new System.Drawing.Size(98, 22);
            this.tsmiConfigItem.Text = "ตั้งค่า";
            this.tsmiConfigItem.Click += new System.EventHandler(this.tsmiConfigItem_Click);
            // 
            // tsmiManager
            // 
            this.tsmiManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStaff,
            this.tsmiStaffManager,
            this.toolStripSeparator3,
            this.tsmiRoomManage,
            this.tsmiRoomTypeManager,
            this.toolStripSeparator2,
            this.tsmiDataOption});
            this.tsmiManager.Name = "tsmiManager";
            this.tsmiManager.Size = new System.Drawing.Size(56, 20);
            this.tsmiManager.Text = "ผู้จัดการ";
            // 
            // tsmiAddStaff
            // 
            this.tsmiAddStaff.Name = "tsmiAddStaff";
            this.tsmiAddStaff.Size = new System.Drawing.Size(155, 22);
            this.tsmiAddStaff.Text = "เพิ่มพนักงานใหม่";
            this.tsmiAddStaff.Click += new System.EventHandler(this.tsmiAddStaff_Click);
            // 
            // tsmiStaffManager
            // 
            this.tsmiStaffManager.Name = "tsmiStaffManager";
            this.tsmiStaffManager.Size = new System.Drawing.Size(155, 22);
            this.tsmiStaffManager.Text = "จัดการพนักงาน";
            this.tsmiStaffManager.Click += new System.EventHandler(this.tsmiStaffManager_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(152, 6);
            // 
            // tsmiRoomManage
            // 
            this.tsmiRoomManage.Name = "tsmiRoomManage";
            this.tsmiRoomManage.Size = new System.Drawing.Size(155, 22);
            this.tsmiRoomManage.Text = "จัดการห้อง";
            this.tsmiRoomManage.Click += new System.EventHandler(this.tsmiRoomManage_Click);
            // 
            // tsmiRoomTypeManager
            // 
            this.tsmiRoomTypeManager.Name = "tsmiRoomTypeManager";
            this.tsmiRoomTypeManager.Size = new System.Drawing.Size(155, 22);
            this.tsmiRoomTypeManager.Text = "จัดการประเภทห้อง";
            this.tsmiRoomTypeManager.Click += new System.EventHandler(this.tsmiRoomTypeManager_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // tsmiDataOption
            // 
            this.tsmiDataOption.Name = "tsmiDataOption";
            this.tsmiDataOption.Size = new System.Drawing.Size(155, 22);
            this.tsmiDataOption.Text = "ตั้งค่าข้อมูลอื่น";
            this.tsmiDataOption.Click += new System.EventHandler(this.tsmiDataOption_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelpItem,
            this.tsmiAboutItem});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(59, 20);
            this.tsmiHelp.Text = "ช่วยเหลือ";
            // 
            // tsmiHelpItem
            // 
            this.tsmiHelpItem.Name = "tsmiHelpItem";
            this.tsmiHelpItem.Size = new System.Drawing.Size(114, 22);
            this.tsmiHelpItem.Text = "ช่วยเหลือ";
            // 
            // tsmiAboutItem
            // 
            this.tsmiAboutItem.Name = "tsmiAboutItem";
            this.tsmiAboutItem.Size = new System.Drawing.Size(114, 22);
            this.tsmiAboutItem.Text = "เกี่ยวกับ";
            this.tsmiAboutItem.Click += new System.EventHandler(this.tsmiAboutItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 78);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 480);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.dgvRoomList, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel4, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(157, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(618, 474);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.AllowUserToAddRows = false;
            this.dgvRoomList.AllowUserToDeleteRows = false;
            this.dgvRoomList.AutoGenerateColumns = false;
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkInIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.customerTypeIDDataGridViewTextBoxColumn,
            this.customerTypeNameDataGridViewTextBoxColumn,
            this.roomTypeIDDataGridViewTextBoxColumn,
            this.roomTypeNameDataGridViewTextBoxColumn,
            this.roomIDDataGridViewTextBoxColumn,
            this.roomNODataGridViewTextBoxColumn,
            this.roomPriceDataGridViewTextBoxColumn,
            this.startStayDataGridViewTextBoxColumn,
            this.endStayDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.checkInByStaffIDDataGridViewTextBoxColumn,
            this.bookingIDDataGridViewTextBoxColumn,
            this.checkInDateDataGridViewTextBoxColumn,
            this.checkOutDateDataGridViewTextBoxColumn,
            this.checkInStatusDataGridViewTextBoxColumn});
            this.dgvRoomList.DataSource = this.fKCheckInsCustomerTypesBindingSource;
            this.dgvRoomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoomList.Location = new System.Drawing.Point(3, 78);
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.ReadOnly = true;
            this.dgvRoomList.Size = new System.Drawing.Size(612, 393);
            this.dgvRoomList.TabIndex = 7;
            this.dgvRoomList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRoomList_CellMouseDoubleClick);
            // 
            // checkInIDDataGridViewTextBoxColumn
            // 
            this.checkInIDDataGridViewTextBoxColumn.DataPropertyName = "CheckInID";
            this.checkInIDDataGridViewTextBoxColumn.HeaderText = "CheckInID";
            this.checkInIDDataGridViewTextBoxColumn.Name = "checkInIDDataGridViewTextBoxColumn";
            this.checkInIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerTypeIDDataGridViewTextBoxColumn
            // 
            this.customerTypeIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerTypeID";
            this.customerTypeIDDataGridViewTextBoxColumn.HeaderText = "CustomerTypeID";
            this.customerTypeIDDataGridViewTextBoxColumn.Name = "customerTypeIDDataGridViewTextBoxColumn";
            this.customerTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerTypeNameDataGridViewTextBoxColumn
            // 
            this.customerTypeNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerTypeName";
            this.customerTypeNameDataGridViewTextBoxColumn.HeaderText = "CustomerTypeName";
            this.customerTypeNameDataGridViewTextBoxColumn.Name = "customerTypeNameDataGridViewTextBoxColumn";
            this.customerTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomTypeIDDataGridViewTextBoxColumn
            // 
            this.roomTypeIDDataGridViewTextBoxColumn.DataPropertyName = "RoomTypeID";
            this.roomTypeIDDataGridViewTextBoxColumn.HeaderText = "RoomTypeID";
            this.roomTypeIDDataGridViewTextBoxColumn.Name = "roomTypeIDDataGridViewTextBoxColumn";
            this.roomTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomTypeNameDataGridViewTextBoxColumn
            // 
            this.roomTypeNameDataGridViewTextBoxColumn.DataPropertyName = "RoomTypeName";
            this.roomTypeNameDataGridViewTextBoxColumn.HeaderText = "RoomTypeName";
            this.roomTypeNameDataGridViewTextBoxColumn.Name = "roomTypeNameDataGridViewTextBoxColumn";
            this.roomTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNODataGridViewTextBoxColumn
            // 
            this.roomNODataGridViewTextBoxColumn.DataPropertyName = "RoomNO";
            this.roomNODataGridViewTextBoxColumn.HeaderText = "RoomNO";
            this.roomNODataGridViewTextBoxColumn.Name = "roomNODataGridViewTextBoxColumn";
            this.roomNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomPriceDataGridViewTextBoxColumn
            // 
            this.roomPriceDataGridViewTextBoxColumn.DataPropertyName = "RoomPrice";
            this.roomPriceDataGridViewTextBoxColumn.HeaderText = "RoomPrice";
            this.roomPriceDataGridViewTextBoxColumn.Name = "roomPriceDataGridViewTextBoxColumn";
            this.roomPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startStayDataGridViewTextBoxColumn
            // 
            this.startStayDataGridViewTextBoxColumn.DataPropertyName = "StartStay";
            this.startStayDataGridViewTextBoxColumn.HeaderText = "StartStay";
            this.startStayDataGridViewTextBoxColumn.Name = "startStayDataGridViewTextBoxColumn";
            this.startStayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endStayDataGridViewTextBoxColumn
            // 
            this.endStayDataGridViewTextBoxColumn.DataPropertyName = "EndStay";
            this.endStayDataGridViewTextBoxColumn.HeaderText = "EndStay";
            this.endStayDataGridViewTextBoxColumn.Name = "endStayDataGridViewTextBoxColumn";
            this.endStayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkInByStaffIDDataGridViewTextBoxColumn
            // 
            this.checkInByStaffIDDataGridViewTextBoxColumn.DataPropertyName = "CheckInByStaffID";
            this.checkInByStaffIDDataGridViewTextBoxColumn.HeaderText = "CheckInByStaffID";
            this.checkInByStaffIDDataGridViewTextBoxColumn.Name = "checkInByStaffIDDataGridViewTextBoxColumn";
            this.checkInByStaffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkInDateDataGridViewTextBoxColumn
            // 
            this.checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.HeaderText = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
            this.checkInDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            this.checkOutDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkInStatusDataGridViewTextBoxColumn
            // 
            this.checkInStatusDataGridViewTextBoxColumn.DataPropertyName = "CheckInStatus";
            this.checkInStatusDataGridViewTextBoxColumn.HeaderText = "CheckInStatus";
            this.checkInStatusDataGridViewTextBoxColumn.Name = "checkInStatusDataGridViewTextBoxColumn";
            this.checkInStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKCheckInsCustomerTypesBindingSource
            // 
            this.fKCheckInsCustomerTypesBindingSource.DataMember = "FK_CheckIns_CustomerTypes";
            this.fKCheckInsCustomerTypesBindingSource.DataSource = this.customerTypesBindingSource;
            // 
            // customerTypesBindingSource
            // 
            this.customerTypesBindingSource.DataMember = "CustomerTypes";
            this.customerTypesBindingSource.DataSource = this.apartmentDataSet;
            // 
            // apartmentDataSet
            // 
            this.apartmentDataSet.DataSetName = "ApartmentDataSet";
            this.apartmentDataSet.Locale = new System.Globalization.CultureInfo("th");
            this.apartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblRoomNO);
            this.flowLayoutPanel2.Controls.Add(this.tbxRoomNO);
            this.flowLayoutPanel2.Controls.Add(this.btnSearch);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(612, 29);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // lblRoomNO
            // 
            this.lblRoomNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomNO.Location = new System.Drawing.Point(3, 0);
            this.lblRoomNO.Name = "lblRoomNO";
            this.lblRoomNO.Size = new System.Drawing.Size(75, 29);
            this.lblRoomNO.TabIndex = 4;
            this.lblRoomNO.Text = "หมายเลขห้อง :";
            this.lblRoomNO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxRoomNO
            // 
            this.tbxRoomNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxRoomNO.Location = new System.Drawing.Point(84, 3);
            this.tbxRoomNO.Name = "tbxRoomNO";
            this.tbxRoomNO.Size = new System.Drawing.Size(120, 20);
            this.tbxRoomNO.TabIndex = 5;
            this.tbxRoomNO.TextChanged += new System.EventHandler(this.tbxRoomNO_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(210, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.cbxCustomerType);
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Controls.Add(this.dtpDate);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(612, 29);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ประเภทผู้เช่า :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxCustomerType
            // 
            this.cbxCustomerType.DataSource = this.customerTypesBindingSource;
            this.cbxCustomerType.DisplayMember = "CustomerTypeName";
            this.cbxCustomerType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomerType.FormattingEnabled = true;
            this.cbxCustomerType.Location = new System.Drawing.Point(84, 3);
            this.cbxCustomerType.Name = "cbxCustomerType";
            this.cbxCustomerType.Size = new System.Drawing.Size(120, 21);
            this.cbxCustomerType.TabIndex = 1;
            this.cbxCustomerType.ValueMember = "CustomerTypeID";
            this.cbxCustomerType.SelectedIndexChanged += new System.EventHandler(this.cbxCustomerType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(210, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "วันที :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDate
            // 
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(266, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnCheckIn, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnBooking, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnServiceCharge, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.btnUtility, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.btnBookingMgn, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 0, 9);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 10;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(148, 474);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(3, 3);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(142, 23);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "เช็คอิน";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(3, 38);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(142, 23);
            this.btnBooking.TabIndex = 5;
            this.btnBooking.Text = "จองห้อง";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnServiceCharge
            // 
            this.btnServiceCharge.Location = new System.Drawing.Point(3, 108);
            this.btnServiceCharge.Name = "btnServiceCharge";
            this.btnServiceCharge.Size = new System.Drawing.Size(142, 23);
            this.btnServiceCharge.TabIndex = 8;
            this.btnServiceCharge.Text = "บันทึกค่าบริการ";
            this.btnServiceCharge.UseVisualStyleBackColor = true;
            this.btnServiceCharge.Click += new System.EventHandler(this.btnServiceCharge_Click);
            // 
            // btnUtility
            // 
            this.btnUtility.Location = new System.Drawing.Point(3, 143);
            this.btnUtility.Name = "btnUtility";
            this.btnUtility.Size = new System.Drawing.Size(142, 23);
            this.btnUtility.TabIndex = 7;
            this.btnUtility.Text = "บันทึกค่าสาธารณูปโภค";
            this.btnUtility.UseVisualStyleBackColor = true;
            this.btnUtility.Click += new System.EventHandler(this.btnUtility_Click);
            // 
            // btnBookingMgn
            // 
            this.btnBookingMgn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBookingMgn.Location = new System.Drawing.Point(3, 73);
            this.btnBookingMgn.Name = "btnBookingMgn";
            this.btnBookingMgn.Size = new System.Drawing.Size(142, 24);
            this.btnBookingMgn.TabIndex = 9;
            this.btnBookingMgn.Text = "จัดการจอง";
            this.btnBookingMgn.UseVisualStyleBackColor = true;
            this.btnBookingMgn.Click += new System.EventHandler(this.btnBookingMgn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.71831F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.28169F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblTotalRoom, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblUseRoom, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblUse1, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblUse2, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.lblRoomEmtry, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.lblTime, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDate, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 170);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(148, 304);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "จำนวนห้องทั้งหมด";
            // 
            // lblTotalRoom
            // 
            this.lblTotalRoom.AutoSize = true;
            this.lblTotalRoom.Location = new System.Drawing.Point(106, 184);
            this.lblTotalRoom.Name = "lblTotalRoom";
            this.lblTotalRoom.Size = new System.Drawing.Size(13, 13);
            this.lblTotalRoom.TabIndex = 1;
            this.lblTotalRoom.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "จำนวนห้องเช่า";
            // 
            // lblUseRoom
            // 
            this.lblUseRoom.AutoSize = true;
            this.lblUseRoom.Location = new System.Drawing.Point(106, 204);
            this.lblUseRoom.Name = "lblUseRoom";
            this.lblUseRoom.Size = new System.Drawing.Size(13, 13);
            this.lblUseRoom.TabIndex = 3;
            this.lblUseRoom.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "ผู้เช่ารายเดือน";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "ผู้เช่ารายวัน";
            // 
            // lblUse1
            // 
            this.lblUse1.AutoSize = true;
            this.lblUse1.Location = new System.Drawing.Point(106, 224);
            this.lblUse1.Name = "lblUse1";
            this.lblUse1.Size = new System.Drawing.Size(13, 13);
            this.lblUse1.TabIndex = 6;
            this.lblUse1.Text = "0";
            // 
            // lblUse2
            // 
            this.lblUse2.AutoSize = true;
            this.lblUse2.Location = new System.Drawing.Point(106, 244);
            this.lblUse2.Name = "lblUse2";
            this.lblUse2.Size = new System.Drawing.Size(13, 13);
            this.lblUse2.TabIndex = 7;
            this.lblUse2.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "จำนวนห้องว่าง";
            // 
            // lblRoomEmtry
            // 
            this.lblRoomEmtry.AutoSize = true;
            this.lblRoomEmtry.Location = new System.Drawing.Point(106, 264);
            this.lblRoomEmtry.Name = "lblRoomEmtry";
            this.lblRoomEmtry.Size = new System.Drawing.Size(13, 13);
            this.lblRoomEmtry.TabIndex = 9;
            this.lblRoomEmtry.Text = "0";
            // 
            // lblTime
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.lblTime, 2);
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTime.Location = new System.Drawing.Point(3, 94);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(142, 50);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "22:22:22";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.lblDate, 2);
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDate.Location = new System.Drawing.Point(3, 144);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(142, 40);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "12/12/2012";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // customerTypesTableAdapter
            // 
            this.customerTypesTableAdapter.ClearBeforeFill = true;
            // 
            // checkInsTableAdapter
            // 
            this.checkInsTableAdapter.ClearBeforeFill = true;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.HelpButton = true;
            this.MainMenuStrip = this.mtpMain;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartment Manager System";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mtpMain.ResumeLayout(false);
            this.mtpMain.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCheckInsCustomerTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.MenuStrip mtpMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiOption;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAboutItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dgvRoomList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblRoomNO;
        private System.Windows.Forms.TextBox tbxRoomNO;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCustomerType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogoutItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePasswordItem;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnUtility;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfigItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaffManager;
        private System.Windows.Forms.Button btnServiceCharge;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomTypeManager;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiDataOption;
        private System.Windows.Forms.Button btnBookingMgn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUseRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUse1;
        private System.Windows.Forms.Label lblUse2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRoomEmtry;
        private Apartmant.Database.ApartmentDataSet apartmentDataSet;
        private System.Windows.Forms.BindingSource customerTypesBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.CustomerTypesTableAdapter customerTypesTableAdapter;
        private System.Windows.Forms.BindingSource fKCheckInsCustomerTypesBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.CheckInsTableAdapter checkInsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startStayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endStayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInByStaffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
    }
}