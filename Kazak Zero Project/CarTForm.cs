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
    public partial class CarTForm : Form
    {
        public CarTForm()
        {
            InitializeComponent();
        }
        private static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=main.accdb";
        private void CarForm_Load(object sender, EventArgs e)
        {
            Fill_DataGridView();
            Fill_ComboBox();
        }

        private void Fill_ComboBox()
        {
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM type_car;", connectionString);
            DataTable data = new DataTable();
            oleDbDataAdapter.Fill(data);
            comboBox1.DataSource = data;
            comboBox1.DisplayMember = "type_car";
            comboBox1.ValueMember = "id_typecar";


            oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM oil;", connectionString);
            data = new DataTable();
            oleDbDataAdapter.Fill(data);
            comboBox2.DataSource = data;
            comboBox2.DisplayMember = "name_oil";
            comboBox2.ValueMember = "id_oil";

        }

        private void Fill_DataGridView()
        {
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT car.id_car, type_car.type_car, car.state_number, car.name_car, oil.name_oil, car.norm_summer, car.norm_winter, car.coint_oil FROM (car INNER JOIN oil ON car.id_oil = oil.id_oil) INNER JOIN type_car ON car.id_typecar = type_car.id_typecar WHERE car.id_typecar = 1;", connectionString);
            DataTable data = new DataTable();
            oleDbDataAdapter.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Тип ТС";
            dataGridView1.Columns[2].HeaderText = "Гос номер";
            dataGridView1.Columns[3].HeaderText = "Наименование ТС";
            dataGridView1.Columns[4].HeaderText = "Вид топлива";
            dataGridView1.Columns[5].HeaderText = "Норма расхода летом";
            dataGridView1.Columns[6].HeaderText = "Норма расхода зимой";
            dataGridView1.Columns[7].HeaderText = "Количество топлива";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(maskedTextBox1.Text) && !String.IsNullOrEmpty(maskedTextBox2.Text) && !String.IsNullOrEmpty(maskedTextBox3.Text))
            {
                if (MessageBox.Show("Добавить: " + textBox2.Text + "\nКатегории: " + textBox2.Text, "Добавление ТС", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    OleDbConnection connection = new OleDbConnection(connectionString);
                    connection.Open();
                    OleDbCommand oleDb = new OleDbCommand("INSERT INTO car (id_typecar,state_number,name_car,id_oil,norm_summer,norm_winter,coint_oil) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connection);
                    oleDb.Parameters.Add("@p1", OleDbType.BigInt).Value = comboBox1.SelectedValue.ToString();
                    oleDb.Parameters.Add("@p2", OleDbType.VarChar).Value = textBox2.Text;
                    oleDb.Parameters.Add("@p3", OleDbType.VarChar).Value = textBox3.Text;
                    oleDb.Parameters.Add("@p4", OleDbType.Integer).Value = comboBox2.SelectedValue.ToString();
                    oleDb.Parameters.Add("@p5", OleDbType.Double).Value = maskedTextBox1.Text;
                    oleDb.Parameters.Add("@p6", OleDbType.Double).Value = maskedTextBox2.Text;
                    oleDb.Parameters.Add("@p7", OleDbType.Double).Value = maskedTextBox3.Text;
                    oleDb.ExecuteNonQuery();
                    connection.Close();
                    Fill_DataGridView();
                }
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT car.id_car, type_car.type_car, car.state_number, car.name_car, oil.name_oil, car.norm_summer, car.norm_winter, car.coint_oil FROM (car INNER JOIN oil ON car.id_oil = oil.id_oil) INNER JOIN type_car ON car.id_typecar = type_car.id_typecar WHERE car.name_car Like \"%" + textBox1.Text + "%\" AND car.id_typecar = 1;", connectionString);
            DataTable data = new DataTable();
            oleDbDataAdapter.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Тип ТС";
            dataGridView1.Columns[2].HeaderText = "Гос номер";
            dataGridView1.Columns[3].HeaderText = "Наименование ТС";
            dataGridView1.Columns[4].HeaderText = "Вид топлива";
            dataGridView1.Columns[5].HeaderText = "Норма расхода летом";
            dataGridView1.Columns[6].HeaderText = "Норма расхода зимой";
            dataGridView1.Columns[7].HeaderText = "Количество топлива";
        }

        public void UpdateDataGridView()
        {
            Fill_DataGridView();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            EditDriverForm edit = new EditDriverForm(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            edit.Owner = this;
            edit.Show();
            this.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CarReportForm carReportForm = new CarReportForm();
            carReportForm.Owner = this;
            carReportForm.Show();
        }
    }
}
