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
            map.Zoom = 4;
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
            string query = @"SELECT [Name], [Contact Number], [Address], [State], [Company Name], [Price], [Stock] , [Status], [Lat] , [Lng]  from [Sheet1$] WHERE  [State] = '" + selectedState + "'";
            cmd.Connection = oleDbConnection;                               
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            ((OleDbDataAdapter)new OleDbDataAdapter(cmd)).Fill(SheetData);        // Filling the DataTable with all entries from Excel File (Oxygen Suppliers)
            oleDbConnection.Close();
            SuppliersDataGrid.DataSource = SheetData;      // Displaying all the data in the respective GridView in HospitalView
            
            SuppliersDataGrid.Columns["Lat"].Visible = false;
            SuppliersDataGrid.Columns["Lng"].Visible = false;
            //SheetData = SheetData.Rows
            //    .Cast<DataRow>()
            //    .Where(row => !row.ItemArray.All(field => field is DBNull ||
            //                                     string.IsNullOrWhiteSpace(field as string)))
            //    .CopyToDataTable();

            GMapOverlay markersOverlay = new GMapOverlay("markers");
            map.Overlays.Add(markersOverlay);
            RefreshMap();

            // Setting Map Location According to Selected State
            switch (selectedState)
            {
                case "Andhra Pradesh":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(15.9129, 79.7400);
                    placeMarkers(SheetData);
                    break;

                case "Arunachal Pradesh":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(28.2180, 94.7278);
                    placeMarkers(SheetData);
                    break;

                case "Assam":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(26.244156, 92.537842);
                    placeMarkers(SheetData);
                    break;

                case "Bihar":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(25.78541445, 87.4799727);
                    placeMarkers(SheetData);
                    break;

                case "Chhattisgarh":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(22.09042035, 82.15998734);
                    placeMarkers(SheetData);
                    break;

                case "Goa":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(15.491997, 73.81800065);
                    placeMarkers(SheetData);
                    break;

                case "Gujarat":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(22.309425, 72.136230);
                    placeMarkers(SheetData);
                    break;

                case "Haryana":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(29.065773, 76.040497);
                    placeMarkers(SheetData);
                    break;

                case "Himachal Pradesh":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(32.084206, 77.571167);
                    placeMarkers(SheetData);
                    break;

                case "Jammu and Kashmir":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(34.29995933, 74.46665849);
                    placeMarkers(SheetData);
                    break;

                case "Jharkhand":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(23.80039349, 86.41998572);
                    placeMarkers(SheetData);
                    break;

                case "Karnataka":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(12.57038129, 76.91999711);
                    placeMarkers(SheetData);
                    break;

                case "Kerala":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(8.900372741, 76.56999263);
                    placeMarkers(SheetData);
                    break;

                case "Madhya Pradesh":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(21.30039105, 76.13001949);
                    placeMarkers(SheetData);
                    break;

                case "Maharashtra":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(19.25023195, 73.16017493);
                    placeMarkers(SheetData);
                    break;

                case "Manipur":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(24.79997072, 93.95001705);
                    placeMarkers(SheetData);
                    break;

                case "Mizoram":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(23.71039899, 92.72001461);
                    placeMarkers(SheetData);
                    break;

                case "Nagaland":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(25.6669979, 94.11657019);
                    placeMarkers(SheetData);
                    break;

                case "Odisha":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(19.82042971, 85.90001746);
                    placeMarkers(SheetData);
                    break;

                case "Punjab":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(31.51997398, 75.98000281);
                    placeMarkers(SheetData);
                    break;

                case "Rajasthan":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(26.44999921, 74.63998124);
                    placeMarkers(SheetData);
                    break;

                case "Sikkim":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(27.3333303, 88.6166475);
                    placeMarkers(SheetData);
                    break;

                case "Tamil Nadu":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(12.92038576, 79.15004187);
                    placeMarkers(SheetData);
                    break;

                case "Telangana":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(17.123184, 79.208824);
                    placeMarkers(SheetData);
                    break;

                case "Tripura":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(23.83540428, 91.27999914);
                    placeMarkers(SheetData);
                    break;

                case "Uttarakhand":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(30.0668, 79.0193);
                    placeMarkers(SheetData);
                    break;

                case "Uttar Pradesh":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(27.59998069, 78.05000565);
                    placeMarkers(SheetData);
                    break;

                case "West Bengal":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(22.58039044, 88.32994665);
                    placeMarkers(SheetData);
                    break;

                case "Andaman and Nicobar Islands":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(11.66702557, 92.73598262);
                    placeMarkers(SheetData);
                    break;

                case "Chandigarh":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(30.71999697, 76.78000565);
                    placeMarkers(SheetData);
                    break;

                case "Dadra and Nagar Haveli":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(20.26657819, 73.0166178);
                    placeMarkers(SheetData);
                    break;

                case "Daman and Diu":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(20.2270, 73.0169);
                    placeMarkers(SheetData);
                    break;

                case "Delhi":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(28.6699929, 77.23000403);
                    placeMarkers(SheetData);
                    break;

                case "Lakshadweep":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(10.56257331, 72.63686717);
                    placeMarkers(SheetData);
                    break;

                case "Puducherry":
                    map.Zoom = 6;
                    map.Position = new PointLatLng(11.93499371, 79.83000037);
                    placeMarkers(SheetData);
                    break;

                case "":
                    MessageBox.Show("Please select a state!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    MessageBox.Show("Please select a state!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
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

        private string randomisedMarker(string [] t)
        {

            Random rnd = new Random();
            int index = rnd.Next(t.Length);
            return t[index];
        }

        private void placeMarkers(DataTable s)
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            map.Overlays.Add(markersOverlay);

            for (int i = s.Rows.Count - 1; i >= 0; i--)
            {

                // Column Indexing Starts From 0;
                int random_number = new Random().Next(1, 8);
                int latcln = s.Columns["Lat"].Ordinal;
                int lngcln = s.Columns["Lng"].Ordinal;
                double latd = double.Parse(s.Rows[i][latcln].ToString());
                double lngd = double.Parse(s.Rows[i][lngcln].ToString());


                string stock = s.Rows[i][6].ToString();
                string name = s.Rows[i][0].ToString();
                string status = s.Rows[i][7].ToString();

                PointLatLng point = new PointLatLng(latd, lngd);
                map.Position = point;

                // Randomising MarkerType 
                switch (random_number)                            
                {
                    case 1 : GMarkerGoogle m = new GMarkerGoogle(point, GMarkerGoogleType.purple);
                                markersOverlay.Markers.Add(m);
                                m.ToolTipText = "\n\nName: " + name + "\n\nStock: " + stock + "\n\nStatus: " + status;
                                m.ToolTip.Fill = new SolidBrush(Color.FromArgb(255, Color.Black));
                                m.ToolTip.Foreground = Brushes.White;
                                m.ToolTip.TextPadding = new Size(30, 20);
                                m.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                            break;
                    case 2:
                            GMarkerGoogle m2 = new GMarkerGoogle(point, GMarkerGoogleType.blue);
                            markersOverlay.Markers.Add(m2);
                            m2.ToolTipText = "\n\nName: " + name + "\n\nStock: " + stock + "\n\nStatus: " + status;
                            m2.ToolTip.Fill = new SolidBrush(Color.FromArgb(255, Color.Black));
                            m2.ToolTip.Foreground = Brushes.White;
                            m2.ToolTip.TextPadding = new Size(30, 20);
                            m2.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                            break;

                    case 3:
                            GMarkerGoogle m3 = new GMarkerGoogle(point, GMarkerGoogleType.red);
                            markersOverlay.Markers.Add(m3);
                            m3.ToolTipText = "\n\nName: " + name + "\n\nStock: " + stock + "\n\nStatus: " + status;
                            m3.ToolTip.Fill = new SolidBrush(Color.FromArgb(255, Color.Black));
                            m3.ToolTip.Foreground = Brushes.White;
                            m3.ToolTip.TextPadding = new Size(30, 20);
                            m3.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                            break;

                    case 4:
                            GMarkerGoogle m4 = new GMarkerGoogle(point, GMarkerGoogleType.pink);
                            markersOverlay.Markers.Add(m4);
                            m4.ToolTipText = "\n\nName: " + name + "\n\nStock: " + stock + "\n\nStatus: " + status;
                            m4.ToolTip.Fill = new SolidBrush(Color.FromArgb(255, Color.Black));
                            m4.ToolTip.Foreground = Brushes.White;
                            m4.ToolTip.TextPadding = new Size(30, 20);
                            m4.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        break;

                    case 5:
                            GMarkerGoogle m5 = new GMarkerGoogle(point, GMarkerGoogleType.green);
                            markersOverlay.Markers.Add(m5);
                            m5.ToolTipText = "\n\nName: " + name + "\n\nStock: " + stock + "\n\nStatus: " + status;
                            m5.ToolTip.Fill = new SolidBrush(Color.FromArgb(255, Color.Black));
                            m5.ToolTip.Foreground = Brushes.White;
                            m5.ToolTip.TextPadding = new Size(30, 20);
                            m5.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        break;

                    case 6:
                            GMarkerGoogle m6 = new GMarkerGoogle(point, GMarkerGoogleType.orange);
                            markersOverlay.Markers.Add(m6);
                            m6.ToolTipText = "\n\nName: " + name + "\n\nStock: " + stock + "\n\nStatus: " + status;
                            m6.ToolTip.Fill = new SolidBrush(Color.FromArgb(255, Color.Black));
                            m6.ToolTip.Foreground = Brushes.White;
                            m6.ToolTip.TextPadding = new Size(30, 20);
                            m6.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                            break;

                    case 7:
                        GMarkerGoogle m7 = new GMarkerGoogle(point, GMarkerGoogleType.yellow);
                        markersOverlay.Markers.Add(m7);
                        m7.ToolTipText = "\n\nName: " + name + "\n\nStock: " + stock + "\n\nStatus: " + status;
                        m7.ToolTip.Fill = new SolidBrush(Color.FromArgb(255, Color.Black));
                        m7.ToolTip.Foreground = Brushes.White;
                        m7.ToolTip.TextPadding = new Size(30, 20);
                        m7.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        break;

                    case 8: 
                        GMarkerGoogle m8 = new GMarkerGoogle(point, GMarkerGoogleType.lightblue);
                        markersOverlay.Markers.Add(m8);
                        m8.ToolTipText = "\n\nName: " + name + "\n\nStock: " + stock + "\n\nStatus: " + status;
                        m8.ToolTip.Fill = new SolidBrush(Color.FromArgb(255, Color.Black));
                        m8.ToolTip.Foreground = Brushes.White;
                        m8.ToolTip.TextPadding = new Size(30, 20);
                        m8.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        break;

                    default :
                        MessageBox.Show("Something Went Wrong, please retry.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;


                }


            }

            RefreshMap();
        }

    

        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            
        }
    }
}
