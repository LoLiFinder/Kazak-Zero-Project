namespace Kazak_Zero_Project
{
    partial class PutListReport
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
            this.ReportPutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportPutTableAdapter = new Kazak_Zero_Project.mainDataSet12TableAdapters.ReportPutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportPutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReportPutBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kazak_Zero_Project.PutReport.rdlc";
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
            // ReportPutBindingSource
            // 
            this.ReportPutBindingSource.DataMember = "ReportPut";
            this.ReportPutBindingSource.DataSource = this.mainDataSet12;
            // 
            // ReportPutTableAdapter
            // 
            this.ReportPutTableAdapter.ClearBeforeFill = true;
            // 
            // PutListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PutListReport";
            this.Text = "Отчет по путевому листу";
            this.Load += new System.EventHandler(this.PutListReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportPutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportPutBindingSource;
        private mainDataSet12 mainDataSet12;
        private mainDataSet12TableAdapters.ReportPutTableAdapter ReportPutTableAdapter;
    }
}