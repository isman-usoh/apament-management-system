using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apartmant.Database.ApartmentDataSetTableAdapters;
using Apartmant.Database;

namespace Apartmant.UserInterface.Utility
{
    public partial class UtilityUI : Form
    {
        private int Year { get; set; }

        private int Month { get; set; }

        public UtilityUI(int pYear, int pMonth)
        {
            InitializeComponent();
            this.Year = pYear;
            this.Month = pMonth;


            RoomsTableAdapter roomsTableAdapter = new RoomsTableAdapter();
            ApartmentDataSet.RoomsDataTable roomIDs = roomsTableAdapter.CheckRoomForUtilities(new DateTime(Year, Month, 1));

            Console.WriteLine(roomIDs.Count);
            foreach (ApartmentDataSet.RoomsRow row in roomIDs)
            {
                int y = utilitiesTableAdapter.Insert(row.RoomID, row.No, 0, 0, new DateTime(Year, Month, 1), null);
                Console.WriteLine(y);
            }
        }

        private void UtilityUI_Load(object sender, EventArgs e)
        {
            utilitiesTableAdapter.Fill(apartmentDataSet.Utilities, new DateTime(Year, Month, 1));

            this.roomTypesTableAdapter.Fill(this.apartmentDataSet.RoomTypes);
            this.customerTypesTableAdapter.Fill(this.apartmentDataSet.CustomerTypes);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            utilitiesBindingSource.EndEdit();
            utilitiesTableAdapter.Update(apartmentDataSet.Utilities);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void cbxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //utilitiesBindingSource.EndEdit();
            //utilitiesTableAdapter.Update(apartmentDataSet.Utilities);
            //utilitiesTableAdapter.Fill(apartmentDataSet.Utilities, new DateTime(Year, Month, 1), Convert.ToInt32(cbxRoomType.SelectedValue));
            
        }
    }
}
