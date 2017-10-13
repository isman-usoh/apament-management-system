namespace Apartment.UserInterface.IUserControl
{
    partial class RoomDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxCustomerType = new System.Windows.Forms.ComboBox();
            this.customerTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet = new Apartmant.Database.ApartmentDataSet();
            this.dtpStarStay = new System.Windows.Forms.DateTimePicker();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblStartStay = new System.Windows.Forms.Label();
            this.lblStayCount = new System.Windows.Forms.Label();
            this.cbxRoomType = new System.Windows.Forms.ComboBox();
            this.fKRoomTypesCustomerTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cbxRoomNO = new System.Windows.Forms.ComboBox();
            this.fKRoomsRoomTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRoomNO = new System.Windows.Forms.Label();
            this.dtpEndStay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblPriceLable = new System.Windows.Forms.Label();
            this.customerTypesTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.CustomerTypesTableAdapter();
            this.roomTypesTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.RoomTypesTableAdapter();
            this.roomsTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.RoomsTableAdapter();
            this.panel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomTypesCustomerTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomsRoomTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tableLayoutPanel5);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(650, 450);
            this.panel.TabIndex = 3;
            this.panel.TabStop = false;
            this.panel.Text = "ข้อมูลห้อง";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.cbxCustomerType, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.dtpStarStay, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblCustomerType, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblStartStay, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblStayCount, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.cbxRoomType, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblRoomType, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbxRoomNO, 2, 4);
            this.tableLayoutPanel5.Controls.Add(this.lblRoomNO, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.dtpEndStay, 4, 2);
            this.tableLayoutPanel5.Controls.Add(this.label1, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.tbxDescription, 2, 6);
            this.tableLayoutPanel5.Controls.Add(this.lblRoomPrice, 4, 4);
            this.tableLayoutPanel5.Controls.Add(this.lblPriceLable, 3, 4);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(644, 431);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // cbxCustomerType
            // 
            this.cbxCustomerType.DataSource = this.customerTypesBindingSource;
            this.cbxCustomerType.DisplayMember = "CustomerTypeName";
            this.cbxCustomerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomerType.FormattingEnabled = true;
            this.cbxCustomerType.Location = new System.Drawing.Point(145, 3);
            this.cbxCustomerType.Name = "cbxCustomerType";
            this.cbxCustomerType.Size = new System.Drawing.Size(174, 21);
            this.cbxCustomerType.TabIndex = 0;
            this.cbxCustomerType.ValueMember = "CustomerTypeID";
            this.cbxCustomerType.SelectedIndexChanged += new System.EventHandler(this.cbxCustomerType_SelectedIndexChanged);
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
            // dtpStarStay
            // 
            this.dtpStarStay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStarStay.Location = new System.Drawing.Point(145, 33);
            this.dtpStarStay.Name = "dtpStarStay";
            this.dtpStarStay.Size = new System.Drawing.Size(174, 20);
            this.dtpStarStay.TabIndex = 1;
            this.dtpStarStay.ValueChanged += new System.EventHandler(this.dtpStarStay_ValueChanged);
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerType.Location = new System.Drawing.Point(20, 0);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(119, 25);
            this.lblCustomerType.TabIndex = 15;
            this.lblCustomerType.Text = "ประเภทผู้เช่า : ";
            this.lblCustomerType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartStay
            // 
            this.lblStartStay.AutoSize = true;
            this.lblStartStay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartStay.Location = new System.Drawing.Point(20, 30);
            this.lblStartStay.Name = "lblStartStay";
            this.lblStartStay.Size = new System.Drawing.Size(119, 25);
            this.lblStartStay.TabIndex = 7;
            this.lblStartStay.Text = "วันทีเข้า : ";
            this.lblStartStay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStayCount
            // 
            this.lblStayCount.AutoSize = true;
            this.lblStayCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStayCount.Location = new System.Drawing.Point(325, 30);
            this.lblStayCount.Name = "lblStayCount";
            this.lblStayCount.Size = new System.Drawing.Size(119, 25);
            this.lblStayCount.TabIndex = 33;
            this.lblStayCount.Text = "วันทีออก : ";
            this.lblStayCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxRoomType
            // 
            this.cbxRoomType.DataSource = this.fKRoomTypesCustomerTypesBindingSource;
            this.cbxRoomType.DisplayMember = "RoomTypeName";
            this.cbxRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoomType.FormattingEnabled = true;
            this.cbxRoomType.Location = new System.Drawing.Point(450, 3);
            this.cbxRoomType.Name = "cbxRoomType";
            this.cbxRoomType.Size = new System.Drawing.Size(174, 21);
            this.cbxRoomType.TabIndex = 37;
            this.cbxRoomType.ValueMember = "RoomTypeID";
            this.cbxRoomType.SelectedIndexChanged += new System.EventHandler(this.cbxRoomType_SelectedIndexChanged);
            // 
            // fKRoomTypesCustomerTypesBindingSource
            // 
            this.fKRoomTypesCustomerTypesBindingSource.DataMember = "FK_RoomTypes_CustomerTypes";
            this.fKRoomTypesCustomerTypesBindingSource.DataSource = this.customerTypesBindingSource;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomType.Location = new System.Drawing.Point(325, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(119, 25);
            this.lblRoomType.TabIndex = 38;
            this.lblRoomType.Text = "รูปแบบห้อง : ";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxRoomNO
            // 
            this.cbxRoomNO.DataSource = this.fKRoomsRoomTypesBindingSource;
            this.cbxRoomNO.DisplayMember = "No";
            this.cbxRoomNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRoomNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoomNO.FormattingEnabled = true;
            this.cbxRoomNO.Location = new System.Drawing.Point(145, 63);
            this.cbxRoomNO.Name = "cbxRoomNO";
            this.cbxRoomNO.Size = new System.Drawing.Size(174, 21);
            this.cbxRoomNO.TabIndex = 39;
            this.cbxRoomNO.ValueMember = "RoomID";
            // 
            // fKRoomsRoomTypesBindingSource
            // 
            this.fKRoomsRoomTypesBindingSource.DataMember = "FK_Rooms_RoomTypes";
            this.fKRoomsRoomTypesBindingSource.DataSource = this.fKRoomTypesCustomerTypesBindingSource;
            // 
            // lblRoomNO
            // 
            this.lblRoomNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomNO.Location = new System.Drawing.Point(20, 60);
            this.lblRoomNO.Name = "lblRoomNO";
            this.lblRoomNO.Size = new System.Drawing.Size(119, 25);
            this.lblRoomNO.TabIndex = 40;
            this.lblRoomNO.Text = "หมายเลขห้อง : ";
            this.lblRoomNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpEndStay
            // 
            this.dtpEndStay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndStay.Location = new System.Drawing.Point(450, 33);
            this.dtpEndStay.Name = "dtpEndStay";
            this.dtpEndStay.Size = new System.Drawing.Size(174, 20);
            this.dtpEndStay.TabIndex = 41;
            this.dtpEndStay.ValueChanged += new System.EventHandler(this.dtpEndStay_ValueChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(20, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 70);
            this.label1.TabIndex = 42;
            this.label1.Text = "คำอธิบาย : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDescription.Location = new System.Drawing.Point(145, 93);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(174, 64);
            this.tbxDescription.TabIndex = 43;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKRoomTypesCustomerTypesBindingSource, "Prices", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "C2"));
            this.lblRoomPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomPrice.Location = new System.Drawing.Point(450, 60);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(174, 25);
            this.lblRoomPrice.TabIndex = 44;
            this.lblRoomPrice.Text = "-";
            this.lblRoomPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPriceLable
            // 
            this.lblPriceLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPriceLable.Location = new System.Drawing.Point(325, 60);
            this.lblPriceLable.Name = "lblPriceLable";
            this.lblPriceLable.Size = new System.Drawing.Size(119, 25);
            this.lblPriceLable.TabIndex = 45;
            this.lblPriceLable.Text = "ราคาต่อวัน :";
            this.lblPriceLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerTypesTableAdapter
            // 
            this.customerTypesTableAdapter.ClearBeforeFill = true;
            // 
            // roomTypesTableAdapter
            // 
            this.roomTypesTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // RoomDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "RoomDetail";
            this.Size = new System.Drawing.Size(650, 450);
            this.Load += new System.EventHandler(this.RoomDetail_Load);
            this.panel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomTypesCustomerTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomsRoomTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblStartStay;
        private System.Windows.Forms.Label lblStayCount;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomNO;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbxCustomerType;
        public System.Windows.Forms.DateTimePicker dtpStarStay;
        public System.Windows.Forms.ComboBox cbxRoomType;
        public System.Windows.Forms.ComboBox cbxRoomNO;
        public System.Windows.Forms.DateTimePicker dtpEndStay;
        public System.Windows.Forms.TextBox tbxDescription;
        public System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label lblPriceLable;
        public System.Windows.Forms.GroupBox panel;
        private System.Windows.Forms.BindingSource customerTypesBindingSource;
        public Apartmant.Database.ApartmentDataSet apartmentDataSet;
        public Apartmant.Database.ApartmentDataSetTableAdapters.CustomerTypesTableAdapter customerTypesTableAdapter;
        public Apartmant.Database.ApartmentDataSetTableAdapters.RoomTypesTableAdapter roomTypesTableAdapter;
        public Apartmant.Database.ApartmentDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        public System.Windows.Forms.BindingSource fKRoomsRoomTypesBindingSource;
        public System.Windows.Forms.BindingSource fKRoomTypesCustomerTypesBindingSource;
    }
}
