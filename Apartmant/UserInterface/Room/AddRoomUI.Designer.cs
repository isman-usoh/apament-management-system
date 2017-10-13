namespace Apartment.UserInterface.Room
{
    partial class AddRoomUI
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRoomNO = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.tbxRoomNO = new System.Windows.Forms.TextBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet = new Apartmant.Database.ApartmentDataSet();
            this.cbxCustomerType = new System.Windows.Forms.ComboBox();
            this.customerTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxRoomType = new System.Windows.Forms.ComboBox();
            this.fKRoomTypesCustomerTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPriceLabel = new System.Windows.Forms.Label();
            this.lblFlow = new System.Windows.Forms.Label();
            this.tbxFlow = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBuilder = new System.Windows.Forms.Label();
            this.tbxBuilding = new System.Windows.Forms.TextBox();
            this.lblRoomStatus = new System.Windows.Forms.Label();
            this.cbxRoomStatus = new System.Windows.Forms.ComboBox();
            this.customerTypesTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.CustomerTypesTableAdapter();
            this.roomTypesTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.RoomTypesTableAdapter();
            this.roomsTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.RoomsTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomTypesCustomerTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(10);
            this.lblHeader.Size = new System.Drawing.Size(384, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "เพิ่มห้องใหม่";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 329);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(378, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(219, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 270);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblRoomNO, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCustomerType, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblRoomType, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tbxRoomNO, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbxCustomerType, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbxRoomType, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblPriceLabel, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblFlow, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.tbxFlow, 2, 11);
            this.tableLayoutPanel2.Controls.Add(this.lblPrice, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblBuilder, 1, 13);
            this.tableLayoutPanel2.Controls.Add(this.tbxBuilding, 2, 13);
            this.tableLayoutPanel2.Controls.Add(this.lblRoomStatus, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.cbxRoomStatus, 2, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 15;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(376, 268);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblRoomNO
            // 
            this.lblRoomNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomNO.Location = new System.Drawing.Point(37, 31);
            this.lblRoomNO.Name = "lblRoomNO";
            this.lblRoomNO.Size = new System.Drawing.Size(81, 25);
            this.lblRoomNO.TabIndex = 0;
            this.lblRoomNO.Text = "เลขห้อง : ";
            this.lblRoomNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerType.Location = new System.Drawing.Point(37, 61);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(81, 25);
            this.lblCustomerType.TabIndex = 1;
            this.lblCustomerType.Text = "ประเภทผู้เช่า : ";
            this.lblCustomerType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomType.Location = new System.Drawing.Point(37, 91);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(81, 25);
            this.lblRoomType.TabIndex = 2;
            this.lblRoomType.Text = "ประเภทห้อง : ";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxRoomNO
            // 
            this.tbxRoomNO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "No", true));
            this.tbxRoomNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxRoomNO.Location = new System.Drawing.Point(124, 34);
            this.tbxRoomNO.Name = "tbxRoomNO";
            this.tbxRoomNO.Size = new System.Drawing.Size(214, 20);
            this.tbxRoomNO.TabIndex = 3;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.apartmentDataSet;
            // 
            // apartmentDataSet
            // 
            this.apartmentDataSet.DataSetName = "ApartmentDataSet";
            this.apartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxCustomerType
            // 
            this.cbxCustomerType.DataSource = this.customerTypesBindingSource;
            this.cbxCustomerType.DisplayMember = "CustomerTypeName";
            this.cbxCustomerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomerType.FormattingEnabled = true;
            this.cbxCustomerType.Location = new System.Drawing.Point(124, 64);
            this.cbxCustomerType.Name = "cbxCustomerType";
            this.cbxCustomerType.Size = new System.Drawing.Size(214, 21);
            this.cbxCustomerType.TabIndex = 4;
            this.cbxCustomerType.ValueMember = "CustomerTypeID";
            // 
            // customerTypesBindingSource
            // 
            this.customerTypesBindingSource.DataMember = "CustomerTypes";
            this.customerTypesBindingSource.DataSource = this.apartmentDataSet;
            // 
            // cbxRoomType
            // 
            this.cbxRoomType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roomsBindingSource, "RoomID", true));
            this.cbxRoomType.DataSource = this.fKRoomTypesCustomerTypesBindingSource;
            this.cbxRoomType.DisplayMember = "RoomTypeName";
            this.cbxRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoomType.FormattingEnabled = true;
            this.cbxRoomType.Location = new System.Drawing.Point(124, 94);
            this.cbxRoomType.Name = "cbxRoomType";
            this.cbxRoomType.Size = new System.Drawing.Size(214, 21);
            this.cbxRoomType.TabIndex = 5;
            this.cbxRoomType.ValueMember = "RoomTypeID";
            // 
            // fKRoomTypesCustomerTypesBindingSource
            // 
            this.fKRoomTypesCustomerTypesBindingSource.DataMember = "FK_RoomTypes_CustomerTypes";
            this.fKRoomTypesCustomerTypesBindingSource.DataSource = this.customerTypesBindingSource;
            // 
            // lblPriceLabel
            // 
            this.lblPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPriceLabel.Location = new System.Drawing.Point(37, 121);
            this.lblPriceLabel.Name = "lblPriceLabel";
            this.lblPriceLabel.Size = new System.Drawing.Size(81, 25);
            this.lblPriceLabel.TabIndex = 6;
            this.lblPriceLabel.Text = "ราคา : ";
            this.lblPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFlow
            // 
            this.lblFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFlow.Location = new System.Drawing.Point(37, 181);
            this.lblFlow.Name = "lblFlow";
            this.lblFlow.Size = new System.Drawing.Size(81, 25);
            this.lblFlow.TabIndex = 7;
            this.lblFlow.Text = "ชั้น : ";
            this.lblFlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxFlow
            // 
            this.tbxFlow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Flow", true));
            this.tbxFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFlow.Location = new System.Drawing.Point(124, 184);
            this.tbxFlow.Name = "tbxFlow";
            this.tbxFlow.Size = new System.Drawing.Size(214, 20);
            this.tbxFlow.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKRoomTypesCustomerTypesBindingSource, "Prices", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "C2"));
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPrice.Location = new System.Drawing.Point(124, 121);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(214, 25);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "-";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBuilder
            // 
            this.lblBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBuilder.Location = new System.Drawing.Point(37, 211);
            this.lblBuilder.Name = "lblBuilder";
            this.lblBuilder.Size = new System.Drawing.Size(81, 25);
            this.lblBuilder.TabIndex = 11;
            this.lblBuilder.Text = "อาคาร : ";
            this.lblBuilder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxBuilding
            // 
            this.tbxBuilding.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Builder", true));
            this.tbxBuilding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxBuilding.Location = new System.Drawing.Point(124, 214);
            this.tbxBuilding.Name = "tbxBuilding";
            this.tbxBuilding.Size = new System.Drawing.Size(214, 20);
            this.tbxBuilding.TabIndex = 12;
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomStatus.Location = new System.Drawing.Point(37, 151);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(81, 25);
            this.lblRoomStatus.TabIndex = 13;
            this.lblRoomStatus.Text = "สถานะ : ";
            this.lblRoomStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxRoomStatus
            // 
            this.cbxRoomStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roomsBindingSource, "Status", true));
            this.cbxRoomStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoomStatus.FormattingEnabled = true;
            this.cbxRoomStatus.Location = new System.Drawing.Point(124, 154);
            this.cbxRoomStatus.Name = "cbxRoomStatus";
            this.cbxRoomStatus.Size = new System.Drawing.Size(214, 21);
            this.cbxRoomStatus.TabIndex = 14;
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
            // AddRoomUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoomUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มห้องใหม่";
            this.Load += new System.EventHandler(this.AddRoomUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomTypesCustomerTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblRoomNO;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox tbxRoomNO;
        private System.Windows.Forms.ComboBox cbxCustomerType;
        private System.Windows.Forms.ComboBox cbxRoomType;
        private System.Windows.Forms.Label lblPriceLabel;
        private System.Windows.Forms.Label lblFlow;
        private System.Windows.Forms.TextBox tbxFlow;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBuilder;
        private System.Windows.Forms.TextBox tbxBuilding;
        private System.Windows.Forms.Label lblRoomStatus;
        private System.Windows.Forms.ComboBox cbxRoomStatus;
        private Apartmant.Database.ApartmentDataSet apartmentDataSet;
        private System.Windows.Forms.BindingSource customerTypesBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.CustomerTypesTableAdapter customerTypesTableAdapter;
        private System.Windows.Forms.BindingSource fKRoomTypesCustomerTypesBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.RoomTypesTableAdapter roomTypesTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
    }
}