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
    public partial class OilForm : Form
    {
        private static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=main.accdb";
        public OilForm()
        {
            InitializeComponent();
        }

        private void OilForm_Load(object sender, EventArgs e)
        {
           Fill_DataGridView();
        }

        private void Fill_DataGridView()
        {
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM oil;", connectionString);
            DataTable data = new DataTable();
            oleDbDataAdapter.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Наименование топлива";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT oil.id_oil, oil.name_oil FROM oil WHERE(((oil.name_oil)Like \"%"+textBox1.Text+"%\"));", connectionString);
            DataTable data = new DataTable();
            oleDbDataAdapter.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Наименование топлива";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                if (MessageBox.Show("Добавить "+textBox2.Text+"?","Добавление топлива",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    OleDbConnection  connection = new OleDbConnection(connectionString);
                    connection.Open();
                    OleDbCommand oleDb = new OleDbCommand("INSERT INTO oil (name_oil) VALUES ('"+textBox2.Text+"')",connection);
                    oleDb.ExecuteNonQuery();
                    connection.Close();
                    Fill_DataGridView();
                }
            }
            else MessageBox.Show("Введите наименование!");
        }
    }
}
