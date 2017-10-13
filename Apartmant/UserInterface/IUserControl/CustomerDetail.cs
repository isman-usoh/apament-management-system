using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Apartment.UserInterface.IUserControl
{
    public partial class CustomerDetail : UserControl
    {
        
        public CustomerDetail()
        {
            InitializeComponent();
        }

        private void tbxPeopleID_Validated(object sender, CancelEventArgs e)
        {
            string sPattern = "^\\d{1}-\\d{4}-\\d{5}-\\d{2}-\\d{1}$";

            if (!Regex.IsMatch(tbxPeopleID.Text.Trim(), sPattern))
            {
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.Show("เลขประจำตัวประชาชนคุณไม่ถูกต้อง : " + this.tbxPeopleID.Text, this.tbxPeopleID, 5000);
                e.Cancel = true;
            }
        }

        private void tbxFirstname_Validated(object sender, CancelEventArgs e)
        {
            if (tbxFirstname.Text.Length < 4)
            {
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.Show("กรุณาป้อนชื่อของผู้เช่า", this.tbxFirstname, 5000);
                e.Cancel = true;
            }
        }

        private void tbxLastname_Validated(object sender, CancelEventArgs e)
        {
            if (tbxLastname.Text.Length < 4)
            {
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.Show("กรุณาป้อนนามสกุลของผู้เช่า", this.tbxLastname, 5000);
                e.Cancel = true;
            }
        }

        private void tbxAddress_Validated(object sender, CancelEventArgs e)
        {
            if (tbxAddress.Text.Trim() == "")
            {
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.Show("กรุณาป้อนทีอยู่ของผู้เช่า", this.tbxAddress, 5000);
                e.Cancel = true;
            }
        }
        
        private void cbxProvince_Validated(object sender, CancelEventArgs e)
        {
            if (cbxProvince.SelectedItem == null)
            {
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.Show("กรุณาเลือกจังหวัดของผู้เช่า", this.cbxProvince, 5000);
                e.Cancel = true;
            }
        }
        
        private void cbxCountry_Validated(object sender, CancelEventArgs e)
        {
            if (cbxCountry.SelectedItem == null)
            {
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.Show("กรุณาเลือกปรเทศของผู้เช่า", this.cbxCountry, 5000);
                e.Cancel = true;
            }
        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {
            SortedDictionary<byte, string> gender = new SortedDictionary<byte, string>();
            gender.Add(0, "ชาย");
            gender.Add(1, "หญิง");

            this.cbxSex.DataSource = gender.ToList();
            this.cbxSex.ValueMember = "Key";
            this.cbxSex.DisplayMember = "Value";
        }
    }
}
