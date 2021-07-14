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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HospitalView hv = new HospitalView();
            hv.Closed += (s, args) => this.Close();
            hv.Show();
            String user = hosp_name.Text;
            String pass = maskedTextBox1.Text;
           
            string connectionString = @"provider = Microsoft.ACE.OLEDB.12.0; 
                            Data source = D:\Login.xlsx; 
                            Extended Properties = 'Excel 8.0'";
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
            
                oleDbConnection.Open();
            OleDbCommand cmd = new OleDbCommand();
                string query = "INSERT INTO [Sheet1$] ([Username], [Password]) VALUES('" + user + "','" + pass + "')";
                cmd.Connection = oleDbConnection;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                oleDbConnection.Close();
                
            
          
        }

        private void Hosp_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hospital_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
