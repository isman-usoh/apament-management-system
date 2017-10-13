using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UI;
using Apartmant.UserInterface.Booking;

namespace Apartment.UserInterface.Booking
{
    public partial class BookingManageUI : Form
    {
        public BookingManageUI()
        {
            InitializeComponent();
        }

        private void BookingManageUI_Load(object sender, EventArgs e)
        {
            this.bookingViewTableAdapter.Fill(this.apartmentDataSet.BookingView);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBookingList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BookingViewUI bookingUI = new BookingViewUI();
            bookingUI.BookingID = Convert.ToInt32(((DataRowView)bookingViewBindingSource[e.RowIndex]).Row["BookingID"]);
            bookingUI.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bookingViewBindingSource.Filter = @"Firstname LIKE '%" + textBox1.Text + "%' OR Lastname LIKE '%" + textBox1.Text + "%' OR BookingID = " + textBox1.Text;
            }
            catch
            {
                bookingViewBindingSource.Filter = "";
            }
        }
    }
}
