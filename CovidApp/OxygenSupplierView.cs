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
    public partial class OxygenSupplierView : Form
    {
       
        public OxygenSupplierView()
        {
            InitializeComponent();
        }

        string connectionString = @"provider = Microsoft.ACE.OLEDB.12.0; 
                            Data source = D:\SuppliersDatabase.xlsx; 
                            Extended Properties = 'Excel 8.0'";
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OxygenSupplierView_Load(object sender, EventArgs e)
        {
            loadData();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = Login.usernameForQuery;  // Gets username which was used to login by the user from the Login Form
            String price = oxy_price.Text;
            String stock = oxy_stock.Text;
            String status = comboBox1.Text;


            if (isValid())
            {
                OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
                oleDbConnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                string query = "UPDATE [Sheet1$] SET [Price] = '" + price + "', [Stock] = '" + stock + "', [Status] = '" + status + "' WHERE [Username] = '" + user + "' ";
                cmd.Connection = oleDbConnection;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                loadData();
                oleDbConnection.Close();
                

            }
            
        }

        // Function to Validate TextFields Before Updating
        private bool isValid()
        {
            if(oxy_price.Text == string.Empty)
            {
                MessageBox.Show("Price Value is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(oxy_stock.Text == string.Empty)
            {
                MessageBox.Show("Current Stock is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if(comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Please Select Status (Required)*", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // Function To Refresh DataGrid To Display Details On Updating.
        public void loadData()
        {
            String user = Login.usernameForQuery;
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
            DataTable SheetData = new DataTable();                
            oleDbConnection.Open();
            OleDbCommand cmd = new OleDbCommand();
            string query = $"SELECT [Name], [Contact Number], [Address], [State], [Company Name], [Price], [Stock], [Status] from [Sheet1$]  WHERE [Username] = '" + user + "'";
            cmd.Connection = oleDbConnection;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            ((OleDbDataAdapter)new OleDbDataAdapter(cmd)).Fill(SheetData);        // Filling the DataTable with all entries from Excel File (Oxygen Suppliers)
            oleDbConnection.Close();
            personalDetailsView.DataSource = SheetData;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            locationSelector loc = new locationSelector();
            loc.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void oxy_stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void oxy_price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
