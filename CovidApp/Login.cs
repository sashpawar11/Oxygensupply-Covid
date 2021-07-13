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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HospitalView hv = new HospitalView();
            hv.Closed += (s, args) => this.Close();
            hv.Show();
            String user = hosp_name.Text;
            String pass = maskedTextBox1.Text;
            string connstr = String.Format(@"Provider= Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Login.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""");
            OleDbConnection con = new OleDbConnection(connstr);

            //con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\\Login.xlsx" + @";Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            //con.Open();
            //OleDbCommand cmd = new OleDbCommand();
            //String sql = "INSERT INTO [sheet1$](Username,Password) values('+user+','+pass+')";      //ucxasg
            //cmd.Connection = con;
            //cmd.CommandText = sql;
            //cmd.ExecuteNonQuery();

            //ConnectionToExcelFilebelow
            string connectionString = @"provider = Microsoft.ACE.OLEDB.12.0; 
                            Data source = D:\Login.xlsx; 
                            Extended Properties = 'Excel 12.0'";
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
            try
            {
                oleDbConnection.Open();
                MessageBox.Show("Connection Successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed");

            }
        }

        private void hosp_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
