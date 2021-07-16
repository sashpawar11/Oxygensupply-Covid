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

namespace CovidApp
{
    public partial class locationSelector : Form
    {
        

        public locationSelector()
        {
            InitializeComponent();
        }

        private void locationSelector_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = "AIzaSyC2VXa8OMhRU4ivt7CAIErwB2cJDYS2s2g";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            locatormap.MapProvider = GMapProviders.GoogleMap;
            locatormap.MinZoom = 1;
            locatormap.MaxZoom = 50;
            locatormap.Zoom = 3;
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
        public void RefreshMap()
        {
            locatormap.Zoom--;
            locatormap.Zoom++;

        }

        private void locatormap_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var point = locatormap.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double longt = point.Lng;

                latBox.Text = lat.ToString();
                longBox.Text = longt.ToString();

                locatormap.Position = point;

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
            var marker = new GMarkerGoogle(pointToAdd, GMarkerGoogleType.purple_dot);
            markers.Markers.Add(marker);
            locatormap.Overlays.Add(markers);

        }
    }
}
