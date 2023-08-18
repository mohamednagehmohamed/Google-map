using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
namespace Windows_Google_MAp
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer ssynthize = new SpeechSynthesizer();
        SpeechRecognitionEngine srecognize = new SpeechRecognitionEngine();
        List<PointLatLng> Points;
        int lblmovespeed=5;
        Random rand = new Random();
        Color[] lblmovecolors = {Color.Red,Color.Green,Color.Blue,Color.Khaki,Color.Purple,Color.Yellow,Color.Lavender };
        public Form1()
        {
            InitializeComponent();
            Points = new List<PointLatLng>();
        }
        GMapOverlay markers = new GMapOverlay("markers");
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtlat.Text.Trim() != "" && txtlong.Text.Trim() != "")
            {
                try
                {
                    ssynthize.SpeakAsync("Please Wait For Loading Smart Map");
                    // gMapControl1.ShowCenter = false;
                    //GMaps.Instance.Mode = AccessMode.ServerAndCache;
                    //gMapControl1.CacheLocation = @"cache";
                    //gMapControl1.SetPositionByKeywords("Cairo,Egypt");
                    // gMapControl1.DragButton = MouseButtons.Right;
                    //gMapControl1.MapProvider = GMapProviders.GoogleMap;
                    double latitude = Convert.ToDouble(txtlat.Text);
                    double longitude = Convert.ToDouble(txtlong.Text);
                    gMapControl1.Position = new PointLatLng(latitude, longitude);
                    gMapControl1.MinZoom = 5;
                    gMapControl1.MaxZoom = 100;
                    gMapControl1.Zoom = 10;

                    PointLatLng point = new PointLatLng(latitude, longitude);
                    //Bitmap bmp = (Bitmap)Image.FromFile("img/flag.png");
                    GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
                    //  GMapOverlay markers = new GMapOverlay("markers");
                    marker.ToolTipText = "Latitude'" + Math.Round(gMapControl1.Position.Lat, 3) + "',/n'" + Math.Round(gMapControl1.Position.Lng,3) + "'";
                    var ToolTip = new GMapToolTip(marker);
                    ToolTip.Fill = new SolidBrush(Color.DarkSlateBlue);
                    ToolTip.Foreground = new SolidBrush(Color.Firebrick);
                    ToolTip.Offset = new Point(100,-50);
                    ToolTip.Stroke = new Pen(new SolidBrush(Color.DimGray));
                    marker.ToolTip = ToolTip;
                    markers.Markers.Add(marker);
                    gMapControl1.Overlays.Add(markers);

                    GeoCoderStatusCode statuscoder;
                    var Placemark=GoogleMapProvider.Instance.GetPlacemark(point,out statuscoder);
                    if(statuscoder==GeoCoderStatusCode.G_GEO_SUCCESS)
                    {
                        richTextBox1.AppendText(Placemark.ToString());
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error");
                }
            }
            else
            {
                if (richTextBox1.Text.Trim() != "")
                {
                    GeoCoderStatusCode statuscode;
                    var pointlatlang = GoogleMapProvider.Instance.GetPoint(richTextBox1.Text.Trim(),out statuscode);
                    //PointLatLng 
                    var pt = new PointLatLng(1,1);
                    if (statuscode == GeoCoderStatusCode.G_GEO_SUCCESS)
                    {
                        // PointLatLng?.la
                        //txtlat.Text = PointLatLng?.Lat.ToString();
                        txtlat.Text = pt.Lat.ToString();
                        txtlong.Text = pt.Lng.ToString();
                        button1.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong, Returned StatusCode"+statuscode);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Data To Load Map");
                }
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ssynthize.SpeakAsync("Welcome To Google Map Application");
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyAs9LmhT58_HWX_6egWeBuwjoF14ca3s1M";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.CacheLocation = @"cache-provider-master";
            gMapControl1.ShowCenter = false;
            gMapControl1.DragButton = MouseButtons.Right;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.SetPositionByKeywords("Cairo,Egypt");
            LoadRandomPointsForPolygon();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ssynthize.SpeakAsync("Confirm if you want to exit");
            DialogResult isdialoge;
            isdialoge = MessageBox.Show("Confirm You Want To Exit", "Google Map Application Adminstrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isdialoge == DialogResult.Yes)
            {
                ssynthize.SpeakAsync("Bye Bye My Friend");
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Points.Add(new PointLatLng(Convert.ToDouble(txtlat.Text), Convert.ToDouble(txtlong.Text)));
            ssynthize.SpeakAsync("Point IS Added");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Points.Clear();
            ssynthize.SpeakAsync("Point IS Clear");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (gMapControl1.Overlays.Count > 0)
            {
                gMapControl1.Overlays.RemoveAt(0);
                gMapControl1.Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var Route = GoogleMapProvider.Instance.GetRoute(Points[0], Points[1], false, false, 14);
                var r = new GMapRoute(Route.Points, "My Route")
                {
                    Stroke = new Pen(Color.Red, 5)
                };

                var Routes = new GMapOverlay("Routes");
                Routes.Routes.Add(r);
                gMapControl1.Overlays.Add(Routes);
                lbldistance.Text = Route.Distance + "Km";
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var Polygon = new GMapPolygon(Points, "My Area")
                {
                    Stroke = new Pen(Color.DarkBlue, 2),
                    Fill = new SolidBrush(Color.WhiteSmoke)
                };
                var Polygons = new GMapOverlay("Polygons");
                Polygons.Polygons.Add(Polygon);
                gMapControl1.Overlays.Add(Polygons);
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var Point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                double lat = Point.Lat;
                double lang = Point.Lng;
                txtlat.Text = lat.ToString();
                txtlong.Text = lang.ToString();
                gMapControl1.Position = Point;
                GMapMarker marker = new GMarkerGoogle(Point, GMarkerGoogleType.red_pushpin);
               
                // GMapOverlay markers = new GMapOverlay("markers");
                marker.ToolTipText = "Latitude'" + Math.Round(gMapControl1.Position.Lat, 3) + "',/n'" + Math.Round(gMapControl1.Position.Lng, 3) + "'";
                var ToolTip = new GMapToolTip(marker);
                ToolTip.Fill = new SolidBrush(Color.DarkSlateBlue);
                ToolTip.Foreground = new SolidBrush(Color.Firebrick);
                ToolTip.Offset = new Point(100, -50);
                ToolTip.Stroke = new Pen(new SolidBrush(Color.DimGray));
                marker.ToolTip = ToolTip;
                markers.Markers.Add(marker);
                markers.Markers.Add(marker);
                gMapControl1.Overlays.Add(markers);
               // richTextBox1.Text = marker.ToolTipText;
                if (checkBox1.Checked)
                {
                    var address = GetAddress(Point);
                    richTextBox1.Visible = true;
                   // richTextBox1.Text = marker.ToolTipText;
                    if (address != null)
                        richTextBox1.Text = "Address: \n" + string.Join(",", address[0]);

                    else
                    {
                        richTextBox1.Text = "Unable To Load Address";
                        richTextBox1.Text = marker.ToolTipText;
                    }
                }
                else
                {
                    ssynthize.SpeakAsync("Please Check the Checkbox Fristle Then Try Again");
                    //MessageBox.Show("Please Check the Checkbox Fristle Then Try Again");
                }
            }
        }
        private List<String> GetAddress(PointLatLng point)
        {
            List<Placemark> placemarkers = null;
            var statuscode = GMapProviders.GoogleMap.GetPlacemarks(point, out placemarkers);
            if (statuscode == GeoCoderStatusCode.G_GEO_SUCCESS && placemarkers != null)
            {
                List<string> addreses = new List<string>();
                foreach (var placemarker in placemarkers)
                {
                    addreses.Add(placemarker.Address);
                }
                return addreses;
            }
            return null;
        }

        void Refresh(GMapControl map)
        {
            map.Zoom--;
            map.Zoom++;
        }
       public static GMapControl gmap;
        class MyClass
        {
            void test()
            {
               // GMapControl gmap;
                var frm1 = new Form1();
               // frm1.
                frm1.Refresh(gmap);
            }
        }

        void LoadRandomPointsForRoute()
        {
            var surupoint = new PointLatLng(12.2958,76.6394);
            var BingularPoint = new PointLatLng(12.9716,77.5946);
           // double latitude = Convert.ToDouble(txtlat.Text);
            //double longitude = Convert.ToDouble(txtlong.Text);
            gMapControl1.Position = new PointLatLng(12.2958,76.6394);
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 10;

            PointLatLng point = new PointLatLng(12.2958, 76.6394);
            //Bitmap bmp = (Bitmap)Image.FromFile("img/flag.png");
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
            //  GMapOverlay markers = new GMapOverlay("markers");
            marker.ToolTipText = "Latitude'" + Math.Round(gMapControl1.Position.Lat, 3) + "',/n'" + Math.Round(gMapControl1.Position.Lng, 3) + "'";
            var ToolTip = new GMapToolTip(marker);
            ToolTip.Fill = new SolidBrush(Color.DarkSlateBlue);
            ToolTip.Foreground = new SolidBrush(Color.Firebrick);
            ToolTip.Offset = new Point(100, -50);
            ToolTip.Stroke = new Pen(new SolidBrush(Color.DimGray));
            marker.ToolTip = ToolTip;
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
            Points.Add(surupoint);
            Points.Add(BingularPoint);
        }
        void LoadRandomPointsForPolygon()
        {
           // var surupoint = new PointLatLng(12.2958, 76.6394);
            //var BingularPoint = new PointLatLng(12.9716, 77.5946);
            // double latitude = Convert.ToDouble(txtlat.Text);
            //double longitude = Convert.ToDouble(txtlong.Text);
            gMapControl1.Position = new PointLatLng(-25.969562, 32.585789);
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 10;

            PointLatLng point = new PointLatLng(-25.969562, 32.585789);
            //Bitmap bmp = (Bitmap)Image.FromFile("img/flag.png");
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
            //  GMapOverlay markers = new GMapOverlay("markers");
            marker.ToolTipText = "Latitude'" + Math.Round(gMapControl1.Position.Lat, 3) + "',/n'" + Math.Round(gMapControl1.Position.Lng, 3) + "'";
            var ToolTip = new GMapToolTip(marker);
            ToolTip.Fill = new SolidBrush(Color.DarkSlateBlue);
            ToolTip.Foreground = new SolidBrush(Color.Firebrick);
            ToolTip.Offset = new Point(100, -50);
            ToolTip.Stroke = new Pen(new SolidBrush(Color.DimGray));
            marker.ToolTip = ToolTip;
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
            Points.Add(new PointLatLng(-25.969562, 32.585789));
            Points.Add(new PointLatLng(-25.966205, 32.588171));
            Points.Add(new PointLatLng(-25.968134, 32.951647));
            Points.Add(new PointLatLng(-25.971684, 32.589759));
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gMapControl1.Refresh();
        }

        private void txtlat_MouseHover(object sender, EventArgs e)
        {
            txtlat.BackColor = Color.Crimson;
        }

        private void txtlat_MouseLeave(object sender, EventArgs e)
        {
            txtlat.BackColor = Color.DeepSkyBlue;
        }

        private void txtlong_MouseHover(object sender, EventArgs e)
        {
            txtlong.BackColor = Color.DeepSkyBlue;
        }

        private void txtlong_MouseLeave(object sender, EventArgs e)
        {
            txtlong.BackColor = Color.Crimson;
        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Coral;
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.DarkRed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblmove.Left -= lblmovespeed;
            if(lblmove.Bounds.IntersectsWith(gMapControl1.Bounds))
            {
                lblmovespeed = -lblmovespeed;
            }
            if(lblmove.Bounds.IntersectsWith(picexit.Bounds))
            {
                lblmovespeed = -lblmovespeed;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
           /* foreach(Control c in this.Controls)
            {
            if(c is PictureBox&& c.Tag=="pic")
            {
                c.Left = 950;
            }
            }*/
            picexit.Left = 935;
            picmax.Left = 950;
            picmin.Left = 955;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var pointtosearch = new PointLatLng(Convert.ToDouble(txtlat.Text),Convert.ToDouble(txtlong.Text));
            var Overlays = gMapControl1.Overlays;
            foreach(var Overlay in Overlays)
            {
                var Polygons = Overlay.Polygons;
                foreach(var Polygon in Polygons)
                {
                if(Polygon.IsInside(pointtosearch))
                {
                    Polygon.Fill = new SolidBrush(Color.FromArgb(120,10,100,200));
                    double latitude = Convert.ToDouble(txtlat.Text);
                    double longitude = Convert.ToDouble(txtlong.Text);
                    gMapControl1.Position = new PointLatLng(latitude, longitude);
                    gMapControl1.MinZoom = 5;
                    gMapControl1.MaxZoom = 100;
                    gMapControl1.Zoom = 10;

                    PointLatLng point = new PointLatLng(latitude, longitude);
                    //Bitmap bmp = (Bitmap)Image.FromFile("img/flag.png");
                    GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
                    //  GMapOverlay markers = new GMapOverlay("markers");
                    marker.ToolTipText = "Latitude'" + Math.Round(gMapControl1.Position.Lat, 3) + "',/n'" + Math.Round(gMapControl1.Position.Lng, 3) + "'";
                    var ToolTip = new GMapToolTip(marker);
                    ToolTip.Fill = new SolidBrush(Color.DarkSlateBlue);
                    ToolTip.Foreground = new SolidBrush(Color.Firebrick);
                    ToolTip.Offset = new Point(100, -50);
                    ToolTip.Stroke = new Pen(new SolidBrush(Color.DimGray));
                    marker.ToolTip = ToolTip;
                    markers.Markers.Add(marker);
                    gMapControl1.Overlays.Add(markers);
                    gMapControl1.Refresh();
                    richTextBox1.Text = marker.ToolTipText;
                    MessageBox.Show("Point Is Found:::");
                    var ps = Polygon.Points;
                    var ps1 = Polygon.LocalPoints;
                    return;
                }
                }
            }
            MessageBox.Show("Location Not Found");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int x = rand.Next(0,lblmovecolors.Length);
            lblmove.ForeColor=lblmovecolors[x];
        }
    }
}
