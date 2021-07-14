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
    public partial class Reg_Hospital : Form
    {
        public Reg_Hospital()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
            String hospname = hosp_name.Text;
            String connum = hosp_no.Text;
            String add = hosp_addr.Text;
            String inchargenm = inc_name.Text;
            String inchargeno = inc_no.Text;

            string connectionString = @"provider = Microsoft.ACE.OLEDB.12.0; 
                            Data source = D:\Hospital data.xlsx; 
                            Extended Properties = 'Excel 8.0'";
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);

            oleDbConnection.Open();
            OleDbCommand cmd = new OleDbCommand();
            string query = "INSERT INTO [Sheet1$] ([Username], [Password], [Hospital Name], [Contact Number], [Address], [Incharge name], [Incharge No]) VALUES('" + user1 + "','" + pass1 + "','" + hospname + "','" + connum + "','" + add + "','" + inchargenm + "','" + inchargeno + "')";
            cmd.Connection = oleDbConnection;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            oleDbConnection.Close();
        }
    }
}
