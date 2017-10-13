using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Apartment.UserInterface.Staff
{
    public partial class StaffManageUI : Form
    {
        public StaffManageUI()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStaffUI addStaffUI = new AddStaffUI();
            addStaffUI.OpenMode = AddStaffUI.AddStaffOpenMode.Add;
            if (DialogResult.Yes.Equals(addStaffUI.ShowDialog()))
                this.staffsTableAdapter.Fill(this.apartmentDataSet.Staffs);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StaffManageUI_Load(object sender, EventArgs e)
        {
            this.staffsTableAdapter.Fill(this.apartmentDataSet.Staffs);
            this.positionsTableAdapter.Fill(this.apartmentDataSet.Positions);
        }

        private void dgvStaffList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            AddStaffUI addStaffUI = new AddStaffUI();
            addStaffUI.OpenMode = AddStaffUI.AddStaffOpenMode.Edit;
            addStaffUI.StaffID = Convert.ToInt32(((DataRowView)fKStaffsPositionsBindingSource[e.RowIndex]).Row["StaffID"]);
            if(DialogResult.Yes.Equals(addStaffUI.ShowDialog()))
                this.staffsTableAdapter.Fill(this.apartmentDataSet.Staffs);
        }
    }
}
