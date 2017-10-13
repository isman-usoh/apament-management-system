using System.Collections.Generic;
using System;
namespace Apartment.UserInterface.Staff
{
    partial class AddStaffUI
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.staffsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet = new Apartmant.Database.ApartmentDataSet();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.tbxFirstname = new System.Windows.Forms.TextBox();
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.cbxPosition = new System.Windows.Forms.ComboBox();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.chkSuperUser = new System.Windows.Forms.CheckBox();
            this.lblComfirmPass = new System.Windows.Forms.Label();
            this.staffsTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.StaffsTableAdapter();
            this.positionsTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.PositionsTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 339);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(368, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(209, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(10);
            this.lblHeader.Size = new System.Drawing.Size(368, 50);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "เพิ่มพนักงาน";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 280);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblUsername, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPassword, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblFirstname, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.tbxPassword, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbxConfirmPassword, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.tbxUsername, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblLastname, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.lblSex, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.tbxFirstname, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.tbxLastname, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.lblPosition, 1, 13);
            this.tableLayoutPanel2.Controls.Add(this.cbxSex, 2, 11);
            this.tableLayoutPanel2.Controls.Add(this.cbxPosition, 2, 13);
            this.tableLayoutPanel2.Controls.Add(this.btnAddPosition, 3, 13);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 2, 15);
            this.tableLayoutPanel2.Controls.Add(this.lblComfirmPass, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 17;
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(366, 278);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Location = new System.Drawing.Point(26, 21);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "ชื่อผู้ใช้ : ";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Location = new System.Drawing.Point(26, 51);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "รหัสผ่าน : ";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstname
            // 
            this.lblFirstname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstname.Location = new System.Drawing.Point(26, 111);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(74, 25);
            this.lblFirstname.TabIndex = 4;
            this.lblFirstname.Text = "ชื่อ : ";
            this.lblFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPassword
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tbxPassword, 2);
            this.tbxPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffsBindingSource, "Passsword", true));
            this.tbxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPassword.Location = new System.Drawing.Point(106, 54);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(234, 20);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.UseSystemPasswordChar = true;
            this.tbxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPassword_Validating);
            // 
            // staffsBindingSource
            // 
            this.staffsBindingSource.DataMember = "Staffs";
            this.staffsBindingSource.DataSource = this.apartmentDataSet;
            // 
            // apartmentDataSet
            // 
            this.apartmentDataSet.DataSetName = "ApartmentDataSet";
            this.apartmentDataSet.Locale = new System.Globalization.CultureInfo("th");
            this.apartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxConfirmPassword
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tbxConfirmPassword, 2);
            this.tbxConfirmPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffsBindingSource, "Passsword", true));
            this.tbxConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxConfirmPassword.Location = new System.Drawing.Point(106, 84);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.Size = new System.Drawing.Size(234, 20);
            this.tbxConfirmPassword.TabIndex = 2;
            this.tbxConfirmPassword.UseSystemPasswordChar = true;
            this.tbxConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbxConfirmPassword_Validating);
            // 
            // tbxUsername
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tbxUsername, 2);
            this.tbxUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffsBindingSource, "Username", true));
            this.tbxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxUsername.Location = new System.Drawing.Point(106, 24);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(234, 20);
            this.tbxUsername.TabIndex = 0;
            this.tbxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbxUsername_Validating);
            // 
            // lblLastname
            // 
            this.lblLastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastname.Location = new System.Drawing.Point(26, 141);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(74, 25);
            this.lblLastname.TabIndex = 5;
            this.lblLastname.Text = "นามสกุล : ";
            this.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSex
            // 
            this.lblSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSex.Location = new System.Drawing.Point(26, 171);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(74, 25);
            this.lblSex.TabIndex = 12;
            this.lblSex.Text = "เพศ : ";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxFirstname
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tbxFirstname, 2);
            this.tbxFirstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffsBindingSource, "Firstname", true));
            this.tbxFirstname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFirstname.Location = new System.Drawing.Point(106, 114);
            this.tbxFirstname.Name = "tbxFirstname";
            this.tbxFirstname.Size = new System.Drawing.Size(234, 20);
            this.tbxFirstname.TabIndex = 3;
            this.tbxFirstname.Validating += new System.ComponentModel.CancelEventHandler(this.tbxFirstname_Validating);
            // 
            // tbxLastname
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tbxLastname, 2);
            this.tbxLastname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffsBindingSource, "Lastname", true));
            this.tbxLastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLastname.Location = new System.Drawing.Point(106, 144);
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(234, 20);
            this.tbxLastname.TabIndex = 4;
            this.tbxLastname.Validating += new System.ComponentModel.CancelEventHandler(this.tbxLastname_Validating);
            // 
            // lblPosition
            // 
            this.lblPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPosition.Location = new System.Drawing.Point(26, 201);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(74, 25);
            this.lblPosition.TabIndex = 15;
            this.lblPosition.Text = "ตำแหน่ง : ";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxSex
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbxSex, 2);
            this.cbxSex.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.staffsBindingSource, "Sex", true));
            this.cbxSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSex.Location = new System.Drawing.Point(106, 174);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(234, 21);
            this.cbxSex.TabIndex = 5;
            this.cbxSex.Validating += new System.ComponentModel.CancelEventHandler(this.cbxSex_Validating);
            // 
            // cbxPosition
            // 
            this.cbxPosition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.staffsBindingSource, "PositionID", true));
            this.cbxPosition.DataSource = this.positionsBindingSource;
            this.cbxPosition.DisplayMember = "PositionName";
            this.cbxPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPosition.FormattingEnabled = true;
            this.cbxPosition.Location = new System.Drawing.Point(106, 204);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(154, 21);
            this.cbxPosition.TabIndex = 6;
            this.cbxPosition.ValueMember = "PositionID";
            this.cbxPosition.Validating += new System.ComponentModel.CancelEventHandler(this.cbxPosition_Validating);
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "Positions";
            this.positionsBindingSource.DataSource = this.apartmentDataSet;
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPosition.Location = new System.Drawing.Point(263, 201);
            this.btnAddPosition.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(80, 25);
            this.btnAddPosition.TabIndex = 7;
            this.btnAddPosition.Text = "เพิ่ม";
            this.btnAddPosition.UseVisualStyleBackColor = true;
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // flowLayoutPanel2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Controls.Add(this.chkEnable);
            this.flowLayoutPanel2.Controls.Add(this.chkSuperUser);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(103, 231);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(240, 25);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.staffsBindingSource, "Enable", true));
            this.chkEnable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEnable.Location = new System.Drawing.Point(3, 3);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(96, 17);
            this.chkEnable.TabIndex = 0;
            this.chkEnable.Text = "เปิดใช้งานผู้ใช้";
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // chkSuperUser
            // 
            this.chkSuperUser.AutoSize = true;
            this.chkSuperUser.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.staffsBindingSource, "SuperUser", true));
            this.chkSuperUser.Location = new System.Drawing.Point(105, 3);
            this.chkSuperUser.Name = "chkSuperUser";
            this.chkSuperUser.Size = new System.Drawing.Size(86, 17);
            this.chkSuperUser.TabIndex = 1;
            this.chkSuperUser.Text = "ตั้งเป็นผู้ดูแล";
            this.chkSuperUser.UseVisualStyleBackColor = true;
            // 
            // lblComfirmPass
            // 
            this.lblComfirmPass.Location = new System.Drawing.Point(26, 81);
            this.lblComfirmPass.Name = "lblComfirmPass";
            this.lblComfirmPass.Size = new System.Drawing.Size(74, 23);
            this.lblComfirmPass.TabIndex = 20;
            this.lblComfirmPass.Text = "ยืนยันรหัสผ่าน : ";
            this.lblComfirmPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // staffsTableAdapter
            // 
            this.staffsTableAdapter.ClearBeforeFill = true;
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // AddStaffUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 371);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStaffUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มพนักงาน";
            this.Load += new System.EventHandler(this.AddStaffUI_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFirstname;
        public System.Windows.Forms.TextBox tbxPassword;
        public System.Windows.Forms.TextBox tbxConfirmPassword;
        public System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblSex;
        public System.Windows.Forms.TextBox tbxFirstname;
        public System.Windows.Forms.TextBox tbxLastname;
        private System.Windows.Forms.Label lblPosition;
        public System.Windows.Forms.ComboBox cbxSex;
        public System.Windows.Forms.ComboBox cbxPosition;
        private System.Windows.Forms.Button btnAddPosition;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.CheckBox chkSuperUser;
        private System.Windows.Forms.Label lblComfirmPass;
        private Apartmant.Database.ApartmentDataSet apartmentDataSet;
        private System.Windows.Forms.BindingSource staffsBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.StaffsTableAdapter staffsTableAdapter;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private Apartmant.Database.ApartmentDataSetTableAdapters.PositionsTableAdapter positionsTableAdapter;


    }

}