namespace Apartment.UserInterface.IUserControl
{
    partial class ServiceCharge
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvServiceChargeList = new System.Windows.Forms.DataGridView();
            this.tbxServiceIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxServiceNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxAmountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxServiceStatusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxPaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddServiceCharge = new System.Windows.Forms.Button();
            this.btnRemoveServiceCharge = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceChargeList)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 450);
            this.groupBox2.TabIndex = 3;
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
            this.tableLayoutPanel9.Size = new System.Drawing.Size(644, 431);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // dgvServiceChargeList
            // 
            this.dgvServiceChargeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceChargeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbxServiceIDCol,
            this.tbxTimeCol,
            this.tbxServiceNameCol,
            this.tbxAmountCol,
            this.lblDescriptionCol,
            this.cbxServiceStatusCol,
            this.tbxPaymentID});
            this.dgvServiceChargeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiceChargeList.Location = new System.Drawing.Point(3, 3);
            this.dgvServiceChargeList.Name = "dgvServiceChargeList";
            this.dgvServiceChargeList.Size = new System.Drawing.Size(638, 396);
            this.dgvServiceChargeList.TabIndex = 0;
            // 
            // tbxServiceIDCol
            // 
            this.tbxServiceIDCol.HeaderText = "ID";
            this.tbxServiceIDCol.Name = "tbxServiceIDCol";
            this.tbxServiceIDCol.ReadOnly = true;
            this.tbxServiceIDCol.Visible = false;
            // 
            // tbxTimeCol
            // 
            this.tbxTimeCol.HeaderText = "วัน เวลา";
            this.tbxTimeCol.Name = "tbxTimeCol";
            this.tbxTimeCol.Width = 110;
            // 
            // tbxServiceNameCol
            // 
            this.tbxServiceNameCol.HeaderText = "ชื่อบริการ";
            this.tbxServiceNameCol.Name = "tbxServiceNameCol";
            this.tbxServiceNameCol.Width = 140;
            // 
            // tbxAmountCol
            // 
            this.tbxAmountCol.HeaderText = "จำนวนเงิน";
            this.tbxAmountCol.Name = "tbxAmountCol";
            this.tbxAmountCol.Width = 90;
            // 
            // lblDescriptionCol
            // 
            this.lblDescriptionCol.HeaderText = "คำอธิบาย";
            this.lblDescriptionCol.Name = "lblDescriptionCol";
            this.lblDescriptionCol.Width = 120;
            // 
            // cbxServiceStatusCol
            // 
            this.cbxServiceStatusCol.HeaderText = "สถานะ";
            this.cbxServiceStatusCol.Name = "cbxServiceStatusCol";
            this.cbxServiceStatusCol.Width = 90;
            // 
            // tbxPaymentID
            // 
            this.tbxPaymentID.HeaderText = "เลขใบชำระเงิน";
            this.tbxPaymentID.Name = "tbxPaymentID";
            this.tbxPaymentID.Width = 120;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnAddServiceCharge);
            this.flowLayoutPanel3.Controls.Add(this.btnRemoveServiceCharge);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 402);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(644, 29);
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
            // 
            // btnRemoveServiceCharge
            // 
            this.btnRemoveServiceCharge.Location = new System.Drawing.Point(109, 3);
            this.btnRemoveServiceCharge.Name = "btnRemoveServiceCharge";
            this.btnRemoveServiceCharge.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveServiceCharge.TabIndex = 1;
            this.btnRemoveServiceCharge.Text = "ลบ";
            this.btnRemoveServiceCharge.UseVisualStyleBackColor = true;
            // 
            // ServiceCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "ServiceCharge";
            this.Size = new System.Drawing.Size(650, 450);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceChargeList)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.DataGridView dgvServiceChargeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbxServiceIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbxTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbxServiceNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbxAmountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblDescriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbxServiceStatusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbxPaymentID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnAddServiceCharge;
        private System.Windows.Forms.Button btnRemoveServiceCharge;
    }
}
