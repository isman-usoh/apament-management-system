using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apartment.UserInterface.Booking;
using Apartment.UserInterface.Service;
using Apartment.UserInterface.Staff;
using Apartment.UserInterface.Room;
using Apartment.UserInterface.Payment;
using Apartmant.Report;
using Apartmant.UserInterface.Setting;
using Apartmant.Database.ApartmentDataSetTableAdapters;
using Apartmant.UserInterface.Utility;

namespace UI
{
    public partial class MainUI : Form
    {

        public static int StaffID
        {
            get;
            set;
        }
        
        public static Boolean SuperUser
        {
            get;
            set;
        }

        public MainUI()
        {
            InitializeComponent();
            StaffID = 2;
            SuperUser = true;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckInUI checkInUI = new CheckInUI();
            checkInUI.ShowDialog();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            AddBookingUI bookingUI = new AddBookingUI();
            bookingUI.ShowDialog();
        }

        private void btnServiceCharge_Click(object sender, EventArgs e)
        {
            AddServiceUI addServiceUI = new AddServiceUI();
            addServiceUI.ShowDialog();
        }

        private void btnUtility_Click(object sender, EventArgs e)
        {
            SelectMonthUI month = new SelectMonthUI(this);
            month.ShowDialog();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            tsmiManager.Visible = SuperUser;
            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();




            loadDatasource();
            //StaffLogin();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnBookingMgn_Click(object sender, EventArgs e)
        {
            BookingManageUI BookingManageUI = new BookingManageUI();
            BookingManageUI.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PaymentPreview pay = new PaymentPreview();
            pay.ShowDialog();
            //loadDatasource();
        }

        private void StaffLogin()
        {
            LoginUI loginUI = new LoginUI();
            if (DialogResult.Yes.Equals(loginUI.ShowDialog()))
            {
                if (StaffID == -13131)
                {
                    lblHeader.Text = "Apartment Manager System (Configuration Mode)";
                    tsmiStaff.Visible = false;
                    tsmiManager.Visible = false;
                    tsmiOption.Visible = true;
                    tableLayoutPanel2.Enabled = false ;
                }
                else
                {
                    lblHeader.Text = "Apartment Manager System";
                    tableLayoutPanel2.Enabled = true;
                    tsmiOption.Visible = false;
                    tsmiManager.Visible = SuperUser;
                }
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void loadDatasource()
        {
            DateTime dDate = DateTime.Now;
            if (dDate.Hour < 12)
            {
                dDate.AddDays(-1);
            }

            this.checkInsTableAdapter.FillCheckIng(this.apartmentDataSet.CheckIns);
            this.customerTypesTableAdapter.Fill(this.apartmentDataSet.CustomerTypes);
            


            RoomsTableAdapter roomsTableAdapter = new RoomsTableAdapter();
            int roomCount = Convert.ToInt32(roomsTableAdapter.GetRoomCount());
            int roomUserCount = Convert.ToInt32(checkInsTableAdapter.GetCheckInRoomCount(dDate));
            int roomType1 = Convert.ToInt32(checkInsTableAdapter.GetCkeckInRoomTypeCount(1,dDate));
            int roomType2 = Convert.ToInt32(checkInsTableAdapter.GetCkeckInRoomTypeCount(2,dDate));

            lblTotalRoom.Text = roomCount + "";
            lblUseRoom.Text = roomUserCount + "";
            lblRoomEmtry.Text = roomCount - roomUserCount + "";
            
            lblUse1.Text = roomType1 + "";
            lblUse2.Text = roomType2 + "";
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            loadDatasource();
        }

        private void cbxCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxRoomNO_TextChanged(object sender, EventArgs e)
        {
            loadDatasource();
        }

        private void dgvRoomList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            RoomDetailUI roomDetailUI = new RoomDetailUI();
            roomDetailUI.CheckInID = Convert.ToInt32(((DataRowView)this.fKCheckInsCustomerTypesBindingSource[e.RowIndex]).Row["CheckInID"]);
            if(DialogResult.Yes.Equals(roomDetailUI.ShowDialog()))
                this.checkInsTableAdapter.FillCheckIng(this.apartmentDataSet.CheckIns);
        }

        private void tsmiLogoutItem_Click(object sender, EventArgs e)
        {
            StaffID = 0;
            this.Hide();
            StaffLogin();
        }

        private void tsmiAboutItem_Click(object sender, EventArgs e)
        {
            AboutApp AboutApp = new AboutApp();
            AboutApp.ShowDialog();
        }

        private void tsmiCloseItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากโปรแกรมนี้ใช้หรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Information).Equals(DialogResult.Yes))
                this.Close();
        }

        private void tsmiDataOption_Click(object sender, EventArgs e)
        {
            OptionUI optionUi = new OptionUI();
            optionUi.ShowDialog();
        }

        private void tsmiConfigItem_Click(object sender, EventArgs e)
        {
            OptionUI optionUi = new OptionUI();
            optionUi.ShowDialog();
        }

        private void tsmiAddStaff_Click(object sender, EventArgs e)
        {
            AddStaffUI addStaffUI = new AddStaffUI();
            addStaffUI.OpenMode = AddStaffUI.AddStaffOpenMode.Add;
            addStaffUI.ShowDialog();
        }

        private void tsmiStaffManager_Click(object sender, EventArgs e)
        {
            StaffManageUI staffManageUI = new StaffManageUI();
            staffManageUI.ShowDialog();
        }

        private void tsmiRoomManage_Click(object sender, EventArgs e)
        {
            RoomManageUI staffManageUI = new RoomManageUI();
            staffManageUI.ShowDialog();
        }

        private void tsmiRoomTypeManager_Click(object sender, EventArgs e)
        {
            RoomTypeManageUI roomTypeManageUI = new RoomTypeManageUI();
            roomTypeManageUI.ShowDialog();
        }

        private void tsmiChangePasswordItem_Click(object sender, EventArgs e)
        {
            AddStaffUI addStaffUI = new AddStaffUI();
            addStaffUI.OpenMode = AddStaffUI.AddStaffOpenMode.MyEdit;
            addStaffUI.StaffID = StaffID;
            addStaffUI.Text = "เปลี่ยนรหัสผ่าน";
            addStaffUI.lblHeader.Text = "เปลี่ยนรหัสผ่าน";

            addStaffUI.tbxFirstname.Enabled = false;
            addStaffUI.tbxLastname.Enabled = false;
            addStaffUI.cbxPosition.Enabled = false;
            addStaffUI.tbxUsername.Enabled = false;
            addStaffUI.cbxSex.Enabled = false;
            addStaffUI.ShowDialog();
        }
    }
}
