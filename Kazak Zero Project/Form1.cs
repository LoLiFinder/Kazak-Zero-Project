using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kazak_Zero_Project
{
    public partial class Form1 : Form
    {
        private static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=main.accdb";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand comand = new OleDbCommand(String.Format("SELECT * FROM users WHERE login='{0}' AND pass='{1}'", textBox1.Text, textBox2.Text), connection);
            OleDbDataReader reader = comand.ExecuteReader();
            if (!reader.HasRows)
            {
                connection.Close();
                MessageBox.Show("Ошибка авторизации");
                return;
            }

            reader.Read();
            int type = (int)reader[3];
            reader.Close();
            connection.Close();
            if (type == 1)
            {
                MainForm main = new MainForm();
                main.Owner = this;
                main.Show();
                this.Hide();
            }
           
        }
    }
}
