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
    public partial class AddRoomUI : Form
    {   
        public int RoomID
        {
            get;
            set;
        }
        
        public AddRoomUI()
        {
            InitializeComponent();


            Dictionary<byte, string> dRoomStatus = new Dictionary<byte, string>();
            dRoomStatus.Add(0, "ว่าง");
            dRoomStatus.Add(1, "ไม่ว่าง");
            dRoomStatus.Add(2, "กำลังทำความสะอาด");
            dRoomStatus.Add(3, "ปิดปรับปรุง");
            this.cbxRoomStatus.ValueMember = "Key";
            this.cbxRoomStatus.DisplayMember = "Value";
            this.cbxRoomStatus.DataSource = dRoomStatus.ToList();
        }

        private void AddRoomUI_Load(object sender, EventArgs e)
        {
            this.roomTypesTableAdapter.Fill(this.apartmentDataSet.RoomTypes);
            this.customerTypesTableAdapter.Fill(this.apartmentDataSet.CustomerTypes);

            if (RoomID != 0)
            {
                this.roomsTableAdapter.FillByID(this.apartmentDataSet.Rooms, RoomID);
                this.tbxRoomNO.ReadOnly = true;
                this.cbxCustomerType.Enabled = false;
                this.cbxRoomType.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (RoomID == 0)
            {
                try
                {
                    this.Validate();
                    this.ValidateChildren();

                    RoomsTableAdapter roomsTableAdapter = new RoomsTableAdapter();
                    roomsTableAdapter.Insert(
                        Convert.ToInt32(cbxRoomType.SelectedValue),
                        Convert.ToByte(cbxRoomStatus.SelectedValue),
                        tbxRoomNO.Text.Trim(),
                        tbxFlow.Text.Trim(),
                        tbxBuilding.Text.Trim());

                    MessageBox.Show("บันทึกเสร็จสมบูรณ์");
                    DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
                catch(Exception ex)
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
                    this.Validate();
                    this.ValidateChildren();
                    this.roomsBindingSource.EndEdit();
                    this.roomsTableAdapter.Update(this.apartmentDataSet.Rooms);
                    MessageBox.Show("บันทึกเสร็จสมบูรณ์");
                    DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
                catch(Exception ex)
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
    }
}
