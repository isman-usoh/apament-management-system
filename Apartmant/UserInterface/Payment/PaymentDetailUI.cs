using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UI;
using Apartmant.Report;
using Apartmant.Database.ApartmentDataSetTableAdapters;

namespace Apartment.UserInterface.Payment
{
    public partial class PaymentDetailUI : Form
    {
        public int PaymentID { get; set; }
        
        public PaymentDetailUI()
        {
            InitializeComponent();
        }

        private void PaymentUI_Load(object sender, EventArgs e)
        {
            loadDataSource();
        }

        private void loadDataSource()
        {
            this.paymentViewTableAdapter.FillByID(this.apartmentDataSet.PaymentView, PaymentID);
            DataRowView payDataRow = (DataRowView)paymentViewBindingSource.Current;

            if (Convert.ToByte(payDataRow.Row["PayStatus"]) == 0)
            {
                lblPaymentStatus.Text = "ยังไม่ได้ชำระเงิน";
                lblPaymentStatus.ForeColor = Color.Red;
                btnPayment.Enabled = true;
                btnPrintPayment.Enabled = false;
            }
            else
            {
                lblPaymentStatus.Text = "ชำระเงินแล้ว";
                lblPaymentStatus.ForeColor = Color.Green;
                btnPayment.Enabled = false;
                btnPrintPayment.Enabled = true;
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            DataRowView payDataRow = (DataRowView)paymentViewBindingSource.Current;
            DialogResult result = MessageBox.Show("คุณต้องการชำระเงิน " + payDataRow.Row["AmountTotal"].ToString() + " บาท หรือไม่", "ยืนยันชำระเงิน", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                PaymentsTableAdapter paymentsTableAdapter = new PaymentsTableAdapter();
                paymentsTableAdapter.UpdatePayStatus(MainUI.StaffID, 1, DateTime.Now, PaymentID);
                MessageBox.Show("คุณชำระเงินเสร็จเรียนร้อย");
            }
            loadDataSource();
        }

        private void btnPrintPayment_Click(object sender, EventArgs e)
        {
            PaymentPreview preview = new PaymentPreview();
            preview.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
