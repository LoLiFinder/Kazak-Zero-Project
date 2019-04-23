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
    public partial class putListForm : Form
    {
        private static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=main.accdb";
        public putListForm()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

        }

        private void PutListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet12.drivers". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter.Fill(this.mainDataSet12.drivers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet12.car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.mainDataSet12.car);
            Fill_DataGridView();
        }

        private void Fill_DataGridView()
        {
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT put.id_put, car.name_car, car.state_number, car.norm_summer, car.norm_winter, drivers.FIO, oil.name_oil, put.com_s, put.com_e, put.date_s, put.date_e, put.oil_s, put.oil_e\r\nFROM (drivers INNER JOIN ((car INNER JOIN oil ON car.id_oil = oil.id_oil) INNER JOIN put ON car.id_car = put.id_car) ON drivers.id_drivers = put.id_drivers) INNER JOIN type_car ON car.id_typecar = type_car.id_typecar;\r\n", connectionString);
            DataTable data = new DataTable();
            oleDbDataAdapter.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Наименование ТС";
            dataGridView1.Columns[2].HeaderText = "Гос номер";
            dataGridView1.Columns[3].HeaderText = "Норма расхода летом";
            dataGridView1.Columns[4].HeaderText = "Норма расхода зимой";
            dataGridView1.Columns[5].HeaderText = "ФИО водителя";
            dataGridView1.Columns[6].HeaderText = "Тип топлива";
            dataGridView1.Columns[7].HeaderText = "КМ отправление";
            dataGridView1.Columns[8].HeaderText = "КМ прибытие";
            dataGridView1.Columns[9].HeaderText = "Дата отправления";
            dataGridView1.Columns[10].HeaderText = "Дата прибытия";
            dataGridView1.Columns[11].HeaderText = "Топлива при отправлении";
            dataGridView1.Columns[12].HeaderText = "Топлива при прибытии";
        }

        private void Button1_Click(object sender, EventArgs e)
        {   
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand command = new OleDbCommand(String.Format("INSERT INTO put (id_car,id_drivers,com_s,com_e,date_s,date_e,oil_s,oil_e) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",comboBox1.SelectedValue,comboBox2.SelectedValue,maskedTextBox4.Text,maskedTextBox3.Text,dateTimePicker1.Value.ToString("G"),dateTimePicker2.Value.ToString("G"),
                maskedTextBox1.Text,maskedTextBox2.Text),connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
