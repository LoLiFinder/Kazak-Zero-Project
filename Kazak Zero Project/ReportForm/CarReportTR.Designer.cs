namespace Kazak_Zero_Project
{
    partial class CarReportTR
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mainDataSet12 = new Kazak_Zero_Project.mainDataSet12();
            this.car_report_tBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_report_tTableAdapter = new Kazak_Zero_Project.mainDataSet12TableAdapters.car_report_tTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_report_tBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.car_report_tBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kazak_Zero_Project.ReportTR.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // mainDataSet12
            // 
            this.mainDataSet12.DataSetName = "mainDataSet12";
            this.mainDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // car_report_tBindingSource
            // 
            this.car_report_tBindingSource.DataMember = "car_report_t";
            this.car_report_tBindingSource.DataSource = this.mainDataSet12;
            // 
            // car_report_tTableAdapter
            // 
            this.car_report_tTableAdapter.ClearBeforeFill = true;
            // 
            // CarReportTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CarReportTR";
            this.Text = "Отчет по тракторам";
            this.Load += new System.EventHandler(this.CarReportTR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_report_tBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource car_report_tBindingSource;
        private mainDataSet12 mainDataSet12;
        private mainDataSet12TableAdapters.car_report_tTableAdapter car_report_tTableAdapter;
    }
}