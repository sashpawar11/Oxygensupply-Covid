using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
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

namespace CovidApp
{
    public partial class HospitalView : Form
    {
        public HospitalView()
        {
            InitializeComponent();
        }

        private void HospitalView_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"'AIzaSyCqQU_079Ch8SYiLbC4Eql3D6SOKM_b7ic";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Connection string for OleDB Connection to Excel File
            string connectionString = @"provider = Microsoft.ACE.OLEDB.12.0;      
                            Data source = D:\Oxygen supplier.xlsx; 
                            Extended Properties = 'Excel 8.0'";
            
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);          // Reading Oxygen Suppliers Database From Excel File
            DataTable SheetData = new DataTable();                // Creating DataTable for the DataGrid in Hospital View
            oleDbConnection.Open(); 
            OleDbCommand cmd = new OleDbCommand();
            /// Query to Fetch all data from Excel file
            string query = $"SELECT [Name], [Contact Number], [Address], [State], [Company Name] from [Sheet1$]";
            cmd.Connection = oleDbConnection;                               
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            ((OleDbDataAdapter)new OleDbDataAdapter(cmd)).Fill(SheetData);        // Filling the DataTable with all entries from Excel File (Oxygen Suppliers)
            oleDbConnection.Close();
            SuppliersDataGrid.DataSource = SheetData;      // Displaying all the data in the respective GridView in HospitalView




            //   -------------- Map Section (Under Dev)-----
            map.MapProvider = GMapProviders.GoogleMap;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;
            
            if (stateSelector.Text == "Goa")
            {
                double lat = 15.2993;
                double longt = 74.1240;
                map.Position = new GMap.NET.PointLatLng(lat, longt);
               
                //GMaps.Instance.Mode = AccessMode.ServerOnly;
               // map.SetPositionByKeywords("Panaji,India");
                GMapOverlay markers = new GMapOverlay("markers");
                GMapMarker marker = new GMarkerGoogle(
                    new PointLatLng(lat, longt),
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin                    
                    );
                markers.Markers.Add(marker);
                map.Overlays.Add(markers);

               
            }
        }

        private void map_Load(object sender, EventArgs e)
        {
            map.ShowCenter = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
