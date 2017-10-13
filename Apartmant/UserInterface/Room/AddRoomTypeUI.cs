using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apartmant.Database.ApartmentDataSetTableAdapters;

namespace Apartment.UserInterface.Room
{
    public partial class AddRoomTypeUI : Form
    {   
        public int RoomTypeID
        {
            get;
            set;
        }

        public AddRoomTypeUI()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (RoomTypeID == 0)
            {
                try
                {
                    RoomTypesTableAdapter roomTypesTableAdapter = new RoomTypesTableAdapter();
                    roomTypesTableAdapter.Insert(
                        tbxRoomTypeName.Text.Trim(),
                        Convert.ToInt32(cbxCustomerType.SelectedValue),
                        Convert.ToDouble(tbxPrice.Text),
                        tbxDescription.Text.Trim());

                    MessageBox.Show("บันทึกเสร็จสมบูรณ์");
                    DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("ไม่สามารถบันทึกได้");
                    DialogResult = System.Windows.Forms.DialogResult.No;
                    throw;
                }
            }
            else
            {
                try
                {
                    this.roomTypesBindingSource.EndEdit();
                    this.roomTypesTableAdapter.Update(this.apartmentDataSet.RoomTypes);
                    MessageBox.Show("บันทึกเสร็จสมบูรณ์");
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());

                    MessageBox.Show("ไม่สามารถบันทึกได้");
                    DialogResult = System.Windows.Forms.DialogResult.No;
                    throw;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void AddRoomTypeUI_Load(object sender, EventArgs e)
        {
            this.customerTypesTableAdapter.Fill(this.apartmentDataSet.CustomerTypes);
            
            if (RoomTypeID != 0)
            {
                this.roomTypesTableAdapter.FillByID(this.apartmentDataSet.RoomTypes, RoomTypeID);
                cbxCustomerType.Enabled = false;
                tbxRoomTypeName.ReadOnly = true;
                tbxPrice.ReadOnly = true;
            }
        }
    }
}
