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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OxygenSupplierView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String price = oxy_price.Text;
            String stock = oxy_stock.Text;
            String status = comboBox1.SelectedItem.ToString();

            string connectionString = @"provider = Microsoft.ACE.OLEDB.12.0; 
                            Data source = D:\Oxygen supplier.xlsx; 
                            Extended Properties = 'Excel 8.0'";
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);

            oleDbConnection.Open();
            OleDbCommand cmd = new OleDbCommand();
            string query = "INSERT INTO [Sheet1$] ([Price], [Stock], [Status]) VALUES('" + price + "','" + stock + "','" + status + "')";
            cmd.Connection = oleDbConnection;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            oleDbConnection.Close();
        }
    }
}
