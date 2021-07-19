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
using System.Data.SqlClient;


namespace CovidApp          
{

    
    public partial class Login : Form
    {

        public static string usernameForQuery = "";     // Storing username entered by User for further queries in other Forms.
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            String user = hosp_name.Text;
            String pass = password.Text;
            usernameForQuery = user;

            if(hosp_box.Checked)
            {
                string connectionString = @"provider = Microsoft.ACE.OLEDB.12.0; 
                            Data source = D:\HospitalDatabase.xlsx; 
                            Extended Properties = 'Excel 8.0'";
                OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
                
                oleDbConnection.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter("SELECT COUNT(*) FROM [Sheet1$] WHERE [Username] = '" + user + "' AND [Password] = '" + pass + "'", connectionString);
                DataTable dt = new DataTable(); 
                oda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                  
                    this.Hide();
                    HospitalView hv = new HospitalView();
                    hv.Closed += (s, args) => this.Close();
                    hv.Show();
                }
                else {
                    MessageBox.Show("Invalid Username or Password. Please Retry!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                oleDbConnection.Close();
                

            }
            else if(supp_box.Checked)
            {
                string connectionString = @"provider = Microsoft.ACE.OLEDB.12.0; 
                            Data source = D:\SuppliersDatabase.xlsx; 
                            Extended Properties = 'Excel 8.0'";
                OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
                OleDbDataAdapter oda = new OleDbDataAdapter("SELECT COUNT(*) FROM [Sheet1$] WHERE [Username] = '" + user + "' AND [Password] = '" + pass + "'", connectionString);
                DataTable dt = new DataTable(); 
                oda.Fill(dt);
     
                oleDbConnection.Close();
                if (dt.Rows[0][0].ToString() == "1")
                { 
                    
                    this.Hide();
                    OxygenSupplierView ov = new OxygenSupplierView();
                    ov.Closed += (s, args) => this.Close();
                    ov.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password. Please Retry!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                oleDbConnection.Close();

            }
            else
            {

                MessageBox.Show("Invalid Username or Password. Please Retry!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

           
                
            
          
        }

        private void Hosp_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hospital_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterScreen rg = new RegisterScreen();
            rg.Closed += (s, args) => this.Close();
            rg.Show();
        }
    }
}
