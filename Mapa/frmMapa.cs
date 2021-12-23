using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using System.Xml.Linq;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.Drawing.Imaging;
using System.Net.NetworkInformation;

namespace Mapa
{
    public partial class frmMapa : Form
    {

        [DllImportAttribute("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);

        GMapPolygon polygonCircles;
        GMapOverlay overlayCircles;

        GMarkerGoogle markerUbicacion;
        GMapOverlay overlayUbicaciones;

        GMarkerGoogle markerBuscarUbicacion;
        GMapOverlay overlayBuscarUbicaciones;

        GMarkerGoogle markerCamion;
        GMapOverlay overlayCamiones;

        GMapOverlay overlayLinea;

        GMarkerGoogle markerRecorrido;
        GMapOverlay overlayRecorridos;

        GMarkerGoogle markerCorral;
        GMapOverlay overlayCorrales;

        GMapPolygon polygonZona;
        GMapOverlay overlayZonas;

        GMapPolygon polygonRecepcion;
        GMapOverlay overlayRecepcion;

        GMapPolygon polygonCelda;
        GMapOverlay overlayCeldas;
        GMarkerGoogle markerlabelCelda;
        GMapOverlay overlaylabelCeldas;

        GMapPolygon polygonComederos;
        GMapOverlay overlayComederos;

        //GMapOverlay overlaytextCeldas;

        GMarkerGoogle markerDrag;
        GMapOverlay overlayDrags;

        GMapOverlay overlayRutas;

        DataTable dtCamiontmp;
        DataTable dtListaCamiontmp;
        DataTable vdt;

        DataTable dtUbictmp;
        DataTable dtRepartotmp;
        DataTable dtCabezastmp;

        private ArrayList lista = new ArrayList();
        
        private String seleccion = "";
        ConnectedWs connectar;

        String usuario = "";
        String contrasena = "";
        string vtodos = "Todos";

        bool ubicActivo = false;
        bool celdaActivo = false;
        bool recActivo = false;

        string ip = "";
         
        int filaSeleccionada = 0;

        double LatInicial = 21.911191;
        double LngInicial = -98.738904;
        double gmindist = 0.035;//0.05//0.02;//0.004;

        double LatActual = 0;
        double LngActual = 0;

        int indiceBoton = 1;
        int indiceBoton2 = 1;
        int indiceBotonVista = 1;
        int indiceBotonVistaSel = 1;
        int indiceBotonFecha = 1;
        int tab = 0;
        int gorientacion = 0;

        int contblanco = 0;
        int contgris = 0;
        int contnaranja = 0;
        int contamarillo = 0;
        int contazul = 0;
        int contverde = 0;
        int contpurpura = 0;
        int controjo = 0;

        int marcas = 0;
        string corralModif = "";

        bool gVerCoordenada = false;
        bool gVerCoordenadaR = false;

        /*
        int lv_pos = 0;
        string[] posMouseX = new string[] { "0", "0"};
        string[] posMouseY = new string[] { "0", "0"};
        */

        Boolean ActivoCtrl = false;

        string desdesap = "0";
        string latencia = "0";
        string cambiopantalla = "20";
        string instancia = "0";
        string inactividad = "0";
        string rutared = "";

        string iniFecha = "";
        string finFecha = "";
        int gopc;

        private List<PointLatLng> _points;
        private List<PointLatLng> _pointsc;
        private List<PointLatLng> _pointslc;

        List<Color> colores = new List<Color>();
        List<String> tablets = new List<String>();

        public frmMapa(int opc)
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
            _pointsc = new List<PointLatLng>();
            _pointslc = new List<PointLatLng>();
            gopc = opc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            carpeta_existe_local();

            tabControl1.Height = 0;

            this.Text = "Mapa"; //Application.ProductName + " - Sistema Reparto Gusi - v" + Application.ProductVersion;
                        
            tablaCamionTemp();
            tablaListaCamionTemp();
            tablaRepartoTemp();
            tablaCabezasTemp();

            llenaTablets();
            buscaCamiones2(false);

            ip = obtenerConfig(0);

            if (ip.Equals("")) { ip = "0.0.0.0"; }

            txtFecha.Text = DateTime.Today.ToShortDateString();

            latencia = obtenerConfig(1);
            usuario = obtenerConfig(3);
            contrasena = obtenerConfig(4);
            inactividad = obtenerConfig(5);
            rutared = obtenerConfig(6);

            if (!latencia.Equals(""))
            {
                timerCamion.Interval = Convert.ToInt32(latencia) * 1000;
                //timerMonitor.Interval = Convert.ToInt32(latencia) * 1000;a
            }

            instancia = obtenerConfig(2);

            desdesap = "0";
            origenDatos(desdesap);

            lblip.Text = ip;
            lblLatencia.Text = latencia.ToString() + "seg";
            
            posicionBTN();

            cargaMapa();

            vdt = new DataTable();

            variablesMapa();

            LatInicial = 21.911191;
            LngInicial = -98.738904;

            LatActual = LatInicial;
            LngActual = LngInicial;

            timerCamion.Enabled = true;

            tablaUbicTemp();

            listaCamiones();

            llenacombocolorcapas();

            //webclimaUrl();

            //vistaCorrales();
            vistaTodo();

            botonCeldas();
            corralesActividadNombre();

            this.WindowState = FormWindowState.Maximized;

            FlushMemory();

            //gMapControl1.ShowCenter = false;

            if (instancia.Equals("0"))
            {

                string[] lines = gMapControl1.MapProvider.Copyright.Split(',');
                string[] lines2 = lines[0].ToString().Split('-');

                lblProveedor.Text = lines2[0].ToString(); //"©2021 Google - Map data ©2021 Tele Atlas, Imagery ©2021 TerraMetrics"
            }
            else
            {
                lblProveedor.Text = "";
            }

            tabControl1.TabPages.Remove(tabControl1.TabPages[1]);
            tabControl1.TabPages.Remove(tabControl1.TabPages[1]);

            lblErrores.Text = "Ok";
            lblCtrl.Text = "";

            mostrarDatosWs();

            switch (gopc) 
            {
                case 1:

                    tim();



                    break;
                case 2:
                    indiceBotonVista = 0;

                    toolStripButton15.Visible = true; //refresca cabezas
                    toolStripSplitButton3.Visible = false;
                    toolStripButton5.Visible = false;
                    toolStripLabel8.Visible = false;
                    toolStripButton16.Visible = false;
                    this.Refresh();

                    timerCamion.Stop();                    
                    cabezasToolStripMenuItem_Click(sender, e);
                    //menuBasico();

                    menuBuscarCamion(false);
                    menuRutas(false);
                   
                    

                    break;
                default:
                    break;
            }




            //mostrarDatosWs();
  

            cmbServidas.SelectedIndex = 0;
            
            //agregarZona();
            //agregarRecepciones();
            
            lineasComederos();




            opcionMouseMenu();
            iniciaNumeroCamion();


            //corralActividad("1076", Color.White);
            //corralActividad("1075", Color.White);

            //corralActividadMod("1076", Color.Green);
            //corralActividadMod("1075", Color.Yellow);

            /*
            var textMap = new TextSymbol("1076", Color.Black, 10, HorizontalAlignment.Left, VerticalAlignment.Bottom);

            _points.Clear();
            _points.Add(new PointLatLng(Convert.ToDouble("21.917745"), Convert.ToDouble("-98.743985")));

            Graphic bassRockGraphic = new Graphic(_points, textMap);
            */

            //grafico1();
            //grafico2();

            //PointLatLng start = new PointLatLng(21.918015, -98.749666);
            //PointLatLng end = new PointLatLng(21.919767, -98.742006);
            //MapRoute route = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(
            //  start, end, false, false, (int)gMapControl1.Zoom);

            //GDirections ss;
            //var xx = GMapProviders.GoogleMap.GetDirections(out ss, start, end, false, false, false, false, false);
            //GMapRoute r = new GMapRoute(ss.Route, "My route");

            this.Refresh();
           

            //this.WindowState = FormWindowState.Maximized;
            this.Cursor = Cursors.Default;


        }
        
        private void variablesMapa() 
        {

            overlayZonas = new GMapOverlay("zonas");
            gMapControl1.Overlays.Add(overlayZonas);

            overlayCeldas = new GMapOverlay("celdas");
            gMapControl1.Overlays.Add(overlayCeldas);

            overlayComederos = new GMapOverlay("comederos");
            gMapControl1.Overlays.Add(overlayComederos);

            overlayRecepcion = new GMapOverlay("recepciones");
            gMapControl1.Overlays.Add(overlayRecepcion);

            overlaylabelCeldas = new GMapOverlay("labelceldas");
            gMapControl1.Overlays.Add(overlaylabelCeldas);

            overlayRutas = new GMapOverlay("Rutas");
            gMapControl1.Overlays.Add(overlayRutas);

            overlayLinea = new GMapOverlay("Ruta");
            gMapControl1.Overlays.Add(overlayLinea);

            overlayUbicaciones = new GMapOverlay("ubicaciones");
            gMapControl1.Overlays.Add(overlayUbicaciones);

            overlayRecorridos = new GMapOverlay("recorridos");
            gMapControl1.Overlays.Add(overlayRecorridos);

            overlayCamiones = new GMapOverlay("camiones");
            gMapControl1.Overlays.Add(overlayCamiones);

            overlayBuscarUbicaciones = new GMapOverlay("buscarubicaciones");
            gMapControl1.Overlays.Add(overlayBuscarUbicaciones);

            overlayCorrales = new GMapOverlay("corrales");
            gMapControl1.Overlays.Add(overlayCorrales);

            overlayDrags = new GMapOverlay("drags");
            gMapControl1.Overlays.Add(overlayDrags);

            overlayCircles = new GMapOverlay("ciculos");
            gMapControl1.Overlays.Add(overlayCircles);

            /*
            overlaytextCeldas = new GMapOverlay("textceldas");
            gMapControl1.Overlays.Add(overlaytextCeldas);
            */


        }

        private void corralActividadInicio()
        {
            String colorcapa = cmbColorCapas.Text;
            Color vcolor = Color.White;

            switch (cmbColorCapas.SelectedIndex)
            {
                case 0:
                    vcolor = Color.White;
                    break;
                case 1 :
                    vcolor = Color.Transparent;
                    break;

            }
            


            for (int i = 0; i < overlayCeldas.Polygons.Count; i++)
            {
                overlayCeldas.Polygons.ElementAt(i).Fill = new SolidBrush(vcolor);//White);
                overlayCeldas.Polygons.ElementAt(i).Tag = Color.White.Name;
            }

        }

        private void corralActividadMod(string nombre, Color color)
        {

            for (int i = 0; i < overlayCeldas.Polygons.Count; i++)
            {

                if (overlayCeldas.Polygons.ElementAt(i).Name.Equals(nombre))
                {
                    overlayCeldas.Polygons.ElementAt(i).Fill = new SolidBrush(color);
                    overlayCeldas.Polygons.ElementAt(i).Tag = color.Name;

                }

            }

        }

        private void tablaRepartoTemp()
        {

            dtRepartotmp = new DataTable();

            dtRepartotmp.Columns.Add("fecha");
            dtRepartotmp.Columns.Add("hora");
            dtRepartotmp.Columns.Add("corral");
            dtRepartotmp.Columns.Add("numcamion");
            dtRepartotmp.Columns.Add("servida");
            dtRepartotmp.Columns.Add("racion");
            dtRepartotmp.Columns.Add("plan");
            dtRepartotmp.Columns.Add("servido");
            dtRepartotmp.Columns.Add("plandia");
            dtRepartotmp.Columns.Add("servidodia");

        }

        private void corralesActividadNombre()
        {
            FlushMemory();

            if (overlayCeldas != null)
            {
                overlaylabelCeldas.Markers.Clear();

                for (int i = 0; i < overlayCeldas.Polygons.Count; i++)
                {
                    //corralActividadNombre(overlayCeldas.Polygons.ElementAt(i).Name, overlayCeldas.Polygons.ElementAt(i).Points, Color.White);
                         
                    corralActividadNombres(overlayCeldas.Polygons.ElementAt(i), "", Color.White);

                }

            }

        }

        private void corralesActividadNombres(ref DataTable dt)
        {

            DataRow[] foundRows1;
            string valor = "";
            string valorm = "";
            string valorh = "";
            int valort = 0;
            int valortm = 0;
            int valorth = 0;
            int valortc = 0;
            
            FlushMemory();

            if (overlayCeldas != null)
            {
                overlaylabelCeldas.Markers.Clear();

                for (int i = 0; i < overlayCeldas.Polygons.Count; i++)
                {
                    //corralActividadNombre(overlayCeldas.Polygons.ElementAt(i).Name, overlayCeldas.Polygons.ElementAt(i).Points, Color.White);
                                                                      
                    dt.DefaultView.Sort = "corral ASC";
                    foundRows1 = dt.Select("centro='2000' and corral='" + overlayCeldas.Polygons.ElementAt(i).Name + "'");

                    if (foundRows1.Length > 0)
                    {
                        DataRow item1 = foundRows1[0];
                        valor = item1["cabezas"].ToString().Replace(".000", "");
                        valorm = "0";
                        valorh = "0";

                        valort += Convert.ToInt32(valor);

                        if (item1["sexo"].ToString().ToUpper().Equals("MACHO"))
                        {
                            valorm = valor;
                            valor = valor + " M";
                        }

                        if (item1["sexo"].ToString().ToUpper().Equals("HEMBRA"))
                        {
                            valorh = valor;
                            valor = valor + " H";
                        }

                        valortm += Convert.ToInt32(valorm);
                        valorth += Convert.ToInt32(valorh);


                    }
                    else 
                    {
                        valor = "0";
                    }

                    corralActividadNombres(overlayCeldas.Polygons.ElementAt(i), valor, Color.White);

                    

                }

                valortc = overlayCeldas.Polygons.Count;

            }





            valort = 0;

            foreach (DataRow row in dt.Rows)
            {

                foundRows1 = dt.Select("centro='2000' and corral='" + row["corral"].ToString() + "'");

                if (foundRows1.Length > 0)
                {
                    DataRow item1 = foundRows1[0];
                    valor = item1["cabezas"].ToString().Replace(".000", "");
                    valort += Convert.ToInt32(valor);
                }

            }




            lblDetalles.Text = "Cabezas Totales en Mapa : " + "\r\n" + valort.ToString("N0") + "\r\n"
             + "Machos : " + valortm.ToString("N0") + "\r\n"
             + "Hembras : " + valorth.ToString("N0") + "\r\n"
             + "Cabezas Totales (c2000): " + "\r\n" + valort.ToString("N0") + "\r\n"
             + "Corrales : " + valortc.ToString("N0");

        }

        private void tablaUbicTemp()
        {

            dtUbictmp = new DataTable();

            dtUbictmp.Columns.Add("corral");
            dtUbictmp.Columns.Add("lat");
            dtUbictmp.Columns.Add("lng");
            dtUbictmp.Columns.Add("lat1");
            dtUbictmp.Columns.Add("lng1");
            dtUbictmp.Columns.Add("lat2");
            dtUbictmp.Columns.Add("lng2");
            dtUbictmp.Columns.Add("lat3");
            dtUbictmp.Columns.Add("lng3");
            dtUbictmp.Columns.Add("lat4");
            dtUbictmp.Columns.Add("lng4");

            dtUbictmp.Columns.Add("lat1m");
            dtUbictmp.Columns.Add("lng1m");
            dtUbictmp.Columns.Add("lat2m");
            dtUbictmp.Columns.Add("lng2m");
            dtUbictmp.Columns.Add("lat3m");
            dtUbictmp.Columns.Add("lng3m");
            dtUbictmp.Columns.Add("lat4m");
            dtUbictmp.Columns.Add("lng4m");

            dtUbictmp.Columns.Add("lat1a");
            dtUbictmp.Columns.Add("lng1a");
            dtUbictmp.Columns.Add("lat1b");
            dtUbictmp.Columns.Add("lng1b");
            dtUbictmp.Columns.Add("lat2a");
            dtUbictmp.Columns.Add("lng2a");
            dtUbictmp.Columns.Add("lat2b");
            dtUbictmp.Columns.Add("lng2b");
            dtUbictmp.Columns.Add("lat3a");
            dtUbictmp.Columns.Add("lng3a");
            dtUbictmp.Columns.Add("lat3b");
            dtUbictmp.Columns.Add("lng3b");
            dtUbictmp.Columns.Add("lat4a");
            dtUbictmp.Columns.Add("lng4a");
            dtUbictmp.Columns.Add("lat4b");
            dtUbictmp.Columns.Add("lng4b");
            
            dtUbictmp.Columns.Add("distancia");


        }


        private void zonaActividad(string nombre, List<PointLatLng> points, Color color)
        {

            polygonZona = new GMapPolygon(points, nombre)
            {
                Stroke = new Pen(Color.Black, 2),
                Fill = new SolidBrush(Color.FromArgb(50, color)), //Brushes.Transparent,
                Tag = nombre,
            };

            overlayZonas.Polygons.Add(polygonZona);

        }

        private void recepcionActividad(string nombre, List<PointLatLng> points, Color color)
        {

            polygonRecepcion = new GMapPolygon(points, nombre)
            {
                Stroke = new Pen(Color.Black, 2),
                Fill = new SolidBrush(Color.FromArgb(100, color)), //Brushes.Transparent,
                Tag = nombre,
            };

            overlayRecepcion.Polygons.Add(polygonRecepcion);

        }

        private void comederoActividad(string nombre, List<PointLatLng> points, Color color)
        {

            polygonComederos = new GMapPolygon(points, nombre)
            {
                Stroke = new Pen(Color.Black, 2),
                Fill = new SolidBrush(Color.FromArgb(100, color)), //Brushes.Transparent,
                Tag = nombre,
            };

            overlayComederos.Polygons.Add(polygonComederos);

        }

        private void corralActividad(string nombre, List<PointLatLng> points, Color color)
        {

            polygonCelda = new GMapPolygon(points, nombre)
            {
                Stroke = new Pen(Color.Black, 2),
                Fill = new SolidBrush(color), //Brushes.Transparent,
                //Fill = new SolidBrush(Color.FromArgb(50, Color.Red)), //Brushes.Transparent,
                Tag = nombre,
            };

            overlayCeldas.Polygons.Add(polygonCelda);

            //Bitmap bmpmarker = new Bitmap(40, 23);
            //Graphics graphicImage = Graphics.FromImage(bmpmarker);
            //graphicImage.SmoothingMode = SmoothingMode.AntiAlias;
            //graphicImage.DrawString(nombre, new Font("Arial", 10, FontStyle.Regular), SystemBrushes.WindowText, new Point(5, 10));
            //graphicImage.Dispose();

            //PointLatLng centerPoint = GetZoneCenter(points);
            //markerlabelCelda = new GMarkerGoogle(centerPoint, bmpmarker);
            //overlaylabelCeldas.Markers.Add(markerlabelCelda);

        }

        private void corralActividadNombre(string nombre, List<PointLatLng> points, Color color)
        {

            int tamano;
            int ancho = 40;
            int alto = 23;

            switch (Convert.ToInt32(trackBar1.Value))
            {
                case 20: //max
                    tamano = 15;
                    ancho = 60;
                    alto = 60;
                    break;
                case 19: 
                    tamano = 15;
                    ancho = 60;
                    alto = 60;
                    break;
                case 18:
                    tamano = 10;
                    ancho = 50;
                    alto = 50;
                    break;
                case 17: //medio
                    tamano = 8;
                    ancho = 40;
                    alto = 50;
                    break;
                case 16:
                    tamano = 1;
                    ancho = 40;
                    alto = 23;
                    break;
                case 15: //min
                    tamano = 1;
                    ancho = 40;
                    alto = 23;
                    break;
                default:
                    tamano = 10;
                    ancho = 40;
                    alto = 23;
                    break;
            }

            Bitmap bmpmarker = new Bitmap(ancho, alto);
            Graphics graphicImage = Graphics.FromImage(bmpmarker);
            graphicImage.SmoothingMode = SmoothingMode.AntiAlias;
            graphicImage.DrawString(nombre, new Font("Tamoha", tamano, FontStyle.Regular ), SystemBrushes.WindowText, new Point(5, 37));
            graphicImage.Dispose();

            PointLatLng centerPoint = GetZoneCenter(points);

            centerPoint.Lat -= 0.000000;
            centerPoint.Lng += 0.000000;

            markerlabelCelda = new GMarkerGoogle(centerPoint, bmpmarker);
            overlaylabelCeldas.Markers.Add(markerlabelCelda);

            


        }

        private void corralActividadNombres(GMapPolygon polygon, string valor, Color color)
        {
    
            int tamano = 8;
            int ancho = 40;
            int alto = 22; //11;

            int tmin = trackBar1.Minimum;
            int ttam = trackBar1.Value - tmin;

            if (ttam >= 0 && ttam <= 1) {return;}

            //tamano = Convert.ToInt32(Math.Pow(2,ttam+1));
            //lblErrores.Text = "escala"+ttam.ToString()+",letra:"+tamano.ToString() + ",a" + ancho.ToString() + ",h" + alto.ToString();


            //valor = "";

            Bitmap bmpmarker = new Bitmap(ancho, alto);
            Graphics graphicImage = Graphics.FromImage(bmpmarker);
            graphicImage.SmoothingMode = SmoothingMode.AntiAlias;
            graphicImage.DrawString(valor, new Font("Tamoha", tamano, FontStyle.Bold), SystemBrushes.WindowText, new Point(3, 0));
            graphicImage.DrawString(polygon.Name, new Font("Tamoha", tamano, FontStyle.Bold), SystemBrushes.WindowText, new Point(0, 10));
            graphicImage.Dispose();


            PointLatLng centerPoint = GetZoneCenter(polygon.Points);
            //double dist = getDistancia(polygon.Points.ElementAt(0).Lat, polygon.Points.ElementAt(0).Lng, centerPoint.Lat, centerPoint.Lng);
            //lblErrores.Text = dist.ToString();

            PointLatLng ladoPoint = new PointLatLng();

            int p1=0, p2=0;

            switch (gorientacion) 
            {
                case 0:
                    p1 = 2;
                    p2 = 3;
                    break;
                case 1:
                    p1 = 3;
                    p2 = 0;
                    break;
                case 2:
                    p1 = 0;
                    p2 = 1;
                    break;
                case 3:
                    p1 = 1;
                    p2 = 2;
                    break;
            }

            ladoPoint.Lat = (polygon.Points.ElementAt(p1).Lat + polygon.Points.ElementAt(p2).Lat) / 2;
            ladoPoint.Lng = (polygon.Points.ElementAt(p1).Lng + polygon.Points.ElementAt(p2).Lng) / 2;

            if (ttam == 2 && valor.Length > 0)
            {
                markerlabelCelda = new GMarkerGoogle(ladoPoint, bmpmarker);
            }
            else 
            { 
                markerlabelCelda = new GMarkerGoogle(centerPoint, bmpmarker);            
            }
            
            overlaylabelCeldas.Markers.Add(markerlabelCelda);

           

        }

        private PointLatLng GetZoneCenter(List<PointLatLng> vertexes)
        {

            PointLatLng centerPoint = new PointLatLng();
            int sum = 0;
            double lat = 0;
            double lng = 0;

            foreach (var point in vertexes)
            {
                sum += 1;
                lat += point.Lat;
                lng += point.Lng;
            }

            lat = lat / sum;
            lng = lng / sum;

            centerPoint.Lat = lat;
            centerPoint.Lng = lng;

            return centerPoint;

        }

        private void frmMapa_FormClosed(object sender, EventArgs e)
        {
            FlushMemory();
        }

        private void frmMapa_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public static void FlushMemory()
        {

            GC.Collect();
            GC.WaitForPendingFinalizers();
            SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);

        }

        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBClima.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void webclimaUrl()
        {

            string url = "http://" + ip + "/gusi/engorda/gps/wsclimatamuin.php";
            Navigate(url);

        }

        private void origenDatos(string desdesap)
        {

            switch (desdesap)
            {
                case "0":
                    lblOrigenDatos.Text = "WS";
                    break;
                case "1":
                    lblOrigenDatos.Text = "SAP";
                    break;
            }

        }

        private AccessMode modoAcceso(string instancia)
        {

            switch (instancia)
            {
                case "0":
                    lblInstancia.Text = "Internet";
                    return AccessMode.ServerOnly;
                case "1":
                    lblInstancia.Text = "Internet y Local";
                    return AccessMode.ServerAndCache;
                case "2":
                    lblInstancia.Text = "Local";
                    return AccessMode.CacheOnly;
                default:
                    return AccessMode.ServerOnly;
            }

        }

        private void cargaMapa()
        {

            GMaps.Instance.Mode = modoAcceso(instancia);
            //gMapControl1.Manager.Mode = modoAcceso(instancia);
            gMapControl1.CacheLocation = @"mapa";
            

            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            //gMapControl1.MaspProvider = GMapProviders.GoogleMap;
            gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
            //gMapControl1.MapProvider = GMapProviders.GoogleChinaHybridMap;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;

            gMapControl1.MaxZoom = 20;
            gMapControl1.MinZoom = 15;

            gMapControl1.Zoom = 17;
            gMapControl1.Bearing = -140;//-50;
            gMapControl1.AutoScroll = true;

            trackBar1.Value = Convert.ToInt32(gMapControl1.Zoom);
            //lblCoordenadas.Text = "lat= " + Convert.ToString(LatInicial) + "   long= " + Convert.ToString(LngInicial);
            lblCoordenadas.Text = Convert.ToString(LatInicial) + "," + Convert.ToString(LngInicial);

        }

        private void tablaCamionTemp()
        {

            dtCamiontmp = new DataTable();

            dtCamiontmp.Columns.Add("id");
            dtCamiontmp.Columns.Add("name");
            dtCamiontmp.Columns.Add("tipo");

        }

        private void tablaListaCamionTemp()
        {

            dtListaCamiontmp = new DataTable();

            dtListaCamiontmp.Columns.Add("id");
            dtListaCamiontmp.Columns.Add("name");
            dtListaCamiontmp.Columns.Add("tipo");

        }

        private void tablaCabezasTemp()
        {

            dtCabezastmp = new DataTable();

            dtCabezastmp.Columns.Add("centro");
            dtCabezastmp.Columns.Add("corral");
            dtCabezastmp.Columns.Add("fecha");
            dtCabezastmp.Columns.Add("lote");
            dtCabezastmp.Columns.Add("tipo");
            dtCabezastmp.Columns.Add("sexo");
            dtCabezastmp.Columns.Add("peso");
            dtCabezastmp.Columns.Add("cabezas");

        }

        private void listaCamiones()
        {

            DataTable dt = new DataTable();

            leerWsdlListaCamion(ref dt);
            //leerWsListaCamion(ref dt);

            dt.DefaultView.Sort = "id" + " asc";
            dt = dt.DefaultView.ToTable();

            cmbCamionRuta.Items.Clear();
            cmbCamion.Items.Clear();

            dtListaCamiontmp.Clear();

            foreach (DataRow row in dt.Rows)
            {

                //if (!row["id"].ToString().Equals("00"))
                //{
                    DataRow newRow = dtListaCamiontmp.NewRow();

                    newRow["id"] = row["id"].ToString();
                    newRow["name"] = row["name"].ToString();
                    newRow["tipo"] = row["type"].ToString();

                    dtListaCamiontmp.Rows.Add(newRow);

                    cmbCamionRuta.Items.Add(newRow["id"]);
                    cmbCamion.Items.Add(newRow["id"]);
                //}

            }


            if (cmbCamionRuta.Items.Count > 0) {
                cmbCamionRuta.SelectedIndex = 0;
            }

            if (cmbCamion.Items.Count > 0)
            {
                cmbCamion.SelectedIndex = 0;
            }

        }

        private void llenacombocolorcapas()
        {
            cmbColorCapas.Items.Add("Blanco");
            cmbColorCapas.Items.Add("Transp");

            cmbColorCapas.SelectedIndex = 0;
   

        }

        private void agregaractualizarMarcadorCorral()
        {


        }

        private void agregaractualizarMarcadorCamion(string id, string name, string fecha, string hora, string racion, string carga, string servida, double lat, double lng, string corral, string plan, string servido, string falta, string corrales, string velocidad, string status)
        {

            string horaAct = DateTime.Now.ToString("HH") + ":" + DateTime.Now.ToString("mm") + ":" + DateTime.Now.ToString("ss");
            DateTime hora1 = Convert.ToDateTime(hora);
            DateTime hora2 = Convert.ToDateTime(horaAct);
            TimeSpan demora = hora2.Subtract(hora1);

            Bitmap bmpmarker = new Bitmap(this.imageList1.Images[6]); //imagen camion

            SolidBrush drawBrush = new SolidBrush(Color.White); //color numero camion

            Graphics graphicImage = Graphics.FromImage(bmpmarker);
            graphicImage.SmoothingMode = SmoothingMode.AntiAlias;
            Point punto = new Point(2, 6);
            graphicImage.DrawString(id, new Font("Arial", 11, FontStyle.Bold), drawBrush, punto);
            graphicImage.Dispose();



            markerCamion = new GMarkerGoogle(new PointLatLng(lat, lng), bmpmarker);
            markerCamion.ToolTipMode = MarkerTooltipMode.OnMouseOver;//.Always;

            switch (status)
            {
                case "S":

                    markerCamion.ToolTipText = string.Format("SIRVIENDO \n {0} \n RACION: {1} \n SERVIDA: {2} \n CORRAL: {5} \n CARGA: {3} Kg \nPLAN: {6} kg\nSERVIDO: {7} kg\nFALTA: {8} kg \n CORRALES SIN SERVIR: {9} \n VELOCIDAD: {11} \n HORA:{4} \n DEMORA WEB: {10}", name, racion, servida, carga, hora, corral, plan, servido, falta, corrales, demora, velocidad);

                    break;
                case "C":

                    markerCamion.ToolTipText = string.Format("CARGANDO\n{0}", name);

                    break;


            }

            overlayCamiones.Markers.Add(markerCamion);
        }

        private void agregaractualizarMarcadorLocalizaCamion(string id, string name, string fecha, string hora, double lat, double lng, string racion, string servida)
        {

            string horaAct = DateTime.Now.ToString("HH") + ":" + DateTime.Now.ToString("mm") + ":" + DateTime.Now.ToString("ss");
            DateTime hora1 = Convert.ToDateTime(hora);
            DateTime hora2 = Convert.ToDateTime(horaAct);
            TimeSpan demora = hora2.Subtract(hora1);
            Image vimg;

            if (demora.TotalMinutes <= Convert.ToDouble(inactividad))
            {
                vimg = this.imageList1.Images[6];
                mostrarCamionActivo(id, false);
            }
            else
            {
                vimg = this.imageList1.Images[2];
                mostrarCamionActivo(id, true);
            }

            Bitmap bmpmarker = new Bitmap(vimg); //imagen camion

            SolidBrush drawBrush = new SolidBrush(Color.White); //color numero camion

            Graphics graphicImage = Graphics.FromImage(bmpmarker);
            graphicImage.SmoothingMode = SmoothingMode.AntiAlias;
            Point punto = new Point(2, 6);
            graphicImage.DrawString(id, new Font("Arial", 11, FontStyle.Bold), drawBrush, punto);
            graphicImage.Dispose();

            markerCamion = new GMarkerGoogle(new PointLatLng(lat, lng), bmpmarker);
            markerCamion.ToolTipMode = MarkerTooltipMode.OnMouseOver;//.Always;

            markerCamion.ToolTipText = string.Format("CAM {4}, {2}, SERV {3}, HR {1}", name, hora, racion, servida, id);
            //markerCamion.ToolTipText = string.Format("{0} \n VELOCIDAD: {1} \n HORA:{2}", name, velocidad, hora);

            overlayCamiones.Markers.Add(markerCamion);
        }

        private void agregaractualizarMarcadorUbicacion(string id, string name, double lat, double lng)
        {

            Image imagen;
            imagen = this.imageListColor.Images[0];


            //lat += 0.000150;
            //lng += 0.000135;
            /*
                       switch (id)
                       {
                           case "1030":
                               imagen = this.imageListColor.Images[2];
                               break;
                           case "1111":
                               imagen = this.imageListColor.Images[2];
                               break;
                           case "1114":
                               imagen = this.imageListColor.Images[0];
                               break;
                           default:
                               imagen = this.imageListColor.Images[1];
                               break; 
                       }
                       */


            //imageListColor.ImageSize = new Size(20, 20);

            //Bitmap bmpmarker = new Bitmap(this.imageList1.Images[1]);
            Bitmap bmpmarker = new Bitmap(imagen);

            ///////
            Graphics graphicImage = Graphics.FromImage(bmpmarker);
            graphicImage.SmoothingMode = SmoothingMode.AntiAlias;
            graphicImage.DrawString(id, new Font("Arial", 10, FontStyle.Bold), SystemBrushes.WindowText, new Point(5, 10));
            graphicImage.Dispose();
            /////


            markerUbicacion = new GMarkerGoogle(new PointLatLng(lat, lng), bmpmarker);
            //markerUbicacion.ToolTipMode = MarkerTooltipMode.OnMouseOver;// .Always;
            //markerUbicacion.ToolTipText = string.Format("{0} {1}", id, name);
            overlayUbicaciones.Markers.Add(markerUbicacion);

        }

        private void agregarZona()
        {
            
            _points.Clear();
            _points.Add(new PointLatLng(21.898814,-98.745546));
            _points.Add(new PointLatLng(21.902557,-98.750396));
            _points.Add(new PointLatLng(21.907613,-98.746061));
            _points.Add(new PointLatLng(21.903632,-98.74104));

            zonaActividad("Zona1", _points, Color.Blue);


            _points.Clear();
            _points.Add(new PointLatLng(21.894075,-98.743465));
            _points.Add(new PointLatLng(21.897002,-98.74707));
            _points.Add(new PointLatLng(21.902039,-98.742328));
            _points.Add(new PointLatLng(21.899371,-98.73883));         
            
            zonaActividad("Zona2", _points, Color.Red);


            _points.Clear();
            _points.Add(new PointLatLng(21.892074,-98.73957));
            _points.Add(new PointLatLng(21.894782,-98.742886));
            _points.Add(new PointLatLng(21.899302,-98.738852));
            _points.Add(new PointLatLng(21.896524,-98.735397));

            zonaActividad("Zona3", _points, Color.Green);
            

            _points.Clear();
            _points.Add(new PointLatLng(21.889396,-98.736105));
            _points.Add(new PointLatLng(21.892005,-98.739474));
            _points.Add(new PointLatLng(21.898057,-98.733938));
            _points.Add(new PointLatLng(21.89535,-98.730569));

            zonaActividad("Zona4", _points, Color.Yellow);




  



        }

        private void agregarRecepciones()
        {
            _pointsc.Clear();
            _pointsc.Add(new PointLatLng(21.916079, -98.747773));
            _pointsc.Add(new PointLatLng(21.916512, -98.748352));
            _pointsc.Add(new PointLatLng(21.916851, -98.748049));
            _pointsc.Add(new PointLatLng(21.916373, -98.747435));

            recepcionActividad("Recepciones 1004", _pointsc, Color.Brown);


            //_pointsc.Clear();
            //_pointsc.Add(new PointLatLng(21.91693, -98.746399));
            //_pointsc.Add(new PointLatLng(21.917157, -98.746668));
            //_pointsc.Add(new PointLatLng(21.91749, -98.746348));
            //_pointsc.Add(new PointLatLng(21.917149, -98.745898));

            //recepcionActividad("Recepciones 00", _pointsc, Color.Brown);

            _pointsc.Clear();
            _pointsc.Add(new PointLatLng(21.917572, -98.748886));
            _pointsc.Add(new PointLatLng(21.917741, -98.749106));
            _pointsc.Add(new PointLatLng(21.918082, -98.748797));
            _pointsc.Add(new PointLatLng(21.917911, -98.748577));

            recepcionActividad("Recepciones 1005", _pointsc, Color.Brown);




            _pointsc.Clear();
            _pointsc.Add(new PointLatLng(21.917323, -98.74523));
            _pointsc.Add(new PointLatLng(21.919209, -98.747697));
            _pointsc.Add(new PointLatLng(21.919906, -98.747075));
            _pointsc.Add(new PointLatLng(21.917667, -98.74413));
            _pointsc.Add(new PointLatLng(21.917353, -98.744425));

            recepcionActividad("Recepciones 01", _pointsc, Color.Brown);

            //_pointsc.Clear();
            //_pointsc.Add(new PointLatLng(21.9220311912, -98.7439262867));
            //_pointsc.Add(new PointLatLng(21.92253382, -98.7445914745));
            //_pointsc.Add(new PointLatLng(21.9228672461, -98.7442910671));
            //_pointsc.Add(new PointLatLng(21.9223596419, -98.7436258793));

            //recepcionActividad("Recepciones 02", _pointsc, Color.Brown);

            //_pointsc.Clear();
            //_pointsc.Add(new PointLatLng(21.925423, -98.740895));
            //_pointsc.Add(new PointLatLng(21.926015, -98.741652));
            //_pointsc.Add(new PointLatLng(21.926649, -98.741078));
            //_pointsc.Add(new PointLatLng(21.92608, -98.740303));

            //recepcionActividad("Recepciones 03", _pointsc, Color.Brown);





            _pointsc.Clear();
            _pointsc.Add(new PointLatLng(21.926764, -98.745954));
            _pointsc.Add(new PointLatLng(21.927505, -98.746936));
            _pointsc.Add(new PointLatLng(21.927674, -98.746791));
            _pointsc.Add(new PointLatLng(21.926918, -98.745798));

            recepcionActividad("Enf 01", _pointsc, Color.Brown);

            _pointsc.Clear();
            _pointsc.Add(new PointLatLng(21.927401, -98.744967));
            _pointsc.Add(new PointLatLng(21.928177, -98.745959));
            _pointsc.Add(new PointLatLng(21.928311, -98.745804));
            _pointsc.Add(new PointLatLng(21.927565, -98.744811));

            recepcionActividad("Enf 02", _pointsc, Color.Brown);

            //_pointsc.Clear();
            //_pointsc.Add(new PointLatLng(21.926721, -98.747494));
            //_pointsc.Add(new PointLatLng(21.927055, -98.747904));
            //_pointsc.Add(new PointLatLng(21.927376, -98.74762));
            //_pointsc.Add(new PointLatLng(21.927045, -98.747201));

            //recepcionActividad("Enf 03", _pointsc, Color.Brown);

            //_pointsc.Clear();
            //_pointsc.Add(new PointLatLng(21.915618, -98.753082));
            //_pointsc.Add(new PointLatLng(21.9157, -98.753356));
            //_pointsc.Add(new PointLatLng(21.91598, -98.753259));
            //_pointsc.Add(new PointLatLng(21.9159, -98.752984));

            //recepcionActividad("Enf 04", _pointsc, Color.Brown);






        }

        private void agregaractualizarMarcadorCelda(string id, string name, double lat, double lng, double lat1, double lng1, double lat2, double lng2, double lat3, double lng3, double lat4, double lng4)
        {

            _points.Clear();
            _points.Add(new PointLatLng(lat1, lng1));
            _points.Add(new PointLatLng(lat2, lng2));
            _points.Add(new PointLatLng(lat3, lng3));
            _points.Add(new PointLatLng(lat4, lng4));

            corralActividad(id, _points, Color.White);
            //corralActividadNombre(id, _points, Color.White);

        }

        private void agregaractualizarMarcadorModificarUbicacion(string id, string name, double lat, double lng)
        {
            Bitmap bmpmarker = new Bitmap(this.imageList1.Images[3]);

            markerBuscarUbicacion = new GMarkerGoogle(new PointLatLng(lat, lng), bmpmarker);
            markerBuscarUbicacion.ToolTipMode = MarkerTooltipMode.Always;
            markerBuscarUbicacion.ToolTipText = string.Format("{0}\n{1}\n{2}", id, lat, lng);
            overlayBuscarUbicaciones.Markers.Add(markerBuscarUbicacion);
                        
        }

        private void agregaractualizarMarcadorBuscarUbicacion(string id, string name, double lat, double lng)
        {
            //Bitmap bmpmarker = new Bitmap(this.imageList1.Images[1]);

            markerBuscarUbicacion = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.yellow);// bmpmarker);
            markerBuscarUbicacion.ToolTipMode = MarkerTooltipMode.OnMouseOver;// .Always;
            markerBuscarUbicacion.ToolTipText = string.Format("{0}, {1}, {2}", id, lat, lng);
            overlayBuscarUbicaciones.Markers.Add(markerBuscarUbicacion);
        }

        private void agregarMarcadorUbicacion(string id, double lat, double lng)
        {
            Bitmap bmpmarker = new Bitmap(this.imageList1.Images[3]);

            //markerRecorrido = new GMarkerGoogle(new PointLatLng(lat, lng), bmpmarker); // GMarkerGoogleType.blue);// .purple_small);
            markerUbicacion = new GMarkerGoogle(new PointLatLng(lat, lng), bmpmarker);//, GMarkerGoogleType.blue);// .purple_small);
            markerUbicacion.ToolTipMode = MarkerTooltipMode.Always;//.OnMouseOver;
            markerUbicacion.ToolTipText = string.Format("{0}", id);
            //markerRecorrido.ToolTipText = string.Format("{0} \n VELOCIDAD: {1} \n HORA:{2}", name, velocidad, hora);
            overlayUbicaciones.Markers.Add(markerUbicacion);
        }

        private void agregaractualizarMarcadorRecorrido(string id, string fecha, string hora, double lat, double lng)
        {
            Bitmap bmpmarker = new Bitmap(this.imageList1.Images[3]);

            //markerRecorrido = new GMarkerGoogle(new PointLatLng(lat, lng), bmpmarker); // GMarkerGoogleType.blue);// .purple_small);
            markerRecorrido = new GMarkerGoogle(new PointLatLng(lat, lng),  GMarkerGoogleType.blue);// .purple_small);
            markerRecorrido.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            markerRecorrido.ToolTipText = string.Format("CAMION {0}\nHORA:{1}", id , hora);
            //markerRecorrido.ToolTipText = string.Format("{0} \n VELOCIDAD: {1} \n HORA:{2}", name, velocidad, hora);
            overlayRecorridos.Markers.Add(markerRecorrido);
        }

        private void agregaractualizarMarcadorRepartos(string id, int opc, string fecha, string hora, double lat, double lng)
        {

            int indice = 3;

            switch (opc)
            {
                case 1:
                    indice = 3;
                    break;
                case 2:
                    indice = 7;
                    break;
                case 3:
                    indice = 8;
                    break;

            } 

            Bitmap bmpmarker = new Bitmap(this.imageList1.Images[indice]);

            //markerRecorrido = new GMarkerGoogle(new PointLatLng(lat, lng), bmpmarker); // GMarkerGoogleType.blue);// .purple_small);
            markerRecorrido = new GMarkerGoogle(new PointLatLng(lat, lng), bmpmarker);// .purple_small);
            markerRecorrido.ToolTipMode = MarkerTooltipMode.Always;
            markerRecorrido.ToolTipText = string.Format("{0} {1}", id, hora);
            //markerRecorrido.ToolTipText = string.Format("{0} \n VELOCIDAD: {1} \n HORA:{2}", name, velocidad, hora);
            overlayRecorridos.Markers.Add(markerRecorrido);
        }

        private void agregaractualizarMarcadorRecorridoCamion(string id, string fecha, string hora, int numero, double lat, double lng, Boolean textos)
        {
            Bitmap bmpmarker = new Bitmap(this.imageList1.Images[4]);

            markerRecorrido = new GMarkerGoogle(new PointLatLng(lat, lng), bmpmarker); // GMarkerGoogleType.blue);// .purple_small);
            //markerRecorrido = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.blue);// .purple_small);
            if (textos)
            {
                markerRecorrido.ToolTipMode = MarkerTooltipMode.Always;         
            }
            else 
            {
                markerRecorrido.ToolTipMode = MarkerTooltipMode.OnMouseOver;   
            }


            markerRecorrido.ToolTipText = string.Format("({0}) {1}",numero, hora);
            //markerRecorrido.ToolTipText = string.Format("{0} \n VELOCIDAD: {1} \n HORA:{2}", name, velocidad, hora);
            overlayRecorridos.Markers.Add(markerRecorrido);
        }

        /*
        private void agregaractualizarMarcadorCamion2(object tag,double lat, double lng)
        {

            //markerCamiones = new GMapOverlay("camiones");

            marker = new GMarkerGoogle(new PointLatLng(lat, lng),GMarkerGoogleType.green);
            markerCamiones.Markers.Add(marker);
            gMapControl1.UpdateMarkerLocalPosition(marker);

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format(tag);

            gMapControl1.Overlays.Add(markerCamiones);
            
            //gMapControl1.Refresh();
            //gMapControl1.UpdateMarkerLocalPosition(marker);
                       
            //Bitmap bmpmarker = (Bitmap)NewImage;

            var marker = markerCamiones.Markers.FirstOrDefault(m => m.Tag == tag);

            if (marker != null)
            {
                //mover
                markerCamiones.Markers.Remove(marker);
                gMapControl1.Refresh();
                marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.green);//bmpmarker);
                marker.Tag = tag;
                markerCamiones.Markers.Add(marker);
                gMapControl1.Overlays.Add(markerCamiones);
                //gMapControl1.Refresh();
            }
            else
            {
                //nuevo
                //markerOverlay = new GMapOverlay("marcadores");
                marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.green);//bmpmarker);
                marker.Tag = tag;
                markerCamiones.Markers.Add(marker);

                //gMapControl1.Overlays.Add(markerCamiones);
                //gMapControl1.Refresh();
            }
            
            //gMapControl1.UpdateMarkerLocalPosition(marker);
           
        }
*/

        private void quitarMarcadoresMapa()
        {
            gMapControl1.Overlays.Clear();
        }

        private void quitarMarcadorCamiones()
        {
            overlayCamiones.Markers.Clear();
        }

        private void quitarMarcadorUbicaciones()
        {
            overlayUbicaciones.Markers.Clear();
        }

        private void quitarMarcadorCeldas()
        {
            overlayCeldas.Polygons.Clear();
            overlaylabelCeldas.Markers.Clear();
        }

        private void quitarMarcadorCeldasRecepciones()
        {
            overlayRecepcion.Polygons.Clear();
            overlaylabelCeldas.Markers.Clear();
        }

        private void quitarMarcadorBuscarUbicaciones()
        {
            overlayBuscarUbicaciones.Markers.Clear();
        }

        private void quitarMarcadorRecorridos()
        {
            overlayRecorridos.Markers.Clear();
        }

        private void quitarMarcadorRutas()
        {
            overlayRutas.Routes.Clear();
        }

        private void posicionBTN()
        {

            toolStrip1.Top = tabControl1.Top + tabControl1.Height;
            toolStrip1.Left = 0;
            toolStrip1.Width = this.Width;

            //picLogo.Top = 30;
            //picLogo.Left = this.Width - picLogo.Width - 30;

            //txtDistancia.Top = btnEmpacadora.Top + txtDistancia.Height + 5;
            //txtDistancia.Left = (this.Width / 2) - (txtDistancia.Width / 2);

            panelTrack.Top = 70;
            panelTrack.Left = 10;

            btnRotarDer.Top = panelTrack.Top + panelTrack.Height + 40;
            btnRotarDer.Left = panelTrack.Left;

            btnRotarIzq.Top = btnRotarDer.Top;
            btnRotarIzq.Left = btnRotarDer.Left;

            //panelRuta.Top = 60;
            //panelRuta.Left = 60;

            /*
            datFecha.Top = 40;
            datFecha.Left = 10;

            cmbCamionRuta.Top = datFecha.Top + datFecha.Height + 20;
            cmbCamionRuta.Left = datFecha.Left;
            */

            //lstCamiones.Top = this.Height / 2 - 80;
            //lstCamiones.Left = this.Width - lstCamiones.Width - 30;

            webBClima.Top = 40;
            webBClima.Left = this.Width - webBClima.Width - 30;
            webBClima.Height = 340;

            //panelFlechas.Top = this.Height - panelFlechas.Height - 100;
            //panelFlechas.Left = this.Width - panelFlechas.Width - 100;

            panelLeyenda.Top = this.Height - panelLeyenda.Height - 90;
            panelLeyenda.Left = 10;

            panelLeyendas.Top = this.Height - panelLeyendas.Height - 90;
            panelLeyendas.Left = 10;

            panelFecha.Top = toolStrip1.Top + toolStrip1.Height;
            panelFecha.Left = this.Width / 4;

            //chart1.Left = this.Width / 4;
            //chart1.Top = this.Height - chart1.Height - 90;

            chart2.Left = this.Width - chart2.Width - 30;
            chart2.Top = this.Height - chart2.Height - 90;

            chart1.Top = chart2.Top;
            chart1.Left = chart2.Left - chart1.Width;

            panelDetalles.Top = panelLeyendas.Top;
            panelDetalles.Left = panelLeyendas.Left;
            panelDetalles.Height = panelLeyendas.Height;
            panelDetalles.Width = panelLeyendas.Width;

            //panelCamiones.Top = this.Height - 110;
            //panelCamiones.Left = (this.Width / 2) - (panelCamiones.Width / 2);

            panelCamiones.Top = this.Height - 63;
            panelCamiones.Left = this.Width - panelCamiones.Width - 10;





        }

        private void btnSatelital_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }

        private void btnRelieve_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackMover();
        }

        private void trackMover() 
        { 
            gMapControl1.Zoom = trackBar1.Value;
            lblZomm.Text = valorPorcZomm() + "%";       
        }

        private string valorPorcZomm()
        {

            string valor;

            switch (Convert.ToInt32(trackBar1.Value))
            {
                case 20:
                    valor = "175";
                    break;
                case 19:
                    valor = "150";
                    break;
                case 18:
                    valor = "125";
                    break;
                case 17:
                    valor = "100";
                    break;
                case 16:
                    valor = "75";
                    break;
                case 15:
                    valor = "50";
                    break;

                default:
                    valor = "0";
                    break;
            }

            return valor;

        }
               
        private void timerCamion_Tick(object sender, EventArgs e)
        {

            tim();

        }

        private void tim() 
        { 

            if (indiceBotonFecha == 1)
            {
                txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }

            //lblErrores.Text = "Ok";

            mostrarLocalizaCamiones();

            //mostrarDatos(tab);
                       
            mostrarDatosWs();

            //FlushMemory();

            //mostrarCamionesActivos();


            //Convert.ToInt32()

            if (lblConectadoF.Value == 0)
            {
                lblConectadoF.Value = 1;
            }
            else 
            {
                lblConectadoF.Value = 0;
            }      

        }

        private void mostrarDatosWs()
        {

            switch (indiceBotonVista)
            {
                case 1:
                    mostrarRepartoCorral();
                    break;
                case 2:
                    mostrarReparto("racion");
                    break;
                case 3:
                    mostrarReparto("numcamion");
                    break;
                case 4:
                    mostrarReparto("racion");
                    break;
                case 0:
                    mostrarCabezasCorral();
                    break;

                default:
                    break;
            }

            gMapControl1.Refresh();

        }
                

        private void mostrarDatos(int itab)
        {

            switch (itab)
            {
                case 0:
                                       
                    switch (indiceBotonVista)
                    {
                        case 1:
                            mostrarRepartoCorral();

                            break;
                        case 2:

                            //corralActividadInicio();

                            break;

                        default:
                            break;
                    }

                    break;

                //case 1:
                //    //obtenerWsdlServidasSap(dtRepartotmp, DateTime.Today);
                //    obtenerServidasSap(dtRepartotmp,1,DateTime.Today);
                //    mostrarRepartoCorral(desdesap);
                //    break;

                //case 2:
                //    //DateTime fecha = datFechaServida.Value;
                //    //fecha = Convert.ToDateTime(fecha.ToString("yyyy-MM-dd"));
                //    DateTime fecha = Convert.ToDateTime(txtFecha.Text);

                //    //obtenerWsdlServidasSap(dtRepartotmp, fecha);
                //    obtenerServidasSap(dtRepartotmp,2,fecha);
                //    mostrarRepartoCorral(desdesap);
                //    break;

            }

            //////

            /////
            //mostrarRepartoCorral(1);
            gMapControl1.Refresh();

            //grafico1(chart1);
            //grafico2(chart2);
            
        }

        private void mostrarCamiones()
        {

            DataTable dt = new DataTable();
            DateTime fecha;
            DateTime hoy = DateTime.Today;

            leerWsCamion(ref dt);


            if (dt.Rows.Count > 0)
            {
                
                quitarMarcadorCamiones();

                //lstCamiones.Items.Clear();

                //cmbCamiones.Items.Clear();

                dtCamiontmp.Clear();

                foreach (DataRow row in dt.Rows)
                {

                    fecha = Convert.ToDateTime(row["fecha"].ToString());

                    if (fecha == hoy)
                    {
                        agregaractualizarMarcadorCamion(
                            row["id"].ToString(),
                            row["name"].ToString(),
                            row["fecha"].ToString(),
                            row["hora"].ToString(),
                            row["racion"].ToString(),
                            row["carga"].ToString(),
                            row["servida"].ToString(),
                            Convert.ToDouble(row["lat"]),
                            Convert.ToDouble(row["lng"]),
                            row["corral"].ToString(),
                            row["plan"].ToString(),
                            row["servido"].ToString(),
                            row["falta"].ToString(),
                            row["corrales"].ToString(),
                            row["velocidad"].ToString(),
                            row["status"].ToString());

                        //lstCamiones.Items.Add(row["name"].ToString());

                        DataRow newRow = dtCamiontmp.NewRow();

                        newRow["id"] = row["id"].ToString();
                        newRow["name"] = row["name"].ToString();

                        dtCamiontmp.Rows.Add(newRow);
                        
                        int index = cmbCamiones.FindString(row["name"].ToString());

                        if (cmbCamiones.FindString(row["name"].ToString()) < 0)
                        {

                            cmbCamiones.Items.Add(row["name"].ToString());

                        }



                    }

                }

            }
            else
            {

                quitarMarcadorCamiones();

                //lstCamiones.Items.Clear();

                //cmbCamiones.Items.Clear();

            }

            vdt.Clear();
            vdt = dt;

        }

        private void mostrarLocalizaCamiones()
        {

            try {
                
                DataTable dt = new DataTable();
                DateTime fecha;
                DateTime hoy = DateTime.Today;

                //leerWsLocalizaCamion(ref dt);
                leerWsdlLocalizaCamion(ref dt);


                if (dt.Rows.Count > 0)
                {

                    quitarMarcadorCamiones();

                    //lstCamiones.Items.Clear();

                    //cmbCamiones.Items.Clear();

                    dtCamiontmp.Clear();

                    foreach (DataRow row in dt.Rows)
                    {

                        fecha = Convert.ToDateTime(row["fecha"].ToString());

                        if (fecha == hoy)
                        {
                            agregaractualizarMarcadorLocalizaCamion(
                                row["numcamion"].ToString(),
                                row["name"].ToString(),
                                row["fecha"].ToString(),
                                row["hora"].ToString(),
                                Convert.ToDouble(row["lat"]),
                                Convert.ToDouble(row["lng"]), //* -1,
                                row["racion"].ToString(),
                                int.Parse(row["servida"].ToString()).ToString()
                                );


                            //lstCamiones.Items.Add(row["name"].ToString());

                            DataRow newRow = dtCamiontmp.NewRow();

                            newRow["id"] = row["numcamion"].ToString();
                            newRow["name"] = row["name"].ToString();

                            dtCamiontmp.Rows.Add(newRow);


                            int index = cmbCamiones.FindString(row["name"].ToString());

                            if (cmbCamiones.FindString(row["name"].ToString()) < 0)
                            {

                                cmbCamiones.Items.Add(row["name"].ToString());

                            }



                        }

                    }

                }
                else
                {

                    quitarMarcadorCamiones();

                    //lstCamiones.Items.Clear();

                    //cmbCamiones.Items.Clear();

                }

                vdt.Clear();
                vdt = dt;


            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrores.Text = "Localiza, " + e.Message;
            }


        }

        private void botonUbicaciones()
        {

            this.Cursor = Cursors.WaitCursor;

            if (!ubicActivo)
            {
                DataTable dt = new DataTable();

                //leerWsdlUbicacion(ref dt);
                consultaUbicaciones(ref dt);

                quitarMarcadorUbicaciones();

                foreach (DataRow row in dt.Rows)
                {
                    agregaractualizarMarcadorUbicacion(
                        row["id"].ToString(),
                        row["name"].ToString(),
                        Convert.ToDouble(row["lat"]),
                        Convert.ToDouble(row["lng"]));
                }

            }
            else
            {
                quitarMarcadorUbicaciones();
            }

            ubicActivo = !ubicActivo;

            this.Cursor = Cursors.Default;

        }

        private void botonCeldas()
        {

            this.Cursor = Cursors.WaitCursor;

            if (!celdaActivo)
            {
                DataTable dt = new DataTable();

        
                consultaUbicaciones(ref dt);
                //leerWsdlUbicacion(ref dt);

                //leerWsUbicacion(ref dt);

                quitarMarcadorCeldas();

                dtUbictmp.Clear();


                foreach (DataRow row in dt.Rows)
                {
                    agregaractualizarMarcadorCelda(
                        row["corral"].ToString(),
                        row["name"].ToString(),
                        Convert.ToDouble(row["lat"]),
                        Convert.ToDouble(row["lng"]),
                        Convert.ToDouble(row["lat1"]),
                        Convert.ToDouble(row["lng1"]),
                        Convert.ToDouble(row["lat2"]),
                        Convert.ToDouble(row["lng2"]),
                        Convert.ToDouble(row["lat3"]),
                        Convert.ToDouble(row["lng3"]),
                        Convert.ToDouble(row["lat4"]),
                        Convert.ToDouble(row["lng4"]));



                        DataRow newRow = dtUbictmp.NewRow();

                        newRow["corral"] = row["corral"];
                        newRow["lat"] = row["lat"];
                        newRow["lng"] = row["lng"];
                        newRow["lat1"] = row["lat1"];
                        newRow["lng1"] = row["lng1"];
                        newRow["lat2"] = row["lat2"];
                        newRow["lng2"] = row["lng2"];
                        newRow["lat3"] = row["lat3"];
                        newRow["lng3"] = row["lng3"];
                        newRow["lat4"] = row["lat4"];
                        newRow["lng4"] = row["lng4"];

                        newRow["lat1m"] = (Convert.ToDouble(row["lat1"]) + Convert.ToDouble(row["lat2"])) / 2;
                        newRow["lng1m"] = (Convert.ToDouble(row["lng1"]) + Convert.ToDouble(row["lng2"])) / 2;
                        newRow["lat2m"] = (Convert.ToDouble(row["lat2"]) + Convert.ToDouble(row["lat3"])) / 2;
                        newRow["lng2m"] = (Convert.ToDouble(row["lng2"]) + Convert.ToDouble(row["lng3"])) / 2;
                        newRow["lat3m"] = (Convert.ToDouble(row["lat3"]) + Convert.ToDouble(row["lat4"])) / 2;
                        newRow["lng3m"] = (Convert.ToDouble(row["lng3"]) + Convert.ToDouble(row["lng4"])) / 2;
                        newRow["lat4m"] = (Convert.ToDouble(row["lat4"]) + Convert.ToDouble(row["lat1"])) / 2;
                        newRow["lng4m"] = (Convert.ToDouble(row["lng4"]) + Convert.ToDouble(row["lng1"])) / 2;
                                       
                        newRow["lat1a"] = (Convert.ToDouble(row["lat1"]) + Convert.ToDouble(newRow["lat1m"])) / 2;
                        newRow["lng1a"] = (Convert.ToDouble(row["lng1"]) + Convert.ToDouble(newRow["lng1m"])) / 2;
                        newRow["lat1b"] = (Convert.ToDouble(newRow["lat1m"]) + Convert.ToDouble(row["lat2"])) / 2;
                        newRow["lng1b"] = (Convert.ToDouble(newRow["lng1m"]) + Convert.ToDouble(row["lng2"])) / 2;
                        newRow["lat2a"] = (Convert.ToDouble(row["lat2"]) + Convert.ToDouble(newRow["lat2m"])) / 2;
                        newRow["lng2a"] = (Convert.ToDouble(row["lng2"]) + Convert.ToDouble(newRow["lng2m"])) / 2;
                        newRow["lat2b"] = (Convert.ToDouble(newRow["lat2m"]) + Convert.ToDouble(row["lat3"])) / 2;
                        newRow["lng2b"] = (Convert.ToDouble(newRow["lng2m"]) + Convert.ToDouble(row["lng3"])) / 2;
                        newRow["lat3a"] = (Convert.ToDouble(row["lat3"]) + Convert.ToDouble(newRow["lat3m"])) / 2;
                        newRow["lng3a"] = (Convert.ToDouble(row["lng3"]) + Convert.ToDouble(newRow["lng3m"])) / 2;
                        newRow["lat3b"] = (Convert.ToDouble(newRow["lat3m"]) + Convert.ToDouble(row["lat4"])) / 2;
                        newRow["lng3b"] = (Convert.ToDouble(newRow["lng3m"]) + Convert.ToDouble(row["lng4"])) / 2;
                        newRow["lat4a"] = (Convert.ToDouble(row["lat4"]) + Convert.ToDouble(newRow["lat4m"])) / 2;
                        newRow["lng4a"] = (Convert.ToDouble(row["lng4"]) + Convert.ToDouble(newRow["lng4m"])) / 2;
                        newRow["lat4b"] = (Convert.ToDouble(newRow["lat4m"]) + Convert.ToDouble(row["lat1"])) / 2;
                        newRow["lng4b"] = (Convert.ToDouble(newRow["lng4m"]) + Convert.ToDouble(row["lng1"])) / 2;





                    dtUbictmp.Rows.Add(newRow);

                }

                corralesActividadNombre();

                agregarRecepciones();

            }
            else
            {
                quitarMarcadorCeldas();
                quitarMarcadorCeldasRecepciones();

            }

            celdaActivo = !celdaActivo;

            if (celdaActivo)
            {
                toolStripButton5.CheckState = CheckState.Checked;
            }
            else
            {
                toolStripButton5.CheckState = CheckState.Unchecked;
            }
            

            this.Cursor = Cursors.Default;

        }

        private void recorridoBoton()
        {
            //if (txtCantP.Text.Equals("")) {
            //    txtCantP.Text = "0";
            //}

            //int cantp = Convert.ToInt32(txtCantP.Text);
            int i = 1;

            this.Cursor = Cursors.WaitCursor;

            //////////
            //GMapOverlay Ruta = new GMapOverlay("Rutas");
            List<PointLatLng> puntos = new List<PointLatLng>();
            /////////

            //if (datFecha.Visible)
            //{
                DataTable dt = new DataTable();

                //leerWsRecorrido(ref dt);
                leerWsdlRecorrido(ref dt);
                       

                quitarMarcadorRecorridos();
                quitarMarcadorRutas();

                foreach (DataRow row in dt.Rows)
                {

                    agregaractualizarMarcadorRecorrido(
                        row["numcamion"].ToString(),
                        row["fecha"].ToString(),
                        row["hora"].ToString(),
                        Convert.ToDouble(row["lat"]),
                        Convert.ToDouble(row["lng"]));


                    puntos.Add(new PointLatLng(Convert.ToDouble(row["lat"]), Convert.ToDouble(row["lng"])));

                    //if (cantp == i)
                    //{
                    //    break;
                    //}

                    i++;
                }

                ///////////// linea une puntos

                GMapRoute PuntoRuta = new GMapRoute(puntos, "Ruta");
                overlayRutas.Routes.Add(PuntoRuta);

                //PuntoRuta.Stroke.Color = Color.Blue;
                PuntoRuta.Stroke.Color = Color.Transparent;



                double distance = PuntoRuta.Distance;

                distance = Math.Round(distance, 2);

                lblDistancia.Text = "dist = " + distance.ToString() + " Km";
                lblDistancia.Visible = true;

                ///////////

            //}
            //else
            //{
            //    quitarMarcadorRecorridos();
            //    quitarMarcadorRutas();

            //    lblDistancia.Text = "dist = 0 Km";
            //    lblDistancia.Visible = false;
            //}

            this.Cursor = Cursors.Default;

        }

        private void repartosBoton()
        {
            //if (txtCantP.Text.Equals("")) {
            //    txtCantP.Text = "0";
            //}

            //int cantp = Convert.ToInt32(txtCantP.Text);
            int i = 1;
            int opc;

            this.Cursor = Cursors.WaitCursor;

            //////////
            //GMapOverlay Ruta = new GMapOverlay("Rutas");
            List<PointLatLng> puntos = new List<PointLatLng>();
            /////////

            //if (datFecha.Visible)
            //{
            DataTable dt = new DataTable();

            //leerWsRecorrido(ref dt);
            //leerWsdlRecorrido(ref dt);
            leerWsdlRepartos(ref dt);


            dt.DefaultView.Sort = "hora asc";
            dt = dt.DefaultView.ToTable();

            DataRow[] rows = dt.Select("lat = '0.0000000000'");
            foreach (DataRow row in rows) dt.Rows.Remove(row);


            quitarMarcadorRecorridos();
            quitarMarcadorRutas();

            foreach (DataRow row in dt.Rows)
            {
                string corral = "";
                if (row["corral"].ToString() == row["corralgps"].ToString())
                {
                    corral = row["corralgps"].ToString();
                    opc = 3;
                }
                else
                {
                    corral = row["corralgps"].ToString() + " [" + row["corral"].ToString()+"]";
                    opc = 1;
                }
                
                if (row["corralgps"].ToString() == "0000") 
                {
                    opc = 2;
                }

                agregaractualizarMarcadorRepartos(
                    corral,
                    opc,
                    row["fecha"].ToString(),
                    row["hora"].ToString(),
                    Convert.ToDouble(row["lat"]),
                    Convert.ToDouble(row["lng"]));


                puntos.Add(new PointLatLng(Convert.ToDouble(row["lat"]), Convert.ToDouble(row["lng"])));

                //if (cantp == i)
                //{
                //    break;
                //}

                i++;
            }

            ///////////// linea une puntos

            GMapRoute PuntoRuta = new GMapRoute(puntos, "Ruta");
            overlayRutas.Routes.Add(PuntoRuta);

            //PuntoRuta.Stroke.Color = Color.Blue;
            PuntoRuta.Stroke.Color = Color.Transparent;



            double distance = PuntoRuta.Distance;

            distance = Math.Round(distance, 2);

            lblDistancia.Text = "dist = " + distance.ToString() + " Km";
            lblDistancia.Visible = true;

            ///////////

            //}
            //else
            //{
            //    quitarMarcadorRecorridos();
            //    quitarMarcadorRutas();

            //    lblDistancia.Text = "dist = 0 Km";
            //    lblDistancia.Visible = false;
            //}

            this.Cursor = Cursors.Default;

        }


        private void btnRecorridos_Click(object sender, EventArgs e)
        {


        }

        private void leerWsCamion(ref DataTable dt)
        {

            try
            {

                string url = "http://" + ip + "/gusi/engorda/gps/wsconsultarcamionesxml.php";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                //request.Timeout = 50;

                //request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream iDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(iDataStream);
                string eresponse = reader.ReadToEnd();

                string _xml = eresponse;
                var xdocument = XElement.Parse(_xml);

                var list = (from item in xdocument.Elements("marker")
                            select new
                            {
                                id = item.Attribute("id").Value,
                                name = item.Attribute("name").Value,
                                fecha = item.Attribute("fecha").Value,
                                hora = item.Attribute("hora").Value,
                                lat = item.Attribute("lat").Value,
                                lng = item.Attribute("lng").Value,
                                racion = item.Attribute("racion").Value,
                                carga = item.Attribute("carga").Value,
                                servida = item.Attribute("servida").Value,
                                type = item.Attribute("type").Value,

                                corral = item.Attribute("corral").Value,
                                plan = item.Attribute("plan").Value,
                                servido = item.Attribute("servido").Value,
                                falta = item.Attribute("falta").Value,
                                corrales = item.Attribute("corrales").Value,
                                velocidad = item.Attribute("velocidad").Value,
                                status = item.Attribute("status").Value,


                            }).ToList();




                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("id");
                dttmp.Columns.Add("name");
                dttmp.Columns.Add("fecha");
                dttmp.Columns.Add("hora");
                dttmp.Columns.Add("lat");
                dttmp.Columns.Add("lng");
                dttmp.Columns.Add("racion");
                dttmp.Columns.Add("carga");
                dttmp.Columns.Add("servida");
                dttmp.Columns.Add("type");

                dttmp.Columns.Add("corral");
                dttmp.Columns.Add("plan");
                dttmp.Columns.Add("servido");
                dttmp.Columns.Add("falta");
                dttmp.Columns.Add("corrales");
                dttmp.Columns.Add("velocidad");
                dttmp.Columns.Add("status");

                foreach (var item in list)
                {

                    DataRow newRow = dttmp.NewRow();
                    newRow["id"] = item.id;
                    newRow["name"] = item.name;
                    newRow["fecha"] = item.fecha;
                    newRow["hora"] = item.hora;
                    newRow["lat"] = item.lat;
                    newRow["lng"] = item.lng;
                    newRow["racion"] = item.racion;
                    newRow["carga"] = item.carga;
                    newRow["servida"] = item.servida;
                    newRow["type"] = item.type;

                    newRow["corral"] = item.corral;
                    newRow["plan"] = item.plan;
                    newRow["servido"] = item.servido;
                    newRow["falta"] = item.falta;
                    newRow["corrales"] = item.corrales;
                    newRow["velocidad"] = item.velocidad;
                    newRow["status"] = item.status;

                    dttmp.Rows.Add(newRow);

                }

                dt = dttmp;


                reader.Close();
                iDataStream.Close();
                response.Close();

            }
            catch (WebException)
            {

            }

        }

        private void leerWsLocalizaCamion(ref DataTable dt)
        {

            DateTime fecha = DateTime.Today;
            string fechastr = fecha.ToString("yyyy-MM-dd"); 

            try
            {

                string url = "http://" + ip + "/gusi/engorda/gps/wsconsultarlocalizacamionxml.php?fecha=" + fechastr;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                //request.Timeout = 50;

                //request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream iDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(iDataStream);
                string eresponse = reader.ReadToEnd();

                string _xml = eresponse;
                var xdocument = XElement.Parse(_xml);

                var list = (from item in xdocument.Elements("marker")
                            select new
                            {
                                id = item.Attribute("id").Value,
                                name = item.Attribute("name").Value,
                                fecha = item.Attribute("fecha").Value,
                                hora = item.Attribute("hora").Value,
                                lat = item.Attribute("lat").Value,
                                lng = item.Attribute("lng").Value,
                                velocidad = item.Attribute("velocidad").Value,


                            }).ToList();




                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("id");
                dttmp.Columns.Add("name");
                dttmp.Columns.Add("fecha");
                dttmp.Columns.Add("hora");
                dttmp.Columns.Add("lat");
                dttmp.Columns.Add("lng");
                dttmp.Columns.Add("velocidad");

                foreach (var item in list)
                {

                    DataRow newRow = dttmp.NewRow();
                    newRow["id"] = item.id;
                    newRow["name"] = item.name;
                    newRow["fecha"] = item.fecha;
                    newRow["hora"] = item.hora;
                    newRow["lat"] = item.lat;
                    newRow["lng"] = item.lng;
                    newRow["velocidad"] = item.velocidad;

                    dttmp.Rows.Add(newRow);

                }

                dt = dttmp;


                reader.Close();
                iDataStream.Close();
                response.Close();

            }
            catch (WebException)
            {

            }

        }

        private void leerWsdlUbicacion(ref DataTable dt)
        {

            //Cursor = Cursors.WaitCursor;

            seleccion = "ALMACENES";

            Thread t = new Thread(() => { cargarWSDLSel(seleccion, DateTime.Today, DateTime.Today); });
            t.Name = seleccion;
            t.IsBackground = true;
            t.Start();

            Console.WriteLine(t.Name + " " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString());
            //while (t.IsAlive)
            //{
            //    Thread.Sleep(50);//50
            //    Application.DoEvents();
            //}

            t.Join();

            lista = connectar.getList();
            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();

            if (!errormsg.Equals("")) { lblErrores.Text = errormsg; }


            try
            {

                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("corral");
                dttmp.Columns.Add("name");
                dttmp.Columns.Add("lat");
                dttmp.Columns.Add("lng");
                dttmp.Columns.Add("lat1");
                dttmp.Columns.Add("lng1");
                dttmp.Columns.Add("lat2");
                dttmp.Columns.Add("lng2");
                dttmp.Columns.Add("lat3");
                dttmp.Columns.Add("lng3");
                dttmp.Columns.Add("lat4");
                dttmp.Columns.Add("lng4");
                dttmp.Columns.Add("type");

                foreach (String listar in lista)
                {

                    string[] lines = listar.Split('|');

                    DataRow newRow = dttmp.NewRow();
                    newRow["corral"] = lines[0].Trim();
                    newRow["name"] = lines[0].Trim();
                    newRow["lat"] = lines[1].Trim();
                    newRow["lng"] = lines[2].Trim();
                    newRow["lat1"] = lines[3].Trim();
                    newRow["lng1"] = lines[4].Trim();
                    newRow["lat2"] = lines[5].Trim();
                    newRow["lng2"] = lines[6].Trim();
                    newRow["lat3"] = lines[7].Trim();
                    newRow["lng3"] = lines[8].Trim();
                    newRow["lat4"] = lines[9].Trim();
                    newRow["lng4"] = lines[10].Trim();
                    newRow["type"] = "";

                    dttmp.Rows.Add(newRow);

                }

                dt = dttmp;

            }
            catch (Exception e)
            {
                if (!errormsg.Equals("")) { lblErrores.Text = errormsg; }
            }

            //Cursor = Cursors.Default;

            //if (!errormsg.Equals("")) { MessageBox.Show(errormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }
          


        }

        private void leerWsdlLocalizaCamion(ref DataTable dt)
        {

            //Cursor = Cursors.WaitCursor;

            seleccion = "LOCALIZA";

            Thread t = new Thread(() => { cargarWSDLSel(seleccion, DateTime.Today, DateTime.Today); });
            t.Name = seleccion;
            t.IsBackground = true;
            t.Start();

            Console.WriteLine(t.Name + " " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString());
            //while (t.IsAlive)
            //{
            //    Thread.Sleep(50);//50
            //    Application.DoEvents();
            //}

            t.Join();

            lista = connectar.getList();
            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();
            String url = connectar.getUrl();


            string[] lurl = url.Split('/');
            string[] serverl = lurl[2].Trim().Split('.');
            lblServer.Text = serverl[0].Trim();

            lblMandante.Text = lurl[9].Trim();

            DataTable dttmp = new DataTable();
            dttmp.Columns.Add("numcamion");
            dttmp.Columns.Add("name");
            dttmp.Columns.Add("fecha");
            dttmp.Columns.Add("hora");
            dttmp.Columns.Add("lat");
            dttmp.Columns.Add("lng");
            dttmp.Columns.Add("Racion");
            dttmp.Columns.Add("Servida");


            foreach (String listar in lista)
            {

                string[] lines = listar.Split('|');

                DataRow newRow = dttmp.NewRow();
                newRow["numcamion"] = lines[0].Trim();
                newRow["name"] = "";

                lines[1] = lines[1].Insert(4, "-");
                lines[1] = lines[1].Insert(7, "-");
                newRow["fecha"] = lines[1].Trim();

                lines[2] = lines[2].Insert(2, ":");
                lines[2] = lines[2].Insert(5, ":");
                newRow["hora"] = lines[2].Trim();

                newRow["lat"] = lines[3].Trim();
                newRow["lng"] = lines[4].Trim();

                newRow["racion"] = lines[5].Trim();
                newRow["servida"] = lines[6].Trim();

                //if (newRow["numcamion"].Equals("3")||
                //    newRow["numcamion"].Equals("7")||
                //        newRow["numcamion"].Equals("9"))
                //{
                //    newRow["lng"] = "-"+newRow["lng"];
                //}



                dttmp.Rows.Add(newRow);

            }

            dt = dttmp;
             
            //Cursor = Cursors.Default;

            //if (!errormsg.Equals("")) { MessageBox.Show(errormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (!errormsg.Equals("")) { lblErrores.Text = errormsg; }


        }

        private void cargarWSDLSel(String catalogo, DateTime fechai, DateTime fechaf)
        {
            
            connectar = new ConnectedWs(Constants.OPERACION_CATALOGO, catalogo, usuario, contrasena, fechai.ToString("yyyy-MM-dd"), fechaf.ToString("yyyy-MM-dd"));
            connectar.getDataWs();
            
        }

        private void leerWsUbicacion(ref DataTable dt)
        {

            try
            {

                string url = "http://" + ip + "/gusi/engorda/gps/wsconsultarlistacorralesxml.php";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                //request.Timeout = 100;

                //request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream iDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(iDataStream);
                string eresponse = reader.ReadToEnd();

                string _xml = eresponse;
                var xdocument = XElement.Parse(_xml);

                var list = (from item in xdocument.Elements("marker")
                            select new
                            {
                                id = item.Attribute("id").Value,
                                name = item.Attribute("name").Value,
                                lat = item.Attribute("lat").Value,
                                lng = item.Attribute("lng").Value,
                                lat1 = item.Attribute("lat1").Value,
                                lng1 = item.Attribute("lng1").Value,
                                lat2 = item.Attribute("lat2").Value,
                                lng2 = item.Attribute("lng2").Value,
                                lat3 = item.Attribute("lat3").Value,
                                lng3 = item.Attribute("lng3").Value,
                                lat4 = item.Attribute("lat4").Value,
                                lng4 = item.Attribute("lng4").Value,
                                type = item.Attribute("type").Value,
                            }).ToList();




                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("id");
                dttmp.Columns.Add("name");
                dttmp.Columns.Add("lat");
                dttmp.Columns.Add("lng");
                dttmp.Columns.Add("lat1");
                dttmp.Columns.Add("lng1");
                dttmp.Columns.Add("lat2");
                dttmp.Columns.Add("lng2");
                dttmp.Columns.Add("lat3");
                dttmp.Columns.Add("lng3");
                dttmp.Columns.Add("lat4");
                dttmp.Columns.Add("lng4");
                dttmp.Columns.Add("type");

                foreach (var item in list)
                {

                    DataRow newRow = dttmp.NewRow();
                    newRow["id"] = item.id;
                    newRow["name"] = item.name;
                    newRow["lat"] = item.lat;
                    newRow["lng"] = item.lng;
                    newRow["lat1"] = item.lat1;
                    newRow["lng1"] = item.lng1;
                    newRow["lat2"] = item.lat2;
                    newRow["lng2"] = item.lng2;
                    newRow["lat3"] = item.lat3;
                    newRow["lng3"] = item.lng3;
                    newRow["lat4"] = item.lat4;
                    newRow["lng4"] = item.lng4;
                    newRow["type"] = item.type;

                    dttmp.Rows.Add(newRow);

                }

                dt = dttmp;


                reader.Close();
                iDataStream.Close();
                response.Close();

            }
            catch (WebException)
            {

            }



        }

        private string numCamion(string name)
        {

            string valor = "";

            foreach (DataRow row in dtCamiontmp.Rows)
            {

                if (name.Equals(row["name"].ToString()))
                {
                    valor = row["id"].ToString();
                }

            }

            return valor;

        }

        private string numListaCamion(string name)
        {

            string valor = "";

            foreach (DataRow row in dtListaCamiontmp.Rows)
            {

                if (name.Equals(row["name"].ToString()))
                {
                    valor = row["id"].ToString();
                }

            }

            return valor;

        }

        private string fechaConvertir(string vfecha)
        {
            // 10/02/2019 a 2019-02-10
            string resultado;

            if (!vfecha.Equals(""))
            {
                resultado = vfecha.Substring(6, 4) + "-" + vfecha.Substring(3, 2) + "-" + vfecha.Substring(0, 2);
            }
            else
            {
                resultado = "";
            }
            
            return resultado;
        }

        private string fechaConvertir2(string vfecha)
        {
            // 2019-02-10 a 10/02/2019
            string resultado;

            if (!vfecha.Equals(""))
            {
                resultado = vfecha.Substring(8, 2) + "/" + vfecha.Substring(5, 2) + "/" + vfecha.Substring(0, 4);
            }
            else
            {
                resultado = "";
            }

            return resultado;
        }

        private void leerWsdlRecorrido(ref DataTable dt)
        {

            //DataTable dttmp1 = new DataTable();
            //DataTable dttmp2 = new DataTable();
            //DataRow[] foundRows1;
            DataRow[] foundRows2;

            //Cursor = Cursors.WaitCursor;

            seleccion = "RECORRIDO";  

            Thread t = new Thread(() => { cargarWSDLSel(seleccion, DateTime.Today, DateTime.Today); });
            t.Name = seleccion;
            t.IsBackground = true;
            t.Start();

            Console.WriteLine(t.Name + " " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString());
            //while (t.IsAlive)
            //{
            //    Thread.Sleep(50);
            //    Application.DoEvents();
            //}

            t.Join();

            lista = connectar.getList();
            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();

            try
            {

                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("fecha");
                dttmp.Columns.Add("hora");
                dttmp.Columns.Add("numcamion");
                dttmp.Columns.Add("lat");
                dttmp.Columns.Add("lng");

                foreach (String listar in lista)
                {

                    string[] lines = listar.Split('|');

                    if (lines[2].Trim().Equals(cmbCamionRuta.Text) || cmbCamionRuta.Text.Equals(""))
                    {
                        DataRow newRow = dttmp.NewRow();

                        lines[0] = lines[0].Insert(4, "-");
                        lines[0] = lines[0].Insert(7, "-");
                        newRow["fecha"] = lines[0].Trim();

                        lines[1] = lines[1].Insert(2, ":");
                        lines[1] = lines[1].Insert(5, ":");
                        newRow["hora"] = lines[1].Trim();

                        newRow["numcamion"] = lines[2].Trim();
                        newRow["lat"] = lines[3].Trim();
                        newRow["lng"] = lines[4].Trim();

                        dttmp.Rows.Add(newRow);
                    }

                }

                dt = dttmp;

            }
            catch (Exception e)
            {
                dt.Clear();
            }
            //Cursor = Cursors.Default;

            //if (!errormsg.Equals("")) { MessageBox.Show(errormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //if (!errormsg.Equals("")) { lblErrores.Text = errormsg; }



        }

        private void leerWsdlRepartos(ref DataTable dt)
        {

            //DataTable dttmp1 = new DataTable();
            //DataTable dttmp2 = new DataTable();
            //DataRow[] foundRows1;
            DataRow[] foundRows2;

            //Cursor = Cursors.WaitCursor;

            seleccion = "REPARTOS";

            Thread t = new Thread(() => { cargarWSDLSel(seleccion, Convert.ToDateTime(txtFecha.Text), Convert.ToDateTime(txtFecha.Text)); });
            t.Name = seleccion;
            t.IsBackground = true;
            t.Start();

            Console.WriteLine(t.Name + " " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString());
            //while (t.IsAlive)
            //{
            //    Thread.Sleep(50);
            //    Application.DoEvents();
            //}

            t.Join();

            lista = connectar.getList();
            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();

            try
            {

                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("corral");
                dttmp.Columns.Add("fecha");
                dttmp.Columns.Add("hora");
                dttmp.Columns.Add("numcamion");
                dttmp.Columns.Add("servida");
                dttmp.Columns.Add("racion");
                dttmp.Columns.Add("plan");
                dttmp.Columns.Add("servido");
                dttmp.Columns.Add("plandia");
                dttmp.Columns.Add("servidodia");

                dttmp.Columns.Add("corralgps");
                dttmp.Columns.Add("lat");
                dttmp.Columns.Add("lng");

                foreach (String listar in lista)
                {

                    string[] lines = listar.Split('|');

                    if (lines[3].Trim().TrimStart('0').Equals(cmbCamion.Text.TrimStart('0')) || cmbCamion.Text.Equals(""))
                    {
                        if (lines[4].Trim().TrimStart('0').Equals(cmbServidas.Text.TrimStart('0')) || cmbServidas.Text.Equals(""))
                        {
                            if (lines[5].Trim().TrimStart('0').Equals(cmbRaciones.Text.TrimStart('0')) || cmbRaciones.Text.Equals(""))
                            {
                                DataRow newRow = dttmp.NewRow();
                                newRow["corral"] = lines[0].Trim();

                                lines[1] = lines[1].Insert(4, "-");
                                lines[1] = lines[1].Insert(7, "-");
                                newRow["fecha"] = lines[1].Trim();

                                lines[2] = lines[2].Insert(2, ":");
                                lines[2] = lines[2].Insert(5, ":");
                                newRow["hora"] = lines[2].Trim();

                                newRow["numcamion"] = lines[3].Trim().PadLeft(2, '0');
                                newRow["servida"] = lines[4].Trim();
                                newRow["racion"] = lines[5].Trim();
                                newRow["plan"] = lines[6].Trim();
                                newRow["servido"] = lines[7].Trim();
                                newRow["plandia"] = lines[8].Trim();
                                newRow["servidodia"] = lines[9].Trim();

                                newRow["corralgps"] = lines[10].Trim();
                                newRow["lat"] = lines[11].Trim();
                                newRow["lng"] = lines[12].Trim();

                                dttmp.Rows.Add(newRow);
                            }
                        
                        }
                    
                    }

                }

                dt = dttmp;

            }
            catch (Exception e)
            {
                dt.Clear();
            }
            //Cursor = Cursors.Default;

            //if (!errormsg.Equals("")) { MessageBox.Show(errormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //if (!errormsg.Equals("")) { lblErrores.Text = errormsg; }



        }

        private void leerWsdlSelRecorrido(ref DataTable dt)
        {

            DataTable dttmp1 = new DataTable();
            DataTable dttmp2 = new DataTable();
            DataRow[] foundRows1;
            DataRow[] foundRows2;
            
     
            try
            {

                //leerWsdlUbicacion(ref dttmp2);
                consultaUbicaciones(ref dttmp2);

            }
            finally {

                obtenerWsdlServidasSap(ref dttmp1);
                dttmp1.DefaultView.Sort = "numcamion, servida, hora ASC";
                foundRows1 = dttmp1.Select("numcamion='"+cmbCamionRuta.Text.Trim()+"'");

            }


            try
            {

                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("corral");
                dttmp.Columns.Add("fecha");
                dttmp.Columns.Add("hora");
                dttmp.Columns.Add("lat");
                dttmp.Columns.Add("lng");


                foreach (DataRow item in foundRows1)
                {

                    DataRow newRow = dttmp.NewRow();
                    newRow["corral"] = item["corral"].ToString();
                    newRow["fecha"] = item["fecha"].ToString();
                    newRow["hora"] = item["hora"].ToString();

                    foundRows2 = dttmp2.Select("corral='" + item["corral"].ToString() + "'");

                    if (foundRows2.Length > 0)
                    {
                        DataRow item1 = foundRows2[0];
                        newRow["lat"] = item1["lat"];
                        newRow["lng"] = item1["lng"];
                        dttmp.Rows.Add(newRow);
                    }

                }


                dt = dttmp;

            }
            catch (Exception e)
            {
                dt.Clear();

            }


        }

        private void leerWsRecorrido(ref DataTable dt)
        {

            //DateTime fecha = datFecha.Value;
            //string fechastr = fecha.ToString("yyyy-MM-dd");
            string fechastr = fechaConvertir(txtFecha.Text);


            string vcam = numListaCamion(cmbCamionRuta.Text);

            if (!vcam.Equals(""))
            {

                try
                {

                    string url = "http://" + ip + "/gusi/engorda/gps/wsconsultarrecorridosxml.php?fecha=" + fechastr + "&camion=" + vcam;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                    //request.Timeout = 50;

                    //request.Credentials = CredentialCache.DefaultCredentials;
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    Stream iDataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(iDataStream);
                    string eresponse = reader.ReadToEnd();

                    string _xml = eresponse;
                    var xdocument = XElement.Parse(_xml);

                    var list = (from item in xdocument.Elements("marker")
                                select new
                                {
                                    id = item.Attribute("id").Value,
                                    name = item.Attribute("name").Value,
                                    fecha = item.Attribute("fecha").Value,
                                    hora = item.Attribute("hora").Value,
                                    lat = item.Attribute("lat").Value,
                                    lng = item.Attribute("lng").Value,
                                    velocidad = item.Attribute("velocidad").Value,

                                }).ToList();




                    DataTable dttmp = new DataTable();
                    dttmp.Columns.Add("id");
                    dttmp.Columns.Add("name");
                    dttmp.Columns.Add("fecha");
                    dttmp.Columns.Add("hora");
                    dttmp.Columns.Add("lat");
                    dttmp.Columns.Add("lng");
                    dttmp.Columns.Add("velocidad");

                    foreach (var item in list)
                    {

                        DataRow newRow = dttmp.NewRow();
                        newRow["id"] = item.id;
                        newRow["name"] = item.name;
                        newRow["fecha"] = item.fecha;
                        newRow["hora"] = item.hora;
                        newRow["lat"] = item.lat;
                        newRow["lng"] = item.lng;
                        newRow["velocidad"] = item.velocidad;

                        dttmp.Rows.Add(newRow);

                    }

                    dt = dttmp;


                    reader.Close();
                    iDataStream.Close();
                    response.Close();

                }
                catch (WebException)
                {

                }

            }


        }

        private void coordenasPuntoMedio(double lat1, double lng1, double lat2, double lng2, double lat3, double lng3, double lat4, double lng4, ref double lat, ref double lng)
        {

            lat = (lat1 + lat3) / 2;
            lng = (lng1 + lng3) / 2;            

        }

        private void leerWsdlBuscarUbicacion(ref DataTable dt, string corral)
        {

            String name = "";
            String lat = "";
            String lng = "";

            double latitud = 0;
            double longitud = 0;

            foreach (var item in overlayCeldas.Polygons)
            {
                if (item.Name.Equals(corral))
                {
                   name = item.Name;
                   //lat = item.Points[0].Lat.ToString();
                   //lng = item.Points[0].Lng.ToString();

                    coordenasPuntoMedio(item.Points[0].Lat, item.Points[0].Lng, item.Points[1].Lat, item.Points[1].Lng, item.Points[2].Lat, item.Points[2].Lng, item.Points[3].Lat, item.Points[3].Lng, ref latitud, ref longitud);

                    lat = latitud.ToString();
                    lng = longitud.ToString();

                }
            }
                                 
            DataTable dttmp = new DataTable();
            dttmp.Columns.Add("id");
            dttmp.Columns.Add("name");
            dttmp.Columns.Add("lat");
            dttmp.Columns.Add("lng");

            if (!name.Equals(""))
            {
                DataRow newRow = dttmp.NewRow();
                newRow["id"] = name;
                newRow["name"] = "";
                newRow["lat"] = lat;
                newRow["lng"] = lng;

                dttmp.Rows.Add(newRow);
            }

            dt = dttmp;


        }

        private void leerWsBuscarUbicacion(ref DataTable dt, string corral)
        {

            try
            {

                string url = "http://" + ip + "/gusi/engorda/gps/wsconsultarbuscarubicacionxml.php?corral=" + corral;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                //request.Timeout = 100;

                //request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream iDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(iDataStream);
                string eresponse = reader.ReadToEnd();

                string _xml = eresponse;
                var xdocument = XElement.Parse(_xml);

                var list = (from item in xdocument.Elements("marker")
                            select new
                            {
                                id = item.Attribute("id").Value,
                                name = item.Attribute("name").Value,
                                lat = item.Attribute("lat").Value,
                                lng = item.Attribute("lng").Value,

                            }).ToList();




                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("id");
                dttmp.Columns.Add("name");
                dttmp.Columns.Add("lat");
                dttmp.Columns.Add("lng");

                foreach (var item in list)
                {

                    DataRow newRow = dttmp.NewRow();
                    newRow["id"] = item.id;
                    newRow["name"] = item.name;
                    newRow["lat"] = item.lat;
                    newRow["lng"] = item.lng;

                    dttmp.Rows.Add(newRow);

                }

                dt = dttmp;


                reader.Close();
                iDataStream.Close();
                response.Close();

            }
            catch (WebException)
            {

            }

        }

        private void leerWsdlListaCamion(ref DataTable dtsalida)
        {

            //Cursor = Cursors.WaitCursor;

            seleccion = "CAMIONES";

            Thread t = new Thread(() => { cargarWSDLSel(seleccion, DateTime.Today, DateTime.Today); });
            t.Name = seleccion;
            t.IsBackground = true;
            t.Start();

            Console.WriteLine(t.Name + " " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString());
            //while (t.IsAlive)
            //{
            //    Thread.Sleep(50);
            //    Application.DoEvents();
            //}

            t.Join();

            lista = connectar.getList();
            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();


            lista.Remove("  |");
            //lista.RemoveAt(0);

            DataTable dttmp = new DataTable();
            dttmp.Columns.Add("id");
            dttmp.Columns.Add("name");
            dttmp.Columns.Add("type");
            
            foreach (String listar in lista)
            {

                string[] lines = listar.Split('|');

                DataRow newRow = dttmp.NewRow();
                newRow["id"] = lines[0].Trim().PadLeft(2, '0');
                newRow["name"] = lines[1].Trim();
                newRow["type"] = "";

                dttmp.Rows.Add(newRow);

            }

            dtsalida = dttmp;

            //Cursor = Cursors.Default;

            //if (!errormsg.Equals("")) { MessageBox.Show(errormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (!errormsg.Equals("")) { lblErrores.Text = errormsg; }


        }

        private void leerWsListaCamion(ref DataTable dt)
        {

            try
            {

                string url = "http://" + ip + "/gusi/engorda/gps/wsconsultarlistacamionesxml.php";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                //request.Timeout = 100;

                //request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream iDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(iDataStream);
                string eresponse = reader.ReadToEnd();

                string _xml = eresponse;
                var xdocument = XElement.Parse(_xml);

                var list = (from item in xdocument.Elements("marker")
                            select new
                            {
                                id = item.Attribute("id").Value,
                                name = item.Attribute("name").Value,
                                type = item.Attribute("type").Value,

                            }).ToList();




                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("id");
                dttmp.Columns.Add("name");
                dttmp.Columns.Add("type");

                foreach (var item in list)
                {

                    DataRow newRow = dttmp.NewRow();
                    newRow["id"] = item.id;
                    newRow["name"] = item.name;
                    newRow["type"] = item.type;

                    dttmp.Rows.Add(newRow);

                }

                dt = dttmp;


                reader.Close();
                iDataStream.Close();
                response.Close();

            }
            catch (WebException)
            {

            }

        }

        private void editarUbicacion(string corral, ref double lat, ref double lng)
        {

            //envio coordenadas
            try
            {

                string url = "http://" + ip + "/gusi/engorda/gps/wseditarubicacioncorral.php?corral=" + corral + "&latitud=" + lat + "&longitud=" + lng;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

                req.Method = "POST";
                string Data = "message=";// + keys;
                byte[] postBytes = Encoding.ASCII.GetBytes(Data);
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = postBytes.Length;

                req.Timeout = 10;

                Stream requestStream = req.GetRequestStream();
                requestStream.Write(postBytes, 0, postBytes.Length);
                requestStream.Close();

                /*
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                Stream resStream = response.GetResponseStream();

                var sr = new StreamReader(response.GetResponseStream());
                string responseText = sr.ReadToEnd();
                */

            }
            catch (WebException)
            {
                //MessageBox.Show("Please Check Your Internet Connection");
            }

        }

        private void btnRotarIzq_Click(object sender, EventArgs e)
        {
            gMapControl1.Bearing += 90;//10;
            lblGiro.Text = gMapControl1.Bearing.ToString();
            //lblGirar.Text = gMapControl1.Bearing.ToString();

            switch (gorientacion) 
            {
                case 0:
                    gorientacion = 1;
                    break;
                case 1:
                    gorientacion = 2;
                    break;
                case 2:
                    gorientacion = 3;
                    break;
                case 3:
                    gorientacion = 0;
                    break;

            }

            nombresCorral();
            //corralesActividadNombre();
            //lblErrores.Text = gorientacion.ToString();



        }

        private void btnRotarDer_Click(object sender, EventArgs e)
        {
            gMapControl1.Bearing -= 10;
            lblGiro.Text = gMapControl1.Bearing.ToString();
            //gMapControl1.Bearing -= -50; //-140

            //if (gMapControl1.Bearing)
            //{

            //}

            //lblGirar.Text = gMapControl1.Bearing.ToString() + " " + trackBar1.Value.ToString();

        }

        private void ubicacionCamion()
        {

            foreach (DataRow row in vdt.Rows)
            {
                if (cmbCamionRuta.SelectedItem != null)
                {
                    if (cmbCamionRuta.SelectedItem.ToString().Equals(cerosIzq(row["numcamion"].ToString()))) //"name"
                    {

                        if (row["fecha"].ToString().Equals(DateTime.Now.ToString("yyyy-MM-dd")))
                        {

                            gMapControl1.Position = new PointLatLng(Convert.ToDouble(row["lat"]), Convert.ToDouble(row["lng"]));

                        }

                    }
                }

            }

            //foreach (DataRow row in vdt.Rows)
            //{
            //    if (cmbCamiones.SelectedItem != null)
            //    {
            //        if (cmbCamiones.SelectedItem.ToString().Equals(row["id"].ToString())) //"name"
            //        {
            //            gMapControl1.Position = new PointLatLng(Convert.ToDouble(row["lat"]), Convert.ToDouble(row["lng"]));

            //        }
            //    }

            //}


        }

        private string cerosIzq(string valor) {
            
            int len = 2 - valor.Length;

            for (int i = 1; i<=len; i++) {
                valor = "0" + valor;
            }
            
            return valor;

        }

        private void datFecha_ValueChanged(object sender, EventArgs e)
        {
            //recorridoBoton();
        }

        private void gMapControl1_KeyDown(object sender, KeyEventArgs e)
        {


            if (Form.ModifierKeys == Keys.Control)
            {
                ActivoCtrl = true;
                lblCtrl.Text = "CTRL";

            }


        }

        private void gMapControl1_KeyUp(object sender, KeyEventArgs e)
        {
            

            ActivoCtrl = false;
            lblCtrl.Text = "";
            marcas = 0;
            overlayDrags.Markers.Clear();



        }

        private void gMapControl1_MouseMove(object sender, MouseEventArgs e)
        {

            base.OnMouseMove(e);

            double lat = Math.Round(gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat, 10);//6);
            double lng = Math.Round(gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng, 10);//6);
                       
            //lblCoordenadas.Text = "lat= " + Convert.ToString(lat) + "   long= " + Convert.ToString(lng);
            lblCoordenadas.Text = Convert.ToString(lat) + "," + Convert.ToString(lng);

            LatActual = lat;
            LngActual = lng;


            //centrocorarl
            lblCorral.Text = corralUbicacion(dtUbictmp, lat, lng, gmindist);
            //ladocorral
            //lblCorral.Text = corralUbicacionm(dtUbictmp, lat, lng, gmindist);

            //overlayCircles.Polygons.Clear();
            //CreateCircle(new PointLatLng(lat, lng), 0.0002, 30);

            /*
            txtDistancia.Text = e.X.ToString() + "-" + e.Y.ToString();
            */

            //if (ActivoCtrl)
            //{

            /*
            lv_pos = lv_pos + 1;

            if (lv_pos == 2)
            {
                lv_pos = 0;
            }

            posMouseX[lv_pos] = e.X.ToString();
            posMouseY[lv_pos] = e.Y.ToString();

            lblpos.Text = e.X.ToString() + "-" + e.Y.ToString() + posMouseX[0].ToString() + " " + posMouseX[1].ToString();

            //estable[0] == estable[1]

            if (Convert.ToInt32(posMouseX[0].ToString()) < Convert.ToInt32(posMouseX[1].ToString()) && Convert.ToInt32(posMouseY[0].ToString()) < Convert.ToInt32(posMouseY[1].ToString()))
            {
                gMapControl1.Bearing -= 1;
            }
            else
            {
                gMapControl1.Bearing += 1;
            }

            */


            //}


            switch (e.Button)
            {
                case MouseButtons.Right:
                    {

                    }
                    break;
            }



        }

        private void toolStripMenuItemCopiar_Click(object sender, EventArgs e)
        {           


            Clipboard.SetText(lblCoordenadas.Text); //To copy your text to your clipboard
            Clipboard.GetText(); //To get your text from your clipboard
        }

        private void btnBuscarUbicacion_Click(object sender, EventArgs e)
        {

           



        }

        private void buscarBoton()
        {

            this.Cursor = Cursors.WaitCursor;

            double vLatInicial = 0;
            double vLngInicial = 0;

            DataTable dt = new DataTable();

            //leerWsBuscarUbicacion(ref dt, txtBuscarUbicacion.Text);
            leerWsdlBuscarUbicacion(ref dt, txtBuscarUbicacion.Text);

            //quitarMarcadorBuscarUbicaciones();

            foreach (DataRow row in dt.Rows)
            {

                agregaractualizarMarcadorBuscarUbicacion(
                row["id"].ToString(),
                row["name"].ToString(),
                Convert.ToDouble(row["lat"]),
                Convert.ToDouble(row["lng"]));


                vLatInicial = Convert.ToDouble(row["lat"]);
                vLngInicial = Convert.ToDouble(row["lng"]);

            }

            this.Cursor = Cursors.Default;

            if (vLatInicial != 0 && vLngInicial != 0)
            {

                gMapControl1.Position = new PointLatLng(vLatInicial, vLngInicial);
                //gMapControl1.Zoom = 19;
            }

        }


        private void Form1_Resize(object sender, System.EventArgs e)
        {


            toolStrip1.Refresh();
            toolStrip2.Refresh();
            btnRotarDer.Refresh();
            btnRotarIzq.Refresh();
            panelTrack.Refresh();
            trackBar1.Refresh();

            posicionBTN();

        }

        private void satelitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
            toolStripSplitButton1.Text = satelitalToolStripMenuItem.Text;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            toolStripSplitButton1.Text = toolStripMenuItem1.Text;
        }

        private void relieveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;
            toolStripSplitButton1.Text = relieveToolStripMenuItem.Text;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            botonUbicaciones();
        }
        /*
        private void empacadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double LatInicial = 21.911191;
            double LngInicial = -98.738904;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);

            toolStripSplitButton2.Text = empacadoraToolStripMenuItem.Text;

        }
        */
        private void corralesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            vistaCorrales();
            toolStripSplitButton2.Text = corralesToolStripMenuItem.Text;
            gorientacion = 1;
            //lblErrores.Text = gorientacion.ToString();
            //corralesActividadNombre();
            nombresCorral();
        }

        private void vistaCorrales()
        {

            double LatInicial = 21.923121;
            double LngInicial = -98.745482;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);

            gMapControl1.Bearing = -50;//-140;
            gMapControl1.Zoom = 17;
            trackBar1.Value = Convert.ToInt32(gMapControl1.Zoom);

            //ubicActivo = false;
            //botonUbicaciones();

            //trackBar1.Visible = true;
            //btnRotarDer.Visible = true;
            //btnRotarIzq.Visible = true;

            trackBar1.Value = (int)gMapControl1.Zoom; // 17;
            //timerMonitor.Enabled = true;

        }

        private void ecologicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double LatInicial = 21.896245;
            double LngInicial = -98.738959;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);

            gMapControl1.Bearing = -140;//-50;
            gMapControl1.Zoom = 17;
            trackBar1.Value = Convert.ToInt32(gMapControl1.Zoom);

            //trackBar1.Visible = true;
            //btnRotarDer.Visible = true;
            //btnRotarIzq.Visible = true;

            //ubicActivo = false;
            //botonUbicaciones();

            trackBar1.Value = (int)gMapControl1.Zoom; //17;
            //timerMonitor.Enabled = false;

            toolStripSplitButton2.Text = ecologicosToolStripMenuItem.Text;

            gorientacion = 0;
            //lblErrores.Text = gorientacion.ToString();
            //corralesActividadNombre();

            nombresCorral();

        }

        private void txtBuscarUbicacion_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            buscarBoton();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            /*
            datFecha.Visible = !datFecha.Visible;
            cmbCamionRuta.Visible = datFecha.Visible;
            */

            //panelRuta.Visible = true;// !panelRuta.Visible;

            /*
            if (!datFecha.Visible)
            {
                quitarMarcadorRecorridos();
                quitarMarcadorRutas();
                recActivo = false;
            }
            */
            //recorridoBoton();

            //datFecha.Value = DateTime.Now;

            toolStripButton3.CheckState = CheckState.Checked;

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBClima.Visible = !webBClima.Visible;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

            double LatInicial = 21.919538;
            double LngInicial = -98.747370;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);

            //gMapControl1.MapProvider = GMapProviders.GoogleMap;

            gMapControl1.Bearing = -140;
            gMapControl1.Zoom = 17;

            ubicActivo = false;
            botonUbicaciones();

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            ubicacionCamion();
        }

        private void empacadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double LatInicial = 21.911191;
            double LngInicial = -98.738904;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.Zoom = 18;
            gMapControl1.Bearing = -50;

            //trackBar1.Visible = true;
            //btnRotarDer.Visible = true;
            //btnRotarIzq.Visible = true;

            //ubicActivo = true;
            //botonUbicaciones();
            trackBar1.Value = (int)gMapControl1.Zoom; // 18;
            //timerMonitor.Enabled = false;

            toolStripSplitButton2.Text = empacadoraToolStripMenuItem.Text;
            gorientacion = 0;
            //lblErrores.Text = gorientacion.ToString();
            corralesActividadNombre();

        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom += 1;
        }

        private void zoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom -= 1;
        }
         

        private void moverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panelFlechas.Visible = true;
        }
        

        private void coordenadaUbicacion(string corral, ref double lat, ref double lng)
        {

            lat = 0;
            lng = 0;

            DataTable dt = new DataTable();

            leerWsBuscarUbicacion(ref dt, corral);

            foreach (DataRow row in dt.Rows)
            {

                lat = Convert.ToDouble(row["lat"]);
                lng = Convert.ToDouble(row["lng"]);

            }

        }

        //private void moverUbicacion(int direccion)
        //{

        //    if (!txtCorralMover.Text.Equals(""))
        //    {

        //        double vlat = 0;
        //        double vlng = 0;

        //        coordenadaUbicacion(txtCorralMover.Text, ref vlat, ref vlng);

        //        switch (direccion)
        //        {
        //            case 1://arriba
        //                vlat += 0.000010; //85

        //                break;
        //            case 2://abajo
        //                vlat -= 0.000010;

        //                break;
        //            case 3://izq
        //                vlng += 0.000010; //70

        //                break;
        //            case 4://der
        //                vlng -= 0.000010;

        //                break;
        //            default:
        //                break;
        //        }

        //        //editarUbicacion(txtCorralMover.Text, ref vlat, ref vlng);

        //        ubicActivo = false;
        //        botonUbicaciones();

        //    }

        //}

        private string obtenerConfig(int indice)
        {

            string rutaorigen = "";
            string valor = "";

            rutaorigen = Application.StartupPath + "\\Config.txt";

            try
            {

                StreamReader objReader = new StreamReader(rutaorigen);
                string sLine = "";

                sLine = objReader.ReadLine();

                string[] lines = sLine.Split('|');


                valor = lines[indice].Trim();

                objReader.Close();

                //MessageBox.Show("Listo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch (Exception)
            {
                //MessageBox.Show("El archivo no se puede leer");
            }

            return valor;

        }

        

        private void btnMostrarRuta_Click(object sender, EventArgs e)
        {
            recorridoBoton();
        }

        private void btnCerrarRuta_Click(object sender, EventArgs e)
        {
            quitarRecorrido();
        }

        private void quitarRecorrido()
        {

            //panelRuta.Visible = false;
            lblDistancia.Visible = false;

            quitarMarcadorRecorridos();
            quitarMarcadorRutas();

            toolStripButton3.CheckState = CheckState.Unchecked;

        }

        private void txtCantP_TextChanged(object sender, EventArgs e)
        {

        }

        private class GmapMarkerWithLabel
        {
            private object centerPoint;
            private object zoneName;
            private GMarkerGoogleType blue;

            public GmapMarkerWithLabel(object centerPoint, object zoneName, GMarkerGoogleType blue)
            {
                this.centerPoint = centerPoint;
                this.zoneName = zoneName;
                this.blue = blue;
            }
        }

        private void marcadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void marcadorCelda(string valor)
        {
            
            //overlayDrags.Markers.Clear();
            markerDrag = new GMarkerGoogle(new PointLatLng(LatActual, LngActual), GMarkerGoogleType.red);
            markerDrag.ToolTipMode = MarkerTooltipMode.Always;
            markerDrag.ToolTipText = valor;
                        
            overlayDrags.Markers.Add(markerDrag);
            
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            botonCeldas();
            mostrarDatos(tab);
        }

        //private void txtCantP_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        //}
                                      
        private void mostrarRepartoCorral()
        {

            string[] valores = { "VACIO", "0 - 20%", "20 - 40%", "40 - 75%", "75 - 95%", "95 - 105%", "EXCEDIO"  };//, "ERROR" };

            listBoxLeyendas.Items.Clear();

            for (int i=0;i<valores.Length;i++)
            {
                listBoxLeyendas.Items.Add(valores[i]);
            }

            //dataGridVista.Rows.Clear();
            llenarColores(true);
            llenaGridValores(true);
            
            try
            {

                DataTable dt = new DataTable();

                obtenerWsdlServidasSap(ref dt);

                corralActividadInicio();

                corralesActividadNombre();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        double valor = Convert.ToDouble(row["servidodia"]) / Convert.ToDouble(row["plandia"]) * 100;
                        //valor = -1;
                        corralActividadMod(row["corral"].ToString(), colorLeyenda(valor));

                        if (txtFecha.Text.Equals(DateTime.Now.ToString("dd/MM/yyyy")))
                        {
                            if (row["corral"].ToString() != row["corralgps"].ToString()
                                && row["corralgps"].ToString() != "0000"
                                && (
                                   row["numcamion"].ToString() == "05"
                                || row["numcamion"].ToString() == "03"
                                || row["numcamion"].ToString() == "12"
                                || row["numcamion"].ToString() == "01"
                                || row["numcamion"].ToString() == "02"
                                )
                                )
                            {
                                corralActividadMod(row["corral"].ToString(), Color.Red);
                            }
                        }

                    }
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrores.Text = "Reparto, " + e.Message;
            }

        }

        private void llenarCabezasCorral() 
        {

            dtCabezastmp.Rows.Clear();
            obtenerWsdlCabezasSap(ref dtCabezastmp);
            
            
        }

        private void mostrarCabezasCorral() 
        {

            //this.Cursor = Cursors.WaitCursor;
            
            try
            {

                //DataTable dt = new DataTable();

                obtenerWsdlCabezasSap(ref dtCabezastmp);

                corralActividadInicio();
                
                corralesActividadNombres(ref dtCabezastmp);

                //if (dt.Rows.Count > 0)
                //{
                //    foreach (DataRow row in dt.Rows)
                //    {
                //        int valor = Convert.ToInt32(row["cabezas"]);
               
                //        //corralActividadMod(row["corral"].ToString(), colorLeyenda(valor));
                //    }
                //}

            }
            catch (Exception e)
            {
                lblErrores.Text = "Cabezas, " + e.Message;
            }

            //this.Cursor = Cursors.Default;

        }

        private Image numeroImagen(Image imagen, string id) 
        {

            Bitmap bmpmarker = new Bitmap(imagen);

            SolidBrush drawBrush = new SolidBrush(Color.Black); //color numero 

            Graphics graphicImage = Graphics.FromImage(bmpmarker);
            graphicImage.SmoothingMode = SmoothingMode.AntiAlias;
            Point punto = new Point(2, 6);
            graphicImage.DrawString(id, new Font("Arial", 11, FontStyle.Bold), drawBrush, punto);
            graphicImage.Dispose();


            return bmpmarker;

        }

        private void mostrarCamionActivo(String camion, Boolean estado) 
        {


            try
            {

                Image imagen;

                if (estado)
                {
                    imagen = imageList1.Images[2];
                }
                else 
                {
                    imagen = imageList1.Images[0];
                }

                camion = cerosIzq(camion);
                
                switch (camion)
                {
                    case "01":
                        picCam01.Image = numeroImagen(imagen, camion);
                        break;
                    case "02":
                        picCam02.Image = numeroImagen(imagen, camion);
                        break;
                    case "03":
                        picCam03.Image = numeroImagen(imagen, camion);
                        break;
                    case "04":
                        picCam04.Image = numeroImagen(imagen, camion);
                        break;
                    case "05":
                        picCam05.Image = numeroImagen(imagen, camion);
                        break;
                    case "06":
                        picCam06.Image = numeroImagen(imagen, camion);
                        break;
                    case "07":
                        picCam07.Image = numeroImagen(imagen, camion);
                        break;
                    case "08":
                        picCam08.Image = numeroImagen(imagen, camion);
                        break;
                    case "09":
                        picCam09.Image = numeroImagen(imagen, camion);
                        break;
                    case "10":
                        picCam10.Image = numeroImagen(imagen, camion);
                        break;
                    case "11":
                        picCam11.Image = numeroImagen(imagen, camion);
                        break;
                    case "12":
                        picCam12.Image = numeroImagen(imagen, camion);
                        break;
                    case "13":
                        picCam13.Image = numeroImagen(imagen, camion);
                        break;
                    case "14":
                        picCam14.Image = numeroImagen(imagen, camion);
                        break;
                    case "15":
                        picCam15.Image = numeroImagen(imagen, camion);
                        break;
                }

            }
            catch { }

        }

        private void iniciaNumeroCamion() 
        {

            picCam01.Image = numeroImagen(imageList1.Images[2], "01");
            picCam02.Image = numeroImagen(imageList1.Images[2], "02");
            picCam03.Image = numeroImagen(imageList1.Images[2], "03");
            picCam04.Image = numeroImagen(imageList1.Images[2], "04");
            picCam05.Image = numeroImagen(imageList1.Images[2], "05");
            picCam06.Image = numeroImagen(imageList1.Images[2], "06");
            picCam07.Image = numeroImagen(imageList1.Images[2], "07");
            picCam08.Image = numeroImagen(imageList1.Images[2], "08");
            picCam09.Image = numeroImagen(imageList1.Images[2], "09");
            picCam10.Image = numeroImagen(imageList1.Images[2], "10");
            picCam11.Image = numeroImagen(imageList1.Images[2], "11");
            picCam12.Image = numeroImagen(imageList1.Images[2], "12");
            picCam13.Image = numeroImagen(imageList1.Images[2], "13");
            picCam14.Image = numeroImagen(imageList1.Images[2], "14");
            picCam15.Image = numeroImagen(imageList1.Images[2], "15");

        }

        private void mostrarCamionesActivos() 
        {

            try
            {
                //this.Cursor = Cursors.WaitCursor;

                ArrayList camiones = new ArrayList();

                picCam01.Image = numeroImagen(imageList1.Images[2], "01");
                picCam02.Image = numeroImagen(imageList1.Images[2], "02");
                picCam03.Image = numeroImagen(imageList1.Images[2], "03");
                picCam04.Image = numeroImagen(imageList1.Images[2], "04");
                picCam05.Image = numeroImagen(imageList1.Images[2], "05");
                picCam06.Image = numeroImagen(imageList1.Images[2], "06");
                picCam07.Image = numeroImagen(imageList1.Images[2], "07");
                picCam08.Image = numeroImagen(imageList1.Images[2], "08");
                picCam09.Image = numeroImagen(imageList1.Images[2], "09");
                picCam10.Image = numeroImagen(imageList1.Images[2], "10");
                picCam11.Image = numeroImagen(imageList1.Images[2], "11");
                picCam12.Image = numeroImagen(imageList1.Images[2], "12");
                picCam13.Image = numeroImagen(imageList1.Images[2], "13");
                picCam14.Image = numeroImagen(imageList1.Images[2], "14");
                picCam15.Image = numeroImagen(imageList1.Images[2], "15");


                camiones = camionesActivos("numcamion");

                if (camiones != null)
                {

                    foreach (String camion in camiones)
                    {

                        switch (camion)
                        {
                            case "01":
                                picCam01.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "02":
                                picCam02.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "03":
                                picCam03.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "04":
                                picCam04.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "05":
                                picCam05.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "06":
                                picCam06.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "07":
                                picCam07.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "08":
                                picCam08.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "09":
                                picCam09.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "10":
                                picCam10.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "11":
                                picCam11.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "12":
                                picCam12.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "13":
                                picCam13.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "14":
                                picCam14.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "15":
                                picCam15.Image = numeroImagen(imageList1.Images[0], camion);
                                break;


                                //default:

                                //    if (camion.Equals("01")) picCam01.Image = numeroImagen(imageList1.Images[2], camion);
                                //    if (camion.Equals("02")) picCam02.Image = numeroImagen(imageList1.Images[2], camion);
                                //    if (camion.Equals("03")) picCam03.Image = numeroImagen(imageList1.Images[2], camion);
                                //    if (camion.Equals("04")) picCam04.Image = numeroImagen(imageList1.Images[2], camion);
                                //    if (camion.Equals("05")) picCam05.Image = numeroImagen(imageList1.Images[2], camion);
                                //    if (camion.Equals("06")) picCam06.Image = numeroImagen(imageList1.Images[2], camion);
                                //    if (camion.Equals("07")) picCam07.Image = numeroImagen(imageList1.Images[2], camion);
                                //    if (camion.Equals("08")) picCam08.Image = numeroImagen(imageList1.Images[2], camion);
                                //    if (camion.Equals("09")) picCam09.Image = numeroImagen(imageList1.Images[2], camion);
                                //    if (camion.Equals("10")) picCam10.Image = numeroImagen(imageList1.Images[2], camion);
                                //    if (camion.Equals("11")) picCam11.Image = numeroImagen(imageList1.Images[2], camion);
                                //    if (camion.Equals("12")) picCam12.Image = numeroImagen(imageList1.Images[2], camion);
                                //    if (camion.Equals("13")) picCam13.Image = numeroImagen(imageList1.Images[2], camion);
                                //    if (camion.Equals("14")) picCam14.Image = numeroImagen(imageList1.Images[2], camion);
                                //    if (camion.Equals("15")) picCam15.Image = numeroImagen(imageList1.Images[2], camion);

                                //    break;

                        }


                    }

                }

                //this.Cursor = Cursors.Default;

            }
            catch { }

        }

        private ArrayList camionesActivos(String columna) 
        {

     
            ArrayList camiones = new ArrayList();


            camiones.Clear();
            
            
            try
            {

                DataTable dt = new DataTable();

                obtenerWsdlServidasSap(ref dt);


                if (dt.Rows.Count > 0)
                {

                    dt.DefaultView.Sort = columna + " asc";
                    dt = dt.DefaultView.ToTable();

                    //if (cmbFiltroVista.Items.Count > 0 && !cmbFiltroVista.Text.Equals(vtodos))
                    //{
                    //    dt.DefaultView.RowFilter = columna + " = '" + cmbFiltroVista.Text + "'";
                    //    dt = dt.DefaultView.ToTable();
                    //    //vfiltro = true;
                    //}

                    foreach (DataRow row in dt.Rows)
                    {

                        String valor = row[columna].ToString();

                        if (!camiones.Contains(valor))
                        {

                            camiones.Add(valor);

                            //listBoxLey endas.Items.Add(valor);

                            //vcolor = Color.White;

                            //if (indexcolor < cont) { vcolor = colores[indexcolor]; }

                            //indexcolor++;

                        }

                        //if (vfiltro) { vcolor = Color.Green; }

                        //corralActividadMod(row["corral"].ToString(), vcolor);

                    }

                    return camiones;


                }


            }
            catch { }


            //this.Cursor = Cursors.Default;

            return null;

        }

        private void mostrarReparto(String columna)
        {

            Boolean vfiltro = false;

            this.Cursor = Cursors.WaitCursor;

            try
            {

                llenarColores(false);

                int cont = 0;

                foreach (Color clr in colores) { cont++; }                

                int indexcolor = 0;
                Color vcolor = Color.White;

                DataTable dt = new DataTable();

                //dataGridVista.Rows.Clear();

                obtenerWsdlServidasSap(ref dt);

                corralActividadInicio();

                corralesActividadNombre();

                listBoxLeyendas.Items.Clear();
                //dataGridVista.Rows.Clear();

                if (dt.Rows.Count > 0)
                {
                    
                    dt.DefaultView.Sort = columna + " asc";
                    dt = dt.DefaultView.ToTable();
                    
                    if (cmbFiltroVista.Items.Count>0 && !cmbFiltroVista.Text.Equals(vtodos)) 
                    {
                        dt.DefaultView.RowFilter = columna + " = '" + cmbFiltroVista.Text + "'";
                        dt = dt.DefaultView.ToTable();
                        vfiltro = true;
                    }
                    
                    foreach (DataRow row in dt.Rows)
                    {

                        String valor = row[columna].ToString();

                        if (!listBoxLeyendas.Items.Contains(valor))
                        {
 
                            listBoxLeyendas.Items.Add(valor);

                            vcolor = Color.White;

                            if (indexcolor < cont) { vcolor = colores[indexcolor]; }

                            indexcolor++;

                        }

                        if (vfiltro) { vcolor = Color.Green; }

                        corralActividadMod(row["corral"].ToString(), vcolor);
                        
                    }
                    

                }

                llenaGridValores(!vfiltro);

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrores.Text = e.Message;
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;

        }
                     
        private void llenaGridValores(Boolean concolor)
        {                

            DataTable dtUbictmp = new DataTable();

            dtUbictmp.Columns.Add("valor");
            dtUbictmp.Columns.Add("color");

            for (int i=0;i<listBoxLeyendas.Items.Count; i++)
            {

                //if (!listBoxLeyendas.Items[i].ToString().Equals("00"))
                //{
                    DataRow newRow = dtUbictmp.NewRow();

                    newRow["valor"] = listBoxLeyendas.Items[i].ToString();
                    dtUbictmp.Rows.Add(newRow);
                //}

            }

            dataGridVista.DataSource = dtUbictmp;
            formatoubicacionesGrid();

            if (concolor)
            {

                int count = 0;

                foreach (DataGridViewRow row in dataGridVista.Rows)
                {

                    dataGridVista[1, count].Style.BackColor = colores[count];
                    count++;
                }

            }

        }

        private void formatoubicacionesGrid()
        {            

            for (int i = 0; i < dataGridVista.Columns.Count; i++)
            {
                dataGridVista.Columns[i].Width = dataGridVista.Width / 2;//50;
                dataGridVista.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;                    
                dataGridVista.Columns[i].HeaderCell.Style.Font = new Font("Tahoma", 15.00F, FontStyle.Bold);
                dataGridVista.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridVista.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            
            dataGridVista.Columns[0].HeaderText = "Valor";
            dataGridVista.Columns[1].HeaderText = "Color";
            
        }

        private void colorCont()
        {

            //    if (overlayCeldas.Polygons.ElementAt(i).Fill.Equals(Color.White)) { contblanco = contblanco + 1; }
            //    if (overlayCeldas.Polygons.ElementAt(i).Fill.Equals(Color.Gray)) { contgris = contgris + 1; }
            //    if (overlayCeldas.Polygons.ElementAt(i).Fill.Equals(Color.Orange)) { contnaranja = contnaranja + 1; }
            //    if (overlayCeldas.Polygons.ElementAt(i).Fill.Equals(Color.Yellow)) { contamarillo = contamarillo + 1; }
            //    if (overlayCeldas.Polygons.ElementAt(i).Fill.Equals(Color.Blue)) { contazul = contazul + 1; }
            //    if (overlayCeldas.Polygons.ElementAt(i).Fill.Equals(Color.Green)) { contverde = contverde + 1; }
            //    if (overlayCeldas.Polygons.ElementAt(i).Fill.Equals(Color.Purple)) { contpurpura = contpurpura + 1; }
            //    if (overlayCeldas.Polygons.ElementAt(i).Fill.Equals(Color.Red)) { controjo = controjo + 1; }

        }

        private Color colorLeyenda(double valor)
        {

            Color color = Color.White;

            if (valor == -1) { color = Color.Transparent; }
            if (valor == 0) { color = Color.White; }
            if (valor > 0 && valor <= 20) { color = Color.Silver; }
            if (valor > 20 && valor <= 40) { color = Color.Orange; }
            if (valor > 40 && valor <= 75) { color = Color.Yellow; }
            if (valor > 75 && valor <= 95) { color = Color.Cyan; }
            if (valor > 95 && valor <= 105) { color = Color.LimeGreen; }
            if (valor >= 105) { color = Color.DarkViolet; }

            return color;

        }

        private void leerWsRepartoCorral(ref DataTable dt)
        {

            DateTime fecha = DateTime.Today;
            string fechastr = fecha.ToString("yyyy-MM-dd"); 

            try
            {

                string url = "http://" + ip + "/gusi/engorda/gps/wsconsultarrepartocorralxml.php?fecha=" + fechastr;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                request.Timeout = 50;

                //request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream iDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(iDataStream);
                string eresponse = reader.ReadToEnd();

                string _xml = eresponse;
                var xdocument = XElement.Parse(_xml);

                var list = (from item in xdocument.Elements("marker")
                            select new
                            {
                                id = item.Attribute("id").Value,
                                hora = item.Attribute("hora").Value,
                                servida = item.Attribute("servida").Value,
                                camion = item.Attribute("camion").Value,
                                nomservida = item.Attribute("nomservida").Value,
                                racion = item.Attribute("racion").Value,
                                plan = item.Attribute("plan").Value,
                                servido = item.Attribute("servido").Value,
                                plandia = item.Attribute("plandia").Value,
                                servidodia = item.Attribute("servidodia").Value,

                            }).ToList();



                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("id");
                dttmp.Columns.Add("hora");
                dttmp.Columns.Add("servida");
                dttmp.Columns.Add("camion");
                dttmp.Columns.Add("nomservida");
                dttmp.Columns.Add("racion");
                dttmp.Columns.Add("plan");
                dttmp.Columns.Add("servido");
                dttmp.Columns.Add("plandia");
                dttmp.Columns.Add("servidodia");

                foreach (var item in list)
                {

                    DataRow newRow = dttmp.NewRow();
                    newRow["id"] = item.id;
                    newRow["hora"] = item.hora;
                    newRow["servida"] = item.servida;
                    newRow["camion"] = item.camion;
                    newRow["nomservida"] = item.nomservida;
                    newRow["racion"] = item.racion;
                    newRow["plan"] = item.plan;
                    newRow["servido"] = item.servido;
                    newRow["plandia"] = item.plandia;
                    newRow["servidodia"] = item.servidodia;

                    dttmp.Rows.Add(newRow);

                }

                dt = dttmp;


                reader.Close();
                iDataStream.Close();
                response.Close();

            }
            catch (WebException)
            {

            }

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            quitarMarcadorBuscarUbicaciones();
            txtBuscarUbicacion.Text = "";
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void cambioZoomMapa()
        {

            trackBar1.Value = Convert.ToInt32(gMapControl1.Zoom);

            nombresCorral();

            lblZomm.Text = valorPorcZomm() + "%";

        }
        private void nombresCorral() 
        { 
        
            if (indiceBotonVistaSel != 5)
            {   
                corralesActividadNombre();                
            }
            else 
            {
                mostrarCabezasCorral();
            }    

        }

        private void obtenerWsdlServidasSap(ref DataTable dtsalida)
        {

            //Cursor = Cursors.WaitCursor;

            if (txtFecha.Text.Equals(DateTime.Now.ToString("dd/MM/yyyy")))
            {
                seleccion = "REPARTO"; //envio datos camion en vivo
            }
            else
            {
                seleccion = "SERVIDAS"; //subido archivo en sap
            }                       

            Thread t = new Thread(() => { cargarWSDLSel(seleccion, Convert.ToDateTime(txtFecha.Text), Convert.ToDateTime(txtFecha.Text)); });
            t.Name = seleccion;
            t.IsBackground = true;
            t.Start();

            Console.WriteLine(t.Name + " " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString());

            //while (t.IsAlive)
            //{
            //    Thread.Sleep(50);
            //    Application.DoEvents();
            //}

            t.Join();

            lista = connectar.getList();
            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();



            DataTable dttmp = new DataTable();
            dttmp.Columns.Add("corral");
            dttmp.Columns.Add("fecha");
            dttmp.Columns.Add("hora");
            dttmp.Columns.Add("numcamion");
            dttmp.Columns.Add("servida");
            dttmp.Columns.Add("racion");
            dttmp.Columns.Add("plan");
            dttmp.Columns.Add("servido");
            dttmp.Columns.Add("plandia");
            dttmp.Columns.Add("servidodia");

            dttmp.Columns.Add("corralgps");


            foreach (String listar in lista)
            {

                string[] lines = listar.Split('|');

                DataRow newRow = dttmp.NewRow();

                newRow["corral"] = lines[0].Trim();

                lines[1] = lines[1].Insert(4, "-");
                lines[1] = lines[1].Insert(7, "-");
                newRow["fecha"] = lines[1].Trim();

                lines[2] = lines[2].Insert(2, ":");
                lines[2] = lines[2].Insert(5, ":");
                newRow["hora"] = lines[2].Trim();

                newRow["numcamion"] = lines[3].Trim().PadLeft(2,'0');
                newRow["servida"] = lines[4].Trim();
                newRow["racion"] = lines[5].Trim();
                newRow["plan"] = lines[6].Trim();
                newRow["servido"] = lines[7].Trim();
                newRow["plandia"] = lines[8].Trim();
                newRow["servidodia"] = lines[9].Trim();
                
                if (seleccion == "REPARTO") 
                {
                    newRow["corralgps"] = lines[10].Trim();
                }
                
                dttmp.Rows.Add(newRow);

            }

            dtsalida = dttmp;

            //Cursor = Cursors.Default;

            //if (!errormsg.Equals("")) { MessageBox.Show(errormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (!errormsg.Equals("")) { lblErrores.Text = errormsg; }


        }

        private void obtenerWsdlRepartoSap(ref DataTable dtsalida)
        {

            //Cursor = Cursors.WaitCursor;

            if (txtFecha.Text.Equals(DateTime.Now.ToString("dd/MM/yyyy")))
            {
                seleccion = "REPARTO"; //envio datos camion en vivo
            }
            else
            {
                seleccion = "REPARTOS"; //subido archivo en sap
            }


            Thread t = new Thread(() => { cargarWSDLSel(seleccion, Convert.ToDateTime(txtFecha.Text), Convert.ToDateTime(txtFecha.Text)); });
            t.Name = seleccion;
            t.IsBackground = true;
            t.Start();

            Console.WriteLine(t.Name + " " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString());

            t.Join();

            lista = connectar.getList();
            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();



            DataTable dttmp = new DataTable();
            dttmp.Columns.Add("corral");
            dttmp.Columns.Add("fecha");
            dttmp.Columns.Add("hora");
            dttmp.Columns.Add("numcamion");
            dttmp.Columns.Add("servida");
            dttmp.Columns.Add("racion");
            dttmp.Columns.Add("plan");
            dttmp.Columns.Add("servido");
            dttmp.Columns.Add("plandia");
            dttmp.Columns.Add("servidodia");

            dttmp.Columns.Add("corralgps");
            dttmp.Columns.Add("lat");
            dttmp.Columns.Add("lng");


            foreach (String listar in lista)
            {

                string[] lines = listar.Split('|');

                DataRow newRow = dttmp.NewRow();

                newRow["corral"] = lines[0].Trim();

                lines[1] = lines[1].Insert(4, "-");
                lines[1] = lines[1].Insert(7, "-");
                newRow["fecha"] = lines[1].Trim();

                lines[2] = lines[2].Insert(2, ":");
                lines[2] = lines[2].Insert(5, ":");
                newRow["hora"] = lines[2].Trim();

                newRow["numcamion"] = lines[3].Trim().PadLeft(2, '0');
                newRow["servida"] = lines[4].Trim();
                newRow["racion"] = lines[5].Trim();
                newRow["plan"] = lines[6].Trim();
                newRow["servido"] = lines[7].Trim();
                newRow["plandia"] = lines[8].Trim();
                newRow["servidodia"] = lines[9].Trim();

                newRow["corralgps"] = lines[10].Trim();
                newRow["lat"] = lines[11].Trim();
                newRow["lng"] = lines[12].Trim();

                dttmp.Rows.Add(newRow);

            }

            dtsalida = dttmp;

            //Cursor = Cursors.Default;

            //if (!errormsg.Equals("")) { MessageBox.Show(errormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (!errormsg.Equals("")) { lblErrores.Text = errormsg; }


        }

        private void obtenerWsdlCabezasSap(ref DataTable dtsalida)
        {

            //Cursor = Cursors.WaitCursor;

            seleccion = "CABEZAS"; 


            Thread t = new Thread(() => { cargarWSDLSel(seleccion, Convert.ToDateTime(txtFecha.Text), Convert.ToDateTime(txtFecha.Text)); }); //Convert.ToDateTime(txtFecha.Text).AddDays(-1)
            t.Name = seleccion;
            t.IsBackground = true;
            t.Start();

            Console.WriteLine(t.Name + " " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString());

            //while (t.IsAlive)
            //{
            //    Thread.Sleep(50);
            //    Application.DoEvents();
            //}

            t.Join();

            lista = connectar.getList();
            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();



            DataTable dttmp = new DataTable();
            dttmp.Columns.Add("centro");
            dttmp.Columns.Add("corral");
            dttmp.Columns.Add("fecha");
            dttmp.Columns.Add("lote");
            dttmp.Columns.Add("tipo");
            dttmp.Columns.Add("sexo");
            dttmp.Columns.Add("peso");
            dttmp.Columns.Add("cabezas");
     

            foreach (String listar in lista)
            {

                string[] lines = listar.Split('|');

                DataRow newRow = dttmp.NewRow();

                newRow["centro"] = lines[0].Trim();
                newRow["corral"] = lines[1].Trim();

                lines[2] = lines[2].Insert(4, "-");
                lines[2] = lines[2].Insert(7, "-");
                newRow["fecha"] = lines[2].Trim();

                newRow["lote"] = lines[3].Trim();
                newRow["tipo"] = lines[4].Trim();
                newRow["sexo"] = lines[5].Trim();
                newRow["peso"] = lines[6].Trim();
                newRow["cabezas"] = lines[7].Trim();


                dttmp.Rows.Add(newRow);

            }

            dtsalida = dttmp;

            //Cursor = Cursors.Default;

            //if (!errormsg.Equals("")) { MessageBox.Show(errormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (!errormsg.Equals("")) { lblErrores.Text = errormsg; }


        }

        private void obtenerWsdlHorariosSap(ref DataTable dtsalida)
        {

            //Cursor = Cursors.WaitCursor;

            seleccion = "HORARIOS"; 

            Thread t = new Thread(() => { cargarWSDLSel(seleccion, Convert.ToDateTime(txtFecha.Text), Convert.ToDateTime(txtFecha.Text)); });
            t.Name = seleccion;
            t.IsBackground = true;
            t.Start();

            Console.WriteLine(t.Name + " " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString());

            //while (t.IsAlive)
            //{
            //    Thread.Sleep(50);
            //    Application.DoEvents();
            //}

            t.Join();

            lista = connectar.getList();
            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();



            DataTable dttmp = new DataTable();
            dttmp.Columns.Add("corral");
            dttmp.Columns.Add("fecha");
            dttmp.Columns.Add("numcamion");
            dttmp.Columns.Add("servida");
            dttmp.Columns.Add("racionant");
            dttmp.Columns.Add("horaant");
            dttmp.Columns.Add("racion");
            dttmp.Columns.Add("hora");   
            dttmp.Columns.Add("dif");



            foreach (String listar in lista)
            {

                string[] lines = listar.Split('|');

                DataRow newRow = dttmp.NewRow();

                newRow["corral"] = lines[0].Trim();

                lines[1] = lines[1].Insert(4, "-");
                lines[1] = lines[1].Insert(7, "-");
                newRow["fecha"] = lines[1].Trim();

                newRow["numcamion"] = lines[2].Trim().PadLeft(2, '0');

                newRow["servida"] = lines[3].Trim();

                newRow["racionant"] = lines[4].Trim();

                lines[5] = lines[5].Insert(2, ":");
                lines[5] = lines[5].Insert(5, ":");
                newRow["horaant"] = lines[5].Trim();

                newRow["racion"] = lines[6].Trim();

                lines[7] = lines[7].Insert(2, ":");
                lines[7] = lines[7].Insert(5, ":");
                newRow["hora"] = lines[7].Trim();

                newRow["dif"] = lines[8].Trim();


                dttmp.Rows.Add(newRow);

            }

            dtsalida = dttmp;

            //Cursor = Cursors.Default;

            //if (!errormsg.Equals("")) { MessageBox.Show(errormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (!errormsg.Equals("")) { lblErrores.Text = errormsg; }


        }

        private void obtenerServidasSap(DataTable dtsalida, int opc, DateTime fecha)
        {

            string rutaorigen = "";

            switch (opc)
            {
                case 1:
                    rutaorigen = "\\\\tamggerpsig\\senga\\senga_archivos\\cargasap\\servidas.txt";
                    break;
                case 2:
                    rutaorigen = "\\\\tamggerpsig\\senga\\senga_archivos\\cargasap\\servidasant.txt";
                    break;
            }
            
            try
            {

                StreamReader objReader = new StreamReader(rutaorigen);
                string sLine = "";

                dtsalida.Clear();

                iniFecha = "";

                while (sLine != null)
                {

                    sLine = objReader.ReadLine();

                    if (sLine != null)
                    {

                        string[] lines = sLine.Split(',');

                        switch (opc)
                        {
                            case 1:
                                break;
                            case 2:

                                if (iniFecha.Equals(""))
                                {
                                    iniFecha = Convert.ToDateTime(lines[0]).ToString("yyyy-MM-dd");
                                }                                
                                finFecha = Convert.ToDateTime(lines[0]).ToString("yyyy-MM-dd");
                                break;
                        }


                        if (Convert.ToDateTime(lines[0]) == fecha)
                        {

                            DataRow newRow = dtsalida.NewRow();

                            newRow["fecha"] = Convert.ToDateTime(lines[0]).ToString("yyyy-MM-dd");
                            newRow["hora"] = lines[1].Trim();
                            newRow["corral"] = lines[2].Trim();
                            newRow["numcamion"] = lines[3].Trim();
                            newRow["servida"] = lines[4].Trim();
                            newRow["racion"] = lines[5].Trim();
                            newRow["plan"] = lines[6].Trim();
                            newRow["servido"] = lines[7].Trim();
                            newRow["plandia"] = lines[8].Trim();
                            newRow["servidodia"] = lines[9].Trim();
                            
                            dtsalida.Rows.Add(newRow);
                                                                                 
                        }

                    }

                }

                objReader.Close();

                //MessageBox.Show("Listo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch (Exception)
            {
                //MessageBox.Show("El archivo no se puede leer");
            }



        }

        private void todoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            vistaTodo();
            toolStripSplitButton2.Text = todoToolStripMenuItem.Text;

            gorientacion = 0;
            //lblErrores.Text = gorientacion.ToString();
            //corralesActividadNombre();
            nombresCorral();

        }

        private void vistaTodo() 
        {

            double LatInicial = 21.909286;
            double LngInicial = -98.740869;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.Zoom = 15;//16;

            //gMapControl1.Bearing = -90;

            //trackBar1.Visible = true;
            //btnRotarDer.Visible = true;
            //btnRotarIzq.Visible = true;

            //ubicActivo = true;
            //botonUbicaciones();
            trackBar1.Value = (int)gMapControl1.Zoom; // 16;
            //timerMonitor.Enabled = false;

        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {

            indiceBoton += 1;

            switch (indiceBoton)
            {
                case 1:
                    todoToolStripMenuItem_Click(sender,e);
                    //toolStripSplitButton2.Text = todoToolStripMenuItem.Text;
                    break;
                case 2:
                    corralesToolStripMenuItem_Click(sender, e);
                    //toolStripSplitButton2.Text = corralesToolStripMenuItem.Text;
                    break;
                case 3:
                    ecologicosToolStripMenuItem_Click(sender, e);
                    //toolStripSplitButton2.Text = ecologicosToolStripMenuItem.Text;
                    break;
                //case 4:
                //    empacadoraToolStripMenuItem_Click(sender, e);
                //    //toolStripSplitButton2.Text = empacadoraToolStripMenuItem.Text;
                //    break;

                default:
                    break;
            }

            if (indiceBoton == 3)//4)
            {
                indiceBoton = 0;
            }

        

        }
        
        private void pestanaOpcion(object sender, TabControlEventArgs e)
        {

            tab = e.TabPageIndex;

            txtFecha.Text = DateTime.Today.ToShortDateString();

            switch (tab)
            {
                case 0:
                    desdesap = "0";
                    //cmbCamiones.Visible = true;
                    //toolStripLabel2.Visible = true;
                    //btnBuscarcamionruta.Visible = true;
                    buscaCamiones(true);
                    txtFecha.Visible = true;
                    //toolStripLabel4.Visible = true;
                    toolStripButton10.Visible = true;
                    panelFecha.Visible = false;
                    timerCamion.Enabled = true;
                    toolStripButton9.Enabled = true;
                    break;
                case 1:
                    desdesap = "1";
                    //cmbCamiones.Visible = true;
                    //toolStripLabel2.Visible = true;
                    //btnBuscarcamionruta.Visible = true;
                    buscaCamiones(true);
                    txtFecha.Visible = true;
                    //toolStripLabel4.Visible = true;
                    toolStripButton10.Visible = false;
                    panelFecha.Visible = false;
                    timerCamion.Enabled = true;
                    toolStripButton9.Enabled = true;
                    break;
                case 2:
                    desdesap = "1";
                    //cmbCamiones.Visible = false;
                    //toolStripLabel2.Visible = false;
                    //btnBuscarcamionruta.Visible = false;
                    buscaCamiones(false);
                    txtFecha.Visible = true;
                    //toolStripLabel4.Visible = true;
                    toolStripButton10.Visible = true;
                    panelFecha.Visible = false;
                    timerCamion.Enabled = false;
                    toolStripButton9.Enabled = true;

                    monthCalendar1.SetDate(DateTime.Today);
                    break;
            }

            //desdesap = e.TabPageIndex.ToString();
            //origenDatos(desdesap);
            mostrarDatos(tab);
            
            quitarRecorrido();
            quitarMarcadorCamiones();
        }

        private void buscaCamiones(Boolean valor) 
        {

            cmbCamiones.Visible = valor;
            toolStripLabel2.Visible = valor;
            btnBuscarcamionruta.Visible = valor;

        }

        private void buscaCamiones2(Boolean valor)
        {
            lblcmbCamionRuta.Visible = valor;
            cmbCamionRuta.Visible = valor;
            btnBuscarcamionruta.Visible = valor;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            recorridoBoton();
            //panelFecha.Visible = false;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            quitarRecorrido();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {

            mostrarDatos(tab);
            calendarioNegritas(iniFecha,finFecha);
            
            panelFecha.Visible = ! panelFecha.Visible;
            toolStripButton9.Enabled = false;



            monthCalendar1.SelectionStart = DateTime.Parse( txtFecha.Text );
            //monthCalendar1.SelectionEnd = monthCalendar1.SelectionStart;



        }

        private void calendarioNegritas(string ifecha, string ffecha)
        {

            if (!ifecha.Equals(""))
            {    

                string fechastri = fechaConvertir2(ifecha);
                DateTime fechai = Convert.ToDateTime(fechastri);

                string fechastrf = fechaConvertir2(ffecha);
                DateTime fechaf = Convert.ToDateTime(fechastrf);

                DateTime fecha = fechai;
                
                monthCalendar1.RemoveAllBoldedDates();
                               
                do
                {
                    monthCalendar1.AddBoldedDate(fecha);
                    fecha = fecha.AddDays(1);
                }while(fecha <= fechaf);
                                                          
                monthCalendar1.UpdateBoldedDates();

                monthCalendar1.Refresh();

            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //monthCalendar1.Visible = false;
            //quitarRecorrido();
            //txtFecha.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();

            //fechaVer();
            //panelFecha.Visible = false;
        }

        private void btnCerrarFecha_Click(object sender, EventArgs e)
        {
            panelFecha.Visible = false;
            toolStripButton9.Enabled = true;
        }

        private void btnActualizaFecha_Click(object sender, EventArgs e)
        {

            fechaVer();
            panelFecha.Visible = false;
            
            timerCamion.Enabled = txtFecha.Text.Equals(DateTime.Now.ToString("dd/MM/yyyy"));
            
        }

        private void fechaVer()
        {

            this.Cursor = Cursors.WaitCursor;

            txtFecha.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();

            mostrarDatos(tab);

            mostrarDatosWs();

            calendarioNegritas(iniFecha, finFecha);
            //panelFecha.Visible = false;


            llenarCabezasCorral();
            nombresCorral();

            toolStripButton9.Enabled = true;
            
            this.Cursor = Cursors.Default;

        }
               
        private void grafico1(Chart chart)
        {
            
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].IsVisibleInLegend = false;
            chart.Series[0].BorderColor = Color.Black;
            chart.Series[0].LabelBackColor = Color.Transparent;
            chart.Series[0].LabelBorderColor = Color.Transparent;
            chart.Series[0].LabelForeColor = Color.Black;
            chart.Series[0].Points.Clear();
                        
            chart.Series[1].IsValueShownAsLabel = true;
            chart.Series[1].IsVisibleInLegend = false;
            chart.Series[1].BorderColor = Color.Black;
            chart.Series[1].LabelBackColor = Color.Transparent;
            chart.Series[1].LabelBorderColor = Color.Transparent;
            chart.Series[1].LabelForeColor = Color.Black;
            chart.Series[1].Points.Clear();


            double vfaltadia = 0;
            double vplandia = 0;
            double vservido = 0;
            double vvalor = 0;

            foreach (DataRow row in dtRepartotmp.Rows)
            {

                if (row["numcamion"].Equals("1"))
                {
                  vplandia = vplandia + Convert.ToInt32(row["plandia"]);
                  vservido = vservido + Convert.ToInt32(row["servidodia"]);
                }
                
            }



            vplandia = Math.Round(vplandia, 0);
            vservido = Math.Round(vservido, 0);

            vfaltadia = Math.Abs(vplandia - vservido);
            
            chart.Series[0].Points.AddXY("CAM1", vservido.ToString());

            vvalor = vservido / vplandia * 100;
            chart.Series[0].Points[0].Color = colorLeyenda(vvalor);

            chart.Series[1].Points.AddXY("CAM1", vfaltadia.ToString());
            chart.Series[1].Points[0].Color = Color.White;

            chart.Series[1].Sort(PointSortOrder.Ascending);



        }                  

        private void grafico2(Chart chart)
        {
                       
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].IsVisibleInLegend = false;
            chart.Series[0].BorderColor = Color.Black;
            chart.Series[0].LabelBackColor = Color.Transparent;
            chart.Series[0].LabelBorderColor = Color.Transparent;
            chart.Series[0].LabelForeColor = Color.Black;
            chart.Series[0].Points.Clear();

            Color[] colores = {
                     Color.White,
                     Color.Silver,
                     Color.Orange,
                     Color.Yellow,
                     Color.Cyan,
                     Color.LimeGreen,
                     Color.DarkViolet,
                     Color.Red,
            };

            double[] valores = { 0,0,0,0,0,0,0,0 };

            int totalcapas = overlayCeldas.Polygons.Count;

            for (int i = 0; i < totalcapas; i++)
            {
                for (int j = 0; j < valores.Count(); j++)
                {
                    if (overlayCeldas.Polygons.ElementAt(i).Tag.Equals(colores[j].Name)) { valores[j]++; }
                }
            }
            
            for (int i = 0; i < valores.Count(); i++)
            {
                valores[i] = Math.Round(valores[i] / totalcapas * 100, 1);
                chart.Series[0].Points.AddXY(i.ToString(),valores[i].ToString());
                chart.Series[0].Points[i].Color = colores[i];
            }

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

            indiceBoton2 += 1;

            switch (indiceBoton2)
            {
                case 1:
                    satelitalToolStripMenuItem_Click(sender, e);
                    toolStripSplitButton1.Text = satelitalToolStripMenuItem.Text;
                    break;
                case 2:
                    toolStripMenuItem1_Click(sender, e);
                    toolStripSplitButton1.Text = toolStripMenuItem1.Text;
                    break;
                case 3:
                    relieveToolStripMenuItem_Click(sender, e);
                    toolStripSplitButton1.Text = relieveToolStripMenuItem.Text;
                    break;

                default:
                    break;
            }

            if (indiceBoton2 == 3)
            {
                indiceBoton2 = 0;
            }

        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {


            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Imagen|*.jpg|Bitmap Imagen|*.bmp|Gif Imagen|*.gif";
            saveFileDialog1.Title = "Guardar en Archivo Imagen";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                //System.IO.FileStream fs =
                //    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.

                //String sImageName = "MapaGusi_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";

                int ancho = gMapControl1.Width;
                int alto = gMapControl1.Height;

                String sImageName = saveFileDialog1.FileName;
                Bitmap ThisMap = new Bitmap(ancho, alto);             
                gMapControl1.DrawToBitmap(ThisMap, new Rectangle(0, 0, ancho, alto));

                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        ThisMap.Save(sImageName, ImageFormat.Jpeg);
                        break;

                    case 2:
                        ThisMap.Save(sImageName, ImageFormat.Bmp);
                        break;

                    case 3:
                        ThisMap.Save(sImageName, ImageFormat.Gif);
                        break;
                }

                //fs.Close();
            }

            
            //ThisMap.Save(sImageName, ImageFormat.Png);

            //MessageBox.Show("Listo: se guardo en: " + sImageName, "Mensaje");


        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {


            indiceBotonVista += 1;

            switch (indiceBotonVista)
            {
                case 1:
                    servidasToolStripMenuItem_Click(sender, e);
                    //toolStripSplitButton3.Text = servidasToolStripMenuItem.Text;
                    break;

                case 2:
                    racionToolStripMenuItem_Click(sender, e);
                    //toolStripSplitButton3.Text = servidasToolStripMenuItem.Text;
                    break;

                case 3:
                    camionToolStripMenuItem_Click(sender, e);
                    //toolStripSplitButton3.Text = servidasToolStripMenuItem.Text;
                    break;

                case 4:
                    planeadoToolStripMenuItem_Click(sender, e);
                    //toolStripSplitButton3.Text = servidasToolStripMenuItem.Text;
                    break;

                case 5:
                    cabezasToolStripMenuItem_Click(sender, e);
                    //toolStripSplitButton3.Text = servidasToolStripMenuItem.Text;
                    break;

                default:
                    break;
            }

            if (indiceBotonVista == 5)
            {
                indiceBotonVista = 0;
            }

        }

        private void servidasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            toolStripSplitButton3.Text = servidasToolStripMenuItem.Text;
            indiceBotonVista = 1;
            indiceBotonVistaSel = 1;
            panelLeyenda.Visible = false;
            panelLeyendas.Visible = true;
            panelDetalles.Visible = false;
            panelCamiones.Visible = true;
            labelLeyendas.Text = toolStripSplitButton3.Text;

            cmbFiltroVista.Items.Clear();

            if (indiceBotonFecha == 1) { timerCamion.Start(); }
            mostrarDatosWs();  

            cmbFiltroVista.Visible = false;

        }

        private void racionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            toolStripSplitButton3.Text = racionToolStripMenuItem.Text;
            indiceBotonVista = 2;
            indiceBotonVistaSel = 2;
            panelLeyenda.Visible = false;
            panelLeyendas.Visible = true;
            panelDetalles.Visible = false;
            panelCamiones.Visible = true;
            labelLeyendas.Text = toolStripSplitButton3.Text;

            if (cmbFiltroVista.Items.Count > 0) { cmbFiltroVista.SelectedIndex = 0; }

            if (indiceBotonFecha == 1) { timerCamion.Start(); }
            mostrarDatosWs();

            cmbFiltroVista.Visible = true;
            llenaFiltroVista();            
                                
        }

        private void camionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            toolStripSplitButton3.Text = camionToolStripMenuItem.Text;
            indiceBotonVista = 3;
            indiceBotonVistaSel = 3;
            panelLeyenda.Visible = false;
            panelLeyendas.Visible = true;
            panelDetalles.Visible = false;
            panelCamiones.Visible = true;
            labelLeyendas.Text = toolStripSplitButton3.Text;

            if(cmbFiltroVista.Items.Count > 0) { cmbFiltroVista.SelectedIndex = 0; }

            if (indiceBotonFecha == 1) { timerCamion.Start(); }
            mostrarDatosWs();

            cmbFiltroVista.Visible = true;
            llenaFiltroVista();
                                           
        }

        private void planeadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripSplitButton3.Text = planeadoToolStripMenuItem.Text;
            indiceBotonVista = 4;
            indiceBotonVistaSel = 4;
            panelLeyenda.Visible = false;
            panelLeyendas.Visible = true;
            panelDetalles.Visible = false;
            panelCamiones.Visible = true;
            labelLeyendas.Text = toolStripSplitButton3.Text;

            if (cmbFiltroVista.Items.Count > 0) { cmbFiltroVista.SelectedIndex = 0; }

            if (indiceBotonFecha == 1) { timerCamion.Start(); }
            mostrarDatosWs();

            cmbFiltroVista.Visible = true;
            llenaFiltroVista();
        }

        private void cabezasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripSplitButton3.Text = cabezasToolStripMenuItem.Text;
            indiceBotonVista = 0;
            indiceBotonVistaSel = 5;
            panelLeyenda.Visible = false;
            panelLeyendas.Visible = false;
            panelDetalles.Visible = true;
            panelCamiones.Visible = false;
            labelLeyendas.Text = toolStripSplitButton3.Text;

            if (cmbFiltroVista.Items.Count > 0) { cmbFiltroVista.SelectedIndex = 0; }

            mostrarDatosWs();
            //timerCamion.Stop();
            //refrescarCabezas();
            
            //llenarCabezasCorral();
            //mostrarCabezasCorral();
            quitarMarcadorCamiones();

            cmbFiltroVista.Visible = false;
            llenaFiltroVista();

            panelLeyendas.Visible = false;
            panelCamiones.Visible = false;

        }

        private void llenaFiltroVista()
        {

            cmbFiltroVista.Items.Clear();
            cmbFiltroVista.Items.Add(vtodos);

            for (int i=0;i<dataGridVista.Rows.Count; i++)
            {
               cmbFiltroVista.Items.Add(dataGridVista[0, i].Value.ToString());
            }

            if (cmbFiltroVista.Items.Count > 0)
            {
                cmbFiltroVista.SelectedIndex = 0;
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBoxLeyendas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblInstancia_Click(object sender, EventArgs e)
        {

        }

        private void llenarColores(Boolean blanco)
        {

            colores.Clear();

            if (blanco)
            {
                colores.Add(Color.White);
            }

            colores.Add(Color.Silver);
            colores.Add(Color.Orange);
            colores.Add(Color.Yellow);
            colores.Add(Color.Cyan);   
            colores.Add(Color.LimeGreen);
            colores.Add(Color.DarkViolet);
            colores.Add(Color.Red);

            colores.Add(Color.MediumTurquoise);
            colores.Add(Color.GreenYellow);
            colores.Add(Color.CadetBlue);
            colores.Add(Color.DarkBlue);
            colores.Add(Color.Plum);
            colores.Add(Color.DarkRed);
            colores.Add(Color.Fuchsia);
            colores.Add(Color.Brown);
            colores.Add(Color.Blue);
            colores.Add(Color.DarkViolet);

        }

        private void lblErrores_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
        }


        private void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message + " " + e.Exception.StackTrace, "Unhandled Thread Exception");
            ErrorLogging(e.Exception);
            // here you can log the exception ...
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show((e.ExceptionObject as Exception).Message + " " + (e.ExceptionObject as Exception).StackTrace, "Unhandled UI Exception");
            // here you can log the exception ...
            ErrorLogging((e.ExceptionObject as Exception));
        }

        public void ErrorLogging(Exception ex)
        {

            String fechahoy = DateTime.Now.ToString("dd-MM-yyyy");


            string strPath = Application.StartupPath + "\\log\\log_" + fechahoy + ".txt";
            if (!File.Exists(strPath))
            {
                File.Create(strPath).Dispose();
            }
            using (StreamWriter sw = File.AppendText(strPath))
            {
                sw.WriteLine("=============Error Logging ===========");
                sw.WriteLine("===========Start============= " + DateTime.Now);
                sw.WriteLine("Error Message: " + ex.Message);
                sw.WriteLine("Stack Trace: " + ex.StackTrace);
                sw.WriteLine("===========End============= " + DateTime.Now);

            }
        }

        private void carpeta_existe_local()
        {

            if (!System.IO.Directory.Exists(Application.StartupPath + "\\log"))
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + "\\log");
            }

        }


        private string corralUbicacion(DataTable dt, double lat, double lng, double distancia)
        {
            double clat = 0;
            double clng = 0;
            double clat0 = 0; 
            double clng0 = 0;
            double clat1 = 0;
            double clng1 = 0;
            double clat2 = 0;
            double clng2 = 0;
            double clat3 = 0;
            double clng3 = 0;

            double clatmin0 = 0;
            double clngmin0 = 0;
            double clatmin1 = 0;
            double clngmin1 = 0;
            double clatmin2 = 0;
            double clngmin2 = 0;
            double clatmin3 = 0;
            double clngmin3 = 0;

            double dist0 = 0;
            double dist1 = 0;
            double dist2 = 0;
            double dist3 = 0;

            double distmin = 9999999;

            string corral = "0000";

            string corralmin0 = "0";
            string corralmin1 = "0";
            string corralmin2 = "0";
            string corralmin3 = "0";

            DataTable vdt = new DataTable();
            vdt = dt;

            try
            {

                foreach (DataRow row in vdt.Rows)
                {

                    clat = Convert.ToDouble(row["lat"].ToString());
                    clng = Convert.ToDouble(row["lng"].ToString());
                    
                    vdt.Rows[vdt.Rows.IndexOf(row)]["distancia"] = getDistancia(lat, lng, clat, clng);

                    //if (dist0 < distmin)
                    //{
                    //    distmin = dist0;
                    //    corralmin0 = row["corral"].ToString();

                    //    clatmin0 = clat0;
                    //    clngmin0 = clng0;

                    //}

                }


                //------------------------------------------------------------------
                vdt.DefaultView.Sort = "distancia asc";
                vdt = vdt.DefaultView.ToTable();

                overlayLinea.Routes.Clear();

                if (vdt.Rows.Count >= 1)
                {
                    DataRow row = vdt.Rows[0];
                    clatmin0 = Convert.ToDouble(row["lat"].ToString());
                    clngmin0 = Convert.ToDouble(row["lng"].ToString());
                    corralmin0 = row["corral"].ToString();
                    distmin = Convert.ToDouble(row["distancia"].ToString());
                    if (distmin <= distancia)
                    {
                        mostrarLinea(lat, lng, clatmin0, clngmin0);
                        corral = corralmin0;
                        lblDistanciaMin.Text = distmin.ToString();

                        overlayCircles.Polygons.Clear();
                        CreateCircle(new PointLatLng(lat, lng), 0.0001, 30);
                    }
                    else
                    {
                        overlayLinea.Routes.Clear();
                        overlayCircles.Polygons.Clear();
                        corral = "0000";
                        lblDistanciaMin.Text = "";
                    }
                }
                if (vdt.Rows.Count >= 2)
                {
                    DataRow row = vdt.Rows[1];
                    clatmin1 = Convert.ToDouble(row["lat"].ToString());
                    clngmin1 = Convert.ToDouble(row["lng"].ToString());
                    corralmin1 = row["corral"].ToString();
                    distmin = Convert.ToDouble(row["distancia"].ToString());
                    if (distmin <= distancia)
                    {
                        mostrarLinea(lat, lng, clatmin1, clngmin1);
                    }
                }
                if (vdt.Rows.Count >= 3)
                {
                    DataRow row = vdt.Rows[2];
                    clatmin2 = Convert.ToDouble(row["lat"].ToString());
                    clngmin2 = Convert.ToDouble(row["lng"].ToString());
                    corralmin2 = row["corral"].ToString();
                    distmin = Convert.ToDouble(row["distancia"].ToString());
                    if (distmin <= distancia)
                    {
                        mostrarLinea(lat, lng, clatmin2, clngmin2);
                    }
                }
                if (vdt.Rows.Count >= 4)
                {
                    DataRow row = vdt.Rows[3];
                    clatmin3 = Convert.ToDouble(row["lat"].ToString());
                    clngmin3 = Convert.ToDouble(row["lng"].ToString());
                    corralmin3 = row["corral"].ToString();
                    distmin = Convert.ToDouble(row["distancia"].ToString());
                    if (distmin <= distancia)
                    {
                        mostrarLinea(lat, lng, clatmin3, clngmin3);
                    }
                }
                //------------------------------------------------------------------


                ////if (dist >= 0.5 && dist <= 1)
                //if (distmin <= distancia)//0.05)
                //{                    
                //    corral = corralmin0;

                //    overlayLinea.Routes.Clear();

                //    mostrarLinea(lat, lng, clatmin0, clngmin0);

                //    lblDistanciaMin.Text = distmin.ToString();

                //    //-------------------------------------------

                //    mostrarLinea(lat, lng, clatmin1, clngmin1);
                //    mostrarLinea(lat, lng, clatmin2, clngmin2);
                //    mostrarLinea(lat, lng, clatmin3, clngmin3);

                //    //-------------------------------------------

                //}
                //else
                //{
                //    overlayLinea.Routes.Clear();
                //    corral = "0000";
                //    lblDistanciaMin.Text = "";
                //}







            }
            catch (Exception e)
            {

            }


            return corral;

        }
        
        private string corralUbicacionm(DataTable dt, double lat, double lng, double distancia)
        {

            double clat = 0;
            double clng = 0;

            double clatmin = 0;
            double clngmin = 0;

            double dist = 0;
            double distmin = 9999999;

            string corral = "0000";
            string corralmin = "0";

            string[][] valores = new string[][]
                {

                    //new string[] { "lat1m", "lng1m"},
                    //new string[] { "lat3m", "lng3m"},

                    //new string[] { "lat1a", "lng1a"},
                    //new string[] { "lat1b", "lng1b"},
                    //new string[] { "lat3a", "lng3a"},
                    //new string[] { "lat3b", "lng3b"},

                    //------------------------------------------

                    //new string[] { "lat2", "lng2"},
                    //new string[] { "lat4", "lng4"},

                    new string[] { "lat1m", "lng1m"},
                    new string[] { "lat3m", "lng3m"},

                    new string[] { "lat1b", "lng1b"},
                    new string[] { "lat3b", "lng3b"},

                    new string[] { "lat1a", "lng1a"},
                    new string[] { "lat3a", "lng3a"},

                    //------------------------------------------

                    //new string[] { "lat", "lng"},

                };

            try
            {

                foreach (DataRow row in dt.Rows)
                {

                    foreach (string[] valor in valores)
                    {
                        

                        clat = Convert.ToDouble(row[valor[0]].ToString());
                        clng = Convert.ToDouble(row[valor[1]].ToString());

                        dist = getDistancia(lat, lng, clat, clng);

                        if (dist < distmin)
                        {
                            distmin = dist;
                            corralmin = row["corral"].ToString();

                            clatmin = clat;
                            clngmin = clng;

                        }



                    }
                    

                    //for (int i = 1; i <= 4; i++)
                    //{
           
                    //    clat = Convert.ToDouble(row["lat"+i.ToString()+"m"].ToString());
                    //    clng = Convert.ToDouble(row["lng"+ i.ToString()+"m"].ToString());                                 
                      
                    //    dist = getDistancia(lat, lng, clat, clng);

                    //    if (dist < distmin)
                    //    {
                    //        distmin = dist;
                    //        corralmin = row["corral"].ToString();
                    //    }

                    //}

                    //clat = Convert.ToDouble(row["lat1m"].ToString());
                    //clng = Convert.ToDouble(row["lng1m"].ToString());

                    //dist = getDistancia(lat, lng, clat, clng);

                    //if (dist < distmin)
                    //{
                    //    distmin = dist;
                    //    corralmin = row["corral"].ToString();

                    //    clatmin = clat;
                    //    clngmin = clng;

                    //}


                    //clat = Convert.ToDouble(row["lat3m"].ToString());
                    //clng = Convert.ToDouble(row["lng3m"].ToString());

                    //dist = getDistancia(lat, lng, clat, clng);

                    //if (dist < distmin)
                    //{
                    //    distmin = dist;
                    //    corralmin = row["corral"].ToString();

                    //    clatmin = clat;
                    //    clngmin = clng;

                    //}

                    //---------------------------------------------------------------------------

                    

                }

                if (distmin <= distancia)
                {
                    corral = corralmin;

                    overlayLinea.Routes.Clear();

                    mostrarLinea(lat, lng, clatmin, clngmin);

                }
                else
                {
                    overlayLinea.Routes.Clear();

                    corral = "0000";
                }             
                
            }
            catch (Exception e)
            {

            }

            return corral;

        }

        private void mostrarLinea(double lat1, double lng1, double lat2, double lng2)
        {

            try
            {

                List<PointLatLng> puntos = new List<PointLatLng>();

                //overlayLinea.Routes.Clear();

                puntos.Add(new PointLatLng(lat1, lng1));
                puntos.Add(new PointLatLng(lat2, lng2));
                
                GMapRoute PuntoLinea = new GMapRoute(puntos, "Linea");
                overlayLinea.Routes.Add(PuntoLinea);

                PuntoLinea.Stroke.Color = Color.Yellow;
                //PuntoRuta.Stroke.Color = Color.Transparent; //Color.Blue;

                //double distance = PuntoLinea.Distance * 1000;

                //distance = Math.Round(distance, 2);

                //lblDistancia.Text = distance.ToString();
                //lblDistancia.Visible = true;

            }
            catch (Exception e)
            {

            }


        }

        public double getDistancia(double lat, double lng, double clat, double clng)
        {

            double EarthRadius = 6371;
            double distance = 0;
            double Lat = (clat - lat) * (Math.PI / 180);
            double Lon = (clng - lng) * (Math.PI / 180);
            double a = Math.Sin(Lat / 2) * Math.Sin(Lat / 2) + Math.Cos(lat * (Math.PI / 180)) * Math.Cos(clat * (Math.PI / 180)) * Math.Sin(Lon / 2) * Math.Sin(Lon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            distance = EarthRadius * c;

            return distance;

        }

        private void puntosmedios()
        {

            int i = 0;
            
            this.Cursor = Cursors.WaitCursor;

            DataTable dt = new DataTable();

            dt = dtUbictmp;

            quitarMarcadorRecorridos();

            foreach (DataRow row in dt.Rows)
            {

                agregaractualizarMarcadorRecorrido(
                    "",
                    "",
                    "",
                    Convert.ToDouble(row["lat1m"]),
                    Convert.ToDouble(row["lng1m"]));

                agregaractualizarMarcadorRecorrido(
                    "",
                    "",
                    "",
                    Convert.ToDouble(row["lat3m"]),
                    Convert.ToDouble(row["lng3m"]));

                i++;
     
            }

            this.Cursor = Cursors.Default;

        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            puntosmedios();
        }

        private void consultaUbicaciones(ref DataTable dt)
        {

            Datos datos = new Datos();
            DataTable dt2 = new DataTable();
     
            this.Cursor = Cursors.WaitCursor;

            datos.p_sql = "SELECT * FROM ubicacion";

            if (!datos.consultaSQL(ref dt2, true))
            {
                //MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(datos.p_error, "Mensaje");
            }
            else
            {

                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("corral");
                dttmp.Columns.Add("name");
                dttmp.Columns.Add("lat");
                dttmp.Columns.Add("lng");
                dttmp.Columns.Add("lat1");
                dttmp.Columns.Add("lng1");
                dttmp.Columns.Add("lat2");
                dttmp.Columns.Add("lng2");
                dttmp.Columns.Add("lat3");
                dttmp.Columns.Add("lng3");
                dttmp.Columns.Add("lat4");
                dttmp.Columns.Add("lng4");

                foreach (DataRow row in dt2.Rows)
                {

                    DataRow newRow = dttmp.NewRow();

                    newRow["corral"] = row["corral"];
                    newRow["name"] = row["corral"];
                    newRow["lat"] = row["latitud"];
                    newRow["lng"] = row["longitud"];
                    newRow["lat1"] = row["latitud1"];
                    newRow["lng1"] = row["longitud1"];
                    newRow["lat2"] = row["latitud2"];
                    newRow["lng2"] = row["longitud2"];
                    newRow["lat3"] = row["latitud3"];
                    newRow["lng3"] = row["longitud3"];
                    newRow["lat4"] = row["latitud4"];
                    newRow["lng4"] = row["longitud4"];
                    
                    dttmp.Rows.Add(newRow);                                                        
                    
                }
                
                dt = dttmp;

            }

            this.Cursor = Cursors.Default;

        }

        private void modifcarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.Cross;
            modificar();
        }

        private void modificar()
        {

            overlayBuscarUbicaciones.Markers.Clear();

            foreach (DataRow row in dtUbictmp.Rows)
            {

                if (row["corral"].ToString().Equals(lblCorral.Text))
                {

                    agregaractualizarMarcadorModificarUbicacion(
                     "1",//+row["corral"].ToString(),
                     row["corral"].ToString(),
                     Convert.ToDouble(row["lat1"]),
                     Convert.ToDouble(row["lng1"]));

                    agregaractualizarMarcadorModificarUbicacion(
                    "2",// + row["corral"].ToString(),
                    row["corral"].ToString(),
                    Convert.ToDouble(row["lat2"]),
                    Convert.ToDouble(row["lng2"]));

                    agregaractualizarMarcadorModificarUbicacion(
                    "3",// + row["corral"].ToString(),
                    row["corral"].ToString(),
                    Convert.ToDouble(row["lat3"]),
                    Convert.ToDouble(row["lng3"]));

                    agregaractualizarMarcadorModificarUbicacion(
                    "4",// + row["corral"].ToString(),
                    row["corral"].ToString(),
                    Convert.ToDouble(row["lat4"]),
                    Convert.ToDouble(row["lng4"]));

                    corralModif = lblCorral.Text;

                }                

            }
            


        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            gMapControl1.Bearing = 0;
        }

        private void hoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripSplitButton4.Text = hoyToolStripMenuItem.Text;
            toolStripButton10.Visible = false;
            indiceBotonFecha = 1;
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            mostrarDatosWs();

            if (indiceBotonVistaSel != 5 || gopc == 1)
            {
                timerCamion.Enabled = true;
            }
            panelFecha.Visible = false;

            //lblcmbCamionRuta.Visible = true;
            //cmbCamionRuta.Visible = true;
            //btnBuscarcamionruta.Visible = true;
            buscaCamiones2(false);

            //llenarCabezasCorral();
            //nombresCorral();
        }

        private void fechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripSplitButton4.Text = fechaToolStripMenuItem.Text;
            toolStripButton10.Visible = true;
            indiceBotonFecha = 0;

            quitarMarcadorCamiones();
            timerCamion.Enabled = false;

            //lblcmbCamionRuta.Visible = false;
            //cmbCamionRuta.Visible = false;
            //btnBuscarcamionruta.Visible = false;
            buscaCamiones2(false);

        }

        private void toolStripSplitButton4_ButtonClick(object sender, EventArgs e)
        {
                       
            indiceBotonFecha += 1;

            switch (indiceBotonFecha)
            {
                case 1:
                    hoyToolStripMenuItem_Click(sender, e);
                    //toolStripSplitButton3.Text = servidasToolStripMenuItem.Text;
                    break;

                case 2:
                    fechaToolStripMenuItem_Click(sender, e);
                    //toolStripSplitButton3.Text = servidasToolStripMenuItem.Text;
                    break;

                default:
                    break;
            }

            if (indiceBotonFecha == 2)
            {
                indiceBotonFecha = 0;
            }


        }

        private void gMapControl1_KeyPress(object sender, KeyPressEventArgs e)
        {            

            if (ActivoCtrl && e.KeyChar == (char)1)
            {
                ajustarCelda();
            }

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            marcadorCelda("1");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            marcadorCelda("2");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            marcadorCelda("3");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            marcadorCelda("4");
        }

        private void cmbFiltroVista_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbFiltroVista_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarDatosWs();
        }

        private void frmMapa_KeyPress(object sender, KeyPressEventArgs e)
        {
           char a =  e.KeyChar;
        }

        private void gMapControl1_MouseDown(object sender, MouseEventArgs e)
        {
 

        }

        private void gMapControl1_Click(object sender, EventArgs e)
        {
            if (ActivoCtrl)
            {
                marcas++;
                marcadorCelda(marcas.ToString());


            }
        }

        private void ajustarCelda()
        {

            Datos datos = new Datos();
            DataTable dt = new DataTable();

            double vlat1 = 0;
            double vlng1 = 0;
            double vlat2 = 0;
            double vlng2 = 0;
            double vlat3 = 0;
            double vlng3 = 0;
            double vlat4 = 0;
            double vlng4 = 0;

            if (corralModif.Equals("")) { }
                       
            vlat1 = overlayDrags.Markers.ElementAt(0).Position.Lat;
            vlng1 = overlayDrags.Markers.ElementAt(0).Position.Lng;
            vlat2 = overlayDrags.Markers.ElementAt(1).Position.Lat;
            vlng2 = overlayDrags.Markers.ElementAt(1).Position.Lng;
            vlat3 = overlayDrags.Markers.ElementAt(2).Position.Lat;
            vlng3 = overlayDrags.Markers.ElementAt(2).Position.Lng;
            vlat4 = overlayDrags.Markers.ElementAt(3).Position.Lat;
            vlng4 = overlayDrags.Markers.ElementAt(3).Position.Lng;

            //corral,latitud,longitud,latitud1,longitud1,latitud2,longitud2,latitud3,longitud3,latitud4,longitud4
            datos.p_sql = "UPDATE ubicacion SET " +
                 " latitud1 = " + vlat1.ToString() + ", longitud1 = " + vlng1.ToString() + ", " +
                 " latitud2 = " + vlat2.ToString() + ", longitud2 = " + vlng2.ToString() + ", " +
                 " latitud3 = " + vlat3.ToString() + ", longitud3 = " + vlng3.ToString() + ", " +
                 " latitud4 = " + vlat4.ToString() + ", longitud4 = " + vlng4.ToString() + "  " +
                 " WHERE corral = '" + corralModif + "'";

            if (!datos.consultaSQL(ref dt, false))
            {
                lblErrores.Text = datos.p_error;
            }
            else
            {
                overlayBuscarUbicaciones.Markers.Clear();
            }
                       



        } 

        private void ajustarToolStripMenuItem_Click(object sender, EventArgs e)
        {




        }

        private void alinearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        void llenaTablets() 
        { 
        
            tablets.Clear();
            tablets.Add("tamggcamr01");
            tablets.Add("tamggcamr02");
            tablets.Add("tamggcamr03");
            tablets.Add("tamggcamr04");
            tablets.Add("tamggcamr05");
            tablets.Add("tamggcamr06");
            tablets.Add("tamggcamr07");
            tablets.Add("tamggcamr08");
            tablets.Add("tamggcamr09");
            tablets.Add("tamggcamr10");
            tablets.Add("tamggcamr11");
            tablets.Add("tamggcamr12");
            tablets.Add("tamggcamr13");
            tablets.Add("tamggcamr14");
            tablets.Add("tamggcamr15"); 
            
        }

        private void timerPing_Tick(object sender, EventArgs e)
        {

            //int i = 1;

            //foreach (String tbl in tablets) 
            //{
                
            //    if (PingHost(tbl)) 
            //    {
            //        lblPing.Text += tbl;
            //    }
            //    if (i==3) { break; }
            //    i++;

            //}




        }


        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }

        private void btnPing_Click(object sender, EventArgs e)
        {

            lblPing.Text = "";
            int i = 1;

            foreach (String tbl in tablets)
            {
                lblPing.Text += tbl;
                //if (PingHost(tbl))  { lblPing.Text += tbl; }
                if (i == 3) { break; }
                i++;

            }

        }

        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {
            //recorridoBoton();
            if (cmbRaciones.Items.Count == 0)
            {
                MessageBox.Show("Elija camion y racion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                recorridoCamionBoton(true);
            }
        
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {

            if (cmbRaciones.Items.Count == 0)
            {
                MessageBox.Show("Elija camion y racion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            { 
                recorridoCamionBoton(false);            
            }
        
        }

        private void recorridoCamionBoton(Boolean textos) 
        {

            DataRow[] foundRows2;
            List<PointLatLng> puntos = new List<PointLatLng>();
            int i = 1;
            
            try
            {

                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();

                obtenerWsdlHorariosSap(ref dt);
                consultaUbicaciones(ref dt2);

                quitarMarcadorRecorridos();
                quitarMarcadorRutas();

                dt.DefaultView.Sort = "servida, numcamion, racion, hora asc";
                dt = dt.DefaultView.ToTable();



                this.Cursor = Cursors.WaitCursor;

                if (dt.Rows.Count > 0)
                {

                    foreach (DataRow row in dt.Rows)
                    {
                        string vracion = "";
                        if (cmbRaciones.Items.Count>0)
                        {
                            vracion = cmbRaciones.SelectedItem.ToString();
                        }

                        if (cmbCamion.SelectedItem.ToString().Equals(row["numcamion"].ToString())
                            && cmbServidas.SelectedItem.ToString().Equals(row["servida"].ToString())
                            //&& cmbRaciones.SelectedItem.ToString().Contains(row["racion"].ToString())
                            && row["racion"].ToString().Contains(vracion)
                            && ! row["hora"].ToString().Equals("0:00:00") 
                            )
                        {

                            foundRows2 = dt2.Select("corral='" + row["corral"].ToString() + "'");

                            if (foundRows2.Length > 0)
                            {
                                DataRow item1 = foundRows2[0];

                                agregaractualizarMarcadorRecorridoCamion(
                                    row["numcamion"].ToString(),
                                    row["fecha"].ToString(),
                                    row["hora"].ToString(),
                                    i,
                                    Convert.ToDouble(item1["lat"]),
                                    Convert.ToDouble(item1["lng"]),
                                    textos);
                                    
                                i++;

                                puntos.Add(new PointLatLng(Convert.ToDouble(item1["lat"]), Convert.ToDouble(item1["lng"])));

                            }

                        
                        }

                    }


                    GMapRoute PuntoRuta = new GMapRoute(puntos, "Ruta");
                    overlayRutas.Routes.Add(PuntoRuta);

                    //PuntoRuta.Stroke.Color = Color.Red;
                    //PuntoRuta.Stroke.Color = Color.Transparent;

                }

            }
            catch (Exception e) 
            { 
            
            }

            this.Cursor = Cursors.Default;



            //int i = 1;

            //this.Cursor = Cursors.WaitCursor;

            ////////////
            ////GMapOverlay Ruta = new GMapOverlay("Rutas");
            //List<PointLatLng> puntos = new List<PointLatLng>();
            ///////////

            ////if (datFecha.Visible)
            ////{
            //DataTable dt = new DataTable();

            ////leerWsRecorrido(ref dt);
            //leerWsdlRecorrido(ref dt);


            //quitarMarcadorRecorridos();
            //quitarMarcadorRutas();

            //foreach (DataRow row in dt.Rows)
            //{

            //    agregaractualizarMarcadorRecorrido(
            //        row["numcamion"].ToString(),
            //        row["fecha"].ToString(),
            //        row["hora"].ToString(),
            //        Convert.ToDouble(row["lat"]),
            //        Convert.ToDouble(row["lng"]));


            //    puntos.Add(new PointLatLng(Convert.ToDouble(row["lat"]), Convert.ToDouble(row["lng"])));

            //    //if (cantp == i)
            //    //{
            //    //    break;
            //    //}

            //    i++;
            //}

            /////////////// linea une puntos

            //GMapRoute PuntoRuta = new GMapRoute(puntos, "Ruta");
            //overlayRutas.Routes.Add(PuntoRuta);

            ////PuntoRuta.Stroke.Color = Color.Blue;
            //PuntoRuta.Stroke.Color = Color.Transparent;



            //double distance = PuntoRuta.Distance;

            //distance = Math.Round(distance, 2);

            //lblDistancia.Text = "dist = " + distance.ToString() + " Km";
            //lblDistancia.Visible = true;

            /////////////

            ////}
            ////else
            ////{
            ////    quitarMarcadorRecorridos();
            ////    quitarMarcadorRutas();

            ////    lblDistancia.Text = "dist = 0 Km";
            ////    lblDistancia.Visible = false;
            ////}

            //this.Cursor = Cursors.Default;

        }

        private void llenaRaciones() 
        {

            DataTable dt = new DataTable();
            DataRow[] foundRows2;

            try
            {

                cmbRaciones.Items.Clear();

                obtenerWsdlHorariosSap(ref dt);
                string expression = "numcamion='" + cmbCamion.Text.Trim() + "' and servida = '" + cmbServidas.Text.Trim() + "'";
                string sortOrder = "numcamion, servida, hora ASC";
                foundRows2 = dt.Select(expression, sortOrder);

                foreach (DataRow item in foundRows2)
                {

                    if (!cmbRaciones.Items.Contains(item["racion"].ToString()))
                    {
                        cmbRaciones.Items.Add(item["racion"].ToString());
                    }

                }

                if (cmbRaciones.Items.Count > 0)
                {
                    cmbRaciones.SelectedIndex = 0;
                }

            }
            catch (Exception e) { }
            


        }

        private void cmbCamion_SelectedIndexChanged(object sender, EventArgs e)
        { 
            llenaRaciones();        
        }

        private void cmbCamion_Click(object sender, EventArgs e)
        {
            llenaRaciones();
        }

        private string cadenaCero(string valor)
        {

            if (valor.Equals(""))
            {
                valor = "0";
            }

            return valor;

        }

        private void buscarCoordenadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string value = "";

            if (Comun.InputBox("Buscar Coordenada", "Lat, Lng", ref value) == DialogResult.OK)
            {
                try
                {
                    string[] valor = value.Split(',');
                    gMapControl1.Position = new PointLatLng(Convert.ToDouble(valor[0].Trim()), Convert.ToDouble(valor[1].Trim()));
                }
                catch { }

            }

        }

        private void guardarCoordenadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarCoordenada();
        }

        private void guardarCoordenada() 
        {

            Datos datos = new Datos();
            DataTable dt = new DataTable();

            string value = lblCorral.Text;

            if (Comun.InputBox("Guardar Coordenada", "Corral", ref value) == DialogResult.OK)
            {

                datos.p_sql = "UPDATE ubicacion SET " +
                 " latitud = " + LatActual.ToString() + ", longitud = " + LngActual.ToString() +
                 " WHERE corral = '" + value + "'";

                if (!datos.consultaSQL(ref dt, false))
                {
                    lblErrores.Text = datos.p_error;
                }
                else 
                {
                    marcadorCelda(value);
                    lblErrores.Text = "guardado " + value;
                }

            }

        }

        private void verCoordenadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gVerCoordenada = !gVerCoordenada;

            if (gVerCoordenada)
            {
                marcarCoordenadas();
            }
            else 
            {
                quitarMarcadorUbicaciones();
            }

        }

        private void verOcultarCoordenadasCamionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gVerCoordenadaR = !gVerCoordenadaR;

            if (gVerCoordenadaR)
            {
                marcarCoordenadasR();
            }
            else
            {
                quitarMarcadorUbicaciones();
            }
        }

        private void marcarCoordenadas()
        {            

            List<PointLatLng> puntos = new List<PointLatLng>();

            DataTable dt = new DataTable();

            //leerWsdlRecorrido(ref dt);
            consultaUbicaciones(ref dt);

            quitarMarcadorUbicaciones();

            overlayDrags.Markers.Clear();


            this.Cursor = Cursors.WaitCursor;

            foreach (DataRow row in dt.Rows)
            {

                agregarMarcadorUbicacion(
                    row["corral"].ToString(),
                    Convert.ToDouble(row["lat"]),
                    Convert.ToDouble(row["lng"]));


               
            }

            this.Cursor = Cursors.Default;

        }

        private void marcarCoordenadasR()
        {

            List<PointLatLng> puntos = new List<PointLatLng>();

            DataTable dt = new DataTable();

            obtenerWsdlRepartoSap(ref dt);

            quitarMarcadorUbicaciones();

            overlayDrags.Markers.Clear();


            this.Cursor = Cursors.WaitCursor;

            foreach (DataRow row in dt.Rows)
            {
                string ok = "X";

                if (row["corral"].ToString() == row["corralgps"].ToString()) 
                {
                    ok = "OK";
                }
                
                string nombre = ok + "-S " + row["servida"].ToString().TrimStart('0')+"-C " + row["corral"].ToString() + "-GPS " + row["corralgps"].ToString() + "-CAM " + row["numcamion"].ToString() + "-" + row["hora"].ToString();

                agregarMarcadorUbicacion(
                    nombre,
                    Convert.ToDouble(row["lat"]),
                    Convert.ToDouble(row["lng"]));

            }

            this.Cursor = Cursors.Default;

        }

        private void insertaLineaComederos(string nombre,PointLatLng a, PointLatLng b) 
        {
            _pointslc.Clear();
            _pointslc.Add(a);
            _pointslc.Add(b);

            comederoActividad(nombre, _pointslc, Color.Brown);
        }

        private void lineasComederos() 
        {

            overlayComederos.Polygons.Clear();

            insertaLineaComederos("Comedero01",new PointLatLng(21.92068, -98.741342), new PointLatLng(21.920854, -98.741566));
            insertaLineaComederos("Comedero02",new PointLatLng(21.920868, -98.741583), new PointLatLng(21.92103, -98.741805));
            insertaLineaComederos("Comedero03",new PointLatLng(21.920726, -98.741296), new PointLatLng(21.920899, -98.741527));
            insertaLineaComederos("Comedero04",new PointLatLng(21.92091, -98.74154), new PointLatLng(21.921078, -98.741763));




        }

        //private void getClosestPointOnLines(PointLatLng pXy, aXys)
        //{

        //    float minDist;
        //    float fTo;
        //    float fFrom;
        //    float x;
        //    float y;
        //    float i;
        //    float dist;

        //    if (aXys.length > 1)
        //    {

        //        for (var n = 1; n < aXys.length; n++)
        //        {

        //            if (aXys[n].x != aXys[n - 1].x)
        //            {
        //                float a = (aXys[n].y - aXys[n - 1].y) / (aXys[n].x - aXys[n - 1].x);
        //                float b = aXys[n].y - a * aXys[n].x;
        //                dist = Math.Abs(a * pXy.x + b - pXy.y) / Math.Sqrt(a * a + 1);
        //            }
        //            else
        //                dist = Math.Abs(pXy.x - aXys[n].x)

        //            // length^2 of line segment 
        //            float rl2 = Math.Pow(aXys[n].y - aXys[n - 1].y, 2) + Math.Pow(aXys[n].x - aXys[n - 1].x, 2);

        //            // distance^2 of pt to end line segment
        //            float ln2 = Math.Pow(aXys[n].y - pXy.y, 2) + Math.Pow(aXys[n].x - pXy.x, 2);

        //            // distance^2 of pt to begin line segment
        //            float lnm12 = Math.Pow(aXys[n - 1].y - pXy.y, 2) + Math.pPow(aXys[n - 1].x - pXy.x, 2);

        //            // minimum distance^2 of pt to infinite line
        //            float dist2 = Math.Pow(dist, 2);

        //            // calculated length^2 of line segment
        //            float calcrl2 = ln2 - dist2 + lnm12 - dist2;

        //            // redefine minimum distance to line segment (not infinite line) if necessary
        //            if (calcrl2 > rl2)
        //                dist = Math.Sqrt(Math.Min(ln2, lnm12));

        //            if ((minDist == null) || (minDist > dist))
        //            {
        //                if (calcrl2 > rl2)
        //                {
        //                    if (lnm12 < ln2)
        //                    {
        //                        fTo = 0;//nearer to previous point
        //                        fFrom = 1;
        //                    }
        //                    else
        //                    {
        //                        fFrom = 0;//nearer to current point
        //                        fTo = 1;
        //                    }
        //                }
        //                else
        //                {
        //                    // perpendicular from point intersects line segment
        //                    fTo = ((Math.Sqrt(lnm12 - dist2)) / Math.Sqrt(rl2));
        //                    fFrom = ((Math.Sqrt(ln2 - dist2)) / Math.Sqrt(rl2));
        //                }
        //                minDist = dist;
        //                i = n;
        //            }
        //        }

        //        var dx = aXys[i - 1].x - aXys[i].x;
        //        var dy = aXys[i - 1].y - aXys[i].y;

        //        x = aXys[i - 1].x - (dx * fTo);
        //        y = aXys[i - 1].y - (dy * fTo);

        //    }

        //    return { 'x': x, 'y': y, 'i': i, 'fTo': fTo, 'fFrom': fFrom };
        //}



        private void menuBasico() 
        {

            //toolStrip1.Items["lblcmbCamionRuta"].Visible = false;




        }

        private void menuBuscarCamion(Boolean opc)
        {

            toolStrip1.Items["lblcmbCamionRuta"].Visible = opc;
            toolStrip1.Items["cmbCamionRuta"].Visible = opc;
            toolStrip1.Items["btnBuscarcamionruta"].Visible = opc;
            
        }

        private void menuRutas(Boolean opc) 
        {

            toolStrip1.Items["toolStripButton9"].Visible = opc;
            toolStrip1.Items["toolStripButton12"].Visible = opc;
            toolStrip1.Items["toolStripButton6"].Visible = opc;
            toolStrip1.Items["toolStripButton14"].Visible = opc;
            toolStrip1.Items["toolStripButton8"].Visible = opc;

            toolStrip1.Items["toolStripLabel3"].Visible = opc;
            toolStrip1.Items["cmbServidas"].Visible = opc;
            toolStrip1.Items["toolStripLabel7"].Visible = opc;
            toolStrip1.Items["cmbCamion"].Visible = opc;
            toolStrip1.Items["toolStripLabel4"].Visible = opc;
            toolStrip1.Items["cmbRaciones"].Visible = opc;
                      

        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            refrescarCabezas();
            this.Cursor = Cursors.Default;
        }

        private void refrescarCabezas() 
        { 
            llenarCabezasCorral();
            mostrarCabezasCorral();        
        }

        private void picCam01_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 0;
            ubicacionCamion();
        }

        private void picCam02_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 1;
            ubicacionCamion();
        }

        private void picCam03_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 2;
            ubicacionCamion();
        }

        private void picCam04_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 3;
            ubicacionCamion();
        }

        private void picCam05_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 4;
            ubicacionCamion();
        }

        private void picCam06_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 5;
            ubicacionCamion();
        }

        private void picCam07_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 6;
            ubicacionCamion();
        }

        private void picCam08_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 7;
            ubicacionCamion();
        }

        private void picCam09_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 8;
            ubicacionCamion();
        }

        private void picCam10_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 9;
            ubicacionCamion();
        }

        private void picCam11_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 10;
            ubicacionCamion();
        }

        private void picCam12_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 11;
            ubicacionCamion();
        }

        private void picCam13_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 12;
            ubicacionCamion();
        }

        private void picCam14_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 13;
            ubicacionCamion();
        }

        private void picCam15_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 14;
            ubicacionCamion();
        }

        private void opcionMouseMenu()
        {

            string name = Environment.MachineName;

            if (name.Equals("TAMGGDEV"))
            { 
                guardarCoordenadaToolStripMenuItem.Visible = true;
                verCoordenadasToolStripMenuItem.Visible = true;
                modifcarToolStripMenuItem.Visible = true;
                verOcultarCoordenadasCamionToolStripMenuItem.Visible = true;
            }
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            repartosBoton();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value > 15)
            {
                trackBar1.Value--;
                trackMover();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value<20) 
            {
                trackBar1.Value++;
                trackMover();
            }
        }


        private void CreateCircle(PointLatLng point, double radius, int segments)
        {

            List<PointLatLng> gpollist = new List<PointLatLng>();

            double seg = Math.PI * 2 / segments;

            //PointLatLng gpoi1 = new PointLatLng(point.Lat, point.Lng);
            //gpollist.Add(gpoi1);

            for (int i = 0; i < segments; i++)
            {
                double theta = seg * i;
                double a = point.Lat + Math.Cos(theta) * radius;
                double b = point.Lng + Math.Sin(theta) * radius;

                PointLatLng gpoi = new PointLatLng(a, b);

                gpollist.Add(gpoi);
            }

            polygonCircles = new GMapPolygon(gpollist, "circulo")
            {
                Stroke = new Pen(Color.Lime, 4),
                Fill = new SolidBrush(Color.Transparent), 
                Tag = "circulo",
            };
            overlayCircles.Polygons.Add(polygonCircles);




        }

    }

    internal class Graphic
    {
        private object bassPoint;
        private object bassRockTextSymbol;

        public Graphic(object bassPoint, object bassRockTextSymbol)
        {
            this.bassPoint = bassPoint;
            this.bassRockTextSymbol = bassRockTextSymbol;
        }
    }

    internal class TextSymbol
    {
        private string v1;
        private Color color;
        private int v2;
        private object left;
        private object bottom;

        public TextSymbol(string v1, Color color, int v2, object left, object bottom)
        {
            this.v1 = v1;
            this.color = color;
            this.v2 = v2;
            this.left = left;
            this.bottom = bottom;
        }
    }

    internal class MapPoint
    {
        private double v1;
        private double v2;
        private object wgs84;

        public MapPoint(double v1, double v2, object wgs84)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.wgs84 = wgs84;
        }
    }
}
