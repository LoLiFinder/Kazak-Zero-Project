﻿using System;
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
    public partial class CarReportT : Form
    {
        public CarReportT()
        {
            InitializeComponent();
        }

        private void CarReportT_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet12.car_report_m". При необходимости она может быть перемещена или удалена.
            this.car_report_mTableAdapter.Fill(this.mainDataSet12.car_report_m);

            this.reportViewer1.RefreshReport();
        }
    }
}
