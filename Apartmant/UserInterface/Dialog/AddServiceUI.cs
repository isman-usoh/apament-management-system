using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apartment;

namespace UI
{
    public partial class AddServiceUI : Form
    {
        public int CheckInID { get; set; }

        public AddServiceUI()
        {
            InitializeComponent();
        }

        private void AddServiceUI_Load(object sender, EventArgs e)
        {
            this.serviceChargesTableAdapter.Fill(this.apartmentDataSet.ServiceCharges);
            if (CheckInID != 0)
            {
                this.roomsTableAdapter.FillByCheckInID(apartmentDataSet.Rooms, CheckInID);
                this.cbxRoomNO.Enabled = false;
            }
            else
            {
                DateTime now = DateTime.Now;

                if (now.Hour < 12)
                {
                    now = now.AddDays(-1);
                    now = new DateTime(now.Year, now.Month, now.Day, 0, 00, 00);
                }
                else
                {
                    now = new DateTime(now.Year, now.Month, now.Day, 0, 00, 00);
                }
                this.roomsTableAdapter.FillByDate(this.apartmentDataSet.Rooms, now, now.AddDays(1));
            }
        }

        private void tbxSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.serviceChargesTableAdapter.Insert(
                    Convert.ToInt32(((DataRowView)roomsBindingSource.Current).Row["CheckInID"]),
                    null,
                    DateTime.Now,
                    cbxServiceName.Text,
                    Convert.ToDouble(tbxAmount.Text),
                    tbxDescription.Text
                    );
                MessageBox.Show("บันทึกเสร็จสมบูรณ์", "เสร็จสมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("ไม่สามารถบันทึกได้, กรุณาลองใหม่อีกครั้ง", "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = System.Windows.Forms.DialogResult.No;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
