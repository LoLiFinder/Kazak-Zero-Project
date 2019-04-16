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
    public partial class EditDriverForm : Form
    {
        private string id;
        public EditDriverForm()
        {
            InitializeComponent();
        }
        private static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=main.accdb";

        public EditDriverForm(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void EditDriverForm_Load(object sender, EventArgs e)
        {
           Fill_ComboBox();
           SetData(id);
        }

        public void SetData(string id)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM car WHERE id_car="+id+";",connection);
            OleDbDataReader reader = oleDbCommand.ExecuteReader();
            reader.Read();
            comboBox1.SelectedIndex = (int) reader[1] - 1;
            textBox2.Text = reader[2].ToString();
            textBox3.Text = reader[3].ToString();
            comboBox2.SelectedIndex = (int) reader[4] - 1;
            maskedTextBox1.Text = reader[5].ToString();
            maskedTextBox2.Text = reader[6].ToString();
            maskedTextBox3.Text =  reader[7].ToString();
            connection.Close();
            
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
        private void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand oleDb = new OleDbCommand("UPDATE car SET id_typecar = @p1, state_number = @p2, name_car = @p3, id_oil = @p4, norm_summer = @p5, norm_winter = @p6, coint_oil = @p7 WHERE id_car ="+id+";",connection);
            oleDb.Parameters.Add("@p1", OleDbType.BigInt).Value = comboBox1.SelectedValue.ToString();
            oleDb.Parameters.Add("@p2", OleDbType.VarChar).Value = textBox2.Text;
            oleDb.Parameters.Add("@p3", OleDbType.VarChar).Value = textBox3.Text;
            oleDb.Parameters.Add("@p4", OleDbType.Integer).Value = comboBox2.SelectedValue.ToString();
            oleDb.Parameters.Add("@p5", OleDbType.Double).Value = maskedTextBox1.Text;
            oleDb.Parameters.Add("@p6", OleDbType.Double).Value = maskedTextBox2.Text;
            oleDb.Parameters.Add("@p7", OleDbType.Double).Value = maskedTextBox3.Text;
            oleDb.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Данные изменены");
            (Owner as CarTForm)?.UpdateDataGridView();
        }

        private void EditDriverForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
            (Owner as CarTForm)?.UpdateDataGridView();
        }
    }
}
