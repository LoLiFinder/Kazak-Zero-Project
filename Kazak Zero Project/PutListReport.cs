using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kazak_Zero_Project
{
    public partial class PutListReport : Form
    {
        public PutListReport()
        {
            InitializeComponent();
        }

        private void PutListReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet12.ReportPut". При необходимости она может быть перемещена или удалена.
            this.ReportPutTableAdapter.Fill(this.mainDataSet12.ReportPut);

            this.reportViewer1.RefreshReport();
        }
    }
}
