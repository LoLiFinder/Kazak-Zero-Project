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
    }
}
