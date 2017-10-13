namespace Apartment.UserInterface.Room
{
    partial class AddRoomTypeUI
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
            this.tbxRoomTypeName = new System.Windows.Forms.TextBox();
            this.roomTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet = new Apartmant.Database.ApartmentDataSet();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lblRoomTypeName = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbxCustomerType = new System.Windows.Forms.ComboBox();
            this.customerTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.customerTypesTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.CustomerTypesTableAdapter();
            this.roomTypesTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.RoomTypesTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(10);
            this.lblHeader.Size = new System.Drawing.Size(374, 50);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "เพิ่มประเภทห้องเช่า";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 279);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(368, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(209, 3);
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
            this.panel1.Size = new System.Drawing.Size(368, 220);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tbxRoomTypeName, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbxPrice, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblRoomTypeName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCustomerType, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblPrice, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.cbxCustomerType, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbxDescription, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblDescription, 1, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(366, 218);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tbxRoomTypeName
            // 
            this.tbxRoomTypeName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomTypesBindingSource, "RoomTypeName", true));
            this.tbxRoomTypeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxRoomTypeName.Location = new System.Drawing.Point(118, 32);
            this.tbxRoomTypeName.Name = "tbxRoomTypeName";
            this.tbxRoomTypeName.Size = new System.Drawing.Size(214, 20);
            this.tbxRoomTypeName.TabIndex = 0;
            // 
            // roomTypesBindingSource
            // 
            this.roomTypesBindingSource.DataMember = "RoomTypes";
            this.roomTypesBindingSource.DataSource = this.apartmentDataSet;
            // 
            // apartmentDataSet
            // 
            this.apartmentDataSet.DataSetName = "ApartmentDataSet";
            this.apartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxPrice
            // 
            this.tbxPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomTypesBindingSource, "Prices", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "C2"));
            this.tbxPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPrice.Location = new System.Drawing.Point(118, 92);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(214, 20);
            this.tbxPrice.TabIndex = 2;
            // 
            // lblRoomTypeName
            // 
            this.lblRoomTypeName.AutoSize = true;
            this.lblRoomTypeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomTypeName.Location = new System.Drawing.Point(33, 29);
            this.lblRoomTypeName.Name = "lblRoomTypeName";
            this.lblRoomTypeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRoomTypeName.Size = new System.Drawing.Size(79, 25);
            this.lblRoomTypeName.TabIndex = 3;
            this.lblRoomTypeName.Text = "ชื่อรูปแบบ : ";
            this.lblRoomTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerType.Location = new System.Drawing.Point(33, 59);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(79, 25);
            this.lblCustomerType.TabIndex = 4;
            this.lblCustomerType.Text = "ประเภทผู้เช่า : ";
            this.lblCustomerType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Location = new System.Drawing.Point(33, 89);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(79, 25);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "ราคา : ";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxCustomerType
            // 
            this.cbxCustomerType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roomTypesBindingSource, "CustomerTypeID", true));
            this.cbxCustomerType.DataSource = this.customerTypesBindingSource;
            this.cbxCustomerType.DisplayMember = "CustomerTypeName";
            this.cbxCustomerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomerType.FormattingEnabled = true;
            this.cbxCustomerType.Location = new System.Drawing.Point(118, 62);
            this.cbxCustomerType.Name = "cbxCustomerType";
            this.cbxCustomerType.Size = new System.Drawing.Size(214, 21);
            this.cbxCustomerType.TabIndex = 6;
            this.cbxCustomerType.ValueMember = "CustomerTypeID";
            // 
            // customerTypesBindingSource
            // 
            this.customerTypesBindingSource.DataMember = "CustomerTypes";
            this.customerTypesBindingSource.DataSource = this.apartmentDataSet;
            // 
            // tbxDescription
            // 
            this.tbxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomTypesBindingSource, "Description", true));
            this.tbxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDescription.Location = new System.Drawing.Point(118, 122);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(214, 64);
            this.tbxDescription.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(33, 119);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 70);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "คำอธิบาย : ";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerTypesTableAdapter
            // 
            this.customerTypesTableAdapter.ClearBeforeFill = true;
            // 
            // roomTypesTableAdapter
            // 
            this.roomTypesTableAdapter.ClearBeforeFill = true;
            // 
            // AddRoomTypeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddRoomTypeUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มประเภทห้องเช่า";
            this.Load += new System.EventHandler(this.AddRoomTypeUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbxRoomTypeName;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lblRoomTypeName;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbxCustomerType;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblDescription;
        private Apartmant.Database.ApartmentDataSet apartmentDataSet;
        private System.Windows.Forms.BindingSource customerTypesBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.CustomerTypesTableAdapter customerTypesTableAdapter;
        private System.Windows.Forms.BindingSource roomTypesBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.RoomTypesTableAdapter roomTypesTableAdapter;
    }
}