using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apartmant.Database.ApartmentDataSetTableAdapters;
using Apartment.UserInterface.Service;

namespace Apartmant.UserInterface.Booking
{
    public partial class BookingViewUI : Form
    {
        public int BookingID { get; set; }
        
        public BookingViewUI()
        {
            InitializeComponent();
        }

        private void BookingView_Load(object sender, EventArgs e)
        {
            loadDataSource();
        }

        private void loadDataSource()
        {
            this.bookingViewTableAdapter.FillByID(this.apartmentDataSet.BookingView, BookingID);
            byte bookingStatus = Convert.ToByte(((DataRowView)bookingViewBindingSource.Current).Row["BookingStatus"]);
            if (bookingStatus == 0)
            {
                lblBookingStatus.Text = "Ready";
            }
            else if (bookingStatus == 1)
            {
                lblBookingStatus.Text = "CheckIn";
            }
            else if (bookingStatus == 2)
            {

            }
            else if (bookingStatus == 3)
            {
                lblBookingStatus.Text = "Cancel";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckInUI checkInUI = new CheckInUI();
            checkInUI.BookingID = BookingID;
            checkInUI.Show();
            this.Close();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("คุณต้องการยกเลิกการจองใช้หรือไม่", "ยกเลิกการจอง", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(System.Windows.Forms.DialogResult.Yes))
            {
                BookingTableAdapter bookingTableAdapter = new BookingTableAdapter();
                bookingTableAdapter.CancelBooking(BookingID);
                MessageBox.Show("ยกเลิกการจองเสร็จสมบูรณ์", "ยกเลิกการจองเสร็จสมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            loadDataSource();
        }
    }
}
