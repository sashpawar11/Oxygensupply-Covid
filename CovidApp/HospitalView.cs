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

        public static double default_lat = 20.5937;
        public static double default_longt = 78.9629;
        private void HospitalView_Load(object sender, EventArgs e)
        {
            //GMapProviders.GoogleMap.ApiKey = @"'AIzaSyCqQU_079Ch8SYiLbC4Eql3D6SOKM_b7ic";
            GMapProviders.GoogleMap.ApiKey = "AIzaSyC2VXa8OMhRU4ivt7CAIErwB2cJDYS2s2g";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.MapProvider = GMapProviders.GoogleMap;
            map.MinZoom = 1;
            map.MaxZoom = 50;
            map.Zoom = 3;
            map.ShowCenter = false;
            map.DragButton = MouseButtons.Left;
            map.Position = new GMap.NET.PointLatLng(default_lat, default_longt);
            RefreshMap();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Connection string for OleDB Connection to Excel File
            string connectionString = @"provider = Microsoft.ACE.OLEDB.12.0;      
                            Data source = D:\SuppliersDatabase.xlsx; 
                            Extended Properties = 'Excel 8.0'";
            
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);          // Reading Oxygen Suppliers Database From Excel File
            DataTable SheetData = new DataTable();                // Creating DataTable for the DataGrid in Hospital View
            oleDbConnection.Open(); 
            OleDbCommand cmd = new OleDbCommand();

            var selectedState = stateSelector.Text;

            
            /// Query to search Data and Fetch according to the State Selected.
            string query = $"SELECT [Name], [Contact Number], [Address], [State], [Company Name], [Price], [Stock] , [Status] from [Sheet1$] WHERE  [State] = '" + selectedState + "'";
            cmd.Connection = oleDbConnection;                               
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            ((OleDbDataAdapter)new OleDbDataAdapter(cmd)).Fill(SheetData);        // Filling the DataTable with all entries from Excel File (Oxygen Suppliers)
            oleDbConnection.Close();
            SuppliersDataGrid.DataSource = SheetData;      // Displaying all the data in the respective GridView in HospitalView



            
            //   -------------- Map Section (Under Dev)-----
            
            RefreshMap();

            if (selectedState== "Goa")
            {
                map.Zoom = 10;
                double lat = 15.2993;
                double longt = 74.1240;
                map.Position = new GMap.NET.PointLatLng(lat, longt);
                //map.SetPositionByKeywords("Chennai,India")
                GMapOverlay markers = new GMapOverlay("markers");
                GMapMarker marker = new GMarkerGoogle(
                    new PointLatLng(lat, longt),
                    GMarkerGoogleType.pink_dot
                    ) ;

               
                markers.Markers.Add(marker);
                map.Overlays.Add(markers);
                marker.ToolTipText = "Goa Test Text";
                marker.ToolTip.Fill = new SolidBrush(Color.FromArgb(100, Color.Black));
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.TextPadding = new Size(20, 20);
                RefreshMap();

               
            }
        }

        private void map_Load(object sender, EventArgs e)
        {
            
            RefreshMap();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void stateSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Function to Auto-Refresh GMap
        public void RefreshMap()
        {
            map.Zoom--;
            map.Zoom++;
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        // public void addMarker(GMapControl _control, String location)
        //{
        //    _control.SetPositionByKeywords(location);
        //       GMap.NET.PointLatLng pt1 = _control.Position;
        //       GMapMarker marker1 = new GMapMarker(pt1);
        //       marker1.Shape = new MarkerTemplate();
        //       marker1.ZIndex = 1;
        //       _control.Markers.Add(marker1);

        //       Console.WriteLine("Should be added");
        //}
    }
}
