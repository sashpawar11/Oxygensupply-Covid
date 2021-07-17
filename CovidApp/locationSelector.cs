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
    public partial class locationSelector : Form
    {
        

        public locationSelector()
        {
            InitializeComponent();
        }

        // Variables for storing lat and long for passing in SuppliersRegistration Form
        public static string latitude;
        public static string longitude;

        private void locationSelector_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = "AIzaSyC2VXa8OMhRU4ivt7CAIErwB2cJDYS2s2g";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            locatormap.MapProvider = GMapProviders.GoogleMap;
            locatormap.MinZoom = 1;
            locatormap.MaxZoom = 50;
            locatormap.Zoom = 5;
            locatormap.ShowCenter = false;
            locatormap.DragButton = MouseButtons.Left;
            locatormap.Position = new GMap.NET.PointLatLng(HospitalView.default_lat,HospitalView.default_longt);
            
            RefreshMap();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }


        private void locatormap_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var point = locatormap.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double longt = point.Lng;

                latitude = lat.ToString();
                longitude = longt.ToString();
                //latBox.Text = lat.ToString();
                //longBox.Text = longt.ToString();

                
                LoadMap(point);
                AddMarker(point);

            }
        }

        private void LoadMap(PointLatLng point)
        {
            locatormap.Position = point;
        }
        
        private void AddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.purple_dot)
        {
            
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(pointToAdd, GMarkerGoogleType.purple);
            locatormap.Overlays.Add(markers);
            markers.Markers.Add(marker);
            


        }


        private void latBox_TextChanged(object sender, EventArgs e)
        {

        }


        private bool isValid()
        {
            if (latitude == string.Empty)
            {
                MessageBox.Show("Please Re-mark your location!", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (longitude == string.Empty)
            {
                MessageBox.Show(" Please Re-mark your location!", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            locatormap.Overlays.Clear();
            RefreshMap();
            latitude = "";
            longitude = "";
            RefreshMap();
        }

        public void RefreshMap()
        {
            locatormap.Zoom--;
            locatormap.Zoom++;

        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            if (isValid())
            {
                MessageBox.Show("Location Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
