using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apartment.UserInterface.Room;

namespace Apartment.UserInterface.Room
{
    public partial class RoomManageUI : Form
    {
        public RoomManageUI()
        {
            InitializeComponent();
            Dictionary<byte, string> dRoomStatus = new Dictionary<byte, string>();
            dRoomStatus.Add(0, "ว่าง");
            dRoomStatus.Add(1, "ไม่ว่าง");
            dRoomStatus.Add(2, "กำลังทำความสะอาด");
            dRoomStatus.Add(3, "ปิดปรับปรุง");


            this.statusDataGridViewComboBoxColumn.ValueMember = "Key";
            this.statusDataGridViewComboBoxColumn.DisplayMember = "Value";
            this.statusDataGridViewComboBoxColumn.DataSource = dRoomStatus.ToList();
        }
        
        private void RoomManageUI_Load(object sender, EventArgs e)
        {
            this.roomsTableAdapter.Fill(this.apartmentDataSet.Rooms);
            this.roomTypesTableAdapter.Fill(this.apartmentDataSet.RoomTypes);
            this.customerTypesTableAdapter.Fill(this.apartmentDataSet.CustomerTypes);
        }

        private void btnRoomManager_Click(object sender, EventArgs e)
        {
            RoomTypeManageUI roomTypeManageUI = new RoomTypeManageUI();
            roomTypeManageUI.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoomUI AddRoomUI = new AddRoomUI();
            if (DialogResult.Yes.Equals(AddRoomUI.ShowDialog()))
                this.roomsTableAdapter.Fill(this.apartmentDataSet.Rooms);
        }

        private void dgvRoomList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            AddRoomUI AddRoomUI = new AddRoomUI();
            AddRoomUI.RoomID = Convert.ToInt32(((DataRowView)fKRoomsRoomTypesBindingSource[e.RowIndex]).Row["RoomID"]);
            if (DialogResult.Yes.Equals(AddRoomUI.ShowDialog()))
                this.roomsTableAdapter.Fill(this.apartmentDataSet.Rooms);
        }
    }
}
