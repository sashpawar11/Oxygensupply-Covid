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
using System.IO;


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
            String user1 = username.Text;
            String pass1 = password.Text;
            String oxyname = hosp_name.Text;
            String oxynum = hosp_no.Text;
            String add = hosp_addr.Text;
            String state = comboBox1.SelectedItem.ToString();
            String comname = inc_name.Text;
            String lat = locationSelector.latitude;
            String lng = locationSelector.longitude;



            string connectionString = @"provider = Microsoft.ACE.OLEDB.12.0; 
                            Data source = D:\SuppliersDatabase.xlsx; 
                            Extended Properties = 'Excel 8.0'";

            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);

            oleDbConnection.Open();
            OleDbCommand cmd = new OleDbCommand();
            string query = "INSERT INTO [Sheet1$] ([Username], [Password], [Name], [Contact Number], [Address], [State], [Company Name], [Lat] , [Lng] ) VALUES('" + user1 + "','" + pass1 + "','" + oxyname + "','" + oxynum + "','" + add + "','" + state + "','" + comname + "','" + lat + "', '" + lng + "')";
            cmd.Connection = oleDbConnection;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            oleDbConnection.Close();
            
            this.Hide();
            Login login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
            
        }

        private void hospitalDetailbox_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            locationSelector loc = new locationSelector();
            loc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
