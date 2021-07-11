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
            map.MapProvider = GMapProviders.GoogleMap;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;
            if (stateSelector.Text == "Goa")
            {
                double lat = 15.2993;
                double longt = 74.1240;
                map.Position = new GMap.NET.PointLatLng(lat, longt);
            }
        }

        private void map_Load(object sender, EventArgs e)
        {
            map.ShowCenter = false;
        }
    }
}
