using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Apartment.UserInterface.Room
{
    public partial class RoomTypeManageUI : Form
    {
        public RoomTypeManageUI()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRoomTypeUI addRoomTypeUI = new AddRoomTypeUI();
            if (DialogResult.Yes.Equals(addRoomTypeUI.ShowDialog()))
                this.roomTypesTableAdapter.Fill(this.apartmentDataSet.RoomTypes);
        }

        private void RoomTypeManageUI_Load(object sender, EventArgs e)
        {
            this.roomTypesTableAdapter.Fill(this.apartmentDataSet.RoomTypes);
            this.customerTypesTableAdapter.Fill(this.apartmentDataSet.CustomerTypes);
        }

        private void dgvRoomTypeList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            AddRoomTypeUI AddRoomUI = new AddRoomTypeUI();
            AddRoomUI.RoomTypeID = Convert.ToInt32(((DataRowView)fKRoomTypesCustomerTypesBindingSource[e.RowIndex]).Row["RoomTypeID"]);
            if (DialogResult.Yes.Equals(AddRoomUI.ShowDialog()))
                this.roomTypesTableAdapter.Fill(this.apartmentDataSet.RoomTypes);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
