namespace UI
{
    partial class AddServiceUI
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRoomNO = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.cbxRoomNO = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet = new Apartmant.Database.ApartmentDataSet();
            this.cbxServiceName = new System.Windows.Forms.ComboBox();
            this.serviceChargesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.roomsTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.RoomsTableAdapter();
            this.serviceChargesTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.ServiceChargesTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceChargesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.tbxSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 279);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(378, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbxSave
            // 
            this.tbxSave.Location = new System.Drawing.Point(219, 3);
            this.tbxSave.Name = "tbxSave";
            this.tbxSave.Size = new System.Drawing.Size(75, 23);
            this.tbxSave.TabIndex = 0;
            this.tbxSave.Text = "บันทึก";
            this.tbxSave.UseVisualStyleBackColor = true;
            this.tbxSave.Click += new System.EventHandler(this.tbxSave_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(378, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "บันทึกค่าบริการเสริม";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblRoomNO, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblServiceName, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblPrice, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblNote, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.cbxRoomNO, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbxServiceName, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbxAmount, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.tbxDescription, 2, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(378, 220);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblRoomNO
            // 
            this.lblRoomNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomNO.Location = new System.Drawing.Point(42, 37);
            this.lblRoomNO.Name = "lblRoomNO";
            this.lblRoomNO.Size = new System.Drawing.Size(74, 20);
            this.lblRoomNO.TabIndex = 0;
            this.lblRoomNO.Text = "หมายเลขห้อง : ";
            this.lblRoomNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServiceName
            // 
            this.lblServiceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServiceName.Location = new System.Drawing.Point(42, 62);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(74, 20);
            this.lblServiceName.TabIndex = 1;
            this.lblServiceName.Text = "ชื่อบริการ : ";
            this.lblServiceName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Location = new System.Drawing.Point(42, 87);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(74, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "ราคา : ";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNote
            // 
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNote.Location = new System.Drawing.Point(42, 112);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(74, 70);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "คำอธิบาย : ";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxRoomNO
            // 
            this.cbxRoomNO.DataSource = this.roomsBindingSource;
            this.cbxRoomNO.DisplayMember = "No";
            this.cbxRoomNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRoomNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoomNO.FormattingEnabled = true;
            this.cbxRoomNO.Location = new System.Drawing.Point(122, 40);
            this.cbxRoomNO.Name = "cbxRoomNO";
            this.cbxRoomNO.Size = new System.Drawing.Size(214, 21);
            this.cbxRoomNO.TabIndex = 4;
            this.cbxRoomNO.ValueMember = "RoomID";
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
            // cbxServiceName
            // 
            this.cbxServiceName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxServiceName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxServiceName.DataSource = this.serviceChargesBindingSource;
            this.cbxServiceName.DisplayMember = "ServiceName";
            this.cbxServiceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxServiceName.FormattingEnabled = true;
            this.cbxServiceName.Location = new System.Drawing.Point(122, 65);
            this.cbxServiceName.Name = "cbxServiceName";
            this.cbxServiceName.Size = new System.Drawing.Size(214, 21);
            this.cbxServiceName.TabIndex = 5;
            this.cbxServiceName.ValueMember = "ServiceChargeID";
            // 
            // serviceChargesBindingSource
            // 
            this.serviceChargesBindingSource.DataMember = "ServiceCharges";
            this.serviceChargesBindingSource.DataSource = this.apartmentDataSet;
            // 
            // tbxAmount
            // 
            this.tbxAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAmount.Location = new System.Drawing.Point(122, 90);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(214, 20);
            this.tbxAmount.TabIndex = 6;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDescription.Location = new System.Drawing.Point(122, 115);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(214, 64);
            this.tbxDescription.TabIndex = 7;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // serviceChargesTableAdapter
            // 
            this.serviceChargesTableAdapter.ClearBeforeFill = true;
            // 
            // AddServiceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddServiceUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "บันทึกค่าบริการเสริม";
            this.Load += new System.EventHandler(this.AddServiceUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceChargesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button tbxSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblRoomNO;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ComboBox cbxRoomNO;
        private System.Windows.Forms.ComboBox cbxServiceName;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.TextBox tbxDescription;
        private Apartmant.Database.ApartmentDataSet apartmentDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource serviceChargesBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.ServiceChargesTableAdapter serviceChargesTableAdapter;
    }
}