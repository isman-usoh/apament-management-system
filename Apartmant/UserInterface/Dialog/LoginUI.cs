using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apartmant.Database.ApartmentDataSetTableAdapters;

namespace UI
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text.ToLower().Equals("ap") && tbxPassword.Text.Equals(Apartmant.Properties.Settings.Default.apPassword))
            {
                if (DialogResult.Yes.Equals(MessageBox.Show("คุณกำลังเข้าใช้งานโหมดตั้งค่า ฟังก์ชันการทำงานจะถูกผิดไว้ อณุญาติให้แก้ไขการเชื่อมต่อ ฐานข้อมูลเท่านั้น , กดใช้เพือเข้าใช้งานโหมดนี้หรือกดไม่เพือล็อกอินใหม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Information)))
                {
                    MainUI.StaffID = -13131;
                    DialogResult = System.Windows.Forms.DialogResult.Yes;
                    this.Close();
                }
            }
            else
            {
                StaffsTableAdapter staffsTableAdapter = new StaffsTableAdapter();
                Apartmant.Database.ApartmentDataSet.StaffsDataTable staff = staffsTableAdapter.GetStaffLogin(tbxUsername.Text.ToLower().Trim(), tbxPassword.Text);

                if (staff.Count == 0)
                {
                    MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MainUI.StaffID = staff[0].StaffID;
                    MainUI.SuperUser = Convert.ToBoolean(staff[0].SuperUser);
                    DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
