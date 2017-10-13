using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apartment.UserInterface.Service;

namespace Apartment.UserInterface.IUserControl
{
    public partial class RoomDetail : UserControl
    {
        public Boolean Booking { get; set; }
        public ChangeDateCallback ChangeDateCallback { set; get; }

        public RoomDetail()
        {
            InitializeComponent();
        }

        private void RoomDetail_Load(object sender, EventArgs e){
            DateTime start = DateTime.Now.AddDays(-1);
            DateTime now = new DateTime(
                start.Year,
                start.Month,
                start.Day,
                00, 00, 00);
            dtpStarStay.Value = now;
            dtpStarStay.MinDate = now;
            dtpStarStay.MaxDate = now.AddDays(2);




            loadDate();
        }

        private void loadDate() {
            if (this.cbxCustomerType.SelectedIndex == 0)
            {
                lblPriceLable.Text = "ราคาต่อเดือน :";
                dtpEndStay.Enabled = false;
                DateTime date = dtpStarStay.Value.AddMonths(1);
                this.dtpEndStay.Value = new DateTime(date.Year, date.Month, 5, 00, 00, 00);
            }
            else
            {
                lblPriceLable.Text = "ราคาต่อวัน :";
                dtpEndStay.Enabled = true;
                dtpEndStay.MinDate = dtpStarStay.Value.AddDays(1);
                dtpEndStay.Value = dtpStarStay.Value.AddDays(1);
            }
        }

        private void cbxCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDate();
        }

        private void dtpStarStay_ValueChanged(object sender, EventArgs e)
        {
            if (Booking)
                return;
            ChangeDateCallback.onChange();
            loadDate();
        }

        private void dtpEndStay_ValueChanged(object sender, EventArgs e)
        {
            if (Booking)
                return;
            ChangeDateCallback.onChange();
        }

        private void cbxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
