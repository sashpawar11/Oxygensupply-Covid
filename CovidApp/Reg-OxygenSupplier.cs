using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CovidApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
            String user1 = username.Text;
            String pass1 = maskedTextBox1.Text;
            String oxyname = hosp_name.Text;
            String oxynum = hosp_no.Text;
            String add = hosp_addr.Text;
            string state = comboBox1.SelectedItem.ToString();
            String comname = inc_name.Text;

            string connectionString = @"provider = Microsoft.ACE.OLEDB.12.0; 
                            Data source = D:\Oxygen supplier.xlsx; 
                            Extended Properties = 'Excel 8.0'";
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);

            oleDbConnection.Open();
            OleDbCommand cmd = new OleDbCommand();
            string query = "INSERT INTO [Sheet1$] ([Username], [Password], [Name], [Contact Number], [Address], [State], [Company Name]) VALUES('" + user1 + "','" + pass1 + "','" + oxyname + "','" + oxynum + "','" + add + "','" + state + "','" + comname + "')";
            cmd.Connection = oleDbConnection;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            oleDbConnection.Close();
        }
    }
}
