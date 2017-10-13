using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apartment.UI.Dialog;
using Apartmant.Database.ApartmentDataSetTableAdapters;

namespace Apartment.UserInterface.Staff
{
    public partial class AddStaffUI : Form
    {
        public int StaffID
        {
            set;
            get;
        }

        public AddStaffOpenMode OpenMode
        {
            get;
            set;
        }

        public enum AddStaffOpenMode
        {
            Add,
            Edit,
            MyEdit,
        }
        
        public AddStaffUI()
        {
            InitializeComponent();

            SortedDictionary<byte, string> gender = new SortedDictionary<byte, string>();
            gender.Add(0, "ชาย");
            gender.Add(1, "หญิง");

            this.cbxSex.DataSource = gender.ToList() ;
            this.cbxSex.ValueMember = "Key";
            this.cbxSex.DisplayMember = "Value";
        }

        private void ValidateUI()
        {
            switch(OpenMode){
                case AddStaffOpenMode.Add:
                    lblHeader.Text = "เพิ่มพนักงาน";
                    btnSave.Text = "เพิ่ม";

                    tbxUsername.ReadOnly = false;
                    tbxPassword.ReadOnly = false;
                    tbxConfirmPassword.ReadOnly = false;
                    tbxFirstname.ReadOnly = false;
                    tbxLastname.ReadOnly = false;
                    cbxSex.Enabled = true;
                    cbxPosition.Enabled = true;
                    btnAddPosition.Enabled = true;
                    chkEnable.Enabled = true;
                    chkSuperUser.Enabled = true;
                    break;
                case AddStaffOpenMode.Edit:
                    lblHeader.Text = "แก้ไขข้อมูลพนักงาน";
                    btnSave.Text = "บันทึก";

                    tbxUsername.ReadOnly = true;
                    tbxPassword.ReadOnly = false;
                    tbxConfirmPassword.ReadOnly = false;
                    tbxFirstname.ReadOnly = false;
                    tbxLastname.ReadOnly = false;
                    cbxSex.Enabled = true;
                    cbxPosition.Enabled = true;
                    btnAddPosition.Enabled = true;
                    chkEnable.Enabled = true;
                    chkSuperUser.Enabled = true;
                    break;
                case AddStaffOpenMode.MyEdit:
                    lblHeader.Text = "แก้ไขข้อมูลพนักงาน";
                    btnSave.Text = "บันทึก";

                    tbxUsername.ReadOnly = true;
                    tbxPassword.ReadOnly = false;
                    tbxConfirmPassword.ReadOnly = false;
                    tbxFirstname.ReadOnly = true;
                    tbxLastname.ReadOnly = true;
                    cbxSex.Enabled = false;
                    cbxPosition.Enabled = false;
                    btnAddPosition.Enabled = false;
                    chkEnable.Enabled = false;
                    chkSuperUser.Enabled = false;
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            switch (OpenMode)
            {
                case AddStaffOpenMode.Add:
                    try
                    {
                        this.staffsTableAdapter.Insert(
                            tbxUsername.Text.Trim().ToLower(),
                            tbxPassword.Text.Trim(),
                            tbxFirstname.Text.Trim(),
                            tbxLastname.Text.Trim(),
                            Convert.ToByte(cbxSex.SelectedValue),
                            chkEnable.Checked == true ? (byte)1 : (byte)0,
                            chkSuperUser.Checked == true ? (byte)1 : (byte)0,
                            Convert.ToInt32(cbxPosition.SelectedValue));
                        DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        DialogResult = System.Windows.Forms.DialogResult.No;
                        throw;
                    }
                    break;
                case AddStaffOpenMode.Edit:
                case AddStaffOpenMode.MyEdit:
                    try
                    {
                        this.Validate();
                        this.staffsBindingSource.EndEdit();
                        this.staffsTableAdapter.Update(this.apartmentDataSet.Staffs);
                        DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        DialogResult = System.Windows.Forms.DialogResult.No;
                        throw;
                    }
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void AddStaffUI_Load(object sender, EventArgs e)
        {
            ValidateUI();
            switch (OpenMode)
            {
                case AddStaffOpenMode.Add:
                    this.positionsTableAdapter.Fill(this.apartmentDataSet.Positions);
                    break;
                case AddStaffOpenMode.Edit:
                case AddStaffOpenMode.MyEdit:
                    this.positionsTableAdapter.Fill(this.apartmentDataSet.Positions);
                    this.staffsTableAdapter.FillByID(this.apartmentDataSet.Staffs, StaffID);
                    break;
            }
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            InputDialog dialog = new InputDialog("Caption Here", "Default Textbox String");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string result_text = dialog.ResultText;
                this.positionsTableAdapter.Insert(result_text);
                this.positionsTableAdapter.Fill(this.apartmentDataSet.Positions);
            }
        }

        private void tbxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (tbxUsername.Text.Length < 5)
            {
                e.Cancel = false;
                MessageBox.Show("ชื่อผู้ใช้ : ยาวอย่างน้อย 6 ตัวอักษรขึ้นไป");
            }
        }

        private void tbxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbxPassword.Text.Length < 6)
            {
                e.Cancel = false;
                MessageBox.Show("รหัสผ่าน : ยาวอย่างน้อย 6 ตัวอักษรขึ้นไป");
            }
        }

        private void tbxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!tbxPassword.Text.Equals(tbxConfirmPassword.Text))
            {
                e.Cancel = false;
                MessageBox.Show("ยืนยันรหัสผ่าน : รหัสผ่านไม่ตรงกัน");
            }
        }

        private void tbxFirstname_Validating(object sender, CancelEventArgs e)
        {
            if (tbxFirstname.Text.Length < 5)
            {
                e.Cancel = false;
                MessageBox.Show("ชื่อ : ยาวอย่างน้อย 5 ตัวอักษรขึ้นไป");
            }
        }

        private void tbxLastname_Validating(object sender, CancelEventArgs e)
        {
            if (tbxLastname.Text.Length < 5)
            {
                e.Cancel = false;
                MessageBox.Show("นามสกุล : ยาวอย่างน้อย 5 ตัวอักษรขึ้นไป");
            }
        }

        private void cbxSex_Validating(object sender, CancelEventArgs e)
        {
            if (cbxSex.SelectedItem == null)
            {
                e.Cancel = false;
                MessageBox.Show("เพศ : ข้อมูลจำเป็น");
            }
        }

        private void cbxPosition_Validating(object sender, CancelEventArgs e)
        {
            if (cbxPosition.SelectedItem == null)
            {
                e.Cancel = false;
                MessageBox.Show("ตำแหน่ง : ข้อมูลจำเป็น");
            }
        }
    }
}
