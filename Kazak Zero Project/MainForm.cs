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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            OilForm oilForm = new OilForm();
            oilForm.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DriversForm driversForm = new DriversForm();
            driversForm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            CarForm carForm = new CarForm();
            carForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CarTForm carTForm = new CarTForm();
            carTForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CarTRForm carTRForm = new CarTRForm();
            carTRForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CarReportL carReportL = new CarReportL();
            carReportL.Owner = this;
            carReportL.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            CarReportForm carReportL = new CarReportForm();
            carReportL.Owner = this;
            carReportL.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            CarReportTR car = new CarReportTR();
            car.Owner = this;
            car.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            CarReportT car = new CarReportT();
            car.Owner = this;
            car.Show();
        }
    }
}
