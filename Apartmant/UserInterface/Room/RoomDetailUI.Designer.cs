using Apartment.UserInterface.IUserControl;

namespace Apartment.UserInterface.Room
{
    partial class RoomDetailUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnContinu = new System.Windows.Forms.Button();
            this.btnNotifCheckOut = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tclPanel = new System.Windows.Forms.TabControl();
            this.tabCustomerDetail = new System.Windows.Forms.TabPage();
            this.customerDetailPanel = new Apartment.UserInterface.IUserControl.CustomerDetailView();
            this.tabRoomDetail = new System.Windows.Forms.TabPage();
            this.roomDetailPanel = new Apartment.UserInterface.IUserControl.RoomDetailView();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPaymentList = new System.Windows.Forms.DataGridView();
            this.payIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startStayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payStatusDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet = new Apartmant.Database.ApartmentDataSet();
            this.btnCelculatePayment = new System.Windows.Forms.Button();
            this.tabServiceCharge = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvServiceChargeList = new System.Windows.Forms.DataGridView();
            this.serviceChargeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceChargesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddServiceCharge = new System.Windows.Forms.Button();
            this.serviceChargesTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.ServiceChargesTableAdapter();
            this.paymentViewTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.PaymentViewTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tclPanel.SuspendLayout();
            this.tabCustomerDetail.SuspendLayout();
            this.tabRoomDetail.SuspendLayout();
            this.tabPayment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).BeginInit();
            this.tabServiceCharge.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceChargeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceChargesBindingSource)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tclPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "เช็คอินผู้เช่ารายวัน";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 526);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(784, 35);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCheckOut);
            this.flowLayoutPanel1.Controls.Add(this.btnContinu);
            this.flowLayoutPanel1.Controls.Add(this.btnNotifCheckOut);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(386, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(3, 3);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(90, 23);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "ย้ายออก";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnContinu
            // 
            this.btnContinu.Location = new System.Drawing.Point(99, 3);
            this.btnContinu.Name = "btnContinu";
            this.btnContinu.Size = new System.Drawing.Size(90, 23);
            this.btnContinu.TabIndex = 3;
            this.btnContinu.Text = "เช่าต่อ";
            this.btnContinu.UseVisualStyleBackColor = true;
            this.btnContinu.Click += new System.EventHandler(this.btnContinu_Click);
            // 
            // btnNotifCheckOut
            // 
            this.btnNotifCheckOut.Location = new System.Drawing.Point(195, 3);
            this.btnNotifCheckOut.Name = "btnNotifCheckOut";
            this.btnNotifCheckOut.Size = new System.Drawing.Size(90, 23);
            this.btnNotifCheckOut.TabIndex = 4;
            this.btnNotifCheckOut.Text = "แจ้งย้ายออก";
            this.btnNotifCheckOut.UseVisualStyleBackColor = true;
            this.btnNotifCheckOut.Visible = false;
            this.btnNotifCheckOut.Click += new System.EventHandler(this.btnNotifCheckOut_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnCancel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(395, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(386, 29);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(293, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "ปืด";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tclPanel
            // 
            this.tclPanel.Controls.Add(this.tabCustomerDetail);
            this.tclPanel.Controls.Add(this.tabRoomDetail);
            this.tclPanel.Controls.Add(this.tabPayment);
            this.tclPanel.Controls.Add(this.tabServiceCharge);
            this.tclPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclPanel.Location = new System.Drawing.Point(3, 53);
            this.tclPanel.Name = "tclPanel";
            this.tclPanel.SelectedIndex = 0;
            this.tclPanel.Size = new System.Drawing.Size(778, 470);
            this.tclPanel.TabIndex = 0;
            // 
            // tabCustomerDetail
            // 
            this.tabCustomerDetail.BackColor = System.Drawing.SystemColors.Control;
            this.tabCustomerDetail.Controls.Add(this.customerDetailPanel);
            this.tabCustomerDetail.Location = new System.Drawing.Point(4, 22);
            this.tabCustomerDetail.Name = "tabCustomerDetail";
            this.tabCustomerDetail.Size = new System.Drawing.Size(770, 444);
            this.tabCustomerDetail.TabIndex = 0;
            this.tabCustomerDetail.Text = "ข้อมูลผู้เช่า";
            // 
            // customerDetailPanel
            // 
            this.customerDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDetailPanel.Location = new System.Drawing.Point(0, 0);
            this.customerDetailPanel.Name = "customerDetailPanel";
            this.customerDetailPanel.Size = new System.Drawing.Size(770, 444);
            this.customerDetailPanel.TabIndex = 0;
            // 
            // tabRoomDetail
            // 
            this.tabRoomDetail.BackColor = System.Drawing.SystemColors.Control;
            this.tabRoomDetail.Controls.Add(this.roomDetailPanel);
            this.tabRoomDetail.Location = new System.Drawing.Point(4, 22);
            this.tabRoomDetail.Name = "tabRoomDetail";
            this.tabRoomDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoomDetail.Size = new System.Drawing.Size(770, 444);
            this.tabRoomDetail.TabIndex = 3;
            this.tabRoomDetail.Text = "ข้อมูลห้อง";
            // 
            // roomDetailPanel
            // 
            this.roomDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomDetailPanel.Location = new System.Drawing.Point(3, 3);
            this.roomDetailPanel.Name = "roomDetailPanel";
            this.roomDetailPanel.Size = new System.Drawing.Size(764, 438);
            this.roomDetailPanel.TabIndex = 0;
            // 
            // tabPayment
            // 
            this.tabPayment.BackColor = System.Drawing.Color.White;
            this.tabPayment.Controls.Add(this.groupBox1);
            this.tabPayment.Location = new System.Drawing.Point(4, 22);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayment.Size = new System.Drawing.Size(770, 444);
            this.tabPayment.TabIndex = 1;
            this.tabPayment.Text = "ชำระเงิน";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 438);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ประวัติการชำระเงิน";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dgvPaymentList, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCelculatePayment, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(758, 419);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvPaymentList
            // 
            this.dgvPaymentList.AllowUserToAddRows = false;
            this.dgvPaymentList.AllowUserToDeleteRows = false;
            this.dgvPaymentList.AutoGenerateColumns = false;
            this.dgvPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payIDDataGridViewTextBoxColumn,
            this.roomNODataGridViewTextBoxColumn,
            this.startStayDataGridViewTextBoxColumn,
            this.endStayDataGridViewTextBoxColumn,
            this.amountRoomDataGridViewTextBoxColumn,
            this.amountServiceDataGridViewTextBoxColumn,
            this.amountTotalDataGridViewTextBoxColumn,
            this.payStatusDataGridViewComboBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.payDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvPaymentList.DataSource = this.paymentViewBindingSource;
            this.dgvPaymentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentList.Location = new System.Drawing.Point(3, 3);
            this.dgvPaymentList.Name = "dgvPaymentList";
            this.dgvPaymentList.ReadOnly = true;
            this.dgvPaymentList.Size = new System.Drawing.Size(752, 384);
            this.dgvPaymentList.TabIndex = 2;
            this.dgvPaymentList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPaymentList_CellMouseDoubleClick);
            // 
            // payIDDataGridViewTextBoxColumn
            // 
            this.payIDDataGridViewTextBoxColumn.DataPropertyName = "PayID";
            this.payIDDataGridViewTextBoxColumn.HeaderText = "เลขที";
            this.payIDDataGridViewTextBoxColumn.Name = "payIDDataGridViewTextBoxColumn";
            this.payIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNODataGridViewTextBoxColumn
            // 
            this.roomNODataGridViewTextBoxColumn.DataPropertyName = "RoomNO";
            this.roomNODataGridViewTextBoxColumn.HeaderText = "เลขห้อง";
            this.roomNODataGridViewTextBoxColumn.Name = "roomNODataGridViewTextBoxColumn";
            this.roomNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startStayDataGridViewTextBoxColumn
            // 
            this.startStayDataGridViewTextBoxColumn.DataPropertyName = "StartStay";
            this.startStayDataGridViewTextBoxColumn.HeaderText = "วันเริ่มต้น";
            this.startStayDataGridViewTextBoxColumn.Name = "startStayDataGridViewTextBoxColumn";
            this.startStayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endStayDataGridViewTextBoxColumn
            // 
            this.endStayDataGridViewTextBoxColumn.DataPropertyName = "EndStay";
            this.endStayDataGridViewTextBoxColumn.HeaderText = "วันสิ้นสุด";
            this.endStayDataGridViewTextBoxColumn.Name = "endStayDataGridViewTextBoxColumn";
            this.endStayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountRoomDataGridViewTextBoxColumn
            // 
            this.amountRoomDataGridViewTextBoxColumn.DataPropertyName = "AmountRoom";
            this.amountRoomDataGridViewTextBoxColumn.HeaderText = "ค่าห้อง";
            this.amountRoomDataGridViewTextBoxColumn.Name = "amountRoomDataGridViewTextBoxColumn";
            this.amountRoomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountServiceDataGridViewTextBoxColumn
            // 
            this.amountServiceDataGridViewTextBoxColumn.DataPropertyName = "AmountService";
            this.amountServiceDataGridViewTextBoxColumn.HeaderText = "ค่าบริการ";
            this.amountServiceDataGridViewTextBoxColumn.Name = "amountServiceDataGridViewTextBoxColumn";
            this.amountServiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountTotalDataGridViewTextBoxColumn
            // 
            this.amountTotalDataGridViewTextBoxColumn.DataPropertyName = "AmountTotal";
            this.amountTotalDataGridViewTextBoxColumn.HeaderText = "รวม";
            this.amountTotalDataGridViewTextBoxColumn.Name = "amountTotalDataGridViewTextBoxColumn";
            this.amountTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payStatusDataGridViewComboBoxColumn
            // 
            this.payStatusDataGridViewComboBoxColumn.DataPropertyName = "PayStatus";
            this.payStatusDataGridViewComboBoxColumn.HeaderText = "สถานะ";
            this.payStatusDataGridViewComboBoxColumn.Name = "payStatusDataGridViewComboBoxColumn";
            this.payStatusDataGridViewComboBoxColumn.ReadOnly = true;
            this.payStatusDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.payStatusDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "ผู้รับเงิน";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payDateDataGridViewTextBoxColumn
            // 
            this.payDateDataGridViewTextBoxColumn.DataPropertyName = "PayDate";
            this.payDateDataGridViewTextBoxColumn.HeaderText = "วันชำระเงิน";
            this.payDateDataGridViewTextBoxColumn.Name = "payDateDataGridViewTextBoxColumn";
            this.payDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "คำอธิบาย";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentViewBindingSource
            // 
            this.paymentViewBindingSource.DataMember = "PaymentView";
            this.paymentViewBindingSource.DataSource = this.apartmentDataSet;
            // 
            // apartmentDataSet
            // 
            this.apartmentDataSet.DataSetName = "ApartmentDataSet";
            this.apartmentDataSet.Locale = new System.Globalization.CultureInfo("th");
            this.apartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCelculatePayment
            // 
            this.btnCelculatePayment.Location = new System.Drawing.Point(3, 393);
            this.btnCelculatePayment.Name = "btnCelculatePayment";
            this.btnCelculatePayment.Size = new System.Drawing.Size(100, 23);
            this.btnCelculatePayment.TabIndex = 3;
            this.btnCelculatePayment.Text = "คำนวนใบเสร็จ";
            this.btnCelculatePayment.UseVisualStyleBackColor = true;
            this.btnCelculatePayment.Click += new System.EventHandler(this.btnCelculatePayment_Click);
            // 
            // tabServiceCharge
            // 
            this.tabServiceCharge.Controls.Add(this.groupBox2);
            this.tabServiceCharge.Location = new System.Drawing.Point(4, 22);
            this.tabServiceCharge.Name = "tabServiceCharge";
            this.tabServiceCharge.Padding = new System.Windows.Forms.Padding(3);
            this.tabServiceCharge.Size = new System.Drawing.Size(770, 444);
            this.tabServiceCharge.TabIndex = 5;
            this.tabServiceCharge.Text = "ค่าบริการเพิ่มเติ่ม";
            this.tabServiceCharge.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 438);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ประวัติค่าบริการเพิ่มเติม";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.dgvServiceChargeList, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(758, 419);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // dgvServiceChargeList
            // 
            this.dgvServiceChargeList.AllowUserToAddRows = false;
            this.dgvServiceChargeList.AllowUserToDeleteRows = false;
            this.dgvServiceChargeList.AutoGenerateColumns = false;
            this.dgvServiceChargeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceChargeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceChargeIDDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.dgvServiceChargeList.DataSource = this.serviceChargesBindingSource;
            this.dgvServiceChargeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiceChargeList.Location = new System.Drawing.Point(3, 3);
            this.dgvServiceChargeList.Name = "dgvServiceChargeList";
            this.dgvServiceChargeList.ReadOnly = true;
            this.dgvServiceChargeList.Size = new System.Drawing.Size(752, 384);
            this.dgvServiceChargeList.TabIndex = 0;
            this.dgvServiceChargeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceChargeList_CellContentClick);
            // 
            // serviceChargeIDDataGridViewTextBoxColumn
            // 
            this.serviceChargeIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceChargeID";
            this.serviceChargeIDDataGridViewTextBoxColumn.HeaderText = "เลขที";
            this.serviceChargeIDDataGridViewTextBoxColumn.Name = "serviceChargeIDDataGridViewTextBoxColumn";
            this.serviceChargeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "บริการ";
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            this.serviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "จำนวนเงิน";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ServiceDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "วันที";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PayID";
            this.dataGridViewTextBoxColumn7.HeaderText = "สถานะ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn9.HeaderText = "คำอธิบาย";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // serviceChargesBindingSource
            // 
            this.serviceChargesBindingSource.DataMember = "ServiceCharges";
            this.serviceChargesBindingSource.DataSource = this.apartmentDataSet;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnAddServiceCharge);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 390);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(758, 29);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // btnAddServiceCharge
            // 
            this.btnAddServiceCharge.Location = new System.Drawing.Point(3, 3);
            this.btnAddServiceCharge.Name = "btnAddServiceCharge";
            this.btnAddServiceCharge.Size = new System.Drawing.Size(100, 23);
            this.btnAddServiceCharge.TabIndex = 0;
            this.btnAddServiceCharge.Text = "เพิ่มค่าบริการ";
            this.btnAddServiceCharge.UseVisualStyleBackColor = true;
            this.btnAddServiceCharge.Click += new System.EventHandler(this.btnAddServiceCharge_Click);
            // 
            // serviceChargesTableAdapter
            // 
            this.serviceChargesTableAdapter.ClearBeforeFill = true;
            // 
            // paymentViewTableAdapter
            // 
            this.paymentViewTableAdapter.ClearBeforeFill = true;
            // 
            // RoomDetailUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomDetailUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ข้อมูลห้องพัก";
            this.Load += new System.EventHandler(this.RoomDetailUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tclPanel.ResumeLayout(false);
            this.tabCustomerDetail.ResumeLayout(false);
            this.tabRoomDetail.ResumeLayout(false);
            this.tabPayment.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).EndInit();
            this.tabServiceCharge.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceChargeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceChargesBindingSource)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tclPanel;
        private System.Windows.Forms.TabPage tabCustomerDetail;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TabPage tabServiceCharge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.DataGridView dgvServiceChargeList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnAddServiceCharge;
        private System.Windows.Forms.Button btnContinu;
        private System.Windows.Forms.Button btnNotifCheckOut;
        private System.Windows.Forms.TabPage tabRoomDetail;
        private CustomerDetailView customerDetailPanel;
        private RoomDetailView roomDetailPanel;
        private System.Windows.Forms.TabPage tabPayment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvPaymentList;
        private System.Windows.Forms.Button btnCelculatePayment;
        private Apartmant.Database.ApartmentDataSet apartmentDataSet;
        private System.Windows.Forms.BindingSource serviceChargesBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.ServiceChargesTableAdapter serviceChargesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceChargeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource paymentViewBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.PaymentViewTableAdapter paymentViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn payIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startStayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endStayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn payStatusDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}