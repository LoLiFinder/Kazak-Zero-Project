using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kazak_Zero_Project
{
    public partial class DriversForm : Form
    {
        public DriversForm()
        {
            InitializeComponent();
        }
        private static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=main.accdb";
        private void DriversForm_Load(object sender, EventArgs e)
        {
            Fill_DataGridView();
        }

        private void Fill_DataGridView()
        {
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM drivers;", connectionString);
            DataTable data = new DataTable();
            oleDbDataAdapter.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[2].HeaderText = "Категории";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM drivers WHERE FIO Like \"%"+textBox1.Text+"%\";", connectionString);
            DataTable data = new DataTable();
            oleDbDataAdapter.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[2].HeaderText = "Категории";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text))
            {
                if (MessageBox.Show("Добавить: " + textBox2.Text + "\nКатегории: "+textBox2.Text, "Добавление Водителя", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    OleDbConnection connection = new OleDbConnection(connectionString);
                    connection.Open();
                    OleDbCommand oleDb = new OleDbCommand("INSERT INTO drivers (FIO,category) VALUES ('" + textBox2.Text + "','"+textBox3.Text+"')", connection);
                    oleDb.ExecuteNonQuery();
                    connection.Close();
                    Fill_DataGridView();
                }
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("text");
            EditDriverForm edit = new EditDriverForm();
            edit.Owner = this;
            edit.Show();
            this.Enabled = false;
        }
    }
}
