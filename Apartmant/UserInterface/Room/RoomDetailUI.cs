using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apartment.UserInterface.Payment;
using UI;
using Apartmant.Database.ApartmentDataSetTableAdapters;
using Apartmant.UserInterface.Services;
using Apartment.UserInterface.Service;

namespace Apartment.UserInterface.Room
{
    public partial class RoomDetailUI : Form
    {
        public int CheckInID { get; set; }

        public RoomDetailUI()
        {
            InitializeComponent();
            SortedDictionary<Byte, String> paymentStatus = new SortedDictionary<Byte, String>();
            paymentStatus.Add(0, "ยังไม่ได้ชำระเงิน");
            paymentStatus.Add(1, "ชำระเงินแล้ว");
            paymentStatus.Add(2, "ยกเลิกชำระเงิน");


            payStatusDataGridViewComboBoxColumn.ValueMember = "Key";
            payStatusDataGridViewComboBoxColumn.DisplayMember = "Value";
            payStatusDataGridViewComboBoxColumn.DataSource = paymentStatus.ToList();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (DialogResult.No.Equals(MessageBox.Show("คุณยืนยันจะเช็คเอ้าออกจริงหรือไม่", "ยืนยันจะเช็คเอ้าออก", MessageBoxButtons.YesNo, MessageBoxIcon.Information)))
            {
                return;
            }

            PaymentsTableAdapter paymentsTableAdapter = new PaymentsTableAdapter();
            int compareDate = Convert.ToInt32(paymentsTableAdapter.CompareDatePayAndCheckIn(CheckInID));
            if (compareDate == 0)
            {
                int paymentId = Convert.ToInt32(paymentsTableAdapter.GetMaxIDAsCheckIn(CheckInID));
                if (paymentId > 0)
                {
                    if (0 == Convert.ToDouble(serviceChargesTableAdapter.GetServiceAmount(CheckInID)))
                    {
                        MessageBox.Show("คุณยังมียอดค้างชำระ กรุณากลับไปจ่ายให้เรียบร้อย", "แจ้งเตือน 0-0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //MessageBox.Show("ไม่มีรายการปรับปรุง", "เสร็จสมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    paymentsTableAdapter.UpdateServiceAmount(paymentId, CheckInID);
                    serviceChargesTableAdapter.UpdatePayID(paymentId, CheckInID);
                }
                else
                {
                    double servicesAmount = Convert.ToDouble(serviceChargesTableAdapter.GetServiceAmount(CheckInID));
                    if (servicesAmount != 0)
                    {

                        paymentsTableAdapter.Insert(
                            CheckInID,
                            null,
                            null,
                            0,
                            servicesAmount,
                            servicesAmount,
                            null,
                            0,
                            null,
                            null);

                        int payId = Convert.ToInt32(paymentsTableAdapter.GetMaxID());
                        serviceChargesTableAdapter.UpdatePayID(payId, CheckInID);
                    }
                }
                this.paymentViewTableAdapter.FillByCheckInID(
                    this.apartmentDataSet.PaymentView, CheckInID);
                this.serviceChargesTableAdapter.FillByCheckInID(
                    this.apartmentDataSet.ServiceCharges, CheckInID);

            }

            if (Convert.ToInt32(paymentsTableAdapter.CheckPayIt(CheckInID)) == 0)
            {
                try
                {
                    CheckInsTableAdapter checkInTableAdapter = new CheckInsTableAdapter();
                    checkInTableAdapter.UpdateCheckOutDate(DateTime.Now, CheckInID);
                    MessageBox.Show("เช็คเอ้าเสร็จสมบูรณ์", "เสร็จสมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
                catch (Exception)
                {
                    MessageBox.Show("ไม่สามารถเช็คเอ้าได้ กรุณาลองใหม่อีกครั้ง", "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("คุณยังมียอดค้างชำระ กรุณากลับไปจ่ายให้เรียบร้อย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnContinu_Click(object sender, EventArgs e)
        {
            ChangeCheckOutUI changeCheckOutUI = new ChangeCheckOutUI();
            changeCheckOutUI.CheckInID = CheckInID;
            if (DialogResult.Yes.Equals(changeCheckOutUI.ShowDialog()))
            {
                this.paymentViewTableAdapter.FillByCheckInID(
                    this.apartmentDataSet.PaymentView, CheckInID);
                this.roomDetailPanel.checkInsTableAdapter.FillByID(
                    this.roomDetailPanel.apartmentDataSet.CheckIns, CheckInID);
            }
        }

        private void btnNotifCheckOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clieck Notifocation");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoomDetailUI_Load(object sender, EventArgs e)
        {
            this.paymentViewTableAdapter.FillByCheckInID(
                this.apartmentDataSet.PaymentView, CheckInID);
            this.serviceChargesTableAdapter.FillByCheckInID(
                this.apartmentDataSet.ServiceCharges, CheckInID);
            this.roomDetailPanel.checkInsTableAdapter.FillByID(
                this.roomDetailPanel.apartmentDataSet.CheckIns, CheckInID);
            this.customerDetailPanel.customersTableAdapter.FillByID(
                this.customerDetailPanel.apartmentDataSet.Customers, Convert.ToInt32(((DataRowView)this.roomDetailPanel.checkInsBindingSource.Current).Row["CustomerID"]));
        }

        private void btnAddServiceCharge_Click(object sender, EventArgs e)
        {
            AddServiceUI AddServiceUI = new AddServiceUI();
            AddServiceUI.CheckInID = CheckInID;
            if (DialogResult.Yes.Equals(AddServiceUI.ShowDialog()))
                this.serviceChargesTableAdapter.FillByCheckInID(this.apartmentDataSet.ServiceCharges, CheckInID);
        }

        private void btnCelculatePayment_Click(object sender, EventArgs e)
        {
            PaymentsTableAdapter paymentsTableAdapter = new PaymentsTableAdapter();

            int compareDate = Convert.ToInt32(paymentsTableAdapter.CompareDatePayAndCheckIn(CheckInID));
            if (compareDate == 0)
            {
                int paymentId = Convert.ToInt32(paymentsTableAdapter.GetMaxIDAsCheckIn(CheckInID));
                if (paymentId > 0)
                {
                    if (0 == Convert.ToDouble(serviceChargesTableAdapter.GetServiceAmount(CheckInID)))
                    {
                        MessageBox.Show("ไม่มีรายการปรับปรุง", "เสร็จสมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        paymentsTableAdapter.UpdateServiceAmount(paymentId, CheckInID);
                        serviceChargesTableAdapter.UpdatePayID(paymentId, CheckInID);
                    }
                }
                else
                {
                    double servicesAmount = Convert.ToDouble(serviceChargesTableAdapter.GetServiceAmount(CheckInID));
                    if (servicesAmount != 0)
                    {

                        paymentsTableAdapter.Insert(
                            CheckInID,
                            null,
                            null,
                            0,
                            servicesAmount,
                            servicesAmount,
                            null,
                            0,
                            null,
                            null);

                        int payId = Convert.ToInt32(paymentsTableAdapter.GetMaxID());
                        serviceChargesTableAdapter.UpdatePayID(payId, CheckInID);
                    }
                }

                MessageBox.Show("คำนวนใบเสร็จรับเงินเสร็จสมบูรณ์", "เสร็จสมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.paymentViewTableAdapter.FillByCheckInID(
                    this.apartmentDataSet.PaymentView, CheckInID);
                this.serviceChargesTableAdapter.FillByCheckInID(
                    this.apartmentDataSet.ServiceCharges, CheckInID);
            }
            else
            {
                MessageBox.Show("ไม่มีรายการปรับปรุง", "เสร็จสมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvPaymentList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            PaymentDetailUI paymentDetailUI = new PaymentDetailUI();
            paymentDetailUI.PaymentID = Convert.ToInt32(((DataRowView)paymentViewBindingSource[e.RowIndex]).Row["PayID"]);
            if (DialogResult.Yes.Equals(paymentDetailUI.ShowDialog()))
                this.paymentViewTableAdapter.FillByCheckInID(this.apartmentDataSet.PaymentView, CheckInID);
        }

        private void dgvServiceChargeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
