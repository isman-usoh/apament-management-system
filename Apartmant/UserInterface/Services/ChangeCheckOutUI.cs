using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apartmant.Database.ApartmentDataSetTableAdapters;

namespace Apartmant.UserInterface.Services
{
    public partial class ChangeCheckOutUI : Form
    {
        public int CheckInID { get; set; }
        
        public ChangeCheckOutUI()
        {
            InitializeComponent();
        }

        private void ChangeCheckOutUI_Load(object sender, EventArgs e)
        {
            this.checkInsTableAdapter.FillByID(this.apartmentDataSet.CheckIns, CheckInID);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dtpEndStay.MinDate.Subtract(dtpEndStay.Value).Days == 0)
            {
                DialogResult result = MessageBox.Show("คุณไม่ได้เปลี่ยนแปลงเวลาออก, คุณต้องเปลี่ยนแปลงอีกครั้งหรือไม่", "คุณไม่ได้เปลี่ยนแปลงเวลาออก", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.No)){
                    DialogResult = System.Windows.Forms.DialogResult.No;
                    Console.WriteLine("No Change date.");
                }
            }

            checkInsTableAdapter.UpdateCheckInEndStay(dtpEndStay.Value, CheckInID);
            
            PaymentsTableAdapter paymentsTableAdapter = new PaymentsTableAdapter();
            DateTime checkInDate = (DateTime)checkInsTableAdapter.GetMaxEndDate(CheckInID);
            DateTime paymentDate = (DateTime)paymentsTableAdapter.GetMaxEndDate(CheckInID);

            if(checkInDate.Subtract(paymentDate).Days > 0){
                double roomAmount = checkInDate.Subtract(paymentDate).Days * Convert.ToDouble(checkInsTableAdapter.GetRoomPrice(CheckInID));


                int paymentId = Convert.ToInt32(paymentsTableAdapter.GetMaxIDAsCheckInFromRoom(CheckInID));
                if (paymentId > 0)
                {
                    try
                    {
                        ServiceChargesTableAdapter serviceChargesTableAdapter = new ServiceChargesTableAdapter();
                        if (0 != Convert.ToDouble(serviceChargesTableAdapter.GetServiceAmount(CheckInID)))
                        {
                            paymentsTableAdapter.UpdateRoomAmount(roomAmount, paymentDate.ToString(), dtpEndStay.Value.ToString(), paymentId);
                            paymentsTableAdapter.UpdateServiceAmount(paymentId, CheckInID);
                            serviceChargesTableAdapter.UpdatePayID(paymentId, CheckInID);
                        }
                        else
                        {
                            paymentsTableAdapter.UpdateRoomAmount(roomAmount, paymentDate.ToString(), dtpEndStay.Value.ToString(), paymentId);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        throw;
                    }

                }
                else
                {
                    ServiceChargesTableAdapter serviceChargesTableAdapter = new ServiceChargesTableAdapter();
                    double servicesAmount = Convert.ToDouble(serviceChargesTableAdapter.GetServiceAmount(CheckInID));

                    try
                    {
                        paymentsTableAdapter.Insert(
                            CheckInID,
                            paymentDate,
                            dtpEndStay.Value,
                            roomAmount,
                            servicesAmount,
                            servicesAmount + roomAmount,
                            null,
                            0,
                            null,
                            null);

                        int payId = Convert.ToInt32(paymentsTableAdapter.GetMaxID());
                        serviceChargesTableAdapter.UpdatePayID(payId, CheckInID);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        throw;
                    }
                }


            }
            MessageBox.Show("การเปลี่ยนแปลงเสร็จสมบูรณ์");
            DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
