namespace Apartment.UserInterface.Payment
{
    partial class PaymentDetailUI
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAmountsLabel = new System.Windows.Forms.Label();
            this.lblTotalAmountsLabel = new System.Windows.Forms.Label();
            this.lblServiceAmountsLabel = new System.Windows.Forms.Label();
            this.lblDescrptionLabel = new System.Windows.Forms.Label();
            this.lblPaymentIDLabel = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.paymentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet = new Apartmant.Database.ApartmentDataSet();
            this.lblStartStayDateLabel = new System.Windows.Forms.Label();
            this.lblEndStayDateLabel = new System.Windows.Forms.Label();
            this.lblRoomTypeLabel = new System.Windows.Forms.Label();
            this.lblCustomerTypeLabel = new System.Windows.Forms.Label();
            this.lblRoomNOLabel = new System.Windows.Forms.Label();
            this.lblRoomNO = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblStartStayDate = new System.Windows.Forms.Label();
            this.lblAmounts = new System.Windows.Forms.Label();
            this.lblServiceCharge = new System.Windows.Forms.Label();
            this.lblTotalAmounts = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblEndStayDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPaymentStatusLabel = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnPrintPayment = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.paymentViewTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.PaymentViewTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(10);
            this.lblHeader.Size = new System.Drawing.Size(628, 45);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "ใบเสร็จรับเงิน";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(628, 325);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ข้อมูลชำระเงิน";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(622, 306);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 6;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.lblAmountsLabel, 1, 6);
            this.tableLayoutPanel8.Controls.Add(this.lblTotalAmountsLabel, 1, 10);
            this.tableLayoutPanel8.Controls.Add(this.lblServiceAmountsLabel, 1, 8);
            this.tableLayoutPanel8.Controls.Add(this.lblDescrptionLabel, 3, 6);
            this.tableLayoutPanel8.Controls.Add(this.lblPaymentIDLabel, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblPaymentID, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblStartStayDateLabel, 1, 4);
            this.tableLayoutPanel8.Controls.Add(this.lblEndStayDateLabel, 3, 4);
            this.tableLayoutPanel8.Controls.Add(this.lblRoomTypeLabel, 3, 2);
            this.tableLayoutPanel8.Controls.Add(this.lblCustomerTypeLabel, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.lblRoomNOLabel, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblRoomNO, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblCustomerType, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.lblStartStayDate, 2, 4);
            this.tableLayoutPanel8.Controls.Add(this.lblAmounts, 2, 6);
            this.tableLayoutPanel8.Controls.Add(this.lblServiceCharge, 2, 8);
            this.tableLayoutPanel8.Controls.Add(this.lblTotalAmounts, 2, 10);
            this.tableLayoutPanel8.Controls.Add(this.lblRoomType, 4, 2);
            this.tableLayoutPanel8.Controls.Add(this.lblEndStayDate, 4, 4);
            this.tableLayoutPanel8.Controls.Add(this.lblDescription, 4, 6);
            this.tableLayoutPanel8.Controls.Add(this.lblPaymentStatusLabel, 1, 12);
            this.tableLayoutPanel8.Controls.Add(this.lblPaymentStatus, 2, 12);
            this.tableLayoutPanel8.Controls.Add(this.label1, 3, 12);
            this.tableLayoutPanel8.Controls.Add(this.label2, 4, 12);
            this.tableLayoutPanel8.Controls.Add(this.label3, 1, 14);
            this.tableLayoutPanel8.Controls.Add(this.label4, 2, 14);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 16;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(622, 271);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // lblAmountsLabel
            // 
            this.lblAmountsLabel.AutoSize = true;
            this.lblAmountsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmountsLabel.Location = new System.Drawing.Point(9, 90);
            this.lblAmountsLabel.Name = "lblAmountsLabel";
            this.lblAmountsLabel.Size = new System.Drawing.Size(119, 25);
            this.lblAmountsLabel.TabIndex = 15;
            this.lblAmountsLabel.Text = "จำนวนเงินค่าเช่า : ";
            this.lblAmountsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmountsLabel
            // 
            this.lblTotalAmountsLabel.AutoSize = true;
            this.lblTotalAmountsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmountsLabel.Location = new System.Drawing.Point(9, 150);
            this.lblTotalAmountsLabel.Name = "lblTotalAmountsLabel";
            this.lblTotalAmountsLabel.Size = new System.Drawing.Size(119, 25);
            this.lblTotalAmountsLabel.TabIndex = 40;
            this.lblTotalAmountsLabel.Text = "รวมจำนวนเงินทั้งหมด : ";
            this.lblTotalAmountsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServiceAmountsLabel
            // 
            this.lblServiceAmountsLabel.AutoSize = true;
            this.lblServiceAmountsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServiceAmountsLabel.Location = new System.Drawing.Point(9, 120);
            this.lblServiceAmountsLabel.Name = "lblServiceAmountsLabel";
            this.lblServiceAmountsLabel.Size = new System.Drawing.Size(119, 25);
            this.lblServiceAmountsLabel.TabIndex = 39;
            this.lblServiceAmountsLabel.Text = "ค่าบริการเพิ่มเติม : ";
            this.lblServiceAmountsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescrptionLabel
            // 
            this.lblDescrptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescrptionLabel.Location = new System.Drawing.Point(314, 90);
            this.lblDescrptionLabel.Name = "lblDescrptionLabel";
            this.tableLayoutPanel8.SetRowSpan(this.lblDescrptionLabel, 3);
            this.lblDescrptionLabel.Size = new System.Drawing.Size(119, 55);
            this.lblDescrptionLabel.TabIndex = 48;
            this.lblDescrptionLabel.Text = "คำอธิบาย : ";
            this.lblDescrptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPaymentIDLabel
            // 
            this.lblPaymentIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentIDLabel.Location = new System.Drawing.Point(9, 0);
            this.lblPaymentIDLabel.Name = "lblPaymentIDLabel";
            this.lblPaymentIDLabel.Size = new System.Drawing.Size(119, 25);
            this.lblPaymentIDLabel.TabIndex = 53;
            this.lblPaymentIDLabel.Text = "เลขใบเสร็จ : ";
            this.lblPaymentIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentViewBindingSource, "PayID", true));
            this.lblPaymentID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPaymentID.Location = new System.Drawing.Point(134, 0);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(174, 25);
            this.lblPaymentID.TabIndex = 54;
            this.lblPaymentID.Text = "-";
            this.lblPaymentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paymentViewBindingSource
            // 
            this.paymentViewBindingSource.DataMember = "PaymentView";
            this.paymentViewBindingSource.DataSource = this.apartmentDataSet;
            // 
            // apartmentDataSet
            // 
            this.apartmentDataSet.DataSetName = "ApartmentDataSet";
            this.apartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStartStayDateLabel
            // 
            this.lblStartStayDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartStayDateLabel.Location = new System.Drawing.Point(9, 60);
            this.lblStartStayDateLabel.Name = "lblStartStayDateLabel";
            this.lblStartStayDateLabel.Size = new System.Drawing.Size(119, 25);
            this.lblStartStayDateLabel.TabIndex = 57;
            this.lblStartStayDateLabel.Text = "วันทีเข้า : ";
            this.lblStartStayDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEndStayDateLabel
            // 
            this.lblEndStayDateLabel.AutoSize = true;
            this.lblEndStayDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEndStayDateLabel.Location = new System.Drawing.Point(314, 60);
            this.lblEndStayDateLabel.Name = "lblEndStayDateLabel";
            this.lblEndStayDateLabel.Size = new System.Drawing.Size(119, 25);
            this.lblEndStayDateLabel.TabIndex = 59;
            this.lblEndStayDateLabel.Text = "วันทีออก : ";
            this.lblEndStayDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoomTypeLabel
            // 
            this.lblRoomTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomTypeLabel.Location = new System.Drawing.Point(314, 30);
            this.lblRoomTypeLabel.Name = "lblRoomTypeLabel";
            this.lblRoomTypeLabel.Size = new System.Drawing.Size(119, 25);
            this.lblRoomTypeLabel.TabIndex = 56;
            this.lblRoomTypeLabel.Text = "รูปแบบห้อง : ";
            this.lblRoomTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerTypeLabel
            // 
            this.lblCustomerTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerTypeLabel.Location = new System.Drawing.Point(9, 30);
            this.lblCustomerTypeLabel.Name = "lblCustomerTypeLabel";
            this.lblCustomerTypeLabel.Size = new System.Drawing.Size(119, 25);
            this.lblCustomerTypeLabel.TabIndex = 55;
            this.lblCustomerTypeLabel.Text = "ประเภทผู้เช่า : ";
            this.lblCustomerTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoomNOLabel
            // 
            this.lblRoomNOLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomNOLabel.Location = new System.Drawing.Point(314, 0);
            this.lblRoomNOLabel.Name = "lblRoomNOLabel";
            this.lblRoomNOLabel.Size = new System.Drawing.Size(119, 25);
            this.lblRoomNOLabel.TabIndex = 60;
            this.lblRoomNOLabel.Text = "หมายเลขห้อง : ";
            this.lblRoomNOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoomNO
            // 
            this.lblRoomNO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentViewBindingSource, "RoomNO", true));
            this.lblRoomNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblRoomNO.Location = new System.Drawing.Point(439, 0);
            this.lblRoomNO.Name = "lblRoomNO";
            this.lblRoomNO.Size = new System.Drawing.Size(174, 25);
            this.lblRoomNO.TabIndex = 61;
            this.lblRoomNO.Text = "-";
            this.lblRoomNO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentViewBindingSource, "CustomerTypeName", true));
            this.lblCustomerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCustomerType.Location = new System.Drawing.Point(134, 30);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(174, 25);
            this.lblCustomerType.TabIndex = 62;
            this.lblCustomerType.Text = "-";
            this.lblCustomerType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStartStayDate
            // 
            this.lblStartStayDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentViewBindingSource, "StartStay", true));
            this.lblStartStayDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartStayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblStartStayDate.Location = new System.Drawing.Point(134, 60);
            this.lblStartStayDate.Name = "lblStartStayDate";
            this.lblStartStayDate.Size = new System.Drawing.Size(174, 25);
            this.lblStartStayDate.TabIndex = 63;
            this.lblStartStayDate.Text = "-";
            this.lblStartStayDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAmounts
            // 
            this.lblAmounts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentViewBindingSource, "AmountRoom", true));
            this.lblAmounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblAmounts.Location = new System.Drawing.Point(134, 90);
            this.lblAmounts.Name = "lblAmounts";
            this.lblAmounts.Size = new System.Drawing.Size(174, 25);
            this.lblAmounts.TabIndex = 64;
            this.lblAmounts.Text = "-";
            this.lblAmounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServiceCharge
            // 
            this.lblServiceCharge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentViewBindingSource, "AmountService", true));
            this.lblServiceCharge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServiceCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblServiceCharge.Location = new System.Drawing.Point(134, 120);
            this.lblServiceCharge.Name = "lblServiceCharge";
            this.lblServiceCharge.Size = new System.Drawing.Size(174, 25);
            this.lblServiceCharge.TabIndex = 65;
            this.lblServiceCharge.Text = "-";
            this.lblServiceCharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmounts
            // 
            this.lblTotalAmounts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentViewBindingSource, "AmountTotal", true));
            this.lblTotalAmounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTotalAmounts.Location = new System.Drawing.Point(134, 150);
            this.lblTotalAmounts.Name = "lblTotalAmounts";
            this.lblTotalAmounts.Size = new System.Drawing.Size(174, 25);
            this.lblTotalAmounts.TabIndex = 66;
            this.lblTotalAmounts.Text = "-";
            this.lblTotalAmounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoomType
            // 
            this.lblRoomType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentViewBindingSource, "RoomTypeName", true));
            this.lblRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblRoomType.Location = new System.Drawing.Point(439, 30);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(174, 25);
            this.lblRoomType.TabIndex = 67;
            this.lblRoomType.Text = "-";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEndStayDate
            // 
            this.lblEndStayDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentViewBindingSource, "EndStay", true));
            this.lblEndStayDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEndStayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEndStayDate.Location = new System.Drawing.Point(439, 60);
            this.lblEndStayDate.Name = "lblEndStayDate";
            this.lblEndStayDate.Size = new System.Drawing.Size(174, 25);
            this.lblEndStayDate.TabIndex = 68;
            this.lblEndStayDate.Text = "-";
            this.lblEndStayDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentViewBindingSource, "Description", true));
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDescription.Location = new System.Drawing.Point(439, 90);
            this.lblDescription.Name = "lblDescription";
            this.tableLayoutPanel8.SetRowSpan(this.lblDescription, 3);
            this.lblDescription.Size = new System.Drawing.Size(174, 55);
            this.lblDescription.TabIndex = 69;
            this.lblDescription.Text = "-";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaymentStatusLabel
            // 
            this.lblPaymentStatusLabel.Location = new System.Drawing.Point(9, 180);
            this.lblPaymentStatusLabel.Name = "lblPaymentStatusLabel";
            this.lblPaymentStatusLabel.Size = new System.Drawing.Size(119, 25);
            this.lblPaymentStatusLabel.TabIndex = 42;
            this.lblPaymentStatusLabel.Text = "สถานะชำระเงิน : ";
            this.lblPaymentStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPaymentStatus.ForeColor = System.Drawing.Color.Red;
            this.lblPaymentStatus.Location = new System.Drawing.Point(134, 180);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(174, 25);
            this.lblPaymentStatus.TabIndex = 43;
            this.lblPaymentStatus.Text = "ยังไม่ได้ชำระเงิน";
            this.lblPaymentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(314, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "ผู้รับเงิน : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentViewBindingSource, "Fullname", true));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(439, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(9, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "วันชำระเงิน : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentViewBindingSource, "PayDate", true));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(134, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnPayment);
            this.flowLayoutPanel4.Controls.Add(this.btnPrintPayment);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 274);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(616, 29);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(3, 3);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(100, 23);
            this.btnPayment.TabIndex = 0;
            this.btnPayment.Text = "ชำระค่าบริการ";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnPrintPayment
            // 
            this.btnPrintPayment.Location = new System.Drawing.Point(109, 3);
            this.btnPrintPayment.Name = "btnPrintPayment";
            this.btnPrintPayment.Size = new System.Drawing.Size(100, 23);
            this.btnPrintPayment.TabIndex = 0;
            this.btnPrintPayment.Text = "พิมท์ใบเสร็จ";
            this.btnPrintPayment.UseVisualStyleBackColor = true;
            this.btnPrintPayment.Click += new System.EventHandler(this.btnPrintPayment_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 379);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(628, 29);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(550, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "ปิด";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // paymentViewTableAdapter
            // 
            this.paymentViewTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentDetailUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PaymentDetailUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ใบเสร็จรับเงิน";
            this.Load += new System.EventHandler(this.PaymentUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label lblAmountsLabel;
        private System.Windows.Forms.Label lblTotalAmountsLabel;
        public System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblPaymentStatusLabel;
        private System.Windows.Forms.Label lblServiceAmountsLabel;
        private System.Windows.Forms.Label lblDescrptionLabel;
        private System.Windows.Forms.Label lblPaymentIDLabel;
        public System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Label lblStartStayDateLabel;
        private System.Windows.Forms.Label lblEndStayDateLabel;
        private System.Windows.Forms.Label lblRoomTypeLabel;
        private System.Windows.Forms.Label lblCustomerTypeLabel;
        private System.Windows.Forms.Label lblRoomNOLabel;
        public System.Windows.Forms.Label lblRoomNO;
        public System.Windows.Forms.Label lblCustomerType;
        public System.Windows.Forms.Label lblStartStayDate;
        public System.Windows.Forms.Label lblAmounts;
        public System.Windows.Forms.Label lblServiceCharge;
        public System.Windows.Forms.Label lblTotalAmounts;
        public System.Windows.Forms.Label lblRoomType;
        public System.Windows.Forms.Label lblEndStayDate;
        public System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        public System.Windows.Forms.Button btnPayment;
        public System.Windows.Forms.Button btnPrintPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private Apartmant.Database.ApartmentDataSet apartmentDataSet;
        private System.Windows.Forms.BindingSource paymentViewBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.PaymentViewTableAdapter paymentViewTableAdapter;
    }
}