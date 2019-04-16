namespace Kazak_Zero_Project
{
    partial class CarReportForm
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
            this.car_reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet12 = new Kazak_Zero_Project.mainDataSet12();
            this.car_reportTableAdapter = new Kazak_Zero_Project.mainDataSet12TableAdapters.car_reportTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.car_reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // car_reportBindingSource
            // 
            this.car_reportBindingSource.DataMember = "car_report";
            this.car_reportBindingSource.DataSource = this.mainDataSet12;
            // 
            // mainDataSet12
            // 
            this.mainDataSet12.DataSetName = "mainDataSet12";
            this.mainDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // car_reportTableAdapter
            // 
            this.car_reportTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.car_reportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kazak_Zero_Project.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // CarReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CarReportForm";
            this.Text = "Отчет по автомобилям";
            this.Load += new System.EventHandler(this.CarReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.car_reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource car_reportBindingSource;
        private mainDataSet12 mainDataSet12;
        private mainDataSet12TableAdapters.car_reportTableAdapter car_reportTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}