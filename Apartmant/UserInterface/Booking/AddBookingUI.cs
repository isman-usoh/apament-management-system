using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apartment.UserInterface.Service;
using Apartmant.Database.ApartmentDataSetTableAdapters;

namespace Apartment.UserInterface.Booking
{
    public partial class AddBookingUI : Form
    {
        public AddBookingUI()
        {
            InitializeComponent();
        }

        private void BookingUI_Load(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now.AddDays(-1);
            DateTime now = new DateTime(
                start.Year,
                start.Month,
                start.Day,
                00, 00, 00);
            dtpStarStay.Value = now;
            dtpStarStay.MinDate = now;
            dtpStarStay.MaxDate = now.AddDays(30);

            
            this.roomsTableAdapter.FillByRoomCheckInCheck(apartmentDataSet.Rooms, dtpStarStay.Value, dtpEndStay.Value);
            this.roomTypesTableAdapter.Fill(this.apartmentDataSet.RoomTypes);
            this.customerTypesTableAdapter.Fill(this.apartmentDataSet.CustomerTypes);

            loadDate();
        }

        private void loadDate()
        {
            if (this.cbxCustomerType.SelectedIndex == 0)
            {
                lblPriceLabel.Text = "ราคาต่อเดือน :";
                dtpEndStay.Enabled = false;
                DateTime date = dtpStarStay.Value.AddMonths(1);
                this.dtpEndStay.Value = new DateTime(date.Year, date.Month, 5, 00, 00, 00);
            }
            else
            {
                lblPriceLabel.Text = "ราคาต่อวัน :";
                dtpEndStay.Enabled = true;
                dtpEndStay.MinDate = dtpStarStay.Value.AddDays(1);
                dtpEndStay.Value = dtpStarStay.Value.AddDays(1);
            }
            this.roomsTableAdapter.FillByRoomCheckInCheck(apartmentDataSet.Rooms, dtpStarStay.Value, dtpEndStay.Value);
        }   

        private void dtpStarStay_ValueChanged(object sender, EventArgs e)
        {
            loadDate();
            this.roomsTableAdapter.FillByRoomCheckInCheck(apartmentDataSet.Rooms, dtpStarStay.Value, dtpEndStay.Value);
        }
        
        private void dtpEndStay_ValueChanged(object sender, EventArgs e)
        {
            loadDate();
            this.roomsTableAdapter.FillByRoomCheckInCheck(apartmentDataSet.Rooms, dtpStarStay.Value, dtpEndStay.Value);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            try
            {
                BookingTableAdapter bookingTableAdapter = new BookingTableAdapter();
                bookingTableAdapter.Insert(
                    tbxFirstname.Text,
                    tbxLastname.Text,
                    tbxAddress.Text,
                    cbxProvince.Text,
                    tbxTelephone.Text,
                    tbxEmail.Text,
                    Convert.ToInt32(cbxCustomerType.SelectedValue),
                    Convert.ToInt32(cbxRoomType.SelectedValue),
                    Convert.ToInt32(cbxRoom.SelectedValue),
                    DateTime.Now,
                    0,
                    dtpStarStay.Value,
                    dtpEndStay.Value);
                MessageBox.Show("บันทึกการจองห้องเสร็จสมบูรณ์", "เสร็จสมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ไม่สามารถบันทึกการจองห้องได้, กรุณาลองใหม่อีกครั้ง", "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(ex.ToString());
                this.DialogResult = System.Windows.Forms.DialogResult.No;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDate();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
