using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apartment;
using System.Globalization;
using UI;

namespace Apartmant.UserInterface.Utility
{
    public partial class SelectMonthUI : Form
    {
        private DateTime startYear = new DateTime(2000, 10, 01, new System.Globalization.CultureInfo("en-US").Calendar);
        
        private Dictionary<int, string> dicYear = new Dictionary<int, string>();
        
        private Dictionary<int, string> dicMonth = new Dictionary<int, string>();

        private MainUI main;

        public SelectMonthUI(MainUI mainUI)
        {
            InitializeComponent();
            main = mainUI;
        }

        private void SelectMountUI_Load(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            dicYear.Clear();
            for (int i = startYear.Year; i <= current.Year; i++)
            {
                dicYear.Add(i, i + "");
            }
            cbxYear.SelectedValue = current.Year;

            cbxYear.DisplayMember = "Value";
            cbxYear.ValueMember = "Key";
            cbxYear.DataSource = dicYear.ToList();

            cbxMonth.DisplayMember = "Value";
            cbxMonth.ValueMember = "Key";
        }

        private void cbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            dicMonth.Clear();

            DateTime current = DateTime.Now;
            if (Convert.ToInt32(cbxYear.SelectedValue) == startYear.Year)
            {
                for (int i = startYear.Month; i <= 12; i++)
                {
                    dicMonth.Add(i, CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
                }
            }
            else if (Convert.ToInt32(cbxYear.SelectedValue) == current.Year)
            {
                for (int i = 1; i < current.Month + 1; i++)
                {
                    dicMonth.Add(i, CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
                }

                if (current.Day > 5)
                {
                    dicMonth.Add(current.Month + 1, CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(current.Month + 1));
                }
            }
            else
            {
                for (int i = 1; i <= 12; i++)
                {
                    dicMonth.Add(i, CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
                }
            }
            cbxMonth.DataSource = dicMonth.ToList();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

            UtilityUI utilityUI = new UtilityUI(Convert.ToInt32(cbxYear.SelectedValue),
                Convert.ToInt32(cbxMonth.SelectedValue));
            utilityUI.ShowDialog(main);
            
        }
    }
}
