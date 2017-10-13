using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Apartmant.Report
{
    public partial class PaymentPreview : Form
    {
        public PaymentPreview()
        {
            InitializeComponent();
        }

        private void PaymentPreview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartmentDataSet.Staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.apartmentDataSet.Staffs);
            // TODO: This line of code loads data into the 'apartmentDataSet.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.apartmentDataSet.Payments);
            // TODO: This line of code loads data into the 'apartmentDataSet.CheckIns' table. You can move, or remove it, as needed.
            this.checkInsTableAdapter.Fill(this.apartmentDataSet.CheckIns);
            // TODO: This line of code loads data into the 'apartmentDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.apartmentDataSet.Customers);
            // TODO: This line of code loads data into the 'apartmentDataSet.PaymentView' table. You can move, or remove it, as needed.
            this.paymentViewTableAdapter.Fill(this.apartmentDataSet.PaymentView);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}
