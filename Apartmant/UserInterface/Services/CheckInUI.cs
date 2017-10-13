using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apartment.UserInterface.Payment;
using UI;
using Apartmant.Database.ApartmentDataSetTableAdapters;
using Apartmant.UserInterface.Services;

namespace Apartment.UserInterface.Service
{
    public partial class CheckInUI : Form,ChangeDateCallback
    {
        public int BookingID
        {
            get;
            set;
        }
        
        public CheckInUI()
        {
            InitializeComponent();
        }

        private void CheckInUI_Load(object sender, EventArgs e)
        {
            loadDataSource();
        }

        private void loadDataSource()
        {


            if (BookingID == 0)
            {
                this.roomDetailPanel.roomsTableAdapter.FillByRoomCheckInCheck(roomDetailPanel.apartmentDataSet.Rooms, roomDetailPanel.dtpStarStay.Value, roomDetailPanel.dtpEndStay.Value);
            }
            else
            {
                BookingTableAdapter bookingTableAdapter = new BookingTableAdapter();
                Apartmant.Database.ApartmentDataSet.BookingDataTable booking = bookingTableAdapter.GetDataByID(BookingID);

                this.roomDetailPanel.Booking = true;
                this.roomDetailPanel.roomsTableAdapter.FillByID(roomDetailPanel.apartmentDataSet.Rooms, booking[0].RoomID);
                this.roomDetailPanel.dtpStarStay.Value = booking[0].StartStay;
                this.roomDetailPanel.dtpStarStay.Enabled = false;
                this.roomDetailPanel.dtpEndStay.Value = booking[0].EndStay;
                this.roomDetailPanel.dtpEndStay.Enabled = false;
               


                this.customerDetailPanel.tbxFirstname.Text = booking[0].Firstname;
                this.customerDetailPanel.tbxLastname.Text = booking[0].Lastname;
                this.customerDetailPanel.tbxAddress.Text = booking[0].Address;
                this.customerDetailPanel.cbxProvince.SelectedItem = booking[0].Province;
            }
            this.roomDetailPanel.roomTypesTableAdapter.Fill(roomDetailPanel.apartmentDataSet.RoomTypes);
            this.roomDetailPanel.customerTypesTableAdapter.Fill(roomDetailPanel.apartmentDataSet.CustomerTypes);

            this.roomDetailPanel.ChangeDateCallback = this;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (!this.customerDetailPanel.ValidateChildren())
            {
                tabControl1.SelectedIndex = 0;
                return;
            }
            if (this.roomDetailPanel.cbxRoomNO.SelectedItem == null)
            {
                MessageBox.Show("คุณยังไม่ได้เลือกห้องพัก", "คุณยังไม่ได้เลือกห้องพัก", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl1.SelectedIndex = 1;
                return;
            }

            double amountRoom = 0;
            double roomPrices = Convert.ToDouble(((DataRowView)this.roomDetailPanel.fKRoomTypesCustomerTypesBindingSource.Current).Row["Prices"]);
            if (Convert.ToInt32(this.roomDetailPanel.cbxCustomerType.SelectedValue) == 1)
            {
                int days = this.roomDetailPanel.dtpEndStay.Value.Subtract(this.roomDetailPanel.dtpStarStay.Value).Days;
                if (days < 30)
                {
                    amountRoom = (roomPrices / 30) * days;
                    Console.WriteLine("รายเดือน "+amountRoom + " " + days);
                }
            }
            else if (Convert.ToInt32(this.roomDetailPanel.cbxCustomerType.SelectedValue) == 2)
            {
                int days = this.roomDetailPanel.dtpEndStay.Value.Subtract(this.roomDetailPanel.dtpStarStay.Value).Days;
                amountRoom = roomPrices * days;
                Console.WriteLine("รายวัน "+amountRoom + " " + days);
            }
            


            try
            {
                CustomersTableAdapter customerTableAdapter = new CustomersTableAdapter();

                customerTableAdapter.Insert(
                    this.customerDetailPanel.tbxPeopleID.Text,
                    this.customerDetailPanel.tbxFirstname.Text,
                    this.customerDetailPanel.tbxLastname.Text,
                    Convert.ToByte(this.customerDetailPanel.cbxSex.SelectedIndex),
                    this.customerDetailPanel.dtpBirthDay.Value,
                    this.customerDetailPanel.tbxAddress.Text,
                    this.customerDetailPanel.tbxSubDistrict.Text,
                    this.customerDetailPanel.tbxDistrict.Text,
                    this.customerDetailPanel.cbxProvince.SelectedItem.ToString(),
                    this.customerDetailPanel.cbxCountry.SelectedItem.ToString(),
                    this.customerDetailPanel.tbxTelephone.Text,
                    this.customerDetailPanel.tbxMobile.Text,
                    this.customerDetailPanel.tbxEmail.Text);



                CustomerTypesTableAdapter customerTypesTableAdapter = new CustomerTypesTableAdapter();
                RoomTypesTableAdapter roomTypesTableAdapter = new RoomTypesTableAdapter();
                CheckInsTableAdapter checkInsTableAdapter = new CheckInsTableAdapter();
                RoomsTableAdapter roomsTableAdapter = new RoomsTableAdapter();
                int customerID = Convert.ToInt32(customerTableAdapter.GetMaxID());

                if (BookingID == 0)
                {
                    checkInsTableAdapter.Insert(
                        customerID,
                        Convert.ToInt32(roomDetailPanel.cbxCustomerType.SelectedValue),
                        customerTypesTableAdapter.GetCustomerTypeName(Convert.ToInt32(roomDetailPanel.cbxCustomerType.SelectedValue)),
                        Convert.ToInt32(roomDetailPanel.cbxRoomType.SelectedValue),
                        roomTypesTableAdapter.GetRoomTypeName(Convert.ToInt32(roomDetailPanel.cbxRoomType.SelectedValue)),
                        Convert.ToInt32(this.roomDetailPanel.roomsTableAdapter.GetRoomID(((DataRowView)roomDetailPanel.fKRoomsRoomTypesBindingSource.Current).Row["NO"].ToString())),
                        ((DataRowView)roomDetailPanel.fKRoomsRoomTypesBindingSource.Current).Row["NO"].ToString(),
                        roomPrices,
                        roomDetailPanel.dtpStarStay.Value,
                        roomDetailPanel.dtpEndStay.Value,
                        roomDetailPanel.tbxDescription.Text,
                        MainUI.StaffID,
                        null,
                        DateTime.Now,
                        null,
                        0);
                }
                else
                {
                    checkInsTableAdapter.Insert(
                        customerID,
                        Convert.ToInt32(roomDetailPanel.cbxCustomerType.SelectedValue),
                        customerTypesTableAdapter.GetCustomerTypeName(Convert.ToInt32(roomDetailPanel.cbxCustomerType.SelectedValue)),
                        Convert.ToInt32(roomDetailPanel.cbxRoomType.SelectedValue),
                        roomTypesTableAdapter.GetRoomTypeName(Convert.ToInt32(roomDetailPanel.cbxRoomType.SelectedValue)),
                         Convert.ToInt32(this.roomDetailPanel.roomsTableAdapter.GetRoomID(((DataRowView)roomDetailPanel.fKRoomsRoomTypesBindingSource.Current).Row["NO"].ToString())),
                        ((DataRowView)roomDetailPanel.fKRoomsRoomTypesBindingSource.Current).Row["NO"].ToString(),
                        roomPrices,
                        roomDetailPanel.dtpStarStay.Value,
                        roomDetailPanel.dtpEndStay.Value,
                        roomDetailPanel.tbxDescription.Text,
                        MainUI.StaffID,
                        BookingID,
                        DateTime.Now,
                        null,
                        0);
                }


                PaymentsTableAdapter paymentsTableAdapter = new PaymentsTableAdapter();
                int checKInID = Convert.ToInt32(checkInsTableAdapter.GetMaxID());
                paymentsTableAdapter.Insert(
                    checKInID,
                    this.roomDetailPanel.dtpStarStay.Value,
                    this.roomDetailPanel.dtpEndStay.Value,
                    (int)amountRoom,
                    0,
                    (int)amountRoom,
                    null,
                    0,
                    null,
                    null);


                MessageBox.Show("เช็คอินเสร็จสมบูรณ์", "เสร็จสมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //เปิดหน้าชำระเงิน
                PaymentDetailUI payment = new PaymentDetailUI();
                payment.PaymentID = Convert.ToInt32(paymentsTableAdapter.GetMaxID());
                payment.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                MessageBox.Show("ไม่สามารถเช็คอินได้, กรุณาลองใหม่อีกครั้ง ", "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = System.Windows.Forms.DialogResult.No;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        public void onChange()
        {
            this.roomDetailPanel.roomsTableAdapter.FillByRoomCheckInCheck(roomDetailPanel.apartmentDataSet.Rooms, roomDetailPanel.dtpStarStay.Value, roomDetailPanel.dtpEndStay.Value);
        }

    }

    public interface ChangeDateCallback
    {
        void onChange();
    }
}
