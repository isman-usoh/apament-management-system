namespace Apartmant.Report
{
    partial class PaymentPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet = new Apartmant.Database.ApartmentDataSet();
            this.checkInsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.paymentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentViewTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.PaymentViewTableAdapter();
            this.customersTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.CustomersTableAdapter();
            this.checkInsTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.CheckInsTableAdapter();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.PaymentsTableAdapter();
            this.staffsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffsTableAdapter = new Apartmant.Database.ApartmentDataSetTableAdapters.StaffsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.apartmentDataSet;
            // 
            // apartmentDataSet
            // 
            this.apartmentDataSet.DataSetName = "ApartmentDataSet";
            this.apartmentDataSet.Locale = new System.Globalization.CultureInfo("th");
            this.apartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkInsBindingSource
            // 
            this.checkInsBindingSource.DataMember = "CheckIns";
            this.checkInsBindingSource.DataSource = this.apartmentDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CustomerDataSet";
            reportDataSource1.Value = this.customersBindingSource;
            reportDataSource2.Name = "CheckInDateSet";
            reportDataSource2.Value = this.checkInsBindingSource;
            reportDataSource3.Name = "PaymentDataSet";
            reportDataSource3.Value = this.paymentsBindingSource;
            reportDataSource4.Name = "StaffDataSet";
            reportDataSource4.Value = this.staffsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.Size = new System.Drawing.Size(550, 437);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // paymentViewBindingSource
            // 
            this.paymentViewBindingSource.DataMember = "PaymentView";
            this.paymentViewBindingSource.DataSource = this.apartmentDataSet;
            // 
            // paymentViewTableAdapter
            // 
            this.paymentViewTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // checkInsTableAdapter
            // 
            this.checkInsTableAdapter.ClearBeforeFill = true;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.apartmentDataSet;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // staffsBindingSource
            // 
            this.staffsBindingSource.DataMember = "Staffs";
            this.staffsBindingSource.DataSource = this.apartmentDataSet;
            // 
            // staffsTableAdapter
            // 
            this.staffsTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 437);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PaymentPreview";
            this.Text = "PaymentPreview";
            this.Load += new System.EventHandler(this.PaymentPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Database.ApartmentDataSet apartmentDataSet;
        private System.Windows.Forms.BindingSource paymentViewBindingSource;
        private Database.ApartmentDataSetTableAdapters.PaymentViewTableAdapter paymentViewTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Database.ApartmentDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource checkInsBindingSource;
        private Database.ApartmentDataSetTableAdapters.CheckInsTableAdapter checkInsTableAdapter;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private Database.ApartmentDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.BindingSource staffsBindingSource;
        private Database.ApartmentDataSetTableAdapters.StaffsTableAdapter staffsTableAdapter;
    }
}