using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
//using System.Reflection.Emit;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using System.Xml.Linq;



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

        GMarkerGoogle markerCamion2;
        GMapOverlay overlayCamiones2;

        GMapOverlay overlayLinea;

        GMarkerGoogle markerRecorrido;
        GMapOverlay overlayRecorridos;

        GMarkerGoogle markerCorral;
        GMapOverlay overlayCorrales;

        GMapPolygon polygonZona;
        GMapOverlay overlayZonas;

        GMapPolygon polygonRecepcion;
        GMapOverlay overlayRecepcion;

        GMapPolygon polygonTaller;
        GMapOverlay overlayTaller;

        GMapPolygon polygonPrensas;
        GMapOverlay overlayPrensas;
        GMarkerGoogle markerlabelPrensas;
        GMapOverlay overlaylabelPrensas;

        GMapPolygon polygonEcoSec01;
        GMapOverlay overlayEcoSec01;

        GMapPolygon polygonEcologicos;
        GMapOverlay overlayEcologicos;

        GMapPolygon polygonCelda;
        GMapOverlay overlayCeldas;
        GMarkerGoogle markerlabelCelda;
        GMapOverlay overlaylabelCeldas;

        //--------------------------
        GMapPolygon polygonCelda2;
        GMapOverlay overlayCeldas2;
        GMarkerGoogle markerlabelCelda2;
        GMapOverlay overlaylabelCeldas2;


        GMapPolygon polygonComederos;
        GMapOverlay overlayComederos;

        //GMapOverlay overlaytextCeldas;

        GMarkerGoogle markerDrag;
        GMapOverlay overlayDrags;

        GMapOverlay overlayRutas;

        DataTable dtTallertmp;
        DataTable dtCamiontmp;
        DataTable dtListaCamiontmp;
        DataTable vdt;

        DataTable dtUbictmp;
        DataTable dtRepartotmp;
        DataTable dtLocalizatmp;
        DataTable dtCabezastmp;
        DataTable dtPlanestmp;
        DataTable dtRutaErrortmp;

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
        double LatAnterior = 0;
        double LngAnterior = 0;

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

        double vlat;
        double vlng;

        string vselActRut = "00";
        int totCam = 36;
        int altura_barra_progress_ubic;
        int altura_barra_progress_cam;

        int vCantDesconect = 0;
        int vCantConect = 0;
        int vCantLocaliza = 0;

        Image CamionAct;
        Image CamionInAct;

        RoundedPanel panelTablero;

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
        bool gMostrarRepartos = true;
        bool gTimerActivo1 = false;

        Color colorCamion = Color.FromArgb(30, 144, 255);

        string iniFecha = "";
        string finFecha = "";
        int gopc;
        string gnombre;

        const int clasico = 1;
        const int ecologico = 2;

        string mensajeSinServir = "Status:\n";
        bool verSinServir = false;

        private List<PointLatLng> _points;
        private List<PointLatLng> _pointsc;
        private List<PointLatLng> _pointslc;

        List<Color> colores = new List<Color>();
        List<String> tablets = new List<String>();

        private ProgressStackBar progressBar01 = new ProgressStackBar();
        private ProgressStackBar progressBar02 = new ProgressStackBar();

        private ProgressStackBar progressBarCam01 = new ProgressStackBar();
        private ProgressStackBar progressBarCam02 = new ProgressStackBar();
        private ProgressStackBar progressBarCam03 = new ProgressStackBar();
        private ProgressStackBar progressBarCam12 = new ProgressStackBar();
        private ProgressStackBar progressBarCam13 = new ProgressStackBar();
        private ProgressStackBar progressBarCam14 = new ProgressStackBar();
        private ProgressStackBar progressBarCam15 = new ProgressStackBar();
        private ProgressStackBar progressBarCam16 = new ProgressStackBar();
        private ProgressStackBar progressBarCam17 = new ProgressStackBar();
        private ProgressStackBar progressBarCam18 = new ProgressStackBar();
        private ProgressStackBar progressBarCam19 = new ProgressStackBar();
        private ProgressStackBar progressBarCam20 = new ProgressStackBar();
        private ProgressStackBar progressBarCam21 = new ProgressStackBar();
        private ProgressStackBar progressBarCam22 = new ProgressStackBar();
        private ProgressStackBar progressBarCam23 = new ProgressStackBar();
        private ProgressStackBar progressBarCam24 = new ProgressStackBar();
        private ProgressStackBar progressBarCam25 = new ProgressStackBar();
        private ProgressStackBar progressBarCam26 = new ProgressStackBar();
        private ProgressStackBar progressBarCam27 = new ProgressStackBar();
        private ProgressStackBar progressBarCam28 = new ProgressStackBar();
        private ProgressStackBar progressBarCam29 = new ProgressStackBar();
        private ProgressStackBar progressBarCam30 = new ProgressStackBar();
        private ProgressStackBar progressBarCam31 = new ProgressStackBar();
        private ProgressStackBar progressBarCam32 = new ProgressStackBar();
        private ProgressStackBar progressBarCam33 = new ProgressStackBar();
        private ProgressStackBar progressBarCam34 = new ProgressStackBar();
        private ProgressStackBar progressBarCam35 = new ProgressStackBar();
        private ProgressStackBar progressBarCam36 = new ProgressStackBar();









        public static frmMapa instance = null;

        public frmMapa(int opc, string nombre)
        {
            instance = this;
            InitializeComponent();                
            _points = new List<PointLatLng>();
            _pointsc = new List<PointLatLng>();
            _pointslc = new List<PointLatLng>();
            gopc = opc;
            gnombre = nombre;
        }

        private void frmMapa_Shown(object sender, EventArgs e)
        {
            //panelIniTablero();
            //panelTablero.Visible = true;
            splitContainerMapa.Visible = true;
            posicionBTN();
            fverPanelCamiones();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            carpeta_existe_local();

            tabControl1.Height = 0;

            this.Text = "Mapa " + "[" + gnombre + "]"; //Application.ProductName + " - Sistema Reparto Gusi - v" + Application.ProductVersion;

            splitContainerMapa.Dock = DockStyle.Fill;
            splitContainerMapa.Panel2Collapsed = true;
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl2.Dock = DockStyle.Fill;
            splitContainerMapas.Panel1Collapsed = true;

            this.Refresh();

            CamionInAct = imageListTruck.Images[1]; //imageList1.Images[2];//9//2
            CamionAct = imageListTruck.Images[0]; //imageList1.Images[6];//10//6

            tablaCamionTemp();
            tablaTallerTemp();
            tablaListaCamionTemp();
            tablaRepartoTemp();
            tablaLocalizaTemp();
            tablaCabezasTemp();
            tablaPlanesTemp();
            tablaRutaErrorTemp();

            //this.label35.Text = "D\na\nt\na\n";
            //this.label30.Text = "G\np\ns\n";

            llenaTablets();
            buscaCamiones2(false);

            //ip = obtenerConfig(0);

            if (ip.Equals("")) { ip = "0.0.0.0"; }

            txtFecha.Text = DateTime.Today.ToShortDateString();

            DataRow row = obtenerConfigDB();

            if (row != null)
            {
                latencia = row["Latencia"].ToString(); //obtenerConfigTxt(1);
                usuario = row["Usuario"].ToString(); //obtenerConfig(3);
                contrasena = row["contrasena"].ToString(); //obtenerConfig(4);
                inactividad = row["Inactividad"].ToString(); //obtenerConfig(5);
                rutared = row["RutaRed"].ToString(); //obtenerConfig(6);
                instancia = row["Instancia"].ToString(); //obtenerConfig(2);                                 //
            }

            lblTimer.Text = latencia;

            if (!latencia.Equals(""))
            {
                timerCamion.Interval = Convert.ToInt32(latencia) * 1000;
                //timerMonitor.Interval = Convert.ToInt32(latencia) * 1000;a
            }

            desdesap = "0";
            origenDatos(desdesap);

            lblip.Text = ip;
            lblLatencia.Text = latencia.ToString() + "seg";

            posPanelCam();
            //posicionBTN();
            


            cargaMapa(gMapControl1);
            cargaMapa(gMapControl2);

            vdt = new DataTable();

            variablesMapa();
            IniBarrasprogreso();


            LatInicial = 21.911191;
            LngInicial = -98.738904;

            LatActual = LatInicial;
            LngActual = LngInicial;

            timerCamion.Enabled = true;

            tablaUbicTemp();

            listaCamiones();
            
            //Thread t = new Thread(() => { listaCamiones(); });
            //t.Name = "flistaCamiones";
            //t.IsBackground = true;
            //t.Start();

            labelLeyendas.Visible = false;


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
            Principal.instance.toolStripMenuItem4.Visible = false;
            //btnCerrarPanel.Visible = true;
            //toolStripMenuItem5.Visible = true;
            //mostrarDatosWs();

            this.Refresh();

            switch (gopc)
            {
                case 1:
                    //chart2.Visible = true;
                    mostrarDatosWs();
                    timer();
                    servidaToolStripMenuItem_Click(sender, e);
                    //btnAbrirCerrarPanel.Visible = true;

                    //splitContainerMapa.Panel2Collapsed = false;
                    Principal.instance.toolStripMenuItem4.Visible = true; //2 mapas
                    break;
                case 2:
                    chart2.Visible = false;
                    chart3.Visible = false;
                    chart4.Visible = false;

                    indiceBotonVista = 0;
                    mostrarDatosWs();

                    toolStripButton15.Visible = true; //refresca cabezas
                    toolStripSplitButton3.Visible = false;
                    toolStripButton5.Visible = false;
                    toolStripLabel8.Visible = false;
                    toolStripButton16.Visible = false;
                    toolStripButton18.Visible = false;
                    toolStripButton21.Visible = false;
                    this.Refresh();

                    timerCamion.Stop();
                    cabezasToolStripMenuItem_Click(sender, e);
                    //menuBasico();

                    menuBuscarCamion(false);
                    menuRutas(false);

                    break;

                case 3:
                    //corralActividadInicio();
                    //dtCabezastmp.Rows.Clear();

                    chart2.Visible = false;
                    chart3.Visible = false;
                    chart4.Visible = false;
                    indiceBotonVista = 0;
                    mostrarDatosWs();

                    toolStripButton15.Visible = true; //refresca cabezas
                    toolStripSplitButton3.Visible = false;
                    toolStripButton5.Visible = false;
                    toolStripLabel8.Visible = false;
                    toolStripButton16.Visible = false;
                    toolStripButton18.Visible = false;
                    toolStripButton21.Visible = false;
                    this.Refresh();

                    timerCamion.Stop();
                    cabezasToolStripMenuItem_Click(sender, e);
                    //menuBasico();

                    menuBuscarCamion(false);
                    menuRutas(false);

                    //botonCeldasActividad(1);

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

            //this.Refresh();


            //this.WindowState = FormWindowState.Maximized;
            //this.Cursor = Cursors.Default;


            //////////////////////////////////////////////////////////////////////////////////////////

            //21.885035827,-98.732714653
            //21.9012825188,-98.7540006638


            //21.8934779666,-98.7249469757
            //21.9090468278,-98.7459754944


            //21.9021186955,-98.7417697906


            //_points.Clear();
            //_points.Add(new PointLatLng(21.9021186955, -98.7417697906));


            ////PointLatLng lPoint = new PointLatLng();
            ////lPoint.Lat = 21.9021186955;
            ////lPoint.Lng = -98.7417697906;

            //Point point = new Point(21.9021186955, -98.7417697906);

            //double North = 0;
            //double East = 0;
            //double South = 0;
            //double West = 0;

            //bool valor = PointInRectangle(_points, North, East, South, West);


            //servidaToolStripMenuItem_Click(sender,e);


            CopyGMapElements(gMapControl1, gMapControl2);

            panelTrack.Visible = true;

            Principal.instance.toolStripMenuItem8_Click(sender,e);
            //////////////////////////////////////////////////////////////////////////////////////////

            //picCamion04.Image = imageListCamiones.Images[5];
            //picCamion06.Image = imageListCamiones.Images[5];
            //picCamion07.Image = imageListCamiones.Images[5];
            //picCamion08.Image = imageListCamiones.Images[5];
            //picCamion09.Image = imageListCamiones.Images[5];


            //panelCam04.Visible = false;
            //panelCam06.Visible = false;
            //panelCam07.Visible = false;
            //panelCam08.Visible = false;
            //panelCam09.Visible = false;


            this.Refresh();
            this.Cursor = Cursors.Default;

            //fverPanelCamiones();
            inactivarNumCam();
            //panelReloj.Parent = gMapControl1;
            //DibujarRelojAnalogico(panelReloj);


           



        }

        private void variablesMapa()
        {

            overlayZonas = new GMapOverlay("zonas");
            gMapControl1.Overlays.Add(overlayZonas);

            overlayCeldas = new GMapOverlay("celdas");
            gMapControl1.Overlays.Add(overlayCeldas);

            overlayCeldas2 = new GMapOverlay("celdas2");
            gMapControl2.Overlays.Add(overlayCeldas2);

            overlayComederos = new GMapOverlay("comederos");
            gMapControl1.Overlays.Add(overlayComederos);

            overlayRecepcion = new GMapOverlay("recepciones");
            gMapControl1.Overlays.Add(overlayRecepcion);

            overlayTaller = new GMapOverlay("talleres");
            gMapControl1.Overlays.Add(overlayTaller);

            overlayPrensas = new GMapOverlay("prensas");
            gMapControl1.Overlays.Add(overlayPrensas);
            overlaylabelPrensas = new GMapOverlay("labelprensa");
            gMapControl1.Overlays.Add(overlaylabelPrensas);

            overlayEcoSec01 = new GMapOverlay("ecosec01");
            gMapControl1.Overlays.Add(overlayEcoSec01);

            overlayEcologicos = new GMapOverlay("ecologicos");
            gMapControl1.Overlays.Add(overlayEcologicos);

            overlaylabelCeldas = new GMapOverlay("labelceldas");
            gMapControl1.Overlays.Add(overlaylabelCeldas);

            overlaylabelCeldas2 = new GMapOverlay("labelceldas2");
            gMapControl2.Overlays.Add(overlaylabelCeldas2);

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

            overlayCamiones2 = new GMapOverlay("camiones2");
            gMapControl2.Overlays.Add(overlayCamiones2);


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

        private void corralActividadLimpia()
        {
            String colorcapa = cmbColorCapas.Text;
            Color vcolor = Color.White;

            switch (cmbColorCapas.SelectedIndex)
            {
                case 0:
                    vcolor = Color.White;
                    break;
                case 1:
                    vcolor = Color.Transparent;
                    break;

            }



            for (int i = 0; i < overlayCeldas.Polygons.Count; i++)
            {
                overlayCeldas.Polygons.ElementAt(i).Fill = new SolidBrush(vcolor);//White);
                overlayCeldas.Polygons.ElementAt(i).Tag = Color.White.Name;

                overlayCeldas2.Polygons.ElementAt(i).Fill = new SolidBrush(vcolor);//White);
                overlayCeldas2.Polygons.ElementAt(i).Tag = Color.White.Name;

            }

        }

        private void corralActividadMod(string nombre, Color color)
        {

            //llenarCabezasCorral();
            //if (dtCabezastmp.Rows.Count > 0)
            //{
            //    var cab = dtCabezastmp.Rows[0][7].ToString().Replace(".000", "");                
            //}


            for (int i = 0; i < overlayCeldas.Polygons.Count; i++)
            {

                if (overlayCeldas.Polygons.ElementAt(i).Name.Equals(nombre))
                {
                    overlayCeldas.Polygons.ElementAt(i).Fill = new SolidBrush(color);
                    overlayCeldas.Polygons.ElementAt(i).Tag = color.Name;
                }

                if (overlayCeldas2.Polygons.ElementAt(i).Name.Equals(nombre))
                {
                    overlayCeldas2.Polygons.ElementAt(i).Fill = new SolidBrush(color);
                    overlayCeldas2.Polygons.ElementAt(i).Tag = color.Name;
                }

            }

        }

        private Color corralColor(string nombre)
        {
            Color color = Color.Transparent;

            for (int i = 0; i < overlayCeldas.Polygons.Count; i++)
            {

                if (overlayCeldas.Polygons.ElementAt(i).Name.Equals(nombre))
                {

                    Brush brush = overlayCeldas.Polygons.ElementAt(i).Fill;
                    SolidBrush solidbrush = (SolidBrush)brush;
                    color = solidbrush.Color;

                }

            }

            return color;

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

        private void tablaLocalizaTemp()
        {

            dtLocalizatmp = new DataTable();

            dtLocalizatmp.Columns.Add("numcamion");
            dtLocalizatmp.Columns.Add("name");
            dtLocalizatmp.Columns.Add("fecha");
            dtLocalizatmp.Columns.Add("hora");
            dtLocalizatmp.Columns.Add("lat");
            dtLocalizatmp.Columns.Add("lng");
            dtLocalizatmp.Columns.Add("racion");
            dtLocalizatmp.Columns.Add("servida");
            dtLocalizatmp.Columns.Add("pila");
            dtLocalizatmp.Columns.Add("red");
            dtLocalizatmp.Columns.Add("velocidad");



        }

        private void tablaRutaErrorTemp()
        {

            dtRutaErrortmp = new DataTable();

            dtRutaErrortmp.Columns.Add("texto");
            dtRutaErrortmp.Columns.Add("lat");
            dtRutaErrortmp.Columns.Add("lng");

        }

        private void corralesActividadNombre()
        {
            FlushMemory();

            if (overlayCeldas != null)
            {
                overlaylabelCeldas.Markers.Clear();
                //overlayCeldas.Markers.Clear(); //aqui
                //overlaylabelCeldas2.Markers.Clear();

                for (int i = 0; i < overlayCeldas.Polygons.Count; i++)
                {
                    //corralActividadNombre(overlayCeldas.Polygons.ElementAt(i).Name, overlayCeldas.Polygons.ElementAt(i).Points, Color.White);

                    corralActividadNombres(overlayCeldas.Polygons.ElementAt(i), "", Color.Black, markerlabelCelda, overlaylabelCeldas);
                    //corralActividadNombres(overlayCeldas2.Polygons.ElementAt(i), "", Color.White);

                }

            }


            if (overlayPrensas != null)
            {
                overlaylabelPrensas.Markers.Clear();


                for (int i = 0; i < overlayPrensas.Polygons.Count; i++)
                {
                    corralActividadNombres(overlayPrensas.Polygons.ElementAt(i), "", Color.White, markerlabelPrensas, overlaylabelPrensas);
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
                //overlaylabelCeldas2.Markers.Clear();

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

                    corralActividadNombres(overlayCeldas.Polygons.ElementAt(i), valor, Color.Black, markerlabelCelda, overlaylabelCeldas);
                    //corralActividadNombres(overlayCeldas2.Polygons.ElementAt(i), valor, Color.White);


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

        private void prensaActividad(string nombre, List<PointLatLng> points, Color color, bool visible)
        {            

            polygonPrensas = new GMapPolygon(points, nombre)
            {
                Stroke = new Pen(Color.Black, 2),
                Fill = new SolidBrush(Color.FromArgb(200, color)), //Brushes.Transparent,
                Tag = nombre,
                IsVisible = visible
            };

            overlayPrensas.Polygons.Add(polygonPrensas);
            
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

        private void tallerActividad(string nombre, List<PointLatLng> points, Color color, bool visible)
        {

            polygonTaller = new GMapPolygon(points, nombre)
            {
                Stroke = new Pen(Color.Black, 2),
                Fill = new SolidBrush(Color.FromArgb(100, color)), //Brushes.Transparent,
                Tag = nombre,
                IsVisible = visible
            };

            overlayTaller.Polygons.Add(polygonTaller);

        }

        private void ecologicosSec01Actividad(string nombre, List<PointLatLng> points, Color color, bool visible)
        {

            polygonEcoSec01 = new GMapPolygon(points, nombre)
            {
                Stroke = new Pen(Color.Black, 2),
                Fill = new SolidBrush(Color.FromArgb(100, color)), //Brushes.Transparent,
                Tag = nombre,
                IsVisible = visible
            };

            overlayEcoSec01.Polygons.Add(polygonEcoSec01);

        }

        private void ecologicosActividad(string nombre, List<PointLatLng> points, Color color, bool visible)
        {

            polygonEcologicos = new GMapPolygon(points, nombre)
            {
                Stroke = new Pen(Color.Black, 2),
                Fill = new SolidBrush(Color.FromArgb(100, color)), //Brushes.Transparent,
                Tag = nombre,
                IsVisible = visible
            };

            overlayEcologicos.Polygons.Add(polygonEcologicos);

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
            graphicImage.DrawString(nombre, new Font("Tamoha", tamano, FontStyle.Regular), SystemBrushes.WindowText, new Point(5, 37));
            graphicImage.Dispose();

            PointLatLng centerPoint = GetZoneCenter(points);

            centerPoint.Lat -= 0.000000;
            centerPoint.Lng += 0.000000;

            markerlabelCelda = new GMarkerGoogle(centerPoint, bmpmarker);
            overlaylabelCeldas.Markers.Add(markerlabelCelda);

            //markerlabelCelda2 = new GMarkerGoogle(centerPoint, bmpmarker);
            //overlaylabelCeldas2.Markers.Add(markerlabelCelda2);


        }

        private void corralActividadNombres(GMapPolygon polygon, string valor, Color color, GMarkerGoogle vmarkerlabelCelda, GMapOverlay voverlaylabelCeldas)
        {

            int tamano = 8+3;
            int ancho = 40;
            int alto = 22+2; //11;

            int tmin = trackBar1.Minimum;
            int ttam = trackBar1.Value - tmin;

            if (ttam >= 0 && ttam <= 1) { return; }

            //tamano = Convert.ToInt32(Math.Pow(2,ttam+1));
            //lblErrores.Text = "escala"+ttam.ToString()+",letra:"+tamano.ToString() + ",a" + ancho.ToString() + ",h" + alto.ToString();


            //valor = "";

            Bitmap bmpmarker = new Bitmap(ancho, alto);
            Graphics graphicImage = Graphics.FromImage(bmpmarker);
            graphicImage.SmoothingMode = SmoothingMode.AntiAlias;
            Brush textBrush = new SolidBrush(color);
            //texto nombre corrales
            graphicImage.DrawString(valor, new Font("Calibri", tamano, FontStyle.Regular), SystemBrushes.WindowText, new Point(3, 0));
            graphicImage.DrawString(polygon.Name, new Font("Calibri", tamano, FontStyle.Regular), textBrush, new Point(0+3, 10));
            graphicImage.Dispose();


            PointLatLng centerPoint = GetZoneCenter(polygon.Points);

            double p1 = 0, p2 = 0;


            PointLatLng adjustedCenterPoint = new PointLatLng(centerPoint.Lat + p1, centerPoint.Lng + p2);

            //double dist = getDistancia(polygon.Points.ElementAt(0).Lat, polygon.Points.ElementAt(0).Lng, centerPoint.Lat, centerPoint.Lng);
            //lblErrores.Text = dist.ToString();

            //PointLatLng ladoPoint = new PointLatLng();

            //int p1 = 0, p2 = 0;

            //switch (gorientacion)
            //{
            //    case 0:
            //        p1 = 2;
            //        p2 = 3;
            //        break;
            //    case 1:
            //        p1 = 2;
            //        p2 = 0;
            //        break;
            //    case 2:
            //        p1 = 0;
            //        p2 = 1;
            //        break;
            //    case 3:
            //        p1 = 1;
            //        p2 = 2;
            //        break;
            //}

            //ladoPoint.Lat = (polygon.Points.ElementAt(p1).Lat + polygon.Points.ElementAt(p2).Lat) / 2;
            //ladoPoint.Lng = (polygon.Points.ElementAt(p1).Lng + polygon.Points.ElementAt(p2).Lng) / 2;

            //if (ttam == 2 && valor.Length > 0)
            //{
            //    markerlabelCelda = new GMarkerGoogle(ladoPoint, bmpmarker);
            //markerlabelCelda2 = new GMarkerGoogle(ladoPoint, bmpmarker);
            //}
            //else
            //{
            vmarkerlabelCelda = new GMarkerGoogle(adjustedCenterPoint, bmpmarker);
            //    //markerlabelCelda2 = new GMarkerGoogle(centerPoint, bmpmarker);
            //}

            vmarkerlabelCelda.Tag = polygon.Name;
            voverlaylabelCeldas.Markers.Add(vmarkerlabelCelda);

            //markerlabelCelda2.Tag = polygon.Name;
            //overlaylabelCeldas2.Markers.Add(markerlabelCelda2);


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

            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);

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

        private void cargaMapa(GMapControl gmap)
        {

            GMaps.Instance.Mode = modoAcceso(instancia);
            //gMapControl1.Manager.Mode = modoAcceso(instancia);
            gmap.CacheLocation = @"mapa";


            gmap.Position = new PointLatLng(LatInicial, LngInicial);
            //gMapControl1.MaspProvider = GMapProviders.GoogleMap;
            gmap.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
            //gMapControl1.MapProvider = GMapProviders.GoogleChinaHybridMap;

            gmap.DragButton = MouseButtons.Left;
            gmap.CanDragMap = true;

            gmap.MaxZoom = 20;
            gmap.MinZoom = 15;

            gmap.Zoom = 17;
            gmap.Bearing = -140;//-50;
            gmap.AutoScroll = true;

            trackBar1.Value = Convert.ToInt32(gmap.Zoom);
            //lblCoordenadas.Text = "lat= " + Convert.ToString(LatInicial) + "   long= " + Convert.ToString(LngInicial);
            lblCoordenadas.Text = Convert.ToString(LatInicial) + "," + Convert.ToString(LngInicial);

            Principal.instance.toolStripTextBox1.Text = lblCoordenadas.Text;
         
        }

        private void tablaCamionTemp()
        {

            dtCamiontmp = new DataTable();

            dtCamiontmp.Columns.Add("id");
            dtCamiontmp.Columns.Add("name");
            dtCamiontmp.Columns.Add("tipo");

        }

        private void tablaTallerTemp()
        {

            dtTallertmp = new DataTable();

            dtTallertmp.Columns.Add("id");
            dtTallertmp.Columns.Add("name");
            dtTallertmp.Columns.Add("fecha");
            dtTallertmp.Columns.Add("mtto");


        }

        private void tablaListaCamionTemp()
        {

            dtListaCamiontmp = new DataTable();

            dtListaCamiontmp.Columns.Add("id");
            dtListaCamiontmp.Columns.Add("name");

            dtListaCamiontmp.Columns.Add("zona");            
            dtListaCamiontmp.Columns.Add("centroam");
            dtListaCamiontmp.Columns.Add("centropm");
            dtListaCamiontmp.Columns.Add("recepcion");


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

        private void tablaPlanesTemp()
        {
            dtPlanestmp = new DataTable();
            dtPlanestmp.Columns.Add("corral");
        }

        private void listaCamiones()
        {

            DataTable dt = new DataTable();

            leerWsdlListaCamion(ref dt);
            //leerWsListaCamion(ref dt);

            if(dt==null) { return; }
            if (dt.Rows.Count == 0) { return; }

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

                newRow["zona"] = row["zona"].ToString();
                newRow["centroam"] = row["centroam"].ToString();
                newRow["centropm"] = row["centropm"].ToString();
                newRow["recepcion"] = row["recepcion"].ToString();

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

            Bitmap bmpmarker = new Bitmap(CamionAct); //imagen camion

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

        private void agregaractualizarMarcadorLocalizaCamion(string id, string name, string fecha, string hora, double lat, double lng, string racion, string servida, string total_corral, string faltan_serv, int carga_actual, string pila, string velocidad)
        {
            
            string horaAct = DateTime.Now.ToString("HH") + ":" + DateTime.Now.ToString("mm") + ":" + DateTime.Now.ToString("ss");
            DateTime hora1 = Convert.ToDateTime(hora);
            DateTime hora2 = Convert.ToDateTime(horaAct);
            TimeSpan demora = hora2.Subtract(hora1).Duration();
            Image vimg = null;
            bool vActivo = false;

            //FlushMemory();

            if (id == "14")
            {
                var a = 1;
            }

            //////////////////////////
            if (carga_actual < 0) { carga_actual = 0; }
            if (total_corral == "") total_corral = "0-0";
            if (faltan_serv == "") faltan_serv = "0-0";
            string[] satc = total_corral.Split('-');
            string[] safs = faltan_serv.Split('-');
            double total_carga = 18000;

            //pogressLimpiaCamionNum(id);
            //pogressCamionNum(id, servida, sa1, sa2);
            ///////////////////////////

            if (demora.TotalMinutes <= Convert.ToDouble(inactividad))
            {
                //activo
                vActivo = true;
                vimg = CamionAct;
                mostrarCamionActivo(id, true);
            }
            else
               //if (demora.TotalMinutes > Convert.ToDouble(inactividad)
               // && demora.TotalMinutes <= Convert.ToDouble(inactividad) + 120
               // )
            {
                //inactivo
                vimg = CamionInAct;
                mostrarCamionActivo(id, false);

                pogressLimpiaCamionNum(id);
            }

            if (lat == 0)
            {
                vimg = CamionInAct;
                mostrarCamionActivo(id, false);
                pogressLimpiaCamionNum(id);
                //pogressCamionNum(id, servida, satc, safs);
                return;
            }

            if (vimg != null) 
            { 

                Bitmap bmpmarker = new Bitmap(vimg); //imagen camion

                //SolidBrush drawBrush = new SolidBrush(Color.White); //White //color numero camion
                Graphics graphicImage = Graphics.FromImage(bmpmarker);
                graphicImage.SmoothingMode = SmoothingMode.AntiAlias;

                //if (carga_actual < 0) { carga_actual = 0; }
                //if (total_corral == "") total_corral = "0-0";
                //if (faltan_serv == "") faltan_serv = "0-0";
                //string[] sa1 = total_corral.Split('-');
                //string[] sa2 = faltan_serv.Split('-');
                //double total_carga = 18000;

                if (vActivo)
                {
                    graphicImage = drawBarraV(graphicImage, bmpmarker, carga_actual, total_carga, 0, 18, 18, 34);

                    //var v1 = velocidad.TrimStart('0');
                    //var vel1 = Convert.ToDouble(string.IsNullOrEmpty(velocidad.TrimStart('0')) ? "0" : velocidad.TrimStart('0'));
                    //var i = Convert.ToInt32(Math.Round(vel1, 0));
                    //var k = ConvertirNudosAKilometros(vel1);
                    //var e = Convert.ToInt32(Math.Round(k, 0));
                    //if (vel1 != 0)
                    //{
                    //    graphicImage = drawBarraH(graphicImage, bmpmarker, e, 30, 23, 18, 17, 10);

                    //    graphicImage = drawEtiqueta(graphicImage, e.ToString() + "v", 7, Color.White, 25, 13);
                    //    //graphicImage = drawEtiqueta(graphicImage, vel1.ToString(), 9, Color.White, 28, 22-10);

                    //}
   
                    graphicImage = drawPie(graphicImage, bmpmarker, servida, satc, safs, 6, 20 - 0);
                    graphicImage = drawStop(graphicImage, bmpmarker, velocidad, 8, 22 - 0);

                    if (safs[0] != "0")
                    {
                        pogressCamionNum(id, servida, satc, safs);
                    }
                    else
                    {
                        string[] sa1a = { "100", "0" };
                        string[] sa2a = { "0", "0" };
                        pogressCamionNum(id, servida, sa1a, sa2a);
                        //pogressLimpiaCamionNum(id);
                    }
                }
                else
                {
                    //if (safs[0]!="0")
                    //{
                    //    pogressCamionNum(id, servida, satc, safs);
                    //}
                    //else
                    //{
                        pogressLimpiaCamionNum(id);
                    //}
                }

                if (!vActivo)
                {
                    string formatoH = $"{(int)demora.TotalHours}h {demora.Minutes}min";
                    graphicImage = drawEtiqueta(graphicImage, formatoH, 9, Color.White, 3, 3);
                }                    

                graphicImage = drawEtiqueta(graphicImage, id.PadLeft(2, '0'), 15, Color.White, 6, 24-0);
                string vracion = racion.Length >= 4 ? racion.Substring(0, 4) : racion;
                graphicImage = drawEtiqueta(graphicImage, (vracion /*+ " " + Math.Round((double)carga_actual / 1000.0, 1) + "t"*/), 7, Color.White, -2 + 34, -2 + 44);
                var p = Math.Round((double)carga_actual / 1000.0, 0);
                
                graphicImage = drawPila(graphicImage, bmpmarker, pila);

                Color colorLetra = Color.White;
                //if (p>11)
                //{
                //    //colorLetra = Color.Black;
                //}
                graphicImage = drawEtiqueta(graphicImage, p + "t", 7, colorLetra, -1, 13);



                graphicImage.Dispose();
                markerCamion = new GMarkerGoogle(new PointLatLng(lat, lng), bmpmarker);
                markerCamion.ToolTipMode = MarkerTooltipMode.OnMouseOver;//.Always;
                markerCamion.ToolTipText = string.Format("S{3}, {2}, {1}, Carga {5} kg", name, hora, racion, servida, id, carga_actual);
                overlayCamiones.Markers.Add(markerCamion);

            }
            else
            {
                vimg = CamionInAct;
                mostrarCamionActivo(id, false);
            }

        }

        Graphics drawPie(Graphics graphicImage, Bitmap bmpmarker, string servida, string[] sa1, string[] sa2, int x, int y)
        {

            double vtotal_corral = Convert.ToDouble(sa1[0]);
            double vfaltan_serv = Convert.ToDouble(sa2[0]);

            double percentComplete = vtotal_corral > 0 ? (double)(vtotal_corral - vfaltan_serv) / (vtotal_corral) : 0;
            double degreesComplete = vtotal_corral > 0 ? ((double)(vtotal_corral - vfaltan_serv) / vtotal_corral) * 360 - 360 : 0;

            float anguloIni = 270;

            var colorBarr = Color.FromArgb(200, Color.Transparent);
            colorBarr = colorCamion;

            graphicImage.FillPie(
                new SolidBrush(colorBarr), // Pen to draw the pie
                new Rectangle(x, y, 30, 30), // Rectangle defining the bounds of the pie
                anguloIni, // Start angle in degrees
                360 // Sweep angle in degrees
            );

            var vColor = Color.Lime;

            switch (servida)
            {
                case "1":
                    vColor = Color.Orange;
                    break;
                case "2":
                    vColor = Color.Lime;
                    break;
            }

            graphicImage.DrawPie(
                new Pen(vColor, 3), // Pen to draw the pie
                new Rectangle(x, y, 30, 30), // Rectangle defining the bounds of the pie
                anguloIni, // Start angle in degrees
                (float)degreesComplete // Sweep angle in degrees
            );

            var colorVel = colorCamion;
            //colorVel = Color.Black;
            //double vel = 0;
            //Double.TryParse(velocidad ?? "0", out vel);

            //if (vel > 0.0 && vel < 0.9)
            //{
            //    colorVel = Color.Red;
            //}

            graphicImage.FillPie(
                new SolidBrush(colorVel), // Pen to draw the pie
                new Rectangle(x + 2, y + 2, 30 - 4, 30 - 4), // Rectangle defining the bounds of the pie
                anguloIni, // Start angle in degrees
                360 // Sweep angle in degrees
            );

            return graphicImage;

        }

        Graphics drawStop(Graphics graphicImage, Bitmap bmpmarker, string velocidad, int x, int y)
        {

            float anguloIni = 270;

            var colorVel = colorCamion;
            //colorVel = Color.Black;
            double vel = 0;
            Double.TryParse(velocidad ?? "0", out vel);

            if (vel > 0.0 && vel < 0.1)
            {
                colorVel = Color.Red;
            }
            if (vel >= 0.1 && vel < 16.0)
            {
                //colorVel = Color.Blue;
            }
            if (vel >= 16.0)
            {
                //colorVel = Color.Blue;
            }

            //60km = 32.42 nudos
            //50km = 27.02 nudos
            //40km = 21.61 nudos
            
            //33km = 18.00 nudos

            //30km = 16.20 nudos
            //20km = 10.80 nudos
            //10km =  5.40 nudos
            // 5km =  2.70 nudos


            int v = 1;

            graphicImage.FillPie(
                new SolidBrush(colorVel), // Pen to draw the pie
                new Rectangle(x + v, y + v, 27 - v*2, 27 - v*2), // Rectangle defining the bounds of the pie
                anguloIni, // Start angle in degrees
                360 // Sweep angle in degrees
            );

            return graphicImage;

        }

        //Graphics drawBarraH(Graphics graphicImage, Bitmap bmpmarker, int actual, double total, int x, int y)
        //{

        //    int alturaBarr = 10;

        //    Rectangle rect = new Rectangle(x, y, bmpmarker.Width / 2, alturaBarr);
        //    graphicImage.FillRectangle(new SolidBrush(Color.FromArgb(200, Color.Black)), rect);

        //    double percentComplete2 = total > 0 ? (double)(actual) / total : 0;
        //    int progressWidth = (int)(bmpmarker.Width * percentComplete2 / 2);
        //    Rectangle progressRect = new Rectangle(x, y, progressWidth, alturaBarr - 0);
        //    graphicImage.FillRectangle(new SolidBrush(Color.FromArgb(200, Color.Yellow)), progressRect);

        //    return graphicImage;

        //}

        Graphics drawBarraH(Graphics graphicImage, Bitmap bmpmarker, int actual, double total, int left, int top, int width, int height)
        {
            int margenDerecha = bmpmarker.Width - width - left;
            Rectangle rect = new Rectangle(
                bmpmarker.Width - width - margenDerecha,
                top,
                width,
                height
            );
            Color vColor = colorCamion;
            vColor = Color.FromArgb(200, Color.Black);
            graphicImage.FillRectangle(new SolidBrush(vColor), rect);

            double percentComplete2 = total > 0 ? (double)(actual) / total : 0;
            int progressWidth = (int)(width * percentComplete2);

            Rectangle progressRect = new Rectangle(
                bmpmarker.Width - width - margenDerecha,
                top,
                progressWidth,
                height
            );

            Color colorCarga = Color.Yellow;
            if (actual > total)
            {
                colorCarga = Color.Red;
            }
            graphicImage.FillRectangle(new SolidBrush(Color.FromArgb(250, colorCarga)), progressRect);

            return graphicImage;
        }

        Graphics drawBarraV(Graphics graphicImage, Bitmap bmpmarker, int actual, double total, int left, int top, int width, int height)
        {

            int margenDerecha = bmpmarker.Width - width - left;

            Rectangle rect = new Rectangle(
                bmpmarker.Width - width - margenDerecha,
                top,
                width,
                height
            );

            Color vColor = colorCamion;
            vColor = Color.FromArgb(200, Color.Black);

            graphicImage.FillRectangle(new SolidBrush(vColor), rect);

            double percentComplete2 = total > 0 ? (double)(actual) / total : 0;
            int progressHeight = (int)(height * percentComplete2);

            Rectangle progressRect = new Rectangle(
                bmpmarker.Width - width - margenDerecha,
                height - progressHeight + top,
                width,
                progressHeight
            );

            Color colorCarga = Color.MediumOrchid;
            if (actual > total)
            {
                colorCarga = Color.Red;
            }

            graphicImage.FillRectangle(new SolidBrush(Color.FromArgb(250, colorCarga)), progressRect);

            return graphicImage;
        }


        Graphics drawPila(Graphics graphicImage, Bitmap bmpmarker, string pila)
        {
            Rectangle rect2 = new Rectangle(40 + 5, bmpmarker.Height - 19 + 6, 11-5, 5);
            if (!pila.Contains("~"))
            {
                graphicImage.FillRectangle(new SolidBrush(Color.FromArgb(150 + 100, Color.Yellow)), rect2);
            }
            return graphicImage;                
        }

        Graphics drawEtiqueta(Graphics graphicImage, string texto, float emsize, Color color, int x, int y)
        {
            graphicImage.DrawString(texto,
            new Font("Courier", emsize, FontStyle.Bold),
            new SolidBrush(color),
            new Point(x, y));

            return graphicImage;
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

        void pogressCamionNum(string id, string servida, string[] sa1, string[] sa2)
        {

            double vtotal_corral = Convert.ToDouble(sa1[0]);
            double vfaltan_serv = Convert.ToDouble(sa2[0]);
            double percentComplete = vtotal_corral > 0 ? (double)(vtotal_corral - vfaltan_serv) / (vtotal_corral) : 0;
            var vColor = Color.Lime;

            if (id == "19")
            {
                var a = 1;
            }

            var vColorSinColor = Color.White;
            if (vfaltan_serv != 0)
            {
                vColorSinColor = Color.FromArgb(180, Color.Black);
            }

            switch (servida)
            {
                case "1":
                    vColor = Color.Orange;
                    break;
                case "2":
                    vColor = Color.Lime;
                    break;
            }

            switch (id)
            {
                case "1":
                    progressBarCam01.ClearSegments();
                    progressBarCam01.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam01.AddSegment("", percentComplete, vColorSinColor);
                    break;
                case "2":
                    progressBarCam02.ClearSegments();
                    progressBarCam02.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam02.AddSegment("", percentComplete, vColorSinColor);
                    break;
                case "3":
                    progressBarCam03.ClearSegments();
                    progressBarCam03.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam03.AddSegment("", percentComplete, vColorSinColor);
                    break;
                case "12":
                    progressBarCam12.ClearSegments();
                    progressBarCam12.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam12.AddSegment("", percentComplete, vColorSinColor);
                    break;
                case "13":
                    progressBarCam13.ClearSegments();
                    progressBarCam13.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam13.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "14":
                    progressBarCam14.ClearSegments();
                    progressBarCam14.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam14.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "15":
                    progressBarCam15.ClearSegments();
                    progressBarCam15.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam15.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "16":
                    progressBarCam16.ClearSegments();
                    progressBarCam16.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam16.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "17":
                    progressBarCam17.ClearSegments();
                    progressBarCam17.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam17.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "18":
                    progressBarCam18.ClearSegments();
                    progressBarCam18.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam18.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "19":
                    progressBarCam19.ClearSegments();
                    progressBarCam19.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam19.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "20":
                    progressBarCam20.ClearSegments();
                    progressBarCam20.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam20.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "21":
                    progressBarCam21.ClearSegments();
                    progressBarCam21.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam21.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "22":
                    progressBarCam22.ClearSegments();
                    progressBarCam22.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam22.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "23":
                    progressBarCam23.ClearSegments();
                    progressBarCam23.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam23.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "24":
                    progressBarCam24.ClearSegments();
                    progressBarCam24.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam24.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "25":
                    progressBarCam25.ClearSegments();
                    progressBarCam25.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam25.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "26":
                    progressBarCam26.ClearSegments();
                    progressBarCam26.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam26.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "27":
                    progressBarCam27.ClearSegments();
                    progressBarCam27.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam27.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "28":
                    progressBarCam28.ClearSegments();
                    progressBarCam28.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam28.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "29":
                    progressBarCam29.ClearSegments();
                    progressBarCam29.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam29.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "30":
                    progressBarCam30.ClearSegments();
                    progressBarCam30.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam30.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "31":
                    progressBarCam31.ClearSegments();
                    progressBarCam31.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam31.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "32":
                    progressBarCam32.ClearSegments();
                    progressBarCam32.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam32.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "33":
                    progressBarCam33.ClearSegments();
                    progressBarCam33.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam33.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "34":
                    progressBarCam34.ClearSegments();
                    progressBarCam34.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam34.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "35":
                    progressBarCam35.ClearSegments();
                    progressBarCam35.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam35.AddSegment("", percentComplete, vColorSinColor);
                    break;

                case "36":
                    progressBarCam36.ClearSegments();
                    progressBarCam36.AddSegment("", 1 - percentComplete, vColor);
                    progressBarCam36.AddSegment("", percentComplete, vColorSinColor);
                    break;

            }




        }

        void pogressLimpiaCamionNum(string id)
        {


            switch (id)
            {
                case "1":
                    progressBarCam01.ClearSegments();
                    break;
                case "2":
                    progressBarCam02.ClearSegments();
                    break;
                case "3":
                    progressBarCam03.ClearSegments();
                    break;
                case "12":
                    progressBarCam12.ClearSegments();
                    break;
                case "13":
                    progressBarCam13.ClearSegments();
                    break;
                case "14":
                    progressBarCam14.ClearSegments();
                    break;

                case "15":
                    progressBarCam15.ClearSegments();
                    break;

                case "16":
                    progressBarCam16.ClearSegments();
                    break;

                case "17":
                    progressBarCam17.ClearSegments();
                    break;

                case "18":
                    progressBarCam18.ClearSegments();
                    break;

                case "19":
                    progressBarCam19.ClearSegments();
                    break;

                case "20":
                    progressBarCam20.ClearSegments();
                    break;

                case "21":
                    progressBarCam21.ClearSegments();
                    break;

                case "22":
                    progressBarCam22.ClearSegments();
                    break;

                case "23":
                    progressBarCam23.ClearSegments();
                    break;

                case "24":
                    progressBarCam24.ClearSegments();
                    break;

                case "25":
                    progressBarCam25.ClearSegments();
                    break;

                case "26":
                    progressBarCam26.ClearSegments();
                    break;

                case "27":
                    progressBarCam27.ClearSegments();
                    break;

                case "28":
                    progressBarCam28.ClearSegments();
                    break;

                case "29":
                    progressBarCam29.ClearSegments();
                    break;

                case "30":
                    progressBarCam30.ClearSegments();
                    break;

                case "31":
                    progressBarCam31.ClearSegments();
                    break;

                case "32":
                    progressBarCam32.ClearSegments();
                    break;

                case "33":
                    progressBarCam33.ClearSegments();
                    break;

                case "34":
                    progressBarCam34.ClearSegments();
                    break;

                case "35":
                    progressBarCam35.ClearSegments();
                    break;

                case "36":
                    progressBarCam36.ClearSegments();
                    break;

            }




        }

        private void agregarZona()
        {

            _points.Clear();
            _points.Add(new PointLatLng(21.898814, -98.745546));
            _points.Add(new PointLatLng(21.902557, -98.750396));
            _points.Add(new PointLatLng(21.907613, -98.746061));
            _points.Add(new PointLatLng(21.903632, -98.74104));

            zonaActividad("Zona1", _points, Color.Blue);


            _points.Clear();
            _points.Add(new PointLatLng(21.894075, -98.743465));
            _points.Add(new PointLatLng(21.897002, -98.74707));
            _points.Add(new PointLatLng(21.902039, -98.742328));
            _points.Add(new PointLatLng(21.899371, -98.73883));

            zonaActividad("Zona2", _points, Color.Red);


            _points.Clear();
            _points.Add(new PointLatLng(21.892074, -98.73957));
            _points.Add(new PointLatLng(21.894782, -98.742886));
            _points.Add(new PointLatLng(21.899302, -98.738852));
            _points.Add(new PointLatLng(21.896524, -98.735397));

            zonaActividad("Zona3", _points, Color.Green);


            _points.Clear();
            _points.Add(new PointLatLng(21.889396, -98.736105));
            _points.Add(new PointLatLng(21.892005, -98.739474));
            _points.Add(new PointLatLng(21.898057, -98.733938));
            _points.Add(new PointLatLng(21.89535, -98.730569));

            zonaActividad("Zona4", _points, Color.Yellow);


        }

        private void agregarPrensas()
        {            

            Color colorprensa = Color.Brown;

            if (gopc != 1)
            {
                return;
            }

            _pointsc.Clear();

            _pointsc.Add(new PointLatLng(21.889712416, -98.7341684103));
            _pointsc.Add(new PointLatLng(21.890391865, -98.7350401282));
            _pointsc.Add(new PointLatLng(21.890556127, -98.7348926067));
            _pointsc.Add(new PointLatLng(21.8898766787, -98.7340182066));

            prensaActividad("P 10", _pointsc, colorprensa, true);

            _pointsc.Clear();

            _pointsc.Add(new PointLatLng(21.8937815955,-98.7365421653));
            _pointsc.Add(new PointLatLng(21.894244504, -98.7371402979));
            _pointsc.Add(new PointLatLng(21.8944112502, -98.7369954586));
            _pointsc.Add(new PointLatLng(21.8939433648, -98.7363919616));

            prensaActividad("P 9", _pointsc, colorprensa, true);

            _pointsc.Clear();

            _pointsc.Add(new PointLatLng(21.8959791531, -98.740195334));
            _pointsc.Add(new PointLatLng(21.8966635497, -98.7410858274));
            _pointsc.Add(new PointLatLng(21.8968327818, -98.7409302592));
            _pointsc.Add(new PointLatLng(21.8961434086, -98.7400504947));

            prensaActividad("P 8", _pointsc, colorprensa, true);

            _pointsc.Clear();

            _pointsc.Add(new PointLatLng(21.8987117425, -98.7437036633));
            _pointsc.Add(new PointLatLng(21.899396126, -98.7445700169));
            _pointsc.Add(new PointLatLng(21.8995678435, -98.7444117665));
            _pointsc.Add(new PointLatLng(21.8988759948, -98.7435480952));

            prensaActividad("P 7", _pointsc, colorprensa, true);

            _pointsc.Clear();

            _pointsc.Add(new PointLatLng(21.9031639094, -98.7446987629));
            _pointsc.Add(new PointLatLng(21.9038507601, -98.7455758452));
            _pointsc.Add(new PointLatLng(21.9039975865, -98.7454363704));
            _pointsc.Add(new PointLatLng(21.9033132251, -98.744559288));

            prensaActividad("P 6", _pointsc, colorprensa, true);

            _pointsc.Clear();

            _pointsc.Add(new PointLatLng(21.9033480654, -98.7445297837));
            _pointsc.Add(new PointLatLng(21.9040274495, -98.7454175949));
            _pointsc.Add(new PointLatLng(21.9041767642, -98.7452727556));
            _pointsc.Add(new PointLatLng(21.9034948922, -98.7444010377));

            prensaActividad("P 5", _pointsc, colorprensa, true);




            _pointsc.Clear();

            _pointsc.Add(new PointLatLng(21.9273659333, -98.7445056438));
            _pointsc.Add(new PointLatLng(21.9267886761, -98.7450367212));
            _pointsc.Add(new PointLatLng(21.9268956679, -98.7451627851));
            _pointsc.Add(new PointLatLng(21.9274555075, -98.7446558475));

            prensaActividad("P 4", _pointsc, colorprensa, true);

            _pointsc.Clear();

            _pointsc.Add(new PointLatLng(21.9258083287, -98.7414103746));
            _pointsc.Add(new PointLatLng(21.9259825026, -98.7416303158));
            _pointsc.Add(new PointLatLng(21.9266493378, -98.7410402298));
            _pointsc.Add(new PointLatLng(21.9264801411, -98.7408149242));

            prensaActividad("P 3", _pointsc, colorprensa, true);

            _pointsc.Clear();

            _pointsc.Add(new PointLatLng(21.9214588889, -98.7456214428));
            _pointsc.Add(new PointLatLng(21.921623115, -98.7458360195));
            _pointsc.Add(new PointLatLng(21.9223148532, -98.7452030182));
            _pointsc.Add(new PointLatLng(21.9221506279, -98.7449884415));

            prensaActividad("P 2", _pointsc, colorprensa, true);

            _pointsc.Clear();

            _pointsc.Add(new PointLatLng(21.9192343529, -98.7477242947));
            _pointsc.Add(new PointLatLng(21.9193985815, -98.747933507));
            _pointsc.Add(new PointLatLng(21.9198514536, -98.7475258112));
            _pointsc.Add(new PointLatLng(21.919692202, -98.7473058701));

            prensaActividad("P 1", _pointsc, colorprensa, true);



        }


        private void agregarTalleres()
        {

            if (gopc != 1)
            {
                return;
            }

            _pointsc.Clear();
            _pointsc.Add(new PointLatLng(21.9206004311, -98.7474641204));
            _pointsc.Add(new PointLatLng(21.9215136309, -98.7486469746));

            _pointsc.Add(new PointLatLng(21.9221282335, -98.7478905916));
            _pointsc.Add(new PointLatLng(21.921244897, -98.7468767166));


            tallerActividad("Taller 1", _pointsc, Color.Transparent, false);

        }

        private void agregarEcoSec01()
        {

            if (gopc != 1)
            {
                return;
            }

            _pointsc.Clear();

            _pointsc.Add(new PointLatLng(21.8986793897, -98.745573163));
            _pointsc.Add(new PointLatLng(21.9026761439, -98.7507176399));
            _pointsc.Add(new PointLatLng(21.9077727138, -98.7462329865));
            _pointsc.Add(new PointLatLng(21.903671582, -98.7410616875));
            _pointsc.Add(new PointLatLng(21.9020788777, -98.7423920631));
            _pointsc.Add(new PointLatLng(21.9003866098, -98.7439799309));

            ecologicosSec01Actividad("Eco Sec 1", _pointsc, Color.Black, false);

        }

        private void agregarEcologicos()
        {

            if (gopc != 1)
            {
                return;
            }

            _pointsc.Clear();

            _pointsc.Add(new PointLatLng(21.884836714, -98.7342596054));
            _pointsc.Add(new PointLatLng(21.8902524911, -98.7411260605));
            _pointsc.Add(new PointLatLng(21.8962255362, -98.7479066849));
            _pointsc.Add(new PointLatLng(21.9009241559, -98.7523698807));
            _pointsc.Add(new PointLatLng(21.9078523462, -98.7462329865));
            _pointsc.Add(new PointLatLng(21.9035521298, -98.7409114838));
            _pointsc.Add(new PointLatLng(21.9020091964, -98.7421989441));
            _pointsc.Add(new PointLatLng(21.896678482, -98.735498786));
            _pointsc.Add(new PointLatLng(21.8982563146, -98.7340021133));
            _pointsc.Add(new PointLatLng(21.892801021, -98.7268352509));

            ecologicosActividad("Ecologicos", _pointsc, Color.Transparent, false);

        }

        private void agregarRecepciones()
        {

            return;

            if (gopc != 1)
            {
                return;
            }



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

            markerBuscarUbicacion = new GMarkerGoogle(new PointLatLng(lat-.0001, lng), GMarkerGoogleType.yellow_small);// .yellow);// bmpmarker);
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
            markerRecorrido = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.blue);// .purple_small);
            markerRecorrido.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            markerRecorrido.ToolTipText = string.Format("CAMION {0}\nHORA:{1}", id, hora);
            //markerRecorrido.ToolTipText = string.Format("{0} \n VELOCIDAD: {1} \n HORA:{2}", name, velocidad, hora);
            overlayRecorridos.Markers.Add(markerRecorrido);
        }

        private void agregaractualizarMarcadorRepartos(string id, int opc, string fecha, string hora, double lat, double lng, Boolean vertexto)
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
            if (vertexto)
            {
                markerRecorrido.ToolTipMode = MarkerTooltipMode.Always;
            }
            else
            {
                markerRecorrido.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            }
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


            markerRecorrido.ToolTipText = string.Format("({0}) {1}", numero, hora);
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

            lblEtiquetaRutas.Top = 5;
            lblEtiquetaRutas.Left = 20;

            toolStrip1.Top = tabControl1.Top + tabControl1.Height;
            toolStrip1.Left = 0;
            toolStrip1.Width = this.Width;

            //picLogo.Top = 30;
            //picLogo.Left = this.Width - picLogo.Width - 30;

            //txtDistancia.Top = btnEmpacadora.Top + txtDistancia.Height + 5;
            //txtDistancia.Left = (this.Width / 2) - (txtDistancia.Width / 2);

            panelTrack.Top = 90; //this.Height - panelTrack.Height - 100; //70;
            panelTrack.Left = 0;

            btnRotarDer.Top = panelTrack.Top + panelTrack.Height + 40;
            btnRotarDer.Left = panelTrack.Left;

            //btnRotarIzq.Top = btnRotarDer.Top;
            //btnRotarIzq.Left = btnRotarDer.Left;
            btnRotarIzq.Top = panelTrack.Top + panelTrack.Height - btnRotarIzq.Height;
            btnRotarIzq.Left = panelTrack.Left + panelTrack.Width + 5;

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

            //chart2.Left = this.Width - chart2.Width - 30;
            //chart2.Top = this.Height - chart2.Height - 90;

            panelDetalles.Top = panelLeyendas.Top;
            panelDetalles.Left = panelLeyendas.Left;
            panelDetalles.Height = panelLeyendas.Height;
            panelDetalles.Width = panelLeyendas.Width;

            //panelCamiones.Top = this.Height - 110;
            //panelCamiones.Left = (this.Width / 2) - (panelCamiones.Width / 2);

            panelCamiones.Top = this.Height - 63;
            panelCamiones.Left = this.Width - panelCamiones.Width - 10;

            //-------------------------------------------------------------------------------



            panelActCamiones.Controls.Add(panelCamion2); //splitContainerMapa.Panel2.Controls.Add(panelCamion);
            panelActCamiones.Controls.Add(chart1);
            panelActCamiones.Controls.Add(chart2);
            //panelActCamiones.Controls.Add(chart3);
            //panelActCamiones.Controls.Add(chart4); //splitContainerMapa.Panel2.Controls.Add(btnCerrarPanel);
            //panelActCamiones.Controls.Add(panelIndicador01);
            //panelActCamiones.Controls.Add(panelIndicador02);
            panelActCamiones.Controls.Add(panelLeyendas);
            panelActCamiones.Controls.Add(panelDescrip);
            panelActCamiones.Controls.Add(lblClasicConn);
            panelActCamiones.Controls.Add(lblEcoConn);
           
            //panelActCamiones.Controls.Add(lblHoraMapa);
            panelActCamiones.Dock = DockStyle.Bottom;
            panelActCamiones.Height = 230;
            panelActCamiones.Width = this.Width;

            panelCamion2.Dock = DockStyle.Fill;


            //splitContainerMapa.Panel2.Controls.Add(panelCamion2); //splitContainerMapa.Panel2.Controls.Add(panelCamion);
            //splitContainerMapa.Panel2.Controls.Add(chart1);
            //splitContainerMapa.Panel2.Controls.Add(chart2);
            //splitContainerMapa.Panel2.Controls.Add(chart3);
            //splitContainerMapa.Panel2.Controls.Add(chart4); //splitContainerMapa.Panel2.Controls.Add(btnCerrarPanel);
            //splitContainerMapa.Panel2.Controls.Add(panelLeyendas);
            //splitContainerMapa.Panel2.Controls.Add(panelDescrip);
            //splitContainerMapa.Panel2.Controls.Add(lblClasicConn);
            //splitContainerMapa.Panel2.Controls.Add(lblEcoConn);
            //splitContainerMapa.Panel2.Controls.Add(lblHoraMapa);
            //splitContainerMapa.FixedPanel = FixedPanel.Panel2;
            //splitContainerMapa.Panel2MinSize = 10;
            //splitContainerMapa.SplitterDistance = 130;





            //splitContainerMapas.Panel1.Controls.Add(btnCerrarPanel);


            //chart1.Top = 40;
            //chart1.Left = 10;
            //chart1.Height = 300;
            //chart1.Width = 170;

            //panelCamion.Top = 40;
            //panelCamion.Left = 10;

            panelCamion2.Top = 0;
            panelCamion2.Left = 0;
            panelCamion2.Width = panelCam01.Width * 18 + 80;
            //panelCamion2.Height = panelCam01.Height * 2 + 10;

            //panelCamion.Height = 300;
            //panelCamion.Width = 170;

            panelDescrip.Top = 0; // panelCamion.Top + panelCamion.Height + 75 + 100;
            panelDescrip.Left = 0;
            panelDescrip.Visible = false;

            //chart2.Top = 0;//panelCamion.Top + panelCamion.Height + 75 + 150;//chart1.Top + chart1.Height + 5;
            //chart2.Left = panelCamion.Left + panelCamion.Width + 75;
            //chart2.Height = 0;

            ////////////////////////

            //posCamiones(panelCam02, lblCam01, lblpBc01, lblpBr01, picMov01, picCamion01, pBar01, lblpAct01);
            posCamiones(panelCam02, lblCam02, lblpBc02, lblpBr02, picMov02, picCamion02, pBar02, lblpAct02, picWifi02, lblTablet02, picPila02);
            posCamiones(panelCam03, lblCam03, lblpBc03, lblpBr03, picMov03, picCamion03, pBar03, lblpAct03, picWifi03, lblTablet03, picPila03);
            posCamiones(panelCam04, lblCam04, lblpBc04, lblpBr04, picMov04, picCamion04, pBar04, lblpAct04, picWifi04, lblTablet04, picPila04);
            posCamiones(panelCam05, lblCam05, lblpBc05, lblpBr05, picMov05, picCamion05, pBar05, lblpAct05, picWifi05, lblTablet05, picPila05);
            posCamiones(panelCam06, lblCam06, lblpBc06, lblpBr06, picMov06, picCamion06, pBar06, lblpAct06, picWifi06, lblTablet06, picPila06);
            posCamiones(panelCam07, lblCam07, lblpBc07, lblpBr07, picMov07, picCamion07, pBar07, lblpAct07, picWifi07, lblTablet07, picPila07);
            posCamiones(panelCam08, lblCam08, lblpBc08, lblpBr08, picMov08, picCamion08, pBar08, lblpAct08, picWifi08, lblTablet08, picPila08);
            posCamiones(panelCam09, lblCam09, lblpBc09, lblpBr09, picMov09, picCamion09, pBar09, lblpAct09, picWifi09, lblTablet09, picPila09);
            posCamiones(panelCam10, lblCam10, lblpBc10, lblpBr10, picMov10, picCamion10, pBar10, lblpAct10, picWifi10, lblTablet10, picPila10);
            posCamiones(panelCam11, lblCam11, lblpBc11, lblpBr11, picMov11, picCamion11, pBar11, lblpAct11, picWifi11, lblTablet11, picPila11);
            posCamiones(panelCam12, lblCam12, lblpBc12, lblpBr12, picMov12, picCamion12, pBar12, lblpAct12, picWifi12, lblTablet12, picPila12);
            posCamiones(panelCam13, lblCam13, lblpBc13, lblpBr13, picMov13, picCamion13, pBar13, lblpAct13, picWifi13, lblTablet13, picPila13);
            posCamiones(panelCam14, lblCam14, lblpBc14, lblpBr14, picMov14, picCamion14, pBar14, lblpAct14, picWifi14, lblTablet14, picPila14);
            posCamiones(panelCam15, lblCam15, lblpBc15, lblpBr15, picMov15, picCamion15, pBar15, lblpAct15, picWifi15, lblTablet15, picPila15);
            posCamiones(panelCam16, lblCam16, lblpBc16, lblpBr16, picMov16, picCamion16, pBar16, lblpAct16, picWifi16, lblTablet16, picPila16);
            posCamiones(panelCam17, lblCam17, lblpBc17, lblpBr17, picMov17, picCamion17, pBar17, lblpAct17, picWifi17, lblTablet17, picPila17);
            posCamiones(panelCam18, lblCam18, lblpBc18, lblpBr18, picMov18, picCamion18, pBar18, lblpAct18, picWifi18, lblTablet18, picPila18);
            posCamiones(panelCam19, lblCam19, lblpBc19, lblpBr19, picMov19, picCamion19, pBar19, lblpAct19, picWifi19, lblTablet19, picPila19);
            posCamiones(panelCam20, lblCam20, lblpBc20, lblpBr20, picMov20, picCamion20, pBar20, lblpAct20, picWifi20, lblTablet20, picPila20);
            posCamiones(panelCam21, lblCam21, lblpBc21, lblpBr21, picMov21, picCamion21, pBar21, lblpAct21, picWifi21, lblTablet21, picPila21);
            posCamiones(panelCam22, lblCam22, lblpBc22, lblpBr22, picMov22, picCamion22, pBar22, lblpAct22, picWifi22, lblTablet22, picPila22);
            posCamiones(panelCam23, lblCam23, lblpBc23, lblpBr23, picMov23, picCamion23, pBar23, lblpAct23, picWifi23, lblTablet23, picPila23);
            posCamiones(panelCam24, lblCam24, lblpBc24, lblpBr24, picMov24, picCamion24, pBar24, lblpAct24, picWifi24, lblTablet24, picPila24);
            posCamiones(panelCam25, lblCam25, lblpBc25, lblpBr25, picMov25, picCamion25, pBar25, lblpAct25, picWifi25, lblTablet25, picPila25);
            posCamiones(panelCam26, lblCam26, lblpBc26, lblpBr26, picMov26, picCamion26, pBar26, lblpAct26, picWifi26, lblTablet26, picPila26);
            posCamiones(panelCam27, lblCam27, lblpBc27, lblpBr27, picMov27, picCamion27, pBar27, lblpAct27, picWifi27, lblTablet27, picPila27);
            posCamiones(panelCam28, lblCam28, lblpBc28, lblpBr28, picMov28, picCamion28, pBar28, lblpAct28, picWifi28, lblTablet28, picPila28);

            posCamiones(panelCam29, lblCam29, lblpBc29, lblpBr29, null, picCamion29, pBar29, null, null, lblTablet29, null);
            posCamiones(panelCam30, lblCam30, lblpBc30, lblpBr30, null, picCamion30, pBar30, null, null, lblTablet30, null);
            posCamiones(panelCam31, lblCam31, lblpBc31, lblpBr31, null, picCamion31, pBar31, null, null, lblTablet31, null);
            posCamiones(panelCam32, lblCam32, lblpBc32, lblpBr32, null, picCamion32, pBar32, null, null, lblTablet32, null);
            posCamiones(panelCam33, lblCam33, lblpBc33, lblpBr33, null, picCamion33, pBar33, null, null, lblTablet33, null);
            posCamiones(panelCam34, lblCam34, lblpBc34, lblpBr34, null, picCamion34, pBar34, null, null, lblTablet34, null);
            posCamiones(panelCam35, lblCam35, lblpBc35, lblpBr35, null, picCamion35, pBar35, null, null, lblTablet35, null);
            posCamiones(panelCam36, lblCam36, lblpBc36, lblpBr36, null, picCamion36, pBar36, null, null, lblTablet36, null);

            //////////////////

            inactivarNumCam();
            //posPanelCam();

            //////////////////////////////////////////////////////////////////

            //chart3.Top = 0;// chart2.Top + chart2.Height + 65 + 30;
            //chart3.Left = panelDescripciones.Left - panelDescripciones.Width ;// panelCamion2.Left + panelCamion2.Width + 75;// chart2.Left + chart2.Width + 10;
            //chart3.Height = panelCamion2.Height / 2;// 130;//chart2.Height;
            //chart3.Width = 130;// chart2.Width;
            //chart3.BringToFront();

            //chart4.Top = chart3.Top + chart3.Height; //+ chart3.Height + 5;
            //chart4.Left = chart3.Left; //+ chart3.Width + 10; //10;
            //chart4.Height = chart3.Height;
            //chart4.Width = chart3.Width;
            //chart4.BringToFront();

            ////cla
            //chart3.Top = 0;// chart2.Top + chart2.Height + 65 + 30;
            //chart3.Left = panelCam35.Left + 60;// panelCamion2.Left + panelCamion2.Width + 75;// chart2.Left + chart2.Width + 10;
            //chart3.Height = panelCamion2.Height ;// 130;//chart2.Height;
            //chart3.Width = panelCamion2.Width / 8; //chart3.Height;// chart2.Width;
            //chart3.BringToFront();

            ////eco
            //chart4.Top = chart3.Top; //+ chart3.Height + 5;
            //chart4.Left = chart3.Left + chart3.Width; //+ chart3.Width + 10; //10;
            //chart4.Height = chart3.Height;
            //chart4.Width = chart3.Width;
            //chart4.BringToFront();

            //cla
            chart4.Height = 240;//chart2.Height;
            chart4.Width = 300; //chart3.Height;// chart2.Width;
            chart4.Top = this.Height - chart4.Height - 100;// chart2.Top + chart2.Height + 65 + 30;
            chart4.Left = 0;// panelCamion2.Left + panelCamion2.Width + 75;// chart2.Left + chart2.Width + 10;

            //chart3.BringToFront();

            //eco
            chart3.Height = chart4.Height;
            chart3.Width = chart4.Width;
            chart3.Top = chart4.Top;
            chart3.Left = this.Width - chart4.Width - 50; 

            //chart4.BringToFront();

            //panelIndicador01.Top = chart4.Top; //+ chart3.Height + 5;
            //panelIndicador01.Left = chart4.Left + chart4.Width; //+ chart3.Width + 10; //10;
            //panelIndicador01.Height = chart4.Height;
            //panelIndicador01.Width = chart4.Width;
            //panelIndicador01.BringToFront();

            //panelIndicador02.Top = panelIndicador01.Top; //+ chart3.Height + 5;
            //panelIndicador02.Left = panelIndicador01.Left + panelIndicador01.Width; //+ chart3.Width + 10; //10;
            //panelIndicador02.Height = panelIndicador01.Height;
            //panelIndicador02.Width = panelIndicador01.Width;
            //panelIndicador02.BringToFront();


            ///////////////////////////////////////////////////////////////

            panelLeyendas.Top = 0; // chart3.Top + chart3.Height + 10;
            panelLeyendas.Left = chart3.Left + chart3.Width + chart4.Width + 50; //chart3.Left;

            //lblHoraMapa.Top = chart3.Top + chart3.Height + 30;
            //lblHoraMapa.Left = chart3.Left;

            //btnCerrarPanel.Top = splitContainerMapa.Panel2.Height / 2;
            //btnCerrarPanel.Left = 0;

            //btnAbrirCerrarPanel.Top = (this.Height / 2) - (btnAbrirCerrarPanel.Height / 2);
            //btnAbrirCerrarPanel.Left = this.Width - btnAbrirCerrarPanel.Width - 15;

            btnAbrirCerrarPanel.Top = (this.Height) - (btnAbrirCerrarPanel.Height) - 100;
            btnAbrirCerrarPanel.Left = 0;//(this.Width / 2) - (btnAbrirCerrarPanel.Width / 2);

            btnCerrarPanel.Top = 50;
            //btnCerrarPanel.Top = (this.Width / 2) - (btnCerrarPanel.Width / 2) + 10;
            btnCerrarPanel.Left = (this.Width / 2) - (btnCerrarPanel.Width / 2);

            lblClasicConn.Top = chart3.Top;
            lblClasicConn.Left = chart3.Left;
            lblClasicConn.BringToFront();

            lblEcoConn.Top = chart4.Top;
            lblEcoConn.Left = chart4.Left;
            lblEcoConn.BringToFront();

            picIndicador01.Parent = gMapControl1;
            picIndicador01.Top = 0;
            picIndicador01.Left = 0;

            posBarrasUbicacion(1, 1, progressBar01, lblEcologicosCorrrales);
            posBarrasUbicacion(1, 2, progressBar02, lblClasicosCorrrales);

            posPanelesCam();

            
            lblDetalleStatus.BackColor = Color.FromArgb(100, Color.Black);
            lblDetalleStatus.Parent = gMapControl1;
            //lblDetalleStatus.Width = 240;
            //lblDetalleStatus.Top = 20;
            //lblDetalleStatus.Left = 20;

            lblDetalleStatusTaller.BackColor = Color.FromArgb(100, Color.Black);
            lblDetalleStatusTaller.Parent = gMapControl1;


            lblHoraMapa.BackColor = Color.FromArgb(100, Color.Black);
            lblHoraMapa.Parent = gMapControl1;
            lblHoraMapa.Width = 240;
            lblHoraMapa.Top = this.Height - panelCam01.Height - 70; // this.Height - lblHoraMapa.Height - 120; //- panelActCamiones.Height;
            lblHoraMapa.Left = this.Width - lblHoraMapa.Width - 70;  //this.Width / 2 - lblHoraMapa.Width / 2;
            //lblHoraMapa.Visible = !panelActCamiones.Visible;       

            posLblStatus();

        }

        void posLblStatus()
        {
            lblDetalleStatus.Top = 20;
            lblDetalleStatus.Left = 20;

            lblDetalleStatusTaller.Top = 20;
            lblDetalleStatusTaller.Left = lblDetalleStatus.Left + lblDetalleStatus.Width + 5;
        }

        void posBarrasUbicacion(int posHorizontal, int posVertical, ProgressStackBar pb, Label lb)
        {

            int vArriba = 0;
            int vIzquierda = 0;

            switch (posHorizontal)
            {
                case 1://izquierda
                    vIzquierda = 10;
                    break;
                case 2://derecha
                     vIzquierda = this.Width - pb.Width - 30;
                    break;
            }
            switch (posVertical)
            {
                case 1://arriba
                    vArriba = this.Height - pb.Height - 220;
                    break;
                case 2://abajo
                    vArriba = this.Height - pb.Height - 150;
                    break;
            }


            posControl(pb,
            altura_barra_progress_ubic,
            350,
            vArriba,
            vIzquierda);
            lb.Top = pb.Top + pb.Height + 10;
            lb.Left = pb.Left + (pb.Width / 2 - lb.Width / 2);

            //posControl(progressBar01,
            //altura_barra_progress_ubic,
            //400,
            //this.Height - progressBar01.Height - 150,
            //0);
            //lblEcologicosCorrrales.Top = progressBar01.Top + progressBar01.Height + 10;
            //lblEcologicosCorrrales.Left = progressBar01.Left + (progressBar01.Width / 2 - lblEcologicosCorrrales.Width / 2);

            //posControl(progressBar02,
            //    altura_barra_progress_ubic,
            //    400,
            //    this.Height - progressBar02.Height - 150,
            //    this.Width - progressBar02.Width - 20);
            //lblClasicosCorrrales.Top = progressBar02.Top + progressBar02.Height + 10;
            //lblClasicosCorrrales.Left = progressBar02.Left + (progressBar02.Width / 2 - lblClasicosCorrrales.Width / 2);

        }

        void posPanelesCam()
        {

            panelCam01.Parent = gMapControl1;
            panelCam02.Parent = gMapControl1;
            panelCam03.Parent = gMapControl1;

            //panelCam04.Parent = gMapControl1;
            //panelCam05.Parent = gMapControl1;
            //panelCam06.Parent = gMapControl1;
            //panelCam07.Parent = gMapControl1;
            //panelCam08.Parent = gMapControl1;
            //panelCam09.Parent = gMapControl1;
            //panelCam10.Parent = gMapControl1;
            //panelCam11.Parent = gMapControl1;

            panelCam12.Parent = gMapControl1;
            panelCam13.Parent = gMapControl1;
            panelCam14.Parent = gMapControl1;
            panelCam15.Parent = gMapControl1;
            panelCam16.Parent = gMapControl1;
            panelCam17.Parent = gMapControl1;
            panelCam18.Parent = gMapControl1;
            panelCam19.Parent = gMapControl1;
            panelCam20.Parent = gMapControl1;
            panelCam21.Parent = gMapControl1;
            panelCam22.Parent = gMapControl1;
            panelCam23.Parent = gMapControl1;
            panelCam24.Parent = gMapControl1;
            panelCam25.Parent = gMapControl1;
            panelCam26.Parent = gMapControl1;
            panelCam27.Parent = gMapControl1;
            panelCam28.Parent = gMapControl1;
            panelCam29.Parent = gMapControl1;
            panelCam30.Parent = gMapControl1;
            panelCam31.Parent = gMapControl1;
            panelCam32.Parent = gMapControl1;
            panelCam33.Parent = gMapControl1;
            panelCam34.Parent = gMapControl1;
            panelCam35.Parent = gMapControl1;
            panelCam36.Parent = gMapControl1;


            ////posControl(panelCam01,panelCam01.Height,panelCam01.Width, 0, 50);
            ////posControl(panelCam01,panelCam01.Height,panelCam01.Width, progressBar01.Top - panelCam01.Height - 20, 50);

            //var vArriba = 10;
            //var vDerecha = 25;

            //posControl(panelCam01, panelCam01.Height, panelCam01.Width, vArriba, vDerecha);
            //posControl(panelCam02, panelCam02.Height, panelCam02.Width, panelCam01.Top + panelCam01.Height + 1, panelCam01.Left);
            //posControl(panelCam03, panelCam03.Height, panelCam03.Width, panelCam02.Top + panelCam02.Height + 1, panelCam02.Left);

            ////posControl(panelCam04,panelCam04.Height,panelCam04.Width, panelCam01.Top, panelCam03.Left + panelCam03.Width + 5);
            ////posControl(panelCam05,panelCam05.Height,panelCam05.Width, panelCam01.Top, panelCam04.Left + panelCam04.Width + 5);
            ////posControl(panelCam06,panelCam06.Height,panelCam06.Width, panelCam01.Top, panelCam05.Left + panelCam05.Width + 5);
            ////posControl(panelCam07,panelCam07.Height,panelCam07.Width, panelCam01.Top, panelCam06.Left + panelCam06.Width + 5);
            ////posControl(panelCam08,panelCam08.Height,panelCam08.Width, panelCam01.Top, panelCam07.Left + panelCam07.Width + 5);
            ////posControl(panelCam09,panelCam09.Height,panelCam09.Width, panelCam01.Top, panelCam08.Left + panelCam08.Width + 5);
            ////posControl(panelCam10,panelCam10.Height,panelCam10.Width, panelCam01.Top, panelCam09.Left + panelCam09.Width + 5);
            ////posControl(panelCam11,panelCam11.Height,panelCam11.Width, panelCam01.Top, panelCam10.Left + panelCam10.Width + 5);

            //posControl(panelCam12, panelCam12.Height, panelCam12.Width, panelCam03.Top + panelCam03.Height + 1, panelCam03.Left);
            //posControl(panelCam13, panelCam13.Height, panelCam13.Width, panelCam12.Top + panelCam12.Height + 1, panelCam12.Left);
            //posControl(panelCam14, panelCam14.Height, panelCam14.Width, panelCam13.Top + panelCam13.Height + 1, panelCam13.Left);
            //posControl(panelCam15, panelCam15.Height, panelCam15.Width, panelCam14.Top + panelCam14.Height + 1, panelCam14.Left);
            //posControl(panelCam16, panelCam16.Height, panelCam16.Width, panelCam15.Top + panelCam15.Height + 1, panelCam15.Left);
            //posControl(panelCam17, panelCam17.Height, panelCam17.Width, panelCam16.Top + panelCam16.Height + 1, panelCam16.Left);
            //posControl(panelCam18, panelCam18.Height, panelCam18.Width, panelCam17.Top + panelCam17.Height + 1, panelCam17.Left);
            //posControl(panelCam19, panelCam19.Height, panelCam19.Width, panelCam18.Top + panelCam18.Height + 1, panelCam18.Left);
            //posControl(panelCam20, panelCam20.Height, panelCam20.Width, panelCam19.Top + panelCam19.Height + 1, panelCam19.Left);
            //posControl(panelCam21, panelCam21.Height, panelCam21.Width, panelCam20.Top + panelCam20.Height + 1, panelCam20.Left);
            //posControl(panelCam22, panelCam22.Height, panelCam22.Width, panelCam21.Top + panelCam21.Height + 1, panelCam21.Left);
            //posControl(panelCam23, panelCam23.Height, panelCam23.Width, panelCam22.Top + panelCam22.Height + 1, panelCam22.Left);
            //posControl(panelCam24, panelCam24.Height, panelCam24.Width, panelCam23.Top + panelCam23.Height + 1, panelCam23.Left);
            //posControl(panelCam25, panelCam25.Height, panelCam25.Width, panelCam24.Top + panelCam24.Height + 1, panelCam24.Left);
            //posControl(panelCam26, panelCam26.Height, panelCam26.Width, panelCam25.Top + panelCam25.Height + 1, panelCam25.Left);
            //posControl(panelCam27, panelCam27.Height, panelCam27.Width, panelCam26.Top + panelCam26.Height + 1, panelCam26.Left);
            //posControl(panelCam28, panelCam28.Height, panelCam28.Width, panelCam27.Top + panelCam27.Height + 1, panelCam27.Left);
            //posControl(panelCam29, panelCam29.Height, panelCam29.Width, panelCam28.Top + panelCam28.Height + 1, panelCam28.Left);
            //posControl(panelCam30, panelCam30.Height, panelCam30.Width, panelCam29.Top + panelCam29.Height + 1, panelCam29.Left);
            //posControl(panelCam31, panelCam31.Height, panelCam31.Width, panelCam30.Top + panelCam30.Height + 1, panelCam30.Left);
            //posControl(panelCam32, panelCam32.Height, panelCam32.Width, panelCam31.Top + panelCam31.Height + 1, panelCam31.Left);
            //posControl(panelCam33, panelCam33.Height, panelCam33.Width, panelCam32.Top + panelCam32.Height + 1, panelCam32.Left);
            //posControl(panelCam34, panelCam34.Height, panelCam34.Width, panelCam33.Top + panelCam33.Height + 1, panelCam33.Left);
            //posControl(panelCam35, panelCam35.Height, panelCam35.Width, panelCam34.Top + panelCam34.Height + 1, panelCam34.Left);
            //posControl(panelCam36, panelCam36.Height, panelCam36.Width, panelCam35.Top + panelCam35.Height + 1, panelCam35.Left);



            //dtListaCamiontmp





            posControl(panelCam01, panelCam01.Height, panelCam01.Width, this.Height - panelCam01.Height - 60, 10);
            posControl(panelCam02, panelCam02.Height, panelCam02.Width, panelCam01.Top, panelCam01.Left + panelCam01.Width + 5);
            posControl(panelCam03, panelCam03.Height, panelCam03.Width, panelCam01.Top, panelCam02.Left + panelCam02.Width + 5);

            //posControl(panelCam04,panelCam04.Height,panelCam04.Width, panelCam01.Top, panelCam03.Left + panelCam03.Width + 5);
            //posControl(panelCam05,panelCam05.Height,panelCam05.Width, panelCam01.Top, panelCam04.Left + panelCam04.Width + 5);
            //posControl(panelCam06,panelCam06.Height,panelCam06.Width, panelCam01.Top, panelCam05.Left + panelCam05.Width + 5);
            //posControl(panelCam07,panelCam07.Height,panelCam07.Width, panelCam01.Top, panelCam06.Left + panelCam06.Width + 5);
            //posControl(panelCam08,panelCam08.Height,panelCam08.Width, panelCam01.Top, panelCam07.Left + panelCam07.Width + 5);
            //posControl(panelCam09,panelCam09.Height,panelCam09.Width, panelCam01.Top, panelCam08.Left + panelCam08.Width + 5);
            //posControl(panelCam10,panelCam10.Height,panelCam10.Width, panelCam01.Top, panelCam09.Left + panelCam09.Width + 5);
            //posControl(panelCam11,panelCam11.Height,panelCam11.Width, panelCam01.Top, panelCam10.Left + panelCam10.Width + 5);

            posControl(panelCam12, panelCam12.Height, panelCam12.Width, panelCam01.Top, panelCam03.Left + panelCam03.Width + 5);
            posControl(panelCam13, panelCam13.Height, panelCam13.Width, panelCam01.Top, panelCam12.Left + panelCam12.Width + 5);
            posControl(panelCam14, panelCam14.Height, panelCam14.Width, panelCam01.Top, panelCam13.Left + panelCam13.Width + 5);
            posControl(panelCam15, panelCam15.Height, panelCam15.Width, panelCam01.Top, panelCam14.Left + panelCam14.Width + 5);
            posControl(panelCam16, panelCam16.Height, panelCam16.Width, panelCam01.Top, panelCam15.Left + panelCam15.Width + 5);
            posControl(panelCam17, panelCam17.Height, panelCam17.Width, panelCam01.Top, panelCam16.Left + panelCam16.Width + 5);
            posControl(panelCam18, panelCam18.Height, panelCam18.Width, panelCam01.Top, panelCam17.Left + panelCam17.Width + 5);
            posControl(panelCam19, panelCam19.Height, panelCam19.Width, panelCam01.Top, panelCam18.Left + panelCam18.Width + 5);
            posControl(panelCam20, panelCam20.Height, panelCam20.Width, panelCam01.Top, panelCam19.Left + panelCam19.Width + 5);
            posControl(panelCam21, panelCam21.Height, panelCam21.Width, panelCam01.Top, panelCam20.Left + panelCam20.Width + 5);
            posControl(panelCam22, panelCam22.Height, panelCam22.Width, panelCam01.Top, panelCam21.Left + panelCam21.Width + 5);
            posControl(panelCam23, panelCam23.Height, panelCam23.Width, panelCam01.Top, panelCam22.Left + panelCam22.Width + 5);
            posControl(panelCam24, panelCam24.Height, panelCam24.Width, panelCam01.Top, panelCam23.Left + panelCam23.Width + 5);
            posControl(panelCam25, panelCam25.Height, panelCam25.Width, panelCam01.Top, panelCam24.Left + panelCam24.Width + 5);
            posControl(panelCam26, panelCam26.Height, panelCam26.Width, panelCam01.Top, panelCam25.Left + panelCam25.Width + 5);
            posControl(panelCam27, panelCam27.Height, panelCam27.Width, panelCam01.Top, panelCam26.Left + panelCam26.Width + 5);
            posControl(panelCam28, panelCam28.Height, panelCam28.Width, panelCam01.Top, panelCam27.Left + panelCam27.Width + 5);
            posControl(panelCam29, panelCam29.Height, panelCam29.Width, panelCam01.Top, panelCam28.Left + panelCam28.Width + 5);
            posControl(panelCam30, panelCam30.Height, panelCam30.Width, panelCam01.Top, panelCam29.Left + panelCam29.Width + 5);
            posControl(panelCam31, panelCam31.Height, panelCam31.Width, panelCam01.Top, panelCam30.Left + panelCam30.Width + 5);
            posControl(panelCam32, panelCam32.Height, panelCam32.Width, panelCam01.Top, panelCam31.Left + panelCam31.Width + 5);
            posControl(panelCam33, panelCam33.Height, panelCam33.Width, panelCam01.Top, panelCam32.Left + panelCam32.Width + 5);
            posControl(panelCam34, panelCam34.Height, panelCam34.Width, panelCam01.Top, panelCam33.Left + panelCam33.Width + 5);
            posControl(panelCam35, panelCam35.Height, panelCam35.Width, panelCam01.Top, panelCam34.Left + panelCam34.Width + 5);
            posControl(panelCam36, panelCam36.Height, panelCam36.Width, panelCam01.Top, panelCam35.Left + panelCam35.Width + 5);


                    


            //return;

            posControl(progressBarCam01,
            altura_barra_progress_cam + 2,
            panelCam01.Width,
            panelCam01.Top - progressBarCam01.Height - 2,
            panelCam01.Left);

            posControl(progressBarCam02,
            altura_barra_progress_cam + 2,
            panelCam02.Width,
            panelCam02.Top - progressBarCam02.Height - 2,
            panelCam02.Left);

            posControl(progressBarCam03,
            altura_barra_progress_cam + 2,
            panelCam03.Width,
            panelCam03.Top - progressBarCam03.Height - 2,
            panelCam03.Left);

            posControl(progressBarCam12,
            altura_barra_progress_cam + 2,
            panelCam12.Width,
            panelCam12.Top - progressBarCam12.Height - 2,
            panelCam12.Left);

            posControl(progressBarCam13,
                altura_barra_progress_cam + 2,
                panelCam13.Width,
                panelCam13.Top - progressBarCam13.Height - 2,
                panelCam13.Left);

            posControl(progressBarCam14,
                altura_barra_progress_cam + 2,
                panelCam14.Width,
                panelCam14.Top - progressBarCam14.Height - 2,
                panelCam14.Left);

            posControl(progressBarCam15,
                altura_barra_progress_cam + 2,
                panelCam15.Width,
                panelCam15.Top - progressBarCam15.Height - 2,
                panelCam15.Left);

            posControl(progressBarCam16,
                altura_barra_progress_cam + 2,
                panelCam16.Width,
                panelCam16.Top - progressBarCam16.Height - 2,
                panelCam16.Left);

            posControl(progressBarCam17,
                altura_barra_progress_cam + 2,
                panelCam17.Width,
                panelCam17.Top - progressBarCam17.Height - 2,
                panelCam17.Left);

            posControl(progressBarCam18,
                altura_barra_progress_cam + 2,
                panelCam18.Width,
                panelCam18.Top - progressBarCam18.Height - 2,
                panelCam18.Left);

            posControl(progressBarCam19,
                altura_barra_progress_cam + 2,
                panelCam19.Width,
                panelCam19.Top - progressBarCam19.Height - 2,
                panelCam19.Left);

            posControl(progressBarCam20,
                altura_barra_progress_cam + 2,
                panelCam20.Width,
                panelCam20.Top - progressBarCam20.Height - 2,
                panelCam20.Left);

            posControl(progressBarCam21,
                altura_barra_progress_cam + 2,
                panelCam21.Width,
                panelCam21.Top - progressBarCam21.Height - 2,
                panelCam21.Left);

            posControl(progressBarCam22,
                altura_barra_progress_cam + 2,
                panelCam22.Width,
                panelCam22.Top - progressBarCam22.Height - 2,
                panelCam22.Left);

            posControl(progressBarCam23,
                altura_barra_progress_cam + 2,
                panelCam23.Width,
                panelCam23.Top - progressBarCam23.Height - 2,
                panelCam23.Left);

            posControl(progressBarCam24,
                altura_barra_progress_cam + 2,
                panelCam24.Width,
                panelCam24.Top - progressBarCam24.Height - 2,
                panelCam24.Left);

            posControl(progressBarCam25,
                altura_barra_progress_cam + 2,
                panelCam25.Width,
                panelCam25.Top - progressBarCam25.Height - 2,
                panelCam25.Left);

            posControl(progressBarCam26,
                altura_barra_progress_cam + 2,
                panelCam26.Width,
                panelCam26.Top - progressBarCam26.Height - 2,
                panelCam26.Left);

            posControl(progressBarCam27,
                altura_barra_progress_cam + 2,
                panelCam27.Width,
                panelCam27.Top - progressBarCam27.Height - 2,
                panelCam27.Left);

            posControl(progressBarCam28,
                altura_barra_progress_cam + 2,
                panelCam28.Width,
                panelCam28.Top - progressBarCam28.Height - 2,
                panelCam28.Left);

            posControl(progressBarCam29,
                altura_barra_progress_cam + 2,
                panelCam29.Width,
                panelCam29.Top - progressBarCam29.Height - 2,
                panelCam29.Left);

            posControl(progressBarCam30,
                altura_barra_progress_cam + 2,
                panelCam30.Width,
                panelCam30.Top - progressBarCam30.Height - 2,
                panelCam30.Left);

            posControl(progressBarCam31,
                altura_barra_progress_cam + 2,
                panelCam31.Width,
                panelCam31.Top - progressBarCam31.Height - 2,
                panelCam31.Left);

            posControl(progressBarCam32,
                altura_barra_progress_cam + 2,
                panelCam32.Width,
                panelCam32.Top - progressBarCam32.Height - 2,
                panelCam32.Left);

            posControl(progressBarCam33,
                altura_barra_progress_cam + 2,
                panelCam33.Width,
                panelCam33.Top - progressBarCam33.Height - 2,
                panelCam33.Left);

            posControl(progressBarCam34,
                altura_barra_progress_cam + 2,
                panelCam34.Width,
                panelCam34.Top - progressBarCam34.Height - 2,
                panelCam34.Left);

            posControl(progressBarCam35,
                altura_barra_progress_cam + 2,
                panelCam35.Width,
                panelCam35.Top - progressBarCam35.Height - 2,
                panelCam35.Left);

            posControl(progressBarCam36,
                altura_barra_progress_cam + 2,
                panelCam36.Width,
                panelCam36.Top - progressBarCam36.Height - 2,
                panelCam36.Left);




        }

        void posControl(Control control, int alto, int ancho, int arriba, int izquierda)
        {
            if (control != null)
            {
                control.Height = alto;
                control.Width = ancho;
                control.Top = arriba;
                control.Left = izquierda;
            }        
        }

        public void visPanelCamiones(bool visible)
        {

            panelCam01.Visible = visible;
            panelCam02.Visible = visible;
            panelCam03.Visible = visible;
            //panelCam04.Visible = visible;
            //panelCam05.Visible = visible;
            //panelCam06.Visible = visible;
            //panelCam07.Visible = visible;
            //panelCam08.Visible = visible;
            //panelCam09.Visible = visible;
            //panelCam10.Visible = visible;
            //panelCam11.Visible = visible;
            panelCam12.Visible = visible;
            panelCam13.Visible = visible;
            panelCam14.Visible = visible;
            panelCam15.Visible = visible;
            panelCam16.Visible = visible;
            panelCam17.Visible = visible;
            panelCam18.Visible = visible;
            panelCam19.Visible = visible;
            panelCam20.Visible = visible;
            panelCam21.Visible = visible;
            panelCam22.Visible = visible;
            panelCam23.Visible = visible;
            panelCam24.Visible = visible;
            panelCam25.Visible = visible;
            panelCam26.Visible = visible;
            panelCam27.Visible = visible;
            panelCam28.Visible = visible;
            panelCam29.Visible = visible;
            panelCam30.Visible = visible;
            panelCam31.Visible = visible;
            panelCam32.Visible = visible;
            panelCam33.Visible = visible;
            panelCam34.Visible = visible;
            panelCam35.Visible = visible;
            panelCam36.Visible = visible;

        }


        void posCamiones(
            Panel panel1,
            Label etiqueta1,
            Label etiqueta2,
            Label etiqueta3,
            PictureBox pic1,
            PictureBox pic2,
            ProgressBar pb1,
            Label etiqueta4,
            PictureBox pic3,
            Label etiqueta5,
            PictureBox pic4)

        {

            panel1.BorderStyle = panelCam01.BorderStyle;
            panel1.Size = panelCam01.Size;

            if (pic1!=null) {
                //pic1.Visible = picMov01.Visible;
                pic1.Top = picMov01.Top;
                pic1.Left = picMov01.Left;
                pic1.Size = picMov01.Size;
                pic1.SizeMode = picMov01.SizeMode;
                pic1.BorderStyle = BorderStyle.None;
                pic1.BackColor = Color.Transparent;
            }
            //if (pic2 != null)
            //{
            //    pic2.Visible = picCamion01.Visible;
            //    pic2.Dock = picCamion01.Dock;
            //    pic2.Top = picCamion01.Top;
            //    pic2.Left = picCamion01.Left;
            //    pic2.Size = picCamion01.Size;
            //    pic2.BringToFront();
            //}
            if (pic3 != null)
            {
                pic3.Top = picWifi01.Top;
                pic3.Left = picWifi01.Left;
                pic3.Size = picWifi01.Size;
            }
            if (pic4 != null)
            {
                pic4.Top = picPila01.Top;
                pic4.Left = picPila01.Left;
                pic4.Size = picPila01.Size;
            }
            if (etiqueta1 != null)
            {
                //etiqueta1.Visible = lblCam01.Visible;
                etiqueta1.TextAlign = lblCam01.TextAlign;
                etiqueta1.Height = lblCam01.Height;
                etiqueta1.AutoSize = lblCam01.AutoSize;
                etiqueta1.Dock = lblCam01.Dock;
                etiqueta1.Top = lblCam01.Top;
                etiqueta1.Left = lblCam01.Left;
                etiqueta1.Font = lblCam01.Font;
                etiqueta1.BackColor = Color.Transparent;
                etiqueta1.BringToFront();
                //etiqueta1.Text = etiqueta1.Text.Replace("ruta ", "");
                //etiqueta1.Text = "ruta " + etiqueta1.Text;
            }
            if (etiqueta2 != null)
            {
                //etiqueta2.Visible = lblpBc01.Visible;
                //etiqueta2.Top = lblpBc01.Top;
                //etiqueta2.Left = lblpBc01.Left;
                //etiqueta2.Font = lblpBc01.Font;
                //etiqueta2.BackColor = Color.Transparent;


                etiqueta2.AutoSize = false;
                etiqueta2.Top = lblpBc01.Top;
                etiqueta2.Left = lblpBc01.Left;
                etiqueta2.Height = lblpBc01.Height;
                etiqueta2.Width = lblpBc01.Width;
                etiqueta2.Font = lblpBc01.Font;
                etiqueta2.Dock = lblpBc01.Dock;
                etiqueta2.TextAlign = lblpBc01.TextAlign;
                etiqueta2.BackColor = Color.Transparent;
                etiqueta2.ForeColor = lblpBc01.ForeColor;
                etiqueta2.Visible = true;
                etiqueta2.BringToFront();
                etiqueta2.Text = "";

            }

            if (pb1 != null)
            {
                pb1.Size = pBar01.Size;
                pb1.Style = pBar01.Style;
                pb1.Dock = DockStyle.Bottom;
                pb1.Visible = false; //pBar01.Visible;
                pb1.BringToFront();
            }
            if (etiqueta4 != null)
            {
                //etiqueta4.Visible = lblpAct01.Visible;
                etiqueta4.Top = lblpAct01.Top;
                etiqueta4.Left = lblpAct01.Left;
                etiqueta4.Font = lblpAct01.Font;
                etiqueta4.BackColor = Color.Transparent;
                etiqueta4.Visible = lblpAct01.Visible;
            }




            if (etiqueta5 != null)
            {
                etiqueta5.AutoSize = false;
                etiqueta5.Location = lblTablet01.Location;
                etiqueta5.Size = lblTablet01.Size;
                etiqueta5.Top = lblTablet01.Top;
                etiqueta5.Left = lblTablet01.Left;
                etiqueta5.Height = lblTablet01.Height;
                etiqueta5.Font = lblTablet01.Font;
                etiqueta5.Dock = lblTablet01.Dock;
                etiqueta5.TextAlign = lblTablet01.TextAlign;
                etiqueta5.BackColor = Color.Transparent; 
                etiqueta5.ForeColor = lblTablet01.ForeColor;
                etiqueta5.Visible = true; 
                etiqueta5.BringToFront();
                etiqueta5.Text = "";
            }
            if (etiqueta3 != null)
            {
                //etiqueta3.Visible = lblpBr01.Visible;
                //etiqueta3.Top = lblpBr01.Top;
                //etiqueta3.Left = lblpBr01.Left;
                //etiqueta3.Font = lblpBr01.Font;
                //etiqueta3.BackColor = Color.Transparent;
                //etiqueta3.BringToFront();

                etiqueta3.AutoSize = false;
                etiqueta3.Top = lblpBr01.Top;
                etiqueta3.Left = lblpBr01.Left;
                etiqueta3.Height = lblpBr01.Height;
                etiqueta3.Font = lblpBr01.Font;
                etiqueta3.Dock = lblpBr01.Dock;
                etiqueta3.TextAlign = lblpBr01.TextAlign;
                etiqueta3.BackColor = Color.Transparent;
                etiqueta3.ForeColor = lblpBr01.ForeColor;
                etiqueta3.Visible = true;
                etiqueta3.BringToFront();
                etiqueta3.Text = "";


            }

            if (pic2 != null)
            {
                pic2.Visible = picCamion01.Visible;
                pic2.Dock = picCamion01.Dock;
                pic2.Top = picCamion01.Top;
                pic2.Left = picCamion01.Left;
                pic2.Size = picCamion01.Size;
                pic2.BringToFront();
            }


        }

        void resetCamiones()
        {

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

        int cantCamionesCla()
        {

            int cant = 0;

            if (picRepCam01.BackColor == Color.Transparent && picGpsCam01.BackColor == Color.Transparent) { cant++; }
            if (picRepCam02.BackColor == Color.Transparent && picGpsCam02.BackColor == Color.Transparent) { cant++; }
            if (picRepCam04.BackColor == Color.Transparent && picGpsCam04.BackColor == Color.Transparent) { cant++; }
            if (picRepCam08.BackColor == Color.Transparent && picGpsCam08.BackColor == Color.Transparent) { cant++; }
            if (picRepCam10.BackColor == Color.Transparent && picGpsCam10.BackColor == Color.Transparent) { cant++; }
            if (picRepCam15.BackColor == Color.Transparent && picGpsCam15.BackColor == Color.Transparent) { cant++; }
            if (picRepCam20.BackColor == Color.Transparent && picGpsCam20.BackColor == Color.Transparent) { cant++; }

            return cant;

        }

        int cantCamionesEco()
        {

            int cant = 0;

            if (picRepCam03.BackColor == Color.Transparent && picGpsCam03.BackColor == Color.Transparent) { cant++; }
            if (picRepCam05.BackColor == Color.Transparent && picGpsCam05.BackColor == Color.Transparent) { cant++; }
            if (picRepCam06.BackColor == Color.Transparent && picGpsCam06.BackColor == Color.Transparent) { cant++; }
            if (picRepCam07.BackColor == Color.Transparent && picGpsCam07.BackColor == Color.Transparent) { cant++; }
            if (picRepCam09.BackColor == Color.Transparent && picGpsCam09.BackColor == Color.Transparent) { cant++; }
            if (picRepCam11.BackColor == Color.Transparent && picGpsCam11.BackColor == Color.Transparent) { cant++; }
            if (picRepCam12.BackColor == Color.Transparent && picGpsCam12.BackColor == Color.Transparent) { cant++; }
            if (picRepCam13.BackColor == Color.Transparent && picGpsCam13.BackColor == Color.Transparent) { cant++; }
            if (picRepCam14.BackColor == Color.Transparent && picGpsCam14.BackColor == Color.Transparent) { cant++; }
            if (picRepCam16.BackColor == Color.Transparent && picGpsCam16.BackColor == Color.Transparent) { cant++; }
            if (picRepCam17.BackColor == Color.Transparent && picGpsCam17.BackColor == Color.Transparent) { cant++; }
            if (picRepCam18.BackColor == Color.Transparent && picGpsCam18.BackColor == Color.Transparent) { cant++; }
            if (picRepCam19.BackColor == Color.Transparent && picGpsCam19.BackColor == Color.Transparent) { cant++; }
            //if (picRepCam21.BackColor == Color.Transparent && picGpsCam21.BackColor == Color.Transparent) { cant++; }
            //if (picRepCam22.BackColor == Color.Transparent && picGpsCam22.BackColor == Color.Transparent) { cant++; }

            return cant;

        }


        private void timerCamion_Tick(object sender, EventArgs e)
        {

            timer();

            lblTimer.Text = (Int32.Parse(latencia) + 1).ToString();
            lblCamPorc.Text = porcCamion().ToString() + "%";


            lblClasicConn.Text = cantCamionesCla().ToString();
            lblEcoConn.Text = cantCamionesEco().ToString();



        }

        private void timer()
        {

            if (indiceBotonFecha == 1)
            {

                if (txtFecha.Text != DateTime.Now.ToString("dd/MM/yyyy"))
                {
                    quitarRecorrido();
                }

                txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }

            //lblErrores.Text = "Ok";

            mostrarTallerCamiones();

            obtenerWsdlCabezasSap(ref dtCabezastmp);
            obtenerWsdlPlanesSap(ref dtPlanestmp);

            mostrarLocalizaCamiones();
            mostrarDatosWs();

            //mostrarDatos(tab);
            refrescaGraficos();

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

            //CopyGMapElements(gMapControl1, gMapControl2);

            msgCamiones();
            msgCamionesTaller();

        }

        private void refrescaGraficos()
        {

            progressBar01.ClearSegments();
            progressBar02.ClearSegments();

            posPanelesCam();

            //progressBarCam01.ClearSegments();
            //progressBarCam01.AddSegment("", 45, Color.Lime);
            //progressBarCam01.AddSegment("", 55, Color.Orange);



            graficoBarras();
            //grafico1(chart1);

            if (overlayBuscarUbicaciones.Markers.Count > 0)
            {
                verSinServir = false;
                //quitarMarcadorBuscarUbicaciones();
            }

            grafico2(chart2, 0);

            chart3.Visible = false;
            chart4.Visible = false;

            lblEcologicosCorrrales.Visible = false;
            lblClasicosCorrrales.Visible = false;

            //if (!panelActCamiones.Visible)
            //if (!panelCam01.Visible)
            //{
                //if (ubicE(gMapControl1.Position.Lat, gMapControl1.Position.Lng) == clasico || gMapControl1.Zoom == gMapControl1.MinZoom)
                //{
                    //chart3.Visible = true;
                    //chart3.Parent = gMapControl1;
                    grafico2(chart3, clasico);
                //}
                //if (ubicE(gMapControl1.Position.Lat, gMapControl1.Position.Lng) == ecologico || gMapControl1.Zoom == gMapControl1.MinZoom)
                //{
                    //chart4.Visible = true;
                    //chart4.Parent = gMapControl1;
                    grafico2(chart4, ecologico);
            //}

            if (ubicE(gMapControl1.Position.Lat, gMapControl1.Position.Lng) == clasico || gMapControl1.Zoom == gMapControl1.MinZoom)
            {
                posBarrasUbicacion(2, 1, progressBar01, lblEcologicosCorrrales);
                posBarrasUbicacion(2, 2, progressBar02, lblClasicosCorrrales);
            }
            if (ubicE(gMapControl1.Position.Lat, gMapControl1.Position.Lng) == ecologico || gMapControl1.Zoom == gMapControl1.MinZoom)
            {
                posBarrasUbicacion(1, 1, progressBar01, lblEcologicosCorrrales);
                posBarrasUbicacion(1, 2, progressBar02, lblClasicosCorrrales);
            }
            //}

        }

        private void mostrarDatosWs()
        {

            switch (indiceBotonVista)
            {

                case 1:
                    mostrarRepartoCorral();
                    
                    //Thread t = new Thread(() => { mostrarRepartoCorral(); });
                    //t.Name = "frepartos";
                    //t.IsBackground = true;
                    //t.Start();                   

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
                case 5:
                    mostrarCabezasCorral();
                    break;
                case 6:
                    mostrarRepartoCorralServida();

                    //Thread t2 = new Thread(() => { mostrarRepartoCorralServida(); });
                    //t2.Name = "frepartosservida";
                    //t2.IsBackground = true;
                    //t2.Start();

                    break;

                case 0: //ultimo lista menus
                    //mostrarDimensionesCorral();
                    mostrarCabezasDimensionesCorral();
                    break;
                default:
                    break;
            }

            gMapControl1.Refresh();
            gMapControl2.Refresh();

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
            gMapControl2.Refresh();

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

        private void mostrarTallerCamiones()
        {

            try
            {

                DataTable dt = new DataTable();
                DateTime fecha;
                DateTime hoy = DateTime.Today;

                leerWsdlTallerCamion(ref dt);

                if (dt.Rows.Count > 0)
                {
                    
                    dtTallertmp.Clear();

                    foreach (DataRow row in dt.Rows)
                    {

                        //fecha = Convert.ToDateTime(row["fecha"].ToString()); 

                        //if (fecha == hoy)
                        //{

                            DataRow newRow = dtTallertmp.NewRow();

                            newRow["numcamion"] = row["numcamion"].ToString();
                            newRow["name"] = row["name"].ToString();
                            newRow["fecha"] = row["fecha"].ToString();
                            newRow["mtto"] = row["mtto"].ToString();

                            dtTallertmp.Rows.Add(newRow);

                        //}

                    }

                }
                else
                {

                }

                vdt.Clear();
                vdt = dt;

            }
            catch (Exception e)
            {
                lblErrores.Text = "Localiza, " + e.Message;
            }

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
                    vCantDesconect = 0;
                    vCantConect = 0;
                    vCantLocaliza = 0;

                    foreach (DataRow row in dt.Rows)
                    {

                        //if (row["numcamion"].ToString() == "13")
                        //{
                        //    var a = 1;
                        //}

                        fecha = Convert.ToDateTime(row["fecha"].ToString()); //fechagps

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
                                int.Parse(row["servida"].ToString()).ToString(),
                                row["total_corral"].ToString(),
                                row["faltan_serv"].ToString(),
                                int.TryParse(row["carga_actual"]?.ToString(), out int valor2) ? valor2 : 0,
                                row["pila"].ToString(),
                                row["velocidad"].ToString()
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

                            camHora(newRow["id"].ToString(), row["hora"].ToString()/*row["horareg"].ToString()*/);

                        }
                    }
                    //pictureBox24.Refresh();

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

        private void camHora(string camion, string hora)
        {

            string horaAct = DateTime.Now.ToString("HH") + ":" + DateTime.Now.ToString("mm") + ":" + DateTime.Now.ToString("ss");
            DateTime hora1 = Convert.ToDateTime(hora);
            DateTime hora2 = Convert.ToDateTime(horaAct);
            TimeSpan demora = hora2.Subtract(hora1);
            double mins = demora.TotalMinutes;

            string tiempo = demora.Hours.ToString("D2") + ":" + demora.Minutes.ToString("D2") + ":" + demora.Seconds.ToString("D2");

            Color colorFondo, colorLetra;

            //if (demora.Hours > 0 || demora.Minutes > 10)
            //{
            //    colorFondo = Color.Red;
            //    colorLetra = Color.White;
            //}
            //else
            //{
            //    colorFondo = Color.Lime;
            //    colorLetra = Color.Black;
            //}

            colorFondo = Color.Transparent;
            colorLetra = Color.Black;

            switch (cerosIzq(camion))
            {
                case "01":
                    lblpAct01.Text = tiempo;
                    lblpAct01.BackColor = colorFondo;
                    lblpAct01.ForeColor = colorLetra;
                    break;
                case "02":
                    lblpAct02.Text = tiempo;
                    lblpAct02.BackColor = colorFondo;
                    lblpAct02.ForeColor = colorLetra;
                    break;
                case "03":
                    lblpAct03.Text = tiempo;
                    lblpAct03.BackColor = colorFondo;
                    lblpAct03.ForeColor = colorLetra;
                    break;
                case "04":
                    lblpAct04.Text = tiempo;
                    lblpAct04.BackColor = colorFondo;
                    lblpAct04.ForeColor = colorLetra;
                    break;
                case "05":
                    lblpAct05.Text = tiempo;
                    lblpAct05.BackColor = colorFondo;
                    lblpAct05.ForeColor = colorLetra;
                    break;
                case "06":
                    lblpAct06.Text = tiempo;
                    lblpAct06.BackColor = colorFondo;
                    lblpAct06.ForeColor = colorLetra;
                    break;
                case "07":
                    lblpAct07.Text = tiempo;
                    lblpAct07.BackColor = colorFondo;
                    lblpAct07.ForeColor = colorLetra;
                    break;
                case "08":
                    lblpAct08.Text = tiempo;
                    lblpAct08.BackColor = colorFondo;
                    lblpAct08.ForeColor = colorLetra;
                    break;
                case "09":
                    lblpAct09.Text = tiempo;
                    lblpAct09.BackColor = colorFondo;
                    lblpAct09.ForeColor = colorLetra;
                    break;
                case "10":
                    lblpAct10.Text = tiempo;
                    lblpAct10.BackColor = colorFondo;
                    lblpAct10.ForeColor = colorLetra;
                    break;
                case "11":
                    lblpAct11.Text = tiempo;
                    lblpAct11.BackColor = colorFondo;
                    lblpAct11.ForeColor = colorLetra;
                    break;
                case "12":
                    lblpAct12.Text = tiempo;
                    lblpAct12.BackColor = colorFondo;
                    lblpAct12.ForeColor = colorLetra;
                    break;
                case "13":
                    lblpAct13.Text = tiempo;
                    lblpAct13.BackColor = colorFondo;
                    lblpAct13.ForeColor = colorLetra;
                    break;
                case "14":
                    lblpAct14.Text = tiempo;
                    lblpAct14.BackColor = colorFondo;
                    lblpAct14.ForeColor = colorLetra;
                    break;
                case "15":
                    lblpAct15.Text = tiempo;
                    lblpAct15.BackColor = colorFondo;
                    lblpAct15.ForeColor = colorLetra;
                    break;
                case "16":
                    lblpAct16.Text = tiempo;
                    lblpAct16.BackColor = colorFondo;
                    lblpAct16.ForeColor = colorLetra;
                    break;
                case "17":
                    lblpAct17.Text = tiempo;
                    lblpAct17.BackColor = colorFondo;
                    lblpAct17.ForeColor = colorLetra;
                    break;
                case "18":
                    lblpAct18.Text = tiempo;
                    lblpAct18.BackColor = colorFondo;
                    lblpAct18.ForeColor = colorLetra;
                    break;
                case "19":
                    lblpAct19.Text = tiempo;
                    lblpAct19.BackColor = colorFondo;
                    lblpAct19.ForeColor = colorLetra;
                    break;
                case "20":
                    lblpAct20.Text = tiempo;
                    lblpAct20.BackColor = colorFondo;
                    lblpAct20.ForeColor = colorLetra;
                    break;
                case "21":
                    lblpAct21.Text = tiempo;
                    lblpAct21.BackColor = colorFondo;
                    lblpAct21.ForeColor = colorLetra;
                    break;
                case "22":
                    lblpAct22.Text = tiempo;
                    lblpAct22.BackColor = colorFondo;
                    lblpAct22.ForeColor = colorLetra;
                    break;
                case "23":
                    lblpAct23.Text = tiempo;
                    lblpAct23.BackColor = colorFondo;
                    lblpAct23.ForeColor = colorLetra;
                    break;
                case "24":
                    lblpAct24.Text = tiempo;
                    lblpAct24.BackColor = colorFondo;
                    lblpAct24.ForeColor = colorLetra;
                    break;

                case "25":
                    lblpAct25.Text = tiempo;
                    lblpAct25.BackColor = colorFondo;
                    lblpAct25.ForeColor = colorLetra;
                    break;
                case "26":
                    lblpAct26.Text = tiempo;
                    lblpAct26.BackColor = colorFondo;
                    lblpAct26.ForeColor = colorLetra;
                    break;
                case "27":
                    lblpAct27.Text = tiempo;
                    lblpAct27.BackColor = colorFondo;
                    lblpAct27.ForeColor = colorLetra;
                    break;
                case "28":
                    lblpAct28.Text = tiempo;
                    lblpAct28.BackColor = colorFondo;
                    lblpAct28.ForeColor = colorLetra;
                    break;
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
                agregarTalleres();
                agregarEcoSec01();
                agregarEcologicos();
                agregarPrensas();


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

            DataRow[] rows = dt.Select("lat = '0.0000000000' OR lng = '0.0000000000'");
            foreach (DataRow row in rows) dt.Rows.Remove(row);


            quitarMarcadorRecorridos();
            quitarMarcadorRutas();

            dtRutaErrortmp.Rows.Clear();
            listBoxRutaError.Items.Clear();


            foreach (DataRow row in dt.Rows)
            {
                string corral = "";

                if (row["corral"].ToString() == row["corralgps"].ToString())
                {
                    corral = row["corralgps"].ToString() + " GPS ";
                    opc = 3; //verde                                        
                }
                else
                {
                    corral = row["corralgps"].ToString() + " GPS [" + row["corral"].ToString() + " SEL] ";
                    opc = 1; //rojo                    
                    listBoxRutaError.Items.Add(corral + " " + row["hora"].ToString());

                    DataRow newRow = dtRutaErrortmp.NewRow();
                    newRow["texto"] = row["corralgps"].ToString();
                    newRow["lat"] = 0;
                    newRow["lng"] = 0;
                    dtRutaErrortmp.Rows.Add(newRow);


                }


                if (row["corralgps"].ToString() == "0000")
                {
                    opc = 2; //amarillo
                }



                agregaractualizarMarcadorRepartos(
                    corral,
                    opc,
                    row["fecha"].ToString(),
                    row["hora"].ToString(),
                    Convert.ToDouble(row["lat"]),
                    Convert.ToDouble(row["lng"])
                    , false);

                vlat = Convert.ToDouble(row["lat"]);
                vlng = Convert.ToDouble(row["lng"]);

                puntos.Add(new PointLatLng(Convert.ToDouble(row["lat"]), Convert.ToDouble(row["lng"])));

                //if (cantp == i)
                //{
                //    break;
                //}

                i++;
            }

            lblRutaError.Text = listBoxRutaError.Items.Count.ToString();

            ///////////// linea une puntos

            GMapRoute PuntoRuta = new GMapRoute(puntos, "Ruta");
            overlayRutas.Routes.Add(PuntoRuta);

            //PuntoRuta.Stroke.Color = Color.Blue;
            //PuntoRuta.Stroke.Color = Color.Transparent;



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

            listBoxRutaError.Visible = true;
            picRecLimpia.Visible = true;
            label21.Visible = true;

            lblRutaError.Visible = true;

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

            if (lista.Count == 0) { return; }

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

        private void leerWsdlTallerCamion(ref DataTable dt)
        {

            //Cursor = Cursors.WaitCursor;

            seleccion = "TALLER";

            Thread t = new Thread(() => { cargarWSDLSel(seleccion, DateTime.Today, DateTime.Today); });
            t.Name = seleccion;
            t.IsBackground = true;

            DateTime inicio = DateTime.UtcNow;

            t.Start();

            //Console.WriteLine(t.Name + " " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString());
            //while (t.IsAlive)
            //{
            //    Thread.Sleep(50);//50
            //    Application.DoEvents();
            //}


            t.Join();

            TimeSpan dur = DateTime.UtcNow - inicio;
            Console.WriteLine(t.Name + " " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString() + " tiempo: " + dur);


            lista = connectar.getList();
            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();
            String url = connectar.getUrl();

            if (lista.Count == 0) { return; }

            //string[] lurl = url.Split('/');
            //string[] serverl = lurl[2].Trim().Split('.');
            //lblServer.Text = serverl[0].Trim();

            //lblMandante.Text = lurl[9].Trim();

            DataTable dttmp = new DataTable();
            dttmp.Columns.Add("numcamion");
            dttmp.Columns.Add("name");
            dttmp.Columns.Add("fecha");
            dttmp.Columns.Add("mtto");


            foreach (String listar in lista)
            {

                string[] lines = listar.Split('|');

                DataRow newRow = dttmp.NewRow();
                newRow["numcamion"] = lines[0].Trim();
                newRow["name"] = lines[1].Trim();

                lines[6] = lines[6].Insert(4, "-");
                lines[6] = lines[6].Insert(7, "-");
                newRow["fecha"] = lines[6].Trim();
                
                newRow["mtto"] = lines[5].Trim();

                dttmp.Rows.Add(newRow);

            }

            dt = dttmp;
            dtTallertmp.Clear();
            dtTallertmp = dttmp.Copy();

            if (!errormsg.Equals("")) { lblErrores.Text = errormsg; }

        }

        private void leerWsdlLocalizaCamion(ref DataTable dt)
        {

            //Cursor = Cursors.WaitCursor;

            seleccion = "LOCALIZA";

            Thread t = new Thread(() => { cargarWSDLSel(seleccion, DateTime.Today, DateTime.Today); });
            t.Name = seleccion;
            t.IsBackground = true;
            
            DateTime inicio = DateTime.UtcNow;

            t.Start();

            //Console.WriteLine(t.Name + " " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString());
            //while (t.IsAlive)
            //{
            //    Thread.Sleep(50);//50
            //    Application.DoEvents();
            //}

            
            t.Join();

            TimeSpan dur = DateTime.UtcNow - inicio;
            Console.WriteLine(t.Name + " " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString() + " tiempo: " + dur);


            lista = connectar.getList();
            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();
            String url = connectar.getUrl();

            if (lista.Count == 0) { return; }

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
            dttmp.Columns.Add("Pila");
            dttmp.Columns.Add("Red");
            dttmp.Columns.Add("velocidad");

            dttmp.Columns.Add("total_corral");
            dttmp.Columns.Add("faltan_serv");
            dttmp.Columns.Add("carga_actual");
            dttmp.Columns.Add("varios01");
            dttmp.Columns.Add("varios02");
            dttmp.Columns.Add("varios03");
            dttmp.Columns.Add("fechareg");
            dttmp.Columns.Add("horareg");


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

                newRow["pila"] = lines[7].Trim();
                newRow["red"] = lines[8].Trim();
                newRow["velocidad"] = lines[9].Trim();

                newRow["total_corral"] = lines[10].Trim();
                newRow["faltan_serv"] = lines[11].Trim();
                newRow["carga_actual"] = lines[12].Trim();
                newRow["varios01"] = lines[13].Trim();
                newRow["varios02"] = lines[14].Trim();
                newRow["varios03"] = lines[15].Trim();


                lines[16] = lines[16].Insert(4, "-");
                lines[16] = lines[16].Insert(7, "-");
                newRow["fechareg"] = lines[16].Trim();

                lines[17] = lines[17].Insert(2, ":");
                lines[17] = lines[17].Insert(5, ":");
                newRow["horareg"] = lines[17].Trim();

                //if (newRow["numcamion"].Equals("3")||
                //    newRow["numcamion"].Equals("7")||
                //        newRow["numcamion"].Equals("9"))
                //{
                //    newRow["lng"] = "-"+newRow["lng"];
                //}



                dttmp.Rows.Add(newRow);

            }

            dt = dttmp;
            dtLocalizatmp.Clear();
            dtLocalizatmp = dttmp;

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

            if (lista.Count == 0) { return; }

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

            if (lista.Count == 0) { return; }

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

        private void leerWsdlRepartosErr(ref DataTable dt)
        {

            //DataTable dttmp1 = new DataTable();
            //DataTable dttmp2 = new DataTable();
            //DataRow[] foundRows1;
            DataRow[] foundRows2;

            //Cursor = Cursors.WaitCursor;

            seleccion = "REPARTOSERR";

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
            
            if (lista.Count == 0) { return; }

            try
            {

                DataTable dttmp = new DataTable();
                dttmp.Columns.Add("corral");
                dttmp.Columns.Add("lat2");
                dttmp.Columns.Add("lng2");
                dttmp.Columns.Add("fecha");
                dttmp.Columns.Add("hora");
                dttmp.Columns.Add("numcamion");
                dttmp.Columns.Add("servida");
                dttmp.Columns.Add("racion");
                dttmp.Columns.Add("corralgps");
                dttmp.Columns.Add("lat");
                dttmp.Columns.Add("lng");

                foreach (String listar in lista)
                {

                    string[] lines = listar.Split('|');

                    DataRow newRow = dttmp.NewRow();
                    newRow["corral"] = lines[0].Trim();
                    newRow["lat2"] = lines[1].Trim();
                    newRow["lng2"] = lines[2].Trim();

                    lines[3] = lines[3].Insert(4, "-");
                    lines[3] = lines[3].Insert(7, "-");
                    newRow["fecha"] = lines[3].Trim();

                    lines[4] = lines[4].Insert(2, ":");
                    lines[4] = lines[4].Insert(5, ":");
                    newRow["hora"] = lines[4].Trim();

                    newRow["numcamion"] = lines[5].Trim().PadLeft(2, '0');
                    newRow["servida"] = lines[6].Trim();
                    newRow["racion"] = lines[7].Trim();
                    newRow["corralgps"] = lines[8].Trim();
                    newRow["lat"] = lines[9].Trim();
                    newRow["lng"] = lines[10].Trim();

                    dttmp.Rows.Add(newRow);

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
                foundRows1 = dttmp1.Select("numcamion='" + cmbCamionRuta.Text.Trim() + "'");

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

            if (lista.Count == 0) { return; }

            lista.Remove("  |");
            //lista.RemoveAt(0);

            DataTable dttmp = new DataTable();
            dttmp.Columns.Add("id");
            dttmp.Columns.Add("name");

            dttmp.Columns.Add("zona");
            dttmp.Columns.Add("centroam");
            dttmp.Columns.Add("centropm");
            dttmp.Columns.Add("recepcion");

            foreach (String listar in lista)
            {

                string[] lines = listar.Split('|');

                DataRow newRow = dttmp.NewRow();
                newRow["id"] = lines[0].Trim().PadLeft(2, '0');
                newRow["name"] = lines[1].Trim();

                newRow["zona"] = lines[2].Trim(); 
                newRow["centroam"] = lines[3].Trim(); 
                newRow["centropm"] = lines[4].Trim(); 
                newRow["recepcion"] = lines[5].Trim(); 

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

            giroIzq();

        }

        private void giroIzq()
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
            giroDer();
        }

        public void giroDer()
        {
            gMapControl1.Bearing -= 90; //10;
            lblGiro.Text = gMapControl1.Bearing.ToString();
            //gMapControl1.Bearing -= -50; //-140

            //if (gMapControl1.Bearing)
            //{

            //}

            //lblGirar.Text = gMapControl1.Bearing.ToString() + " " + trackBar1.Value.ToString();
            //
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
        }

        private PointLatLng ubicaCamion(string camion)
        {

            PointLatLng Position = new PointLatLng(0, 0);

            foreach (DataRow row in vdt.Rows)
            {
                //if (cmbCamionRuta.SelectedItem != null)
                //{
                if (camion.Equals(cerosIzq(row["numcamion"].ToString()))) //"name"
                {

                    if (row["fecha"].ToString().Equals(DateTime.Now.ToString("yyyy-MM-dd")))
                    {

                        Position = new PointLatLng(Convert.ToDouble(row["lat"]), Convert.ToDouble(row["lng"]));

                    }

                }
                //}

            }

            return Position;

        }

        private void ubicacionCamion()
        {

            foreach (DataRow row in vdt.Rows)
            {
                if (cmbCamionRuta.SelectedItem != null)
                {
                    if (cmbCamionRuta.SelectedItem.ToString().Equals(cerosIzq(row["numcamion"].ToString()))) //"name"
                    {
                        if (row["fechareg"].ToString().Equals(DateTime.Now.ToString("yyyy-MM-dd"))) //aqui
                        {
                            if (Convert.ToDouble(row["lat"]) > 0)
                            {
                                gMapControl1.Position = new PointLatLng(Convert.ToDouble(row["lat"]), Convert.ToDouble(row["lng"]));
                                zoomBuscar(18);                            
                            }
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

            for (int i = 1; i <= len; i++) {
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

            Principal.instance.toolStripTextBox1.Text = lblCoordenadas.Text;

            LatActual = lat;
            LngActual = lng;


            lblOrientacion.Text = orientacionCamion(LatAnterior, LngAnterior, lat, lng);
            //centrocorarl
            lblCorral.Text = corralUbicacion(dtUbictmp, lat, lng, gmindist, lblOrientacion.Text);


            LatAnterior = LatActual;
            LngAnterior = LngActual;

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

        private void buscarUbicacionBoton(string valor, bool apuntar)
        {

            this.Cursor = Cursors.WaitCursor;

            double vLatInicial = 0;
            double vLngInicial = 0;

            DataTable dt = new DataTable();

            //leerWsBuscarUbicacion(ref dt, txtBuscarUbicacion.Text);
            leerWsdlBuscarUbicacion(ref dt, valor);

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

            if (apuntar)
            {
                if (vLatInicial != 0 && vLngInicial != 0)
                {

                    gMapControl1.Position = new PointLatLng(vLatInicial, vLngInicial);
                    //gMapControl1.Zoom = 19;
                }
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
            verClasicos();
        }

        public void verClasicos()
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


            double LatInicial = 21.9237381314;
            double LngInicial = -98.7458896637;

            //double LatInicial = 21.923121;
            //double LngInicial = -98.745482;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);

            gMapControl1.Bearing = -230;//-50;//-140;
            gMapControl1.Zoom = 17;
            trackBar1.Value = Convert.ToInt32(gMapControl1.Zoom);

            //ubicActivo = false;
            //botonUbicaciones();

            //trackBar1.Visible = true;
            //btnRotarDer.Visible = true;
            //btnRotarIzq.Visible = true;

            trackBar1.Value = (int)gMapControl1.Zoom; // 17;
                                                      //timerMonitor.Enabled = true;



            double LatInicial2 = 21.9031937726;
            double LngInicial2 = -98.7462759018;
            gMapControl2.Position = new PointLatLng(LatInicial2, LngInicial2);

            gMapControl2.Bearing = -140;//-50;
            gMapControl2.Zoom = 16;



        }

        private void ecologicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verEcologicos();
        }

        public void verEcologicos()
        {

            vistaEcologicos();
            toolStripSplitButton2.Text = ecologicosToolStripMenuItem.Text;
            gorientacion = 0;
            //lblErrores.Text = gorientacion.ToString();
            //corralesActividadNombre();

            nombresCorral();
        }

        public void verHualul()
        {

            vistaTodo();
            toolStripSplitButton2.Text = ecologicosToolStripMenuItem.Text;
            gorientacion = 0;
            //lblErrores.Text = gorientacion.ToString();
            //corralesActividadNombre();

            nombresCorral();
        }

        private void vistaEcologicos()
        {




            double LatInicial = 21.8954191898;
            double LngInicial = -98.7381541729;

            //double LatInicial = 21.8956581077;
            //double LngInicial = -98.7377464771;

            //double LatInicial = 21.896245;
            //double LngInicial = -98.738959;
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


            double LatInicial2 = 21.923121;
            double LngInicial2 = -98.745482;
            gMapControl2.Position = new PointLatLng(LatInicial2, LngInicial2);

            gMapControl2.Bearing = -230;
            gMapControl2.Zoom = 16;


        }

        private void txtBuscarUbicacion_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            buscarUbicacionBoton(txtBuscarUbicacion.Text,true);
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

        private string obtenerConfigTxt(int indice)
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

        private DataRow obtenerConfigDB()
        {

            Datos datos = new Datos();
            DataTable dt = new DataTable();

            datos.p_sql = "SELECT TOP 1 * FROM configuracion";

            if (!datos.consultaSQL(ref dt, true))
            {
                MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    return row;
                }
            }

            return null;

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

            limpiaBotonesRut();

            listBoxRutaError.Items.Clear();
            lblRutaError.Text = "0";

            listBoxRutaError.Visible = false;
            picRecLimpia.Visible = false;
            label21.Visible = false;

            lblRutaError.Visible = false;

        }

        private void limpiaBotonesRut()
        {

            vselActRut = "00";

            picRec01.BackColor = Color.Transparent;
            picRec02.BackColor = Color.Transparent;
            picRec03.BackColor = Color.Transparent;
            picRec04.BackColor = Color.Transparent;
            picRec05.BackColor = Color.Transparent;
            picRec06.BackColor = Color.Transparent;
            picRec07.BackColor = Color.Transparent;
            picRec08.BackColor = Color.Transparent;
            picRec09.BackColor = Color.Transparent;
            picRec10.BackColor = Color.Transparent;
            picRec11.BackColor = Color.Transparent;
            picRec12.BackColor = Color.Transparent;
            picRec13.BackColor = Color.Transparent;
            picRec14.BackColor = Color.Transparent;
            picRec15.BackColor = Color.Transparent;
            picRec16.BackColor = Color.Transparent;
            picRec17.BackColor = Color.Transparent;
            picRec18.BackColor = Color.Transparent;
            picRec19.BackColor = Color.Transparent;
            picRec20.BackColor = Color.Transparent;
            picRec21.BackColor = Color.Transparent;
            picRec22.BackColor = Color.Transparent;

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

            string[] valores = { "VACIO", "0 - 20%", "20 - 40%", "40 - 75%", "75 - 95%", "95 - 105%", "EXCEDIO" };//, "ERROR" };

            listBoxLeyendas.Items.Clear();

            for (int i = 0; i < valores.Length; i++)
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

                if (dt.Rows.Count > 0)
                {

                    corralActividadLimpia();

                    corralesActividadNombre();

                    foreach (DataRow row in dt.Rows)
                    {
                        double valor = Convert.ToDouble(row["servidodia"]) / Convert.ToDouble(row["plandia"]) * 100;
                        //valor = -1;
                        corralActividadMod(row["corral"].ToString(), colorLeyenda(valor));

                        //if (txtFecha.Text.Equals(DateTime.Now.ToString("dd/MM/yyyy")))
                        //{
                        //    if (row["corral"].ToString() != row["corralgps"].ToString()
                        //        && row["corralgps"].ToString() != "0000"
                        //        && (
                        //           row["numcamion"].ToString() == "05"
                        //        || row["numcamion"].ToString() == "03"
                        //        || row["numcamion"].ToString() == "12"
                        //        || row["numcamion"].ToString() == "01"
                        //        || row["numcamion"].ToString() == "02"
                        //        )
                        //        )
                        //    {
                        //        corralActividadMod(row["corral"].ToString(), Color.Red);
                        //    }
                        //}

                    }

                    mostrarCamionRepartiendo(ref dt);

                }

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrores.Text = "Reparto, " + e.Message;
            }

        }

        private void mostrarRepartoCorralServida()
        {

            Boolean vfiltro = false;

            string[] valores = { "VACIO", "AM", "PM" };

            listBoxLeyendas.Items.Clear();

            for (int i = 0; i < valores.Length; i++)
            {
                listBoxLeyendas.Items.Add(valores[i]);
            }

            //dataGridVista.Rows.Clear();
            //llenarColores(true);

            colores.Clear();
            colores.Add(Color.White);
            colores.Add(Color.Orange);
            colores.Add(Color.LimeGreen);

            llenaGridValores(true);

            try
            {

                DataTable dt = new DataTable();

                obtenerWsdlServidasSap(ref dt);

                if (dt.Rows.Count > 0)
                {

                    corralActividadLimpia();

                    corralesActividadNombre();

                    dt.DefaultView.Sort = "numcamion asc";//"corral, hora asc";
                    dt = dt.DefaultView.ToTable();

                    if (cmbFiltroVista.Items.Count > 0 && !cmbFiltroVista.Text.Equals(vtodos))
                    {
                        dt.DefaultView.RowFilter = "numcamion = '" + cmbFiltroVista.Text + "'";
                        dt = dt.DefaultView.ToTable();
                        vfiltro = true;
                    }

                    foreach (DataRow row in dt.Rows)
                    {

                        switch (Int32.Parse(row["servida"].ToString()))
                        {
                            case 1:
                                //if( Color.White == corralColor(row["corral"].ToString()))
                                //{
                                corralActividadMod(row["corral"].ToString(), Color.Orange);
                                // }
                                break;
                            case 3:
                                corralActividadMod(row["corral"].ToString(), Color.Orange);
                                break;
                            case 2:
                                corralActividadMod(row["corral"].ToString(), Color.LimeGreen);
                                break;
                        }

                        /////////////////////
                        //if (row["corral"].ToString()=="2020")
                        //{
                        //    corralActividadMod(row["corral"].ToString(), Color.Transparent);

                        //}
                        ////////////////////

                    }

                    mostrarCamionRepartiendo(ref dt);

                }

            }
            catch (Exception e)
            {
                lblErrores.Text = "Reparto, " + e.Message;
            }

        }

        private void mostrarDimensionesCorral()
        {



            try
            {

                DataTable dt = new DataTable();

                obtenerWsdlDimensionesSap(ref dt);

                if (dt.Rows.Count > 0)
                {

                    corralActividadLimpia();

                    corralesActividadNombre();


                    foreach (DataRow row in dt.Rows)
                    {

                        corralActividadMod(row["corral"].ToString(), Color.Blue);
       
                        

                    }

                }

            }
            catch (Exception e)
            {
                lblErrores.Text = "Dimensiones, " + e.Message;
            }




        }

        private void mostrarCamionRepartiendo(ref DataTable dt)
        {


            DataTable dtLocal = new DataTable();
            dtLocal = dt.Copy();

            dtLocal.DefaultView.Sort = "numcamion, horareg desc";
            dtLocal = dtLocal.DefaultView.ToTable();

            for (int i = 1; i <= totCam; i++)
            {

                DataRow[] foundRows1 = dtLocal.Select("numcamion='" + cerosIzq(i.ToString().Trim()) + "'");

                if (foundRows1.Length > 0)
                {
                    DataRow item1 = foundRows1[0];
                    mostrarCamionStatus(item1["numcamion"].ToString(), horaInactiva(item1["horareg"].ToString()));
                }


            }

            /*
            foreach (DataRow row in dtLocal.Rows)
            {
                string camion = row["numcamion"].ToString();
                string hora = row["horareg"].ToString();
             
            }

            mostrarCamionStatus("01", horaInactiva(hora));
            mostrarCamionStatus("05", true);
            mostrarCamionStatus("07", false);
            */

        }

        private Boolean horaInactiva(string hora)
        {

            Boolean resultado = false;

            string horaAct = DateTime.Now.ToString("HH") + ":" + DateTime.Now.ToString("mm") + ":" + DateTime.Now.ToString("ss");
            DateTime hora1 = Convert.ToDateTime(hora);
            DateTime hora2 = Convert.ToDateTime(horaAct);
            TimeSpan demora = hora2.Subtract(hora1);
            Image vimg;

            if (demora.TotalMinutes <= Convert.ToDouble(inactividad))
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;

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

                corralActividadLimpia();

                corralesActividadNombres(ref dtCabezastmp);

                //if (dt.Rows.Count > 0)
                //{
                //    foreach (DataRow row in dt.Rows)
                //    {
                //        int valor = Convert.ToInt32(row["cabezas"]);

                //        //corralActividadMod(row["corral"].ToString(), colorLeyenda(valor));
                //    }
                //}

                switch (gopc)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        botonCeldasActividad(1);
                        break;
                }



            }
            catch (Exception e)
            {
                lblErrores.Text = "Cabezas, " + e.Message;
            }

            //this.Cursor = Cursors.Default;

        }


        private void mostrarCabezasDimensionesCorral()
        {

            //this.Cursor = Cursors.WaitCursor;

            try
            {

                //DataTable dt = new DataTable();

                obtenerWsdlCabezasSap(ref dtCabezastmp);

                corralActividadLimpia();

                corralesActividadNombres(ref dtCabezastmp);


                DataTable dt = new DataTable();

                obtenerWsdlDimensionesSap(ref dt);
                dtRepartotmp.Clear();
                

                if (dt.Rows.Count > 0)
                {

                    //corralActividadLimpia();

                    //corralesActividadNombre();

                    foreach (DataRow row in dt.Rows)
                    {

                        DataRow[] filasFiltradas = dtCabezastmp.Select("corral = '" + row["corral"].ToString() + "'");
                        if (filasFiltradas.Length > 0)
                        {
                            DataRow fila = filasFiltradas[0]; // Primer resultado
                            double cabezas = Convert.ToDouble(fila["cabezas"]);

                            double msombra = Convert.ToDouble(row["msombra"]);
                            double mcorral = Convert.ToDouble(row["mcorral"]);
                            double mcomedero = Convert.ToDouble(row["mcomedero"]);
                            double mbebedero = Convert.ToDouble(row["mbebedero"]);

                            double resultado1 = 0;
                            double resultado2 = 0;
                            double resultado3 = 0;
                            double resultado4 = 0;

                            if (cabezas!=0) 
                            {
                                resultado1 = msombra / cabezas;
                                resultado2 = mcorral / cabezas;
                                resultado3 = mcomedero / cabezas;
                                resultado4 = mbebedero / cabezas;
                            }
                  
                            corralActividadMod(row["corral"].ToString(), Color.Blue);                            
                           
                        }

                    }

                }





                //if (dt.Rows.Count > 0)
                //{
                //    foreach (DataRow row in dt.Rows)
                //    {
                //        int valor = Convert.ToInt32(row["cabezas"]);

                //        //corralActividadMod(row["corral"].ToString(), colorLeyenda(valor));
                //    }
                //}

                switch (gopc)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        botonCeldasActividad(1);
                        break;
                }



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
            graphicImage.DrawString(id, new Font("Arial", 13, FontStyle.Bold), drawBrush, punto);
            graphicImage.Dispose();


            return bmpmarker;

        }

        private void mostrarCamionActivo(String camion, Boolean estado)
        {

            try
            {

                Image imagen;
                Color color;

                if (estado)
                {
                    imagen = CamionInAct;
                    color = Color.LimeGreen;
                }
                else
                {
                    imagen = imageList1.Images[0];
                    color = Color.Transparent;
                }

                camion = cerosIzq(camion);

                //inactivarNumCam();

                switch (camion)
                {
                    case "01":
                        valoresEtiquetas2(
                         picCam01,
                         picGpsCam01,
                         picRepCam01,
                         picGps2Cam01,
                         picRep2Cam01,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "02":
                        valoresEtiquetas2(
                         picCam02,
                         picGpsCam02,
                         picRepCam02,
                         picGps2Cam02,
                         picRep2Cam02,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "03":
                        valoresEtiquetas2(
                         picCam03,
                         picGpsCam03,
                         picRepCam03,
                         picGps2Cam03,
                         picRep2Cam03,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "04":
                        valoresEtiquetas2(
                         picCam04,
                         picGpsCam04,
                         picRepCam04,
                         picGps2Cam04,
                         picRep2Cam04,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "05":
                        valoresEtiquetas2(
                         picCam05,
                         picGpsCam05,
                         picRepCam05,
                         picGps2Cam05,
                         picRep2Cam05,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "06":
                        valoresEtiquetas2(
                         picCam06,
                         picGpsCam06,
                         picRepCam06,
                         picGps2Cam06,
                         picRep2Cam06,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "07":
                        valoresEtiquetas2(
                         picCam07,
                         picGpsCam07,
                         picRepCam07,
                         picGps2Cam07,
                         picRep2Cam07,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "08":
                        valoresEtiquetas2(
                         picCam08,
                         picGpsCam08,
                         picRepCam08,
                         picGps2Cam08,
                         picRep2Cam08,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "09":
                        valoresEtiquetas2(
                         picCam09,
                         picGpsCam09,
                         picRepCam09,
                         picGps2Cam09,
                         picRep2Cam09,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "10":
                        valoresEtiquetas2(
                         picCam10,
                         picGpsCam10,
                         picRepCam10,
                         picGps2Cam10,
                         picRep2Cam10,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "11":
                        valoresEtiquetas2(
                         picCam11,
                         picGpsCam11,
                         picRepCam11,
                         picGps2Cam11,
                         picRep2Cam11,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "12":
                        valoresEtiquetas2(
                         picCam12,
                         picGpsCam12,
                         picRepCam12,
                         picGps2Cam12,
                         picRep2Cam12,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "13":
                        valoresEtiquetas2(
                         picCam13,
                         picGpsCam13,
                         picRepCam13,
                         picGps2Cam13,
                         picRep2Cam13,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "14":
                        valoresEtiquetas2(
                         picCam14,
                         picGpsCam14,
                         picRepCam14,
                         picGps2Cam14,
                         picRep2Cam14,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "15":
                        valoresEtiquetas2(
                         picCam15,
                         picGpsCam15,
                         picRepCam15,
                         picGps2Cam15,
                         picRep2Cam15,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "16":
                        valoresEtiquetas2(
                         picCam16,
                         picGpsCam16,
                         picRepCam16,
                         picGps2Cam16,
                         picRep2Cam16,
                         imagen,
                         camion,
                         color
                         );
                        break;

                    case "17":
                        valoresEtiquetas2(
                         picCam17,
                         picGpsCam17,
                         picRepCam17,
                         picGps2Cam17,
                         picRep2Cam17,
                         imagen,
                         camion,
                         color
                         );
                        break;

                    case "18":
                        valoresEtiquetas2(
                         picCam18,
                         picGpsCam18,
                         picRepCam18,
                         picGps2Cam18,
                         picRep2Cam18,
                         imagen,
                         camion,
                         color
                         );
                        break;

                    case "19":
                        valoresEtiquetas2(
                         picCam19,
                         picGpsCam19,
                         picRepCam19,
                         picGps2Cam19,
                         picRep2Cam19,
                         imagen,
                         camion,
                         color
                         );
                        break;

                    case "20":
                        valoresEtiquetas2(
                         picCam20,
                         picGpsCam20,
                         picRepCam20,
                         picGps2Cam20,
                         picRep2Cam20,
                         imagen,
                         camion,
                         color
                         );
                        break;

                    case "21":
                        valoresEtiquetas2(
                         picCam21,
                         picGpsCam21,
                         picRepCam21,
                         picGps2Cam21,
                         picRep2Cam21,
                         imagen,
                         camion,
                         color
                         );
                        break;

                    case "22":
                        valoresEtiquetas2(
                         picCam22,
                         picGpsCam22,
                         picRepCam22,
                         picGps2Cam22,
                         picRep2Cam22,
                         imagen,
                         camion,
                         color
                         );
                        break;

                    case "23":
                        valoresEtiquetas2(
                         picCam23,
                         picGpsCam23,
                         picRepCam23,
                         picGps2Cam23,
                         picRep2Cam23,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "24":
                        valoresEtiquetas2(
                         picCam24,
                         picGpsCam24,
                         picRepCam24,
                         picGps2Cam24,
                         picRep2Cam24,
                         imagen,
                         camion,
                         color
                         );
                        break;

                    case "25":
                        valoresEtiquetas2(
                         picCam25,
                         picGpsCam25,
                         picRepCam25,
                         picGps2Cam25,
                         picRep2Cam25,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "26":
                        valoresEtiquetas2(
                         picCam26,
                         picGpsCam26,
                         picRepCam26,
                         picGps2Cam26,
                         picRep2Cam26,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "27":
                        valoresEtiquetas2(
                         picCam27,
                         picGpsCam27,
                         picRepCam27,
                         picGps2Cam27,
                         picRep2Cam27,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "28":
                        valoresEtiquetas2(
                         picCam28,
                         picGpsCam28,
                         picRepCam28,
                         picGps2Cam28,
                         picRep2Cam28,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "29":
                        valoresEtiquetas2(
                         picCam29,
                         picGpsCam29,
                         picRepCam29,
                         null,//picGps2Cam29,
                         null,//picRep2Cam29,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "30":
                        valoresEtiquetas2(
                         picCam30,
                         picGpsCam30,
                         picRepCam30,
                         null,//picGps2Cam30,
                         null,//picRep2Cam30,
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "31":
                        valoresEtiquetas2(
                         picCam31,
                         picGpsCam31,
                         picRepCam31,
                         null, // picGps2Cam31
                         null, // picRep2Cam31
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "32":
                        valoresEtiquetas2(
                         picCam32,
                         picGpsCam32,
                         picRepCam32,
                         null, // picGps2Cam32
                         null, // picRep2Cam32
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "33":
                        valoresEtiquetas2(
                         picCam33,
                         picGpsCam33,
                         picRepCam33,
                         null, // picGps2Cam33
                         null, // picRep2Cam33
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "34":
                        valoresEtiquetas2(
                         picCam34,
                         picGpsCam34,
                         picRepCam34,
                         null, // picGps2Cam34
                         null, // picRep2Cam34
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "35":
                        valoresEtiquetas2(
                         picCam35,
                         picGpsCam35,
                         picRepCam35,
                         null, // picGps2Cam35
                         null, // picRep2Cam35
                         imagen,
                         camion,
                         color
                         );
                        break;
                    case "36":
                        valoresEtiquetas2(
                         picCam36,
                         picGpsCam36,
                         picRepCam36,
                         null, // picGps2Cam36
                         null, // picRep2Cam36
                         imagen,
                         camion,
                         color
                         );
                        break;





                }

                //switch (camion)
                //{
                //    case "01":
                //        picCam01.Image = numeroImagen(imagen, camion);
                //        picGpsCam01.BackColor = color;
                //        if (picRepCam01.BackColor != Color.Transparent && picGpsCam01.BackColor == Color.Transparent)
                //        {
                //            picGpsCam01.BackColor = Color.Red;
                //        }
                //        break;
                //    case "02":
                //        picCam02.Image = numeroImagen(imagen, camion);
                //        picGpsCam02.BackColor = color;
                //        if (picRepCam02.BackColor != Color.Transparent && picGpsCam02.BackColor == Color.Transparent)
                //        {
                //            picGpsCam02.BackColor = Color.Red;
                //        }
                //        break;
                //    case "03":
                //        picCam03.Image = numeroImagen(imagen, camion);
                //        picGpsCam03.BackColor = color;
                //        if (picRepCam03.BackColor != Color.Transparent && picGpsCam03.BackColor == Color.Transparent)
                //        {
                //            picGpsCam03.BackColor = Color.Red;
                //        }
                //        break;
                //    case "04":
                //        picCam04.Image = numeroImagen(imagen, camion);
                //        picGpsCam04.BackColor = color;
                //        if (picRepCam04.BackColor != Color.Transparent && picGpsCam04.BackColor == Color.Transparent)
                //        { 
                //            picGpsCam04.BackColor = Color.Red;
                //        }
                //        break;
                //    case "05":
                //        picCam05.Image = numeroImagen(imagen, camion);
                //        picGpsCam05.BackColor = color;
                //        if (picRepCam05.BackColor != Color.Transparent && picGpsCam05.BackColor == Color.Transparent)
                //        {
                //            picGpsCam05.BackColor = Color.Red;
                //        }
                //        break;
                //    case "06":
                //        picCam06.Image = numeroImagen(imagen, camion);
                //        picGpsCam06.BackColor = color;
                //        if (picRepCam06.BackColor != Color.Transparent && picGpsCam06.BackColor == Color.Transparent)
                //        {
                //            picGpsCam06.BackColor = Color.Red;
                //        }
                //        break;
                //    case "07":
                //        picCam07.Image = numeroImagen(imagen, camion);
                //        picGpsCam07.BackColor = color;
                //        if (picRepCam07.BackColor != Color.Transparent && picGpsCam07.BackColor == Color.Transparent)
                //        {
                //            picGpsCam07.BackColor = Color.Red;
                //        }
                //        break;
                //    case "08":
                //        picCam08.Image = numeroImagen(imagen, camion);
                //        picGpsCam08.BackColor = color;
                //        if (picRepCam08.BackColor != Color.Transparent && picGpsCam08.BackColor == Color.Transparent)
                //        {
                //            picGpsCam08.BackColor = Color.Red;
                //        }
                //        break;
                //    case "09":
                //        picCam09.Image = numeroImagen(imagen, camion);
                //        picGpsCam09.BackColor = color;
                //        if (picRepCam09.BackColor != Color.Transparent && picGpsCam09.BackColor == Color.Transparent)
                //        {
                //            picGpsCam09.BackColor = Color.Red;
                //        }
                //        break;
                //    case "10":
                //        picCam10.Image = numeroImagen(imagen, camion);
                //        picGpsCam10.BackColor = color;
                //        if (picRepCam10.BackColor != Color.Transparent && picGpsCam10.BackColor == Color.Transparent)
                //        {
                //            picGpsCam10.BackColor = Color.Red;
                //        }
                //        break;
                //    case "11":
                //        picCam11.Image = numeroImagen(imagen, camion);
                //        picGpsCam11.BackColor = color;
                //        if (picRepCam11.BackColor != Color.Transparent && picGpsCam11.BackColor == Color.Transparent)
                //        {
                //            picGpsCam11.BackColor = Color.Red;
                //        }
                //        break;
                //    case "12":
                //        picCam12.Image = numeroImagen(imagen, camion);
                //        picGpsCam12.BackColor = color;
                //        if (picRepCam12.BackColor != Color.Transparent && picGpsCam12.BackColor == Color.Transparent)
                //        {
                //            picGpsCam12.BackColor = Color.Red;
                //        }
                //        break;
                //    case "13":
                //        picCam13.Image = numeroImagen(imagen, camion);
                //        picGpsCam13.BackColor = color;
                //        if (picRepCam13.BackColor != Color.Transparent && picGpsCam13.BackColor == Color.Transparent)
                //        {
                //            picGpsCam13.BackColor = Color.Red;
                //        }
                //        break;
                //    case "14":
                //        picCam14.Image = numeroImagen(imagen, camion);
                //        picGpsCam14.BackColor = color;
                //        if (picRepCam14.BackColor != Color.Transparent && picGpsCam14.BackColor == Color.Transparent)
                //        {
                //            picGpsCam14.BackColor = Color.Red;
                //        }
                //        break;
                //    case "15":
                //        //picCam15.Image = numeroImagen(imagen, camion);
                //        //picGpsCam15.BackColor = color;
                //        //if (picRepCam15.BackColor != Color.Transparent && picGpsCam15.BackColor == Color.Transparent)
                //        //{
                //        //    picGpsCam15.BackColor = Color.Red;
                //        //}
                //        valoresEtiquetas2(
                //         picCam15,
                //         picGpsCam15,
                //         picRepCam15,             
                //         imagen,
                //         camion,
                //         color
                //        );
                //        break;
                //}

            }
            catch { }

        }

        private void valoresEtiquetas2(
            PictureBox picCam,
            PictureBox picGpsCam,
            PictureBox picRepCam,
            PictureBox picGps2Cam,
            PictureBox picRep2Cam,
            Image pimagen,
            string pcamion,
            Color pcolor
            )
        {

            //picCam.Image = numeroImagen(pimagen, pcamion);

            //if (picGpsCam.BackColor != pcolor)
            //{

            //    if (pcolor == Color.LimeGreen)
            //    {
            //        notificacion(1000, "Conecto", "Cam " + pcamion, ToolTipIcon.Info);
            //    }   

            //    if (pcolor == Color.Transparent)
            //    {
            //        notificacion(1000, "Desconecto", "Cam "+ pcamion, ToolTipIcon.Error );
            //    }

            //}

            picGpsCam.BackColor = pcolor;

            if (picRepCam.BackColor != Color.Transparent && picGpsCam.BackColor == Color.Transparent)
            {
                //picGpsCam.BackColor = Color.Red;
            }

            //picRep2Cam.BackColor = picRepCam.BackColor;
            if(picGps2Cam != null) picGps2Cam.BackColor = picGpsCam.BackColor;

            //if (picRepCam.BackColor != Color.Transparent && picGpsCam.BackColor == Color.Transparent)
            //{
            //    picGps2Cam.BackColor = Color.Red;
            //}
            //else
            //{
            //    picGps2Cam.BackColor = picGpsCam.BackColor;
            //}

            picCam.Image = numeroImagen(pimagen, pcamion);


        }

        private void mostrarCamionStatus(String camion, Boolean estado)
        {

            try
            {

                Color color;

                if (estado)
                {
                    color = Color.LimeGreen;
                }
                else
                {
                    color = Color.Transparent;
                }

                camion = cerosIzq(camion);

                switch (camion)
                {
                    case "01":
                        picRepCam01.BackColor = color;
                        picRep2Cam01.BackColor = color;
                        break;
                    case "02":
                        picRepCam02.BackColor = color;
                        picRep2Cam02.BackColor = color;
                        break;
                    case "03":
                        picRepCam03.BackColor = color;
                        picRep2Cam03.BackColor = color;
                        break;
                    case "04":
                        picRepCam04.BackColor = color;
                        picRep2Cam04.BackColor = color;
                        break;
                    case "05":
                        picRepCam05.BackColor = color;
                        picRep2Cam05.BackColor = color;
                        break;
                    case "06":
                        picRepCam06.BackColor = color;
                        picRep2Cam06.BackColor = color;
                        break;
                    case "07":
                        picRepCam07.BackColor = color;
                        picRep2Cam07.BackColor = color;
                        break;
                    case "08":
                        picRepCam08.BackColor = color;
                        picRep2Cam08.BackColor = color;
                        break;
                    case "09":
                        picRepCam09.BackColor = color;
                        picRep2Cam09.BackColor = color;
                        break;
                    case "10":
                        picRepCam10.BackColor = color;
                        picRep2Cam10.BackColor = color;
                        //ToolTip tt = new ToolTip();
                        //tt.SetToolTip(this.picRepCam10, "Your username");
                        break;
                    case "11":
                        picRepCam11.BackColor = color;
                        picRep2Cam11.BackColor = color;
                        break;
                    case "12":
                        picRepCam12.BackColor = color;
                        picRep2Cam12.BackColor = color;
                        break;
                    case "13":
                        picRepCam13.BackColor = color;
                        picRep2Cam13.BackColor = color;
                        break;
                    case "14":
                        picRepCam14.BackColor = color;
                        picRep2Cam14.BackColor = color;
                        break;
                    case "15":
                        picRepCam15.BackColor = color;
                        picRep2Cam15.BackColor = color;
                        break;
                    case "16":
                        picRepCam16.BackColor = color;
                        picRep2Cam16.BackColor = color;
                        break;
                    case "17":
                        picRepCam17.BackColor = color;
                        picRep2Cam17.BackColor = color;
                        break;
                    case "18":
                        picRepCam18.BackColor = color;
                        picRep2Cam18.BackColor = color;
                        break;
                    case "19":
                        picRepCam19.BackColor = color;
                        picRep2Cam19.BackColor = color;
                        break;
                    case "20":
                        picRepCam20.BackColor = color;
                        picRep2Cam20.BackColor = color;
                        break;
                    case "21":
                        picRepCam21.BackColor = color;
                        picRep2Cam21.BackColor = color;
                        break;
                    case "22":
                        picRepCam22.BackColor = color;
                        picRep2Cam22.BackColor = color;
                        break;
                    case "23":
                        picRepCam23.BackColor = color;
                        picRep2Cam23.BackColor = color;
                        break;
                    case "24":
                        picRepCam24.BackColor = color;
                        picRep2Cam24.BackColor = color;
                        break;
                    case "25":
                        picRepCam25.BackColor = color;
                        picRep2Cam25.BackColor = color;
                        break;
                    case "26":
                        picRepCam26.BackColor = color;
                        picRep2Cam26.BackColor = color;
                        break;
                    case "27":
                        picRepCam27.BackColor = color;
                        picRep2Cam27.BackColor = color;
                        break;
                    case "28":
                        picRepCam28.BackColor = color;
                        picRep2Cam28.BackColor = color;
                        break;
                    case "29":
                        picRepCam29.BackColor = color;
                        //picRep2Cam29.BackColor = color;
                        break;
                    case "30":
                        picRepCam30.BackColor = color;
                        //picRep2Cam30.BackColor = color;
                        break;
                    case "31":
                        picRepCam31.BackColor = color;
                        //picRep2Cam31.BackColor = color;
                        break;
                    case "32":
                        picRepCam32.BackColor = color;
                        //picRep2Cam32.BackColor = color;
                        break;
                    case "33":
                        picRepCam33.BackColor = color;
                        //picRep2Cam33.BackColor = color;
                        break;
                    case "34":
                        picRepCam34.BackColor = color;
                        //picRep2Cam34.BackColor = color;
                        break;
                    case "35":
                        picRepCam35.BackColor = color;
                        //picRep2Cam35.BackColor = color;
                        break;
                    case "36":
                        picRepCam36.BackColor = color;
                        //picRep2Cam36.BackColor = color;
                        break;

                }

            }
            catch { }

        }

        private void iniciaNumeroCamion()
        {

            picCam01.Image = numeroImagen(CamionInAct, "01");
            picCam02.Image = numeroImagen(CamionInAct, "02");
            picCam03.Image = numeroImagen(CamionInAct, "03");
            picCam04.Image = numeroImagen(CamionInAct, "04");
            picCam05.Image = numeroImagen(CamionInAct, "05");
            picCam06.Image = numeroImagen(CamionInAct, "06");
            picCam07.Image = numeroImagen(CamionInAct, "07");
            picCam08.Image = numeroImagen(CamionInAct, "08");
            picCam09.Image = numeroImagen(CamionInAct, "09");
            picCam10.Image = numeroImagen(CamionInAct, "10");
            picCam11.Image = numeroImagen(CamionInAct, "11");
            picCam12.Image = numeroImagen(CamionInAct, "12");
            picCam13.Image = numeroImagen(CamionInAct, "13");
            picCam14.Image = numeroImagen(CamionInAct, "14");
            picCam15.Image = numeroImagen(CamionInAct, "15");
            picCam16.Image = numeroImagen(CamionInAct, "16");
            picCam17.Image = numeroImagen(CamionInAct, "17");
            picCam18.Image = numeroImagen(CamionInAct, "18");
            picCam19.Image = numeroImagen(CamionInAct, "19");
            picCam20.Image = numeroImagen(CamionInAct, "20");
            picCam21.Image = numeroImagen(CamionInAct, "21");
            picCam22.Image = numeroImagen(CamionInAct, "22");
            picCam23.Image = numeroImagen(CamionInAct, "23");
            picCam24.Image = numeroImagen(CamionInAct, "24");

            picCam25.Image = numeroImagen(CamionInAct, "25");
            picCam26.Image = numeroImagen(CamionInAct, "26");
            picCam27.Image = numeroImagen(CamionInAct, "27");
            picCam28.Image = numeroImagen(CamionInAct, "28");

        }

        private void mostrarCamionesActivos()
        {

            try
            {
                //this.Cursor = Cursors.WaitCursor;

                ArrayList camiones = new ArrayList();

                picCam01.Image = numeroImagen(CamionInAct, "01");
                picCam02.Image = numeroImagen(CamionInAct, "02");
                picCam03.Image = numeroImagen(CamionInAct, "03");
                picCam04.Image = numeroImagen(CamionInAct, "04");
                picCam05.Image = numeroImagen(CamionInAct, "05");
                picCam06.Image = numeroImagen(CamionInAct, "06");
                picCam07.Image = numeroImagen(CamionInAct, "07");
                picCam08.Image = numeroImagen(CamionInAct, "08");
                picCam09.Image = numeroImagen(CamionInAct, "09");
                picCam10.Image = numeroImagen(CamionInAct, "10");
                picCam11.Image = numeroImagen(CamionInAct, "11");
                picCam12.Image = numeroImagen(CamionInAct, "12");
                picCam13.Image = numeroImagen(CamionInAct, "13");
                picCam14.Image = numeroImagen(CamionInAct, "14");
                picCam15.Image = numeroImagen(CamionInAct, "15");
                picCam16.Image = numeroImagen(CamionInAct, "16");
                picCam17.Image = numeroImagen(CamionInAct, "17");
                picCam18.Image = numeroImagen(CamionInAct, "18");
                picCam19.Image = numeroImagen(CamionInAct, "19");
                picCam20.Image = numeroImagen(CamionInAct, "20");
                picCam21.Image = numeroImagen(CamionInAct, "21");
                picCam22.Image = numeroImagen(CamionInAct, "22");
                picCam23.Image = numeroImagen(CamionInAct, "23");
                picCam24.Image = numeroImagen(CamionInAct, "24");

                picCam25.Image = numeroImagen(CamionInAct, "25");
                picCam26.Image = numeroImagen(CamionInAct, "26");
                picCam27.Image = numeroImagen(CamionInAct, "27");
                picCam28.Image = numeroImagen(CamionInAct, "28");



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
                            case "16":
                                picCam16.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "17":
                                picCam17.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "18":
                                picCam18.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "19":
                                picCam19.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "20":
                                picCam20.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "21":
                                picCam21.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "22":
                                picCam22.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "23":
                                picCam23.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "24":
                                picCam24.Image = numeroImagen(imageList1.Images[0], camion);
                                break;

                            case "25":
                                picCam25.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "26":
                                picCam26.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "27":
                                picCam27.Image = numeroImagen(imageList1.Images[0], camion);
                                break;
                            case "28":
                                picCam28.Image = numeroImagen(imageList1.Images[0], camion);
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

                llenarColores(false);//true); incluye blanco para vacio

                int cont = 0;

                foreach (Color clr in colores) { cont++; }

                int indexcolor = 0;
                Color vcolor = Color.White;

                DataTable dt = new DataTable();

                //dataGridVista.Rows.Clear();

                obtenerWsdlServidasSap(ref dt);

                if (dt.Rows.Count > 0)
                {

                    corralActividadLimpia();

                    corralesActividadNombre();

                    listBoxLeyendas.Items.Clear();
                    //dataGridVista.Rows.Clear();

                    dt.DefaultView.Sort = columna + " asc";
                    dt = dt.DefaultView.ToTable();

                    if (cmbFiltroVista.Items.Count > 0 && !cmbFiltroVista.Text.Equals(vtodos))
                    {
                        dt.DefaultView.RowFilter = columna + " = '" + cmbFiltroVista.Text + "'";
                        dt = dt.DefaultView.ToTable();
                        vfiltro = true;
                    }



                    //listBoxLeyendas.Items.Add("VACIO");

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

                    mostrarCamionRepartiendo(ref dt);

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

            //jjj
            //return;

            DataTable dtUbictmp = new DataTable();

            dtUbictmp.Columns.Add("valor");
            dtUbictmp.Columns.Add("color");

            for (int i = 0; i < listBoxLeyendas.Items.Count; i++)
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

                    dataGridVista[0, count].Style.BackColor = SystemColors.Control;
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
            switch (indiceBotonVistaSel)
            {
                case 5:
                    mostrarCabezasCorral();
                    break;
                default:
                    corralesActividadNombre();
                    break;
            }

        }

        private void obtenerWsdlServidasSap(ref DataTable dtsalida)
        {

            if (gTimerActivo1)
            {
                if (gMostrarRepartos)
                {
                    gMostrarRepartos = false;
                }
                else
                {
                    return;
                }
            }


            //Cursor = Cursors.WaitCursor;

            if (txtFecha.Text.Equals(DateTime.Now.ToString("dd/MM/yyyy")))
            {
                seleccion = "REPARTO"; //envio datos camion en vivo HOY
            }
            else
            {
                seleccion = "SERVIDAS"; //subido archivo en sap AYER
            }

            Thread t = new Thread(() => { cargarWSDLSel(seleccion, Convert.ToDateTime(txtFecha.Text), Convert.ToDateTime(txtFecha.Text)); });
            t.Name = seleccion;
            t.IsBackground = true;

            DateTime inicio = DateTime.UtcNow;
            t.Start();

            //Console.WriteLine(t.Name + " " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString());

            //while (t.IsAlive)
            //{
            //    Thread.Sleep(50);
            //    Application.DoEvents();
            //}

            t.Join();
            TimeSpan dur = DateTime.UtcNow - inicio;
            Console.WriteLine(t.Name + "(x) " + t.ManagedThreadId.ToString() + " " + DateTime.Now.ToString() + " tiempo: " + dur);


            lista = connectar.getList();
            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();

            if (lista.Count == 0) { return; }


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
            dttmp.Columns.Add("horareg");
            dttmp.Columns.Add("fechareg");


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

                if (seleccion == "REPARTO")
                {
                    newRow["corralgps"] = lines[10].Trim();

                    lines[14] = lines[14].Insert(2, ":");
                    lines[14] = lines[14].Insert(5, ":");
                    newRow["horareg"] = lines[14].Trim();

                    lines[13] = lines[13].Insert(4, "-");
                    lines[13] = lines[13].Insert(7, "-");
                    newRow["fechareg"] = lines[13].Trim();
                }

                dttmp.Rows.Add(newRow);

            }

            dtsalida = dttmp;

            dtRepartotmp = dtsalida;

            //Cursor = Cursors.Default;

            //if (!errormsg.Equals("")) { MessageBox.Show(errormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            if (errormsg != null)
            {
                if (!errormsg.Equals("")) { lblErrores.Text = errormsg; }
            }

        }

        private void obtenerWsdlDimensionesSap(ref DataTable dtsalida)
        {

            //Cursor = Cursors.WaitCursor;

            seleccion = "DIMENSIONES"; 


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

            if (lista.Count == 0) { return; }


            DataTable dttmp = new DataTable();
            dttmp.Columns.Add("corral");
            dttmp.Columns.Add("seccion");
            dttmp.Columns.Add("orientacion");
            dttmp.Columns.Add("lineascom");
            dttmp.Columns.Add("capacidad");
            dttmp.Columns.Add("areaact");
            dttmp.Columns.Add("msombra");
            dttmp.Columns.Add("mcorral");
            dttmp.Columns.Add("mcomedero");
            dttmp.Columns.Add("mbebedero");




            foreach (String listar in lista)
            {

                string[] lines = listar.Split('|');

                DataRow newRow = dttmp.NewRow();

                newRow["corral"] = lines[0].Trim();
                newRow["seccion"] = lines[1].Trim();
                newRow["orientacion"] = lines[2].Trim();
                newRow["lineascom"] = lines[3].Trim();
                newRow["capacidad"] = lines[4].Trim();
                newRow["areaact"] = lines[5].Trim();
                newRow["msombra"] = lines[6].Trim();
                newRow["mcorral"] = lines[7].Trim();
                newRow["mcomedero"] = lines[8].Trim();
                newRow["mbebedero"] = lines[9].Trim();



                dttmp.Rows.Add(newRow);

            }

            dtsalida = dttmp;

            //dtRepartotmp = dtsalida;

            //Cursor = Cursors.Default;

            //if (!errormsg.Equals("")) { MessageBox.Show(errormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            if (errormsg != null)
            {
                if (!errormsg.Equals("")) { lblErrores.Text = errormsg; }
            }

        }


        private void obtenerWsdlRepartoSap(ref DataTable dtsalida)
        {

            //Cursor = Cursors.WaitCursor;

            if (txtFecha.Text.Equals(DateTime.Now.ToString("dd/MM/yyyy")))
            {
                seleccion = "REPARTO"; //envio datos camion en vivo HOY
            }
            else
            {
                seleccion = "REPARTOS"; //en sap AYER
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

            if (lista.Count == 0) { return; }

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

            if (lista.Count == 0) { return; }

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

        private void obtenerWsdlPlanesSap(ref DataTable dtsalida)
        {

            //Cursor = Cursors.WaitCursor;

            seleccion = "PLANES";


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

            if (lista.Count == 0) { return; }

            DataTable dttmp = new DataTable();

            dttmp.Columns.Add("corral");



            foreach (String listar in lista)
            {

                string[] lines = listar.Split('|');

                if (lines[3].Trim() == "1") { continue; }
                
                DataRow newRow = dttmp.NewRow();

                newRow["corral"] = lines[3].Trim();

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

            if (lista.Count == 0) { return; }

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

            double LatInicial = 21.9109579774;
            double LngInicial = -98.7391090393;
            //double LatInicial = 21.909286;
            //double LngInicial = -98.740869;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.Zoom = 15;//16;

            //gMapControl1.Bearing = -90;
            gMapControl1.Bearing = -140;//-50;
            //trackBar1.Visible = true;
            //btnRotarDer.Visible = true;
            //btnRotarIzq.Visible = true;

            //ubicActivo = true;
            //botonUbicaciones();
            trackBar1.Value = (int)gMapControl1.Zoom; // 16;
                                                      //timerMonitor.Enabled = false;


            double LatInicial2 = 21.909286;
            double LngInicial2 = -98.740869;
            gMapControl2.Position = new PointLatLng(LatInicial2, LngInicial2);
            gMapControl2.Zoom = 15;//16;

        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {

            indiceBoton += 1;

            switch (indiceBoton)
            {
                case 1:
                    todoToolStripMenuItem_Click(sender, e);
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
                    //chart2.Visible = true;
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
                    chart2.Visible = false;
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
                    chart2.Visible = false;
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
            calendarioNegritas(iniFecha, finFecha);

            panelFecha.Visible = !panelFecha.Visible;
            toolStripButton9.Enabled = false;



            monthCalendar1.SelectionStart = DateTime.Parse(txtFecha.Text);
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
                } while (fecha <= fechaf);

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

            refrescaGraficos();

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

        private void graficoBarras()
        {

            //if (panelActCamiones.Visible)
            if (panelCam01.Visible)
            //if (!splitContainerMapa.Panel2Collapsed)
            {

                //obtenerWsdlServidasSap(ref dtRepartotmp);

                foreach (String camion in cmbCamion.Items)
                {

                    double vplandia = 0;
                    double vservido = 0;
                    double vvalor = 0;
                    int vcont = 0;
                    int vporc = 0;

                    DataRow[] rows = dtLocalizatmp.Select("numcamion = '" + camion.TrimStart('0') + "' and fecha ='" + DateTime.Today.ToString("yyyy-MM-dd") + "'");
                    //DataRow[] rows = dtLocalizatmp.Select("numcamion = '" + camion.TrimStart('0') + "' and fechareg ='" + DateTime.Today.ToString("yyyy-MM-dd") + "'");

                    string servida = "";
                    string racion = "_";
                    string pila = "_";
                    string velocidad = "_";
                    string nomtablet = "_";
                    string total_corral = "0";
                    string faltan_serv = "0";
                    int carga_actual = 0;

                    foreach (DataRow row2 in rows)
                    {
                        servida = row2["servida"].ToString();
                        racion = row2["racion"].ToString();
                        pila = row2["pila"].ToString();
                        velocidad = row2["velocidad"].ToString();
                        nomtablet = row2["varios01"].ToString();

                        total_corral = row2["total_corral"].ToString();
                        faltan_serv = row2["faltan_serv"].ToString();
                        carga_actual = int.TryParse(row2["carga_actual"]?.ToString(), out int valor3) ? valor3 : 0;

                        //total_corral = row2["total_corral"].ToString();
                        //faltan_serv = row2["faltan_serv"].ToString();
                        //carga_actual = row2["carga_actual"].ToString();


                    }

                    foreach (DataRow row in dtRepartotmp.Rows)
                    {

                        if (row["fecha"].ToString() == DateTime.Today.ToString("yyyy-MM-dd"))
                        //if (row["fechareg"].ToString() == DateTime.Today.ToString("yyyy-MM-dd"))
                        {

                            if (row["numcamion"].Equals(camion))
                            {
                                vplandia = vplandia + Convert.ToInt32(row["plandia"]);
                                vservido = vservido + Convert.ToInt32(row["servidodia"]);

                                if (row["servida"].Equals(servida) /*&& row["racion"].Equals(racion)*/) { vcont++; }

                            }

                        }

                    }

                    vplandia = Math.Round(vplandia, 0);
                    vservido = Math.Round(vservido, 0);

                    //vporc = (int)((vservido / vplandia) * 100);
                    //if (vporc > 100) { vporc = 100; }

                    vporc = vcont;
                    camBar(camion, 
                        vporc, 
                        vcont, 
                        0, 
                        racion, 
                        servida.TrimStart('0'), 
                        pila, 
                        velocidad, 
                        nomtablet,
                        
                        total_corral,
                        faltan_serv,
                        carga_actual
                        );

                }

                fConteoEstadoConectados();

            }

        }

        private void camBar(string camion, int valor, int cont, int total, string racion, string servida, string pila, string velocidad, string nomtablet, string total_corral, string faltan_serv, int carga_actual)
        {

            //if (valor >= pBar01.Minimum && valor <= pBar01.Maximum)//100)
            if (valor >= 0 && valor <= 300)
            {

                Color colorServ = Color.Transparent;

                switch (servida)
                {
                    case "1":
                        colorServ = Color.Orange;
                        break;
                    case "2":
                        colorServ = Color.LimeGreen;
                        break;

                }

                velocidad = convertKm(velocidad.ToString());

                switch (camion)
                {
                    case "01":
                        valoresEtiquetas(
                         panelCam01,
                         pBar01,
                         lblpBc01,
                         lblpB01,
                         lblpBr01,
                         lblpBs01,
                         picBs01,
                         picRepCam01,
                         picGpsCam01,
                         picMov01,
                         picCamion01,
                         picWifi01,
                         lblpBb01,
                         lblpBv01,
                         lblCam01,
                         lblpAct01,
                         lblTablet01,
                         picPila01,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "02":
                        valoresEtiquetas(
                         panelCam02,
                         pBar02,
                         lblpBc02,
                         lblpB02,
                         lblpBr02,
                         lblpBs02,
                         picBs02,
                         picRepCam02,
                         picGpsCam02,
                         picMov02,
                         picCamion02,
                         picWifi02,
                         lblpBb02,
                         lblpBv02,
                         lblCam02,
                         lblpAct02,
                         lblTablet02,
                         picPila02,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "03":
                        valoresEtiquetas(
                         panelCam03,
                         pBar03,
                         lblpBc03,
                         lblpB03,
                         lblpBr03,
                         lblpBs03,
                         picBs03,
                         picRepCam03,
                         picGpsCam03,
                         picMov03,
                         picCamion03,
                         picWifi03,
                         lblpBb03,
                         lblpBv03,
                         lblCam03,
                         lblpAct03,
                         lblTablet03,
                         picPila03,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "04":
                        valoresEtiquetas(
                         panelCam04,
                         pBar04,
                         lblpBc04,
                         lblpB04,
                         lblpBr04,
                         lblpBs04,
                         picBs04,
                         picRepCam04,
                         picGpsCam04,
                         picMov04,
                         picCamion04,
                         picWifi04,
                         lblpBb04,
                         lblpBv04,
                         lblCam04,
                         lblpAct04,
                         lblTablet04,
                         picPila04,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "05":
                        valoresEtiquetas(
                         panelCam05,
                         pBar05,
                         lblpBc05,
                         lblpB05,
                         lblpBr05,
                         lblpBs05,
                         picBs05,
                         picRepCam05,
                         picGpsCam05,
                         picMov05,
                         picCamion05,
                         picWifi05,
                         lblpBb05,
                         lblpBv05,
                         lblCam05,
                         lblpAct05,
                         lblTablet05,
                         picPila05,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "06":
                        valoresEtiquetas(
                         panelCam06,
                         pBar06,
                         lblpBc06,
                         lblpB06,
                         lblpBr06,
                         lblpBs06,
                         picBs06,
                         picRepCam06,
                         picGpsCam06,
                         picMov06,
                         picCamion06,
                         picWifi06,
                         lblpBb06,
                         lblpBv06,
                         lblCam06,
                         lblpAct06,
                         lblTablet06,
                         picPila06,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "07":
                        valoresEtiquetas(
                         panelCam07,
                         pBar07,
                         lblpBc07,
                         lblpB07,
                         lblpBr07,
                         lblpBs07,
                         picBs07,
                         picRepCam07,
                         picGpsCam07,
                         picMov07,
                         picCamion07,
                         picWifi07,
                         lblpBb07,
                         lblpBv07,
                         lblCam07,
                         lblpAct07,
                         lblTablet07,
                         picPila07,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "08":
                        valoresEtiquetas(
                         panelCam08,
                         pBar08,
                         lblpBc08,
                         lblpB08,
                         lblpBr08,
                         lblpBs08,
                         picBs08,
                         picRepCam08,
                         picGpsCam08,
                         picMov08,
                         picCamion08,
                         picWifi08,
                         lblpBb08,
                         lblpBv08,
                         lblCam08,
                         lblpAct08,
                         lblTablet08,
                         picPila08,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "09":
                        valoresEtiquetas(
                         panelCam09,
                         pBar09,
                         lblpBc09,
                         lblpB09,
                         lblpBr09,
                         lblpBs09,
                         picBs09,
                         picRepCam09,
                         picGpsCam09,
                         picMov09,
                         picCamion09,
                         picWifi09,
                         lblpBb09,
                         lblpBv09,
                         lblCam09,
                         lblpAct09,
                         lblTablet09,
                         picPila09,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "10":
                        valoresEtiquetas(
                         panelCam10,
                         pBar10,
                         lblpBc10,
                         lblpB10,
                         lblpBr10,
                         lblpBs10,
                         picBs10,
                         picRepCam10,
                         picGpsCam10,
                         picMov10,
                         picCamion10,
                         picWifi10,
                         lblpBb10,
                         lblpBv10,
                         lblCam10,
                         lblpAct10,
                         lblTablet10,
                         picPila10,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "11":
                        valoresEtiquetas(
                         panelCam11,
                         pBar11,
                         lblpBc11,
                         lblpB11,
                         lblpBr11,
                         lblpBs11,
                         picBs11,
                         picRepCam11,
                         picGpsCam11,
                         picMov11,
                         picCamion11,
                         picWifi11,
                         lblpBb11,
                         lblpBv11,
                         lblCam11,
                         lblpAct11,
                         lblTablet11,
                         picPila11,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "12":
                        valoresEtiquetas(
                         panelCam12,
                         pBar12,
                         lblpBc12,
                         lblpB12,
                         lblpBr12,
                         lblpBs12,
                         picBs12,
                         picRepCam12,
                         picGpsCam12,
                         picMov12,
                         picCamion12,
                         picWifi12,
                         lblpBb12,
                         lblpBv12,
                         lblCam12,
                         lblpAct12,
                         lblTablet12,
                         picPila12,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "13":
                        valoresEtiquetas(
                         panelCam13,
                         pBar13,
                         lblpBc13,
                         lblpB13,
                         lblpBr13,
                         lblpBs13,
                         picBs13,
                         picRepCam13,
                         picGpsCam13,
                         picMov13,
                         picCamion13,
                         picWifi13,
                         lblpBb13,
                         lblpBv13,
                         lblCam13,
                         lblpAct13,
                         lblTablet13,
                         picPila13,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "14":
                        valoresEtiquetas(
                         panelCam14,
                         pBar14,
                         lblpBc14,
                         lblpB14,
                         lblpBr14,
                         lblpBs14,
                         picBs14,
                         picRepCam14,
                         picGpsCam14,
                         picMov14,
                         picCamion14,
                         picWifi14,
                         lblpBb14,
                         lblpBv14,
                         lblCam14,
                         lblpAct14,
                         lblTablet14,
                         picPila14,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "15":
                        valoresEtiquetas(
                         panelCam15,
                         pBar15,
                         lblpBc15,
                         lblpB15,
                         lblpBr15,
                         lblpBs15,
                         picBs15,
                         picRepCam15,
                         picGpsCam15,
                         picMov15,
                         picCamion15,
                         picWifi15,
                         lblpBb15,
                         lblpBv15,
                         lblCam15,
                         lblpAct15,
                         lblTablet15,
                         picPila15,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "16":
                        valoresEtiquetas(
                         panelCam16,
                         pBar16,
                         lblpBc16,
                         lblpB16,
                         lblpBr16,
                         lblpBs16,
                         picBs16,
                         picRepCam16,
                         picGpsCam16,
                         picMov16,
                         picCamion16,
                         picWifi16,
                         lblpBb16,
                         lblpBv16,
                         lblCam16,
                         lblpAct16,
                         lblTablet16,
                         picPila16,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "17":
                        valoresEtiquetas(
                         panelCam17,
                         pBar17,
                         lblpBc17,
                         lblpB17,
                         lblpBr17,
                         lblpBs17,
                         picBs17,
                         picRepCam17,
                         picGpsCam17,
                         picMov17,
                         picCamion17,
                         picWifi17,
                         lblpBb17,
                         lblpBv17,
                         lblCam17,
                         lblpAct17,
                         lblTablet17,
                         picPila17,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "18":
                        valoresEtiquetas(
                         panelCam18,
                         pBar18,
                         lblpBc18,
                         lblpB18,
                         lblpBr18,
                         lblpBs18,
                         picBs18,
                         picRepCam18,
                         picGpsCam18,
                         picMov18,
                         picCamion18,
                         picWifi18,
                         lblpBb18,
                         lblpBv18,
                         lblCam18,
                         lblpAct18,
                         lblTablet18,
                         picPila18,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "19":
                        valoresEtiquetas(
                         panelCam19,
                         pBar19,
                         lblpBc19,
                         lblpB19,
                         lblpBr19,
                         lblpBs19,
                         picBs19,
                         picRepCam19,
                         picGpsCam19,
                         picMov19,
                         picCamion19,
                         picWifi19,
                         lblpBb19,
                         lblpBv19,
                         lblCam19,
                         lblpAct19,
                         lblTablet19,
                         picPila19,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "20":
                        valoresEtiquetas(
                         panelCam20,
                         pBar20,
                         lblpBc20,
                         lblpB20,
                         lblpBr20,
                         lblpBs20,
                         picBs20,
                         picRepCam20,
                         picGpsCam20,
                         picMov20,
                         picCamion20,
                         picWifi20,
                         lblpBb20,
                         lblpBv20,
                         lblCam20,
                         lblpAct20,
                         lblTablet20,
                         picPila20,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "21":
                        valoresEtiquetas(
                         panelCam21,
                         pBar21,
                         lblpBc21,
                         lblpB21,
                         lblpBr21,
                         lblpBs21,
                         picBs21,
                         picRepCam21,
                         picGpsCam21,
                         picMov21,
                         picCamion21,
                         picWifi21,
                         lblpBb21,
                         lblpBv21,
                         lblCam21,
                         lblpAct21,
                         lblTablet21,
                         picPila21,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "22":
                        valoresEtiquetas(
                         panelCam22,
                         pBar22,
                         lblpBc22,
                         lblpB22,
                         lblpBr22,
                         lblpBs22,
                         picBs22,
                         picRepCam22,
                         picGpsCam22,
                         picMov22,
                         picCamion22,
                         picWifi22,
                         lblpBb22,
                         lblpBv22,
                         lblCam22,
                         lblpAct22,
                         lblTablet22,
                         picPila22,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "23":
                        valoresEtiquetas(
                         panelCam23,
                         pBar23,
                         lblpBc23,
                         lblpB23,
                         lblpBr23,
                         lblpBs23,
                         picBs23,
                         picRepCam23,
                         picGpsCam23,
                         picMov23,
                         picCamion23,
                         picWifi23,
                         lblpBb23,
                         lblpBv23,
                         lblCam23,
                         lblpAct23,
                         lblTablet23,
                         picPila23,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "24":
                        valoresEtiquetas(
                         panelCam24,
                         pBar24,
                         lblpBc24,
                         lblpB24,
                         lblpBr24,
                         lblpBs24,
                         picBs24,
                         picRepCam24,
                         picGpsCam24,
                         picMov24,
                         picCamion24,
                         picWifi24,
                         lblpBb24,
                         lblpBv24,
                         lblCam24,
                         lblpAct24,
                         lblTablet24,
                         picPila24,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "25":
                        valoresEtiquetas(
                         panelCam25,
                         pBar25,
                         lblpBc25,
                         lblpB25,
                         lblpBr25,
                         lblpBs25,
                         picBs25,
                         picRepCam25,
                         picGpsCam25,
                         picMov25,
                         picCamion25,
                         picWifi25,
                         lblpBb25,
                         lblpBv25,
                         lblCam25,
                         lblpAct25,
                         lblTablet25,
                         picPila25,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "26":
                        valoresEtiquetas(
                         panelCam26,
                         pBar26,
                         lblpBc26,
                         lblpB26,
                         lblpBr26,
                         lblpBs26,
                         picBs26,
                         picRepCam26,
                         picGpsCam26,
                         picMov26,
                         picCamion26,
                         picWifi26,
                         lblpBb26,
                         lblpBv26,
                         lblCam26,
                         lblpAct26,
                         lblTablet26,
                         picPila26,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "27":
                        valoresEtiquetas(
                         panelCam27,
                         pBar27,
                         lblpBc27,
                         lblpB27,
                         lblpBr27,
                         lblpBs27,
                         picBs27,
                         picRepCam27,
                         picGpsCam27,
                         picMov27,
                         picCamion27,
                         picWifi27,
                         lblpBb27,
                         lblpBv27,
                         lblCam27,
                         lblpAct27,
                         lblTablet27,
                         picPila27,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;
                    case "28":
                        valoresEtiquetas(
                         panelCam28,
                         pBar28,
                         lblpBc28,
                         lblpB28,
                         lblpBr28,
                         lblpBs28,
                         picBs28,
                         picRepCam28,
                         picGpsCam28,
                         picMov28,
                         picCamion28,
                         picWifi28,
                         lblpBb28,
                         lblpBv28,
                         lblCam28,
                         lblpAct28,
                         lblTablet28,
                         picPila28,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;


                    case "29":
                        valoresEtiquetas(
                         panelCam29,
                         pBar29,
                         lblpBc29,
                         null,//lblpB29,
                         lblpBr29,
                         null,//lblpBs29,
                         null,//picBs29,
                         picRepCam29,
                         picGpsCam29,
                         null,//picMov29,
                         picCamion29,
                         null,//picWifi29,
                         null,//lblpBb29,
                         null,//lblpBv29,
                         lblCam29,
                         null,//lblpAct29,
                         lblTablet29,
                         null,//picPila29,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "30":
                        valoresEtiquetas(
                         panelCam30,
                         pBar30,
                         lblpBc30,
                         null,//lblpB30,
                         lblpBr30,
                         null,//lblpBs30,
                         null,//picBs30,
                         picRepCam30,
                         picGpsCam30,
                         null,//picMov30,
                         picCamion30,
                         null,//picWifi30,
                         null,//lblpBb30,
                         null,//lblpBv30,
                         lblCam30,
                         null,//lblpAct30,
                         lblTablet30,
                         null,//picPila30,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "31":
                        valoresEtiquetas(
                         panelCam31,
                         pBar31,
                         lblpBc31,
                         null,//lblpB31,
                         lblpBr31,
                         null,//lblpBs31,
                         null,//picBs31,
                         picRepCam31,
                         picGpsCam31,
                         null,//picMov31,
                         picCamion31,
                         null,//picWifi31,
                         null,//lblpBb31,
                         null,//lblpBv31,
                         lblCam31,
                         null,//lblpAct31,
                         lblTablet31,
                         null,//picPila31,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "32":
                        valoresEtiquetas(
                         panelCam32,
                         pBar32,
                         lblpBc32,
                         null,//lblpB32,
                         lblpBr32,
                         null,//lblpBs32,
                         null,//picBs32,
                         picRepCam32,
                         picGpsCam32,
                         null,//picMov32,
                         picCamion32,
                         null,//picWifi32,
                         null,//lblpBb32,
                         null,//lblpBv32,
                         lblCam32,
                         null,//lblpAct32,
                         lblTablet32,
                         null,//picPila32,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "33":
                        valoresEtiquetas(
                         panelCam33,
                         pBar33,
                         lblpBc33,
                         null,//lblpB33,
                         lblpBr33,
                         null,//lblpBs33,
                         null,//picBs33,
                         picRepCam33,
                         picGpsCam33,
                         null,//picMov33,
                         picCamion33,
                         null,//picWifi33,
                         null,//lblpBb33,
                         null,//lblpBv33,
                         lblCam33,
                         null,//lblpAct33,
                         lblTablet33,
                         null,//picPila33,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "34":
                        valoresEtiquetas(
                         panelCam34,
                         pBar34,
                         lblpBc34,
                         null,//lblpB34,
                         lblpBr34,
                         null,//lblpBs34,
                         null,//picBs34,
                         picRepCam34,
                         picGpsCam34,
                         null,//picMov34,
                         picCamion34,
                         null,//picWifi34,
                         null,//lblpBb34,
                         null,//lblpBv34,
                         lblCam34,
                         null,//lblpAct34,
                         lblTablet34,
                         null,//picPila34,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "35":
                        valoresEtiquetas(
                         panelCam35,
                         pBar35,
                         lblpBc35,
                         null,//lblpB35,
                         lblpBr35,
                         null,//lblpBs35,
                         null,//picBs35,
                         picRepCam35,
                         picGpsCam35,
                         null,//picMov35,
                         picCamion35,
                         null,//picWifi35,
                         null,//lblpBb35,
                         null,//lblpBv35,
                         lblCam35,
                         null,//lblpAct35,
                         lblTablet35,
                         null,//picPila35,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;

                    case "36":
                        valoresEtiquetas(
                         panelCam36,
                         pBar36,
                         lblpBc36,
                         null,//lblpB36,
                         lblpBr36,
                         null,//lblpBs36,
                         null,//picBs36,
                         picRepCam36,
                         picGpsCam36,
                         null,//picMov36,
                         picCamion36,
                         null,//picWifi36,
                         null,//lblpBb36,
                         null,//lblpBv36,
                         lblCam36,
                         null,//lblpAct36,
                         lblTablet36,
                         null,//picPila36,
                         valor,
                         cont,
                         racion,
                         servida,
                         colorServ,
                         pila,
                         velocidad,
                         camion,
                         nomtablet,
                         total_corral,
                         faltan_serv,
                         carga_actual
                        );
                        break;




                }


                //switch (camion)
                //{
                //    case "01":

                //        valoresEtiquetas(
                //         pBar01,
                //         lblpBc01,
                //         lblpB01,
                //         lblpBr01,
                //         lblpBs01,
                //         picBs01,
                //         picRepCam01,
                //         picGpsCam01,
                //         lblpBb01,
                //         lblpBv01,
                //         lblCam01,
                //         valor,
                //         cont,
                //         racion,
                //         servida,
                //         colorServ,
                //         pila,
                //         velocidad
                //        );

                //        //pBar01.Value = valor;
                //        //lblpBc01.Text = cont.ToString();//+ "/" + total.ToString();
                //        //lblpB01.Text = valor.ToString() + " %";
                //        //lblpBr01.Text = racion.ToString();
                //        //lblpBs01.Text = servida.ToString();
                //        //picBs01.BackColor = colorServ;
                //        //lblpBb01.Text = pila.ToString();
                //        //lblpBv01.Text = velocidad.ToString();

                //        //if (lblpBv01.Text != "" && lblpBv01.Text.Length >= 3)
                //        //{
                //        //    if (lblpBv01.Text.Substring(0, 3) != "000")
                //        //    {
                //        //        lblpBv01.BackColor = Color.LimeGreen;
                //        //        lblpBv01.ForeColor = Color.Black;
                //        //    }
                //        //    else
                //        //    {
                //        //        lblpBv01.BackColor = Color.Red;
                //        //        lblpBv01.ForeColor = Color.White;
                //        //    }                        
                //        //}

                //        //if (picGpsCam01.BackColor == Color.Red) 
                //        //{
                //        //    lblpBv01.BackColor = Color.Yellow;
                //        //    lblpBv01.ForeColor = Color.Black;
                //        //    lblpBv01.Text = "OFF";
                //        //}

                //        //if (lblpBb01.Text.Contains("~"))
                //        //{
                //        //    lblpBb01.BackColor = Color.Blue;
                //        //    lblpBb01.ForeColor = Color.White;
                //        //}
                //        //else
                //        //{
                //        //    lblpBb01.BackColor = Color.Yellow;
                //        //    lblpBb01.ForeColor = Color.Black;
                //        //}                        

                //        //if (picRepCam01.BackColor != Color.Transparent || picGpsCam01.BackColor != Color.Transparent)
                //        //{
                //        //    lblCam01.ForeColor = Color.Black;
                //        //    lblpBc01.ForeColor = Color.Black;
                //        //    lblpBr01.ForeColor = Color.Black;
                //        //    //lblpBb01.ForeColor = Color.Black;
                //        //    //lblpBv01.ForeColor = Color.Black;                   
                //        //}
                //        //else
                //        //{
                //        //    lblCam01.ForeColor = Color.Silver;
                //        //    picBs01.BackColor = Color.Transparent;
                //        //    pBar01.Value = 0;
                //        //    lblpBc01.ForeColor = Color.Silver;
                //        //    lblpBr01.ForeColor = Color.Silver;
                //        //    lblpBb01.ForeColor = Color.Silver;
                //        //    lblpBb01.BackColor = Color.Transparent;
                //        //    lblpBv01.ForeColor = Color.Silver;
                //        //    lblpBv01.BackColor = Color.Transparent;
                //        //}

                //        break;
                //    case "02":
                //        pBar02.Value = valor;
                //        lblpBc02.Text = cont.ToString();// + "/" + total.ToString();
                //        lblpB02.Text = valor.ToString() + " %";
                //        lblpBr02.Text = racion.ToString();
                //        lblpBs02.Text = servida.ToString();
                //        picBs02.BackColor = colorServ;
                //        lblpBb02.Text = pila.ToString();
                //        lblpBv02.Text = velocidad.ToString();

                //        if (lblpBv02.Text != "" && lblpBv02.Text.Length>=3)
                //        {
                //            if (lblpBv02.Text.Substring(0, 3) != "000")
                //            {
                //                lblpBv02.BackColor = Color.LimeGreen;
                //                lblpBv02.ForeColor = Color.Black;
                //            }
                //            else
                //            {
                //                lblpBv02.BackColor = Color.Red;
                //                lblpBv02.ForeColor = Color.White;
                //            }
                //        }

                //        if (picGpsCam02.BackColor == Color.Red)
                //        {
                //            lblpBv02.BackColor = Color.Yellow;
                //            lblpBv02.ForeColor = Color.Black;
                //            lblpBv02.Text = "OFF";
                //        }

                //        if (lblpBb02.Text.Contains("~"))
                //        {
                //            lblpBb02.BackColor = Color.Blue;
                //            lblpBb02.ForeColor = Color.White;
                //        }
                //        else
                //        {
                //            lblpBb02.BackColor = Color.Yellow;
                //            lblpBb02.ForeColor = Color.Black;
                //        }

                //        if (picRepCam02.BackColor != Color.Transparent || picGpsCam02.BackColor != Color.Transparent)
                //        {
                //            lblCam02.ForeColor = Color.Black;             
                //            lblpBc02.ForeColor = Color.Black;
                //            lblpBr02.ForeColor = Color.Black;
                //            //lblpBb02.ForeColor = Color.Black;
                //            //lblpBv02.ForeColor = Color.Black;
                //        }
                //        else
                //        {
                //            lblCam02.ForeColor = Color.Silver;
                //            picBs02.BackColor = Color.Transparent;  
                //            pBar02.Value = 0;
                //            lblpBc02.ForeColor = Color.Silver;
                //            lblpBr02.ForeColor = Color.Silver;
                //            lblpBb02.ForeColor = Color.Silver;
                //            lblpBb02.BackColor = Color.Transparent;
                //            lblpBv02.ForeColor = Color.Silver;
                //            lblpBv02.BackColor = Color.Transparent;
                //        }

                //        break;
                //    case "03":
                //        pBar03.Value = valor;
                //        lblpBc03.Text = cont.ToString();// + "/" + total.ToString();
                //        lblpB03.Text = valor.ToString() + " %";
                //        lblpBr03.Text = racion.ToString();
                //        lblpBs03.Text = servida.ToString();
                //        picBs03.BackColor = colorServ;
                //        lblpBb03.Text = pila.ToString();
                //        lblpBv03.Text = velocidad.ToString();

                //        if (lblpBv03.Text != "" && lblpBv03.Text.Length >= 3)
                //        {
                //            if (lblpBv03.Text.Substring(0, 3) != "000")
                //            {
                //                lblpBv03.BackColor = Color.LimeGreen;
                //                lblpBv03.ForeColor = Color.Black;
                //            }
                //            else
                //            {
                //                lblpBv03.BackColor = Color.Red;
                //                lblpBv03.ForeColor = Color.White;
                //            }
                //        }

                //        if (picGpsCam03.BackColor == Color.Red)
                //        {
                //            lblpBv03.BackColor = Color.Yellow;
                //            lblpBv03.ForeColor = Color.Black;
                //            lblpBv03.Text = "OFF";
                //        }

                //        if (lblpBb03.Text.Contains("~"))
                //        {
                //            lblpBb03.BackColor = Color.Blue;
                //            lblpBb03.ForeColor = Color.White;
                //        }
                //        else
                //        {
                //            lblpBb03.BackColor = Color.Yellow;
                //            lblpBb03.ForeColor = Color.Black;
                //        }

                //        if (picRepCam03.BackColor != Color.Transparent || picGpsCam03.BackColor != Color.Transparent)
                //        {
                //            lblCam03.ForeColor = Color.Black;
                //            lblpBc03.ForeColor = Color.Black;
                //            lblpBr03.ForeColor = Color.Black;
                //            //lblpBb03.ForeColor = Color.Black;
                //            //lblpBv03.ForeColor = Color.Black;
                //        }
                //        else
                //        {
                //            lblCam03.ForeColor = Color.Silver;
                //            picBs03.BackColor = Color.Transparent;
                //            pBar03.Value = 0;
                //            lblpBc03.ForeColor = Color.Silver;
                //            lblpBr03.ForeColor = Color.Silver;
                //            lblpBb03.ForeColor = Color.Silver;
                //            lblpBb03.BackColor = Color.Transparent;
                //            lblpBv03.ForeColor = Color.Silver;
                //            lblpBv03.BackColor = Color.Transparent;
                //        }

                //        break;
                //    case "04":
                //        pBar04.Value = valor;
                //        lblpBc04.Text = cont.ToString();// + "/" + total.ToString();
                //        lblpB04.Text = valor.ToString() + " %";
                //        lblpBr04.Text = racion.ToString();
                //        lblpBs04.Text = servida.ToString();
                //        picBs04.BackColor = colorServ;
                //        lblpBb04.Text = pila.ToString();
                //        lblpBv04.Text = velocidad.ToString();

                //        if (lblpBv04.Text != "" && lblpBv04.Text.Length >= 3)
                //        {
                //            if (lblpBv04.Text.Substring(0, 3) != "000")
                //            {
                //                lblpBv04.BackColor = Color.LimeGreen;
                //                lblpBv04.ForeColor = Color.Black;
                //            }
                //            else
                //            {
                //                lblpBv04.BackColor = Color.Red;
                //                lblpBv04.ForeColor = Color.White;
                //            }
                //        }

                //        if (picGpsCam04.BackColor == Color.Red)
                //        {
                //            lblpBv04.BackColor = Color.Yellow;
                //            lblpBv04.ForeColor = Color.Black;
                //            lblpBv04.Text = "OFF";
                //        }

                //        if (lblpBb04.Text.Contains("~"))
                //        {
                //            lblpBb04.BackColor = Color.Blue;
                //            lblpBb04.ForeColor = Color.White;
                //        }
                //        else
                //        {
                //            lblpBb04.BackColor = Color.Yellow;
                //            lblpBb04.ForeColor = Color.Black;
                //        }

                //        if (picRepCam04.BackColor != Color.Transparent || picGpsCam04.BackColor != Color.Transparent)
                //        {
                //            lblCam04.ForeColor = Color.Black;
                //            lblpBc04.ForeColor = Color.Black;
                //            lblpBr04.ForeColor = Color.Black;
                //            //lblpBb04.ForeColor = Color.Black;
                //            //lblpBv04.ForeColor = Color.Black;
                //        }
                //        else
                //        {
                //            lblCam04.ForeColor = Color.Silver;
                //            picBs04.BackColor = Color.Transparent;
                //            pBar04.Value = 0;
                //            lblpBc04.ForeColor = Color.Silver;
                //            lblpBr04.ForeColor = Color.Silver;
                //            lblpBb04.ForeColor = Color.Silver;
                //            lblpBb04.BackColor = Color.Transparent;
                //            lblpBv04.ForeColor = Color.Silver;
                //            lblpBv04.BackColor = Color.Transparent;
                //        }

                //        break;
                //    case "05":
                //        pBar05.Value = valor;
                //        lblpBc05.Text = cont.ToString();// + "/" + total.ToString();
                //        lblpB05.Text = valor.ToString() + " %";
                //        lblpBr05.Text = racion.ToString();
                //        lblpBs05.Text = servida.ToString();
                //        picBs05.BackColor = colorServ;
                //        lblpBb05.Text = pila.ToString();
                //        lblpBv05.Text = velocidad.ToString();

                //        if (lblpBv05.Text != "" && lblpBv05.Text.Length >= 3)
                //        {
                //            if (lblpBv05.Text.Substring(0, 3) != "000")
                //            {
                //                lblpBv05.BackColor = Color.LimeGreen;
                //                lblpBv05.ForeColor = Color.Black;
                //            }
                //            else
                //            {
                //                lblpBv05.BackColor = Color.Red;
                //                lblpBv05.ForeColor = Color.White;
                //            }
                //        }

                //        if (picGpsCam05.BackColor == Color.Red)
                //        {
                //            lblpBv05.BackColor = Color.Yellow;
                //            lblpBv05.ForeColor = Color.Black;
                //            lblpBv05.Text = "OFF";
                //        }

                //        if (lblpBb05.Text.Contains("~"))
                //        {
                //            lblpBb05.BackColor = Color.Blue;
                //            lblpBb05.ForeColor = Color.White;
                //        }
                //        else
                //        {
                //            lblpBb05.BackColor = Color.Yellow;
                //            lblpBb05.ForeColor = Color.Black;
                //        }

                //        if (picRepCam05.BackColor != Color.Transparent || picGpsCam05.BackColor != Color.Transparent)
                //        {
                //            lblCam05.ForeColor = Color.Black;
                //            lblpBc05.ForeColor = Color.Black;
                //            lblpBr05.ForeColor = Color.Black;
                //            //lblpBb05.ForeColor = Color.Black;
                //            //lblpBv05.ForeColor = Color.Black;
                //        }
                //        else
                //        {
                //            lblCam05.ForeColor = Color.Silver;
                //            picBs05.BackColor = Color.Transparent;
                //            pBar05.Value = 0;
                //            lblpBc05.ForeColor = Color.Silver;
                //            lblpBr05.ForeColor = Color.Silver;
                //            lblpBb05.ForeColor = Color.Silver;
                //            lblpBb05.BackColor = Color.Transparent;
                //            lblpBv05.ForeColor = Color.Silver;
                //            lblpBv05.BackColor = Color.Transparent;
                //        }

                //        break;
                //    case "06":
                //        pBar06.Value = valor;
                //        lblpBc06.Text = cont.ToString();// + "/" + total.ToString();
                //        lblpB06.Text = valor.ToString() + " %";
                //        lblpBr06.Text = racion.ToString();
                //        lblpBs06.Text = servida.ToString();
                //        picBs06.BackColor = colorServ;
                //        lblpBb06.Text = pila.ToString();
                //        lblpBv06.Text = velocidad.ToString();

                //        if (lblpBv06.Text != "" && lblpBv06.Text.Length >= 3)
                //        {
                //            if (lblpBv06.Text.Substring(0, 3) != "000")
                //            {
                //                lblpBv06.BackColor = Color.LimeGreen;
                //                lblpBv06.ForeColor = Color.Black;
                //            }
                //            else
                //            {
                //                lblpBv06.BackColor = Color.Red;
                //                lblpBv06.ForeColor = Color.White;
                //            }
                //        }

                //        if (picGpsCam06.BackColor == Color.Red)
                //        {
                //            lblpBv06.BackColor = Color.Yellow;
                //            lblpBv06.ForeColor = Color.Black;
                //            lblpBv06.Text = "OFF";
                //        }

                //        if (lblpBb06.Text.Contains("~"))
                //        {
                //            lblpBb06.BackColor = Color.Blue;
                //            lblpBb06.ForeColor = Color.White;
                //        }
                //        else
                //        {
                //            lblpBb06.BackColor = Color.Yellow;
                //            lblpBb06.ForeColor = Color.Black;
                //        }

                //        if (picRepCam06.BackColor != Color.Transparent || picGpsCam06.BackColor != Color.Transparent)
                //        {
                //            lblCam06.ForeColor = Color.Black;
                //            lblpBc06.ForeColor = Color.Black;
                //            lblpBr06.ForeColor = Color.Black;
                //            //lblpBb06.ForeColor = Color.Black;
                //            //lblpBv06.ForeColor = Color.Black;
                //        }
                //        else
                //        {
                //            lblCam06.ForeColor = Color.Silver;
                //            picBs06.BackColor = Color.Transparent;
                //            pBar06.Value = 0;
                //            lblpBc06.ForeColor = Color.Silver;
                //            lblpBr06.ForeColor = Color.Silver;
                //            lblpBb06.ForeColor = Color.Silver;
                //            lblpBb06.BackColor = Color.Transparent;
                //            lblpBv06.ForeColor = Color.Silver;
                //            lblpBv06.BackColor = Color.Transparent;
                //        }

                //        break;
                //    case "07":
                //        pBar07.Value = valor;
                //        lblpBc07.Text = cont.ToString();// + "/" + total.ToString();
                //        lblpB07.Text = valor.ToString() + " %";
                //        lblpBr07.Text = racion.ToString();
                //        lblpBs07.Text = servida.ToString();
                //        picBs07.BackColor = colorServ;
                //        lblpBb07.Text = pila.ToString();
                //        lblpBv07.Text = velocidad.ToString();

                //        if (lblpBv07.Text != "" && lblpBv07.Text.Length >= 3)
                //        {
                //            if (lblpBv07.Text.Substring(0, 3) != "000")
                //            {
                //                lblpBv07.BackColor = Color.LimeGreen;
                //                lblpBv07.ForeColor = Color.Black;
                //            }
                //            else
                //            {
                //                lblpBv07.BackColor = Color.Red;
                //                lblpBv07.ForeColor = Color.White;
                //            }
                //        }

                //        if (picGpsCam07.BackColor == Color.Red)
                //        {
                //            lblpBv07.BackColor = Color.Yellow;
                //            lblpBv07.ForeColor = Color.Black;
                //            lblpBv07.Text = "OFF";
                //        }

                //        if (lblpBb07.Text.Contains("~"))
                //        {
                //            lblpBb07.BackColor = Color.Blue;
                //            lblpBb07.ForeColor = Color.White;
                //        }
                //        else
                //        {
                //            lblpBb07.BackColor = Color.Yellow;
                //            lblpBb07.ForeColor = Color.Black;
                //        }

                //        if (picRepCam07.BackColor != Color.Transparent || picGpsCam07.BackColor != Color.Transparent)
                //        {
                //            lblCam07.ForeColor = Color.Black;
                //            lblpBc07.ForeColor = Color.Black;
                //            lblpBr07.ForeColor = Color.Black;
                //            //lblpBb07.ForeColor = Color.Black;
                //            //lblpBv07.ForeColor = Color.Black;
                //        }
                //        else
                //        {
                //            lblCam07.ForeColor = Color.Silver;
                //            picBs07.BackColor = Color.Transparent;
                //            pBar07.Value = 0;
                //            lblpBc07.ForeColor = Color.Silver;
                //            lblpBr07.ForeColor = Color.Silver;
                //            lblpBb07.ForeColor = Color.Silver;
                //            lblpBb07.BackColor = Color.Transparent;
                //            lblpBv07.ForeColor = Color.Silver;
                //            lblpBv07.BackColor = Color.Transparent;
                //        }

                //        break;
                //    case "08":
                //        pBar08.Value = valor;
                //        lblpBc08.Text = cont.ToString();// + "/" + total.ToString();
                //        lblpB08.Text = valor.ToString() + " %";
                //        lblpBr08.Text = racion.ToString();
                //        lblpBs08.Text = servida.ToString();
                //        picBs08.BackColor = colorServ;
                //        lblpBb08.Text = pila.ToString();
                //        lblpBv08.Text = velocidad.ToString();

                //        if (lblpBv08.Text != "" && lblpBv08.Text.Length >= 3)
                //        {
                //            if (lblpBv08.Text.Substring(0, 3) != "000")
                //            {
                //                lblpBv08.BackColor = Color.LimeGreen;
                //                lblpBv08.ForeColor = Color.Black;
                //            }
                //            else
                //            {
                //                lblpBv08.BackColor = Color.Red;
                //                lblpBv08.ForeColor = Color.White;
                //            }
                //        }

                //        if (picGpsCam08.BackColor == Color.Red)
                //        {
                //            lblpBv08.BackColor = Color.Yellow;
                //            lblpBv08.ForeColor = Color.Black;
                //            lblpBv08.Text = "OFF";
                //        }

                //        if (lblpBb08.Text.Contains("~"))
                //        {
                //            lblpBb08.BackColor = Color.Blue;
                //            lblpBb08.ForeColor = Color.White;
                //        }
                //        else
                //        {
                //            lblpBb08.BackColor = Color.Yellow;
                //            lblpBb08.ForeColor = Color.Black;
                //        }

                //        if (picRepCam08.BackColor != Color.Transparent || picGpsCam08.BackColor != Color.Transparent)
                //        {
                //            lblCam08.ForeColor = Color.Black;
                //            lblpBc08.ForeColor = Color.Black;
                //            lblpBr08.ForeColor = Color.Black;
                //            //lblpBb08.ForeColor = Color.Black;
                //            //lblpBv08.ForeColor = Color.Black;
                //        }
                //        else
                //        {
                //            lblCam08.ForeColor = Color.Silver;
                //            picBs08.BackColor = Color.Transparent;
                //            pBar08.Value = 0;
                //            lblpBc08.ForeColor = Color.Silver;
                //            lblpBr08.ForeColor = Color.Silver;
                //            lblpBb08.ForeColor = Color.Silver;
                //            lblpBb08.BackColor = Color.Transparent;
                //            lblpBv08.ForeColor = Color.Silver;
                //            lblpBv08.BackColor = Color.Transparent;
                //        }

                //        break;
                //    case "09":
                //        pBar09.Value = valor;
                //        lblpBc09.Text = cont.ToString();// + "/" + total.ToString();
                //        lblpB09.Text = valor.ToString() + " %";
                //        lblpBr09.Text = racion.ToString();
                //        lblpBs09.Text = servida.ToString();
                //        picBs09.BackColor = colorServ;
                //        lblpBb09.Text = pila.ToString();
                //        lblpBv09.Text = velocidad.ToString();

                //        if (lblpBv09.Text != "" && lblpBv09.Text.Length >= 3)
                //        {
                //            if (lblpBv09.Text.Substring(0, 3) != "000")
                //            {
                //                lblpBv09.BackColor = Color.LimeGreen;
                //                lblpBv09.ForeColor = Color.Black;
                //            }
                //            else
                //            {
                //                lblpBv09.BackColor = Color.Red;
                //                lblpBv09.ForeColor = Color.White;
                //            }
                //        }

                //        if (picGpsCam09.BackColor == Color.Red)
                //        {
                //            lblpBv09.BackColor = Color.Yellow;
                //            lblpBv09.ForeColor = Color.Black;
                //            lblpBv09.Text = "OFF";
                //        }

                //        if (lblpBb09.Text.Contains("~"))
                //        {
                //            lblpBb09.BackColor = Color.Blue;
                //            lblpBb09.ForeColor = Color.White;
                //        }
                //        else
                //        {
                //            lblpBb09.BackColor = Color.Yellow;
                //            lblpBb09.ForeColor = Color.Black;
                //        }

                //        if (picRepCam09.BackColor != Color.Transparent || picGpsCam09.BackColor != Color.Transparent)
                //        {
                //            lblCam09.ForeColor = Color.Black;
                //            lblpBc09.ForeColor = Color.Black;
                //            lblpBr09.ForeColor = Color.Black;
                //            //lblpBb09.ForeColor = Color.Black;
                //            //lblpBv09.ForeColor = Color.Black;
                //        }
                //        else
                //        {
                //            lblCam09.ForeColor = Color.Silver;
                //            picBs09.BackColor = Color.Transparent;
                //            pBar09.Value = 0;
                //            lblpBc09.ForeColor = Color.Silver;
                //            lblpBr09.ForeColor = Color.Silver;
                //            lblpBb09.ForeColor = Color.Silver;
                //            lblpBb09.BackColor = Color.Transparent;
                //            lblpBv09.ForeColor = Color.Silver;
                //            lblpBv09.BackColor = Color.Transparent;
                //        }

                //        break;
                //    case "10":
                //        pBar10.Value = valor;
                //        lblpBc10.Text = cont.ToString();// + "/" + total.ToString();
                //        lblpB10.Text = valor.ToString() + " %";
                //        lblpBr10.Text = racion.ToString();
                //        lblpBs10.Text = servida.ToString();
                //        picBs10.BackColor = colorServ;
                //        lblpBb10.Text = pila.ToString();
                //        lblpBv10.Text = velocidad.ToString();

                //        if (lblpBv10.Text != "" && lblpBv10.Text.Length >= 3)
                //        {
                //            if (lblpBv10.Text.Substring(0, 3) != "000")
                //            {
                //                lblpBv10.BackColor = Color.LimeGreen;
                //                lblpBv10.ForeColor = Color.Black;
                //            }
                //            else
                //            {
                //                lblpBv10.BackColor = Color.Red;
                //                lblpBv10.ForeColor = Color.White;
                //            }
                //        }

                //        if (picGpsCam10.BackColor == Color.Red)
                //        {
                //            lblpBv10.BackColor = Color.Yellow;
                //            lblpBv10.ForeColor = Color.Black;
                //            lblpBv10.Text = "OFF";
                //        }

                //        if (lblpBb10.Text.Contains("~"))
                //        {
                //            lblpBb10.BackColor = Color.Blue;
                //            lblpBb10.ForeColor = Color.White;
                //        }
                //        else
                //        {
                //            lblpBb10.BackColor = Color.Yellow;
                //            lblpBb10.ForeColor = Color.Black;
                //        }

                //        if (picRepCam10.BackColor != Color.Transparent || picGpsCam10.BackColor != Color.Transparent)
                //        {
                //            lblCam10.ForeColor = Color.Black;
                //            lblpBc10.ForeColor = Color.Black;
                //            lblpBr10.ForeColor = Color.Black;
                //            //lblpBb10.ForeColor = Color.Black;
                //            //lblpBv10.ForeColor = Color.Black;
                //        }
                //        else
                //        {
                //            lblCam10.ForeColor = Color.Silver;
                //            picBs10.BackColor = Color.Transparent;
                //            pBar10.Value = 0;
                //            lblpBc10.ForeColor = Color.Silver;
                //            lblpBr10.ForeColor = Color.Silver;
                //            lblpBb10.ForeColor = Color.Silver;
                //            lblpBb10.BackColor = Color.Transparent;
                //            lblpBv10.ForeColor = Color.Silver;
                //            lblpBv10.BackColor = Color.Transparent;
                //        }

                //        break;
                //    case "11":
                //        pBar11.Value = valor;
                //        lblpBc11.Text = cont.ToString();//+ "/" + total.ToString();
                //        lblpB11.Text = valor.ToString() + " %";
                //        lblpBr11.Text = racion.ToString();
                //        lblpBs11.Text = servida.ToString();
                //        picBs11.BackColor = colorServ;
                //        lblpBb11.Text = pila.ToString();
                //        lblpBv11.Text = velocidad.ToString();

                //        if (lblpBv11.Text != "" && lblpBv11.Text.Length >= 3)
                //        {
                //            if (lblpBv11.Text.Substring(0, 3) != "000")
                //            {
                //                lblpBv11.BackColor = Color.LimeGreen;
                //                lblpBv11.ForeColor = Color.Black;
                //            }
                //            else
                //            {
                //                lblpBv11.BackColor = Color.Red;
                //                lblpBv11.ForeColor = Color.White;
                //            }
                //        }

                //        if (picGpsCam11.BackColor == Color.Red)
                //        {
                //            lblpBv11.BackColor = Color.Yellow;
                //            lblpBv11.ForeColor = Color.Black;
                //            lblpBv11.Text = "OFF";
                //        }

                //        if (lblpBb11.Text.Contains("~"))
                //        {
                //            lblpBb11.BackColor = Color.Blue;
                //            lblpBb11.ForeColor = Color.White;
                //        }
                //        else
                //        {
                //            lblpBb11.BackColor = Color.Yellow;
                //            lblpBb11.ForeColor = Color.Black;
                //        }

                //        if (picRepCam11.BackColor != Color.Transparent || picGpsCam11.BackColor != Color.Transparent)
                //        {
                //            lblCam11.ForeColor = Color.Black;
                //            lblpBc11.ForeColor = Color.Black;
                //            lblpBr11.ForeColor = Color.Black;
                //            //lblpBb11.ForeColor = Color.Black;
                //            //lblpBv11.ForeColor = Color.Black;
                //        }
                //        else
                //        {
                //            lblCam11.ForeColor = Color.Silver;
                //            picBs11.BackColor = Color.Transparent;
                //            pBar11.Value = 0;
                //            lblpBc11.ForeColor = Color.Silver;
                //            lblpBr11.ForeColor = Color.Silver;
                //            lblpBb11.ForeColor = Color.Silver;
                //            lblpBb11.BackColor = Color.Transparent;
                //            lblpBv11.ForeColor = Color.Silver;
                //            lblpBv11.BackColor = Color.Transparent;
                //        }

                //        break;
                //    case "12":
                //        pBar12.Value = valor;
                //        lblpBc12.Text = cont.ToString();// + "/" + total.ToString();
                //        lblpB12.Text = valor.ToString() + " %";
                //        lblpBr12.Text = racion.ToString();
                //        lblpBs12.Text = servida.ToString();
                //        picBs12.BackColor = colorServ;
                //        lblpBb12.Text = pila.ToString();
                //        lblpBv12.Text = velocidad.ToString();

                //        if (lblpBv12.Text != "" && lblpBv12.Text.Length >= 3)
                //        {
                //            if (lblpBv12.Text.Substring(0, 3) != "000")
                //            {
                //                lblpBv12.BackColor = Color.LimeGreen;
                //                lblpBv12.ForeColor = Color.Black;
                //            }
                //            else
                //            {
                //                lblpBv12.BackColor = Color.Red;
                //                lblpBv12.ForeColor = Color.White;
                //            }
                //        }

                //        if (picGpsCam12.BackColor == Color.Red)
                //        {
                //            lblpBv12.BackColor = Color.Yellow;
                //            lblpBv12.ForeColor = Color.Black;
                //            lblpBv12.Text = "OFF";
                //        }

                //        if (lblpBb12.Text.Contains("~"))
                //        {
                //            lblpBb12.BackColor = Color.Blue;
                //            lblpBb12.ForeColor = Color.White;
                //        }
                //        else
                //        {
                //            lblpBb12.BackColor = Color.Yellow;
                //            lblpBb12.ForeColor = Color.Black;
                //        }

                //        if (picRepCam12.BackColor != Color.Transparent || picGpsCam12.BackColor != Color.Transparent)
                //        {
                //            lblCam12.ForeColor = Color.Black;
                //            lblpBc12.ForeColor = Color.Black;
                //            lblpBr12.ForeColor = Color.Black;
                //            //lblpBb12.ForeColor = Color.Black;
                //            //lblpBv12.ForeColor = Color.Black;
                //        }
                //        else
                //        {
                //            lblCam12.ForeColor = Color.Silver;
                //            picBs12.BackColor = Color.Transparent;
                //            pBar12.Value = 0;
                //            lblpBc12.ForeColor = Color.Silver;
                //            lblpBr12.ForeColor = Color.Silver;
                //            lblpBb12.BackColor = Color.Transparent;
                //            lblpBv12.ForeColor = Color.Silver;
                //            lblpBv12.BackColor = Color.Transparent;
                //        }

                //        break;
                //    case "13":
                //        pBar13.Value = valor;
                //        lblpBc13.Text = cont.ToString();// + "/" + total.ToString();
                //        lblpB13.Text = valor.ToString() + " %";
                //        lblpBr13.Text = racion.ToString();
                //        lblpBs13.Text = servida.ToString();
                //        picBs13.BackColor = colorServ;
                //        lblpBb13.Text = pila.ToString();
                //        lblpBv13.Text = velocidad.ToString();

                //        if (lblpBv13.Text != "" && lblpBv13.Text.Length >= 3)
                //        {
                //            if (lblpBv13.Text.Substring(0, 3) != "000")
                //            {
                //                lblpBv13.BackColor = Color.LimeGreen;
                //                lblpBv13.ForeColor = Color.Black;
                //            }
                //            else
                //            {
                //                lblpBv13.BackColor = Color.Red;
                //                lblpBv13.ForeColor = Color.White;
                //            }
                //        }

                //        if (picGpsCam13.BackColor == Color.Red)
                //        {
                //            lblpBv13.BackColor = Color.Yellow;
                //            lblpBv13.ForeColor = Color.Black;
                //            lblpBv13.Text = "OFF";
                //        }

                //        if (lblpBb13.Text.Contains("~"))
                //        {
                //            lblpBb13.BackColor = Color.Blue;
                //            lblpBb13.ForeColor = Color.White;
                //        }
                //        else
                //        {
                //            lblpBb13.BackColor = Color.Yellow;
                //            lblpBb13.ForeColor = Color.Black;
                //        }

                //        if (picRepCam13.BackColor != Color.Transparent || picGpsCam13.BackColor != Color.Transparent)
                //        {
                //            lblCam13.ForeColor = Color.Black;
                //            lblpBc13.ForeColor = Color.Black;
                //            lblpBr13.ForeColor = Color.Black;
                //            //lblpBb13.ForeColor = Color.Black;
                //            //lblpBv13.ForeColor = Color.Black;
                //        }
                //        else
                //        {
                //            lblCam13.ForeColor = Color.Silver;
                //            picBs13.BackColor = Color.Transparent;
                //            pBar13.Value = 0;
                //            lblpBc13.ForeColor = Color.Silver;
                //            lblpBr13.ForeColor = Color.Silver;
                //            lblpBb13.ForeColor = Color.Silver;
                //            lblpBb13.BackColor = Color.Transparent;
                //            lblpBv13.ForeColor = Color.Silver;
                //            lblpBv13.BackColor = Color.Transparent;
                //        }

                //        break;
                //    case "14":
                //        pBar14.Value = valor;
                //        lblpBc14.Text = cont.ToString();//+ "/" + total.ToString();
                //        lblpB14.Text = valor.ToString() + " %";
                //        lblpBr14.Text = racion.ToString();
                //        lblpBs14.Text = servida.ToString();
                //        picBs14.BackColor = colorServ;
                //        lblpBb14.Text = pila.ToString();
                //        lblpBv14.Text = velocidad.ToString();

                //        if (lblpBv14.Text != "" && lblpBv14.Text.Length >= 3)
                //        {
                //            if (lblpBv14.Text.Substring(0, 3) != "000")
                //            {
                //                lblpBv14.BackColor = Color.LimeGreen;
                //                lblpBv14.ForeColor = Color.Black;
                //            }
                //            else
                //            {
                //                lblpBv14.BackColor = Color.Red;
                //                lblpBv14.ForeColor = Color.White;
                //            }
                //        }

                //        if (picGpsCam14.BackColor == Color.Red)
                //        {
                //            lblpBv14.BackColor = Color.Yellow;
                //            lblpBv14.ForeColor = Color.Black;
                //            lblpBv14.Text = "OFF";
                //        }

                //        if (lblpBb14.Text.Contains("~"))
                //        {
                //            lblpBb14.BackColor = Color.Blue;
                //            lblpBb14.ForeColor = Color.White;
                //        }
                //        else
                //        {
                //            lblpBb14.BackColor = Color.Yellow;
                //            lblpBb14.ForeColor = Color.Black;
                //        }

                //        if (picRepCam14.BackColor != Color.Transparent || picGpsCam14.BackColor != Color.Transparent)
                //        {
                //            lblCam14.ForeColor = Color.Black;
                //            lblpBc14.ForeColor = Color.Black;
                //            lblpBr14.ForeColor = Color.Black;
                //            //lblpBb14.ForeColor = Color.Black;
                //            //lblpBv14.ForeColor = Color.Black;
                //        }
                //        else
                //        {
                //            lblCam14.ForeColor = Color.Silver;
                //            picBs14.BackColor = Color.Transparent;
                //            pBar14.Value = 0;
                //            lblpBc14.ForeColor = Color.Silver;
                //            lblpBr14.ForeColor = Color.Silver;
                //            lblpBb14.ForeColor = Color.Silver;
                //            lblpBb14.BackColor = Color.Transparent;
                //            lblpBv14.ForeColor = Color.Silver;
                //            lblpBv14.BackColor = Color.Transparent;
                //        }

                //        break;
                //    case "15":
                //        pBar15.Value = valor;
                //        lblpBc15.Text = cont.ToString();// + "/" + total.ToString();
                //        lblpB15.Text = valor.ToString() + " %";
                //        lblpBr15.Text = racion.ToString();
                //        lblpBs15.Text = servida.ToString();
                //        picBs15.BackColor = colorServ;
                //        lblpBb15.Text = pila.ToString();
                //        lblpBv15.Text = velocidad.ToString();

                //        if (lblpBv15.Text != "" && lblpBv15.Text.Length >= 3)
                //        {
                //            if (lblpBv15.Text.Substring(0, 3) != "000")
                //            {
                //                lblpBv15.BackColor = Color.LimeGreen;
                //                lblpBv15.ForeColor = Color.Black;
                //            }
                //            else
                //            {
                //                lblpBv15.BackColor = Color.Red;
                //                lblpBv15.ForeColor = Color.White;
                //            }
                //        }

                //        if (picGpsCam15.BackColor == Color.Red)
                //        {
                //            lblpBv15.BackColor = Color.Yellow;
                //            lblpBv15.ForeColor = Color.Black;
                //            lblpBv15.Text = "OFF";
                //        }

                //        if (lblpBb15.Text.Contains("~"))
                //        {
                //            lblpBb15.BackColor = Color.Blue;
                //            lblpBb15.ForeColor = Color.White;
                //        }
                //        else
                //        {
                //            lblpBb15.BackColor = Color.Yellow;
                //            lblpBb15.ForeColor = Color.Black;
                //        }

                //        if (picRepCam15.BackColor != Color.Transparent || picGpsCam15.BackColor != Color.Transparent)
                //        {
                //            lblCam15.ForeColor = Color.Black;
                //            lblpBc15.ForeColor = Color.Black;
                //            lblpBr15.ForeColor = Color.Black;
                //            //lblpBb15.ForeColor = Color.Black;
                //            //lblpBv15.ForeColor = Color.Black;
                //        }
                //        else
                //        {
                //            lblCam15.ForeColor = Color.Silver;
                //            picBs15.BackColor = Color.Transparent;
                //            pBar15.Value = 0;
                //            lblpBc15.ForeColor = Color.Silver;
                //            lblpBr15.ForeColor = Color.Silver;
                //            lblpBb15.ForeColor = Color.Silver;
                //            lblpBb15.BackColor = Color.Transparent;
                //            lblpBv15.ForeColor = Color.Silver;
                //            lblpBv15.BackColor = Color.Transparent;
                //        }

                //        break;
                //}
            }
            else
            {
            }

        }

        //private void valoresEtiquetas_(
        //    Panel panelcam,
        //    ProgressBar pBar,
        //    Label lblpBc,
        //    Label lblpB,
        //    Label lblpBr,
        //    Label lblpBs,
        //    PictureBox picBs,
        //    PictureBox picRepCam,
        //    PictureBox picGpsCam,
        //    PictureBox picMov,
        //    PictureBox picCamion,
        //    PictureBox picWifi,
        //    Label lblpBb,
        //    Label lblpBv,
        //    Label lblCam,
        //    Label lblpAct,
        //    Label lblTablet,
        //    PictureBox picPila,
        //    int pvalor,
        //    int pcont,
        //    string pracion,
        //    string pservida,
        //    Color pcolorServ,
        //    string ppila,
        //    string pvelocidad,
        //    string pcamion,
        //    string nomtablet,
        //    string total_corral,
        //    string faltan_serv, 
        //    int carga_actual
        //    )
        //{

        //    try
        //    {
        //        //pBar.Value = pvalor;
        //        //pBar.Visible = (total_corral != 0);
        //        //Color colorBaseLime = Color.Lime;
        //        //Color colorBaseYellow = Color.Yellow;

        //        Color vColorConGps = Color.FromArgb(180, colorCamion); //Color.FromArgb(180,Color.Aqua); //FromArgb(250, colorBaseLime.R, colorBaseLime.G, colorBaseLime.B); //Lime;
        //        Color vColorSinGps = Color.FromArgb(160, colorCamion); // Color.FromArgb(170, Color.Aqua); // Yellow ;//Lime; //FromArgb(46, 50, 51);//.White; //Green;
        //        Color vColorAusenteInactivo = Color.White; //FromArgb(76, 80, 81);
        //        Color vColorInactivo = Color.FromArgb(10, 0, 255, 0); //FromArgb(46, 50, 51); // Gainsboro; //FromArgb(10, 0, 255, 0);
        //        Color vColorAusenteBaja = Color.FromArgb(53, 57, 58);
        //        Color vColorTaller = Color.FromArgb(180, 46, 50, 51); //Color.DimGray;

        //        ///////////////////////////

        //        if (total_corral == "") total_corral = "0-0";
        //        if (faltan_serv == "") faltan_serv = "0-0";

        //        string[] sa1 = total_corral.Split('-');
        //        string[] sa2 = faltan_serv.Split('-');

        //        int vtotal_corral = Convert.ToInt32(sa1[0]);
        //        int vfaltan_serv = Convert.ToInt32(sa2[0]);

        //        pBar.Maximum = vtotal_corral;
        //        pBar.Value = vtotal_corral - vfaltan_serv;


        //        /////////////////////
                

        //        if (lblpBc != null) { lblpBc.Text = "OK";  }//pBar.Value.ToString() + "/" + pBar.Maximum.ToString(); } //("000");//+ "/" + total.ToString(); 
        //        if (pBar.Maximum == 0) { lblpBc.Text = ""; }

        //        //if (lblpBc != null) { lblpBc.Text = pcont.ToString(); } //("000");//+ "/" + total.ToString(); 

        //        if (lblpB != null) { lblpB.Text = pvalor.ToString() + " %"; }
        //        lblpBr.Text = pracion.ToString();
        //        if (lblpBs != null) { lblpBs.Text = pservida.ToString(); }
        //        if (picBs != null) { picBs.BackColor = pcolorServ; }
        //        if (lblpBb != null) { lblpBb.Text = ppila.ToString(); }//.Replace("100 %","OK  ");
        //        if (lblpBv != null) { lblpBv.Text = pvelocidad.ToString(); }//.Substring(1,4);

        //        lblpBc.BackColor = Color.Transparent;
        //        //lblpBc.BackColor = pcolorServ;

        //        //camion con gps activo
        //        panelcam.BackColor = vColorConGps;// Color.Lime; //Lime; // pcolorServ;
        //                                         //lblpBr.BackColor = panelcam.BackColor;


        //        //lblCam.ForeColor = Color.Silver;

        //        //picCamion04.Image = imageListCamiones.Images[5];
        //        //picCamion06.Image = imageListCamiones.Images[5];
        //        //picCamion07.Image = imageListCamiones.Images[5];
        //        //picCamion08.Image = imageListCamiones.Images[5];
        //        //picCamion09.Image = imageListCamiones.Images[5];


        //        if (picMov != null) { picMov.Image = null; }
        //        picCamion.Image = imageListCamiones.Images[1];
        //        if (picWifi != null) { picWifi.Image = null; }

        //        //lblpAct.ForeColor = Color.Transparent;

        //        /*
        //        ToolTip tt = new ToolTip();
        //        tt.SetToolTip(picPila, string.Empty);

        //        if (nomtablet != "_")
        //        {
        //            tt.SetToolTip(lblCam, nomtablet);//.Replace("TAMGGCAMR", "").Replace("_", ""));
        //        }

        //        ToolTip tt2 = new ToolTip();
        //        tt2.SetToolTip(picPila, string.Empty);
        //        */

        //        //ToolTip toolTip1 = new ToolTip();

        //        //// Configurar algunas propiedades del ToolTip (opcional)
        //        //toolTip1.AutoPopDelay = 5000; // Tiempo que permanece visible
        //        //toolTip1.InitialDelay = 1000; // Tiempo antes de que aparezca
        //        //toolTip1.ReshowDelay = 500;   // Tiempo entre reapariciones
        //        //toolTip1.ShowAlways = true;   // Permite que el ToolTip aparezca incluso si el form no está activo
        //        //toolTip1.SetToolTip(lblCam, nomtablet);
        //        //lblTablet.Text = nomtablet.Replace("TAMGGCAMR", "").Replace("_", "");
        //        //lblTablet.Refresh();

        //        if (lblpBv != null)
        //        {

        //            //velocidad
        //            if (lblpBv.Text != "" && lblpBv.Text.Length >= 3)
        //            {

        //                lblpBv.Text = lblpBv.Text.ToString().Substring(1, 4);

        //                if (lblpBv.Text.Substring(0, 2) != "00")
        //                {
        //                    //notificacion(1000, "Movimiento", "Mueve Cam" + pcamion, ToolTipIcon.Info);

        //                    lblpBv.BackColor = Color.Lime;
        //                    lblpBv.ForeColor = Color.Black;

        //                    picMov.BackColor = Color.Transparent;
        //                    picMov.Image = imageListMov.Images[0];
        //                    picCamion.Image = imageListCamiones.Images[2];

        //                }
        //                else
        //                {

        //                    if (lblpBv.BackColor == Color.Lime)
        //                    {
        //                        //notificacion(1000, "Detenido", "Cam " + pcamion, ToolTipIcon.Warning);
        //                    }

        //                    lblpBv.BackColor = Color.Red;
        //                    lblpBv.ForeColor = Color.White;

        //                    picMov.BackColor = Color.Transparent;//Red;
        //                    picMov.Image = imageListMov.Images[1];

        //                    picCamion.Image = imageListCamiones.Images[3];
        //                }
        //            }
        //            else
        //            {
        //                lblpBv.BackColor = Color.LightGray;
        //                lblpBv.Text = "00.0";

        //                picMov.BackColor = Color.Transparent;
        //            }

        //        }

        //        if (picGpsCam.BackColor == Color.Red)
        //        {
        //            lblpBc.BackColor = Color.Transparent;
        //            lblpBv.BackColor = Color.Transparent;
        //            //lblpBv.ForeColor = Color.Black;
        //            lblpBv.Text = "_";
        //            lblpBr.Text = "_";
        //            lblpBb.Text = "_";
        //            panelcam.BackColor = Color.Transparent;
        //        }

        //        if (lblpBb != null)
        //        {

        //            //pila
        //            if (lblpBb.Text != "_")
        //            {
        //                if (lblpBb.Text.Contains("~"))
        //                {
        //                    lblpBb.BackColor = Color.Lime;
        //                    lblpBb.ForeColor = Color.Black;
        //                }
        //                else
        //                {
        //                    lblpBb.BackColor = Color.Red;
        //                    lblpBb.ForeColor = Color.White;
        //                }
        //            }
        //            else
        //            {
        //                lblpBb.BackColor = Color.Transparent;
        //            }

        //        }

        //        //racion
        //        if (lblpBr.Text != "_")
        //        {
        //            //if (lblpBr.Text.Contains("1")) { lblpBr.BackColor = Color.YellowGreen; }
        //            //else if (lblpBr.Text.Contains("2")) { lblpBr.BackColor = Color.AntiqueWhite; }
        //            //else if (lblpBr.Text.Contains("3")) { lblpBr.BackColor = Color.Aqua; }
        //            //else if (lblpBr.Text.Contains("4")) { lblpBr.BackColor = Color.Turquoise; }
        //            //else if (lblpBr.Text.Contains("5")) { lblpBr.BackColor = Color.Wheat; }
        //            //else if (lblpBr.Text.Contains("6")) { lblpBr.BackColor = Color.Bisque; }
        //        }
        //        else
        //        {
        //            lblpBr.BackColor = Color.Transparent;
        //        }

        //        // activo
        //        if (picRepCam.BackColor != Color.Transparent ||
        //            picGpsCam.BackColor != Color.Transparent)
        //        {

        //            if (lblCam.ForeColor == Color.Silver)
        //            {
        //                notificacion(1000, "Conecto", "Cam " + pcamion, ToolTipIcon.Info);
        //            }

        //            lblCam.ForeColor = Color.White; // Black;
        //            if (lblpBc != null) { lblpBc.ForeColor = Color.Black; }
        //            lblpBr.ForeColor = Color.Black;
        //            //lblpBb.ForeColor = Color.Black;
        //            //lblpBv.ForeColor = Color.Black;
        //            //picCamion.Image = imageListCamiones.Images[2];

        //            //lblpAct.ForeColor = Color.Transparent;
        //            //lblpAct.BackColor = Color.Transparent;
        //            if (picWifi != null) { picWifi.Image = null; } //imageListWifi.Images[0];

        //            //if (nomtablet.Length>0) 
        //            //{
        //            //    lblTablet.Text = "T" + nomtablet.Replace("TAMGGCAMR", "").Replace("_", "");
        //            //}

        //            if (ppila != "_")
        //            {

        //                if (picPila != null)
        //                {

        //                    if (ppila.Contains('~'))
        //                    {
        //                        picPila.Image = imageListPila.Images[0]; //img carga
        //                    }
        //                    else
        //                    {
        //                        picPila.Image = imageListPila.Images[2]; //img pila
        //                    }

        //                }

        //                //tt2.SetToolTip(picPila, ppila);//.Replace("TAMGGCAMR", "").Replace("_", ""));

        //            }

        //        }
        //        else // inactivo
        //        {

        //            //if (lblCam.ForeColor != Color.Silver)
        //            //{

        //            if (lblCam.ForeColor == Color.Black)
        //            {
        //                notificacion(1000, "Desconecto", "Cam " + pcamion, ToolTipIcon.Error);
        //            }

        //            //}

        //            lblCam.ForeColor = Color.Silver;
        //            if (picBs != null) { picBs.BackColor = Color.Transparent; }
        //            pBar.Value = 0;
        //            if (lblpBc != null)
        //            {
        //                lblpBc.BackColor = Color.Transparent;
        //                lblpBc.ForeColor = Color.Silver;
        //            }
        //            lblpBr.BackColor = Color.Transparent;
        //            lblpBr.ForeColor = Color.Silver;
        //            if (lblpBb != null)
        //            {
        //                lblpBb.ForeColor = Color.Silver;
        //                lblpBb.BackColor = Color.Transparent;
        //            }
        //            if (lblpBv != null)
        //            {
        //                lblpBv.ForeColor = Color.Silver;
        //                lblpBv.BackColor = Color.Transparent;
        //            }
        //            if (picMov != null)
        //            {
        //                picMov.BackColor = Color.Transparent;
        //                picMov.Image = null;
        //            }
        //            //if ()
        //            //{

        //            //}

        //            picCamion.Image = null;// imageListCamiones.Images[4];
        //            panelcam.BackColor = Color.Transparent;

        //            //lblpAct.ForeColor = Color.Black;
        //            //lblpAct.ForeColor = Color.Transparent;

        //            //lblTablet.Text = "";

        //            if (picPila != null) { picPila.Image = null; }

        //        }

        //        if (picRepCam.BackColor != Color.Transparent &&
        //            picGpsCam.BackColor == Color.Transparent)
        //        {

        //            if (picMov != null) { picMov.Image = null; }
        //            picCamion.Image = imageListSignal.Images[0];

        //            lblCam.ForeColor = Color.White; // Black; //Silver; 
        //            //lblpBr.BackColor = Color.Brown;
        //            lblpBc.Text = "SIN GPS";    
        //            //lblTablet.Text = "";
        //            lblpBr.Text = "";
        //            panelcam.BackColor = vColorSinGps; //Green; // Beige;// Yellow;

        //            if (picWifi != null) { picWifi.Image = null; }//imageListWifi.Images[0];

        //        }

        //        //if (polygonTaller.IsInside(ubicaCamion(lblCam.Text)))
        //        //{
        //        //    lblpBr.ForeColor = Color.White;

        //        //    if (lblpBc != null) { lblpBc.ForeColor = Color.White; }

        //        //    //lblpBc.ForeColor = Color.White;

        //        //    //lblCam.ForeColor = Color.White;

        //        //    //lblpAct.ForeColor = Color.White;

        //        //    //taller
        //        //    //panelcam.BackColor = Color.Brown;

        //        //    picCamion.Image = imageListEstado.Images[0];

        //        //}
                
        //        //if(camionTaller(lblCam.Text))
        //        //{ 
        //        //    picCamion.Image = imageListEstado.Images[0];
        //        //    panelcam.BackColor = vColorTaller;                    
        //        //}
        //        //else 
        //        //{
        //        //    picCamion.Image = null;
        //        //}


        //        if (polygonEcologicos.IsInside(ubicaCamion(lblCam.Text)))
        //        {
        //            //lblpBr.ForeColor = Color.White;
        //            //lblpBc.ForeColor = Color.White;
        //            //lblCam.FcoreColor = Color.White;
        //            //panelcam.BackColor = Color.YellowGreen;
        //            //picCamion.Image = imageListEstado.Images[0];
        //        }
                
        //        //}catch{}

        //        /////////////////////////////////////////////////////
        //        ///
        //        Boolean vActivoHoy = true;

        //        string vCam = lblCam.Name.Replace("lblCam", "");

        //        //DataRow[] rows = dtLocalizatmp.Select("numcamion = '" + vCam.TrimStart('0') + "' and fecha ='" + DateTime.Today.ToString("yyyy-MM-dd") + "'");
        //        DataRow[] rows = dtLocalizatmp.Select("numcamion = '" + vCam.TrimStart('0') + "' and fechareg ='" + DateTime.Today.ToString("yyyy-MM-dd") + "'");

        //        string vNomNum = "";

        //        foreach (DataRow row2 in rows)
        //        {
        //            vNomNum = row2["numcamion"].ToString().PadLeft(2, '0');
        //        }

        //        if (vNomNum == "28")
        //        {
        //            string a = "1";
        //        }

        //        if (vNomNum == "")
        //        {
        //            panelcam.BackColor = Color.Transparent;
        //            lblCam.ForeColor = vColorAusenteInactivo;
        //            lblpBr.Text = "";
        //            vActivoHoy = false;
        //        }

        //        bool vSinWifi = false;
        //        //sin wifi
        //        if (lblCam.Name == "lblCam" + vNomNum 
        //            && panelcam.BackColor != vColorSinGps//Color.Green
        //            && panelcam.BackColor != vColorConGps)//Color.Lime)
        //        {
        //            //lblCam.ForeColor = Color.Blue;// Yellow;

        //            //picCamion.Image = imageListEstado.Images[4];
        //            //panelcam.BackColor = vColorInactivo; 
        //            lblpBc.Text = "SIN SEÑAL";
        //            lblpBr.Text = "";
        //            //lblTablet.Text = "";                 
        //            vSinWifi = true;

        //            //lblpBr.BackColor = Color.LightSlateGray;
        //            //lblpBr.Text = "RED";

        //            //lblCam.ForeColor = Color.Black;
        //            //lblCam.Font = new Font(lblCam.Font, lblCam.Font.Style.HasFlag(FontStyle.Strikeout) ? FontStyle.Regular : FontStyle.Strikeout);
        //        }    

        //        //if (lblCam.Name == "lblCam04" ||
        //        //    lblCam.Name == "lblCam05" ||
        //        //    lblCam.Name == "lblCam06" ||
        //        //    lblCam.Name == "lblCam07" ||
        //        //    lblCam.Name == "lblCam08" ||
        //        //    lblCam.Name == "lblCam09" ||
        //        //    lblCam.Name == "lblCam10" ||
        //        //    lblCam.Name == "lblCam11"
        //        //    && (panelcam.BackColor != vColorSinGps //Color.Green
        //        //        && panelcam.BackColor != vColorConGps//Color.Lime
        //        //        && panelcam.BackColor != vColorInactivo)
        //        //)
        //        //{
        //        //    lblCam.ForeColor = vColorAusenteBaja;
        //        //    vActivoHoy = false;
        //        //    //pBar.Visible = false;
        //        //    //pBar.Refresh();
        //        //}

        //        if (lblCam.ForeColor == Color.Silver
        //            && panelcam.BackColor != vColorSinGps //Color.Green
        //            && panelcam.BackColor != vColorConGps//Color.Lime
        //            && panelcam.BackColor != vColorInactivo
        //           )
        //        {
        //            lblCam.ForeColor = vColorAusenteInactivo;
                
        //        }                

        //        lblTablet.ForeColor = lblCam.ForeColor;
        //        lblpBr.ForeColor = lblCam.ForeColor;
        //        lblpBc.ForeColor = lblCam.ForeColor;

        //        if(lblpBr.Text == "RED")
        //        {
        //            //lblpBr.ForeColor = Color.Blue;
        //        }

        //        if (lblpBc.Text == "SIN GPS")
        //        {
        //            lblpBc.ForeColor = Color.White;
        //            lblpBc.BackColor = Color.Red;
        //        }

        //        if (nomtablet.Length > 0 && vActivoHoy )//&& !vSinWifi)
        //        {
        //            var vTabletTxt = lblTablet.Text;
        //            var vTablet = "T" + nomtablet.Replace("TAMGGCAMR", "").Replace("_", "");

        //            lblTablet.Text = vTablet;
        //            //lblTablet.BringToFront();

        //            //if (vSinWifi) { lblTablet.ForeColor = Color.White; }

        //            //if (vTabletTxt != vTablet)
        //            //{
        //            //    lblTablet.Text += vTablet;
        //            //}                
        //        }
        //        else
        //        {
        //            //lblTablet.Text = "";
        //        }

        //        if (lblpBr.Text == "_")
        //        {
        //            lblpBr.Text = "";
        //        }

        //        if (camionTaller(lblCam.Text))
        //        {
        //            picCamion.Image = imageListEstado.Images[4];

        //            if (panelcam.BackColor != vColorConGps)
        //            {
        //                panelcam.BackColor = vColorTaller;
        //                lblCam.ForeColor = Color.White;
        //                lblpBr.ForeColor = lblCam.ForeColor;
        //                lblpBc.ForeColor = lblCam.ForeColor;
        //                lblpBc.Text = "TALLER";
        //                lblpBr.Text = "";
        //                lblTablet.ForeColor = lblCam.ForeColor;
        //                lblpBc.BackColor = Color.Transparent;
        //                lblTablet.Text = "";
        //            }
        //            else
        //            {
        //                picCamion.Image = null;
        //            }                

        //        }
        //        else
        //        {
        //            picCamion.Image = null;
        //        }

        //        if (lblpBc.Text == "SIN SEÑAL")
        //        {
        //            //picCamion.Image = imageListWifi.Images[2];
        //            panelcam.BackColor = vColorInactivo; //Color.FromArgb(180, Color.Yellow); //
        //            lblpBc.Text = "";
        //        }

        //        if(panelcam.BackColor == vColorConGps)
        //        { 
        //            lblpBc.Text = ""; //"OK"
        //        }

        //        if (panelcam.BackColor == vColorInactivo)
        //        {
        //            vCantDesconect++;   
        //        }

        //        if (panelcam.BackColor == vColorSinGps) //Color.Green)
        //        {
        //            vCantConect++;  
        //        }

        //        if (panelcam.BackColor == vColorConGps) //Color.Lime)
        //        {
        //            vCantLocaliza++;
        //        }

        //    }
        //    catch { }

        //}

        private void valoresEtiquetas(
            Panel panelcam, ProgressBar pBar, Label lblpBc, Label lblpB, Label lblpBr, Label lblpBs,
            PictureBox picBs, PictureBox picRepCam, PictureBox picGpsCam, PictureBox picMov,
            PictureBox picCamion, PictureBox picWifi, Label lblpBb, Label lblpBv, Label lblCam,
            Label lblpAct, Label lblTablet, PictureBox picPila, int pvalor, int pcont,
            string pracion, string pservida, Color pcolorServ, string ppila, string pvelocidad,
            string pcamion, string nomtablet, string total_corral, string faltan_serv, int carga_actual)
        {
            try
            {
                // Definición de colores
                Color vColorConGps = Color.FromArgb(180, colorCamion);
                Color vColorSinGps = Color.FromArgb(160, colorCamion);
                Color vColorAusenteInactivo = Color.White;
                Color vColorInactivo = Color.FromArgb(10, 0, 255, 0);
                Color vColorAusenteBaja = Color.FromArgb(53, 57, 58);
                Color vColorTaller = Color.FromArgb(180, 46, 50, 51);

                // Configurar barra de progreso
                ConfigurarBarraProgreso(pBar, lblpBc, total_corral, faltan_serv);

                // Asignar valores básicos a etiquetas
                AsignarValoresBasicos(lblpB, lblpBr, lblpBs, lblpBb, lblpBv, picBs,
                                      pvalor, pracion, pservida, pcolorServ, ppila, pvelocidad);

                // Configurar estado inicial
                ConfigurarEstadoInicial(panelcam, lblpBc, picMov, picCamion, picWifi, vColorConGps);

                // Procesar velocidad
                ProcesarVelocidad(lblpBv, picMov, picCamion, picGpsCam);

                // Procesar pila
                ProcesarPila(lblpBb, picPila, ppila);

                // Procesar ración
                ProcesarRacion(lblpBr);

                // Determinar estado del camión
                bool esActivo = picRepCam.BackColor != Color.Transparent || picGpsCam.BackColor != Color.Transparent;

                if (esActivo)
                {
                    ConfigurarCamionActivo(lblCam, lblpBc, lblpBr, picWifi, picPila, ppila, pcamion);
                }
                else
                {
                    ConfigurarCamionInactivo(panelcam, pBar, lblCam, lblpBc, lblpBr, lblpBb, lblpBv,
                                             picBs, picMov, picCamion, picPila, pcamion);
                }

                // Estado sin GPS
                if (picRepCam.BackColor != Color.Transparent && picGpsCam.BackColor == Color.Transparent)
                {
                    ConfigurarSinGPS(panelcam, lblCam, lblpBc, lblpBr, picMov, picCamion, picWifi, vColorSinGps);
                }

                // Verificar actividad del día y estado de conexión
                bool vActivoHoy = VerificarActividadHoy(lblCam, panelcam, lblpBr, vColorAusenteInactivo);
                bool vSinWifi = VerificarSinWifi(lblCam, panelcam, lblpBc, lblpBr, vColorSinGps, vColorConGps);

                // Ajustar colores según estado
                AjustarColoresPorEstado(lblCam, panelcam, lblTablet, lblpBr, lblpBc,
                                        vColorSinGps, vColorConGps, vColorInactivo, vColorAusenteInactivo);

                // Configurar tablet
                ConfigurarTablet(lblTablet, lblCam, nomtablet, vActivoHoy);

                // Limpiar texto de ración si es placeholder
                if (lblpBr.Text == "_") lblpBr.Text = "";

                // Verificar si está en taller
                if (camionTaller(lblCam.Text))
                {
                    ConfigurarCamionTaller(panelcam, lblCam, lblpBc, lblpBr, lblTablet,
                                           picCamion, vColorConGps, vColorTaller);
                }
                else
                {
                    picCamion.Image = null;
                }

                // Estado sin señal
                if (lblpBc.Text == "SIN SEÑAL")
                {
                    panelcam.BackColor = vColorInactivo;
                    lblpBc.Text = "";
                }

                // Limpiar texto OK si está conectado
                if (panelcam.BackColor == vColorConGps) lblpBc.Text = "";

                // Actualizar contadores
                ActualizarContadores(panelcam, vColorInactivo, vColorSinGps, vColorConGps);
            }
            catch { }
        }

        // Métodos auxiliares
        private void ConfigurarBarraProgreso(ProgressBar pBar, Label lblpBc, string total_corral, string faltan_serv)
        {
            if (string.IsNullOrEmpty(total_corral)) total_corral = "0-0";
            if (string.IsNullOrEmpty(faltan_serv)) faltan_serv = "0-0";

            int vtotal = Convert.ToInt32(total_corral.Split('-')[0]);
            int vfaltan = Convert.ToInt32(faltan_serv.Split('-')[0]);

            pBar.Maximum = vtotal;
            pBar.Value = vtotal - vfaltan;

            if (lblpBc != null)
            {
                lblpBc.Text = pBar.Maximum == 0 ? "" : "OK";
            }
        }

        private void AsignarValoresBasicos(Label lblpB, Label lblpBr, Label lblpBs, Label lblpBb,
                                           Label lblpBv, PictureBox picBs, int pvalor, string pracion,
                                           string pservida, Color pcolorServ, string ppila, string pvelocidad)
        {
            if (lblpB != null) lblpB.Text = pvalor + " %";
            lblpBr.Text = pracion;
            if (lblpBs != null) lblpBs.Text = pservida;
            if (picBs != null) picBs.BackColor = pcolorServ;
            if (lblpBb != null) lblpBb.Text = ppila;
            if (lblpBv != null) lblpBv.Text = pvelocidad;
        }

        private void ConfigurarEstadoInicial(Panel panelcam, Label lblpBc, PictureBox picMov,
                                             PictureBox picCamion, PictureBox picWifi, Color vColorConGps)
        {
            lblpBc.BackColor = Color.Transparent;
            panelcam.BackColor = vColorConGps;

            if (picMov != null) picMov.Image = null;
            picCamion.Image = imageListCamiones.Images[1];
            if (picWifi != null) picWifi.Image = null;
        }

        private void ProcesarVelocidad(Label lblpBv, PictureBox picMov, PictureBox picCamion, PictureBox picGpsCam)
        {
            if (lblpBv == null) return;

            if (string.IsNullOrEmpty(lblpBv.Text) || lblpBv.Text.Length < 3)
            {
                lblpBv.BackColor = Color.LightGray;
                lblpBv.Text = "00.0";
                picMov.BackColor = Color.Transparent;
                return;
            }

            lblpBv.Text = lblpBv.Text.Substring(1, 4);

            if (lblpBv.Text.Substring(0, 2) != "00")
            {
                lblpBv.BackColor = Color.Lime;
                lblpBv.ForeColor = Color.Black;
                picMov.BackColor = Color.Transparent;
                picMov.Image = imageListMov.Images[0];
                picCamion.Image = imageListCamiones.Images[2];
            }
            else
            {
                lblpBv.BackColor = Color.Red;
                lblpBv.ForeColor = Color.White;
                picMov.BackColor = Color.Transparent;
                picMov.Image = imageListMov.Images[1];
                picCamion.Image = imageListCamiones.Images[3];
            }

            if (picGpsCam.BackColor == Color.Red)
            {
                lblpBv.BackColor = Color.Transparent;
                lblpBv.Text = "_";
            }
        }

        private void ProcesarPila(Label lblpBb, PictureBox picPila, string ppila)
        {
            if (lblpBb == null || lblpBb.Text == "_")
            {
                if (lblpBb != null) lblpBb.BackColor = Color.Transparent;
                return;
            }

            if (lblpBb.Text.Contains("~"))
            {
                lblpBb.BackColor = Color.Lime;
                lblpBb.ForeColor = Color.Black;
            }
            else
            {
                lblpBb.BackColor = Color.Red;
                lblpBb.ForeColor = Color.White;
            }
        }

        private void ProcesarRacion(Label lblpBr)
        {
            if (lblpBr.Text == "_")
            {
                lblpBr.BackColor = Color.Transparent;
            }
        }

        private void ConfigurarCamionActivo(Label lblCam, Label lblpBc, Label lblpBr,
                                           PictureBox picWifi, PictureBox picPila, string ppila, string pcamion)
        {
            if (lblCam.ForeColor == Color.Silver)
            {
                notificacion(1000, "Conecto", "Cam " + pcamion, ToolTipIcon.Info);
            }

            lblCam.ForeColor = Color.White;
            if (lblpBc != null) lblpBc.ForeColor = Color.Black;
            lblpBr.ForeColor = Color.Black;
            if (picWifi != null) picWifi.Image = null;

            if (ppila != "_" && picPila != null)
            {
                picPila.Image = ppila.Contains('~') ? imageListPila.Images[0] : imageListPila.Images[2];
            }
        }

        private void ConfigurarCamionInactivo(Panel panelcam, ProgressBar pBar, Label lblCam,
                                             Label lblpBc, Label lblpBr, Label lblpBb, Label lblpBv,
                                             PictureBox picBs, PictureBox picMov, PictureBox picCamion,
                                             PictureBox picPila, string pcamion)
        {
            if (lblCam.ForeColor == Color.Black)
            {
                notificacion(1000, "Desconecto", "Cam " + pcamion, ToolTipIcon.Error);
            }

            lblCam.ForeColor = Color.Silver;
            if (picBs != null) picBs.BackColor = Color.Transparent;
            pBar.Value = 0;

            if (lblpBc != null)
            {
                lblpBc.BackColor = Color.Transparent;
                lblpBc.ForeColor = Color.Silver;
            }

            lblpBr.BackColor = Color.Transparent;
            lblpBr.ForeColor = Color.Silver;

            if (lblpBb != null)
            {
                lblpBb.ForeColor = Color.Silver;
                lblpBb.BackColor = Color.Transparent;
            }

            if (lblpBv != null)
            {
                lblpBv.ForeColor = Color.Silver;
                lblpBv.BackColor = Color.Transparent;
            }

            if (picMov != null)
            {
                picMov.BackColor = Color.Transparent;
                picMov.Image = null;
            }

            picCamion.Image = null;
            panelcam.BackColor = Color.Transparent;
            if (picPila != null) picPila.Image = null;
        }

        private void ConfigurarSinGPS(Panel panelcam, Label lblCam, Label lblpBc, Label lblpBr,
                                     PictureBox picMov, PictureBox picCamion, PictureBox picWifi, Color vColorSinGps)
        {
            if (picMov != null) picMov.Image = null;
            picCamion.Image = imageListSignal.Images[0];
            lblCam.ForeColor = Color.White;
            lblpBc.Text = "SIN GPS";
            lblpBr.Text = "";
            panelcam.BackColor = vColorSinGps;
            if (picWifi != null) picWifi.Image = null;
        }

        private bool VerificarActividadHoy(Label lblCam, Panel panelcam, Label lblpBr, Color vColorAusenteInactivo)
        {
            string vCam = lblCam.Name.Replace("lblCam", "");
            DataRow[] rows = dtLocalizatmp.Select($"numcamion = '{vCam.TrimStart('0')}' and fechareg ='{DateTime.Today:yyyy-MM-dd}'");

            string vNomNum = rows.Length > 0 ? rows[0]["numcamion"].ToString().PadLeft(2, '0') : "";

            if (string.IsNullOrEmpty(vNomNum))
            {
                panelcam.BackColor = Color.Transparent;
                lblCam.ForeColor = vColorAusenteInactivo;
                lblpBr.Text = "";
                return false;
            }

            return true;
        }

        private bool VerificarSinWifi(Label lblCam, Panel panelcam, Label lblpBc, Label lblpBr,
                                     Color vColorSinGps, Color vColorConGps)
        {
            string vCam = lblCam.Name.Replace("lblCam", "");
            DataRow[] rows = dtLocalizatmp.Select($"numcamion = '{vCam.TrimStart('0')}' and fechareg ='{DateTime.Today:yyyy-MM-dd}'");
            string vNomNum = rows.Length > 0 ? rows[0]["numcamion"].ToString().PadLeft(2, '0') : "";

            if (lblCam.Name == "lblCam" + vNomNum &&
                panelcam.BackColor != vColorSinGps &&
                panelcam.BackColor != vColorConGps)
            {
                lblpBc.Text = "SIN SEÑAL";
                lblpBr.Text = "";
                return true;
            }

            return false;
        }

        private void AjustarColoresPorEstado(Label lblCam, Panel panelcam, Label lblTablet,
                                            Label lblpBr, Label lblpBc, Color vColorSinGps,
                                            Color vColorConGps, Color vColorInactivo, Color vColorAusenteInactivo)
        {
            if (lblCam.ForeColor == Color.Silver &&
                panelcam.BackColor != vColorSinGps &&
                panelcam.BackColor != vColorConGps &&
                panelcam.BackColor != vColorInactivo)
            {
                lblCam.ForeColor = vColorAusenteInactivo;
            }

            lblTablet.ForeColor = lblCam.ForeColor;
            lblpBr.ForeColor = lblCam.ForeColor;
            lblpBc.ForeColor = lblCam.ForeColor;

            if (lblpBc.Text == "SIN GPS")
            {
                lblpBc.ForeColor = Color.Black;
                lblpBc.BackColor = Color.FromArgb(180, Color.Yellow);
            }
        }

        private void ConfigurarTablet(Label lblTablet, Label lblCam, string nomtablet, bool vActivoHoy)
        {
            if (nomtablet.Length > 0 && vActivoHoy)
            {
                lblTablet.Text = "T" + nomtablet.Replace("TAMGGCAMR", "").Replace("_", "");
            }
        }

        private void ConfigurarCamionTaller(Panel panelcam, Label lblCam, Label lblpBc, Label lblpBr,
                                           Label lblTablet, PictureBox picCamion, Color vColorConGps, Color vColorTaller)
        {
            picCamion.Image = imageListEstado.Images[4];

            if (panelcam.BackColor != vColorConGps)
            {
                panelcam.BackColor = vColorTaller;
                lblCam.ForeColor = Color.White;
                lblpBr.ForeColor = lblCam.ForeColor;
                lblpBc.ForeColor = lblCam.ForeColor;
                lblpBc.Text = "TALLER";
                lblpBr.Text = "";
                lblTablet.ForeColor = lblCam.ForeColor;
                lblpBc.BackColor = Color.Transparent;
                lblTablet.Text = "";
            }
            else
            {
                picCamion.Image = null;
            }
        }

        private void ActualizarContadores(Panel panelcam, Color vColorInactivo, Color vColorSinGps, Color vColorConGps)
        {
            if (panelcam.BackColor == vColorInactivo) vCantDesconect++;
            if (panelcam.BackColor == vColorSinGps) vCantConect++;
            if (panelcam.BackColor == vColorConGps) vCantLocaliza++;
        }

        void fConteoEstadoConectados()
        {
            lblTotalCamActConect.Text = (vCantConect + vCantLocaliza).ToString();
            lblTotalCamActDesConect.Text = (vCantDesconect).ToString();
            lblTotalCamAct.Text = (vCantDesconect + vCantConect + vCantLocaliza).ToString();
            pictureBox24.Refresh();
            pictureBox20.Refresh();
            pictureBox16.Refresh();
        }

        private void grafico1(Chart chart)
        {

            if (panelActCamiones.Visible)
            //if (!splitContainerMapa.Panel2Collapsed)
            {

                chart.Series["S1"].ChartType = SeriesChartType.StackedBar100;
                chart.Series["S1"].IsValueShownAsLabel = true;
                chart.Series["S1"].IsVisibleInLegend = false;
                chart.Series["S1"].BorderColor = Color.Black;
                chart.Series["S1"].LabelBackColor = Color.Transparent;
                chart.Series["S1"].LabelBorderColor = Color.Transparent;
                chart.Series["S1"].LabelForeColor = Color.Black;
                chart.Series["S1"].Color = Color.LimeGreen;
                chart.Series["S1"].Points.Clear();

                chart.Series["S2"].ChartType = SeriesChartType.StackedBar100;
                chart.Series["S2"].IsValueShownAsLabel = true;
                chart.Series["S2"].IsVisibleInLegend = false;
                chart.Series["S2"].BorderColor = Color.Black;
                chart.Series["S2"].LabelBackColor = Color.Transparent;
                chart.Series["S2"].LabelBorderColor = Color.Transparent;
                chart.Series["S2"].LabelForeColor = Color.Black;
                chart.Series["S2"].Color = Color.Silver;
                chart.Series["S2"].Points.Clear();

                chart.ChartAreas[0].AxisX.Interval = 1;
                chart.ChartAreas[0].AxisY.Interval = 50;

                obtenerWsdlServidasSap(ref dtRepartotmp);

                foreach (String camion in cmbCamion.Items)
                {

                    double vfaltadia = 0;
                    double vplandia = 0;
                    double vservido = 0;
                    double vvalor = 0;

                    foreach (DataRow row in dtRepartotmp.Rows)
                    {

                        if (row["numcamion"].Equals(camion))
                        {
                            vplandia = vplandia + Convert.ToInt32(row["plandia"]);
                            vservido = vservido + Convert.ToInt32(row["servidodia"]);
                        }

                    }

                    vplandia = Math.Round(vplandia, 0);
                    vservido = Math.Round(vservido, 0);
                    vfaltadia = Math.Abs(vplandia - vservido);

                    chart.Series["S1"].Points.AddXY("C" + camion, vservido);
                    chart.Series["S2"].Points.AddXY("C" + camion, vfaltadia);

                }

                //chart.Series["S1"].Sort(PointSortOrder.Ascending);

            }

        }

        private void formatChart(Chart chart, int rows)
        {
            chart.Series.Clear();

            for (int i = 0; i < rows; i++)
            {
                chart.Series.Add("S" + i.ToString());
                chart.Series[i].IsValueShownAsLabel = true;
                chart.Series[i].IsVisibleInLegend = false;
                chart.Series[i].BorderColor = Color.Transparent; //Color.Black;
                chart.Series[i].LabelBackColor = Color.Transparent;
                chart.Series[i].LabelBorderColor = Color.Transparent;
                chart.Series[i].LabelForeColor = Color.FromArgb(46, 50, 51);//Color.White;//Black;
                chart.Series[i].Font = new Font("Courier", 12f); 
                chart.Series[i].Points.Clear();

                //chart.Series[i].ChartType = SeriesChartType.StackedColumn100;
                chart.Series[i].ChartType = SeriesChartType.Doughnut; //Pie//StackedBar100;
                chart.Series[i]["DoughnutRadius"] = "50";
                chart.Series[i]["PieStartAngle"] = "270";
                chart.Series[i]["PieDrawingStyle"] = "Concave";

                //chart.Series[i]["PieLabelStyle"] = "Inside";
                //chart.Series[i]["DoughnutLabelStyle"] = "Outside";
                //chart.Series[i]["PieLabelStyle"] = "Outside";
                //chart.Series[i]["PieLineColor"] = "White";

            }

        }

        private void grafico2(Chart chart, int ubic)
        {

            var vColor = Color.White;

            //if (panelActCamiones.Visible)
            //if (!splitContainerMapa.Panel2Collapsed)
            //{

                int totalcapas = overlayCeldas.Polygons.Count;
                int totalGrid = dataGridVista.RowCount; //valores.Count();
                double totalcapasubic = 0;
                bool salir = false;

                Color[] colores = new Color[totalGrid];
                double[] valores = new double[totalGrid];//{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                double[] valores2 = new double[totalGrid];//{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                for (int j = 0; j < totalGrid; j++)
                {
                    colores[j] = dataGridVista[1, j].Style.BackColor;
                    valores[j] = 0;
                }


                for (int i = 0; i < totalcapas; i++) //corrales
                {
                    salir = false;

                    ///////////////////////

                    //if (overlayCeldas.Polygons.ElementAt(i).Name.Equals("6045"))
                    //{
                    if (indiceBotonVistaSel == 6)
                    {
                        DataRow[] rows = dtPlanestmp.Select("corral = '" + overlayCeldas.Polygons.ElementAt(i).Name + "'");
                        //DataRow[] rows = dtCabezastmp.Select("corral = '" + overlayCeldas.Polygons.ElementAt(i).Name + "'");
                        if (rows.Length > 0)
                        {
                            //DataRow row = rows[0];
                            //string cab = row["cabezas"].ToString().Replace(".000", "");
                            //if (cab == "0")
                            //{
                            //    continue;
                            //}
                        }
                        else
                        {
                            string corral = overlayCeldas.Polygons.ElementAt(i).Name;
                            continue;
                        }
                    }
                    //}

                    ///////////////////////

                    for (int j = 0; j < totalGrid; j++) //colores grid
                    {

                        //if (j==0) 
                        //{
                        //string corral = overlayCeldas.Polygons.ElementAt(i).Name;
                        //}
                        //string numero1 = overlayCeldas.Polygons.ElementAt(i).Name.ToString();
                        //string numero = overlayCeldas.Polygons.ElementAt(i).Name.ToString().Substring(0, 1);

                        //if (!numero.Equals("2")) //quitar recep
                        //{
                        switch (ubic)
                        {
                            case clasico:
                                if (ubicE(overlayCeldas.Polygons.ElementAt(i).Points[0].Lat, overlayCeldas.Polygons.ElementAt(i).Points[0].Lng) == ubic)
                                {
                                    if (overlayCeldas.Polygons.ElementAt(i).Tag.Equals(colores[j].Name))
                                    {

                                        if (verSinServir)//lblDetalleCabSinServir.Visible)
                                        {
                                            if (j == 0)
                                            {
                                                string corral = overlayCeldas.Polygons.ElementAt(i).Name;
                                                //mensajeSinServir += corral.Replace("\r\n","") + ", ";
                                                buscarUbicacionBoton(corral, false);
                                            }
                                        }

                                        valores[j]++;
                                        salir = true;
                                    }
                                }
                                break;
                            case ecologico:
                                if (ubicE(overlayCeldas.Polygons.ElementAt(i).Points[0].Lat, overlayCeldas.Polygons.ElementAt(i).Points[0].Lng) == ubic)
                                {
                                    if (overlayCeldas.Polygons.ElementAt(i).Tag.Equals(colores[j].Name))
                                    {

                                        if (verSinServir)//lblDetalleCabSinServir.Visible)
                                        {
                                            if (j == 0)
                                            {
                                                string corral = overlayCeldas.Polygons.ElementAt(i).Name;
                                                buscarUbicacionBoton(corral, false);
                                            }
                                        }

                                        valores[j]++;
                                        salir = true;
                                    }
                                }
                                break;
                            default:
                                if (overlayCeldas.Polygons.ElementAt(i).Tag.Equals(colores[j].Name))
                                {
                                    valores[j]++;
                                    salir = true;
                                }
                                break;
                        }

                        //}

                        if (salir)
                            break;

                    }

                }

                for (int i = 0; i < totalGrid; i++)
                {
                    totalcapasubic = totalcapasubic + valores[i];
                }

                for (int i = 0; i < totalGrid; i++)
                {
                    valores2[i] = Math.Round(valores[i] / totalcapasubic * 100, 1);
                }


                formatChart(chart, 1);// totalGrid);

                chart.Titles.Clear();

                string ubicn = "";

                switch (ubic)
                {
                    case clasico:
                        ubicn = "Clasicos".ToUpper() + " plan";
                        break;

                    case ecologico:
                        ubicn = "Ecologicos".ToUpper() + " plan";
                    break;
                }

                //descripcion graficos
                string vtitulo = ubicn.ToString() + " " + string.Format("{0:N0}", totalcapasubic).ToString() + " corr.";
                if (indiceBotonVistaSel == 6)
                {
                    vtitulo += "";
                }
                chart.Titles.Add(vtitulo);
                chart.Titles[0].ForeColor = Color.White;
                chart.Titles[0].Font = new Font("Courier", 14f, FontStyle.Bold);


            for (int i = 0; i < totalGrid; i++)
            {
                    //dona
                    //valores[i] = Math.Round(valores[i] / totalcapasubic * 100, 1);
                    chart.Series[0].Points.AddXY(i.ToString(), valores[i].ToString());
                    vColor = colores[i];
                    if (i == 0)
                    {
                        vColor = Color.White; //FromArgb(150, Color.White);
                        //vColor = Color.Transparent;
                    }                    
                    chart.Series[0].Points[i].Color = vColor; //colores[i];
                    if (valores[i].ToString() != "0") 
                    {
                        chart.Series[0].Points[i].Label =  valores2[i].ToString() + "%\n\r" + string.Format("{0:N0}",valores[i]).ToString();
                    }
                    else
                    {
                        chart.Series[0].Points[i].Label = ".";
                    }

                    //var descrip = string.Format("{0:N0}", valores[i]).ToString();
                    //if (ubic == ecologico)
                    //{
                    //    lblEcologicosCorrrales.Text = vtitulo;
                    //    lblEcologicosCorrrales.Visible = true;
                    //    progressBar01.AddSegment(descrip, Convert.ToDouble(valores2[i].ToString()), vColor);
                    //}
                    //if (ubic == clasico)
                    //{
                    //    lblClasicosCorrrales.Text = vtitulo;
                    //    lblClasicosCorrrales.Visible = true;
                    //    progressBar02.AddSegment(descrip, Convert.ToDouble(valores2[i].ToString()), vColor);
                    //}

                //column        
                //chart.Series[i].Points.AddXY("", valores2[i]);
                //vColor = colores[i];
                //if (i == 0) { vColor = Color.Transparent; }
                //chart.Series[i].Points[i].Color = vColor;

            }

            for (int i = totalGrid - 1; i >= 0; i--)
            //for (int i = 0; i < totalGrid; i++)
            {

                vColor = colores[i];
                if (i == 0)
                {
                    vColor = Color.White;                                          
                }

                var descrip = string.Format("{0:N0}", valores[i]).ToString();
                if (ubic == ecologico)
                {
                    lblEcologicosCorrrales.Text = vtitulo;
                    lblEcologicosCorrrales.Visible = true;
                    progressBar01.AddSegment(descrip, Convert.ToDouble(valores2[i].ToString()), vColor);
                }
                if (ubic == clasico)
                {
                    lblClasicosCorrrales.Text = vtitulo;
                    lblClasicosCorrrales.Visible = true;
                    progressBar02.AddSegment(descrip, Convert.ToDouble(valores2[i].ToString()), vColor);
                }

            }


            //}

            //if (mensajeSinServir.Length > 0)
            //{
            //    lblDetalleCabSinServir.Text = "Corrales sin servir: " + mensajeSinServir.TrimEnd(' ').TrimEnd(',');
            //}

        }


        private int ubicE(double lat, double lng)
        {

            int ubic;

            if (lat > 21.911475576 )//|| polygonEcoSec01.IsInside(new PointLatLng(lat, lng)))
            {
                ubic = clasico;
            }
            else
            {
                ubic = ecologico;
            }

            return ubic;

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
        void posPanelCam()
        {

            panelCam01.Top = 20;
            panelCam03.Top = panelCam01.Top;
            panelCam05.Top = panelCam01.Top;
            panelCam07.Top = panelCam01.Top;
            panelCam09.Top = panelCam01.Top;
            panelCam11.Top = panelCam01.Top;
            panelCam13.Top = panelCam01.Top;
            panelCam15.Top = panelCam01.Top;
            panelCam17.Top = panelCam01.Top;
            panelCam19.Top = panelCam01.Top;
            panelCam21.Top = panelCam01.Top;
            panelCam23.Top = panelCam01.Top;
            panelCam25.Top = panelCam01.Top;
            panelCam27.Top = panelCam01.Top;
            panelCam29.Top = panelCam01.Top;
            panelCam31.Top = panelCam01.Top;
            panelCam33.Top = panelCam01.Top;
            panelCam35.Top = panelCam01.Top;

            panelCam02.Top = panelCam01.Top + panelCam01.Height + 1;
            panelCam04.Top = panelCam02.Top;
            panelCam06.Top = panelCam02.Top;
            panelCam08.Top = panelCam02.Top;
            panelCam10.Top = panelCam02.Top;
            panelCam12.Top = panelCam02.Top;
            panelCam14.Top = panelCam02.Top;
            panelCam16.Top = panelCam02.Top;
            panelCam18.Top = panelCam02.Top;
            panelCam20.Top = panelCam02.Top;
            panelCam22.Top = panelCam02.Top;
            panelCam24.Top = panelCam02.Top;
            panelCam26.Top = panelCam02.Top;
            panelCam28.Top = panelCam02.Top;
            panelCam30.Top = panelCam02.Top;
            panelCam32.Top = panelCam02.Top;
            panelCam34.Top = panelCam02.Top;
            panelCam36.Top = panelCam02.Top;


            panelCam05.Visible = false;
            panelCam07.Visible = false;
            panelCam09.Visible = false;
            panelCam11.Visible = false;

            panelCam04.Visible = false;
            panelCam06.Visible = false;
            panelCam08.Visible = false;
            panelCam10.Visible = false;


            panelCam01.Left = 10;
            panelCam03.Left = panelCam01.Left + panelCam01.Width + 5;

            //panelCam05.Left = panelCam03.Left + panelCam03.Width + 5;
            //panelCam07.Left = panelCam05.Left + panelCam05.Width + 5;
            //panelCam09.Left = panelCam07.Left + panelCam07.Width + 5;
            //panelCam11.Left = panelCam09.Left + panelCam09.Width + 5;
            
            panelCam13.Left = panelCam03.Left + panelCam03.Width + 5;
            panelCam15.Left = panelCam13.Left + panelCam13.Width + 5;
            panelCam17.Left = panelCam15.Left + panelCam15.Width + 5;
            panelCam19.Left = panelCam17.Left + panelCam17.Width + 5;
            panelCam21.Left = panelCam19.Left + panelCam19.Width + 5;
            panelCam23.Left = panelCam21.Left + panelCam21.Width + 5;
            panelCam25.Left = panelCam23.Left + panelCam23.Width + 5;
            panelCam27.Left = panelCam25.Left + panelCam25.Width + 5;
            panelCam29.Left = panelCam27.Left + panelCam27.Width + 5;
            panelCam31.Left = panelCam29.Left + panelCam29.Width + 5;
            panelCam33.Left = panelCam31.Left + panelCam31.Width + 5;
            panelCam35.Left = panelCam33.Left + panelCam33.Width + 5;



            panelCam02.Left = panelCam01.Left;
            
            //panelCam04.Left = panelCam02.Left + panelCam02.Width + 5;
            //panelCam06.Left = panelCam04.Left + panelCam04.Width + 5;
            //panelCam08.Left = panelCam06.Left + panelCam06.Width + 5;
            //panelCam10.Left = panelCam08.Left + panelCam08.Width + 5;

            panelCam12.Left = panelCam02.Left + panelCam02.Width + 5;
            panelCam14.Left = panelCam12.Left + panelCam12.Width + 5;
            panelCam16.Left = panelCam14.Left + panelCam14.Width + 5;
            panelCam18.Left = panelCam16.Left + panelCam16.Width + 5;
            panelCam20.Left = panelCam18.Left + panelCam18.Width + 5;
            panelCam22.Left = panelCam20.Left + panelCam20.Width + 5;
            panelCam24.Left = panelCam22.Left + panelCam22.Width + 5;
            panelCam26.Left = panelCam24.Left + panelCam24.Width + 5;
            panelCam28.Left = panelCam26.Left + panelCam26.Width + 5;
            panelCam30.Left = panelCam28.Left + panelCam28.Width + 5;
            panelCam32.Left = panelCam30.Left + panelCam30.Width + 5;
            panelCam34.Left = panelCam32.Left + panelCam32.Width + 5;
            panelCam36.Left = panelCam34.Left + panelCam34.Width + 5;







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

                case 6:
                    servidaToolStripMenuItem_Click(sender, e);
                    //toolStripSplitButton3.Text = servidasToolStripMenuItem.Text;
                    break;

                case 7:
                    dimensionesToolStripMenuItem_Click(sender, e);
                    //toolStripSplitButton3.Text = servidasToolStripMenuItem.Text;
                    break;

                default:
                    break;
            }

            if (indiceBotonVista == 7)
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
            //panelCamiones.Visible = true;
            labelLeyendas.Text = toolStripSplitButton3.Text;

            cmbFiltroVista.Items.Clear();

            if (indiceBotonFecha == 1) { timerCamion.Start(); }
            mostrarDatosWs();

            cmbFiltroVista.Visible = false;
            refrescaGraficos();

        }

        private void racionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            toolStripSplitButton3.Text = racionToolStripMenuItem.Text;
            indiceBotonVista = 2;
            indiceBotonVistaSel = 2;
            panelLeyenda.Visible = false;
            panelLeyendas.Visible = true;
            panelDetalles.Visible = false;
            //panelCamiones.Visible = true;
            labelLeyendas.Text = toolStripSplitButton3.Text;

            if (cmbFiltroVista.Items.Count > 0) { cmbFiltroVista.SelectedIndex = 0; }

            if (indiceBotonFecha == 1) { timerCamion.Start(); }
            mostrarDatosWs();

            cmbFiltroVista.Visible = true;
            llenaFiltroVista();
            refrescaGraficos();

        }

        private void camionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            toolStripSplitButton3.Text = camionToolStripMenuItem.Text;
            indiceBotonVista = 3;
            indiceBotonVistaSel = 3;
            panelLeyenda.Visible = false;
            panelLeyendas.Visible = true;
            panelDetalles.Visible = false;
            //panelCamiones.Visible = true;
            labelLeyendas.Text = toolStripSplitButton3.Text;

            if (cmbFiltroVista.Items.Count > 0) { cmbFiltroVista.SelectedIndex = 0; }

            if (indiceBotonFecha == 1) { timerCamion.Start(); }
            mostrarDatosWs();

            cmbFiltroVista.Visible = true;
            llenaFiltroVista();
            refrescaGraficos();

        }

        private void planeadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripSplitButton3.Text = planeadoToolStripMenuItem.Text;
            indiceBotonVista = 4;
            indiceBotonVistaSel = 4;
            panelLeyenda.Visible = false;
            panelLeyendas.Visible = true;
            panelDetalles.Visible = false;
            //panelCamiones.Visible = true;
            labelLeyendas.Text = toolStripSplitButton3.Text;

            if (cmbFiltroVista.Items.Count > 0) { cmbFiltroVista.SelectedIndex = 0; }

            if (indiceBotonFecha == 1) { timerCamion.Start(); }
            mostrarDatosWs();

            cmbFiltroVista.Visible = true;
            llenaFiltroVista();
            refrescaGraficos();
        }

        private void cabezasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripSplitButton3.Text = cabezasToolStripMenuItem.Text;
            indiceBotonVista = 5;
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

            //chart2.Visible = false;
            //chart3.Visible = false;
            //chart4.Visible = false;

            refrescaGraficos();

        }

        private void servidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripSplitButton3.Text = servidaToolStripMenuItem.Text;
            indiceBotonVista = 6;
            indiceBotonVistaSel = 6;
            panelLeyenda.Visible = false;
            panelLeyendas.Visible = true;
            panelDetalles.Visible = false;
            //panelCamiones.Visible = true;
            labelLeyendas.Text = toolStripSplitButton3.Text;

            cmbFiltroVista.Items.Clear();

            if (indiceBotonFecha == 1) { timerCamion.Start(); }
            mostrarDatosWs();


            cmbFiltroVista.Visible = true;//false;

            cmbFiltroVista.Items.Add(vtodos);
            cmbFiltroVista.Items.AddRange(cmbCamion.Items.Cast<Object>().ToArray());
            if (cmbFiltroVista.Items.Count > 0)
            {
                cmbFiltroVista.SelectedIndex = 0;
            }


            refrescaGraficos();
        }

        private void dimensionesToolStripMenuItem_Click(object sender, EventArgs e) 
        {

            toolStripSplitButton3.Text = dimensionesToolStripMenuItem.Text;
            indiceBotonVista = 0;
            indiceBotonVistaSel = 7;
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

            //chart2.Visible = false;
            //chart3.Visible = false;
            //chart4.Visible = false;

            refrescaGraficos();

            //////////////////////////////////////////////////////////////////////////

            //toolStripSplitButton3.Text = dimensionesToolStripMenuItem.Text;
            //indiceBotonVista = 0;
            //indiceBotonVistaSel = 7;
            //panelLeyenda.Visible = false;
            //panelLeyendas.Visible = true;
            //panelDetalles.Visible = false;
            ////panelCamiones.Visible = true;
            //labelLeyendas.Text = toolStripSplitButton3.Text;

            //cmbFiltroVista.Items.Clear();

            ////if (indiceBotonFecha == 1) { timerCamion.Start(); }
            //timerCamion.Stop();
            //mostrarDatosWs();

            ////quitarMarcadorCamiones();
            ////cmbFiltroVista.Visible = true;//false;

            ////cmbFiltroVista.Items.Add(vtodos);
            ////cmbFiltroVista.Items.AddRange(cmbCamion.Items.Cast<Object>().ToArray());
            ////if (cmbFiltroVista.Items.Count > 0)
            ////{
            ////    cmbFiltroVista.SelectedIndex = 0;
            ////}


            ////refrescaGraficos();

        }

        private void llenaFiltroVista()
        {

            cmbFiltroVista.Items.Clear();
            cmbFiltroVista.Items.Add(vtodos);

            for (int i = 0; i < dataGridVista.Rows.Count; i++)
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

        private string orientacionCamion(double lati, double lngi, double latf, double lngf)
        {

            string resultado = "";


            if (lati < latf && -lngi == -lngf)
            {
                resultado = "N";
            }

            if (lati > latf && -lngi == -lngf)
            {
                resultado = "S";
            }

            if (lati == latf && -lngi < -lngf)
            {
                resultado = "O";
            }

            if (lati == latf && -lngi > -lngf)
            {
                resultado = "E";
            }


            if (lati < latf && -lngi < -lngf)
            {
                resultado = "NO";
            }

            if (lati > latf && -lngi > -lngf)
            {
                resultado = "SE";
            }




            if (lati < latf && -lngi > -lngf)
            {
                resultado = "NE";
            }

            if (lati > latf && -lngi < -lngf)
            {
                resultado = "SO";
            }


            return resultado;

        }

        private string corralUbicacion(DataTable dt, double lat, double lng, double distancia, string vorientacion)
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
            vdt = dt.Copy();

            try
            {

                foreach (DataRow row in vdt.Rows)
                {

                    clat = Convert.ToDouble(row["lat"].ToString());
                    clng = Convert.ToDouble(row["lng"].ToString());

                    vdt.Rows[vdt.Rows.IndexOf(row)]["distancia"] = getDistancia(lat, lng, clat, clng);
                    dist0 = Convert.ToDouble(vdt.Rows[vdt.Rows.IndexOf(row)]["distancia"]);

                    //----------------------------
                    //if ((vorientacion == "NO" || vorientacion == "N" || vorientacion == "O") && clat > lat && -clng < -lng)
                    //{
                    //    continue;
                    //    //vdt.Rows[vdt.Rows.IndexOf(row)]["lat1"] = "0";
                    //    //vdt.Rows[vdt.Rows.IndexOf(row)]["lng1"] = "0";
                    //}

                    //if ((vorientacion == "SE" || vorientacion == "S" || vorientacion == "E") && clat < lat )//&& -clng < -lng)
                    //{
                    //    vdt.Rows[vdt.Rows.IndexOf(row)]["lat1"] = "0";
                    //    vdt.Rows[vdt.Rows.IndexOf(row)]["lng1"] = "0";
                    //}
                    //----------------------------

                    if (dist0 < distmin)
                    {
                        distmin = dist0;
                        corralmin0 = row["corral"].ToString();

                        clatmin0 = clat;
                        clngmin0 = clng;
                    }

                }

                //------------------------------------------------------------------

                //DataRow[] drr = vdt.Select("lat1='0'");
                //foreach (var row in drr)
                //    row.Delete();

                //vdt.DefaultView.Sort = "distancia asc";
                //vdt = vdt.DefaultView.ToTable();

                //overlayLinea.Routes.Clear();

                //if (vdt.Rows.Count >= 1)
                //{
                //    DataRow row = vdt.Rows[0];
                //    clatmin0 = Convert.ToDouble(row["lat"].ToString());
                //    clngmin0 = Convert.ToDouble(row["lng"].ToString());
                //    corralmin0 = row["corral"].ToString();
                //    distmin = Convert.ToDouble(row["distancia"].ToString());
                //    if (distmin <= distancia)
                //    {
                //        mostrarLinea(lat, lng, clatmin0, clngmin0);
                //        corral = corralmin0;
                //        lblDistanciaMin.Text = distmin.ToString();

                //        overlayCircles.Polygons.Clear();
                //        CreateCircle(new PointLatLng(lat, lng), 0.0001, 30);
                //    }
                //    else
                //    {
                //        overlayLinea.Routes.Clear();
                //        overlayCircles.Polygons.Clear();
                //        corral = "0000";
                //        lblDistanciaMin.Text = "";
                //    }
                //}
                //if (vdt.Rows.Count >= 2)
                //{
                //    DataRow row = vdt.Rows[1];
                //    clatmin1 = Convert.ToDouble(row["lat"].ToString());
                //    clngmin1 = Convert.ToDouble(row["lng"].ToString());
                //    corralmin1 = row["corral"].ToString();
                //    distmin = Convert.ToDouble(row["distancia"].ToString());
                //    if (distmin <= distancia)
                //    {
                //        mostrarLinea(lat, lng, clatmin1, clngmin1);
                //    }
                //}
                //if (vdt.Rows.Count >= 3)
                //{
                //    DataRow row = vdt.Rows[2];
                //    clatmin2 = Convert.ToDouble(row["lat"].ToString());
                //    clngmin2 = Convert.ToDouble(row["lng"].ToString());
                //    corralmin2 = row["corral"].ToString();
                //    distmin = Convert.ToDouble(row["distancia"].ToString());
                //    if (distmin <= distancia)
                //    {
                //        mostrarLinea(lat, lng, clatmin2, clngmin2);
                //    }
                //}
                //if (vdt.Rows.Count >= 4)
                //{
                //    DataRow row = vdt.Rows[3];
                //    clatmin3 = Convert.ToDouble(row["lat"].ToString());
                //    clngmin3 = Convert.ToDouble(row["lng"].ToString());
                //    corralmin3 = row["corral"].ToString();
                //    distmin = Convert.ToDouble(row["distancia"].ToString());
                //    if (distmin <= distancia)
                //    {
                //        mostrarLinea(lat, lng, clatmin3, clngmin3);
                //    }
                //}
                //------------------------------------------------------------------

                //if (dist >= 0.5 && dist <= 1)
                if (distmin <= distancia)//0.05)
                {
                    corral = corralmin0;

                    overlayLinea.Routes.Clear();

                    mostrarLinea(lat, lng, clatmin0, clngmin0);

                    lblAngulo.Text = anguloLinea(clatmin0, clngmin0);

                    lblDistanciaMin.Text = distmin.ToString();

                    //-------------------------------------------

                    //mostrarLinea(lat, lng, clatmin1, clngmin1);
                    //mostrarLinea(lat, lng, clatmin2, clngmin2);
                    //mostrarLinea(lat, lng, clatmin3, clngmin3);

                    //-------------------------------------------

                }
                else
                {
                    overlayLinea.Routes.Clear();
                    corral = "0000";
                    lblDistanciaMin.Text = "";
                }

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


        private string anguloLinea(double lat, double lng)
        {
            double angle = Math.Atan2(lat, lng) * (180 / Math.PI);
            return angle.ToString();
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

            //refrescaGraficos();
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
            char a = e.KeyChar;
        }

        private void gMapControl1_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void gMapControl1_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            //Console.WriteLine(String.Format("Polygon {0} with tag {1} was clicked",
            //item.Name, item.Tag));
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (gopc == 3)
            {
                menuColor(item.Tag.ToString().Trim());
            }
            if (gopc == 1)
            {

                if (item.Tag != null)
                {

                    String cadena = item.Tag.ToString().Trim();

                    obtenerWsdlCabezasSap(ref dtCabezastmp);

                    dtCabezastmp.DefaultView.RowFilter = "corral = '" + cadena + "'";
                    dtCabezastmp = dtCabezastmp.DefaultView.ToTable();
                    String cab = "0";
                    String vDetalles = "";

                    if (dtCabezastmp.Rows.Count > 0)
                    {
                        cab = dtCabezastmp.Rows[0][7].ToString().Replace(".000", "");
                        
                        vDetalles = "\n\r" + 
                                    //dtCabezastmp.Rows[0][0].ToString() +"\n\r" +
                                    //dtCabezastmp.Rows[0][1].ToString() + "\n\r" +
                                    //dtCabezastmp.Rows[0][2].ToString() + "\n\r" +
                                    dtCabezastmp.Rows[0][3].ToString() + "\n\r" +
                                    dtCabezastmp.Rows[0][4].ToString() + ", " +
                                    dtCabezastmp.Rows[0][5].ToString() + "\n\r" +
                                    dtCabezastmp.Rows[0][6].ToString() + " Kgs" + "\n\r" +
                                    dtCabezastmp.Rows[0][7].ToString().Replace(".000", "")+" Cab";

                          MessageBox.Show("Corral " + cadena + "" + vDetalles, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                            
                    }
                    else
                    {
                        MessageBox.Show(cadena + ", Cab: " + cab, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                                    
                    lblMsg.Text = cadena + ", Cab: " + cab;
                                  
                }

            }

        }

        private void menuColor(string corral)
        {

            Color color;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                guardarColor(corral, color);
            }

        }

        private void guardarColor(string corral, Color color)
        {

            Datos datos = new Datos();
            DataTable dt = new DataTable();


            datos.p_sql = "SELECT * FROM actividad WHERE corral = '" + corral + "'";

            if (!datos.consultaSQL(ref dt, true))
            {
                MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                if (dt.Rows.Count > 0)
                {
                    datos.p_sql = "UPDATE actividad SET colorarete = '" + color.ToArgb().ToString() + "' WHERE corral = '" + corral + "'";
                }
                else
                {
                    datos.p_sql = "INSERT INTO actividad (corral, colorarete) VALUES ('" + corral + "','" + color.ToArgb().ToString() + "')";
                }

                if (!datos.consultaSQL(ref dt, false))
                {
                    MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    corralActividadMod(corral, color);
                }

            }



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
            tablets.Add("tamggcamr16");
            tablets.Add("tamggcamr17");
            tablets.Add("tamggcamr18");
            tablets.Add("tamggcamr19");
            tablets.Add("tamggcamr20");
            tablets.Add("tamggcamr21");
            tablets.Add("tamggcamr22");

            //tablets.Add("tamggcamr23");
            //tablets.Add("tamggcamr24");
            //tablets.Add("tamggcamr25");
            //tablets.Add("tamggcamr26");
            //tablets.Add("tamggcamr27");
            //tablets.Add("tamggcamr28");
            //tablets.Add("tamggcamr29");
            //tablets.Add("tamggcamr30");
            //tablets.Add("tamggcamr31");
            //tablets.Add("tamggcamr32");
            //tablets.Add("tamggcamr33");
            //tablets.Add("tamggcamr34");
            //tablets.Add("tamggcamr35");
            //tablets.Add("tamggcamr36");



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
                        if (cmbRaciones.Items.Count > 0)
                        {
                            vracion = cmbRaciones.SelectedItem.ToString();
                        }

                        if (cmbCamion.SelectedItem.ToString().Equals(row["numcamion"].ToString())
                            && cmbServidas.SelectedItem.ToString().Equals(row["servida"].ToString())
                            //&& cmbRaciones.SelectedItem.ToString().Contains(row["racion"].ToString())
                            && row["racion"].ToString().Contains(vracion)
                            && !row["hora"].ToString().Equals("0:00:00")
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
            //aqui

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

                string nombre = ok + "-S " + row["servida"].ToString().TrimStart('0') + "-C " + row["corral"].ToString() + "-GPS " + row["corralgps"].ToString() + "-CAM " + row["numcamion"].ToString() + "-" + row["hora"].ToString();

                agregarMarcadorUbicacion(
                    nombre,
                    Convert.ToDouble(row["lat"]),
                    Convert.ToDouble(row["lng"]));

            }

            this.Cursor = Cursors.Default;

        }

        private void insertaLineaComederos(string nombre, PointLatLng a, PointLatLng b)
        {
            _pointslc.Clear();
            _pointslc.Add(a);
            _pointslc.Add(b);

            comederoActividad(nombre, _pointslc, Color.Brown);
        }

        private void lineasComederos()
        {

            overlayComederos.Polygons.Clear();

            insertaLineaComederos("Comedero01", new PointLatLng(21.92068, -98.741342), new PointLatLng(21.920854, -98.741566));
            insertaLineaComederos("Comedero02", new PointLatLng(21.920868, -98.741583), new PointLatLng(21.92103, -98.741805));
            insertaLineaComederos("Comedero03", new PointLatLng(21.920726, -98.741296), new PointLatLng(21.920899, -98.741527));
            insertaLineaComederos("Comedero04", new PointLatLng(21.92091, -98.74154), new PointLatLng(21.921078, -98.741763));




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

        private void picCam16_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 15;
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
            if (trackBar1.Value < 20)
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

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm");
            var vHora = DateTime.Now.ToString("hh");
            var vMinuto = DateTime.Now.ToString("mm");
            var vAmPm = DateTime.Now.ToString("tt").Replace(" ", "").Replace(".", "");


            Principal.instance.toolStripTextBox2.Text = lblHora.Text;
            lblHoraMapa.Text = vHora +":"+ vMinuto + " " + vAmPm;//lblHora.Text;

            if (gopc != 2 && gopc != 3)
            {
                lblTimer.Text = (Int32.Parse(lblTimer.Text) - 1).ToString();
            }


            alarmaCamion(lblCam01, picGps2Cam01, lblpBb01, picRep2Cam01);
            alarmaCamion(lblCam02, picGps2Cam02, lblpBb02, picRep2Cam02);
            alarmaCamion(lblCam03, picGps2Cam03, lblpBb03, picRep2Cam03);
            alarmaCamion(lblCam04, picGps2Cam04, lblpBb04, picRep2Cam04);
            alarmaCamion(lblCam05, picGps2Cam05, lblpBb05, picRep2Cam05);
            alarmaCamion(lblCam06, picGps2Cam06, lblpBb06, picRep2Cam06);
            alarmaCamion(lblCam07, picGps2Cam07, lblpBb07, picRep2Cam07);
            alarmaCamion(lblCam08, picGps2Cam08, lblpBb08, picRep2Cam08);
            alarmaCamion(lblCam09, picGps2Cam09, lblpBb09, picRep2Cam09);
            alarmaCamion(lblCam10, picGps2Cam10, lblpBb10, picRep2Cam10);
            alarmaCamion(lblCam11, picGps2Cam11, lblpBb11, picRep2Cam11);
            alarmaCamion(lblCam12, picGps2Cam12, lblpBb12, picRep2Cam12);
            alarmaCamion(lblCam13, picGps2Cam13, lblpBb13, picRep2Cam13);
            alarmaCamion(lblCam14, picGps2Cam14, lblpBb14, picRep2Cam14);
            alarmaCamion(lblCam15, picGps2Cam15, lblpBb15, picRep2Cam15);
            alarmaCamion(lblCam16, picGps2Cam16, lblpBb16, picRep2Cam16);
            alarmaCamion(lblCam17, picGps2Cam17, lblpBb17, picRep2Cam17);
            alarmaCamion(lblCam18, picGps2Cam18, lblpBb18, picRep2Cam18);
            alarmaCamion(lblCam19, picGps2Cam19, lblpBb19, picRep2Cam19);
            alarmaCamion(lblCam20, picGps2Cam20, lblpBb20, picRep2Cam20);
            alarmaCamion(lblCam21, picGps2Cam21, lblpBb21, picRep2Cam21);
            alarmaCamion(lblCam22, picGps2Cam22, lblpBb22, picRep2Cam22);


        }


        private void alarmaCamion(Label lbl, PictureBox picGps2, Label lblBp, PictureBox picRep2)
        {
            if (picGps2.BackColor == Color.Red ||
                lblBp.BackColor == Color.Yellow ||
                (lbl.ForeColor == Color.Black && picRep2.BackColor == Color.Transparent && picGps2.BackColor == Color.Transparent)
                )
            {

                if (lbl.BackColor == Color.Transparent)
                {
                    lbl.BackColor = Color.Red;
                }
                else
                {
                    lbl.BackColor = Color.Transparent;
                }

            }
            else
            {
                lbl.BackColor = Color.Transparent;
            }

            //if (lblBp.BackColor == Color.Yellow)
            //{

            //    if (lblBp.ForeColor == Color.Black)
            //    {
            //        lblBp.ForeColor = Color.Red;                                        
            //        lblBp.Font = new Font(lblBp.Font, FontStyle.Regular);
            //        lblBp.BorderStyle = BorderStyle.FixedSingle;
            //    }
            //    else
            //    {
            //        lblBp.ForeColor = Color.Black;
            //        lblBp.Font = new Font(lblBp.Font, FontStyle.Bold);
            //        lblBp.BorderStyle = BorderStyle.None;
            //    }

            //}



        }

        private void botonCeldasActividad(int opc)
        {

            Color vcolor = Color.White;

            Datos datos = new Datos();
            DataTable dt = new DataTable();

            this.Cursor = Cursors.WaitCursor;

            datos.p_sql = "SELECT * FROM actividad";

            if (!datos.consultaSQL(ref dt, true))
            {
                MessageBox.Show(datos.p_error, "Mensaje");
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    vcolor = nombreColor(Int32.Parse(row["ColorArete"].ToString()));
                    //vcolor = nombreColor(row["ColorArete"].ToString());
                    corralActividadMod(row["Corral"].ToString(), vcolor);
                }
            }

            this.Cursor = Cursors.Default;

        }

        private Color nombreColor(int nombre)
        {
            Color resultado = Color.White;

            resultado = Color.FromArgb(nombre);

            //resultado = Color.FromName(nombre);



            //switch (nombre.ToUpper().Trim())
            //{
            //    case "ROJO":
            //        resultado = Color.Red;
            //        break;
            //    case "AZUL":
            //        resultado = Color.Blue;
            //        break;
            //    case "VERDE":
            //        resultado = Color.Green;
            //        break;
            //    case "LIMA":
            //        resultado = Color.Lime;
            //        break;
            //    case "AMARILLO":
            //        resultado = Color.Yellow;
            //        break;
            //    case "CELESTE":
            //        resultado = Color.LightBlue;
            //        break;
            //    case "PLATEADO":
            //        resultado = Color.Silver;
            //        break;
            //    case "ROSA":
            //        resultado = Color.Pink;
            //        break;
            //    case "PURPURA":
            //        resultado = Color.Purple;
            //        break;
            //    case "NARANJA":
            //        resultado = Color.Orange;
            //        break;


            //}

            return resultado;
        }

        private void btnOcultarCuadro_Click(object sender, EventArgs e)
        {
            panelLeyendas.Visible = false;
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            giroIzq();
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            panelLeyendas.Visible = true;
        }

        public void toolStripButton19_Click(object sender, EventArgs e)
        {
            giroDer();
        }

        bool PointInRectangle(Point pt, double North, double East, double South, double West)
        {
            // you may want to check that the point is a valid coordinate
            if (West < East)
            {
                return pt.X < East && pt.X > West && pt.Y < North && pt.Y > South;
            }

            // it crosses the date line
            return (pt.X < East || pt.X > West) && pt.Y < North && pt.Y > South;
        }

        private void picRepCam01_Click(object sender, EventArgs e)
        {

        }

        private double porcCamion()
        {
            double cant = 0;

            if (picRepCam01.BackColor != Color.Transparent || picGpsCam01.BackColor != Color.Transparent) { cant++; }
            if (picRepCam02.BackColor != Color.Transparent || picGpsCam02.BackColor != Color.Transparent) { cant++; }
            if (picRepCam03.BackColor != Color.Transparent || picGpsCam03.BackColor != Color.Transparent) { cant++; }
            if (picRepCam04.BackColor != Color.Transparent || picGpsCam04.BackColor != Color.Transparent) { cant++; }
            if (picRepCam05.BackColor != Color.Transparent || picGpsCam05.BackColor != Color.Transparent) { cant++; }
            if (picRepCam06.BackColor != Color.Transparent || picGpsCam06.BackColor != Color.Transparent) { cant++; }
            if (picRepCam07.BackColor != Color.Transparent || picGpsCam07.BackColor != Color.Transparent) { cant++; }
            if (picRepCam08.BackColor != Color.Transparent || picGpsCam08.BackColor != Color.Transparent) { cant++; }
            if (picRepCam09.BackColor != Color.Transparent || picGpsCam09.BackColor != Color.Transparent) { cant++; }
            if (picRepCam10.BackColor != Color.Transparent || picGpsCam10.BackColor != Color.Transparent) { cant++; }
            if (picRepCam11.BackColor != Color.Transparent || picGpsCam11.BackColor != Color.Transparent) { cant++; }
            if (picRepCam12.BackColor != Color.Transparent || picGpsCam12.BackColor != Color.Transparent) { cant++; }
            if (picRepCam13.BackColor != Color.Transparent || picGpsCam13.BackColor != Color.Transparent) { cant++; }
            if (picRepCam14.BackColor != Color.Transparent || picGpsCam14.BackColor != Color.Transparent) { cant++; }
            if (picRepCam15.BackColor != Color.Transparent || picGpsCam15.BackColor != Color.Transparent) { cant++; }
            if (picRepCam16.BackColor != Color.Transparent || picGpsCam16.BackColor != Color.Transparent) { cant++; }
            if (picRepCam17.BackColor != Color.Transparent || picGpsCam17.BackColor != Color.Transparent) { cant++; }
            if (picRepCam18.BackColor != Color.Transparent || picGpsCam18.BackColor != Color.Transparent) { cant++; }
            if (picRepCam19.BackColor != Color.Transparent || picGpsCam19.BackColor != Color.Transparent) { cant++; }
            if (picRepCam20.BackColor != Color.Transparent || picGpsCam20.BackColor != Color.Transparent) { cant++; }
            if (picRepCam21.BackColor != Color.Transparent || picGpsCam21.BackColor != Color.Transparent) { cant++; }
            if (picRepCam22.BackColor != Color.Transparent || picGpsCam22.BackColor != Color.Transparent) { cant++; }
            if (picRepCam23.BackColor != Color.Transparent || picGpsCam23.BackColor != Color.Transparent) { cant++; }
            if (picRepCam24.BackColor != Color.Transparent || picGpsCam24.BackColor != Color.Transparent) { cant++; }

            if (picRepCam25.BackColor != Color.Transparent || picGpsCam25.BackColor != Color.Transparent) { cant++; }
            if (picRepCam26.BackColor != Color.Transparent || picGpsCam26.BackColor != Color.Transparent) { cant++; }
            if (picRepCam27.BackColor != Color.Transparent || picGpsCam27.BackColor != Color.Transparent) { cant++; }
            if (picRepCam28.BackColor != Color.Transparent || picGpsCam28.BackColor != Color.Transparent) { cant++; }
            
            if (picRepCam29.BackColor != Color.Transparent || picGpsCam29.BackColor != Color.Transparent) { cant++; }
            if (picRepCam30.BackColor != Color.Transparent || picGpsCam30.BackColor != Color.Transparent) { cant++; }
            if (picRepCam31.BackColor != Color.Transparent || picGpsCam31.BackColor != Color.Transparent) { cant++; }
            if (picRepCam32.BackColor != Color.Transparent || picGpsCam32.BackColor != Color.Transparent) { cant++; }
            if (picRepCam33.BackColor != Color.Transparent || picGpsCam33.BackColor != Color.Transparent) { cant++; }
            if (picRepCam34.BackColor != Color.Transparent || picGpsCam34.BackColor != Color.Transparent) { cant++; }
            if (picRepCam35.BackColor != Color.Transparent || picGpsCam35.BackColor != Color.Transparent) { cant++; }
            if (picRepCam36.BackColor != Color.Transparent || picGpsCam36.BackColor != Color.Transparent) { cant++; }




            //if (picRepCam01.BackColor != Color.Transparent) { cant++; }
            //if (picRepCam02.BackColor != Color.Transparent) { cant++; }
            //if (picRepCam03.BackColor != Color.Transparent) { cant++; }
            //if (picRepCam04.BackColor != Color.Transparent) { cant++; }
            //if (picRepCam05.BackColor != Color.Transparent) { cant++; }
            //if (picRepCam06.BackColor != Color.Transparent) { cant++; }
            //if (picRepCam07.BackColor != Color.Transparent) { cant++; }
            //if (picRepCam08.BackColor != Color.Transparent) { cant++; }
            //if (picRepCam09.BackColor != Color.Transparent) { cant++; }
            //if (picRepCam10.BackColor != Color.Transparent) { cant++; }
            //if (picRepCam11.BackColor != Color.Transparent) { cant++; }
            //if (picRepCam12.BackColor != Color.Transparent) { cant++; }
            //if (picRepCam13.BackColor != Color.Transparent) { cant++; }
            //if (picRepCam14.BackColor != Color.Transparent) { cant++; }
            //if (picRepCam15.BackColor != Color.Transparent) { cant++; }

            //if (picGpsCam01.BackColor != Color.Transparent) { cant++; }
            //if (picGpsCam02.BackColor != Color.Transparent) { cant++; }
            //if (picGpsCam03.BackColor != Color.Transparent) { cant++; }
            //if (picGpsCam04.BackColor != Color.Transparent) { cant++; }
            //if (picGpsCam05.BackColor != Color.Transparent) { cant++; }
            //if (picGpsCam06.BackColor != Color.Transparent) { cant++; }
            //if (picGpsCam07.BackColor != Color.Transparent) { cant++; }
            //if (picGpsCam08.BackColor != Color.Transparent) { cant++; }
            //if (picGpsCam09.BackColor != Color.Transparent) { cant++; }
            //if (picGpsCam10.BackColor != Color.Transparent) { cant++; }
            //if (picGpsCam11.BackColor != Color.Transparent) { cant++; }
            //if (picGpsCam12.BackColor != Color.Transparent) { cant++; }
            //if (picGpsCam13.BackColor != Color.Transparent) { cant++; }
            //if (picGpsCam14.BackColor != Color.Transparent) { cant++; }
            //if (picGpsCam15.BackColor != Color.Transparent) { cant++; }

            return Math.Round(cant / 16 * 100);
            //return Math.Round(cant / 30 * 100);

        }

        private void lbl01_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 0;
            ubicacionCamion();
        }

        private void lbl02_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 1;
            ubicacionCamion();
        }

        private void lbl03_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 2;
            ubicacionCamion();
        }

        private void lbl04_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 3;
            ubicacionCamion();
        }

        private void lbl05_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 4;
            ubicacionCamion();
        }

        private void lbl06_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 5;
            ubicacionCamion();
        }

        private void lbl07_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 6;
            ubicacionCamion();
        }

        private void lbl08_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 7;
            ubicacionCamion();
        }

        private void lbl09_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 8;
            ubicacionCamion();
        }

        private void lbl10_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 9;
            ubicacionCamion();
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 10;
            ubicacionCamion();
        }

        private void lbl12_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 11;
            ubicacionCamion();
        }

        private void lbl13_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 12;
            ubicacionCamion();
        }

        private void lbl14_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 13;
            ubicacionCamion();
        }

        private void lbl15_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 14;
            ubicacionCamion();
        }

        private void lbl16_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = 15;
            ubicacionCamion();
        }

        private void dataGridVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            //splitContainerMapa.Panel2Collapsed = !splitContainerMapa.Panel2Collapsed;
            panelActCamiones.Visible = !panelActCamiones.Visible;

        }

        private string convertKm(string valor)
        {

            double resultado = 0;
            double cantidad = 0;
            string resultadofinal = "";

            if (valor != "_" && valor != "" && valor != "0")
            {

                try
                {
                    cantidad = Convert.ToDouble(valor);
                    resultado = cantidad * 1.852;
                    resultadofinal = resultado.ToString("000.00", CultureInfo.InvariantCulture);
                }
                catch { }

            }

            return resultadofinal;

        }

        private void splitContainerMapa_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblpBc01_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void panelCamion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCamiones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCam01_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("01");
            ubicacionCamion();
        }

        private void lblCam02_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("02");
            ubicacionCamion();
        }

        private void lblCam03_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("03");
            ubicacionCamion();
        }

        private void lblCam04_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("04");
            ubicacionCamion();
        }

        private void lblCam05_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("05");
            ubicacionCamion();
        }

        private void lblCam06_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("06");
            ubicacionCamion();
        }

        private void lblCam07_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("07");
            ubicacionCamion();
        }

        private void lblCam08_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("08");
            ubicacionCamion();
        }

        private void lblCam09_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("09");
            ubicacionCamion();
        }

        private void lblCam10_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("10");
            ubicacionCamion();
        }

        private void lblCam11_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("11");
            ubicacionCamion();
        }

        private void lblCam12_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("12");
            ubicacionCamion();
        }

        private void lblCam13_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("13");
            ubicacionCamion();
        }

        private void lblCam14_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("14");
            ubicacionCamion();
        }

        private void lblCam15_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("15");
            ubicacionCamion();
        }

        private void lblCam16_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("16");
            ubicacionCamion();
        }

        private void lblCam17_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("17");
            ubicacionCamion();
        }

        private void lblCam18_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("18");
            ubicacionCamion();
        }

        private void lblCam19_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("19");
            ubicacionCamion();
        }

        private void lblCam20_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("20");
            ubicacionCamion();
        }

        private void lblCam21_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("21");
            ubicacionCamion();
        }

        private void lblCam22_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("22");
            ubicacionCamion();
        }

        private void lblCam23_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("23");
            ubicacionCamion();
        }

        private void lblCam24_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("24");
            ubicacionCamion();
        }

        private void lblCam25_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("25");
            ubicacionCamion();
        }

        private void lblCam26_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("26");
            ubicacionCamion();
        }

        private void lblCam27_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("27");
            ubicacionCamion();
        }

        private void lblCam28_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("28");
            ubicacionCamion();
        }


        private void lblCam29_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("29");
            ubicacionCamion();
        }

        private void lblCam30_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("30");
            ubicacionCamion();
        }

        private void lblCam31_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("31");
            ubicacionCamion();
        }

        private void lblCam32_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("32");
            ubicacionCamion();
        }

        private void lblCam33_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("33");
            ubicacionCamion();
        }

        private void lblCam34_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("34");
            ubicacionCamion();
        }

        private void lblCam35_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("35");
            ubicacionCamion();
        }

        private void lblCam36_Click(object sender, EventArgs e)
        {
            cmbCamionRuta.SelectedIndex = cmbCamion.Items.IndexOf("36");
            ubicacionCamion();
        }

        private void zoomBuscar(int valor)
        {
            trackBar1.Value = valor;
            trackMover();
        }

        private void btnAbrirCerrarPanel_Click(object sender, EventArgs e)
        {
            fverPanelCamiones();
        }

        public void fverPanelCamiones()
        {
            //splitContainerMapa.Panel2Collapsed = !splitContainerMapa.Panel2Collapsed;            
            //panelActCamiones.Visible = !panelActCamiones.Visible;
            lblHoraMapa.Visible = !panelActCamiones.Visible;
            
            panelCam01.Visible = !panelCam01.Visible;
            visPanelCamiones(panelCam01.Visible);

        }

        private void chart3_Click(object sender, EventArgs e)
        {
            verClasicos();
        }

        private void chart4_Click(object sender, EventArgs e)
        {
            verEcologicos();
        }

        private void repartosBotonVer(string camion)
        {

            switch (camion)
            {
                case "01":
                    valoresRecorrido(
                    lblpBc01,
                    lblCam01,
                    lblpBr01);
                    break;
                case "02":
                    valoresRecorrido(
                    lblpBc02,
                    lblCam02,
                    lblpBr02);
                    break;
                case "03":
                    valoresRecorrido(
                    lblpBc03,
                    lblCam03,
                    lblpBr03);
                    break;
                case "04":
                    valoresRecorrido(
                    lblpBc04,
                    lblCam04,
                    lblpBr04);
                    break;
                case "05":
                    valoresRecorrido(
                    lblpBc05,
                    lblCam05,
                    lblpBr05);
                    break;
                case "06":
                    valoresRecorrido(
                    lblpBc06,
                    lblCam06,
                    lblpBr06);
                    break;
                case "07":
                    valoresRecorrido(
                    lblpBc07,
                    lblCam07,
                    lblpBr07);
                    break;
                case "08":
                    valoresRecorrido(
                    lblpBc08,
                    lblCam08,
                    lblpBr08);
                    break;
                case "09":
                    valoresRecorrido(
                    lblpBc09,
                    lblCam09,
                    lblpBr09);
                    break;
                case "10":
                    valoresRecorrido(
                    lblpBc10,
                    lblCam10,
                    lblpBr10);
                    break;
                case "11":
                    valoresRecorrido(
                    lblpBc11,
                    lblCam11,
                    lblpBr11);
                    break;
                case "12":
                    valoresRecorrido(
                    lblpBc12,
                    lblCam12,
                    lblpBr12);
                    break;
                case "13":
                    valoresRecorrido(
                    lblpBc13,
                    lblCam13,
                    lblpBr13);
                    break;
                case "14":
                    valoresRecorrido(
                    lblpBc14,
                    lblCam14,
                    lblpBr14);
                    break;
                case "15":
                    valoresRecorrido(
                    lblpBc15,
                    lblCam15,
                    lblpBr15);
                    break;
                case "16":
                    valoresRecorrido(
                    lblpBc16,
                    lblCam16,
                    lblpBr16);
                    break;
                case "17":
                    valoresRecorrido(
                    lblpBc17,
                    lblCam17,
                    lblpBr17);
                    break;
                case "18":
                    valoresRecorrido(
                    lblpBc18,
                    lblCam18,
                    lblpBr18);
                    break;
                case "19":
                    valoresRecorrido(
                    lblpBc19,
                    lblCam19,
                    lblpBr19);
                    break;
                case "20":
                    valoresRecorrido(
                    lblpBc20,
                    lblCam20,
                    lblpBr20);
                    break;
                case "21":
                    valoresRecorrido(
                    lblpBc21,
                    lblCam21,
                    lblpBr21);
                    break;
                case "22":
                    valoresRecorrido(
                    lblpBc22,
                    lblCam22,
                    lblpBr22);
                    break;
                case "23":
                    valoresRecorrido(
                    lblpBc23,
                    lblCam23,
                    lblpBr23);
                    break;
                case "24":
                    valoresRecorrido(
                    lblpBc24,
                    lblCam24,
                    lblpBr24);
                    break;

                case "25":
                    valoresRecorrido(
                    lblpBc25,
                    lblCam25,
                    lblpBr25);
                    break;
                case "26":
                    valoresRecorrido(
                    lblpBc26,
                    lblCam26,
                    lblpBr26);
                    break;
                case "27":
                    valoresRecorrido(
                    lblpBc27,
                    lblCam27,
                    lblpBr27);
                    break;
                case "28":
                    valoresRecorrido(
                    lblpBc28,
                    lblCam28,
                    lblpBr28);
                    break;

            }

            vselActRut = camion;

            repartosBoton();

            gMapControl1.Position = new PointLatLng(vlat, vlng);
            zoomBuscar(17);

        }

        private void valoresRecorrido(
            Label label1,
            Label label2,
            Label label3
            )
        {
            cmbServidas.Text = servColor(label1);
            cmbCamion.Text = label2.Text;
            cmbRaciones.Items.Clear();
            //cmbRaciones.Text = label3.Text;
        }

        private string servColor(Label label)
        {
            string resultado = "1";

            if (label.BackColor == Color.Orange)
            {
                resultado = "1";
            }
            else
            {
                resultado = "2";
            }

            return resultado;
        }

        private void picRec01_Click(object sender, EventArgs e)
        {
            repartosBotonVer("01");
        }

        private void picRec02_Click(object sender, EventArgs e)
        {
            repartosBotonVer("02");
        }

        private void picRec03_Click(object sender, EventArgs e)
        {
            repartosBotonVer("03");
        }

        private void picRec04_Click(object sender, EventArgs e)
        {
            repartosBotonVer("04");
        }

        private void picRec05_Click(object sender, EventArgs e)
        {
            repartosBotonVer("05");
        }

        private void picRec06_Click(object sender, EventArgs e)
        {
            repartosBotonVer("06");
        }

        private void picRec07_Click(object sender, EventArgs e)
        {
            repartosBotonVer("07");
        }

        private void picRec08_Click(object sender, EventArgs e)
        {
            repartosBotonVer("08");
        }

        private void picRec09_Click(object sender, EventArgs e)
        {
            repartosBotonVer("09");
        }

        private void picRec10_Click(object sender, EventArgs e)
        {
            repartosBotonVer("10");
        }

        private void picRec11_Click(object sender, EventArgs e)
        {
            repartosBotonVer("11");
        }

        private void picRec12_Click(object sender, EventArgs e)
        {
            repartosBotonVer("12");
        }

        private void picRec13_Click(object sender, EventArgs e)
        {
            repartosBotonVer("13");
        }

        private void picRec14_Click(object sender, EventArgs e)
        {
            repartosBotonVer("14");
        }

        private void picRec15_Click(object sender, EventArgs e)
        {
            repartosBotonVer("15");
        }

        private void picRec16_Click(object sender, EventArgs e)
        {
            repartosBotonVer("16");
        }

        private void picRec17_Click(object sender, EventArgs e)
        {
            repartosBotonVer("17");
        }

        private void picRec18_Click(object sender, EventArgs e)
        {
            repartosBotonVer("18");
        }

        private void picRec19_Click(object sender, EventArgs e)
        {
            repartosBotonVer("19");
        }

        private void picRec20_Click(object sender, EventArgs e)
        {
            repartosBotonVer("20");
        }

        private void picRec21_Click(object sender, EventArgs e)
        {
            repartosBotonVer("21");
        }

        private void picRec22_Click(object sender, EventArgs e)
        {
            repartosBotonVer("22");
        }

        private void picRec23_Click(object sender, EventArgs e)
        {
            repartosBotonVer("23");
        }



        private void picRecLimpia_Click(object sender, EventArgs e)
        {
            quitarRecorrido();
        }

        private void picRec01_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec01.BackColor = Color.CadetBlue;
        }

        private void picRec01_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "01") { picRec01.BackColor = Color.Transparent; }
        }

        private void picRec02_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec02.BackColor = Color.CadetBlue;
        }

        private void picRec02_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "02") { picRec02.BackColor = Color.Transparent; }
        }

        private void picRec03_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec03.BackColor = Color.CadetBlue;
        }

        private void picRec03_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "03") { picRec03.BackColor = Color.Transparent; }
        }

        private void picRec04_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec04.BackColor = Color.CadetBlue;
        }

        private void picRec04_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "04") { picRec04.BackColor = Color.Transparent; }
        }

        private void picRec05_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec05.BackColor = Color.CadetBlue;
        }

        private void picRec05_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "05") { picRec05.BackColor = Color.Transparent; }
        }

        private void picRec06_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec06.BackColor = Color.CadetBlue;
        }

        private void picRec06_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "06") { picRec06.BackColor = Color.Transparent; }
        }

        private void picRec07_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec07.BackColor = Color.CadetBlue;
        }

        private void picRec07_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "07") { picRec07.BackColor = Color.Transparent; }
        }

        private void picRec08_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec08.BackColor = Color.CadetBlue;
        }

        private void picRec08_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "08") { picRec08.BackColor = Color.Transparent; }
        }

        private void picRec09_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec09.BackColor = Color.CadetBlue;
        }

        private void picRec09_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "09") { picRec09.BackColor = Color.Transparent; }
        }

        private void picRec10_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec10.BackColor = Color.CadetBlue;
        }

        private void picRec10_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "10") { picRec10.BackColor = Color.Transparent; }
        }

        private void picRec11_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec11.BackColor = Color.CadetBlue;
        }

        private void picRec11_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "11") { picRec11.BackColor = Color.Transparent; }
        }

        private void picRec12_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec12.BackColor = Color.CadetBlue;
        }

        private void picRec12_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "12") { picRec12.BackColor = Color.Transparent; }
        }

        private void picRec13_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec13.BackColor = Color.CadetBlue;
        }

        private void picRec13_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "13") { picRec13.BackColor = Color.Transparent; }
        }

        private void picRec14_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec14.BackColor = Color.CadetBlue;
        }

        private void picRec14_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "14") { picRec14.BackColor = Color.Transparent; }
        }

        private void picRec15_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec15.BackColor = Color.CadetBlue;
        }

        private void picRec15_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "15") { picRec15.BackColor = Color.Transparent; }
        }

        private void picRec16_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec16.BackColor = Color.CadetBlue;
        }

        private void picRec16_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "16") { picRec16.BackColor = Color.Transparent; }
        }


        private void picRec17_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec17.BackColor = Color.CadetBlue;
        }

        private void picRec17_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "17") { picRec17.BackColor = Color.Transparent; }
        }

        private void picRec18_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec18.BackColor = Color.CadetBlue;
        }

        private void picRec18_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "18") { picRec18.BackColor = Color.Transparent; }
        }


        private void picRec19_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec19.BackColor = Color.CadetBlue;
        }

        private void picRec19_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "19") { picRec19.BackColor = Color.Transparent; }
        }


        private void picRec20_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec20.BackColor = Color.CadetBlue;
        }

        private void picRec20_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "20") { picRec20.BackColor = Color.Transparent; }
        }


        private void picRec21_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec21.BackColor = Color.CadetBlue;
        }

        private void picRec21_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "21") { picRec21.BackColor = Color.Transparent; }
        }


        private void picRec22_MouseMove(object sender, MouseEventArgs e)
        {
            limpiaBotonesRut();
            picRec22.BackColor = Color.CadetBlue;
        }

        private void picRec22_MouseLeave(object sender, EventArgs e)
        {
            if (vselActRut != "22") { picRec22.BackColor = Color.Transparent; }
        }

        private void picRec23_MouseLeave(object sender, EventArgs e)
        {
            limpiaBotonesRut();
            picRec23.BackColor = Color.CadetBlue;
        }

        private void picRec23_MouseMove(object sender, MouseEventArgs e)
        {
            if (vselActRut != "23") { picRec23.BackColor = Color.Transparent; }
        }



        private void cmbCamionRuta_Click(object sender, EventArgs e)
        {

        }

        private void listBoxRutaError_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscarRutaError(listBoxRutaError.Text);
        }

        private void buscarRutaError(string valor)
        {
            DataTable dt = new DataTable();

            DataRow[] rows = dtRutaErrortmp.Select("texto = '" + valor.Substring(0, 4) + "'");

            foreach (DataRow row in rows)
            {

                leerWsdlBuscarUbicacion(ref dt, row["texto"].ToString());

                foreach (DataRow row2 in dt.Rows)
                {
                    vlat = Convert.ToDouble(row2["lat"]);
                    vlng = Convert.ToDouble(row2["lng"]);

                    gMapControl1.Position = new PointLatLng(vlat, vlng);
                    zoomBuscar(18);
                }

            }

        }

        private void notificacion(int duracion, string titulo, string mensaje, ToolTipIcon icono)
        {


            //notifyIcon1.ShowBalloonTip(duracion, titulo, mensaje, icono);
        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            DataTable dt = new DataTable();
            leerWsdlRepartosErr(ref dt);

            //dt.DefaultView.Sort = "hora asc";
            //dt = dt.DefaultView.ToTable();

            //DataRow[] rows = dt.Select("lat = '0.0000000000' OR lng = '0.0000000000'");
            //foreach (DataRow row in rows) dt.Rows.Remove(row);



            foreach (DataRow row in dt.Rows)
            {
                corralActividadMod(row["corral"].ToString(), Color.Red);
            }


            this.Cursor = Cursors.Default;

        }

        private void lblpBr03_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CopyGMapElements(GMapControl source, GMapControl destination)
        {
            // Ensure the destination control uses the same map provider and settings
            //destination.MapProvider = source.MapProvider;
            //destination.Position = source.Position;
            //destination.Zoom = source.Zoom;
            //destination.MinZoom = source.MinZoom;
            //destination.MaxZoom = source.MaxZoom;
            //destination.DragButton = source.DragButton;

            // Copy markers
            //foreach (GMapMarker marker in source.Overlays.SelectMany(o => o.Markers))
            //{
            //    GMapMarker newMarker = new GMarkerGoogle(marker.Position, (marker as GMarkerGoogle).Type);
            //    newMarker.ToolTipText = marker.ToolTipText;
            //    destination.Overlays.First().Markers.Add(newMarker);
            //}

            // Copy routes
            //foreach (GMapRoute route in source.Overlays.SelectMany(o => o.Routes))
            //{
            //    GMapRoute newRoute = new GMapRoute(route.Points, route.Name)
            //    {
            //        Stroke = route.Stroke
            //    };
            //    destination.Overlays.First().Routes.Add(newRoute);
            //}

            // Copy polygons
            foreach (GMapPolygon polygon in source.Overlays.SelectMany(o => o.Polygons))
            {
                GMapPolygon newPolygon = new GMapPolygon(polygon.Points, polygon.Name)
                {
                    Fill = polygon.Fill,
                    Stroke = polygon.Stroke,
                    IsVisible = polygon.IsVisible,
                    Tag = polygon.Tag
                };
                destination.Overlays.First().Polygons.Add(newPolygon);
            }

            // Refresh the destination control to update the display
            destination.Refresh();
        }

        private void splitContainerMapas_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            //splitContainerMapas.Panel1Collapsed = !splitContainerMapas.Panel1Collapsed;
            //fver2mapas();

            try
            {
                panelMenu.Visible = !panelMenu.Visible;
                if (panelMenu.Visible)
                {
                    btnCerrarPanel.Top = panelMenu.Top + panelMenu.Height + 10;
                }
                else
                {
                    btnCerrarPanel.Top = 0;
                }
            }
            catch { }

        }

        public void fver2mapas()
        {
            splitContainerMapas.Panel1Collapsed = !splitContainerMapas.Panel1Collapsed;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void panelCam07_Paint(object sender, PaintEventArgs e)
        {

        }

        void fPingEquipos()
        {
            //// Crear el archivo batch
            //string batchFilePath = Path.Combine(Path.GetTempPath(), "ping_hosts.bat");
            //File.WriteAllText(batchFilePath, CrearBatchScript());

            //// Ejecutar el archivo batch y capturar la salida
            //EjecutarBatch(batchFilePath);


            // Ruta donde se guardará el archivo batch
            string batchFilePath = @"ping_hosts.bat";

            // Contenido del archivo batch
            string batchContent = @"@echo off
            setlocal enabledelayedexpansion

            :: Lista de direcciones IP o nombres de host
            set ""hosts=tamggcamr01 tamggcamr02 tamggcamr03 tamggcamr04 tamggcamr05 tamggcamr06 tamggcamr07 tamggcamr08 tamggcamr09 tamggcamr10 tamggcamr11 tamggcamr12 tamggcamr13 tamggcamr14 tamggcamr15 tamggcamr16 tamggcamr17 tamggcamr18 tamggcamr19 tamggcamr20 tamggcamr21 tamggcamr22 tamggcamr23 tamggcamr24 tamggcamr25 tamggcamr26 tamggcamr27 tamggcamr28 tamggcamr29 tamggcamr30 tamggcamr31 tamggcamr32 tamggcamr33 tamggcamr34 tamggcamr35 tamggcamr36""

            :: Recorre cada host
            echo RASTREANDO ...
            for %%h in (%hosts%) do (
   
                ping -n 1 %%h | find ""bytes="" >nul
                if !errorlevel! == 0 (
                    echo %%h ON LINE.
                ) else (
                    echo %%h sin respuesta.
                )
            )

            pause";

            // Crear el archivo batch
            File.WriteAllText(batchFilePath, batchContent);

            // Configurar el proceso para ejecutar el archivo batch
            Process process = new Process();
            process.StartInfo.FileName = batchFilePath;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal; // Muestra la ventana de CMD
            process.StartInfo.CreateNoWindow = false; // Asegurarse de que la ventana se muestre
            process.Start();

            // Esperar a que el proceso termine
            process.WaitForExit();
        }

        public void toolStripButton22_Click(object sender, EventArgs e)
        {
            
            Thread t = new Thread(() => { fPingEquipos(); });
            t.Name = "fping";
            t.IsBackground = true;
            t.Start();

        }

        void inactivarNumCam()
        {

            Color vColorAusenteBaja = Color.FromArgb(53, 57, 58);

            lblCam01.ForeColor = vColorAusenteBaja;
            lblCam02.ForeColor = vColorAusenteBaja;
            lblCam03.ForeColor = vColorAusenteBaja;
            lblCam04.ForeColor = vColorAusenteBaja;
            lblCam05.ForeColor = vColorAusenteBaja;
            lblCam06.ForeColor = vColorAusenteBaja;
            lblCam07.ForeColor = vColorAusenteBaja;
            lblCam08.ForeColor = vColorAusenteBaja;
            lblCam09.ForeColor = vColorAusenteBaja;
            lblCam10.ForeColor = vColorAusenteBaja;
            lblCam11.ForeColor = vColorAusenteBaja;





            pBar04.Visible = false;
            pBar05.Visible = false;
            pBar06.Visible = false;
            pBar07.Visible = false;
            pBar08.Visible = false;
            pBar09.Visible = false;
            pBar10.Visible = false;
            pBar11.Visible = false;
            

        }


        //private string CrearBatchScript()
        //{
        //    // Contenido del archivo batch
        //    return @"
        //    @echo off
        //    setlocal enabledelayedexpansion

        //    :: Lista de direcciones IP o nombres de host
        //    set ""hosts=tamggcamr01 tamggcamr02""

        //    :: set ""hosts=tamggcamr01 tamggcamr02 tamggcamr03 tamggcamr04 tamggcamr05 tamggcamr06 tamggcamr07 tamggcamr08 tamggcamr09 tamggcamr10 tamggcamr11 tamggcamr12 tamggcamr13 tamggcamr14 tamggcamr15 tamggcamr16 tamggcamr17 tamggcamr18 tamggcamr19 tamggcamr20 tamggcamr21 tamggcamr22 tamggcamr23 tamggcamr24 tamggcamr25 tamggcamr26 tamggcamr27 tamggcamr28""
        //    :: Recorre cada host
        //    echo RASTREANDO ...
        //    for %%h in (%hosts%) do (
        //        ping -n 1 %%h >nul
        //        if !errorlevel! == 0 (
        //            echo %%h disponible.
        //        ) else (
        //            echo %%h no responde.
        //        )
        //    )


        //    ";
        //}

        //private void EjecutarBatch(string batchFilePath)
        //{
        //    // Crear el proceso para ejecutar el archivo batch
        //    ProcessStartInfo psi = new ProcessStartInfo
        //    {
        //        FileName = batchFilePath,
        //        RedirectStandardOutput = true,
        //        UseShellExecute = false,
        //        CreateNoWindow = true
        //    };

        //    using (Process process = new Process())
        //    {
        //        process.StartInfo = psi;
        //        process.OutputDataReceived += (sender, args) =>
        //        {
        //            if (!string.IsNullOrEmpty(args.Data))
        //            {
        //                // Agregar la salida al ListBox
        //                this.Invoke(new Action(() =>
        //                {
        //                    listBox1.Items.Add(args.Data);
        //                }));
        //            }
        //        };

        //        // Iniciar el proceso y leer la salida
        //        process.Start();
        //        process.BeginOutputReadLine();
        //        process.WaitForExit();
        //    }
        //}

        void panelIniTablero()
        {

            panelTablero = new RoundedPanel();
            panelTablero.Visible = false;
            panelTablero.CornerRadius1 = 1;
            panelTablero.CornerRadius2 = 1;
            panelTablero.CornerRadius3 = 1;
            panelTablero.CornerRadius4 = 1;
            panelTablero.Height = 100;
            panelTablero.Width = 100;
            panelTablero.Top = 100;
            panelTablero.Left = 100;
            panelTablero.BackColor = Color.FromArgb(100, 88, 104, 105);

            //panelTablero.BackColor = Color.FromArgb(150, Color.Black); // Color con opacidad (100 es el valor alfa)


            //panelLogin.Controls.Add(lblMsgLogin);

            splitContainerMapas.Panel2.Controls.Add(panelTablero);
            panelTablero.BringToFront();
            //panelTablero.Dock = DockStyle.Bottom;

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void panelCamion2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Paint(object sender, PaintEventArgs e)
        {
            Comun.valorBoton(pictureBox24, e, vCantDesconect.ToString(), Color.White);
        }

        private void pictureBox20_Paint(object sender, PaintEventArgs e)
        {
            Comun.valorBoton(pictureBox24, e, vCantConect.ToString(), Color.White);
        }

        private void pictureBox16_Paint(object sender, PaintEventArgs e)
        {
            Comun.valorBoton(pictureBox24, e, vCantLocaliza.ToString(), Color.Black);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblDetalleStatus.Visible = !lblDetalleStatus.Visible;
            //msgCamiones();
        }

        void msgCamiones()
        {               


            if (!lblDetalleStatus.Visible) return;

            //leer esta varioable dtLocalizatmp y mostrarla en un msgbox
            string mensaje = "Status Tablets:\n";
            //sort dtLocalizatmp
            dtLocalizatmp.DefaultView.Sort = "numcamion asc";
            dtLocalizatmp = dtLocalizatmp.DefaultView.ToTable();
            
            int i = 0;

            foreach (DataRow row in dtLocalizatmp.Rows)
            {
                if (row["fechareg"].ToString() == DateTime.Now.ToString("yyyy-MM-dd"))
                {
                    //if primer letra de sea row["varios02"] == E

                    //if (!row["varios02"].ToString().StartsWith("E"))
                    //{
                        mensaje += $"[{row["numcamion"].ToString().PadLeft(2, '0')}], {row["varios01"].ToString().Replace("TAMGGCAMR", "T")}, {row["horareg"]}, {row["pila"]}, {row["varios02"]}\n";
                        i++;
                    //}
                }
            }
            lblDetalleStatus.Text = mensaje + "\r\n"+i.ToString() + " cam";//.Replace("\n"," ");
            //MessageBox.Show(mensaje, "Gps", MessageBoxButtons.OK, MessageBoxIcon.Information);
            posLblStatus();
        }

        public void lblEtiquetaRutas_Click(object sender, EventArgs e)
        {
            verStatusTablets();
        }

        void verStatusTablets()
        {
            lblDetalleStatus.Visible = !lblDetalleStatus.Visible;
            lblDetalleStatusTaller.Visible = !lblDetalleStatusTaller.Visible;
        }

        void DibujarBarraProgreso(ProgressStackBar progressBar)
        {
            if(progressBar==null) { return; }
            //panelControl.Controls.Clear();

            //progressBar = new ProgressStackBar
            //{
            //    Location = new Point(0, 0),
            //    Height = panelControl.Height,
            //    Width = panelControl.Width
            //};
            
            //panelControl.Controls.Add(progressBar);
            //progressBar.BringToFront();
            //panelControl.BringToFront();

            progressBar.ClearSegments();
            progressBar.AddSegment("CPU", 50, Color.FromArgb(52, 152, 219));
            progressBar.AddSegment("Memoria", 25, Color.FromArgb(46, 204, 113));
            progressBar.AddSegment("Disco", 25, Color.FromArgb(241, 196, 15));

            //panelControl.Refresh();
            //progressBar.Refresh();

        }

        public void DibujarRelojAnalogico(Panel panelControl)
        {
            // Suscribirse al evento Paint del panel
            panelControl.Paint += (sender, e) => {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Obtener tiempo actual
                DateTime ahora = DateTime.Now;
                int horas = ahora.Hour % 12; // Formato 12 horas
                int minutos = ahora.Minute;
                int segundos = ahora.Second;

                // Dimensiones del panel
                int ancho = panelControl.Width;
                int alto = panelControl.Height;
                int radio = Math.Min(ancho, alto) / 2 - 10; // Radio del reloj
                Point centro = new Point(ancho / 2, alto / 2);

                // Dibujar círculo del reloj 
                using (Pen penBorde = new Pen(Color.Black, 1))
                {
                    //g.DrawEllipse(penBorde, centro.X - radio, centro.Y - radio, radio * 2, radio * 2);
                }

                // Dibujar marcas de horas
                //using (Pen penMarcas = new Pen(Color.Silver, 2))
                //{
                //    for (int i = 0; i < 12; i++)
                //    {
                //        double angulo = (i * 30 - 90) * Math.PI / 180; // -90 para que 12 esté arriba
                //        int x1 = (int)(centro.X + Math.Cos(angulo) * (radio - 10));
                //        int y1 = (int)(centro.Y + Math.Sin(angulo) * (radio - 10));
                //        int x2 = (int)(centro.X + Math.Cos(angulo) * (radio - 20));
                //        int y2 = (int)(centro.Y + Math.Sin(angulo) * (radio - 20));

                //        g.DrawLine(penMarcas, x1, y1, x2, y2);
                //    }
                //}

                // Dibujar marcas de horas como puntos
                using (SolidBrush brushPuntos = new SolidBrush(Color.Silver))
                {
                    for (int i = 0; i < 12; i++)
                    {
                        double angulo = (i * 30 - 90) * Math.PI / 180; // -90 para que 12 esté arriba
                        int x = (int)(centro.X + Math.Cos(angulo) * (radio - 15));
                        int y = (int)(centro.Y + Math.Sin(angulo) * (radio - 15));

                        // Dibujar punto (círculo pequeño)
                        g.FillEllipse(brushPuntos, x - 3, y - 3, 6, 6);
                    }
                }

                // Dibujar números de horas
                using (Font fuente = new Font("Courier", 12, FontStyle.Bold))
                using (SolidBrush brush = new SolidBrush(Color.Silver))
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        if (i != 3 && i != 6 && i != 9 && i != 12)
                        {
                            continue;
                        }

                        double angulo = (i * 30 - 90) * Math.PI / 180;
                        string numero = i.ToString();
                        SizeF tamañoTexto = g.MeasureString(numero, fuente);

                        int x = (int)(centro.X + Math.Cos(angulo) * (radio - 35) - tamañoTexto.Width / 2);
                        int y = (int)(centro.Y + Math.Sin(angulo) * (radio - 35) - tamañoTexto.Height / 2);

                        g.DrawString(numero, fuente, brush, x, y);
                    }
                }

                // Calcular ángulos de las manecillas
                double anguloHora = ((horas * 30) + (minutos * 0.5) - 90) * Math.PI / 180;
                double anguloMinuto = ((minutos * 6) - 90) * Math.PI / 180;

                // Dibujar manecilla de minutos (más larga)
                using (Pen penMinutos = new Pen(Color.WhiteSmoke, 3))
                {
                    int longitudMinutos = (int)(radio * 0.8);
                    int xMinutos = (int)(centro.X + Math.Cos(anguloMinuto) * longitudMinutos);
                    int yMinutos = (int)(centro.Y + Math.Sin(anguloMinuto) * longitudMinutos);

                    g.DrawLine(penMinutos, centro.X, centro.Y, xMinutos, yMinutos);
                }

                // Dibujar manecilla de horas (más corta y gruesa)
                using (Pen penHoras = new Pen(Color.WhiteSmoke, 4))
                {
                    int longitudHoras = (int)(radio * 0.5);
                    int xHoras = (int)(centro.X + Math.Cos(anguloHora) * longitudHoras);
                    int yHoras = (int)(centro.Y + Math.Sin(anguloHora) * longitudHoras);

                    g.DrawLine(penHoras, centro.X, centro.Y, xHoras, yHoras);
                }

                //// Dibujar hora digital entre las manecillas y el 6
                //using (Font fuenteDigital = new Font("Courier", 10, FontStyle.Bold))
                //using (SolidBrush brushDigital = new SolidBrush(Color.WhiteSmoke))
                //{
                //    string horaDigital = ahora.ToString("hh:mm tt");
                //    SizeF tamañoHora = g.MeasureString(horaDigital, fuenteDigital);

                //    // Posición entre el centro y el número 6
                //    int xHora = (int)(centro.X - tamañoHora.Width / 2);
                //    int yHora = (int)(centro.Y + radio * 0.3); // 30% hacia abajo del centro

                //    g.DrawString(horaDigital, fuenteDigital, brushDigital, xHora, yHora);
                //}

                // Dibujar punto central
                using (SolidBrush brushCentro = new SolidBrush(Color.WhiteSmoke))
                {
                    g.FillEllipse(brushCentro, centro.X - 4, centro.Y - 4, 8, 8);
                }
            };

            // Configurar el panel para fondo transparente
            panelControl.BackColor = Color.Transparent;

            //// Timer para actualizar el reloj cada segundo
            //Timer timer = new Timer();
            //timer.Interval = 1000; // 1 segundo
            //timer.Tick += (sender, e) => {
            //    panelControl.Invalidate(); // Fuerza el redibujado
            //};
            //timer.Start();
            panelControl.Invalidate();

        }

        private void timerClockMin_Tick(object sender, EventArgs e)
        {
            //DibujarRelojAnalogico(panelReloj);
        }

        private void panelReloj_Click(object sender, EventArgs e)
        {
            //DibujarRelojAnalogico(panelReloj);
        }

        private void timerRepartos_Tick(object sender, EventArgs e)
        {
            gMostrarRepartos = true;
            gTimerActivo1 = true;
        }

        private double ConvertirNudosAKilometros(double knots)
        {
            // 1 nudo náutico = 1.852 kilómetros por hora
            const double FACTOR_CONVERSION = 1.852;
            return knots * FACTOR_CONVERSION;
        }

        private void panelIndicador01_Paint(object sender, PaintEventArgs e)
        {
            //Tacometro.DibujarTacometro(panelIndicador01, 29); 
        }

        private void panelIndicador02_Paint(object sender, PaintEventArgs e)
        {
            //Tacometro.DibujarTacometro(panelIndicador02, 59);
        }

        bool camionTaller(string nombre)
        {
            string ad = nombre.Trim('0');
            DataRow[] rows = dtTallertmp.Select("id = '" + nombre.TrimStart('0') + "'");
            return rows.Count() > 0;
        }

        void msgCamionesTaller()
        {


            if (!lblDetalleStatusTaller.Visible) return;

            //leer esta varioable dtLocalizatmp y mostrarla en un msgbox
            string mensaje = "Status Taller:\n";
            //sort dtLocalizatmp
            dtTallertmp.DefaultView.Sort = "id";
            dtTallertmp = dtTallertmp.DefaultView.ToTable();

            int i = 0;

            foreach (DataRow row in dtTallertmp.Rows)
            {
                //if (row["fecha"].ToString() == DateTime.Now.ToString("yyyy-MM-dd"))
                //{
                    //if primer letra de sea row["varios02"] == E

                    //if (!row["varios02"].ToString().StartsWith("E"))
                    //{
                        //mensaje += $"[{row["numcamion"].ToString().PadLeft(2, '0')}], {row["varios01"].ToString().Replace("TAMGGCAMR", "T")}, {row["horareg"]}, {row["pila"]}, {row["varios02"]}\n";
                        mensaje += $"[{row["numcamion"].ToString().PadLeft(2, '0')}], {row["name"].ToString()}, {row["fecha"].ToString()}, {row["mtto"].ToString()}\n";
                        i++;
                    //}
                //}
            }

            lblDetalleStatusTaller.Text = mensaje + "\r\n"; //+ i.ToString() + " cam";//.Replace("\n"," ");
            //MessageBox.Show(mensaje, "Gps", MessageBoxButtons.OK, MessageBoxIcon.Information);
            posLblStatus();

        }

        private void lblEtiquetaTaller_Click(object sender, EventArgs e)
        {
            lblDetalleStatusTaller.Visible = !lblDetalleStatusTaller.Visible;
            lblDetalleStatus.Visible = false;
        }

        private void lblEtiquetaConCabSinServir_Click(object sender, EventArgs e)
        {

        }

        private void picIndicador01_Click(object sender, EventArgs e)
        {
            verSinServir = !verSinServir;
            if (verSinServir) 
            { lblEtiquetaConCabSinServir.Text = "CAB ***"; } 
            else
            { lblEtiquetaConCabSinServir.Text = "CAB"; }


            mensajeSinServir = "";
            quitarMarcadorBuscarUbicaciones();
            //lblDetalleCabSinServir.Visible = !lblDetalleCabSinServir.Visible;
        }


        void IniBarrasprogreso()
        {

            altura_barra_progress_ubic = 30;

            progressBar01.SetAltura(altura_barra_progress_ubic);
            progressBar01.Parent = gMapControl1;
            lblEcologicosCorrrales.Parent = gMapControl1;

            progressBar02.SetAltura(altura_barra_progress_ubic);
            progressBar02.Parent = gMapControl1;
            lblClasicosCorrrales.Parent = gMapControl1;


            altura_barra_progress_cam = 5;

            progressBarCam01.SetAltura(altura_barra_progress_cam);
            progressBarCam01.Parent = gMapControl1;

            progressBarCam02.SetAltura(altura_barra_progress_cam);
            progressBarCam02.Parent = gMapControl1;
            progressBarCam03.SetAltura(altura_barra_progress_cam);
            progressBarCam03.Parent = gMapControl1;
            progressBarCam12.SetAltura(altura_barra_progress_cam);
            progressBarCam12.Parent = gMapControl1;
            progressBarCam13.SetAltura(altura_barra_progress_cam);
            progressBarCam13.Parent = gMapControl1;

            progressBarCam14.SetAltura(altura_barra_progress_cam);
            progressBarCam14.Parent = gMapControl1;

            progressBarCam15.SetAltura(altura_barra_progress_cam);
            progressBarCam15.Parent = gMapControl1;

            progressBarCam16.SetAltura(altura_barra_progress_cam);
            progressBarCam16.Parent = gMapControl1;

            progressBarCam17.SetAltura(altura_barra_progress_cam);
            progressBarCam17.Parent = gMapControl1;

            progressBarCam18.SetAltura(altura_barra_progress_cam);
            progressBarCam18.Parent = gMapControl1;

            progressBarCam19.SetAltura(altura_barra_progress_cam);
            progressBarCam19.Parent = gMapControl1;

            progressBarCam20.SetAltura(altura_barra_progress_cam);
            progressBarCam20.Parent = gMapControl1;

            progressBarCam21.SetAltura(altura_barra_progress_cam);
            progressBarCam21.Parent = gMapControl1;

            progressBarCam22.SetAltura(altura_barra_progress_cam);
            progressBarCam22.Parent = gMapControl1;

            progressBarCam23.SetAltura(altura_barra_progress_cam);
            progressBarCam23.Parent = gMapControl1;

            progressBarCam24.SetAltura(altura_barra_progress_cam);
            progressBarCam24.Parent = gMapControl1;

            progressBarCam25.SetAltura(altura_barra_progress_cam);
            progressBarCam25.Parent = gMapControl1;

            progressBarCam26.SetAltura(altura_barra_progress_cam);
            progressBarCam26.Parent = gMapControl1;

            progressBarCam27.SetAltura(altura_barra_progress_cam);
            progressBarCam27.Parent = gMapControl1;

            progressBarCam28.SetAltura(altura_barra_progress_cam);
            progressBarCam28.Parent = gMapControl1;

            progressBarCam29.SetAltura(altura_barra_progress_cam);
            progressBarCam29.Parent = gMapControl1;

            progressBarCam30.SetAltura(altura_barra_progress_cam);
            progressBarCam30.Parent = gMapControl1;

            progressBarCam31.SetAltura(altura_barra_progress_cam);
            progressBarCam31.Parent = gMapControl1;

            progressBarCam32.SetAltura(altura_barra_progress_cam);
            progressBarCam32.Parent = gMapControl1;

            progressBarCam33.SetAltura(altura_barra_progress_cam);
            progressBarCam33.Parent = gMapControl1;

            progressBarCam34.SetAltura(altura_barra_progress_cam);
            progressBarCam34.Parent = gMapControl1;

            progressBarCam35.SetAltura(altura_barra_progress_cam);
            progressBarCam35.Parent = gMapControl1;

            progressBarCam36.SetAltura(altura_barra_progress_cam);
            progressBarCam36.Parent = gMapControl1;











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

    public class RoundedPanel : Panel
    {
        public int CornerRadius1 { get; set; } = 10;
        public int CornerRadius2 { get; set; } = 10;
        public int CornerRadius3 { get; set; } = 10;
        public int CornerRadius4 { get; set; } = 10;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var path = new GraphicsPath();
            var rect = new RectangleF(0, 0, Width, Height);

            path.StartFigure();

            path.AddArc(new RectangleF(rect.X, rect.Y, CornerRadius1 * 2, CornerRadius1 * 2), 180, 90);
            path.AddLine(rect.X + CornerRadius1, rect.Y, rect.Right - CornerRadius1 * 2, rect.Y);

            path.AddArc(new RectangleF(rect.Right - CornerRadius2 * 2, rect.Y, CornerRadius2 * 2, CornerRadius2 * 2), 270, 90);
            path.AddLine(rect.Right, rect.Y + CornerRadius2 * 2, rect.Right, rect.Bottom - CornerRadius2 * 2);

            path.AddArc(new RectangleF(rect.Right - CornerRadius3 * 2, rect.Bottom - CornerRadius3 * 2, 3 * 2, CornerRadius3 * 2), 0, 90);
            path.AddLine(rect.Right - CornerRadius3 * 2, rect.Bottom, rect.X + CornerRadius3 * 2, rect.Bottom);

            path.AddArc(new RectangleF(rect.X, rect.Bottom - CornerRadius4 * 2, CornerRadius4 * 2, CornerRadius4 * 2), 90, 90);

            path.CloseFigure();

            Region = new Region(path);
        }
    }


}
