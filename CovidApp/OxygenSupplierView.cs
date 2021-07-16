﻿using System;
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


            string connectionString = @"provider = Microsoft.ACE.OLEDB.12.0; 
                            Data source = D:\SuppliersDatabase.xlsx; 
                            Extended Properties = 'Excel 8.0'";
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
            string connectionString = @"provider = Microsoft.ACE.OLEDB.12.0; 
                            Data source = D:\SuppliersDatabase.xlsx; 
                            Extended Properties = 'Excel 8.0'";
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
            DataTable SheetData = new DataTable();                
            oleDbConnection.Open();
            OleDbCommand cmd = new OleDbCommand();
            string query = $"SELECT * from [Sheet1$]  WHERE [Username] = '" + user + "'";
            cmd.Connection = oleDbConnection;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            ((OleDbDataAdapter)new OleDbDataAdapter(cmd)).Fill(SheetData);        // Filling the DataTable with all entries from Excel File (Oxygen Suppliers)
            oleDbConnection.Close();
            personalDetailsView.DataSource = SheetData;
        }
    }
}
