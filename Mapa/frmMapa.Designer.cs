namespace Mapa
{
    partial class frmMapa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapa));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.contextMenuStripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guardarCoordenadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCoordenadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCoordenadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ubicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marcadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifcarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verOcultarCoordenadasCamionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timerCamion = new System.Windows.Forms.Timer(this.components);
            this.btnRotarIzq = new System.Windows.Forms.Button();
            this.btnRotarDer = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageListColor = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lblHora = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton23 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton21 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton22 = new System.Windows.Forms.ToolStripButton();
            this.lblConectadoF = new System.Windows.Forms.ToolStripProgressBar();
            this.lblServer = new System.Windows.Forms.ToolStripLabel();
            this.lblMandante = new System.Windows.Forms.ToolStripLabel();
            this.lblProveedor = new System.Windows.Forms.ToolStripLabel();
            this.lblDistancia = new System.Windows.Forms.ToolStripLabel();
            this.lblZomm = new System.Windows.Forms.ToolStripLabel();
            this.lblGiro = new System.Windows.Forms.ToolStripLabel();
            this.lblLatencia = new System.Windows.Forms.ToolStripLabel();
            this.lblip = new System.Windows.Forms.ToolStripLabel();
            this.lblInstancia = new System.Windows.Forms.ToolStripLabel();
            this.lblOrigenDatos = new System.Windows.Forms.ToolStripLabel();
            this.lblCorral = new System.Windows.Forms.ToolStripLabel();
            this.lblCoordenadas = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel20 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel19 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel18 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel17 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel16 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel15 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel14 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel13 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel12 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.lblErrores = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.lblCtrl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPing = new System.Windows.Forms.ToolStripButton();
            this.lblPing = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.lblDistanciaMin = new System.Windows.Forms.ToolStripLabel();
            this.lblOrientacion = new System.Windows.Forms.ToolStripLabel();
            this.lblAngulo = new System.Windows.Forms.ToolStripLabel();
            this.lblTimer = new System.Windows.Forms.ToolStripLabel();
            this.lblMsg = new System.Windows.Forms.ToolStripLabel();
            this.webBClima = new System.Windows.Forms.WebBrowser();
            this.panelLeyenda = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox717 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox716 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox715 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox714 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox713 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox712 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox711 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox710 = new System.Windows.Forms.PictureBox();
            this.panelTrack = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnCerrarFecha = new System.Windows.Forms.Button();
            this.panelFecha = new System.Windows.Forms.Panel();
            this.btnActualizaFecha = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxLeyendas = new System.Windows.Forms.ListBox();
            this.panelLeyendas = new System.Windows.Forms.Panel();
            this.btnOcultarCuadro = new System.Windows.Forms.Button();
            this.dataGridVista = new System.Windows.Forms.DataGridView();
            this.labelLeyendas = new System.Windows.Forms.Label();
            this.timerPing = new System.Windows.Forms.Timer(this.components);
            this.panelCamiones = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.picGpsCam36 = new System.Windows.Forms.PictureBox();
            this.picRepCam36 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.picRepCam35 = new System.Windows.Forms.PictureBox();
            this.picGpsCam35 = new System.Windows.Forms.PictureBox();
            this.picGpsCam34 = new System.Windows.Forms.PictureBox();
            this.picGpsCam33 = new System.Windows.Forms.PictureBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.picRepCam34 = new System.Windows.Forms.PictureBox();
            this.picRepCam33 = new System.Windows.Forms.PictureBox();
            this.label54 = new System.Windows.Forms.Label();
            this.picGpsCam32 = new System.Windows.Forms.PictureBox();
            this.picRepCam32 = new System.Windows.Forms.PictureBox();
            this.label56 = new System.Windows.Forms.Label();
            this.picRepCam31 = new System.Windows.Forms.PictureBox();
            this.picGpsCam31 = new System.Windows.Forms.PictureBox();
            this.picGpsCam30 = new System.Windows.Forms.PictureBox();
            this.picGpsCam29 = new System.Windows.Forms.PictureBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.picRepCam30 = new System.Windows.Forms.PictureBox();
            this.picRepCam29 = new System.Windows.Forms.PictureBox();
            this.picCam36 = new System.Windows.Forms.PictureBox();
            this.picCam35 = new System.Windows.Forms.PictureBox();
            this.picCam34 = new System.Windows.Forms.PictureBox();
            this.picCam33 = new System.Windows.Forms.PictureBox();
            this.picCam32 = new System.Windows.Forms.PictureBox();
            this.picCam31 = new System.Windows.Forms.PictureBox();
            this.picCam30 = new System.Windows.Forms.PictureBox();
            this.picCam29 = new System.Windows.Forms.PictureBox();
            this.label46 = new System.Windows.Forms.Label();
            this.picGpsCam28 = new System.Windows.Forms.PictureBox();
            this.picRepCam28 = new System.Windows.Forms.PictureBox();
            this.label47 = new System.Windows.Forms.Label();
            this.picRepCam27 = new System.Windows.Forms.PictureBox();
            this.picGpsCam27 = new System.Windows.Forms.PictureBox();
            this.picGpsCam26 = new System.Windows.Forms.PictureBox();
            this.picGpsCam25 = new System.Windows.Forms.PictureBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.picRepCam26 = new System.Windows.Forms.PictureBox();
            this.picRepCam25 = new System.Windows.Forms.PictureBox();
            this.picCam28 = new System.Windows.Forms.PictureBox();
            this.picCam27 = new System.Windows.Forms.PictureBox();
            this.picCam26 = new System.Windows.Forms.PictureBox();
            this.picCam25 = new System.Windows.Forms.PictureBox();
            this.label43 = new System.Windows.Forms.Label();
            this.picGpsCam24 = new System.Windows.Forms.PictureBox();
            this.picRepCam24 = new System.Windows.Forms.PictureBox();
            this.picCam24 = new System.Windows.Forms.PictureBox();
            this.label41 = new System.Windows.Forms.Label();
            this.picRepCam23 = new System.Windows.Forms.PictureBox();
            this.picGpsCam23 = new System.Windows.Forms.PictureBox();
            this.picCam23 = new System.Windows.Forms.PictureBox();
            this.picCam22 = new System.Windows.Forms.PictureBox();
            this.picCam20 = new System.Windows.Forms.PictureBox();
            this.picCam21 = new System.Windows.Forms.PictureBox();
            this.picCam19 = new System.Windows.Forms.PictureBox();
            this.picCam17 = new System.Windows.Forms.PictureBox();
            this.picCam18 = new System.Windows.Forms.PictureBox();
            this.picCam16 = new System.Windows.Forms.PictureBox();
            this.picGpsCam22 = new System.Windows.Forms.PictureBox();
            this.picGpsCam21 = new System.Windows.Forms.PictureBox();
            this.picGpsCam20 = new System.Windows.Forms.PictureBox();
            this.picGpsCam19 = new System.Windows.Forms.PictureBox();
            this.picGpsCam18 = new System.Windows.Forms.PictureBox();
            this.picGpsCam17 = new System.Windows.Forms.PictureBox();
            this.picGpsCam16 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl16 = new System.Windows.Forms.Label();
            this.picRepCam22 = new System.Windows.Forms.PictureBox();
            this.picRepCam21 = new System.Windows.Forms.PictureBox();
            this.picRepCam20 = new System.Windows.Forms.PictureBox();
            this.picRepCam19 = new System.Windows.Forms.PictureBox();
            this.picRepCam18 = new System.Windows.Forms.PictureBox();
            this.picRepCam17 = new System.Windows.Forms.PictureBox();
            this.picRepCam16 = new System.Windows.Forms.PictureBox();
            this.lblCamPorc = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.picGpsCam15 = new System.Windows.Forms.PictureBox();
            this.picGpsCam14 = new System.Windows.Forms.PictureBox();
            this.picGpsCam13 = new System.Windows.Forms.PictureBox();
            this.picGpsCam12 = new System.Windows.Forms.PictureBox();
            this.picGpsCam11 = new System.Windows.Forms.PictureBox();
            this.picGpsCam10 = new System.Windows.Forms.PictureBox();
            this.picGpsCam09 = new System.Windows.Forms.PictureBox();
            this.picGpsCam08 = new System.Windows.Forms.PictureBox();
            this.picGpsCam07 = new System.Windows.Forms.PictureBox();
            this.picGpsCam06 = new System.Windows.Forms.PictureBox();
            this.picGpsCam05 = new System.Windows.Forms.PictureBox();
            this.lbl15 = new System.Windows.Forms.Label();
            this.lbl14 = new System.Windows.Forms.Label();
            this.lbl13 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl09 = new System.Windows.Forms.Label();
            this.lbl08 = new System.Windows.Forms.Label();
            this.lbl07 = new System.Windows.Forms.Label();
            this.lbl06 = new System.Windows.Forms.Label();
            this.lbl05 = new System.Windows.Forms.Label();
            this.picGpsCam04 = new System.Windows.Forms.PictureBox();
            this.picGpsCam03 = new System.Windows.Forms.PictureBox();
            this.picGpsCam02 = new System.Windows.Forms.PictureBox();
            this.lbl04 = new System.Windows.Forms.Label();
            this.lbl03 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.picGpsCam01 = new System.Windows.Forms.PictureBox();
            this.lbl01 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picRepCam15 = new System.Windows.Forms.PictureBox();
            this.picRepCam14 = new System.Windows.Forms.PictureBox();
            this.picRepCam13 = new System.Windows.Forms.PictureBox();
            this.picRepCam12 = new System.Windows.Forms.PictureBox();
            this.picRepCam11 = new System.Windows.Forms.PictureBox();
            this.picRepCam08 = new System.Windows.Forms.PictureBox();
            this.picRepCam10 = new System.Windows.Forms.PictureBox();
            this.picRepCam07 = new System.Windows.Forms.PictureBox();
            this.picRepCam09 = new System.Windows.Forms.PictureBox();
            this.picRepCam06 = new System.Windows.Forms.PictureBox();
            this.picRepCam05 = new System.Windows.Forms.PictureBox();
            this.picRepCam04 = new System.Windows.Forms.PictureBox();
            this.picRepCam03 = new System.Windows.Forms.PictureBox();
            this.picRepCam02 = new System.Windows.Forms.PictureBox();
            this.picCam14 = new System.Windows.Forms.PictureBox();
            this.picCam15 = new System.Windows.Forms.PictureBox();
            this.picRepCam01 = new System.Windows.Forms.PictureBox();
            this.picCam13 = new System.Windows.Forms.PictureBox();
            this.picCam11 = new System.Windows.Forms.PictureBox();
            this.picCam12 = new System.Windows.Forms.PictureBox();
            this.picCam10 = new System.Windows.Forms.PictureBox();
            this.picCam08 = new System.Windows.Forms.PictureBox();
            this.picCam09 = new System.Windows.Forms.PictureBox();
            this.picCam07 = new System.Windows.Forms.PictureBox();
            this.picCam04 = new System.Windows.Forms.PictureBox();
            this.picCam06 = new System.Windows.Forms.PictureBox();
            this.picCam02 = new System.Windows.Forms.PictureBox();
            this.picCam03 = new System.Windows.Forms.PictureBox();
            this.picCam05 = new System.Windows.Forms.PictureBox();
            this.picCam01 = new System.Windows.Forms.PictureBox();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.labelDetalles = new System.Windows.Forms.Label();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainerMapa = new System.Windows.Forms.SplitContainer();
            this.splitContainerMapas = new System.Windows.Forms.SplitContainer();
            this.gMapControl2 = new GMap.NET.WindowsForms.GMapControl();
            this.lblDetalleCabSinServir = new System.Windows.Forms.Label();
            this.lblDetalleStatusTaller = new System.Windows.Forms.Label();
            this.lblDetalleStatus = new System.Windows.Forms.Label();
            this.panelActCamiones = new System.Windows.Forms.Panel();
            this.panelIndicador01 = new System.Windows.Forms.Panel();
            this.panelCamion = new System.Windows.Forms.Panel();
            this.lblpB28 = new System.Windows.Forms.Label();
            this.lblpBs28 = new System.Windows.Forms.Label();
            this.picBs28 = new System.Windows.Forms.PictureBox();
            this.picRec28 = new System.Windows.Forms.PictureBox();
            this.lblpBb28 = new System.Windows.Forms.Label();
            this.lblpBv28 = new System.Windows.Forms.Label();
            this.picGps2Cam28 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam28 = new System.Windows.Forms.PictureBox();
            this.lblpB27 = new System.Windows.Forms.Label();
            this.lblpBs27 = new System.Windows.Forms.Label();
            this.picBs27 = new System.Windows.Forms.PictureBox();
            this.picRec27 = new System.Windows.Forms.PictureBox();
            this.lblpBb27 = new System.Windows.Forms.Label();
            this.lblpBv27 = new System.Windows.Forms.Label();
            this.picGps2Cam27 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam27 = new System.Windows.Forms.PictureBox();
            this.lblpB26 = new System.Windows.Forms.Label();
            this.lblpBs26 = new System.Windows.Forms.Label();
            this.picBs26 = new System.Windows.Forms.PictureBox();
            this.picRec26 = new System.Windows.Forms.PictureBox();
            this.lblpBb26 = new System.Windows.Forms.Label();
            this.lblpBv26 = new System.Windows.Forms.Label();
            this.picGps2Cam26 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam26 = new System.Windows.Forms.PictureBox();
            this.lblpB25 = new System.Windows.Forms.Label();
            this.lblpBs25 = new System.Windows.Forms.Label();
            this.picBs25 = new System.Windows.Forms.PictureBox();
            this.picRec25 = new System.Windows.Forms.PictureBox();
            this.lblpBb25 = new System.Windows.Forms.Label();
            this.lblpBv25 = new System.Windows.Forms.Label();
            this.picGps2Cam25 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam25 = new System.Windows.Forms.PictureBox();
            this.lblpB24 = new System.Windows.Forms.Label();
            this.lblpBs24 = new System.Windows.Forms.Label();
            this.picBs24 = new System.Windows.Forms.PictureBox();
            this.picRec24 = new System.Windows.Forms.PictureBox();
            this.lblpBb24 = new System.Windows.Forms.Label();
            this.lblpBv24 = new System.Windows.Forms.Label();
            this.picGps2Cam24 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam24 = new System.Windows.Forms.PictureBox();
            this.lblpB23 = new System.Windows.Forms.Label();
            this.lblpBs23 = new System.Windows.Forms.Label();
            this.picBs23 = new System.Windows.Forms.PictureBox();
            this.picRec23 = new System.Windows.Forms.PictureBox();
            this.lblpBb23 = new System.Windows.Forms.Label();
            this.lblpBv23 = new System.Windows.Forms.Label();
            this.picGps2Cam23 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam23 = new System.Windows.Forms.PictureBox();
            this.lblpBv17 = new System.Windows.Forms.Label();
            this.lblpBv16 = new System.Windows.Forms.Label();
            this.lblpBb17 = new System.Windows.Forms.Label();
            this.picGps2Cam17 = new System.Windows.Forms.PictureBox();
            this.lblpBs22 = new System.Windows.Forms.Label();
            this.picRep2Cam17 = new System.Windows.Forms.PictureBox();
            this.lblpB22 = new System.Windows.Forms.Label();
            this.lblpB17 = new System.Windows.Forms.Label();
            this.lblpBs17 = new System.Windows.Forms.Label();
            this.lblpB21 = new System.Windows.Forms.Label();
            this.lblpB20 = new System.Windows.Forms.Label();
            this.lblpB19 = new System.Windows.Forms.Label();
            this.lblpB18 = new System.Windows.Forms.Label();
            this.lblpBs21 = new System.Windows.Forms.Label();
            this.lblpBs20 = new System.Windows.Forms.Label();
            this.picRec17 = new System.Windows.Forms.PictureBox();
            this.lblpBs19 = new System.Windows.Forms.Label();
            this.picBs17 = new System.Windows.Forms.PictureBox();
            this.lblpBs18 = new System.Windows.Forms.Label();
            this.picBs22 = new System.Windows.Forms.PictureBox();
            this.picBs21 = new System.Windows.Forms.PictureBox();
            this.picBs20 = new System.Windows.Forms.PictureBox();
            this.picBs19 = new System.Windows.Forms.PictureBox();
            this.picBs18 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam22 = new System.Windows.Forms.PictureBox();
            this.picRec22 = new System.Windows.Forms.PictureBox();
            this.lblpBv22 = new System.Windows.Forms.Label();
            this.lblpBb22 = new System.Windows.Forms.Label();
            this.picRep2Cam22 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam21 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam21 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam20 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam20 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam19 = new System.Windows.Forms.PictureBox();
            this.picRec21 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam18 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam19 = new System.Windows.Forms.PictureBox();
            this.picRec20 = new System.Windows.Forms.PictureBox();
            this.picRec19 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam18 = new System.Windows.Forms.PictureBox();
            this.picRec18 = new System.Windows.Forms.PictureBox();
            this.lblpBv21 = new System.Windows.Forms.Label();
            this.lblpBv20 = new System.Windows.Forms.Label();
            this.lblpBv19 = new System.Windows.Forms.Label();
            this.lblpBv18 = new System.Windows.Forms.Label();
            this.lblpBb21 = new System.Windows.Forms.Label();
            this.lblpBb20 = new System.Windows.Forms.Label();
            this.lblpBb19 = new System.Windows.Forms.Label();
            this.lblpBb18 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblRutaError = new System.Windows.Forms.Label();
            this.listBoxRutaError = new System.Windows.Forms.ListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblpBs16 = new System.Windows.Forms.Label();
            this.lblpB16 = new System.Windows.Forms.Label();
            this.picGps2Cam16 = new System.Windows.Forms.PictureBox();
            this.picBs16 = new System.Windows.Forms.PictureBox();
            this.picRec16 = new System.Windows.Forms.PictureBox();
            this.lblpBb16 = new System.Windows.Forms.Label();
            this.picRep2Cam16 = new System.Windows.Forms.PictureBox();
            this.label28 = new System.Windows.Forms.Label();
            this.picGps2Cam15 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam15 = new System.Windows.Forms.PictureBox();
            this.label29 = new System.Windows.Forms.Label();
            this.picGps2Cam14 = new System.Windows.Forms.PictureBox();
            this.picRecLimpia = new System.Windows.Forms.PictureBox();
            this.picRep2Cam14 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam13 = new System.Windows.Forms.PictureBox();
            this.picRec15 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam12 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam13 = new System.Windows.Forms.PictureBox();
            this.picRec14 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam11 = new System.Windows.Forms.PictureBox();
            this.picRec13 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam12 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam10 = new System.Windows.Forms.PictureBox();
            this.picRec12 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam09 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam11 = new System.Windows.Forms.PictureBox();
            this.picRec11 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam08 = new System.Windows.Forms.PictureBox();
            this.picRec10 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam10 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam07 = new System.Windows.Forms.PictureBox();
            this.picRec09 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam06 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam09 = new System.Windows.Forms.PictureBox();
            this.picRec08 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam08 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam05 = new System.Windows.Forms.PictureBox();
            this.picRec07 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam04 = new System.Windows.Forms.PictureBox();
            this.picRec06 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam07 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam03 = new System.Windows.Forms.PictureBox();
            this.picRec05 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam02 = new System.Windows.Forms.PictureBox();
            this.picRec04 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam06 = new System.Windows.Forms.PictureBox();
            this.picGps2Cam01 = new System.Windows.Forms.PictureBox();
            this.picRec03 = new System.Windows.Forms.PictureBox();
            this.picRec02 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam05 = new System.Windows.Forms.PictureBox();
            this.picRec01 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam04 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam03 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam02 = new System.Windows.Forms.PictureBox();
            this.picRep2Cam01 = new System.Windows.Forms.PictureBox();
            this.lblpBv15 = new System.Windows.Forms.Label();
            this.lblpBv14 = new System.Windows.Forms.Label();
            this.lblpBv13 = new System.Windows.Forms.Label();
            this.lblpBv12 = new System.Windows.Forms.Label();
            this.lblpBv11 = new System.Windows.Forms.Label();
            this.lblpBv10 = new System.Windows.Forms.Label();
            this.lblpBv09 = new System.Windows.Forms.Label();
            this.lblpBv08 = new System.Windows.Forms.Label();
            this.lblpBv07 = new System.Windows.Forms.Label();
            this.lblpBv06 = new System.Windows.Forms.Label();
            this.lblpBv05 = new System.Windows.Forms.Label();
            this.lblpBv04 = new System.Windows.Forms.Label();
            this.lblpBv03 = new System.Windows.Forms.Label();
            this.lblpBv02 = new System.Windows.Forms.Label();
            this.lblpBv01 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblpBb15 = new System.Windows.Forms.Label();
            this.lblpBb14 = new System.Windows.Forms.Label();
            this.lblpBb13 = new System.Windows.Forms.Label();
            this.lblpBb12 = new System.Windows.Forms.Label();
            this.lblpBb11 = new System.Windows.Forms.Label();
            this.lblpBb10 = new System.Windows.Forms.Label();
            this.lblpBb09 = new System.Windows.Forms.Label();
            this.lblpBb08 = new System.Windows.Forms.Label();
            this.lblpBb07 = new System.Windows.Forms.Label();
            this.lblpBb06 = new System.Windows.Forms.Label();
            this.lblpBb05 = new System.Windows.Forms.Label();
            this.lblpBb04 = new System.Windows.Forms.Label();
            this.lblpBb03 = new System.Windows.Forms.Label();
            this.lblpBb02 = new System.Windows.Forms.Label();
            this.lblpBb01 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.picBs15 = new System.Windows.Forms.PictureBox();
            this.picBs14 = new System.Windows.Forms.PictureBox();
            this.picBs13 = new System.Windows.Forms.PictureBox();
            this.picBs12 = new System.Windows.Forms.PictureBox();
            this.picBs11 = new System.Windows.Forms.PictureBox();
            this.picBs10 = new System.Windows.Forms.PictureBox();
            this.picBs09 = new System.Windows.Forms.PictureBox();
            this.picBs08 = new System.Windows.Forms.PictureBox();
            this.picBs07 = new System.Windows.Forms.PictureBox();
            this.picBs06 = new System.Windows.Forms.PictureBox();
            this.picBs05 = new System.Windows.Forms.PictureBox();
            this.picBs04 = new System.Windows.Forms.PictureBox();
            this.picBs03 = new System.Windows.Forms.PictureBox();
            this.picBs02 = new System.Windows.Forms.PictureBox();
            this.picBs01 = new System.Windows.Forms.PictureBox();
            this.lblpBs15 = new System.Windows.Forms.Label();
            this.lblpBs14 = new System.Windows.Forms.Label();
            this.lblpBs13 = new System.Windows.Forms.Label();
            this.lblpBs12 = new System.Windows.Forms.Label();
            this.lblpBs11 = new System.Windows.Forms.Label();
            this.lblpBs10 = new System.Windows.Forms.Label();
            this.lblpBs09 = new System.Windows.Forms.Label();
            this.lblpBs08 = new System.Windows.Forms.Label();
            this.lblpBs07 = new System.Windows.Forms.Label();
            this.lblpBs06 = new System.Windows.Forms.Label();
            this.lblpBs05 = new System.Windows.Forms.Label();
            this.lblpBs04 = new System.Windows.Forms.Label();
            this.lblpBs03 = new System.Windows.Forms.Label();
            this.lblpBs02 = new System.Windows.Forms.Label();
            this.lblpBs01 = new System.Windows.Forms.Label();
            this.lblpB15 = new System.Windows.Forms.Label();
            this.lblpB14 = new System.Windows.Forms.Label();
            this.lblpB13 = new System.Windows.Forms.Label();
            this.lblpB12 = new System.Windows.Forms.Label();
            this.lblpB11 = new System.Windows.Forms.Label();
            this.lblpB10 = new System.Windows.Forms.Label();
            this.lblpB09 = new System.Windows.Forms.Label();
            this.lblpB08 = new System.Windows.Forms.Label();
            this.lblpB07 = new System.Windows.Forms.Label();
            this.lblpB06 = new System.Windows.Forms.Label();
            this.lblpB05 = new System.Windows.Forms.Label();
            this.lblpB04 = new System.Windows.Forms.Label();
            this.lblpB03 = new System.Windows.Forms.Label();
            this.lblpB02 = new System.Windows.Forms.Label();
            this.lblpB01 = new System.Windows.Forms.Label();
            this.lblpBc27 = new System.Windows.Forms.Label();
            this.lblpBc26 = new System.Windows.Forms.Label();
            this.lblpBc25 = new System.Windows.Forms.Label();
            this.lblpBc24 = new System.Windows.Forms.Label();
            this.lblpBc23 = new System.Windows.Forms.Label();
            this.lblpBc22 = new System.Windows.Forms.Label();
            this.lblpBc21 = new System.Windows.Forms.Label();
            this.lblpBc28 = new System.Windows.Forms.Label();
            this.picMov22 = new System.Windows.Forms.PictureBox();
            this.picMov21 = new System.Windows.Forms.PictureBox();
            this.pBar22 = new System.Windows.Forms.ProgressBar();
            this.pBar21 = new System.Windows.Forms.ProgressBar();
            this.lblpAct22 = new System.Windows.Forms.Label();
            this.lblpAct21 = new System.Windows.Forms.Label();
            this.lblpBr22 = new System.Windows.Forms.Label();
            this.lblCam22 = new System.Windows.Forms.Label();
            this.lblpBr21 = new System.Windows.Forms.Label();
            this.lblCam21 = new System.Windows.Forms.Label();
            this.lblpAct17 = new System.Windows.Forms.Label();
            this.lblpAct20 = new System.Windows.Forms.Label();
            this.lblpAct16 = new System.Windows.Forms.Label();
            this.lblpAct15 = new System.Windows.Forms.Label();
            this.lblpAct14 = new System.Windows.Forms.Label();
            this.lblpAct13 = new System.Windows.Forms.Label();
            this.lblpAct12 = new System.Windows.Forms.Label();
            this.lblpAct11 = new System.Windows.Forms.Label();
            this.lblpAct10 = new System.Windows.Forms.Label();
            this.lblpAct09 = new System.Windows.Forms.Label();
            this.lblpAct08 = new System.Windows.Forms.Label();
            this.lblpAct07 = new System.Windows.Forms.Label();
            this.lblpAct06 = new System.Windows.Forms.Label();
            this.lblpAct05 = new System.Windows.Forms.Label();
            this.lblpAct04 = new System.Windows.Forms.Label();
            this.lblpAct03 = new System.Windows.Forms.Label();
            this.lblpAct02 = new System.Windows.Forms.Label();
            this.lblpAct01 = new System.Windows.Forms.Label();
            this.lblpAct19 = new System.Windows.Forms.Label();
            this.lblpAct18 = new System.Windows.Forms.Label();
            this.pBar17 = new System.Windows.Forms.ProgressBar();
            this.pBar20 = new System.Windows.Forms.ProgressBar();
            this.pBar19 = new System.Windows.Forms.ProgressBar();
            this.pBar18 = new System.Windows.Forms.ProgressBar();
            this.pBar16 = new System.Windows.Forms.ProgressBar();
            this.pBar15 = new System.Windows.Forms.ProgressBar();
            this.pBar14 = new System.Windows.Forms.ProgressBar();
            this.pBar13 = new System.Windows.Forms.ProgressBar();
            this.pBar12 = new System.Windows.Forms.ProgressBar();
            this.pBar11 = new System.Windows.Forms.ProgressBar();
            this.pBar10 = new System.Windows.Forms.ProgressBar();
            this.pBar09 = new System.Windows.Forms.ProgressBar();
            this.pBar08 = new System.Windows.Forms.ProgressBar();
            this.pBar07 = new System.Windows.Forms.ProgressBar();
            this.pBar06 = new System.Windows.Forms.ProgressBar();
            this.pBar05 = new System.Windows.Forms.ProgressBar();
            this.pBar04 = new System.Windows.Forms.ProgressBar();
            this.pBar03 = new System.Windows.Forms.ProgressBar();
            this.pBar02 = new System.Windows.Forms.ProgressBar();
            this.pBar01 = new System.Windows.Forms.ProgressBar();
            this.picMov20 = new System.Windows.Forms.PictureBox();
            this.picMov19 = new System.Windows.Forms.PictureBox();
            this.picMov18 = new System.Windows.Forms.PictureBox();
            this.picMov15 = new System.Windows.Forms.PictureBox();
            this.picMov14 = new System.Windows.Forms.PictureBox();
            this.picMov13 = new System.Windows.Forms.PictureBox();
            this.picMov12 = new System.Windows.Forms.PictureBox();
            this.picMov11 = new System.Windows.Forms.PictureBox();
            this.picMov10 = new System.Windows.Forms.PictureBox();
            this.picMov09 = new System.Windows.Forms.PictureBox();
            this.picMov08 = new System.Windows.Forms.PictureBox();
            this.picMov07 = new System.Windows.Forms.PictureBox();
            this.picMov06 = new System.Windows.Forms.PictureBox();
            this.picMov05 = new System.Windows.Forms.PictureBox();
            this.picMov04 = new System.Windows.Forms.PictureBox();
            this.picMov03 = new System.Windows.Forms.PictureBox();
            this.picMov02 = new System.Windows.Forms.PictureBox();
            this.picMov01 = new System.Windows.Forms.PictureBox();
            this.lblpBr20 = new System.Windows.Forms.Label();
            this.lblpBr19 = new System.Windows.Forms.Label();
            this.lblpBr18 = new System.Windows.Forms.Label();
            this.lblpBc20 = new System.Windows.Forms.Label();
            this.lblpBc19 = new System.Windows.Forms.Label();
            this.lblpBc18 = new System.Windows.Forms.Label();
            this.lblCam20 = new System.Windows.Forms.Label();
            this.lblCam19 = new System.Windows.Forms.Label();
            this.lblCam18 = new System.Windows.Forms.Label();
            this.lblpBr15 = new System.Windows.Forms.Label();
            this.lblpBr14 = new System.Windows.Forms.Label();
            this.lblpBr13 = new System.Windows.Forms.Label();
            this.lblpBr12 = new System.Windows.Forms.Label();
            this.lblpBr11 = new System.Windows.Forms.Label();
            this.lblpBr10 = new System.Windows.Forms.Label();
            this.lblpBr09 = new System.Windows.Forms.Label();
            this.lblpBr08 = new System.Windows.Forms.Label();
            this.lblpBr07 = new System.Windows.Forms.Label();
            this.lblpBr06 = new System.Windows.Forms.Label();
            this.lblpBr05 = new System.Windows.Forms.Label();
            this.lblpBr04 = new System.Windows.Forms.Label();
            this.lblpBr03 = new System.Windows.Forms.Label();
            this.lblpBr02 = new System.Windows.Forms.Label();
            this.lblpBr01 = new System.Windows.Forms.Label();
            this.lblpBc15 = new System.Windows.Forms.Label();
            this.lblpBc14 = new System.Windows.Forms.Label();
            this.lblpBc13 = new System.Windows.Forms.Label();
            this.lblpBc12 = new System.Windows.Forms.Label();
            this.lblpBc11 = new System.Windows.Forms.Label();
            this.lblpBc10 = new System.Windows.Forms.Label();
            this.lblpBc09 = new System.Windows.Forms.Label();
            this.lblpBc08 = new System.Windows.Forms.Label();
            this.lblpBc07 = new System.Windows.Forms.Label();
            this.lblpBc06 = new System.Windows.Forms.Label();
            this.lblpBc05 = new System.Windows.Forms.Label();
            this.lblpBc04 = new System.Windows.Forms.Label();
            this.lblpBc03 = new System.Windows.Forms.Label();
            this.lblpBc02 = new System.Windows.Forms.Label();
            this.lblpBc01 = new System.Windows.Forms.Label();
            this.lblCam15 = new System.Windows.Forms.Label();
            this.lblCam14 = new System.Windows.Forms.Label();
            this.lblCam13 = new System.Windows.Forms.Label();
            this.lblCam12 = new System.Windows.Forms.Label();
            this.lblCam11 = new System.Windows.Forms.Label();
            this.lblCam10 = new System.Windows.Forms.Label();
            this.lblCam09 = new System.Windows.Forms.Label();
            this.lblCam08 = new System.Windows.Forms.Label();
            this.lblCam07 = new System.Windows.Forms.Label();
            this.lblCam06 = new System.Windows.Forms.Label();
            this.lblCam05 = new System.Windows.Forms.Label();
            this.lblCam04 = new System.Windows.Forms.Label();
            this.lblCam03 = new System.Windows.Forms.Label();
            this.lblCam02 = new System.Windows.Forms.Label();
            this.lblCam01 = new System.Windows.Forms.Label();
            this.lblpBr17 = new System.Windows.Forms.Label();
            this.lblpBc17 = new System.Windows.Forms.Label();
            this.lblCam17 = new System.Windows.Forms.Label();
            this.lblpBr16 = new System.Windows.Forms.Label();
            this.lblpBc16 = new System.Windows.Forms.Label();
            this.lblCam16 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label25 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarPanel = new System.Windows.Forms.Button();
            this.btnAbrirCerrarPanel = new System.Windows.Forms.Button();
            this.lblClasicConn = new System.Windows.Forms.Label();
            this.lblEcoConn = new System.Windows.Forms.Label();
            this.panelCam17 = new System.Windows.Forms.Panel();
            this.picPila17 = new System.Windows.Forms.PictureBox();
            this.lblTablet17 = new System.Windows.Forms.Label();
            this.picWifi17 = new System.Windows.Forms.PictureBox();
            this.picCamion17 = new System.Windows.Forms.PictureBox();
            this.picMov17 = new System.Windows.Forms.PictureBox();
            this.panelCam16 = new System.Windows.Forms.Panel();
            this.picPila16 = new System.Windows.Forms.PictureBox();
            this.lblTablet16 = new System.Windows.Forms.Label();
            this.picWifi16 = new System.Windows.Forms.PictureBox();
            this.picCamion16 = new System.Windows.Forms.PictureBox();
            this.picMov16 = new System.Windows.Forms.PictureBox();
            this.panelCam15 = new System.Windows.Forms.Panel();
            this.picPila15 = new System.Windows.Forms.PictureBox();
            this.lblTablet15 = new System.Windows.Forms.Label();
            this.picWifi15 = new System.Windows.Forms.PictureBox();
            this.picCamion15 = new System.Windows.Forms.PictureBox();
            this.panelCam14 = new System.Windows.Forms.Panel();
            this.picCamion14 = new System.Windows.Forms.PictureBox();
            this.picPila14 = new System.Windows.Forms.PictureBox();
            this.lblTablet14 = new System.Windows.Forms.Label();
            this.picWifi14 = new System.Windows.Forms.PictureBox();
            this.panelCamion2 = new System.Windows.Forms.Panel();
            this.lblEtiquetaConCabSinServir = new System.Windows.Forms.Label();
            this.lblEtiquetaTaller = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEtiquetaRutas = new System.Windows.Forms.Label();
            this.panelDescripciones = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalCamActDesConect = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.lblTotalCamActConect = new System.Windows.Forms.Label();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.lblTotalCamAct = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.lblHoraMapa = new System.Windows.Forms.Label();
            this.panelCam36 = new System.Windows.Forms.Panel();
            this.lblpBc36 = new System.Windows.Forms.Label();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.lblTablet36 = new System.Windows.Forms.Label();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.picCamion36 = new System.Windows.Forms.PictureBox();
            this.lblCam36 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.lblpBr36 = new System.Windows.Forms.Label();
            this.pBar36 = new System.Windows.Forms.ProgressBar();
            this.panelCam32 = new System.Windows.Forms.Panel();
            this.lblpBc32 = new System.Windows.Forms.Label();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.lblTablet32 = new System.Windows.Forms.Label();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.picCamion32 = new System.Windows.Forms.PictureBox();
            this.lblCam32 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.lblpBr32 = new System.Windows.Forms.Label();
            this.pBar32 = new System.Windows.Forms.ProgressBar();
            this.panelCam35 = new System.Windows.Forms.Panel();
            this.lblpBc35 = new System.Windows.Forms.Label();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.lblTablet35 = new System.Windows.Forms.Label();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.picCamion35 = new System.Windows.Forms.PictureBox();
            this.lblCam35 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.lblpBr35 = new System.Windows.Forms.Label();
            this.pBar35 = new System.Windows.Forms.ProgressBar();
            this.panelCam31 = new System.Windows.Forms.Panel();
            this.lblpBc31 = new System.Windows.Forms.Label();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.lblTablet31 = new System.Windows.Forms.Label();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.picCamion31 = new System.Windows.Forms.PictureBox();
            this.lblCam31 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.lblpBr31 = new System.Windows.Forms.Label();
            this.pBar31 = new System.Windows.Forms.ProgressBar();
            this.panelCam34 = new System.Windows.Forms.Panel();
            this.lblpBc34 = new System.Windows.Forms.Label();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.lblTablet34 = new System.Windows.Forms.Label();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.picCamion34 = new System.Windows.Forms.PictureBox();
            this.lblCam34 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.lblpBr34 = new System.Windows.Forms.Label();
            this.pBar34 = new System.Windows.Forms.ProgressBar();
            this.panelCam30 = new System.Windows.Forms.Panel();
            this.lblpBc30 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblTablet30 = new System.Windows.Forms.Label();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.picCamion30 = new System.Windows.Forms.PictureBox();
            this.lblCam30 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.lblpBr30 = new System.Windows.Forms.Label();
            this.pBar30 = new System.Windows.Forms.ProgressBar();
            this.panelCam33 = new System.Windows.Forms.Panel();
            this.lblpBc33 = new System.Windows.Forms.Label();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.lblTablet33 = new System.Windows.Forms.Label();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.picCamion33 = new System.Windows.Forms.PictureBox();
            this.lblCam33 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.lblpBr33 = new System.Windows.Forms.Label();
            this.pBar33 = new System.Windows.Forms.ProgressBar();
            this.panelCam28 = new System.Windows.Forms.Panel();
            this.picPila28 = new System.Windows.Forms.PictureBox();
            this.lblTablet28 = new System.Windows.Forms.Label();
            this.picWifi28 = new System.Windows.Forms.PictureBox();
            this.picMov28 = new System.Windows.Forms.PictureBox();
            this.picCamion28 = new System.Windows.Forms.PictureBox();
            this.lblCam28 = new System.Windows.Forms.Label();
            this.lblpAct28 = new System.Windows.Forms.Label();
            this.lblpBr28 = new System.Windows.Forms.Label();
            this.pBar28 = new System.Windows.Forms.ProgressBar();
            this.panelCam29 = new System.Windows.Forms.Panel();
            this.lblpBc29 = new System.Windows.Forms.Label();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.lblTablet29 = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.picCamion29 = new System.Windows.Forms.PictureBox();
            this.lblCam29 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.lblpBr29 = new System.Windows.Forms.Label();
            this.pBar29 = new System.Windows.Forms.ProgressBar();
            this.panelCam24 = new System.Windows.Forms.Panel();
            this.picPila24 = new System.Windows.Forms.PictureBox();
            this.lblTablet24 = new System.Windows.Forms.Label();
            this.picWifi24 = new System.Windows.Forms.PictureBox();
            this.picMov24 = new System.Windows.Forms.PictureBox();
            this.picCamion24 = new System.Windows.Forms.PictureBox();
            this.lblCam24 = new System.Windows.Forms.Label();
            this.lblpAct24 = new System.Windows.Forms.Label();
            this.lblpBr24 = new System.Windows.Forms.Label();
            this.pBar24 = new System.Windows.Forms.ProgressBar();
            this.panelCam27 = new System.Windows.Forms.Panel();
            this.picPila27 = new System.Windows.Forms.PictureBox();
            this.lblTablet27 = new System.Windows.Forms.Label();
            this.picWifi27 = new System.Windows.Forms.PictureBox();
            this.picMov27 = new System.Windows.Forms.PictureBox();
            this.picCamion27 = new System.Windows.Forms.PictureBox();
            this.lblCam27 = new System.Windows.Forms.Label();
            this.lblpAct27 = new System.Windows.Forms.Label();
            this.lblpBr27 = new System.Windows.Forms.Label();
            this.pBar27 = new System.Windows.Forms.ProgressBar();
            this.panelCam23 = new System.Windows.Forms.Panel();
            this.picPila23 = new System.Windows.Forms.PictureBox();
            this.lblTablet23 = new System.Windows.Forms.Label();
            this.picWifi23 = new System.Windows.Forms.PictureBox();
            this.picMov23 = new System.Windows.Forms.PictureBox();
            this.picCamion23 = new System.Windows.Forms.PictureBox();
            this.lblCam23 = new System.Windows.Forms.Label();
            this.lblpAct23 = new System.Windows.Forms.Label();
            this.lblpBr23 = new System.Windows.Forms.Label();
            this.pBar23 = new System.Windows.Forms.ProgressBar();
            this.panelCam26 = new System.Windows.Forms.Panel();
            this.picPila26 = new System.Windows.Forms.PictureBox();
            this.lblTablet26 = new System.Windows.Forms.Label();
            this.picWifi26 = new System.Windows.Forms.PictureBox();
            this.picMov26 = new System.Windows.Forms.PictureBox();
            this.picCamion26 = new System.Windows.Forms.PictureBox();
            this.lblCam26 = new System.Windows.Forms.Label();
            this.lblpAct26 = new System.Windows.Forms.Label();
            this.lblpBr26 = new System.Windows.Forms.Label();
            this.pBar26 = new System.Windows.Forms.ProgressBar();
            this.panelCam21 = new System.Windows.Forms.Panel();
            this.picPila21 = new System.Windows.Forms.PictureBox();
            this.lblTablet21 = new System.Windows.Forms.Label();
            this.picWifi21 = new System.Windows.Forms.PictureBox();
            this.picCamion21 = new System.Windows.Forms.PictureBox();
            this.panelCam25 = new System.Windows.Forms.Panel();
            this.picPila25 = new System.Windows.Forms.PictureBox();
            this.lblTablet25 = new System.Windows.Forms.Label();
            this.picWifi25 = new System.Windows.Forms.PictureBox();
            this.picMov25 = new System.Windows.Forms.PictureBox();
            this.picCamion25 = new System.Windows.Forms.PictureBox();
            this.lblCam25 = new System.Windows.Forms.Label();
            this.lblpAct25 = new System.Windows.Forms.Label();
            this.lblpBr25 = new System.Windows.Forms.Label();
            this.pBar25 = new System.Windows.Forms.ProgressBar();
            this.panelCam22 = new System.Windows.Forms.Panel();
            this.picPila22 = new System.Windows.Forms.PictureBox();
            this.lblTablet22 = new System.Windows.Forms.Label();
            this.picWifi22 = new System.Windows.Forms.PictureBox();
            this.picCamion22 = new System.Windows.Forms.PictureBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.panelCam18 = new System.Windows.Forms.Panel();
            this.picPila18 = new System.Windows.Forms.PictureBox();
            this.lblTablet18 = new System.Windows.Forms.Label();
            this.picWifi18 = new System.Windows.Forms.PictureBox();
            this.picCamion18 = new System.Windows.Forms.PictureBox();
            this.panelCam04 = new System.Windows.Forms.Panel();
            this.picPila04 = new System.Windows.Forms.PictureBox();
            this.lblTablet04 = new System.Windows.Forms.Label();
            this.picWifi04 = new System.Windows.Forms.PictureBox();
            this.picCamion04 = new System.Windows.Forms.PictureBox();
            this.panelCam19 = new System.Windows.Forms.Panel();
            this.picPila19 = new System.Windows.Forms.PictureBox();
            this.lblTablet19 = new System.Windows.Forms.Label();
            this.picWifi19 = new System.Windows.Forms.PictureBox();
            this.picCamion19 = new System.Windows.Forms.PictureBox();
            this.panelCam20 = new System.Windows.Forms.Panel();
            this.picPila20 = new System.Windows.Forms.PictureBox();
            this.lblTablet20 = new System.Windows.Forms.Label();
            this.picWifi20 = new System.Windows.Forms.PictureBox();
            this.picCamion20 = new System.Windows.Forms.PictureBox();
            this.panelCam08 = new System.Windows.Forms.Panel();
            this.picPila08 = new System.Windows.Forms.PictureBox();
            this.lblTablet08 = new System.Windows.Forms.Label();
            this.picWifi08 = new System.Windows.Forms.PictureBox();
            this.picCamion08 = new System.Windows.Forms.PictureBox();
            this.panelCam01 = new System.Windows.Forms.Panel();
            this.picCamion01 = new System.Windows.Forms.PictureBox();
            this.lblTablet01 = new System.Windows.Forms.Label();
            this.picPila01 = new System.Windows.Forms.PictureBox();
            this.picWifi01 = new System.Windows.Forms.PictureBox();
            this.panelCam02 = new System.Windows.Forms.Panel();
            this.picCamion02 = new System.Windows.Forms.PictureBox();
            this.lblTablet02 = new System.Windows.Forms.Label();
            this.picPila02 = new System.Windows.Forms.PictureBox();
            this.picWifi02 = new System.Windows.Forms.PictureBox();
            this.panelCam12 = new System.Windows.Forms.Panel();
            this.lblTablet12 = new System.Windows.Forms.Label();
            this.picPila12 = new System.Windows.Forms.PictureBox();
            this.picWifi12 = new System.Windows.Forms.PictureBox();
            this.picCamion12 = new System.Windows.Forms.PictureBox();
            this.panelCam03 = new System.Windows.Forms.Panel();
            this.picPila03 = new System.Windows.Forms.PictureBox();
            this.lblTablet03 = new System.Windows.Forms.Label();
            this.picWifi03 = new System.Windows.Forms.PictureBox();
            this.picCamion03 = new System.Windows.Forms.PictureBox();
            this.panelCam05 = new System.Windows.Forms.Panel();
            this.picPila05 = new System.Windows.Forms.PictureBox();
            this.lblTablet05 = new System.Windows.Forms.Label();
            this.picWifi05 = new System.Windows.Forms.PictureBox();
            this.picCamion05 = new System.Windows.Forms.PictureBox();
            this.panelCam09 = new System.Windows.Forms.Panel();
            this.picPila09 = new System.Windows.Forms.PictureBox();
            this.lblTablet09 = new System.Windows.Forms.Label();
            this.picWifi09 = new System.Windows.Forms.PictureBox();
            this.picCamion09 = new System.Windows.Forms.PictureBox();
            this.panelCam06 = new System.Windows.Forms.Panel();
            this.picPila06 = new System.Windows.Forms.PictureBox();
            this.lblTablet06 = new System.Windows.Forms.Label();
            this.picWifi06 = new System.Windows.Forms.PictureBox();
            this.picCamion06 = new System.Windows.Forms.PictureBox();
            this.panelCam07 = new System.Windows.Forms.Panel();
            this.picPila07 = new System.Windows.Forms.PictureBox();
            this.lblTablet07 = new System.Windows.Forms.Label();
            this.picWifi07 = new System.Windows.Forms.PictureBox();
            this.picCamion07 = new System.Windows.Forms.PictureBox();
            this.panelCam13 = new System.Windows.Forms.Panel();
            this.picCamion13 = new System.Windows.Forms.PictureBox();
            this.picPila13 = new System.Windows.Forms.PictureBox();
            this.lblTablet13 = new System.Windows.Forms.Label();
            this.picWifi13 = new System.Windows.Forms.PictureBox();
            this.panelCam10 = new System.Windows.Forms.Panel();
            this.picPila10 = new System.Windows.Forms.PictureBox();
            this.lblTablet10 = new System.Windows.Forms.Label();
            this.picWifi10 = new System.Windows.Forms.PictureBox();
            this.picCamion10 = new System.Windows.Forms.PictureBox();
            this.panelCam11 = new System.Windows.Forms.Panel();
            this.picPila11 = new System.Windows.Forms.PictureBox();
            this.lblTablet11 = new System.Windows.Forms.Label();
            this.picWifi11 = new System.Windows.Forms.PictureBox();
            this.picCamion11 = new System.Windows.Forms.PictureBox();
            this.panelReloj = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.imageListCamiones = new System.Windows.Forms.ImageList(this.components);
            this.imageListSignal = new System.Windows.Forms.ImageList(this.components);
            this.imageListMov = new System.Windows.Forms.ImageList(this.components);
            this.imageListEstado = new System.Windows.Forms.ImageList(this.components);
            this.imageListWifi = new System.Windows.Forms.ImageList(this.components);
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.satelitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relieveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.todoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecologicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empacadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.servidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planeadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cabezasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dimensionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbFiltroVista = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cmbColorCapas = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.hoyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFecha = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscarUbicacion = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbCamiones = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.lblcmbCamionRuta = new System.Windows.Forms.ToolStripLabel();
            this.cmbCamionRuta = new System.Windows.Forms.ToolStripComboBox();
            this.btnBuscarcamionruta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmbServidas = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.cmbCamion = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.cmbRaciones = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.imageListPila = new System.Windows.Forms.ImageList(this.components);
            this.panelDescrip = new System.Windows.Forms.Panel();
            this.label51 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label49 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.imageListTruck = new System.Windows.Forms.ImageList(this.components);
            this.timerClockMin = new System.Windows.Forms.Timer(this.components);
            this.timerRepartos = new System.Windows.Forms.Timer(this.components);
            this.panelIndicador02 = new System.Windows.Forms.Panel();
            this.picIndicador01 = new System.Windows.Forms.PictureBox();
            this.lblEcologicosCorrrales = new System.Windows.Forms.Label();
            this.lblClasicosCorrrales = new System.Windows.Forms.Label();
            this.contextMenuStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.panelLeyenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox717)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox716)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox715)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox714)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox713)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox712)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox711)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox710)).BeginInit();
            this.panelTrack.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panelFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelLeyendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVista)).BeginInit();
            this.panelCamiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam01)).BeginInit();
            this.panelDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMapa)).BeginInit();
            this.splitContainerMapa.Panel1.SuspendLayout();
            this.splitContainerMapa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMapas)).BeginInit();
            this.splitContainerMapas.Panel1.SuspendLayout();
            this.splitContainerMapas.Panel2.SuspendLayout();
            this.splitContainerMapas.SuspendLayout();
            this.panelCamion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBs28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecLimpia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCam17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov17)).BeginInit();
            this.panelCam16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov16)).BeginInit();
            this.panelCam15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion15)).BeginInit();
            this.panelCam14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPila14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi14)).BeginInit();
            this.panelCamion2.SuspendLayout();
            this.panelDescripciones.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.panelCam36.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion36)).BeginInit();
            this.panelCam32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion32)).BeginInit();
            this.panelCam35.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion35)).BeginInit();
            this.panelCam31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion31)).BeginInit();
            this.panelCam34.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion34)).BeginInit();
            this.panelCam30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion30)).BeginInit();
            this.panelCam33.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion33)).BeginInit();
            this.panelCam28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion28)).BeginInit();
            this.panelCam29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion29)).BeginInit();
            this.panelCam24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion24)).BeginInit();
            this.panelCam27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion27)).BeginInit();
            this.panelCam23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion23)).BeginInit();
            this.panelCam26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion26)).BeginInit();
            this.panelCam21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion21)).BeginInit();
            this.panelCam25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion25)).BeginInit();
            this.panelCam22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion22)).BeginInit();
            this.panelCam18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion18)).BeginInit();
            this.panelCam04.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion04)).BeginInit();
            this.panelCam19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion19)).BeginInit();
            this.panelCam20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion20)).BeginInit();
            this.panelCam08.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion08)).BeginInit();
            this.panelCam01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPila01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi01)).BeginInit();
            this.panelCam02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPila02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi02)).BeginInit();
            this.panelCam12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion12)).BeginInit();
            this.panelCam03.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion03)).BeginInit();
            this.panelCam05.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion05)).BeginInit();
            this.panelCam09.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion09)).BeginInit();
            this.panelCam06.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion06)).BeginInit();
            this.panelCam07.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion07)).BeginInit();
            this.panelCam13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPila13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi13)).BeginInit();
            this.panelCam10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion10)).BeginInit();
            this.panelCam11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panelDescrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIndicador01)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.BackColor = System.Drawing.Color.Transparent;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.ContextMenuStrip = this.contextMenuStripMenu;
            this.gMapControl1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(234, 133);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            this.gMapControl1.OnPolygonClick += new GMap.NET.WindowsForms.PolygonClick(this.gMapControl1_OnPolygonClick);
            this.gMapControl1.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.cambioZoomMapa);
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.Click += new System.EventHandler(this.gMapControl1_Click);
            this.gMapControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gMapControl1_KeyDown);
            this.gMapControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gMapControl1_KeyPress);
            this.gMapControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gMapControl1_KeyUp);
            this.gMapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDown);
            this.gMapControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseMove);
            // 
            // contextMenuStripMenu
            // 
            this.contextMenuStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarCoordenadaToolStripMenuItem,
            this.verCoordenadasToolStripMenuItem,
            this.toolStripMenuItemCopiar,
            this.buscarCoordenadaToolStripMenuItem,
            this.toolStripSeparator7,
            this.ubicacionToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.zoomToolStripMenuItem1,
            this.marcadoresToolStripMenuItem,
            this.modifcarToolStripMenuItem,
            this.ajustarToolStripMenuItem,
            this.alinearToolStripMenuItem,
            this.verOcultarCoordenadasCamionToolStripMenuItem});
            this.contextMenuStripMenu.Name = "contextMenuStripMenu";
            this.contextMenuStripMenu.Size = new System.Drawing.Size(297, 274);
            // 
            // guardarCoordenadaToolStripMenuItem
            // 
            this.guardarCoordenadaToolStripMenuItem.Name = "guardarCoordenadaToolStripMenuItem";
            this.guardarCoordenadaToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.guardarCoordenadaToolStripMenuItem.Text = "Guardar Coordenada Corral";
            this.guardarCoordenadaToolStripMenuItem.Visible = false;
            this.guardarCoordenadaToolStripMenuItem.Click += new System.EventHandler(this.guardarCoordenadaToolStripMenuItem_Click);
            // 
            // verCoordenadasToolStripMenuItem
            // 
            this.verCoordenadasToolStripMenuItem.Name = "verCoordenadasToolStripMenuItem";
            this.verCoordenadasToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.verCoordenadasToolStripMenuItem.Text = "Ver/Ocultar Coordenadas Corral";
            this.verCoordenadasToolStripMenuItem.Visible = false;
            this.verCoordenadasToolStripMenuItem.Click += new System.EventHandler(this.verCoordenadasToolStripMenuItem_Click);
            // 
            // toolStripMenuItemCopiar
            // 
            this.toolStripMenuItemCopiar.Name = "toolStripMenuItemCopiar";
            this.toolStripMenuItemCopiar.Size = new System.Drawing.Size(296, 22);
            this.toolStripMenuItemCopiar.Text = "Copiar Coordenada";
            this.toolStripMenuItemCopiar.Click += new System.EventHandler(this.toolStripMenuItemCopiar_Click);
            // 
            // buscarCoordenadaToolStripMenuItem
            // 
            this.buscarCoordenadaToolStripMenuItem.Name = "buscarCoordenadaToolStripMenuItem";
            this.buscarCoordenadaToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.buscarCoordenadaToolStripMenuItem.Text = "Buscar Coordenada";
            this.buscarCoordenadaToolStripMenuItem.Click += new System.EventHandler(this.buscarCoordenadaToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(293, 6);
            this.toolStripSeparator7.Visible = false;
            // 
            // ubicacionToolStripMenuItem
            // 
            this.ubicacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moverToolStripMenuItem});
            this.ubicacionToolStripMenuItem.Name = "ubicacionToolStripMenuItem";
            this.ubicacionToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.ubicacionToolStripMenuItem.Text = "Ubicacion";
            this.ubicacionToolStripMenuItem.Visible = false;
            // 
            // moverToolStripMenuItem
            // 
            this.moverToolStripMenuItem.Name = "moverToolStripMenuItem";
            this.moverToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.moverToolStripMenuItem.Text = "Mover";
            this.moverToolStripMenuItem.Click += new System.EventHandler(this.moverToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.zoomToolStripMenuItem.Text = "Zoom +";
            this.zoomToolStripMenuItem.Visible = false;
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem1
            // 
            this.zoomToolStripMenuItem1.Name = "zoomToolStripMenuItem1";
            this.zoomToolStripMenuItem1.Size = new System.Drawing.Size(296, 22);
            this.zoomToolStripMenuItem1.Text = "Zoom -";
            this.zoomToolStripMenuItem1.Visible = false;
            this.zoomToolStripMenuItem1.Click += new System.EventHandler(this.zoomToolStripMenuItem1_Click);
            // 
            // marcadoresToolStripMenuItem
            // 
            this.marcadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.marcadoresToolStripMenuItem.Name = "marcadoresToolStripMenuItem";
            this.marcadoresToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.marcadoresToolStripMenuItem.Text = "Marcar";
            this.marcadoresToolStripMenuItem.Visible = false;
            this.marcadoresToolStripMenuItem.Click += new System.EventHandler(this.marcadoresToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "1";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem5.Text = "2";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem6.Text = "3";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem7.Text = "4";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // modifcarToolStripMenuItem
            // 
            this.modifcarToolStripMenuItem.Name = "modifcarToolStripMenuItem";
            this.modifcarToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.modifcarToolStripMenuItem.Text = "Ver esquinas, Modificar  ";
            this.modifcarToolStripMenuItem.Visible = false;
            this.modifcarToolStripMenuItem.Click += new System.EventHandler(this.modifcarToolStripMenuItem_Click);
            // 
            // ajustarToolStripMenuItem
            // 
            this.ajustarToolStripMenuItem.Name = "ajustarToolStripMenuItem";
            this.ajustarToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.ajustarToolStripMenuItem.Text = "Ajustar";
            this.ajustarToolStripMenuItem.Visible = false;
            this.ajustarToolStripMenuItem.Click += new System.EventHandler(this.ajustarToolStripMenuItem_Click);
            // 
            // alinearToolStripMenuItem
            // 
            this.alinearToolStripMenuItem.Name = "alinearToolStripMenuItem";
            this.alinearToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.alinearToolStripMenuItem.Text = "Alinear";
            this.alinearToolStripMenuItem.Visible = false;
            this.alinearToolStripMenuItem.Click += new System.EventHandler(this.alinearToolStripMenuItem_Click);
            // 
            // verOcultarCoordenadasCamionToolStripMenuItem
            // 
            this.verOcultarCoordenadasCamionToolStripMenuItem.Name = "verOcultarCoordenadasCamionToolStripMenuItem";
            this.verOcultarCoordenadasCamionToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.verOcultarCoordenadasCamionToolStripMenuItem.Text = "Ver/Ocultar Coordenadas Reparto Camion";
            this.verOcultarCoordenadasCamionToolStripMenuItem.Visible = false;
            this.verOcultarCoordenadasCamionToolStripMenuItem.Click += new System.EventHandler(this.verOcultarCoordenadasCamionToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 15;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(16, 127);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 16;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timerCamion
            // 
            this.timerCamion.Interval = 3000;
            this.timerCamion.Tick += new System.EventHandler(this.timerCamion_Tick);
            // 
            // btnRotarIzq
            // 
            this.btnRotarIzq.BackColor = System.Drawing.Color.White;
            this.btnRotarIzq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRotarIzq.Image = ((System.Drawing.Image)(resources.GetObject("btnRotarIzq.Image")));
            this.btnRotarIzq.Location = new System.Drawing.Point(4, 156);
            this.btnRotarIzq.Name = "btnRotarIzq";
            this.btnRotarIzq.Size = new System.Drawing.Size(50, 50);
            this.btnRotarIzq.TabIndex = 55;
            this.btnRotarIzq.UseVisualStyleBackColor = false;
            this.btnRotarIzq.Visible = false;
            this.btnRotarIzq.Click += new System.EventHandler(this.btnRotarIzq_Click);
            // 
            // btnRotarDer
            // 
            this.btnRotarDer.BackColor = System.Drawing.Color.White;
            this.btnRotarDer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRotarDer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRotarDer.Image = ((System.Drawing.Image)(resources.GetObject("btnRotarDer.Image")));
            this.btnRotarDer.Location = new System.Drawing.Point(6, 211);
            this.btnRotarDer.Name = "btnRotarDer";
            this.btnRotarDer.Size = new System.Drawing.Size(50, 50);
            this.btnRotarDer.TabIndex = 56;
            this.btnRotarDer.UseVisualStyleBackColor = false;
            this.btnRotarDer.Visible = false;
            this.btnRotarDer.Click += new System.EventHandler(this.btnRotarDer_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "truck1.png");
            this.imageList1.Images.SetKeyName(1, "cow.png");
            this.imageList1.Images.SetKeyName(2, "truck2.png");
            this.imageList1.Images.SetKeyName(3, "pin.png");
            this.imageList1.Images.SetKeyName(4, "final-state.png");
            this.imageList1.Images.SetKeyName(5, "target.png");
            this.imageList1.Images.SetKeyName(6, "truck3.png");
            this.imageList1.Images.SetKeyName(7, "pina.png");
            this.imageList1.Images.SetKeyName(8, "pinv.png");
            this.imageList1.Images.SetKeyName(9, "truck4a.png");
            this.imageList1.Images.SetKeyName(10, "truck4b.png");
            this.imageList1.Images.SetKeyName(11, "truck6a.png");
            this.imageList1.Images.SetKeyName(12, "truck6b.png");
            this.imageList1.Images.SetKeyName(13, "truck7a.png");
            this.imageList1.Images.SetKeyName(14, "truck7b.png");
            this.imageList1.Images.SetKeyName(15, "truck5a.png");
            this.imageList1.Images.SetKeyName(16, "truck5b.png");
            this.imageList1.Images.SetKeyName(17, "truck8a.png");
            this.imageList1.Images.SetKeyName(18, "truck8b.png");
            // 
            // imageListColor
            // 
            this.imageListColor.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListColor.ImageStream")));
            this.imageListColor.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListColor.Images.SetKeyName(0, "rectángulo.png");
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHora,
            this.toolStripButton23,
            this.toolStripButton18,
            this.toolStripButton17,
            this.toolStripButton19,
            this.toolStripButton21,
            this.toolStripButton22,
            this.lblConectadoF,
            this.lblServer,
            this.lblMandante,
            this.lblProveedor,
            this.lblDistancia,
            this.lblZomm,
            this.lblGiro,
            this.lblLatencia,
            this.lblip,
            this.lblInstancia,
            this.lblOrigenDatos,
            this.lblCorral,
            this.lblCoordenadas,
            this.toolStripLabel20,
            this.toolStripLabel19,
            this.toolStripLabel18,
            this.toolStripLabel17,
            this.toolStripLabel16,
            this.toolStripLabel15,
            this.toolStripLabel14,
            this.toolStripLabel13,
            this.toolStripLabel12,
            this.toolStripLabel11,
            this.toolStripLabel10,
            this.toolStripLabel9,
            this.lblErrores,
            this.toolStripSeparator17,
            this.lblCtrl,
            this.toolStripSeparator20,
            this.btnPing,
            this.lblPing,
            this.toolStripSeparator21,
            this.lblDistanciaMin,
            this.lblOrientacion,
            this.lblAngulo,
            this.lblTimer,
            this.lblMsg});
            this.toolStrip2.Location = new System.Drawing.Point(0, 675);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(1423, 31);
            this.toolStrip2.TabIndex = 70;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.Visible = false;
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 28);
            this.lblHora.Text = "Hora";
            // 
            // toolStripButton23
            // 
            this.toolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton23.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton23.Image")));
            this.toolStripButton23.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton23.Name = "toolStripButton23";
            this.toolStripButton23.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton23.Text = "toolStripButton23";
            this.toolStripButton23.Visible = false;
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.AutoToolTip = false;
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton18.Text = "toolStripButton18";
            this.toolStripButton18.Click += new System.EventHandler(this.toolStripButton18_Click);
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.AutoToolTip = false;
            this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton17.Text = "toolStripButton17";
            this.toolStripButton17.ToolTipText = "\r\n";
            this.toolStripButton17.Click += new System.EventHandler(this.toolStripButton17_Click);
            // 
            // toolStripButton19
            // 
            this.toolStripButton19.AutoToolTip = false;
            this.toolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton19.Image")));
            this.toolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton19.Name = "toolStripButton19";
            this.toolStripButton19.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton19.Text = "toolStripButton19";
            this.toolStripButton19.ToolTipText = "\r\n";
            this.toolStripButton19.Click += new System.EventHandler(this.toolStripButton19_Click);
            // 
            // toolStripButton21
            // 
            this.toolStripButton21.AutoToolTip = false;
            this.toolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton21.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton21.Image")));
            this.toolStripButton21.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton21.Name = "toolStripButton21";
            this.toolStripButton21.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton21.Text = "toolStripButton21";
            this.toolStripButton21.ToolTipText = "\r\n";
            this.toolStripButton21.Click += new System.EventHandler(this.toolStripButton21_Click);
            // 
            // toolStripButton22
            // 
            this.toolStripButton22.AutoToolTip = false;
            this.toolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton22.Image")));
            this.toolStripButton22.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton22.Name = "toolStripButton22";
            this.toolStripButton22.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton22.Text = "toolStripButton22";
            this.toolStripButton22.Click += new System.EventHandler(this.toolStripButton22_Click);
            // 
            // lblConectadoF
            // 
            this.lblConectadoF.MarqueeAnimationSpeed = 1;
            this.lblConectadoF.Maximum = 1;
            this.lblConectadoF.Name = "lblConectadoF";
            this.lblConectadoF.Size = new System.Drawing.Size(10, 28);
            this.lblConectadoF.Visible = false;
            // 
            // lblServer
            // 
            this.lblServer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(39, 28);
            this.lblServer.Text = "Server";
            this.lblServer.Visible = false;
            // 
            // lblMandante
            // 
            this.lblMandante.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMandante.Name = "lblMandante";
            this.lblMandante.Size = new System.Drawing.Size(61, 28);
            this.lblMandante.Text = "Mandante";
            this.lblMandante.Visible = false;
            // 
            // lblProveedor
            // 
            this.lblProveedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(86, 28);
            this.lblProveedor.Text = "toolStripLabel3";
            this.lblProveedor.Visible = false;
            // 
            // lblDistancia
            // 
            this.lblDistancia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(67, 28);
            this.lblDistancia.Text = "dist = 0 Km";
            this.lblDistancia.Visible = false;
            // 
            // lblZomm
            // 
            this.lblZomm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblZomm.Name = "lblZomm";
            this.lblZomm.Size = new System.Drawing.Size(43, 28);
            this.lblZomm.Text = "Zomm";
            // 
            // lblGiro
            // 
            this.lblGiro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGiro.Name = "lblGiro";
            this.lblGiro.Size = new System.Drawing.Size(29, 28);
            this.lblGiro.Text = "Giro";
            this.lblGiro.Visible = false;
            // 
            // lblLatencia
            // 
            this.lblLatencia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLatencia.Name = "lblLatencia";
            this.lblLatencia.Size = new System.Drawing.Size(51, 28);
            this.lblLatencia.Text = "Latencia";
            this.lblLatencia.Visible = false;
            // 
            // lblip
            // 
            this.lblip.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblip.Name = "lblip";
            this.lblip.Size = new System.Drawing.Size(17, 28);
            this.lblip.Text = "Ip";
            this.lblip.Visible = false;
            // 
            // lblInstancia
            // 
            this.lblInstancia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInstancia.Name = "lblInstancia";
            this.lblInstancia.Size = new System.Drawing.Size(54, 28);
            this.lblInstancia.Text = "Instancia";
            this.lblInstancia.Visible = false;
            this.lblInstancia.Click += new System.EventHandler(this.lblInstancia_Click);
            // 
            // lblOrigenDatos
            // 
            this.lblOrigenDatos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOrigenDatos.Name = "lblOrigenDatos";
            this.lblOrigenDatos.Size = new System.Drawing.Size(71, 28);
            this.lblOrigenDatos.Text = "origenDatos";
            this.lblOrigenDatos.Visible = false;
            // 
            // lblCorral
            // 
            this.lblCorral.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCorral.Name = "lblCorral";
            this.lblCorral.Size = new System.Drawing.Size(39, 28);
            this.lblCorral.Text = "Corral";
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(77, 28);
            this.lblCoordenadas.Text = "Coordenadas";
            // 
            // toolStripLabel20
            // 
            this.toolStripLabel20.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel20.Name = "toolStripLabel20";
            this.toolStripLabel20.Size = new System.Drawing.Size(43, 28);
            this.toolStripLabel20.Text = "Errores";
            this.toolStripLabel20.Visible = false;
            this.toolStripLabel20.Click += new System.EventHandler(this.lblErrores_Click);
            // 
            // toolStripLabel19
            // 
            this.toolStripLabel19.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel19.Name = "toolStripLabel19";
            this.toolStripLabel19.Size = new System.Drawing.Size(77, 28);
            this.toolStripLabel19.Text = "Coordenadas";
            this.toolStripLabel19.Visible = false;
            // 
            // toolStripLabel18
            // 
            this.toolStripLabel18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel18.Name = "toolStripLabel18";
            this.toolStripLabel18.Size = new System.Drawing.Size(39, 28);
            this.toolStripLabel18.Text = "Corral";
            this.toolStripLabel18.Visible = false;
            // 
            // toolStripLabel17
            // 
            this.toolStripLabel17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel17.Name = "toolStripLabel17";
            this.toolStripLabel17.Size = new System.Drawing.Size(71, 28);
            this.toolStripLabel17.Text = "origenDatos";
            this.toolStripLabel17.Visible = false;
            // 
            // toolStripLabel16
            // 
            this.toolStripLabel16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel16.Name = "toolStripLabel16";
            this.toolStripLabel16.Size = new System.Drawing.Size(54, 28);
            this.toolStripLabel16.Text = "Instancia";
            this.toolStripLabel16.Visible = false;
            this.toolStripLabel16.Click += new System.EventHandler(this.lblInstancia_Click);
            // 
            // toolStripLabel15
            // 
            this.toolStripLabel15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel15.Name = "toolStripLabel15";
            this.toolStripLabel15.Size = new System.Drawing.Size(51, 28);
            this.toolStripLabel15.Text = "Latencia";
            this.toolStripLabel15.Visible = false;
            // 
            // toolStripLabel14
            // 
            this.toolStripLabel14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel14.Name = "toolStripLabel14";
            this.toolStripLabel14.Size = new System.Drawing.Size(43, 28);
            this.toolStripLabel14.Text = "Zomm";
            this.toolStripLabel14.Visible = false;
            // 
            // toolStripLabel13
            // 
            this.toolStripLabel13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel13.Name = "toolStripLabel13";
            this.toolStripLabel13.Size = new System.Drawing.Size(67, 28);
            this.toolStripLabel13.Text = "dist = 0 Km";
            this.toolStripLabel13.Visible = false;
            // 
            // toolStripLabel12
            // 
            this.toolStripLabel12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel12.Name = "toolStripLabel12";
            this.toolStripLabel12.Size = new System.Drawing.Size(86, 28);
            this.toolStripLabel12.Text = "toolStripLabel3";
            this.toolStripLabel12.Visible = false;
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(61, 15);
            this.toolStripLabel11.Text = "Mandante";
            this.toolStripLabel11.Visible = false;
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(39, 15);
            this.toolStripLabel10.Text = "Server";
            this.toolStripLabel10.Visible = false;
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripLabel9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(33, 15);
            this.toolStripLabel9.Text = "Hora";
            this.toolStripLabel9.Visible = false;
            // 
            // lblErrores
            // 
            this.lblErrores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(43, 15);
            this.lblErrores.Text = "Errores";
            this.lblErrores.Visible = false;
            this.lblErrores.Click += new System.EventHandler(this.lblErrores_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 36);
            this.toolStripSeparator17.Visible = false;
            // 
            // lblCtrl
            // 
            this.lblCtrl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCtrl.Name = "lblCtrl";
            this.lblCtrl.Size = new System.Drawing.Size(24, 15);
            this.lblCtrl.Text = "ctrl";
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(6, 36);
            this.toolStripSeparator20.Visible = false;
            // 
            // btnPing
            // 
            this.btnPing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPing.Image = ((System.Drawing.Image)(resources.GetObject("btnPing.Image")));
            this.btnPing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(28, 28);
            this.btnPing.Text = "toolStripButton6";
            this.btnPing.ToolTipText = "\r\n";
            this.btnPing.Visible = false;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // lblPing
            // 
            this.lblPing.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(10, 15);
            this.lblPing.Text = ":";
            this.lblPing.Visible = false;
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(6, 36);
            this.toolStripSeparator21.Visible = false;
            // 
            // lblDistanciaMin
            // 
            this.lblDistanciaMin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDistanciaMin.Name = "lblDistanciaMin";
            this.lblDistanciaMin.Size = new System.Drawing.Size(13, 15);
            this.lblDistanciaMin.Text = "0";
            this.lblDistanciaMin.Visible = false;
            // 
            // lblOrientacion
            // 
            this.lblOrientacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOrientacion.Name = "lblOrientacion";
            this.lblOrientacion.Size = new System.Drawing.Size(13, 15);
            this.lblOrientacion.Text = "0";
            // 
            // lblAngulo
            // 
            this.lblAngulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(13, 15);
            this.lblAngulo.Text = "0";
            this.lblAngulo.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(13, 15);
            this.lblTimer.Text = "0";
            // 
            // lblMsg
            // 
            this.lblMsg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(16, 15);
            this.lblMsg.Text = "...";
            // 
            // webBClima
            // 
            this.webBClima.Location = new System.Drawing.Point(12, 85);
            this.webBClima.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBClima.Name = "webBClima";
            this.webBClima.ScrollBarsEnabled = false;
            this.webBClima.Size = new System.Drawing.Size(20, 22);
            this.webBClima.TabIndex = 77;
            this.webBClima.Url = new System.Uri("", System.UriKind.Relative);
            this.webBClima.Visible = false;
            // 
            // panelLeyenda
            // 
            this.panelLeyenda.BackColor = System.Drawing.Color.Transparent;
            this.panelLeyenda.Controls.Add(this.label9);
            this.panelLeyenda.Controls.Add(this.label8);
            this.panelLeyenda.Controls.Add(this.pictureBox717);
            this.panelLeyenda.Controls.Add(this.label7);
            this.panelLeyenda.Controls.Add(this.pictureBox716);
            this.panelLeyenda.Controls.Add(this.label6);
            this.panelLeyenda.Controls.Add(this.pictureBox715);
            this.panelLeyenda.Controls.Add(this.label5);
            this.panelLeyenda.Controls.Add(this.pictureBox714);
            this.panelLeyenda.Controls.Add(this.label10);
            this.panelLeyenda.Controls.Add(this.pictureBox713);
            this.panelLeyenda.Controls.Add(this.label11);
            this.panelLeyenda.Controls.Add(this.pictureBox712);
            this.panelLeyenda.Controls.Add(this.label12);
            this.panelLeyenda.Controls.Add(this.pictureBox711);
            this.panelLeyenda.Controls.Add(this.label13);
            this.panelLeyenda.Controls.Add(this.pictureBox710);
            this.panelLeyenda.Location = new System.Drawing.Point(481, 85);
            this.panelLeyenda.Name = "panelLeyenda";
            this.panelLeyenda.Size = new System.Drawing.Size(168, 83);
            this.panelLeyenda.TabIndex = 78;
            this.panelLeyenda.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Leyendas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Error Racion";
            this.label8.Visible = false;
            // 
            // pictureBox717
            // 
            this.pictureBox717.BackColor = System.Drawing.Color.Red;
            this.pictureBox717.Location = new System.Drawing.Point(11, 204);
            this.pictureBox717.Name = "pictureBox717";
            this.pictureBox717.Size = new System.Drawing.Size(16, 20);
            this.pictureBox717.TabIndex = 14;
            this.pictureBox717.TabStop = false;
            this.pictureBox717.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Excedio";
            // 
            // pictureBox716
            // 
            this.pictureBox716.BackColor = System.Drawing.Color.DarkViolet;
            this.pictureBox716.Location = new System.Drawing.Point(11, 181);
            this.pictureBox716.Name = "pictureBox716";
            this.pictureBox716.Size = new System.Drawing.Size(16, 20);
            this.pictureBox716.TabIndex = 12;
            this.pictureBox716.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "95 - 105%";
            // 
            // pictureBox715
            // 
            this.pictureBox715.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox715.Location = new System.Drawing.Point(11, 159);
            this.pictureBox715.Name = "pictureBox715";
            this.pictureBox715.Size = new System.Drawing.Size(16, 20);
            this.pictureBox715.TabIndex = 10;
            this.pictureBox715.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "75 - 95%";
            // 
            // pictureBox714
            // 
            this.pictureBox714.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox714.Location = new System.Drawing.Point(11, 137);
            this.pictureBox714.Name = "pictureBox714";
            this.pictureBox714.Size = new System.Drawing.Size(16, 20);
            this.pictureBox714.TabIndex = 8;
            this.pictureBox714.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "40 - 75%";
            // 
            // pictureBox713
            // 
            this.pictureBox713.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox713.Location = new System.Drawing.Point(11, 114);
            this.pictureBox713.Name = "pictureBox713";
            this.pictureBox713.Size = new System.Drawing.Size(16, 20);
            this.pictureBox713.TabIndex = 6;
            this.pictureBox713.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "20 - 40%";
            // 
            // pictureBox712
            // 
            this.pictureBox712.BackColor = System.Drawing.Color.Orange;
            this.pictureBox712.Location = new System.Drawing.Point(11, 92);
            this.pictureBox712.Name = "pictureBox712";
            this.pictureBox712.Size = new System.Drawing.Size(16, 20);
            this.pictureBox712.TabIndex = 4;
            this.pictureBox712.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "0 - 20%";
            // 
            // pictureBox711
            // 
            this.pictureBox711.BackColor = System.Drawing.Color.Silver;
            this.pictureBox711.Location = new System.Drawing.Point(11, 68);
            this.pictureBox711.Name = "pictureBox711";
            this.pictureBox711.Size = new System.Drawing.Size(16, 20);
            this.pictureBox711.TabIndex = 2;
            this.pictureBox711.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Vacio";
            // 
            // pictureBox710
            // 
            this.pictureBox710.BackColor = System.Drawing.Color.White;
            this.pictureBox710.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox710.Location = new System.Drawing.Point(11, 45);
            this.pictureBox710.Name = "pictureBox710";
            this.pictureBox710.Size = new System.Drawing.Size(16, 20);
            this.pictureBox710.TabIndex = 0;
            this.pictureBox710.TabStop = false;
            // 
            // panelTrack
            // 
            this.panelTrack.BackColor = System.Drawing.Color.White;
            this.panelTrack.Controls.Add(this.trackBar1);
            this.panelTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTrack.Location = new System.Drawing.Point(334, 124);
            this.panelTrack.Name = "panelTrack";
            this.panelTrack.Size = new System.Drawing.Size(16, 127);
            this.panelTrack.TabIndex = 79;
            this.panelTrack.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1423, 25);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.pestanaOpcion);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1415, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor de Estado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1415, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monitor de Estado del Rancho [SAP]";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1415, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Monitor de Estado del Rancho Historial [SAP]";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 81;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnCerrarFecha
            // 
            this.btnCerrarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarFecha.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarFecha.Image")));
            this.btnCerrarFecha.Location = new System.Drawing.Point(209, 162);
            this.btnCerrarFecha.Name = "btnCerrarFecha";
            this.btnCerrarFecha.Size = new System.Drawing.Size(33, 33);
            this.btnCerrarFecha.TabIndex = 82;
            this.btnCerrarFecha.UseVisualStyleBackColor = true;
            this.btnCerrarFecha.Click += new System.EventHandler(this.btnCerrarFecha_Click);
            // 
            // panelFecha
            // 
            this.panelFecha.Controls.Add(this.btnActualizaFecha);
            this.panelFecha.Controls.Add(this.btnCerrarFecha);
            this.panelFecha.Controls.Add(this.monthCalendar1);
            this.panelFecha.Location = new System.Drawing.Point(61, 73);
            this.panelFecha.Name = "panelFecha";
            this.panelFecha.Size = new System.Drawing.Size(248, 198);
            this.panelFecha.TabIndex = 83;
            this.panelFecha.Visible = false;
            // 
            // btnActualizaFecha
            // 
            this.btnActualizaFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizaFecha.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizaFecha.Image")));
            this.btnActualizaFecha.Location = new System.Drawing.Point(171, 162);
            this.btnActualizaFecha.Name = "btnActualizaFecha";
            this.btnActualizaFecha.Size = new System.Drawing.Size(32, 33);
            this.btnActualizaFecha.TabIndex = 83;
            this.btnActualizaFecha.UseVisualStyleBackColor = true;
            this.btnActualizaFecha.Click += new System.EventHandler(this.btnActualizaFecha_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.chart2.BackImageTransparentColor = System.Drawing.SystemColors.Control;
            this.chart2.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chart2.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Location = new System.Drawing.Point(89, 289);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(46, 79);
            this.chart2.TabIndex = 85;
            this.chart2.Text = "chart2";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Total";
            this.chart2.Titles.Add(title1);
            this.chart2.Visible = false;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.chart1.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(21, 285);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series2.Name = "S1";
            series2.YValuesPerPoint = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series3.Name = "S2";
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(58, 75);
            this.chart1.TabIndex = 86;
            this.chart1.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "Camiones";
            this.chart1.Titles.Add(title2);
            this.chart1.Visible = false;
            // 
            // listBoxLeyendas
            // 
            this.listBoxLeyendas.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxLeyendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLeyendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLeyendas.FormattingEnabled = true;
            this.listBoxLeyendas.ItemHeight = 20;
            this.listBoxLeyendas.Location = new System.Drawing.Point(0, 234);
            this.listBoxLeyendas.MultiColumn = true;
            this.listBoxLeyendas.Name = "listBoxLeyendas";
            this.listBoxLeyendas.Size = new System.Drawing.Size(135, 20);
            this.listBoxLeyendas.TabIndex = 87;
            this.listBoxLeyendas.SelectedIndexChanged += new System.EventHandler(this.listBoxLeyendas_SelectedIndexChanged);
            // 
            // panelLeyendas
            // 
            this.panelLeyendas.BackColor = System.Drawing.Color.Transparent;
            this.panelLeyendas.Controls.Add(this.btnOcultarCuadro);
            this.panelLeyendas.Controls.Add(this.dataGridVista);
            this.panelLeyendas.Controls.Add(this.labelLeyendas);
            this.panelLeyendas.Controls.Add(this.listBoxLeyendas);
            this.panelLeyendas.Location = new System.Drawing.Point(1057, 76);
            this.panelLeyendas.Name = "panelLeyendas";
            this.panelLeyendas.Size = new System.Drawing.Size(134, 188);
            this.panelLeyendas.TabIndex = 88;
            // 
            // btnOcultarCuadro
            // 
            this.btnOcultarCuadro.Location = new System.Drawing.Point(109, 3);
            this.btnOcultarCuadro.Name = "btnOcultarCuadro";
            this.btnOcultarCuadro.Size = new System.Drawing.Size(22, 24);
            this.btnOcultarCuadro.TabIndex = 90;
            this.btnOcultarCuadro.Text = "<<";
            this.btnOcultarCuadro.UseVisualStyleBackColor = true;
            this.btnOcultarCuadro.Visible = false;
            this.btnOcultarCuadro.Click += new System.EventHandler(this.btnOcultarCuadro_Click);
            // 
            // dataGridVista
            // 
            this.dataGridVista.AllowDrop = true;
            this.dataGridVista.AllowUserToAddRows = false;
            this.dataGridVista.AllowUserToDeleteRows = false;
            this.dataGridVista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridVista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.dataGridVista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridVista.ColumnHeadersHeight = 34;
            this.dataGridVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridVista.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVista.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridVista.Location = new System.Drawing.Point(0, 33);
            this.dataGridVista.MultiSelect = false;
            this.dataGridVista.Name = "dataGridVista";
            this.dataGridVista.ReadOnly = true;
            this.dataGridVista.RowHeadersVisible = false;
            this.dataGridVista.RowHeadersWidth = 70;
            this.dataGridVista.RowTemplate.Height = 35;
            this.dataGridVista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridVista.Size = new System.Drawing.Size(134, 155);
            this.dataGridVista.TabIndex = 89;
            this.dataGridVista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVista_CellContentClick);
            // 
            // labelLeyendas
            // 
            this.labelLeyendas.BackColor = System.Drawing.Color.Transparent;
            this.labelLeyendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLeyendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeyendas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelLeyendas.Location = new System.Drawing.Point(0, 0);
            this.labelLeyendas.Name = "labelLeyendas";
            this.labelLeyendas.Size = new System.Drawing.Size(134, 25);
            this.labelLeyendas.TabIndex = 88;
            this.labelLeyendas.Text = "Servido";
            this.labelLeyendas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerPing
            // 
            this.timerPing.Interval = 5000;
            this.timerPing.Tick += new System.EventHandler(this.timerPing_Tick);
            // 
            // panelCamiones
            // 
            this.panelCamiones.BackColor = System.Drawing.Color.Transparent;
            this.panelCamiones.Controls.Add(this.label14);
            this.panelCamiones.Controls.Add(this.picGpsCam36);
            this.panelCamiones.Controls.Add(this.picRepCam36);
            this.panelCamiones.Controls.Add(this.label15);
            this.panelCamiones.Controls.Add(this.picRepCam35);
            this.panelCamiones.Controls.Add(this.picGpsCam35);
            this.panelCamiones.Controls.Add(this.picGpsCam34);
            this.panelCamiones.Controls.Add(this.picGpsCam33);
            this.panelCamiones.Controls.Add(this.label52);
            this.panelCamiones.Controls.Add(this.label53);
            this.panelCamiones.Controls.Add(this.picRepCam34);
            this.panelCamiones.Controls.Add(this.picRepCam33);
            this.panelCamiones.Controls.Add(this.label54);
            this.panelCamiones.Controls.Add(this.picGpsCam32);
            this.panelCamiones.Controls.Add(this.picRepCam32);
            this.panelCamiones.Controls.Add(this.label56);
            this.panelCamiones.Controls.Add(this.picRepCam31);
            this.panelCamiones.Controls.Add(this.picGpsCam31);
            this.panelCamiones.Controls.Add(this.picGpsCam30);
            this.panelCamiones.Controls.Add(this.picGpsCam29);
            this.panelCamiones.Controls.Add(this.label57);
            this.panelCamiones.Controls.Add(this.label58);
            this.panelCamiones.Controls.Add(this.picRepCam30);
            this.panelCamiones.Controls.Add(this.picRepCam29);
            this.panelCamiones.Controls.Add(this.picCam36);
            this.panelCamiones.Controls.Add(this.picCam35);
            this.panelCamiones.Controls.Add(this.picCam34);
            this.panelCamiones.Controls.Add(this.picCam33);
            this.panelCamiones.Controls.Add(this.picCam32);
            this.panelCamiones.Controls.Add(this.picCam31);
            this.panelCamiones.Controls.Add(this.picCam30);
            this.panelCamiones.Controls.Add(this.picCam29);
            this.panelCamiones.Controls.Add(this.label46);
            this.panelCamiones.Controls.Add(this.picGpsCam28);
            this.panelCamiones.Controls.Add(this.picRepCam28);
            this.panelCamiones.Controls.Add(this.label47);
            this.panelCamiones.Controls.Add(this.picRepCam27);
            this.panelCamiones.Controls.Add(this.picGpsCam27);
            this.panelCamiones.Controls.Add(this.picGpsCam26);
            this.panelCamiones.Controls.Add(this.picGpsCam25);
            this.panelCamiones.Controls.Add(this.label48);
            this.panelCamiones.Controls.Add(this.label50);
            this.panelCamiones.Controls.Add(this.picRepCam26);
            this.panelCamiones.Controls.Add(this.picRepCam25);
            this.panelCamiones.Controls.Add(this.picCam28);
            this.panelCamiones.Controls.Add(this.picCam27);
            this.panelCamiones.Controls.Add(this.picCam26);
            this.panelCamiones.Controls.Add(this.picCam25);
            this.panelCamiones.Controls.Add(this.label43);
            this.panelCamiones.Controls.Add(this.picGpsCam24);
            this.panelCamiones.Controls.Add(this.picRepCam24);
            this.panelCamiones.Controls.Add(this.picCam24);
            this.panelCamiones.Controls.Add(this.label41);
            this.panelCamiones.Controls.Add(this.picRepCam23);
            this.panelCamiones.Controls.Add(this.picGpsCam23);
            this.panelCamiones.Controls.Add(this.picCam23);
            this.panelCamiones.Controls.Add(this.picCam22);
            this.panelCamiones.Controls.Add(this.picCam20);
            this.panelCamiones.Controls.Add(this.picCam21);
            this.panelCamiones.Controls.Add(this.picCam19);
            this.panelCamiones.Controls.Add(this.picCam17);
            this.panelCamiones.Controls.Add(this.picCam18);
            this.panelCamiones.Controls.Add(this.picCam16);
            this.panelCamiones.Controls.Add(this.picGpsCam22);
            this.panelCamiones.Controls.Add(this.picGpsCam21);
            this.panelCamiones.Controls.Add(this.picGpsCam20);
            this.panelCamiones.Controls.Add(this.picGpsCam19);
            this.panelCamiones.Controls.Add(this.picGpsCam18);
            this.panelCamiones.Controls.Add(this.picGpsCam17);
            this.panelCamiones.Controls.Add(this.picGpsCam16);
            this.panelCamiones.Controls.Add(this.label4);
            this.panelCamiones.Controls.Add(this.label16);
            this.panelCamiones.Controls.Add(this.label17);
            this.panelCamiones.Controls.Add(this.label18);
            this.panelCamiones.Controls.Add(this.label19);
            this.panelCamiones.Controls.Add(this.label20);
            this.panelCamiones.Controls.Add(this.lbl16);
            this.panelCamiones.Controls.Add(this.picRepCam22);
            this.panelCamiones.Controls.Add(this.picRepCam21);
            this.panelCamiones.Controls.Add(this.picRepCam20);
            this.panelCamiones.Controls.Add(this.picRepCam19);
            this.panelCamiones.Controls.Add(this.picRepCam18);
            this.panelCamiones.Controls.Add(this.picRepCam17);
            this.panelCamiones.Controls.Add(this.picRepCam16);
            this.panelCamiones.Controls.Add(this.lblCamPorc);
            this.panelCamiones.Controls.Add(this.label31);
            this.panelCamiones.Controls.Add(this.picGpsCam15);
            this.panelCamiones.Controls.Add(this.picGpsCam14);
            this.panelCamiones.Controls.Add(this.picGpsCam13);
            this.panelCamiones.Controls.Add(this.picGpsCam12);
            this.panelCamiones.Controls.Add(this.picGpsCam11);
            this.panelCamiones.Controls.Add(this.picGpsCam10);
            this.panelCamiones.Controls.Add(this.picGpsCam09);
            this.panelCamiones.Controls.Add(this.picGpsCam08);
            this.panelCamiones.Controls.Add(this.picGpsCam07);
            this.panelCamiones.Controls.Add(this.picGpsCam06);
            this.panelCamiones.Controls.Add(this.picGpsCam05);
            this.panelCamiones.Controls.Add(this.lbl15);
            this.panelCamiones.Controls.Add(this.lbl14);
            this.panelCamiones.Controls.Add(this.lbl13);
            this.panelCamiones.Controls.Add(this.lbl12);
            this.panelCamiones.Controls.Add(this.lbl11);
            this.panelCamiones.Controls.Add(this.lbl10);
            this.panelCamiones.Controls.Add(this.lbl09);
            this.panelCamiones.Controls.Add(this.lbl08);
            this.panelCamiones.Controls.Add(this.lbl07);
            this.panelCamiones.Controls.Add(this.lbl06);
            this.panelCamiones.Controls.Add(this.lbl05);
            this.panelCamiones.Controls.Add(this.picGpsCam04);
            this.panelCamiones.Controls.Add(this.picGpsCam03);
            this.panelCamiones.Controls.Add(this.picGpsCam02);
            this.panelCamiones.Controls.Add(this.lbl04);
            this.panelCamiones.Controls.Add(this.lbl03);
            this.panelCamiones.Controls.Add(this.lbl02);
            this.panelCamiones.Controls.Add(this.picGpsCam01);
            this.panelCamiones.Controls.Add(this.lbl01);
            this.panelCamiones.Controls.Add(this.label2);
            this.panelCamiones.Controls.Add(this.label1);
            this.panelCamiones.Controls.Add(this.picRepCam15);
            this.panelCamiones.Controls.Add(this.picRepCam14);
            this.panelCamiones.Controls.Add(this.picRepCam13);
            this.panelCamiones.Controls.Add(this.picRepCam12);
            this.panelCamiones.Controls.Add(this.picRepCam11);
            this.panelCamiones.Controls.Add(this.picRepCam08);
            this.panelCamiones.Controls.Add(this.picRepCam10);
            this.panelCamiones.Controls.Add(this.picRepCam07);
            this.panelCamiones.Controls.Add(this.picRepCam09);
            this.panelCamiones.Controls.Add(this.picRepCam06);
            this.panelCamiones.Controls.Add(this.picRepCam05);
            this.panelCamiones.Controls.Add(this.picRepCam04);
            this.panelCamiones.Controls.Add(this.picRepCam03);
            this.panelCamiones.Controls.Add(this.picRepCam02);
            this.panelCamiones.Controls.Add(this.picCam14);
            this.panelCamiones.Controls.Add(this.picCam15);
            this.panelCamiones.Controls.Add(this.picRepCam01);
            this.panelCamiones.Controls.Add(this.picCam13);
            this.panelCamiones.Controls.Add(this.picCam11);
            this.panelCamiones.Controls.Add(this.picCam12);
            this.panelCamiones.Controls.Add(this.picCam10);
            this.panelCamiones.Controls.Add(this.picCam08);
            this.panelCamiones.Controls.Add(this.picCam09);
            this.panelCamiones.Controls.Add(this.picCam07);
            this.panelCamiones.Controls.Add(this.picCam04);
            this.panelCamiones.Controls.Add(this.picCam06);
            this.panelCamiones.Controls.Add(this.picCam02);
            this.panelCamiones.Controls.Add(this.picCam03);
            this.panelCamiones.Controls.Add(this.picCam05);
            this.panelCamiones.Controls.Add(this.picCam01);
            this.panelCamiones.Location = new System.Drawing.Point(300, 277);
            this.panelCamiones.Name = "panelCamiones";
            this.panelCamiones.Size = new System.Drawing.Size(503, 133);
            this.panelCamiones.TabIndex = 89;
            this.panelCamiones.Visible = false;
            this.panelCamiones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCamiones_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(545, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 7);
            this.label14.TabIndex = 219;
            this.label14.Text = "28";
            // 
            // picGpsCam36
            // 
            this.picGpsCam36.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam36.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam36.Location = new System.Drawing.Point(547, 25);
            this.picGpsCam36.Name = "picGpsCam36";
            this.picGpsCam36.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam36.TabIndex = 218;
            this.picGpsCam36.TabStop = false;
            // 
            // picRepCam36
            // 
            this.picRepCam36.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam36.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam36.Location = new System.Drawing.Point(547, 19);
            this.picRepCam36.Name = "picRepCam36";
            this.picRepCam36.Size = new System.Drawing.Size(11, 6);
            this.picRepCam36.TabIndex = 217;
            this.picRepCam36.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(532, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 7);
            this.label15.TabIndex = 216;
            this.label15.Text = "27";
            // 
            // picRepCam35
            // 
            this.picRepCam35.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam35.Location = new System.Drawing.Point(534, 19);
            this.picRepCam35.Name = "picRepCam35";
            this.picRepCam35.Size = new System.Drawing.Size(11, 6);
            this.picRepCam35.TabIndex = 215;
            this.picRepCam35.TabStop = false;
            // 
            // picGpsCam35
            // 
            this.picGpsCam35.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam35.Location = new System.Drawing.Point(534, 25);
            this.picGpsCam35.Name = "picGpsCam35";
            this.picGpsCam35.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam35.TabIndex = 214;
            this.picGpsCam35.TabStop = false;
            // 
            // picGpsCam34
            // 
            this.picGpsCam34.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam34.Location = new System.Drawing.Point(520, 25);
            this.picGpsCam34.Name = "picGpsCam34";
            this.picGpsCam34.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam34.TabIndex = 213;
            this.picGpsCam34.TabStop = false;
            // 
            // picGpsCam33
            // 
            this.picGpsCam33.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam33.Location = new System.Drawing.Point(507, 25);
            this.picGpsCam33.Name = "picGpsCam33";
            this.picGpsCam33.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam33.TabIndex = 212;
            this.picGpsCam33.TabStop = false;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(517, 10);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(14, 7);
            this.label52.TabIndex = 211;
            this.label52.Text = "26";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(504, 10);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(14, 7);
            this.label53.TabIndex = 210;
            this.label53.Text = "25";
            // 
            // picRepCam34
            // 
            this.picRepCam34.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam34.Location = new System.Drawing.Point(520, 19);
            this.picRepCam34.Name = "picRepCam34";
            this.picRepCam34.Size = new System.Drawing.Size(11, 6);
            this.picRepCam34.TabIndex = 209;
            this.picRepCam34.TabStop = false;
            // 
            // picRepCam33
            // 
            this.picRepCam33.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam33.Location = new System.Drawing.Point(507, 19);
            this.picRepCam33.Name = "picRepCam33";
            this.picRepCam33.Size = new System.Drawing.Size(11, 6);
            this.picRepCam33.TabIndex = 208;
            this.picRepCam33.TabStop = false;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(491, 10);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(14, 7);
            this.label54.TabIndex = 207;
            this.label54.Text = "24";
            // 
            // picGpsCam32
            // 
            this.picGpsCam32.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam32.Location = new System.Drawing.Point(493, 25);
            this.picGpsCam32.Name = "picGpsCam32";
            this.picGpsCam32.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam32.TabIndex = 206;
            this.picGpsCam32.TabStop = false;
            // 
            // picRepCam32
            // 
            this.picRepCam32.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam32.Location = new System.Drawing.Point(493, 19);
            this.picRepCam32.Name = "picRepCam32";
            this.picRepCam32.Size = new System.Drawing.Size(11, 6);
            this.picRepCam32.TabIndex = 205;
            this.picRepCam32.TabStop = false;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(478, 10);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(14, 7);
            this.label56.TabIndex = 204;
            this.label56.Text = "23";
            // 
            // picRepCam31
            // 
            this.picRepCam31.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam31.Location = new System.Drawing.Point(480, 19);
            this.picRepCam31.Name = "picRepCam31";
            this.picRepCam31.Size = new System.Drawing.Size(11, 6);
            this.picRepCam31.TabIndex = 203;
            this.picRepCam31.TabStop = false;
            // 
            // picGpsCam31
            // 
            this.picGpsCam31.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam31.Location = new System.Drawing.Point(480, 25);
            this.picGpsCam31.Name = "picGpsCam31";
            this.picGpsCam31.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam31.TabIndex = 202;
            this.picGpsCam31.TabStop = false;
            // 
            // picGpsCam30
            // 
            this.picGpsCam30.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam30.Location = new System.Drawing.Point(466, 25);
            this.picGpsCam30.Name = "picGpsCam30";
            this.picGpsCam30.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam30.TabIndex = 201;
            this.picGpsCam30.TabStop = false;
            // 
            // picGpsCam29
            // 
            this.picGpsCam29.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam29.Location = new System.Drawing.Point(453, 25);
            this.picGpsCam29.Name = "picGpsCam29";
            this.picGpsCam29.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam29.TabIndex = 200;
            this.picGpsCam29.TabStop = false;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(463, 11);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(14, 7);
            this.label57.TabIndex = 199;
            this.label57.Text = "22";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(450, 11);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(14, 7);
            this.label58.TabIndex = 198;
            this.label58.Text = "21";
            // 
            // picRepCam30
            // 
            this.picRepCam30.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam30.Location = new System.Drawing.Point(466, 19);
            this.picRepCam30.Name = "picRepCam30";
            this.picRepCam30.Size = new System.Drawing.Size(11, 6);
            this.picRepCam30.TabIndex = 197;
            this.picRepCam30.TabStop = false;
            // 
            // picRepCam29
            // 
            this.picRepCam29.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam29.Location = new System.Drawing.Point(453, 19);
            this.picRepCam29.Name = "picRepCam29";
            this.picRepCam29.Size = new System.Drawing.Size(11, 6);
            this.picRepCam29.TabIndex = 196;
            this.picRepCam29.TabStop = false;
            // 
            // picCam36
            // 
            this.picCam36.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam36.Image = ((System.Drawing.Image)(resources.GetObject("picCam36.Image")));
            this.picCam36.Location = new System.Drawing.Point(407, 99);
            this.picCam36.Name = "picCam36";
            this.picCam36.Size = new System.Drawing.Size(31, 24);
            this.picCam36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam36.TabIndex = 195;
            this.picCam36.TabStop = false;
            // 
            // picCam35
            // 
            this.picCam35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam35.Image = ((System.Drawing.Image)(resources.GetObject("picCam35.Image")));
            this.picCam35.Location = new System.Drawing.Point(373, 99);
            this.picCam35.Name = "picCam35";
            this.picCam35.Size = new System.Drawing.Size(31, 24);
            this.picCam35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam35.TabIndex = 194;
            this.picCam35.TabStop = false;
            // 
            // picCam34
            // 
            this.picCam34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam34.Image = ((System.Drawing.Image)(resources.GetObject("picCam34.Image")));
            this.picCam34.Location = new System.Drawing.Point(339, 99);
            this.picCam34.Name = "picCam34";
            this.picCam34.Size = new System.Drawing.Size(31, 24);
            this.picCam34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam34.TabIndex = 193;
            this.picCam34.TabStop = false;
            // 
            // picCam33
            // 
            this.picCam33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam33.Image = ((System.Drawing.Image)(resources.GetObject("picCam33.Image")));
            this.picCam33.Location = new System.Drawing.Point(306, 99);
            this.picCam33.Name = "picCam33";
            this.picCam33.Size = new System.Drawing.Size(31, 24);
            this.picCam33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam33.TabIndex = 192;
            this.picCam33.TabStop = false;
            // 
            // picCam32
            // 
            this.picCam32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam32.Image = ((System.Drawing.Image)(resources.GetObject("picCam32.Image")));
            this.picCam32.Location = new System.Drawing.Point(262, 99);
            this.picCam32.Name = "picCam32";
            this.picCam32.Size = new System.Drawing.Size(31, 24);
            this.picCam32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam32.TabIndex = 191;
            this.picCam32.TabStop = false;
            // 
            // picCam31
            // 
            this.picCam31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam31.Image = ((System.Drawing.Image)(resources.GetObject("picCam31.Image")));
            this.picCam31.Location = new System.Drawing.Point(229, 99);
            this.picCam31.Name = "picCam31";
            this.picCam31.Size = new System.Drawing.Size(31, 24);
            this.picCam31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam31.TabIndex = 190;
            this.picCam31.TabStop = false;
            // 
            // picCam30
            // 
            this.picCam30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam30.Image = ((System.Drawing.Image)(resources.GetObject("picCam30.Image")));
            this.picCam30.Location = new System.Drawing.Point(195, 99);
            this.picCam30.Name = "picCam30";
            this.picCam30.Size = new System.Drawing.Size(31, 24);
            this.picCam30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam30.TabIndex = 189;
            this.picCam30.TabStop = false;
            // 
            // picCam29
            // 
            this.picCam29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam29.Image = ((System.Drawing.Image)(resources.GetObject("picCam29.Image")));
            this.picCam29.Location = new System.Drawing.Point(161, 99);
            this.picCam29.Name = "picCam29";
            this.picCam29.Size = new System.Drawing.Size(31, 24);
            this.picCam29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam29.TabIndex = 188;
            this.picCam29.TabStop = false;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(419, 7);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(14, 7);
            this.label46.TabIndex = 187;
            this.label46.Text = "28";
            // 
            // picGpsCam28
            // 
            this.picGpsCam28.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam28.Location = new System.Drawing.Point(421, 22);
            this.picGpsCam28.Name = "picGpsCam28";
            this.picGpsCam28.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam28.TabIndex = 186;
            this.picGpsCam28.TabStop = false;
            // 
            // picRepCam28
            // 
            this.picRepCam28.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam28.Location = new System.Drawing.Point(421, 16);
            this.picRepCam28.Name = "picRepCam28";
            this.picRepCam28.Size = new System.Drawing.Size(11, 6);
            this.picRepCam28.TabIndex = 185;
            this.picRepCam28.TabStop = false;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(405, 7);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(14, 7);
            this.label47.TabIndex = 184;
            this.label47.Text = "27";
            // 
            // picRepCam27
            // 
            this.picRepCam27.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam27.Location = new System.Drawing.Point(407, 16);
            this.picRepCam27.Name = "picRepCam27";
            this.picRepCam27.Size = new System.Drawing.Size(11, 6);
            this.picRepCam27.TabIndex = 183;
            this.picRepCam27.TabStop = false;
            // 
            // picGpsCam27
            // 
            this.picGpsCam27.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam27.Location = new System.Drawing.Point(407, 22);
            this.picGpsCam27.Name = "picGpsCam27";
            this.picGpsCam27.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam27.TabIndex = 182;
            this.picGpsCam27.TabStop = false;
            // 
            // picGpsCam26
            // 
            this.picGpsCam26.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam26.Location = new System.Drawing.Point(393, 22);
            this.picGpsCam26.Name = "picGpsCam26";
            this.picGpsCam26.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam26.TabIndex = 181;
            this.picGpsCam26.TabStop = false;
            // 
            // picGpsCam25
            // 
            this.picGpsCam25.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam25.Location = new System.Drawing.Point(380, 22);
            this.picGpsCam25.Name = "picGpsCam25";
            this.picGpsCam25.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam25.TabIndex = 180;
            this.picGpsCam25.TabStop = false;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(391, 7);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(14, 7);
            this.label48.TabIndex = 179;
            this.label48.Text = "26";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(377, 7);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(14, 7);
            this.label50.TabIndex = 178;
            this.label50.Text = "25";
            // 
            // picRepCam26
            // 
            this.picRepCam26.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam26.Location = new System.Drawing.Point(393, 16);
            this.picRepCam26.Name = "picRepCam26";
            this.picRepCam26.Size = new System.Drawing.Size(11, 6);
            this.picRepCam26.TabIndex = 177;
            this.picRepCam26.TabStop = false;
            // 
            // picRepCam25
            // 
            this.picRepCam25.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam25.Location = new System.Drawing.Point(380, 16);
            this.picRepCam25.Name = "picRepCam25";
            this.picRepCam25.Size = new System.Drawing.Size(11, 6);
            this.picRepCam25.TabIndex = 176;
            this.picRepCam25.TabStop = false;
            // 
            // picCam28
            // 
            this.picCam28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam28.Image = ((System.Drawing.Image)(resources.GetObject("picCam28.Image")));
            this.picCam28.Location = new System.Drawing.Point(453, 66);
            this.picCam28.Name = "picCam28";
            this.picCam28.Size = new System.Drawing.Size(31, 24);
            this.picCam28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam28.TabIndex = 175;
            this.picCam28.TabStop = false;
            // 
            // picCam27
            // 
            this.picCam27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam27.Image = ((System.Drawing.Image)(resources.GetObject("picCam27.Image")));
            this.picCam27.Location = new System.Drawing.Point(419, 66);
            this.picCam27.Name = "picCam27";
            this.picCam27.Size = new System.Drawing.Size(31, 24);
            this.picCam27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam27.TabIndex = 174;
            this.picCam27.TabStop = false;
            // 
            // picCam26
            // 
            this.picCam26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam26.Image = ((System.Drawing.Image)(resources.GetObject("picCam26.Image")));
            this.picCam26.Location = new System.Drawing.Point(385, 66);
            this.picCam26.Name = "picCam26";
            this.picCam26.Size = new System.Drawing.Size(31, 24);
            this.picCam26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam26.TabIndex = 173;
            this.picCam26.TabStop = false;
            // 
            // picCam25
            // 
            this.picCam25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam25.Image = ((System.Drawing.Image)(resources.GetObject("picCam25.Image")));
            this.picCam25.Location = new System.Drawing.Point(352, 66);
            this.picCam25.Name = "picCam25";
            this.picCam25.Size = new System.Drawing.Size(31, 24);
            this.picCam25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam25.TabIndex = 172;
            this.picCam25.TabStop = false;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(365, 7);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(14, 7);
            this.label43.TabIndex = 171;
            this.label43.Text = "24";
            // 
            // picGpsCam24
            // 
            this.picGpsCam24.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam24.Location = new System.Drawing.Point(367, 22);
            this.picGpsCam24.Name = "picGpsCam24";
            this.picGpsCam24.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam24.TabIndex = 170;
            this.picGpsCam24.TabStop = false;
            // 
            // picRepCam24
            // 
            this.picRepCam24.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam24.Location = new System.Drawing.Point(367, 16);
            this.picRepCam24.Name = "picRepCam24";
            this.picRepCam24.Size = new System.Drawing.Size(11, 6);
            this.picRepCam24.TabIndex = 169;
            this.picRepCam24.TabStop = false;
            // 
            // picCam24
            // 
            this.picCam24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam24.Image = ((System.Drawing.Image)(resources.GetObject("picCam24.Image")));
            this.picCam24.Location = new System.Drawing.Point(308, 66);
            this.picCam24.Name = "picCam24";
            this.picCam24.Size = new System.Drawing.Size(31, 24);
            this.picCam24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam24.TabIndex = 168;
            this.picCam24.TabStop = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(351, 7);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(14, 7);
            this.label41.TabIndex = 167;
            this.label41.Text = "23";
            // 
            // picRepCam23
            // 
            this.picRepCam23.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam23.Location = new System.Drawing.Point(353, 16);
            this.picRepCam23.Name = "picRepCam23";
            this.picRepCam23.Size = new System.Drawing.Size(11, 6);
            this.picRepCam23.TabIndex = 166;
            this.picRepCam23.TabStop = false;
            // 
            // picGpsCam23
            // 
            this.picGpsCam23.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam23.Location = new System.Drawing.Point(353, 22);
            this.picGpsCam23.Name = "picGpsCam23";
            this.picGpsCam23.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam23.TabIndex = 165;
            this.picGpsCam23.TabStop = false;
            // 
            // picCam23
            // 
            this.picCam23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam23.Image = ((System.Drawing.Image)(resources.GetObject("picCam23.Image")));
            this.picCam23.Location = new System.Drawing.Point(275, 66);
            this.picCam23.Name = "picCam23";
            this.picCam23.Size = new System.Drawing.Size(31, 24);
            this.picCam23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam23.TabIndex = 164;
            this.picCam23.TabStop = false;
            // 
            // picCam22
            // 
            this.picCam22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam22.Image = ((System.Drawing.Image)(resources.GetObject("picCam22.Image")));
            this.picCam22.Location = new System.Drawing.Point(241, 66);
            this.picCam22.Name = "picCam22";
            this.picCam22.Size = new System.Drawing.Size(31, 24);
            this.picCam22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam22.TabIndex = 163;
            this.picCam22.TabStop = false;
            // 
            // picCam20
            // 
            this.picCam20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam20.Image = ((System.Drawing.Image)(resources.GetObject("picCam20.Image")));
            this.picCam20.Location = new System.Drawing.Point(177, 66);
            this.picCam20.Name = "picCam20";
            this.picCam20.Size = new System.Drawing.Size(31, 24);
            this.picCam20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam20.TabIndex = 162;
            this.picCam20.TabStop = false;
            // 
            // picCam21
            // 
            this.picCam21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam21.Image = ((System.Drawing.Image)(resources.GetObject("picCam21.Image")));
            this.picCam21.Location = new System.Drawing.Point(207, 66);
            this.picCam21.Name = "picCam21";
            this.picCam21.Size = new System.Drawing.Size(31, 24);
            this.picCam21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam21.TabIndex = 161;
            this.picCam21.TabStop = false;
            // 
            // picCam19
            // 
            this.picCam19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam19.Image = ((System.Drawing.Image)(resources.GetObject("picCam19.Image")));
            this.picCam19.Location = new System.Drawing.Point(147, 66);
            this.picCam19.Name = "picCam19";
            this.picCam19.Size = new System.Drawing.Size(31, 24);
            this.picCam19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam19.TabIndex = 160;
            this.picCam19.TabStop = false;
            // 
            // picCam17
            // 
            this.picCam17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam17.Image = ((System.Drawing.Image)(resources.GetObject("picCam17.Image")));
            this.picCam17.Location = new System.Drawing.Point(87, 66);
            this.picCam17.Name = "picCam17";
            this.picCam17.Size = new System.Drawing.Size(31, 24);
            this.picCam17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam17.TabIndex = 159;
            this.picCam17.TabStop = false;
            // 
            // picCam18
            // 
            this.picCam18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam18.Image = ((System.Drawing.Image)(resources.GetObject("picCam18.Image")));
            this.picCam18.Location = new System.Drawing.Point(117, 66);
            this.picCam18.Name = "picCam18";
            this.picCam18.Size = new System.Drawing.Size(31, 24);
            this.picCam18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam18.TabIndex = 158;
            this.picCam18.TabStop = false;
            // 
            // picCam16
            // 
            this.picCam16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam16.Image = ((System.Drawing.Image)(resources.GetObject("picCam16.Image")));
            this.picCam16.Location = new System.Drawing.Point(462, 37);
            this.picCam16.Name = "picCam16";
            this.picCam16.Size = new System.Drawing.Size(31, 24);
            this.picCam16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam16.TabIndex = 157;
            this.picCam16.TabStop = false;
            this.picCam16.Click += new System.EventHandler(this.picCam16_Click);
            // 
            // picGpsCam22
            // 
            this.picGpsCam22.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam22.Location = new System.Drawing.Point(339, 22);
            this.picGpsCam22.Name = "picGpsCam22";
            this.picGpsCam22.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam22.TabIndex = 156;
            this.picGpsCam22.TabStop = false;
            // 
            // picGpsCam21
            // 
            this.picGpsCam21.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam21.Location = new System.Drawing.Point(326, 22);
            this.picGpsCam21.Name = "picGpsCam21";
            this.picGpsCam21.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam21.TabIndex = 155;
            this.picGpsCam21.TabStop = false;
            // 
            // picGpsCam20
            // 
            this.picGpsCam20.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam20.Location = new System.Drawing.Point(313, 22);
            this.picGpsCam20.Name = "picGpsCam20";
            this.picGpsCam20.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam20.TabIndex = 154;
            this.picGpsCam20.TabStop = false;
            // 
            // picGpsCam19
            // 
            this.picGpsCam19.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam19.Location = new System.Drawing.Point(299, 22);
            this.picGpsCam19.Name = "picGpsCam19";
            this.picGpsCam19.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam19.TabIndex = 153;
            this.picGpsCam19.TabStop = false;
            // 
            // picGpsCam18
            // 
            this.picGpsCam18.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam18.Location = new System.Drawing.Point(286, 22);
            this.picGpsCam18.Name = "picGpsCam18";
            this.picGpsCam18.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam18.TabIndex = 152;
            this.picGpsCam18.TabStop = false;
            // 
            // picGpsCam17
            // 
            this.picGpsCam17.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam17.Location = new System.Drawing.Point(273, 22);
            this.picGpsCam17.Name = "picGpsCam17";
            this.picGpsCam17.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam17.TabIndex = 151;
            this.picGpsCam17.TabStop = false;
            // 
            // picGpsCam16
            // 
            this.picGpsCam16.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam16.Location = new System.Drawing.Point(261, 22);
            this.picGpsCam16.Name = "picGpsCam16";
            this.picGpsCam16.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam16.TabIndex = 150;
            this.picGpsCam16.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 7);
            this.label4.TabIndex = 149;
            this.label4.Text = "22";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(323, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 7);
            this.label16.TabIndex = 148;
            this.label16.Text = "21";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(310, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 7);
            this.label17.TabIndex = 147;
            this.label17.Text = "20";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(297, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 7);
            this.label18.TabIndex = 146;
            this.label18.Text = "19";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(285, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 7);
            this.label19.TabIndex = 145;
            this.label19.Text = "18";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(271, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 7);
            this.label20.TabIndex = 144;
            this.label20.Text = "17";
            // 
            // lbl16
            // 
            this.lbl16.AutoSize = true;
            this.lbl16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl16.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl16.Location = new System.Drawing.Point(259, 8);
            this.lbl16.Name = "lbl16";
            this.lbl16.Size = new System.Drawing.Size(14, 7);
            this.lbl16.TabIndex = 143;
            this.lbl16.Text = "16";
            this.lbl16.Click += new System.EventHandler(this.lbl16_Click);
            // 
            // picRepCam22
            // 
            this.picRepCam22.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam22.Location = new System.Drawing.Point(339, 16);
            this.picRepCam22.Name = "picRepCam22";
            this.picRepCam22.Size = new System.Drawing.Size(11, 6);
            this.picRepCam22.TabIndex = 142;
            this.picRepCam22.TabStop = false;
            // 
            // picRepCam21
            // 
            this.picRepCam21.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam21.Location = new System.Drawing.Point(326, 16);
            this.picRepCam21.Name = "picRepCam21";
            this.picRepCam21.Size = new System.Drawing.Size(11, 6);
            this.picRepCam21.TabIndex = 141;
            this.picRepCam21.TabStop = false;
            // 
            // picRepCam20
            // 
            this.picRepCam20.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam20.Location = new System.Drawing.Point(313, 16);
            this.picRepCam20.Name = "picRepCam20";
            this.picRepCam20.Size = new System.Drawing.Size(11, 6);
            this.picRepCam20.TabIndex = 140;
            this.picRepCam20.TabStop = false;
            // 
            // picRepCam19
            // 
            this.picRepCam19.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam19.Location = new System.Drawing.Point(299, 16);
            this.picRepCam19.Name = "picRepCam19";
            this.picRepCam19.Size = new System.Drawing.Size(11, 6);
            this.picRepCam19.TabIndex = 139;
            this.picRepCam19.TabStop = false;
            // 
            // picRepCam18
            // 
            this.picRepCam18.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam18.Location = new System.Drawing.Point(286, 16);
            this.picRepCam18.Name = "picRepCam18";
            this.picRepCam18.Size = new System.Drawing.Size(11, 6);
            this.picRepCam18.TabIndex = 138;
            this.picRepCam18.TabStop = false;
            // 
            // picRepCam17
            // 
            this.picRepCam17.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam17.Location = new System.Drawing.Point(273, 16);
            this.picRepCam17.Name = "picRepCam17";
            this.picRepCam17.Size = new System.Drawing.Size(11, 6);
            this.picRepCam17.TabIndex = 137;
            this.picRepCam17.TabStop = false;
            // 
            // picRepCam16
            // 
            this.picRepCam16.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam16.Location = new System.Drawing.Point(261, 16);
            this.picRepCam16.Name = "picRepCam16";
            this.picRepCam16.Size = new System.Drawing.Size(11, 6);
            this.picRepCam16.TabIndex = 136;
            this.picRepCam16.TabStop = false;
            // 
            // lblCamPorc
            // 
            this.lblCamPorc.AutoSize = true;
            this.lblCamPorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamPorc.Location = new System.Drawing.Point(3, 9);
            this.lblCamPorc.Name = "lblCamPorc";
            this.lblCamPorc.Size = new System.Drawing.Size(28, 17);
            this.lblCamPorc.TabIndex = 135;
            this.lblCamPorc.Text = "0%";
            this.lblCamPorc.Visible = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(36, 7);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(22, 7);
            this.label31.TabIndex = 134;
            this.label31.Text = "Cam";
            // 
            // picGpsCam15
            // 
            this.picGpsCam15.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam15.Location = new System.Drawing.Point(248, 22);
            this.picGpsCam15.Name = "picGpsCam15";
            this.picGpsCam15.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam15.TabIndex = 133;
            this.picGpsCam15.TabStop = false;
            // 
            // picGpsCam14
            // 
            this.picGpsCam14.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam14.Location = new System.Drawing.Point(235, 22);
            this.picGpsCam14.Name = "picGpsCam14";
            this.picGpsCam14.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam14.TabIndex = 132;
            this.picGpsCam14.TabStop = false;
            // 
            // picGpsCam13
            // 
            this.picGpsCam13.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam13.Location = new System.Drawing.Point(221, 22);
            this.picGpsCam13.Name = "picGpsCam13";
            this.picGpsCam13.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam13.TabIndex = 131;
            this.picGpsCam13.TabStop = false;
            // 
            // picGpsCam12
            // 
            this.picGpsCam12.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam12.Location = new System.Drawing.Point(208, 22);
            this.picGpsCam12.Name = "picGpsCam12";
            this.picGpsCam12.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam12.TabIndex = 130;
            this.picGpsCam12.TabStop = false;
            // 
            // picGpsCam11
            // 
            this.picGpsCam11.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam11.Location = new System.Drawing.Point(195, 22);
            this.picGpsCam11.Name = "picGpsCam11";
            this.picGpsCam11.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam11.TabIndex = 129;
            this.picGpsCam11.TabStop = false;
            // 
            // picGpsCam10
            // 
            this.picGpsCam10.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam10.Location = new System.Drawing.Point(183, 22);
            this.picGpsCam10.Name = "picGpsCam10";
            this.picGpsCam10.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam10.TabIndex = 128;
            this.picGpsCam10.TabStop = false;
            // 
            // picGpsCam09
            // 
            this.picGpsCam09.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam09.Location = new System.Drawing.Point(170, 22);
            this.picGpsCam09.Name = "picGpsCam09";
            this.picGpsCam09.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam09.TabIndex = 127;
            this.picGpsCam09.TabStop = false;
            // 
            // picGpsCam08
            // 
            this.picGpsCam08.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam08.Location = new System.Drawing.Point(157, 22);
            this.picGpsCam08.Name = "picGpsCam08";
            this.picGpsCam08.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam08.TabIndex = 126;
            this.picGpsCam08.TabStop = false;
            // 
            // picGpsCam07
            // 
            this.picGpsCam07.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam07.Location = new System.Drawing.Point(144, 22);
            this.picGpsCam07.Name = "picGpsCam07";
            this.picGpsCam07.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam07.TabIndex = 125;
            this.picGpsCam07.TabStop = false;
            // 
            // picGpsCam06
            // 
            this.picGpsCam06.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam06.Location = new System.Drawing.Point(132, 22);
            this.picGpsCam06.Name = "picGpsCam06";
            this.picGpsCam06.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam06.TabIndex = 124;
            this.picGpsCam06.TabStop = false;
            // 
            // picGpsCam05
            // 
            this.picGpsCam05.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam05.Location = new System.Drawing.Point(119, 22);
            this.picGpsCam05.Name = "picGpsCam05";
            this.picGpsCam05.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam05.TabIndex = 123;
            this.picGpsCam05.TabStop = false;
            // 
            // lbl15
            // 
            this.lbl15.AutoSize = true;
            this.lbl15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl15.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl15.Location = new System.Drawing.Point(246, 8);
            this.lbl15.Name = "lbl15";
            this.lbl15.Size = new System.Drawing.Size(14, 7);
            this.lbl15.TabIndex = 122;
            this.lbl15.Text = "15";
            this.lbl15.Click += new System.EventHandler(this.lbl15_Click);
            // 
            // lbl14
            // 
            this.lbl14.AutoSize = true;
            this.lbl14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl14.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl14.Location = new System.Drawing.Point(233, 8);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(14, 7);
            this.lbl14.TabIndex = 121;
            this.lbl14.Text = "14";
            this.lbl14.Click += new System.EventHandler(this.lbl14_Click);
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl13.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl13.Location = new System.Drawing.Point(219, 8);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(14, 7);
            this.lbl13.TabIndex = 120;
            this.lbl13.Text = "13";
            this.lbl13.Click += new System.EventHandler(this.lbl13_Click);
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.Location = new System.Drawing.Point(206, 8);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(14, 7);
            this.lbl12.TabIndex = 119;
            this.lbl12.Text = "12";
            this.lbl12.Click += new System.EventHandler(this.lbl12_Click);
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.Location = new System.Drawing.Point(193, 8);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(14, 7);
            this.lbl11.TabIndex = 118;
            this.lbl11.Text = "11";
            this.lbl11.Click += new System.EventHandler(this.lbl11_Click);
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.Location = new System.Drawing.Point(180, 8);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(14, 7);
            this.lbl10.TabIndex = 117;
            this.lbl10.Text = "10";
            this.lbl10.Click += new System.EventHandler(this.lbl10_Click);
            // 
            // lbl09
            // 
            this.lbl09.AutoSize = true;
            this.lbl09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl09.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl09.Location = new System.Drawing.Point(171, 8);
            this.lbl09.Name = "lbl09";
            this.lbl09.Size = new System.Drawing.Size(9, 7);
            this.lbl09.TabIndex = 116;
            this.lbl09.Text = "9";
            this.lbl09.Click += new System.EventHandler(this.lbl09_Click);
            // 
            // lbl08
            // 
            this.lbl08.AutoSize = true;
            this.lbl08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl08.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl08.Location = new System.Drawing.Point(158, 8);
            this.lbl08.Name = "lbl08";
            this.lbl08.Size = new System.Drawing.Size(9, 7);
            this.lbl08.TabIndex = 115;
            this.lbl08.Text = "8";
            this.lbl08.Click += new System.EventHandler(this.lbl08_Click);
            // 
            // lbl07
            // 
            this.lbl07.AutoSize = true;
            this.lbl07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl07.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl07.Location = new System.Drawing.Point(145, 8);
            this.lbl07.Name = "lbl07";
            this.lbl07.Size = new System.Drawing.Size(9, 7);
            this.lbl07.TabIndex = 114;
            this.lbl07.Text = "7";
            this.lbl07.Click += new System.EventHandler(this.lbl07_Click);
            // 
            // lbl06
            // 
            this.lbl06.AutoSize = true;
            this.lbl06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl06.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl06.Location = new System.Drawing.Point(133, 8);
            this.lbl06.Name = "lbl06";
            this.lbl06.Size = new System.Drawing.Size(9, 7);
            this.lbl06.TabIndex = 113;
            this.lbl06.Text = "6";
            this.lbl06.Click += new System.EventHandler(this.lbl06_Click);
            // 
            // lbl05
            // 
            this.lbl05.AutoSize = true;
            this.lbl05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl05.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl05.Location = new System.Drawing.Point(119, 8);
            this.lbl05.Name = "lbl05";
            this.lbl05.Size = new System.Drawing.Size(9, 7);
            this.lbl05.TabIndex = 112;
            this.lbl05.Text = "5";
            this.lbl05.Click += new System.EventHandler(this.lbl05_Click);
            // 
            // picGpsCam04
            // 
            this.picGpsCam04.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam04.Location = new System.Drawing.Point(105, 22);
            this.picGpsCam04.Name = "picGpsCam04";
            this.picGpsCam04.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam04.TabIndex = 111;
            this.picGpsCam04.TabStop = false;
            // 
            // picGpsCam03
            // 
            this.picGpsCam03.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam03.Location = new System.Drawing.Point(92, 22);
            this.picGpsCam03.Name = "picGpsCam03";
            this.picGpsCam03.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam03.TabIndex = 110;
            this.picGpsCam03.TabStop = false;
            // 
            // picGpsCam02
            // 
            this.picGpsCam02.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam02.Location = new System.Drawing.Point(80, 22);
            this.picGpsCam02.Name = "picGpsCam02";
            this.picGpsCam02.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam02.TabIndex = 109;
            this.picGpsCam02.TabStop = false;
            // 
            // lbl04
            // 
            this.lbl04.AutoSize = true;
            this.lbl04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl04.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl04.Location = new System.Drawing.Point(107, 8);
            this.lbl04.Name = "lbl04";
            this.lbl04.Size = new System.Drawing.Size(9, 7);
            this.lbl04.TabIndex = 108;
            this.lbl04.Text = "4";
            this.lbl04.Click += new System.EventHandler(this.lbl04_Click);
            // 
            // lbl03
            // 
            this.lbl03.AutoSize = true;
            this.lbl03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl03.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl03.Location = new System.Drawing.Point(94, 8);
            this.lbl03.Name = "lbl03";
            this.lbl03.Size = new System.Drawing.Size(9, 7);
            this.lbl03.TabIndex = 107;
            this.lbl03.Text = "3";
            this.lbl03.Click += new System.EventHandler(this.lbl03_Click);
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl02.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl02.Location = new System.Drawing.Point(81, 8);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(9, 7);
            this.lbl02.TabIndex = 106;
            this.lbl02.Text = "2";
            this.lbl02.Click += new System.EventHandler(this.lbl02_Click);
            // 
            // picGpsCam01
            // 
            this.picGpsCam01.BackColor = System.Drawing.Color.Transparent;
            this.picGpsCam01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGpsCam01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGpsCam01.Location = new System.Drawing.Point(67, 22);
            this.picGpsCam01.Name = "picGpsCam01";
            this.picGpsCam01.Size = new System.Drawing.Size(11, 6);
            this.picGpsCam01.TabIndex = 105;
            this.picGpsCam01.TabStop = false;
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl01.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01.Location = new System.Drawing.Point(68, 8);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(9, 7);
            this.lbl01.TabIndex = 104;
            this.lbl01.Text = "1";
            this.lbl01.Click += new System.EventHandler(this.lbl01_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 7);
            this.label2.TabIndex = 103;
            this.label2.Text = "Gps";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 7);
            this.label1.TabIndex = 102;
            this.label1.Text = "Dato";
            // 
            // picRepCam15
            // 
            this.picRepCam15.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam15.Location = new System.Drawing.Point(248, 16);
            this.picRepCam15.Name = "picRepCam15";
            this.picRepCam15.Size = new System.Drawing.Size(11, 6);
            this.picRepCam15.TabIndex = 101;
            this.picRepCam15.TabStop = false;
            // 
            // picRepCam14
            // 
            this.picRepCam14.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam14.Location = new System.Drawing.Point(235, 16);
            this.picRepCam14.Name = "picRepCam14";
            this.picRepCam14.Size = new System.Drawing.Size(11, 6);
            this.picRepCam14.TabIndex = 100;
            this.picRepCam14.TabStop = false;
            // 
            // picRepCam13
            // 
            this.picRepCam13.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam13.Location = new System.Drawing.Point(221, 16);
            this.picRepCam13.Name = "picRepCam13";
            this.picRepCam13.Size = new System.Drawing.Size(11, 6);
            this.picRepCam13.TabIndex = 99;
            this.picRepCam13.TabStop = false;
            // 
            // picRepCam12
            // 
            this.picRepCam12.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam12.Location = new System.Drawing.Point(208, 16);
            this.picRepCam12.Name = "picRepCam12";
            this.picRepCam12.Size = new System.Drawing.Size(11, 6);
            this.picRepCam12.TabIndex = 98;
            this.picRepCam12.TabStop = false;
            // 
            // picRepCam11
            // 
            this.picRepCam11.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam11.Location = new System.Drawing.Point(195, 16);
            this.picRepCam11.Name = "picRepCam11";
            this.picRepCam11.Size = new System.Drawing.Size(11, 6);
            this.picRepCam11.TabIndex = 97;
            this.picRepCam11.TabStop = false;
            // 
            // picRepCam08
            // 
            this.picRepCam08.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam08.Location = new System.Drawing.Point(157, 16);
            this.picRepCam08.Name = "picRepCam08";
            this.picRepCam08.Size = new System.Drawing.Size(11, 6);
            this.picRepCam08.TabIndex = 98;
            this.picRepCam08.TabStop = false;
            // 
            // picRepCam10
            // 
            this.picRepCam10.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam10.Location = new System.Drawing.Point(183, 16);
            this.picRepCam10.Name = "picRepCam10";
            this.picRepCam10.Size = new System.Drawing.Size(11, 6);
            this.picRepCam10.TabIndex = 96;
            this.picRepCam10.TabStop = false;
            // 
            // picRepCam07
            // 
            this.picRepCam07.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam07.Location = new System.Drawing.Point(144, 16);
            this.picRepCam07.Name = "picRepCam07";
            this.picRepCam07.Size = new System.Drawing.Size(11, 6);
            this.picRepCam07.TabIndex = 97;
            this.picRepCam07.TabStop = false;
            // 
            // picRepCam09
            // 
            this.picRepCam09.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam09.Location = new System.Drawing.Point(170, 16);
            this.picRepCam09.Name = "picRepCam09";
            this.picRepCam09.Size = new System.Drawing.Size(11, 6);
            this.picRepCam09.TabIndex = 95;
            this.picRepCam09.TabStop = false;
            // 
            // picRepCam06
            // 
            this.picRepCam06.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam06.Location = new System.Drawing.Point(132, 16);
            this.picRepCam06.Name = "picRepCam06";
            this.picRepCam06.Size = new System.Drawing.Size(11, 6);
            this.picRepCam06.TabIndex = 96;
            this.picRepCam06.TabStop = false;
            // 
            // picRepCam05
            // 
            this.picRepCam05.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam05.Location = new System.Drawing.Point(119, 16);
            this.picRepCam05.Name = "picRepCam05";
            this.picRepCam05.Size = new System.Drawing.Size(11, 6);
            this.picRepCam05.TabIndex = 95;
            this.picRepCam05.TabStop = false;
            // 
            // picRepCam04
            // 
            this.picRepCam04.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam04.Location = new System.Drawing.Point(105, 16);
            this.picRepCam04.Name = "picRepCam04";
            this.picRepCam04.Size = new System.Drawing.Size(11, 6);
            this.picRepCam04.TabIndex = 94;
            this.picRepCam04.TabStop = false;
            // 
            // picRepCam03
            // 
            this.picRepCam03.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam03.Location = new System.Drawing.Point(92, 16);
            this.picRepCam03.Name = "picRepCam03";
            this.picRepCam03.Size = new System.Drawing.Size(11, 6);
            this.picRepCam03.TabIndex = 93;
            this.picRepCam03.TabStop = false;
            // 
            // picRepCam02
            // 
            this.picRepCam02.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam02.Location = new System.Drawing.Point(80, 16);
            this.picRepCam02.Name = "picRepCam02";
            this.picRepCam02.Size = new System.Drawing.Size(11, 6);
            this.picRepCam02.TabIndex = 92;
            this.picRepCam02.TabStop = false;
            // 
            // picCam14
            // 
            this.picCam14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam14.Image = ((System.Drawing.Image)(resources.GetObject("picCam14.Image")));
            this.picCam14.Location = new System.Drawing.Point(399, 37);
            this.picCam14.Name = "picCam14";
            this.picCam14.Size = new System.Drawing.Size(31, 24);
            this.picCam14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam14.TabIndex = 14;
            this.picCam14.TabStop = false;
            this.picCam14.Click += new System.EventHandler(this.picCam14_Click);
            // 
            // picCam15
            // 
            this.picCam15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam15.Image = ((System.Drawing.Image)(resources.GetObject("picCam15.Image")));
            this.picCam15.Location = new System.Drawing.Point(429, 37);
            this.picCam15.Name = "picCam15";
            this.picCam15.Size = new System.Drawing.Size(31, 24);
            this.picCam15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam15.TabIndex = 13;
            this.picCam15.TabStop = false;
            this.picCam15.Click += new System.EventHandler(this.picCam15_Click);
            // 
            // picRepCam01
            // 
            this.picRepCam01.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam01.Location = new System.Drawing.Point(67, 16);
            this.picRepCam01.Name = "picRepCam01";
            this.picRepCam01.Size = new System.Drawing.Size(11, 6);
            this.picRepCam01.TabIndex = 91;
            this.picRepCam01.TabStop = false;
            this.picRepCam01.Click += new System.EventHandler(this.picRepCam01_Click);
            // 
            // picCam13
            // 
            this.picCam13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam13.Image = ((System.Drawing.Image)(resources.GetObject("picCam13.Image")));
            this.picCam13.Location = new System.Drawing.Point(369, 37);
            this.picCam13.Name = "picCam13";
            this.picCam13.Size = new System.Drawing.Size(31, 24);
            this.picCam13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam13.TabIndex = 12;
            this.picCam13.TabStop = false;
            this.picCam13.Click += new System.EventHandler(this.picCam13_Click);
            // 
            // picCam11
            // 
            this.picCam11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam11.Image = ((System.Drawing.Image)(resources.GetObject("picCam11.Image")));
            this.picCam11.Location = new System.Drawing.Point(309, 37);
            this.picCam11.Name = "picCam11";
            this.picCam11.Size = new System.Drawing.Size(31, 24);
            this.picCam11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam11.TabIndex = 11;
            this.picCam11.TabStop = false;
            this.picCam11.Click += new System.EventHandler(this.picCam11_Click);
            // 
            // picCam12
            // 
            this.picCam12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam12.Image = ((System.Drawing.Image)(resources.GetObject("picCam12.Image")));
            this.picCam12.Location = new System.Drawing.Point(339, 37);
            this.picCam12.Name = "picCam12";
            this.picCam12.Size = new System.Drawing.Size(31, 24);
            this.picCam12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam12.TabIndex = 10;
            this.picCam12.TabStop = false;
            this.picCam12.Click += new System.EventHandler(this.picCam12_Click);
            // 
            // picCam10
            // 
            this.picCam10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam10.Image = ((System.Drawing.Image)(resources.GetObject("picCam10.Image")));
            this.picCam10.Location = new System.Drawing.Point(279, 37);
            this.picCam10.Name = "picCam10";
            this.picCam10.Size = new System.Drawing.Size(31, 24);
            this.picCam10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam10.TabIndex = 9;
            this.picCam10.TabStop = false;
            this.picCam10.Click += new System.EventHandler(this.picCam10_Click);
            // 
            // picCam08
            // 
            this.picCam08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam08.Image = ((System.Drawing.Image)(resources.GetObject("picCam08.Image")));
            this.picCam08.Location = new System.Drawing.Point(219, 37);
            this.picCam08.Name = "picCam08";
            this.picCam08.Size = new System.Drawing.Size(31, 24);
            this.picCam08.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam08.TabIndex = 8;
            this.picCam08.TabStop = false;
            this.picCam08.Click += new System.EventHandler(this.picCam08_Click);
            // 
            // picCam09
            // 
            this.picCam09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam09.Image = ((System.Drawing.Image)(resources.GetObject("picCam09.Image")));
            this.picCam09.Location = new System.Drawing.Point(249, 37);
            this.picCam09.Name = "picCam09";
            this.picCam09.Size = new System.Drawing.Size(31, 24);
            this.picCam09.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam09.TabIndex = 7;
            this.picCam09.TabStop = false;
            this.picCam09.Click += new System.EventHandler(this.picCam09_Click);
            // 
            // picCam07
            // 
            this.picCam07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam07.Image = ((System.Drawing.Image)(resources.GetObject("picCam07.Image")));
            this.picCam07.Location = new System.Drawing.Point(189, 37);
            this.picCam07.Name = "picCam07";
            this.picCam07.Size = new System.Drawing.Size(31, 24);
            this.picCam07.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam07.TabIndex = 6;
            this.picCam07.TabStop = false;
            this.picCam07.Click += new System.EventHandler(this.picCam07_Click);
            // 
            // picCam04
            // 
            this.picCam04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam04.Image = ((System.Drawing.Image)(resources.GetObject("picCam04.Image")));
            this.picCam04.Location = new System.Drawing.Point(99, 37);
            this.picCam04.Name = "picCam04";
            this.picCam04.Size = new System.Drawing.Size(31, 24);
            this.picCam04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam04.TabIndex = 5;
            this.picCam04.TabStop = false;
            this.picCam04.Click += new System.EventHandler(this.picCam04_Click);
            // 
            // picCam06
            // 
            this.picCam06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam06.Image = ((System.Drawing.Image)(resources.GetObject("picCam06.Image")));
            this.picCam06.Location = new System.Drawing.Point(159, 37);
            this.picCam06.Name = "picCam06";
            this.picCam06.Size = new System.Drawing.Size(31, 24);
            this.picCam06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam06.TabIndex = 4;
            this.picCam06.TabStop = false;
            this.picCam06.Click += new System.EventHandler(this.picCam06_Click);
            // 
            // picCam02
            // 
            this.picCam02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam02.Image = ((System.Drawing.Image)(resources.GetObject("picCam02.Image")));
            this.picCam02.Location = new System.Drawing.Point(39, 37);
            this.picCam02.Name = "picCam02";
            this.picCam02.Size = new System.Drawing.Size(31, 24);
            this.picCam02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam02.TabIndex = 3;
            this.picCam02.TabStop = false;
            this.picCam02.Click += new System.EventHandler(this.picCam02_Click);
            // 
            // picCam03
            // 
            this.picCam03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam03.Image = ((System.Drawing.Image)(resources.GetObject("picCam03.Image")));
            this.picCam03.Location = new System.Drawing.Point(69, 37);
            this.picCam03.Name = "picCam03";
            this.picCam03.Size = new System.Drawing.Size(31, 24);
            this.picCam03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam03.TabIndex = 2;
            this.picCam03.TabStop = false;
            this.picCam03.Click += new System.EventHandler(this.picCam03_Click);
            // 
            // picCam05
            // 
            this.picCam05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam05.Image = ((System.Drawing.Image)(resources.GetObject("picCam05.Image")));
            this.picCam05.Location = new System.Drawing.Point(129, 37);
            this.picCam05.Name = "picCam05";
            this.picCam05.Size = new System.Drawing.Size(31, 24);
            this.picCam05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam05.TabIndex = 1;
            this.picCam05.TabStop = false;
            this.picCam05.Click += new System.EventHandler(this.picCam05_Click);
            // 
            // picCam01
            // 
            this.picCam01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam01.Image = ((System.Drawing.Image)(resources.GetObject("picCam01.Image")));
            this.picCam01.Location = new System.Drawing.Point(7, 37);
            this.picCam01.Name = "picCam01";
            this.picCam01.Size = new System.Drawing.Size(31, 24);
            this.picCam01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam01.TabIndex = 0;
            this.picCam01.TabStop = false;
            this.picCam01.Click += new System.EventHandler(this.picCam01_Click);
            // 
            // panelDetalles
            // 
            this.panelDetalles.Controls.Add(this.labelDetalles);
            this.panelDetalles.Controls.Add(this.lblDetalles);
            this.panelDetalles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelDetalles.Location = new System.Drawing.Point(1200, 70);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(137, 206);
            this.panelDetalles.TabIndex = 90;
            this.panelDetalles.Visible = false;
            // 
            // labelDetalles
            // 
            this.labelDetalles.AutoSize = true;
            this.labelDetalles.BackColor = System.Drawing.Color.Transparent;
            this.labelDetalles.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalles.Location = new System.Drawing.Point(0, 0);
            this.labelDetalles.Name = "labelDetalles";
            this.labelDetalles.Size = new System.Drawing.Size(82, 25);
            this.labelDetalles.TabIndex = 89;
            this.labelDetalles.Text = "Detalles";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Location = new System.Drawing.Point(3, 40);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(69, 13);
            this.lblDetalles.TabIndex = 0;
            this.lblDetalles.Text = "Cantidades...";
            // 
            // timerReloj
            // 
            this.timerReloj.Enabled = true;
            this.timerReloj.Interval = 1000;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Transparent;
            this.chart3.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart3.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chart3.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chart3.Location = new System.Drawing.Point(218, 282);
            this.chart3.Name = "chart3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 4;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series5.Name = "Series2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series6.Name = "Series3";
            this.chart3.Series.Add(series4);
            this.chart3.Series.Add(series5);
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(66, 50);
            this.chart3.TabIndex = 91;
            this.chart3.Text = "chart3";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            title3.ForeColor = System.Drawing.Color.Transparent;
            title3.Name = "Title1";
            title3.Text = "Clasicos";
            this.chart3.Titles.Add(title3);
            this.chart3.Click += new System.EventHandler(this.chart3_Click);
            // 
            // chart4
            // 
            this.chart4.BackColor = System.Drawing.Color.Transparent;
            this.chart4.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart4.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chart4.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            this.chart4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chart4.Location = new System.Drawing.Point(216, 339);
            this.chart4.Name = "chart4";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series7.Name = "Series1";
            series7.YValuesPerPoint = 6;
            this.chart4.Series.Add(series7);
            this.chart4.Size = new System.Drawing.Size(70, 46);
            this.chart4.TabIndex = 92;
            this.chart4.Text = "chart4";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title4.ForeColor = System.Drawing.Color.Transparent;
            title4.Name = "Title1";
            title4.Text = "Ecologicos";
            this.chart4.Titles.Add(title4);
            this.chart4.Click += new System.EventHandler(this.chart4_Click);
            // 
            // splitContainerMapa
            // 
            this.splitContainerMapa.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerMapa.Location = new System.Drawing.Point(817, 70);
            this.splitContainerMapa.Name = "splitContainerMapa";
            this.splitContainerMapa.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMapa.Panel1
            // 
            this.splitContainerMapa.Panel1.Controls.Add(this.splitContainerMapas);
            // 
            // splitContainerMapa.Panel2
            // 
            this.splitContainerMapa.Panel2.AutoScroll = true;
            this.splitContainerMapa.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.splitContainerMapa.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerMapa_Panel2_Paint);
            this.splitContainerMapa.Size = new System.Drawing.Size(234, 363);
            this.splitContainerMapa.SplitterDistance = 278;
            this.splitContainerMapa.SplitterIncrement = 10;
            this.splitContainerMapa.SplitterWidth = 10;
            this.splitContainerMapa.TabIndex = 93;
            this.splitContainerMapa.Visible = false;
            // 
            // splitContainerMapas
            // 
            this.splitContainerMapas.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerMapas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMapas.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMapas.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerMapas.Name = "splitContainerMapas";
            this.splitContainerMapas.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMapas.Panel1
            // 
            this.splitContainerMapas.Panel1.Controls.Add(this.gMapControl2);
            // 
            // splitContainerMapas.Panel2
            // 
            this.splitContainerMapas.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerMapas.Panel2.Controls.Add(this.lblDetalleCabSinServir);
            this.splitContainerMapas.Panel2.Controls.Add(this.lblDetalleStatusTaller);
            this.splitContainerMapas.Panel2.Controls.Add(this.lblDetalleStatus);
            this.splitContainerMapas.Panel2.Controls.Add(this.gMapControl1);
            this.splitContainerMapas.Panel2.Controls.Add(this.panelActCamiones);
            this.splitContainerMapas.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainerMapas.Size = new System.Drawing.Size(234, 278);
            this.splitContainerMapas.SplitterDistance = 97;
            this.splitContainerMapas.SplitterWidth = 10;
            this.splitContainerMapas.TabIndex = 1;
            this.splitContainerMapas.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerMapas_SplitterMoved);
            // 
            // gMapControl2
            // 
            this.gMapControl2.BackColor = System.Drawing.Color.Transparent;
            this.gMapControl2.Bearing = 0F;
            this.gMapControl2.CanDragMap = true;
            this.gMapControl2.ContextMenuStrip = this.contextMenuStripMenu;
            this.gMapControl2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.gMapControl2.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl2.GrayScaleMode = false;
            this.gMapControl2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl2.LevelsKeepInMemmory = 5;
            this.gMapControl2.Location = new System.Drawing.Point(29, 12);
            this.gMapControl2.Margin = new System.Windows.Forms.Padding(0);
            this.gMapControl2.MarkersEnabled = true;
            this.gMapControl2.MaxZoom = 2;
            this.gMapControl2.MinZoom = 2;
            this.gMapControl2.MouseWheelZoomEnabled = true;
            this.gMapControl2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl2.Name = "gMapControl2";
            this.gMapControl2.NegativeMode = false;
            this.gMapControl2.PolygonsEnabled = true;
            this.gMapControl2.RetryLoadTile = 0;
            this.gMapControl2.RoutesEnabled = true;
            this.gMapControl2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl2.ShowTileGridLines = false;
            this.gMapControl2.Size = new System.Drawing.Size(15, 20);
            this.gMapControl2.TabIndex = 1;
            this.gMapControl2.Zoom = 0D;
            // 
            // lblDetalleCabSinServir
            // 
            this.lblDetalleCabSinServir.AutoSize = true;
            this.lblDetalleCabSinServir.BackColor = System.Drawing.Color.Black;
            this.lblDetalleCabSinServir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleCabSinServir.ForeColor = System.Drawing.Color.Lime;
            this.lblDetalleCabSinServir.Location = new System.Drawing.Point(21, 66);
            this.lblDetalleCabSinServir.Name = "lblDetalleCabSinServir";
            this.lblDetalleCabSinServir.Size = new System.Drawing.Size(43, 13);
            this.lblDetalleCabSinServir.TabIndex = 315;
            this.lblDetalleCabSinServir.Text = "Status: ";
            this.lblDetalleCabSinServir.Visible = false;
            // 
            // lblDetalleStatusTaller
            // 
            this.lblDetalleStatusTaller.AutoSize = true;
            this.lblDetalleStatusTaller.BackColor = System.Drawing.Color.Black;
            this.lblDetalleStatusTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleStatusTaller.ForeColor = System.Drawing.Color.Lime;
            this.lblDetalleStatusTaller.Location = new System.Drawing.Point(20, 36);
            this.lblDetalleStatusTaller.Name = "lblDetalleStatusTaller";
            this.lblDetalleStatusTaller.Size = new System.Drawing.Size(43, 13);
            this.lblDetalleStatusTaller.TabIndex = 314;
            this.lblDetalleStatusTaller.Text = "Status: ";
            this.lblDetalleStatusTaller.Visible = false;
            // 
            // lblDetalleStatus
            // 
            this.lblDetalleStatus.AutoSize = true;
            this.lblDetalleStatus.BackColor = System.Drawing.Color.Black;
            this.lblDetalleStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleStatus.ForeColor = System.Drawing.Color.Lime;
            this.lblDetalleStatus.Location = new System.Drawing.Point(20, 8);
            this.lblDetalleStatus.Name = "lblDetalleStatus";
            this.lblDetalleStatus.Size = new System.Drawing.Size(43, 13);
            this.lblDetalleStatus.TabIndex = 313;
            this.lblDetalleStatus.Text = "Status: ";
            this.lblDetalleStatus.Visible = false;
            // 
            // panelActCamiones
            // 
            this.panelActCamiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.panelActCamiones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActCamiones.Location = new System.Drawing.Point(0, 133);
            this.panelActCamiones.Name = "panelActCamiones";
            this.panelActCamiones.Size = new System.Drawing.Size(234, 38);
            this.panelActCamiones.TabIndex = 1;
            this.panelActCamiones.Visible = false;
            // 
            // panelIndicador01
            // 
            this.panelIndicador01.Location = new System.Drawing.Point(154, 345);
            this.panelIndicador01.Name = "panelIndicador01";
            this.panelIndicador01.Size = new System.Drawing.Size(35, 29);
            this.panelIndicador01.TabIndex = 0;
            this.panelIndicador01.Visible = false;
            this.panelIndicador01.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIndicador01_Paint);
            // 
            // panelCamion
            // 
            this.panelCamion.Controls.Add(this.lblpB28);
            this.panelCamion.Controls.Add(this.lblpBs28);
            this.panelCamion.Controls.Add(this.picBs28);
            this.panelCamion.Controls.Add(this.picRec28);
            this.panelCamion.Controls.Add(this.lblpBb28);
            this.panelCamion.Controls.Add(this.lblpBv28);
            this.panelCamion.Controls.Add(this.picGps2Cam28);
            this.panelCamion.Controls.Add(this.picRep2Cam28);
            this.panelCamion.Controls.Add(this.lblpB27);
            this.panelCamion.Controls.Add(this.lblpBs27);
            this.panelCamion.Controls.Add(this.picBs27);
            this.panelCamion.Controls.Add(this.picRec27);
            this.panelCamion.Controls.Add(this.lblpBb27);
            this.panelCamion.Controls.Add(this.lblpBv27);
            this.panelCamion.Controls.Add(this.picGps2Cam27);
            this.panelCamion.Controls.Add(this.picRep2Cam27);
            this.panelCamion.Controls.Add(this.lblpB26);
            this.panelCamion.Controls.Add(this.lblpBs26);
            this.panelCamion.Controls.Add(this.picBs26);
            this.panelCamion.Controls.Add(this.picRec26);
            this.panelCamion.Controls.Add(this.lblpBb26);
            this.panelCamion.Controls.Add(this.lblpBv26);
            this.panelCamion.Controls.Add(this.picGps2Cam26);
            this.panelCamion.Controls.Add(this.picRep2Cam26);
            this.panelCamion.Controls.Add(this.lblpB25);
            this.panelCamion.Controls.Add(this.lblpBs25);
            this.panelCamion.Controls.Add(this.picBs25);
            this.panelCamion.Controls.Add(this.picRec25);
            this.panelCamion.Controls.Add(this.lblpBb25);
            this.panelCamion.Controls.Add(this.lblpBv25);
            this.panelCamion.Controls.Add(this.picGps2Cam25);
            this.panelCamion.Controls.Add(this.picRep2Cam25);
            this.panelCamion.Controls.Add(this.lblpB24);
            this.panelCamion.Controls.Add(this.lblpBs24);
            this.panelCamion.Controls.Add(this.picBs24);
            this.panelCamion.Controls.Add(this.picRec24);
            this.panelCamion.Controls.Add(this.lblpBb24);
            this.panelCamion.Controls.Add(this.lblpBv24);
            this.panelCamion.Controls.Add(this.picGps2Cam24);
            this.panelCamion.Controls.Add(this.picRep2Cam24);
            this.panelCamion.Controls.Add(this.lblpB23);
            this.panelCamion.Controls.Add(this.lblpBs23);
            this.panelCamion.Controls.Add(this.picBs23);
            this.panelCamion.Controls.Add(this.picRec23);
            this.panelCamion.Controls.Add(this.lblpBb23);
            this.panelCamion.Controls.Add(this.lblpBv23);
            this.panelCamion.Controls.Add(this.picGps2Cam23);
            this.panelCamion.Controls.Add(this.picRep2Cam23);
            this.panelCamion.Controls.Add(this.lblpBv17);
            this.panelCamion.Controls.Add(this.lblpBv16);
            this.panelCamion.Controls.Add(this.lblpBb17);
            this.panelCamion.Controls.Add(this.picGps2Cam17);
            this.panelCamion.Controls.Add(this.lblpBs22);
            this.panelCamion.Controls.Add(this.picRep2Cam17);
            this.panelCamion.Controls.Add(this.lblpB22);
            this.panelCamion.Controls.Add(this.lblpB17);
            this.panelCamion.Controls.Add(this.lblpBs17);
            this.panelCamion.Controls.Add(this.lblpB21);
            this.panelCamion.Controls.Add(this.lblpB20);
            this.panelCamion.Controls.Add(this.lblpB19);
            this.panelCamion.Controls.Add(this.lblpB18);
            this.panelCamion.Controls.Add(this.lblpBs21);
            this.panelCamion.Controls.Add(this.lblpBs20);
            this.panelCamion.Controls.Add(this.picRec17);
            this.panelCamion.Controls.Add(this.lblpBs19);
            this.panelCamion.Controls.Add(this.picBs17);
            this.panelCamion.Controls.Add(this.lblpBs18);
            this.panelCamion.Controls.Add(this.picBs22);
            this.panelCamion.Controls.Add(this.picBs21);
            this.panelCamion.Controls.Add(this.picBs20);
            this.panelCamion.Controls.Add(this.picBs19);
            this.panelCamion.Controls.Add(this.picBs18);
            this.panelCamion.Controls.Add(this.picGps2Cam22);
            this.panelCamion.Controls.Add(this.picRec22);
            this.panelCamion.Controls.Add(this.lblpBv22);
            this.panelCamion.Controls.Add(this.lblpBb22);
            this.panelCamion.Controls.Add(this.picRep2Cam22);
            this.panelCamion.Controls.Add(this.picGps2Cam21);
            this.panelCamion.Controls.Add(this.picRep2Cam21);
            this.panelCamion.Controls.Add(this.picGps2Cam20);
            this.panelCamion.Controls.Add(this.picRep2Cam20);
            this.panelCamion.Controls.Add(this.picGps2Cam19);
            this.panelCamion.Controls.Add(this.picRec21);
            this.panelCamion.Controls.Add(this.picGps2Cam18);
            this.panelCamion.Controls.Add(this.picRep2Cam19);
            this.panelCamion.Controls.Add(this.picRec20);
            this.panelCamion.Controls.Add(this.picRec19);
            this.panelCamion.Controls.Add(this.picRep2Cam18);
            this.panelCamion.Controls.Add(this.picRec18);
            this.panelCamion.Controls.Add(this.lblpBv21);
            this.panelCamion.Controls.Add(this.lblpBv20);
            this.panelCamion.Controls.Add(this.lblpBv19);
            this.panelCamion.Controls.Add(this.lblpBv18);
            this.panelCamion.Controls.Add(this.lblpBb21);
            this.panelCamion.Controls.Add(this.lblpBb20);
            this.panelCamion.Controls.Add(this.lblpBb19);
            this.panelCamion.Controls.Add(this.lblpBb18);
            this.panelCamion.Controls.Add(this.label36);
            this.panelCamion.Controls.Add(this.label35);
            this.panelCamion.Controls.Add(this.label30);
            this.panelCamion.Controls.Add(this.lblRutaError);
            this.panelCamion.Controls.Add(this.listBoxRutaError);
            this.panelCamion.Controls.Add(this.label21);
            this.panelCamion.Controls.Add(this.lblpBs16);
            this.panelCamion.Controls.Add(this.lblpB16);
            this.panelCamion.Controls.Add(this.picGps2Cam16);
            this.panelCamion.Controls.Add(this.picBs16);
            this.panelCamion.Controls.Add(this.picRec16);
            this.panelCamion.Controls.Add(this.lblpBb16);
            this.panelCamion.Controls.Add(this.picRep2Cam16);
            this.panelCamion.Controls.Add(this.label28);
            this.panelCamion.Controls.Add(this.picGps2Cam15);
            this.panelCamion.Controls.Add(this.picRep2Cam15);
            this.panelCamion.Controls.Add(this.label29);
            this.panelCamion.Controls.Add(this.picGps2Cam14);
            this.panelCamion.Controls.Add(this.picRecLimpia);
            this.panelCamion.Controls.Add(this.picRep2Cam14);
            this.panelCamion.Controls.Add(this.picGps2Cam13);
            this.panelCamion.Controls.Add(this.picRec15);
            this.panelCamion.Controls.Add(this.picGps2Cam12);
            this.panelCamion.Controls.Add(this.picRep2Cam13);
            this.panelCamion.Controls.Add(this.picRec14);
            this.panelCamion.Controls.Add(this.picGps2Cam11);
            this.panelCamion.Controls.Add(this.picRec13);
            this.panelCamion.Controls.Add(this.picRep2Cam12);
            this.panelCamion.Controls.Add(this.picGps2Cam10);
            this.panelCamion.Controls.Add(this.picRec12);
            this.panelCamion.Controls.Add(this.picGps2Cam09);
            this.panelCamion.Controls.Add(this.picRep2Cam11);
            this.panelCamion.Controls.Add(this.picRec11);
            this.panelCamion.Controls.Add(this.picGps2Cam08);
            this.panelCamion.Controls.Add(this.picRec10);
            this.panelCamion.Controls.Add(this.picRep2Cam10);
            this.panelCamion.Controls.Add(this.picGps2Cam07);
            this.panelCamion.Controls.Add(this.picRec09);
            this.panelCamion.Controls.Add(this.picGps2Cam06);
            this.panelCamion.Controls.Add(this.picRep2Cam09);
            this.panelCamion.Controls.Add(this.picRec08);
            this.panelCamion.Controls.Add(this.picRep2Cam08);
            this.panelCamion.Controls.Add(this.picGps2Cam05);
            this.panelCamion.Controls.Add(this.picRec07);
            this.panelCamion.Controls.Add(this.picGps2Cam04);
            this.panelCamion.Controls.Add(this.picRec06);
            this.panelCamion.Controls.Add(this.picRep2Cam07);
            this.panelCamion.Controls.Add(this.picGps2Cam03);
            this.panelCamion.Controls.Add(this.picRec05);
            this.panelCamion.Controls.Add(this.picGps2Cam02);
            this.panelCamion.Controls.Add(this.picRec04);
            this.panelCamion.Controls.Add(this.picRep2Cam06);
            this.panelCamion.Controls.Add(this.picGps2Cam01);
            this.panelCamion.Controls.Add(this.picRec03);
            this.panelCamion.Controls.Add(this.picRec02);
            this.panelCamion.Controls.Add(this.picRep2Cam05);
            this.panelCamion.Controls.Add(this.picRec01);
            this.panelCamion.Controls.Add(this.picRep2Cam04);
            this.panelCamion.Controls.Add(this.picRep2Cam03);
            this.panelCamion.Controls.Add(this.picRep2Cam02);
            this.panelCamion.Controls.Add(this.picRep2Cam01);
            this.panelCamion.Controls.Add(this.lblpBv15);
            this.panelCamion.Controls.Add(this.lblpBv14);
            this.panelCamion.Controls.Add(this.lblpBv13);
            this.panelCamion.Controls.Add(this.lblpBv12);
            this.panelCamion.Controls.Add(this.lblpBv11);
            this.panelCamion.Controls.Add(this.lblpBv10);
            this.panelCamion.Controls.Add(this.lblpBv09);
            this.panelCamion.Controls.Add(this.lblpBv08);
            this.panelCamion.Controls.Add(this.lblpBv07);
            this.panelCamion.Controls.Add(this.lblpBv06);
            this.panelCamion.Controls.Add(this.lblpBv05);
            this.panelCamion.Controls.Add(this.lblpBv04);
            this.panelCamion.Controls.Add(this.lblpBv03);
            this.panelCamion.Controls.Add(this.lblpBv02);
            this.panelCamion.Controls.Add(this.lblpBv01);
            this.panelCamion.Controls.Add(this.label3);
            this.panelCamion.Controls.Add(this.label34);
            this.panelCamion.Controls.Add(this.label33);
            this.panelCamion.Controls.Add(this.lblpBb15);
            this.panelCamion.Controls.Add(this.lblpBb14);
            this.panelCamion.Controls.Add(this.lblpBb13);
            this.panelCamion.Controls.Add(this.lblpBb12);
            this.panelCamion.Controls.Add(this.lblpBb11);
            this.panelCamion.Controls.Add(this.lblpBb10);
            this.panelCamion.Controls.Add(this.lblpBb09);
            this.panelCamion.Controls.Add(this.lblpBb08);
            this.panelCamion.Controls.Add(this.lblpBb07);
            this.panelCamion.Controls.Add(this.lblpBb06);
            this.panelCamion.Controls.Add(this.lblpBb05);
            this.panelCamion.Controls.Add(this.lblpBb04);
            this.panelCamion.Controls.Add(this.lblpBb03);
            this.panelCamion.Controls.Add(this.lblpBb02);
            this.panelCamion.Controls.Add(this.lblpBb01);
            this.panelCamion.Controls.Add(this.label32);
            this.panelCamion.Controls.Add(this.picBs15);
            this.panelCamion.Controls.Add(this.picBs14);
            this.panelCamion.Controls.Add(this.picBs13);
            this.panelCamion.Controls.Add(this.picBs12);
            this.panelCamion.Controls.Add(this.picBs11);
            this.panelCamion.Controls.Add(this.picBs10);
            this.panelCamion.Controls.Add(this.picBs09);
            this.panelCamion.Controls.Add(this.picBs08);
            this.panelCamion.Controls.Add(this.picBs07);
            this.panelCamion.Controls.Add(this.picBs06);
            this.panelCamion.Controls.Add(this.picBs05);
            this.panelCamion.Controls.Add(this.picBs04);
            this.panelCamion.Controls.Add(this.picBs03);
            this.panelCamion.Controls.Add(this.picBs02);
            this.panelCamion.Controls.Add(this.picBs01);
            this.panelCamion.Controls.Add(this.lblpBs15);
            this.panelCamion.Controls.Add(this.lblpBs14);
            this.panelCamion.Controls.Add(this.lblpBs13);
            this.panelCamion.Controls.Add(this.lblpBs12);
            this.panelCamion.Controls.Add(this.lblpBs11);
            this.panelCamion.Controls.Add(this.lblpBs10);
            this.panelCamion.Controls.Add(this.lblpBs09);
            this.panelCamion.Controls.Add(this.lblpBs08);
            this.panelCamion.Controls.Add(this.lblpBs07);
            this.panelCamion.Controls.Add(this.lblpBs06);
            this.panelCamion.Controls.Add(this.lblpBs05);
            this.panelCamion.Controls.Add(this.lblpBs04);
            this.panelCamion.Controls.Add(this.lblpBs03);
            this.panelCamion.Controls.Add(this.lblpBs02);
            this.panelCamion.Controls.Add(this.lblpBs01);
            this.panelCamion.Controls.Add(this.lblpB15);
            this.panelCamion.Controls.Add(this.lblpB14);
            this.panelCamion.Controls.Add(this.lblpB13);
            this.panelCamion.Controls.Add(this.lblpB12);
            this.panelCamion.Controls.Add(this.lblpB11);
            this.panelCamion.Controls.Add(this.lblpB10);
            this.panelCamion.Controls.Add(this.lblpB09);
            this.panelCamion.Controls.Add(this.lblpB08);
            this.panelCamion.Controls.Add(this.lblpB07);
            this.panelCamion.Controls.Add(this.lblpB06);
            this.panelCamion.Controls.Add(this.lblpB05);
            this.panelCamion.Controls.Add(this.lblpB04);
            this.panelCamion.Controls.Add(this.lblpB03);
            this.panelCamion.Controls.Add(this.lblpB02);
            this.panelCamion.Controls.Add(this.lblpB01);
            this.panelCamion.Location = new System.Drawing.Point(671, 84);
            this.panelCamion.Name = "panelCamion";
            this.panelCamion.Size = new System.Drawing.Size(87, 77);
            this.panelCamion.TabIndex = 94;
            this.panelCamion.Visible = false;
            this.panelCamion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCamion_Paint);
            // 
            // lblpB28
            // 
            this.lblpB28.AutoSize = true;
            this.lblpB28.BackColor = System.Drawing.Color.Transparent;
            this.lblpB28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB28.Location = new System.Drawing.Point(345, 460);
            this.lblpB28.Name = "lblpB28";
            this.lblpB28.Size = new System.Drawing.Size(18, 9);
            this.lblpB28.TabIndex = 346;
            this.lblpB28.Text = "0 %";
            this.lblpB28.Visible = false;
            // 
            // lblpBs28
            // 
            this.lblpBs28.AutoSize = true;
            this.lblpBs28.Location = new System.Drawing.Point(320, 455);
            this.lblpBs28.Name = "lblpBs28";
            this.lblpBs28.Size = new System.Drawing.Size(13, 13);
            this.lblpBs28.TabIndex = 345;
            this.lblpBs28.Text = "0";
            this.lblpBs28.Visible = false;
            // 
            // picBs28
            // 
            this.picBs28.BackColor = System.Drawing.Color.Transparent;
            this.picBs28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs28.Location = new System.Drawing.Point(283, 461);
            this.picBs28.Name = "picBs28";
            this.picBs28.Size = new System.Drawing.Size(10, 9);
            this.picBs28.TabIndex = 344;
            this.picBs28.TabStop = false;
            // 
            // picRec28
            // 
            this.picRec28.BackColor = System.Drawing.Color.Transparent;
            this.picRec28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec28.Image = ((System.Drawing.Image)(resources.GetObject("picRec28.Image")));
            this.picRec28.Location = new System.Drawing.Point(246, 458);
            this.picRec28.Name = "picRec28";
            this.picRec28.Size = new System.Drawing.Size(20, 12);
            this.picRec28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec28.TabIndex = 343;
            this.picRec28.TabStop = false;
            // 
            // lblpBb28
            // 
            this.lblpBb28.AutoSize = true;
            this.lblpBb28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb28.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb28.Location = new System.Drawing.Point(151, 456);
            this.lblpBb28.Name = "lblpBb28";
            this.lblpBb28.Size = new System.Drawing.Size(11, 12);
            this.lblpBb28.TabIndex = 342;
            this.lblpBb28.Text = "0";
            // 
            // lblpBv28
            // 
            this.lblpBv28.AutoSize = true;
            this.lblpBv28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv28.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv28.Location = new System.Drawing.Point(121, 456);
            this.lblpBv28.Name = "lblpBv28";
            this.lblpBv28.Size = new System.Drawing.Size(11, 12);
            this.lblpBv28.TabIndex = 341;
            this.lblpBv28.Text = "0";
            // 
            // picGps2Cam28
            // 
            this.picGps2Cam28.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam28.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam28.Image")));
            this.picGps2Cam28.Location = new System.Drawing.Point(46, 456);
            this.picGps2Cam28.Name = "picGps2Cam28";
            this.picGps2Cam28.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam28.TabIndex = 340;
            this.picGps2Cam28.TabStop = false;
            // 
            // picRep2Cam28
            // 
            this.picRep2Cam28.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam28.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam28.Image")));
            this.picRep2Cam28.Location = new System.Drawing.Point(24, 458);
            this.picRep2Cam28.Name = "picRep2Cam28";
            this.picRep2Cam28.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam28.TabIndex = 339;
            this.picRep2Cam28.TabStop = false;
            this.picRep2Cam28.Click += new System.EventHandler(this.pictureBox24_Click);
            // 
            // lblpB27
            // 
            this.lblpB27.AutoSize = true;
            this.lblpB27.BackColor = System.Drawing.Color.Transparent;
            this.lblpB27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB27.Location = new System.Drawing.Point(345, 405);
            this.lblpB27.Name = "lblpB27";
            this.lblpB27.Size = new System.Drawing.Size(18, 9);
            this.lblpB27.TabIndex = 337;
            this.lblpB27.Text = "0 %";
            this.lblpB27.Visible = false;
            // 
            // lblpBs27
            // 
            this.lblpBs27.AutoSize = true;
            this.lblpBs27.Location = new System.Drawing.Point(320, 400);
            this.lblpBs27.Name = "lblpBs27";
            this.lblpBs27.Size = new System.Drawing.Size(13, 13);
            this.lblpBs27.TabIndex = 336;
            this.lblpBs27.Text = "0";
            this.lblpBs27.Visible = false;
            // 
            // picBs27
            // 
            this.picBs27.BackColor = System.Drawing.Color.Transparent;
            this.picBs27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs27.Location = new System.Drawing.Point(283, 406);
            this.picBs27.Name = "picBs27";
            this.picBs27.Size = new System.Drawing.Size(10, 9);
            this.picBs27.TabIndex = 335;
            this.picBs27.TabStop = false;
            // 
            // picRec27
            // 
            this.picRec27.BackColor = System.Drawing.Color.Transparent;
            this.picRec27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec27.Image = ((System.Drawing.Image)(resources.GetObject("picRec27.Image")));
            this.picRec27.Location = new System.Drawing.Point(246, 403);
            this.picRec27.Name = "picRec27";
            this.picRec27.Size = new System.Drawing.Size(20, 12);
            this.picRec27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec27.TabIndex = 334;
            this.picRec27.TabStop = false;
            // 
            // lblpBb27
            // 
            this.lblpBb27.AutoSize = true;
            this.lblpBb27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb27.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb27.Location = new System.Drawing.Point(151, 401);
            this.lblpBb27.Name = "lblpBb27";
            this.lblpBb27.Size = new System.Drawing.Size(11, 12);
            this.lblpBb27.TabIndex = 333;
            this.lblpBb27.Text = "0";
            // 
            // lblpBv27
            // 
            this.lblpBv27.AutoSize = true;
            this.lblpBv27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv27.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv27.Location = new System.Drawing.Point(121, 402);
            this.lblpBv27.Name = "lblpBv27";
            this.lblpBv27.Size = new System.Drawing.Size(11, 12);
            this.lblpBv27.TabIndex = 332;
            this.lblpBv27.Text = "0";
            // 
            // picGps2Cam27
            // 
            this.picGps2Cam27.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam27.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam27.Image")));
            this.picGps2Cam27.Location = new System.Drawing.Point(46, 402);
            this.picGps2Cam27.Name = "picGps2Cam27";
            this.picGps2Cam27.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam27.TabIndex = 331;
            this.picGps2Cam27.TabStop = false;
            // 
            // picRep2Cam27
            // 
            this.picRep2Cam27.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam27.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam27.Image")));
            this.picRep2Cam27.Location = new System.Drawing.Point(24, 404);
            this.picRep2Cam27.Name = "picRep2Cam27";
            this.picRep2Cam27.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam27.TabIndex = 330;
            this.picRep2Cam27.TabStop = false;
            // 
            // lblpB26
            // 
            this.lblpB26.AutoSize = true;
            this.lblpB26.BackColor = System.Drawing.Color.Transparent;
            this.lblpB26.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB26.Location = new System.Drawing.Point(345, 393);
            this.lblpB26.Name = "lblpB26";
            this.lblpB26.Size = new System.Drawing.Size(18, 9);
            this.lblpB26.TabIndex = 328;
            this.lblpB26.Text = "0 %";
            this.lblpB26.Visible = false;
            // 
            // lblpBs26
            // 
            this.lblpBs26.AutoSize = true;
            this.lblpBs26.Location = new System.Drawing.Point(320, 388);
            this.lblpBs26.Name = "lblpBs26";
            this.lblpBs26.Size = new System.Drawing.Size(13, 13);
            this.lblpBs26.TabIndex = 327;
            this.lblpBs26.Text = "0";
            this.lblpBs26.Visible = false;
            // 
            // picBs26
            // 
            this.picBs26.BackColor = System.Drawing.Color.Transparent;
            this.picBs26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs26.Location = new System.Drawing.Point(283, 394);
            this.picBs26.Name = "picBs26";
            this.picBs26.Size = new System.Drawing.Size(10, 9);
            this.picBs26.TabIndex = 326;
            this.picBs26.TabStop = false;
            // 
            // picRec26
            // 
            this.picRec26.BackColor = System.Drawing.Color.Transparent;
            this.picRec26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec26.Image = ((System.Drawing.Image)(resources.GetObject("picRec26.Image")));
            this.picRec26.Location = new System.Drawing.Point(246, 391);
            this.picRec26.Name = "picRec26";
            this.picRec26.Size = new System.Drawing.Size(20, 12);
            this.picRec26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec26.TabIndex = 325;
            this.picRec26.TabStop = false;
            // 
            // lblpBb26
            // 
            this.lblpBb26.AutoSize = true;
            this.lblpBb26.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb26.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb26.Location = new System.Drawing.Point(151, 389);
            this.lblpBb26.Name = "lblpBb26";
            this.lblpBb26.Size = new System.Drawing.Size(11, 12);
            this.lblpBb26.TabIndex = 324;
            this.lblpBb26.Text = "0";
            // 
            // lblpBv26
            // 
            this.lblpBv26.AutoSize = true;
            this.lblpBv26.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv26.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv26.Location = new System.Drawing.Point(121, 389);
            this.lblpBv26.Name = "lblpBv26";
            this.lblpBv26.Size = new System.Drawing.Size(11, 12);
            this.lblpBv26.TabIndex = 323;
            this.lblpBv26.Text = "0";
            // 
            // picGps2Cam26
            // 
            this.picGps2Cam26.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam26.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam26.Image")));
            this.picGps2Cam26.Location = new System.Drawing.Point(46, 389);
            this.picGps2Cam26.Name = "picGps2Cam26";
            this.picGps2Cam26.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam26.TabIndex = 322;
            this.picGps2Cam26.TabStop = false;
            // 
            // picRep2Cam26
            // 
            this.picRep2Cam26.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam26.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam26.Image")));
            this.picRep2Cam26.Location = new System.Drawing.Point(24, 391);
            this.picRep2Cam26.Name = "picRep2Cam26";
            this.picRep2Cam26.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam26.TabIndex = 321;
            this.picRep2Cam26.TabStop = false;
            // 
            // lblpB25
            // 
            this.lblpB25.AutoSize = true;
            this.lblpB25.BackColor = System.Drawing.Color.Transparent;
            this.lblpB25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB25.Location = new System.Drawing.Point(345, 380);
            this.lblpB25.Name = "lblpB25";
            this.lblpB25.Size = new System.Drawing.Size(18, 9);
            this.lblpB25.TabIndex = 319;
            this.lblpB25.Text = "0 %";
            this.lblpB25.Visible = false;
            // 
            // lblpBs25
            // 
            this.lblpBs25.AutoSize = true;
            this.lblpBs25.Location = new System.Drawing.Point(320, 375);
            this.lblpBs25.Name = "lblpBs25";
            this.lblpBs25.Size = new System.Drawing.Size(13, 13);
            this.lblpBs25.TabIndex = 318;
            this.lblpBs25.Text = "0";
            this.lblpBs25.Visible = false;
            // 
            // picBs25
            // 
            this.picBs25.BackColor = System.Drawing.Color.Transparent;
            this.picBs25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs25.Location = new System.Drawing.Point(283, 381);
            this.picBs25.Name = "picBs25";
            this.picBs25.Size = new System.Drawing.Size(10, 9);
            this.picBs25.TabIndex = 317;
            this.picBs25.TabStop = false;
            // 
            // picRec25
            // 
            this.picRec25.BackColor = System.Drawing.Color.Transparent;
            this.picRec25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec25.Image = ((System.Drawing.Image)(resources.GetObject("picRec25.Image")));
            this.picRec25.Location = new System.Drawing.Point(246, 378);
            this.picRec25.Name = "picRec25";
            this.picRec25.Size = new System.Drawing.Size(20, 12);
            this.picRec25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec25.TabIndex = 316;
            this.picRec25.TabStop = false;
            // 
            // lblpBb25
            // 
            this.lblpBb25.AutoSize = true;
            this.lblpBb25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb25.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb25.Location = new System.Drawing.Point(151, 376);
            this.lblpBb25.Name = "lblpBb25";
            this.lblpBb25.Size = new System.Drawing.Size(11, 12);
            this.lblpBb25.TabIndex = 315;
            this.lblpBb25.Text = "0";
            // 
            // lblpBv25
            // 
            this.lblpBv25.AutoSize = true;
            this.lblpBv25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv25.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv25.Location = new System.Drawing.Point(121, 376);
            this.lblpBv25.Name = "lblpBv25";
            this.lblpBv25.Size = new System.Drawing.Size(11, 12);
            this.lblpBv25.TabIndex = 314;
            this.lblpBv25.Text = "0";
            // 
            // picGps2Cam25
            // 
            this.picGps2Cam25.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam25.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam25.Image")));
            this.picGps2Cam25.Location = new System.Drawing.Point(46, 376);
            this.picGps2Cam25.Name = "picGps2Cam25";
            this.picGps2Cam25.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam25.TabIndex = 313;
            this.picGps2Cam25.TabStop = false;
            // 
            // picRep2Cam25
            // 
            this.picRep2Cam25.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam25.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam25.Image")));
            this.picRep2Cam25.Location = new System.Drawing.Point(24, 378);
            this.picRep2Cam25.Name = "picRep2Cam25";
            this.picRep2Cam25.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam25.TabIndex = 312;
            this.picRep2Cam25.TabStop = false;
            // 
            // lblpB24
            // 
            this.lblpB24.AutoSize = true;
            this.lblpB24.BackColor = System.Drawing.Color.Transparent;
            this.lblpB24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB24.Location = new System.Drawing.Point(347, 353);
            this.lblpB24.Name = "lblpB24";
            this.lblpB24.Size = new System.Drawing.Size(18, 9);
            this.lblpB24.TabIndex = 310;
            this.lblpB24.Text = "0 %";
            this.lblpB24.Visible = false;
            // 
            // lblpBs24
            // 
            this.lblpBs24.AutoSize = true;
            this.lblpBs24.Location = new System.Drawing.Point(322, 348);
            this.lblpBs24.Name = "lblpBs24";
            this.lblpBs24.Size = new System.Drawing.Size(13, 13);
            this.lblpBs24.TabIndex = 309;
            this.lblpBs24.Text = "0";
            this.lblpBs24.Visible = false;
            // 
            // picBs24
            // 
            this.picBs24.BackColor = System.Drawing.Color.Transparent;
            this.picBs24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs24.Location = new System.Drawing.Point(285, 354);
            this.picBs24.Name = "picBs24";
            this.picBs24.Size = new System.Drawing.Size(10, 9);
            this.picBs24.TabIndex = 308;
            this.picBs24.TabStop = false;
            // 
            // picRec24
            // 
            this.picRec24.BackColor = System.Drawing.Color.Transparent;
            this.picRec24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec24.Image = ((System.Drawing.Image)(resources.GetObject("picRec24.Image")));
            this.picRec24.Location = new System.Drawing.Point(248, 351);
            this.picRec24.Name = "picRec24";
            this.picRec24.Size = new System.Drawing.Size(20, 12);
            this.picRec24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec24.TabIndex = 307;
            this.picRec24.TabStop = false;
            // 
            // lblpBb24
            // 
            this.lblpBb24.AutoSize = true;
            this.lblpBb24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb24.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb24.Location = new System.Drawing.Point(153, 349);
            this.lblpBb24.Name = "lblpBb24";
            this.lblpBb24.Size = new System.Drawing.Size(11, 12);
            this.lblpBb24.TabIndex = 306;
            this.lblpBb24.Text = "0";
            // 
            // lblpBv24
            // 
            this.lblpBv24.AutoSize = true;
            this.lblpBv24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv24.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv24.Location = new System.Drawing.Point(123, 350);
            this.lblpBv24.Name = "lblpBv24";
            this.lblpBv24.Size = new System.Drawing.Size(11, 12);
            this.lblpBv24.TabIndex = 305;
            this.lblpBv24.Text = "0";
            // 
            // picGps2Cam24
            // 
            this.picGps2Cam24.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam24.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam24.Image")));
            this.picGps2Cam24.Location = new System.Drawing.Point(48, 350);
            this.picGps2Cam24.Name = "picGps2Cam24";
            this.picGps2Cam24.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam24.TabIndex = 304;
            this.picGps2Cam24.TabStop = false;
            // 
            // picRep2Cam24
            // 
            this.picRep2Cam24.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam24.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam24.Image")));
            this.picRep2Cam24.Location = new System.Drawing.Point(26, 352);
            this.picRep2Cam24.Name = "picRep2Cam24";
            this.picRep2Cam24.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam24.TabIndex = 303;
            this.picRep2Cam24.TabStop = false;
            // 
            // lblpB23
            // 
            this.lblpB23.AutoSize = true;
            this.lblpB23.BackColor = System.Drawing.Color.Transparent;
            this.lblpB23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB23.Location = new System.Drawing.Point(356, 326);
            this.lblpB23.Name = "lblpB23";
            this.lblpB23.Size = new System.Drawing.Size(18, 9);
            this.lblpB23.TabIndex = 301;
            this.lblpB23.Text = "0 %";
            this.lblpB23.Visible = false;
            // 
            // lblpBs23
            // 
            this.lblpBs23.AutoSize = true;
            this.lblpBs23.Location = new System.Drawing.Point(327, 331);
            this.lblpBs23.Name = "lblpBs23";
            this.lblpBs23.Size = new System.Drawing.Size(13, 13);
            this.lblpBs23.TabIndex = 300;
            this.lblpBs23.Text = "0";
            this.lblpBs23.Visible = false;
            // 
            // picBs23
            // 
            this.picBs23.BackColor = System.Drawing.Color.Transparent;
            this.picBs23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs23.Location = new System.Drawing.Point(285, 334);
            this.picBs23.Name = "picBs23";
            this.picBs23.Size = new System.Drawing.Size(10, 9);
            this.picBs23.TabIndex = 299;
            this.picBs23.TabStop = false;
            // 
            // picRec23
            // 
            this.picRec23.BackColor = System.Drawing.Color.Transparent;
            this.picRec23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec23.Image = ((System.Drawing.Image)(resources.GetObject("picRec23.Image")));
            this.picRec23.Location = new System.Drawing.Point(248, 334);
            this.picRec23.Name = "picRec23";
            this.picRec23.Size = new System.Drawing.Size(20, 12);
            this.picRec23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec23.TabIndex = 298;
            this.picRec23.TabStop = false;
            this.picRec23.Click += new System.EventHandler(this.picRec23_Click);
            this.picRec23.MouseLeave += new System.EventHandler(this.picRec23_MouseLeave);
            this.picRec23.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec23_MouseMove);
            // 
            // lblpBb23
            // 
            this.lblpBb23.AutoSize = true;
            this.lblpBb23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb23.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb23.Location = new System.Drawing.Point(153, 337);
            this.lblpBb23.Name = "lblpBb23";
            this.lblpBb23.Size = new System.Drawing.Size(11, 12);
            this.lblpBb23.TabIndex = 297;
            this.lblpBb23.Text = "0";
            // 
            // lblpBv23
            // 
            this.lblpBv23.AutoSize = true;
            this.lblpBv23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv23.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv23.Location = new System.Drawing.Point(123, 335);
            this.lblpBv23.Name = "lblpBv23";
            this.lblpBv23.Size = new System.Drawing.Size(11, 12);
            this.lblpBv23.TabIndex = 296;
            this.lblpBv23.Text = "0";
            // 
            // picGps2Cam23
            // 
            this.picGps2Cam23.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam23.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam23.Image")));
            this.picGps2Cam23.Location = new System.Drawing.Point(46, 336);
            this.picGps2Cam23.Name = "picGps2Cam23";
            this.picGps2Cam23.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam23.TabIndex = 295;
            this.picGps2Cam23.TabStop = false;
            // 
            // picRep2Cam23
            // 
            this.picRep2Cam23.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam23.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam23.Image")));
            this.picRep2Cam23.Location = new System.Drawing.Point(25, 338);
            this.picRep2Cam23.Name = "picRep2Cam23";
            this.picRep2Cam23.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam23.TabIndex = 294;
            this.picRep2Cam23.TabStop = false;
            // 
            // lblpBv17
            // 
            this.lblpBv17.AutoSize = true;
            this.lblpBv17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv17.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv17.Location = new System.Drawing.Point(123, 254);
            this.lblpBv17.Name = "lblpBv17";
            this.lblpBv17.Size = new System.Drawing.Size(11, 12);
            this.lblpBv17.TabIndex = 235;
            this.lblpBv17.Text = "0";
            // 
            // lblpBv16
            // 
            this.lblpBv16.AutoSize = true;
            this.lblpBv16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv16.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv16.Location = new System.Drawing.Point(123, 239);
            this.lblpBv16.Name = "lblpBv16";
            this.lblpBv16.Size = new System.Drawing.Size(11, 12);
            this.lblpBv16.TabIndex = 174;
            this.lblpBv16.Text = "0";
            // 
            // lblpBb17
            // 
            this.lblpBb17.AutoSize = true;
            this.lblpBb17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb17.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb17.Location = new System.Drawing.Point(153, 254);
            this.lblpBb17.Name = "lblpBb17";
            this.lblpBb17.Size = new System.Drawing.Size(11, 12);
            this.lblpBb17.TabIndex = 230;
            this.lblpBb17.Text = "0";
            // 
            // picGps2Cam17
            // 
            this.picGps2Cam17.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam17.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam17.Image")));
            this.picGps2Cam17.Location = new System.Drawing.Point(48, 256);
            this.picGps2Cam17.Name = "picGps2Cam17";
            this.picGps2Cam17.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam17.TabIndex = 256;
            this.picGps2Cam17.TabStop = false;
            // 
            // lblpBs22
            // 
            this.lblpBs22.AutoSize = true;
            this.lblpBs22.Location = new System.Drawing.Point(327, 318);
            this.lblpBs22.Name = "lblpBs22";
            this.lblpBs22.Size = new System.Drawing.Size(13, 13);
            this.lblpBs22.TabIndex = 292;
            this.lblpBs22.Text = "0";
            this.lblpBs22.Visible = false;
            // 
            // picRep2Cam17
            // 
            this.picRep2Cam17.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam17.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam17.Image")));
            this.picRep2Cam17.Location = new System.Drawing.Point(26, 256);
            this.picRep2Cam17.Name = "picRep2Cam17";
            this.picRep2Cam17.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam17.TabIndex = 244;
            this.picRep2Cam17.TabStop = false;
            // 
            // lblpB22
            // 
            this.lblpB22.AutoSize = true;
            this.lblpB22.BackColor = System.Drawing.Color.Transparent;
            this.lblpB22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB22.Location = new System.Drawing.Point(356, 311);
            this.lblpB22.Name = "lblpB22";
            this.lblpB22.Size = new System.Drawing.Size(18, 9);
            this.lblpB22.TabIndex = 291;
            this.lblpB22.Text = "0 %";
            this.lblpB22.Visible = false;
            // 
            // lblpB17
            // 
            this.lblpB17.AutoSize = true;
            this.lblpB17.BackColor = System.Drawing.Color.Transparent;
            this.lblpB17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB17.Location = new System.Drawing.Point(356, 244);
            this.lblpB17.Name = "lblpB17";
            this.lblpB17.Size = new System.Drawing.Size(18, 9);
            this.lblpB17.TabIndex = 286;
            this.lblpB17.Text = "0 %";
            this.lblpB17.Visible = false;
            // 
            // lblpBs17
            // 
            this.lblpBs17.AutoSize = true;
            this.lblpBs17.Location = new System.Drawing.Point(327, 244);
            this.lblpBs17.Name = "lblpBs17";
            this.lblpBs17.Size = new System.Drawing.Size(13, 13);
            this.lblpBs17.TabIndex = 281;
            this.lblpBs17.Text = "0";
            this.lblpBs17.Visible = false;
            // 
            // lblpB21
            // 
            this.lblpB21.AutoSize = true;
            this.lblpB21.BackColor = System.Drawing.Color.Transparent;
            this.lblpB21.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB21.Location = new System.Drawing.Point(356, 297);
            this.lblpB21.Name = "lblpB21";
            this.lblpB21.Size = new System.Drawing.Size(18, 9);
            this.lblpB21.TabIndex = 290;
            this.lblpB21.Text = "0 %";
            this.lblpB21.Visible = false;
            // 
            // lblpB20
            // 
            this.lblpB20.AutoSize = true;
            this.lblpB20.BackColor = System.Drawing.Color.Transparent;
            this.lblpB20.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB20.Location = new System.Drawing.Point(356, 284);
            this.lblpB20.Name = "lblpB20";
            this.lblpB20.Size = new System.Drawing.Size(18, 9);
            this.lblpB20.TabIndex = 289;
            this.lblpB20.Text = "0 %";
            this.lblpB20.Visible = false;
            // 
            // lblpB19
            // 
            this.lblpB19.AutoSize = true;
            this.lblpB19.BackColor = System.Drawing.Color.Transparent;
            this.lblpB19.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB19.Location = new System.Drawing.Point(356, 271);
            this.lblpB19.Name = "lblpB19";
            this.lblpB19.Size = new System.Drawing.Size(18, 9);
            this.lblpB19.TabIndex = 288;
            this.lblpB19.Text = "0 %";
            this.lblpB19.Visible = false;
            // 
            // lblpB18
            // 
            this.lblpB18.AutoSize = true;
            this.lblpB18.BackColor = System.Drawing.Color.Transparent;
            this.lblpB18.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB18.Location = new System.Drawing.Point(356, 258);
            this.lblpB18.Name = "lblpB18";
            this.lblpB18.Size = new System.Drawing.Size(18, 9);
            this.lblpB18.TabIndex = 287;
            this.lblpB18.Text = "0 %";
            this.lblpB18.Visible = false;
            // 
            // lblpBs21
            // 
            this.lblpBs21.AutoSize = true;
            this.lblpBs21.Location = new System.Drawing.Point(327, 303);
            this.lblpBs21.Name = "lblpBs21";
            this.lblpBs21.Size = new System.Drawing.Size(13, 13);
            this.lblpBs21.TabIndex = 285;
            this.lblpBs21.Text = "0";
            this.lblpBs21.Visible = false;
            // 
            // lblpBs20
            // 
            this.lblpBs20.AutoSize = true;
            this.lblpBs20.Location = new System.Drawing.Point(327, 289);
            this.lblpBs20.Name = "lblpBs20";
            this.lblpBs20.Size = new System.Drawing.Size(13, 13);
            this.lblpBs20.TabIndex = 284;
            this.lblpBs20.Text = "0";
            this.lblpBs20.Visible = false;
            // 
            // picRec17
            // 
            this.picRec17.BackColor = System.Drawing.Color.Transparent;
            this.picRec17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec17.Image = ((System.Drawing.Image)(resources.GetObject("picRec17.Image")));
            this.picRec17.Location = new System.Drawing.Point(248, 254);
            this.picRec17.Name = "picRec17";
            this.picRec17.Size = new System.Drawing.Size(20, 12);
            this.picRec17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec17.TabIndex = 240;
            this.picRec17.TabStop = false;
            this.picRec17.Click += new System.EventHandler(this.picRec17_Click);
            this.picRec17.MouseLeave += new System.EventHandler(this.picRec17_MouseLeave);
            this.picRec17.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec17_MouseMove);
            // 
            // lblpBs19
            // 
            this.lblpBs19.AutoSize = true;
            this.lblpBs19.Location = new System.Drawing.Point(327, 273);
            this.lblpBs19.Name = "lblpBs19";
            this.lblpBs19.Size = new System.Drawing.Size(13, 13);
            this.lblpBs19.TabIndex = 283;
            this.lblpBs19.Text = "0";
            this.lblpBs19.Visible = false;
            // 
            // picBs17
            // 
            this.picBs17.BackColor = System.Drawing.Color.Transparent;
            this.picBs17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs17.Location = new System.Drawing.Point(285, 254);
            this.picBs17.Name = "picBs17";
            this.picBs17.Size = new System.Drawing.Size(10, 9);
            this.picBs17.TabIndex = 274;
            this.picBs17.TabStop = false;
            // 
            // lblpBs18
            // 
            this.lblpBs18.AutoSize = true;
            this.lblpBs18.Location = new System.Drawing.Point(327, 259);
            this.lblpBs18.Name = "lblpBs18";
            this.lblpBs18.Size = new System.Drawing.Size(13, 13);
            this.lblpBs18.TabIndex = 282;
            this.lblpBs18.Text = "0";
            this.lblpBs18.Visible = false;
            // 
            // picBs22
            // 
            this.picBs22.BackColor = System.Drawing.Color.Transparent;
            this.picBs22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs22.Location = new System.Drawing.Point(285, 322);
            this.picBs22.Name = "picBs22";
            this.picBs22.Size = new System.Drawing.Size(10, 9);
            this.picBs22.TabIndex = 280;
            this.picBs22.TabStop = false;
            // 
            // picBs21
            // 
            this.picBs21.BackColor = System.Drawing.Color.Transparent;
            this.picBs21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs21.Location = new System.Drawing.Point(285, 309);
            this.picBs21.Name = "picBs21";
            this.picBs21.Size = new System.Drawing.Size(10, 9);
            this.picBs21.TabIndex = 278;
            this.picBs21.TabStop = false;
            // 
            // picBs20
            // 
            this.picBs20.BackColor = System.Drawing.Color.Transparent;
            this.picBs20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs20.Location = new System.Drawing.Point(285, 294);
            this.picBs20.Name = "picBs20";
            this.picBs20.Size = new System.Drawing.Size(10, 9);
            this.picBs20.TabIndex = 277;
            this.picBs20.TabStop = false;
            // 
            // picBs19
            // 
            this.picBs19.BackColor = System.Drawing.Color.Transparent;
            this.picBs19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs19.Location = new System.Drawing.Point(285, 280);
            this.picBs19.Name = "picBs19";
            this.picBs19.Size = new System.Drawing.Size(10, 9);
            this.picBs19.TabIndex = 276;
            this.picBs19.TabStop = false;
            // 
            // picBs18
            // 
            this.picBs18.BackColor = System.Drawing.Color.Transparent;
            this.picBs18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs18.Location = new System.Drawing.Point(285, 267);
            this.picBs18.Name = "picBs18";
            this.picBs18.Size = new System.Drawing.Size(10, 9);
            this.picBs18.TabIndex = 275;
            this.picBs18.TabStop = false;
            // 
            // picGps2Cam22
            // 
            this.picGps2Cam22.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam22.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam22.Image")));
            this.picGps2Cam22.Location = new System.Drawing.Point(47, 325);
            this.picGps2Cam22.Name = "picGps2Cam22";
            this.picGps2Cam22.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam22.TabIndex = 262;
            this.picGps2Cam22.TabStop = false;
            // 
            // picRec22
            // 
            this.picRec22.BackColor = System.Drawing.Color.Transparent;
            this.picRec22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec22.Image = ((System.Drawing.Image)(resources.GetObject("picRec22.Image")));
            this.picRec22.Location = new System.Drawing.Point(248, 322);
            this.picRec22.Name = "picRec22";
            this.picRec22.Size = new System.Drawing.Size(20, 12);
            this.picRec22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec22.TabIndex = 255;
            this.picRec22.TabStop = false;
            this.picRec22.Click += new System.EventHandler(this.picRec22_Click);
            this.picRec22.MouseLeave += new System.EventHandler(this.picRec22_MouseLeave);
            this.picRec22.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec22_MouseMove);
            // 
            // lblpBv22
            // 
            this.lblpBv22.AutoSize = true;
            this.lblpBv22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv22.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv22.Location = new System.Drawing.Point(123, 324);
            this.lblpBv22.Name = "lblpBv22";
            this.lblpBv22.Size = new System.Drawing.Size(11, 12);
            this.lblpBv22.TabIndex = 254;
            this.lblpBv22.Text = "0";
            // 
            // lblpBb22
            // 
            this.lblpBb22.AutoSize = true;
            this.lblpBb22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb22.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb22.Location = new System.Drawing.Point(153, 324);
            this.lblpBb22.Name = "lblpBb22";
            this.lblpBb22.Size = new System.Drawing.Size(11, 12);
            this.lblpBb22.TabIndex = 253;
            this.lblpBb22.Text = "0";
            // 
            // picRep2Cam22
            // 
            this.picRep2Cam22.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam22.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam22.Image")));
            this.picRep2Cam22.Location = new System.Drawing.Point(25, 325);
            this.picRep2Cam22.Name = "picRep2Cam22";
            this.picRep2Cam22.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam22.TabIndex = 261;
            this.picRep2Cam22.TabStop = false;
            // 
            // picGps2Cam21
            // 
            this.picGps2Cam21.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam21.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam21.Image")));
            this.picGps2Cam21.Location = new System.Drawing.Point(47, 311);
            this.picGps2Cam21.Name = "picGps2Cam21";
            this.picGps2Cam21.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam21.TabIndex = 260;
            this.picGps2Cam21.TabStop = false;
            // 
            // picRep2Cam21
            // 
            this.picRep2Cam21.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam21.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam21.Image")));
            this.picRep2Cam21.Location = new System.Drawing.Point(25, 311);
            this.picRep2Cam21.Name = "picRep2Cam21";
            this.picRep2Cam21.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam21.TabIndex = 252;
            this.picRep2Cam21.TabStop = false;
            // 
            // picGps2Cam20
            // 
            this.picGps2Cam20.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam20.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam20.Image")));
            this.picGps2Cam20.Location = new System.Drawing.Point(47, 297);
            this.picGps2Cam20.Name = "picGps2Cam20";
            this.picGps2Cam20.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam20.TabIndex = 259;
            this.picGps2Cam20.TabStop = false;
            // 
            // picRep2Cam20
            // 
            this.picRep2Cam20.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam20.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam20.Image")));
            this.picRep2Cam20.Location = new System.Drawing.Point(25, 297);
            this.picRep2Cam20.Name = "picRep2Cam20";
            this.picRep2Cam20.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam20.TabIndex = 250;
            this.picRep2Cam20.TabStop = false;
            // 
            // picGps2Cam19
            // 
            this.picGps2Cam19.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam19.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam19.Image")));
            this.picGps2Cam19.Location = new System.Drawing.Point(47, 283);
            this.picGps2Cam19.Name = "picGps2Cam19";
            this.picGps2Cam19.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam19.TabIndex = 258;
            this.picGps2Cam19.TabStop = false;
            // 
            // picRec21
            // 
            this.picRec21.BackColor = System.Drawing.Color.Transparent;
            this.picRec21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec21.Image = ((System.Drawing.Image)(resources.GetObject("picRec21.Image")));
            this.picRec21.Location = new System.Drawing.Point(248, 308);
            this.picRec21.Name = "picRec21";
            this.picRec21.Size = new System.Drawing.Size(20, 12);
            this.picRec21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec21.TabIndex = 245;
            this.picRec21.TabStop = false;
            this.picRec21.Click += new System.EventHandler(this.picRec21_Click);
            this.picRec21.MouseLeave += new System.EventHandler(this.picRec21_MouseLeave);
            this.picRec21.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec21_MouseMove);
            // 
            // picGps2Cam18
            // 
            this.picGps2Cam18.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam18.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam18.Image")));
            this.picGps2Cam18.Location = new System.Drawing.Point(47, 270);
            this.picGps2Cam18.Name = "picGps2Cam18";
            this.picGps2Cam18.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam18.TabIndex = 257;
            this.picGps2Cam18.TabStop = false;
            // 
            // picRep2Cam19
            // 
            this.picRep2Cam19.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam19.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam19.Image")));
            this.picRep2Cam19.Location = new System.Drawing.Point(25, 283);
            this.picRep2Cam19.Name = "picRep2Cam19";
            this.picRep2Cam19.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam19.TabIndex = 247;
            this.picRep2Cam19.TabStop = false;
            // 
            // picRec20
            // 
            this.picRec20.BackColor = System.Drawing.Color.Transparent;
            this.picRec20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec20.Image = ((System.Drawing.Image)(resources.GetObject("picRec20.Image")));
            this.picRec20.Location = new System.Drawing.Point(248, 295);
            this.picRec20.Name = "picRec20";
            this.picRec20.Size = new System.Drawing.Size(20, 12);
            this.picRec20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec20.TabIndex = 243;
            this.picRec20.TabStop = false;
            this.picRec20.Click += new System.EventHandler(this.picRec20_Click);
            this.picRec20.MouseLeave += new System.EventHandler(this.picRec20_MouseLeave);
            this.picRec20.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec20_MouseMove);
            // 
            // picRec19
            // 
            this.picRec19.BackColor = System.Drawing.Color.Transparent;
            this.picRec19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec19.Image = ((System.Drawing.Image)(resources.GetObject("picRec19.Image")));
            this.picRec19.Location = new System.Drawing.Point(248, 281);
            this.picRec19.Name = "picRec19";
            this.picRec19.Size = new System.Drawing.Size(20, 12);
            this.picRec19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec19.TabIndex = 242;
            this.picRec19.TabStop = false;
            this.picRec19.Click += new System.EventHandler(this.picRec19_Click);
            this.picRec19.MouseLeave += new System.EventHandler(this.picRec19_MouseLeave);
            this.picRec19.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec19_MouseMove);
            // 
            // picRep2Cam18
            // 
            this.picRep2Cam18.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam18.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam18.Image")));
            this.picRep2Cam18.Location = new System.Drawing.Point(25, 270);
            this.picRep2Cam18.Name = "picRep2Cam18";
            this.picRep2Cam18.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam18.TabIndex = 246;
            this.picRep2Cam18.TabStop = false;
            // 
            // picRec18
            // 
            this.picRec18.BackColor = System.Drawing.Color.Transparent;
            this.picRec18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec18.Image = ((System.Drawing.Image)(resources.GetObject("picRec18.Image")));
            this.picRec18.Location = new System.Drawing.Point(248, 268);
            this.picRec18.Name = "picRec18";
            this.picRec18.Size = new System.Drawing.Size(20, 12);
            this.picRec18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec18.TabIndex = 241;
            this.picRec18.TabStop = false;
            this.picRec18.Click += new System.EventHandler(this.picRec18_Click);
            this.picRec18.MouseLeave += new System.EventHandler(this.picRec18_MouseLeave);
            this.picRec18.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec18_MouseMove);
            // 
            // lblpBv21
            // 
            this.lblpBv21.AutoSize = true;
            this.lblpBv21.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv21.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv21.Location = new System.Drawing.Point(123, 310);
            this.lblpBv21.Name = "lblpBv21";
            this.lblpBv21.Size = new System.Drawing.Size(11, 12);
            this.lblpBv21.TabIndex = 239;
            this.lblpBv21.Text = "0";
            // 
            // lblpBv20
            // 
            this.lblpBv20.AutoSize = true;
            this.lblpBv20.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv20.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv20.Location = new System.Drawing.Point(123, 295);
            this.lblpBv20.Name = "lblpBv20";
            this.lblpBv20.Size = new System.Drawing.Size(11, 12);
            this.lblpBv20.TabIndex = 238;
            this.lblpBv20.Text = "0";
            // 
            // lblpBv19
            // 
            this.lblpBv19.AutoSize = true;
            this.lblpBv19.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv19.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv19.Location = new System.Drawing.Point(123, 281);
            this.lblpBv19.Name = "lblpBv19";
            this.lblpBv19.Size = new System.Drawing.Size(11, 12);
            this.lblpBv19.TabIndex = 237;
            this.lblpBv19.Text = "0";
            // 
            // lblpBv18
            // 
            this.lblpBv18.AutoSize = true;
            this.lblpBv18.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv18.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv18.Location = new System.Drawing.Point(123, 268);
            this.lblpBv18.Name = "lblpBv18";
            this.lblpBv18.Size = new System.Drawing.Size(11, 12);
            this.lblpBv18.TabIndex = 236;
            this.lblpBv18.Text = "0";
            // 
            // lblpBb21
            // 
            this.lblpBb21.AutoSize = true;
            this.lblpBb21.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb21.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb21.Location = new System.Drawing.Point(153, 310);
            this.lblpBb21.Name = "lblpBb21";
            this.lblpBb21.Size = new System.Drawing.Size(11, 12);
            this.lblpBb21.TabIndex = 234;
            this.lblpBb21.Text = "0";
            // 
            // lblpBb20
            // 
            this.lblpBb20.AutoSize = true;
            this.lblpBb20.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb20.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb20.Location = new System.Drawing.Point(153, 295);
            this.lblpBb20.Name = "lblpBb20";
            this.lblpBb20.Size = new System.Drawing.Size(11, 12);
            this.lblpBb20.TabIndex = 233;
            this.lblpBb20.Text = "0";
            // 
            // lblpBb19
            // 
            this.lblpBb19.AutoSize = true;
            this.lblpBb19.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb19.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb19.Location = new System.Drawing.Point(153, 281);
            this.lblpBb19.Name = "lblpBb19";
            this.lblpBb19.Size = new System.Drawing.Size(11, 12);
            this.lblpBb19.TabIndex = 232;
            this.lblpBb19.Text = "0";
            // 
            // lblpBb18
            // 
            this.lblpBb18.AutoSize = true;
            this.lblpBb18.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb18.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb18.Location = new System.Drawing.Point(153, 268);
            this.lblpBb18.Name = "lblpBb18";
            this.lblpBb18.Size = new System.Drawing.Size(11, 12);
            this.lblpBb18.TabIndex = 231;
            this.lblpBb18.Text = "0";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label36.Location = new System.Drawing.Point(197, 22);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(49, 9);
            this.label36.TabIndex = 214;
            this.label36.Text = "ULT UBIC";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label35.Location = new System.Drawing.Point(25, 22);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(24, 9);
            this.label35.TabIndex = 197;
            this.label35.Text = "DAT";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label30.Location = new System.Drawing.Point(46, 22);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(24, 9);
            this.label30.TabIndex = 196;
            this.label30.Text = "GPS";
            // 
            // lblRutaError
            // 
            this.lblRutaError.AutoSize = true;
            this.lblRutaError.Location = new System.Drawing.Point(5, 350);
            this.lblRutaError.Name = "lblRutaError";
            this.lblRutaError.Size = new System.Drawing.Size(13, 13);
            this.lblRutaError.TabIndex = 182;
            this.lblRutaError.Text = "0";
            this.lblRutaError.Visible = false;
            // 
            // listBoxRutaError
            // 
            this.listBoxRutaError.FormattingEnabled = true;
            this.listBoxRutaError.Location = new System.Drawing.Point(3, 421);
            this.listBoxRutaError.Name = "listBoxRutaError";
            this.listBoxRutaError.ScrollAlwaysVisible = true;
            this.listBoxRutaError.Size = new System.Drawing.Size(263, 30);
            this.listBoxRutaError.TabIndex = 181;
            this.listBoxRutaError.Visible = false;
            this.listBoxRutaError.SelectedIndexChanged += new System.EventHandler(this.listBoxRutaError_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(269, 439);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 180;
            this.label21.Text = "Limpia Ruta";
            this.label21.Visible = false;
            // 
            // lblpBs16
            // 
            this.lblpBs16.AutoSize = true;
            this.lblpBs16.Location = new System.Drawing.Point(327, 227);
            this.lblpBs16.Name = "lblpBs16";
            this.lblpBs16.Size = new System.Drawing.Size(13, 13);
            this.lblpBs16.TabIndex = 179;
            this.lblpBs16.Text = "0";
            this.lblpBs16.Visible = false;
            // 
            // lblpB16
            // 
            this.lblpB16.AutoSize = true;
            this.lblpB16.BackColor = System.Drawing.Color.Transparent;
            this.lblpB16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB16.Location = new System.Drawing.Point(356, 230);
            this.lblpB16.Name = "lblpB16";
            this.lblpB16.Size = new System.Drawing.Size(18, 9);
            this.lblpB16.TabIndex = 178;
            this.lblpB16.Text = "0 %";
            this.lblpB16.Visible = false;
            // 
            // picGps2Cam16
            // 
            this.picGps2Cam16.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam16.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam16.Image")));
            this.picGps2Cam16.Location = new System.Drawing.Point(47, 242);
            this.picGps2Cam16.Name = "picGps2Cam16";
            this.picGps2Cam16.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam16.TabIndex = 195;
            this.picGps2Cam16.TabStop = false;
            // 
            // picBs16
            // 
            this.picBs16.BackColor = System.Drawing.Color.Transparent;
            this.picBs16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs16.Location = new System.Drawing.Point(285, 239);
            this.picBs16.Name = "picBs16";
            this.picBs16.Size = new System.Drawing.Size(10, 9);
            this.picBs16.TabIndex = 177;
            this.picBs16.TabStop = false;
            // 
            // picRec16
            // 
            this.picRec16.BackColor = System.Drawing.Color.Transparent;
            this.picRec16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec16.Image = ((System.Drawing.Image)(resources.GetObject("picRec16.Image")));
            this.picRec16.Location = new System.Drawing.Point(248, 239);
            this.picRec16.Name = "picRec16";
            this.picRec16.Size = new System.Drawing.Size(20, 12);
            this.picRec16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec16.TabIndex = 175;
            this.picRec16.TabStop = false;
            this.picRec16.Click += new System.EventHandler(this.picRec16_Click);
            this.picRec16.MouseLeave += new System.EventHandler(this.picRec16_MouseLeave);
            this.picRec16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec16_MouseMove);
            // 
            // lblpBb16
            // 
            this.lblpBb16.AutoSize = true;
            this.lblpBb16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb16.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb16.Location = new System.Drawing.Point(153, 241);
            this.lblpBb16.Name = "lblpBb16";
            this.lblpBb16.Size = new System.Drawing.Size(11, 12);
            this.lblpBb16.TabIndex = 173;
            this.lblpBb16.Text = "0";
            // 
            // picRep2Cam16
            // 
            this.picRep2Cam16.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam16.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam16.Image")));
            this.picRep2Cam16.Location = new System.Drawing.Point(25, 242);
            this.picRep2Cam16.Name = "picRep2Cam16";
            this.picRep2Cam16.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam16.TabIndex = 188;
            this.picRep2Cam16.TabStop = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label28.Location = new System.Drawing.Point(246, 22);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(25, 9);
            this.label28.TabIndex = 169;
            this.label28.Text = "RUT";
            // 
            // picGps2Cam15
            // 
            this.picGps2Cam15.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam15.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam15.Image")));
            this.picGps2Cam15.Location = new System.Drawing.Point(47, 228);
            this.picGps2Cam15.Name = "picGps2Cam15";
            this.picGps2Cam15.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam15.TabIndex = 187;
            this.picGps2Cam15.TabStop = false;
            // 
            // picRep2Cam15
            // 
            this.picRep2Cam15.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam15.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam15.Image")));
            this.picRep2Cam15.Location = new System.Drawing.Point(25, 228);
            this.picRep2Cam15.Name = "picRep2Cam15";
            this.picRep2Cam15.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam15.TabIndex = 172;
            this.picRep2Cam15.TabStop = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label29.Location = new System.Drawing.Point(-2, 22);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(26, 9);
            this.label29.TabIndex = 45;
            this.label29.Text = "CAM";
            // 
            // picGps2Cam14
            // 
            this.picGps2Cam14.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam14.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam14.Image")));
            this.picGps2Cam14.Location = new System.Drawing.Point(47, 214);
            this.picGps2Cam14.Name = "picGps2Cam14";
            this.picGps2Cam14.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam14.TabIndex = 186;
            this.picGps2Cam14.TabStop = false;
            // 
            // picRecLimpia
            // 
            this.picRecLimpia.BackColor = System.Drawing.Color.Transparent;
            this.picRecLimpia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRecLimpia.Image = ((System.Drawing.Image)(resources.GetObject("picRecLimpia.Image")));
            this.picRecLimpia.Location = new System.Drawing.Point(180, 350);
            this.picRecLimpia.Name = "picRecLimpia";
            this.picRecLimpia.Size = new System.Drawing.Size(20, 12);
            this.picRecLimpia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRecLimpia.TabIndex = 168;
            this.picRecLimpia.TabStop = false;
            this.picRecLimpia.Visible = false;
            this.picRecLimpia.Click += new System.EventHandler(this.picRecLimpia_Click);
            // 
            // picRep2Cam14
            // 
            this.picRep2Cam14.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam14.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam14.Image")));
            this.picRep2Cam14.Location = new System.Drawing.Point(25, 214);
            this.picRep2Cam14.Name = "picRep2Cam14";
            this.picRep2Cam14.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam14.TabIndex = 171;
            this.picRep2Cam14.TabStop = false;
            // 
            // picGps2Cam13
            // 
            this.picGps2Cam13.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam13.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam13.Image")));
            this.picGps2Cam13.Location = new System.Drawing.Point(47, 200);
            this.picGps2Cam13.Name = "picGps2Cam13";
            this.picGps2Cam13.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam13.TabIndex = 185;
            this.picGps2Cam13.TabStop = false;
            // 
            // picRec15
            // 
            this.picRec15.BackColor = System.Drawing.Color.Transparent;
            this.picRec15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec15.Image = ((System.Drawing.Image)(resources.GetObject("picRec15.Image")));
            this.picRec15.Location = new System.Drawing.Point(248, 225);
            this.picRec15.Name = "picRec15";
            this.picRec15.Size = new System.Drawing.Size(20, 12);
            this.picRec15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec15.TabIndex = 167;
            this.picRec15.TabStop = false;
            this.picRec15.Click += new System.EventHandler(this.picRec15_Click);
            this.picRec15.MouseLeave += new System.EventHandler(this.picRec15_MouseLeave);
            this.picRec15.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec15_MouseMove);
            // 
            // picGps2Cam12
            // 
            this.picGps2Cam12.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam12.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam12.Image")));
            this.picGps2Cam12.Location = new System.Drawing.Point(47, 187);
            this.picGps2Cam12.Name = "picGps2Cam12";
            this.picGps2Cam12.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam12.TabIndex = 184;
            this.picGps2Cam12.TabStop = false;
            // 
            // picRep2Cam13
            // 
            this.picRep2Cam13.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam13.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam13.Image")));
            this.picRep2Cam13.Location = new System.Drawing.Point(25, 200);
            this.picRep2Cam13.Name = "picRep2Cam13";
            this.picRep2Cam13.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam13.TabIndex = 170;
            this.picRep2Cam13.TabStop = false;
            // 
            // picRec14
            // 
            this.picRec14.BackColor = System.Drawing.Color.Transparent;
            this.picRec14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec14.Image = ((System.Drawing.Image)(resources.GetObject("picRec14.Image")));
            this.picRec14.Location = new System.Drawing.Point(248, 212);
            this.picRec14.Name = "picRec14";
            this.picRec14.Size = new System.Drawing.Size(20, 12);
            this.picRec14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec14.TabIndex = 166;
            this.picRec14.TabStop = false;
            this.picRec14.Click += new System.EventHandler(this.picRec14_Click);
            this.picRec14.MouseLeave += new System.EventHandler(this.picRec14_MouseLeave);
            this.picRec14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec14_MouseMove);
            // 
            // picGps2Cam11
            // 
            this.picGps2Cam11.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam11.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam11.Image")));
            this.picGps2Cam11.Location = new System.Drawing.Point(47, 173);
            this.picGps2Cam11.Name = "picGps2Cam11";
            this.picGps2Cam11.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam11.TabIndex = 183;
            this.picGps2Cam11.TabStop = false;
            // 
            // picRec13
            // 
            this.picRec13.BackColor = System.Drawing.Color.Transparent;
            this.picRec13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec13.Image = ((System.Drawing.Image)(resources.GetObject("picRec13.Image")));
            this.picRec13.Location = new System.Drawing.Point(248, 198);
            this.picRec13.Name = "picRec13";
            this.picRec13.Size = new System.Drawing.Size(20, 12);
            this.picRec13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec13.TabIndex = 165;
            this.picRec13.TabStop = false;
            this.picRec13.Click += new System.EventHandler(this.picRec13_Click);
            this.picRec13.MouseLeave += new System.EventHandler(this.picRec13_MouseLeave);
            this.picRec13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec13_MouseMove);
            // 
            // picRep2Cam12
            // 
            this.picRep2Cam12.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam12.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam12.Image")));
            this.picRep2Cam12.Location = new System.Drawing.Point(25, 187);
            this.picRep2Cam12.Name = "picRep2Cam12";
            this.picRep2Cam12.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam12.TabIndex = 168;
            this.picRep2Cam12.TabStop = false;
            // 
            // picGps2Cam10
            // 
            this.picGps2Cam10.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam10.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam10.Image")));
            this.picGps2Cam10.Location = new System.Drawing.Point(47, 158);
            this.picGps2Cam10.Name = "picGps2Cam10";
            this.picGps2Cam10.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam10.TabIndex = 182;
            this.picGps2Cam10.TabStop = false;
            // 
            // picRec12
            // 
            this.picRec12.BackColor = System.Drawing.Color.Transparent;
            this.picRec12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec12.Image = ((System.Drawing.Image)(resources.GetObject("picRec12.Image")));
            this.picRec12.Location = new System.Drawing.Point(248, 185);
            this.picRec12.Name = "picRec12";
            this.picRec12.Size = new System.Drawing.Size(20, 12);
            this.picRec12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec12.TabIndex = 164;
            this.picRec12.TabStop = false;
            this.picRec12.Click += new System.EventHandler(this.picRec12_Click);
            this.picRec12.MouseLeave += new System.EventHandler(this.picRec12_MouseLeave);
            this.picRec12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec12_MouseMove);
            // 
            // picGps2Cam09
            // 
            this.picGps2Cam09.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam09.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam09.Image")));
            this.picGps2Cam09.Location = new System.Drawing.Point(47, 144);
            this.picGps2Cam09.Name = "picGps2Cam09";
            this.picGps2Cam09.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam09.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam09.TabIndex = 181;
            this.picGps2Cam09.TabStop = false;
            // 
            // picRep2Cam11
            // 
            this.picRep2Cam11.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam11.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam11.Image")));
            this.picRep2Cam11.Location = new System.Drawing.Point(25, 173);
            this.picRep2Cam11.Name = "picRep2Cam11";
            this.picRep2Cam11.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam11.TabIndex = 167;
            this.picRep2Cam11.TabStop = false;
            // 
            // picRec11
            // 
            this.picRec11.BackColor = System.Drawing.Color.Transparent;
            this.picRec11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec11.Image = ((System.Drawing.Image)(resources.GetObject("picRec11.Image")));
            this.picRec11.Location = new System.Drawing.Point(248, 171);
            this.picRec11.Name = "picRec11";
            this.picRec11.Size = new System.Drawing.Size(20, 12);
            this.picRec11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec11.TabIndex = 163;
            this.picRec11.TabStop = false;
            this.picRec11.Click += new System.EventHandler(this.picRec11_Click);
            this.picRec11.MouseLeave += new System.EventHandler(this.picRec11_MouseLeave);
            this.picRec11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec11_MouseMove);
            // 
            // picGps2Cam08
            // 
            this.picGps2Cam08.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam08.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam08.Image")));
            this.picGps2Cam08.Location = new System.Drawing.Point(47, 130);
            this.picGps2Cam08.Name = "picGps2Cam08";
            this.picGps2Cam08.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam08.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam08.TabIndex = 180;
            this.picGps2Cam08.TabStop = false;
            // 
            // picRec10
            // 
            this.picRec10.BackColor = System.Drawing.Color.Transparent;
            this.picRec10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec10.Image = ((System.Drawing.Image)(resources.GetObject("picRec10.Image")));
            this.picRec10.Location = new System.Drawing.Point(248, 157);
            this.picRec10.Name = "picRec10";
            this.picRec10.Size = new System.Drawing.Size(20, 12);
            this.picRec10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec10.TabIndex = 162;
            this.picRec10.TabStop = false;
            this.picRec10.Click += new System.EventHandler(this.picRec10_Click);
            this.picRec10.MouseLeave += new System.EventHandler(this.picRec10_MouseLeave);
            this.picRec10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec10_MouseMove);
            // 
            // picRep2Cam10
            // 
            this.picRep2Cam10.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam10.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam10.Image")));
            this.picRep2Cam10.Location = new System.Drawing.Point(25, 158);
            this.picRep2Cam10.Name = "picRep2Cam10";
            this.picRep2Cam10.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam10.TabIndex = 165;
            this.picRep2Cam10.TabStop = false;
            // 
            // picGps2Cam07
            // 
            this.picGps2Cam07.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam07.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam07.Image")));
            this.picGps2Cam07.Location = new System.Drawing.Point(47, 116);
            this.picGps2Cam07.Name = "picGps2Cam07";
            this.picGps2Cam07.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam07.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam07.TabIndex = 179;
            this.picGps2Cam07.TabStop = false;
            // 
            // picRec09
            // 
            this.picRec09.BackColor = System.Drawing.Color.Transparent;
            this.picRec09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec09.Image = ((System.Drawing.Image)(resources.GetObject("picRec09.Image")));
            this.picRec09.Location = new System.Drawing.Point(248, 143);
            this.picRec09.Name = "picRec09";
            this.picRec09.Size = new System.Drawing.Size(20, 12);
            this.picRec09.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec09.TabIndex = 161;
            this.picRec09.TabStop = false;
            this.picRec09.Click += new System.EventHandler(this.picRec09_Click);
            this.picRec09.MouseLeave += new System.EventHandler(this.picRec09_MouseLeave);
            this.picRec09.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec09_MouseMove);
            // 
            // picGps2Cam06
            // 
            this.picGps2Cam06.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam06.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam06.Image")));
            this.picGps2Cam06.Location = new System.Drawing.Point(47, 102);
            this.picGps2Cam06.Name = "picGps2Cam06";
            this.picGps2Cam06.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam06.TabIndex = 178;
            this.picGps2Cam06.TabStop = false;
            // 
            // picRep2Cam09
            // 
            this.picRep2Cam09.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam09.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam09.Image")));
            this.picRep2Cam09.Location = new System.Drawing.Point(25, 144);
            this.picRep2Cam09.Name = "picRep2Cam09";
            this.picRep2Cam09.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam09.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam09.TabIndex = 163;
            this.picRep2Cam09.TabStop = false;
            // 
            // picRec08
            // 
            this.picRec08.BackColor = System.Drawing.Color.Transparent;
            this.picRec08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec08.Image = ((System.Drawing.Image)(resources.GetObject("picRec08.Image")));
            this.picRec08.Location = new System.Drawing.Point(248, 129);
            this.picRec08.Name = "picRec08";
            this.picRec08.Size = new System.Drawing.Size(20, 12);
            this.picRec08.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec08.TabIndex = 160;
            this.picRec08.TabStop = false;
            this.picRec08.Click += new System.EventHandler(this.picRec08_Click);
            this.picRec08.MouseLeave += new System.EventHandler(this.picRec08_MouseLeave);
            this.picRec08.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec08_MouseMove);
            // 
            // picRep2Cam08
            // 
            this.picRep2Cam08.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam08.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam08.Image")));
            this.picRep2Cam08.Location = new System.Drawing.Point(25, 130);
            this.picRep2Cam08.Name = "picRep2Cam08";
            this.picRep2Cam08.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam08.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam08.TabIndex = 169;
            this.picRep2Cam08.TabStop = false;
            // 
            // picGps2Cam05
            // 
            this.picGps2Cam05.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam05.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam05.Image")));
            this.picGps2Cam05.Location = new System.Drawing.Point(47, 89);
            this.picGps2Cam05.Name = "picGps2Cam05";
            this.picGps2Cam05.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam05.TabIndex = 177;
            this.picGps2Cam05.TabStop = false;
            // 
            // picRec07
            // 
            this.picRec07.BackColor = System.Drawing.Color.Transparent;
            this.picRec07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec07.Image = ((System.Drawing.Image)(resources.GetObject("picRec07.Image")));
            this.picRec07.Location = new System.Drawing.Point(248, 115);
            this.picRec07.Name = "picRec07";
            this.picRec07.Size = new System.Drawing.Size(20, 12);
            this.picRec07.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec07.TabIndex = 159;
            this.picRec07.TabStop = false;
            this.picRec07.Click += new System.EventHandler(this.picRec07_Click);
            this.picRec07.MouseLeave += new System.EventHandler(this.picRec07_MouseLeave);
            this.picRec07.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec07_MouseMove);
            // 
            // picGps2Cam04
            // 
            this.picGps2Cam04.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam04.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam04.Image")));
            this.picGps2Cam04.Location = new System.Drawing.Point(47, 76);
            this.picGps2Cam04.Name = "picGps2Cam04";
            this.picGps2Cam04.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam04.TabIndex = 176;
            this.picGps2Cam04.TabStop = false;
            // 
            // picRec06
            // 
            this.picRec06.BackColor = System.Drawing.Color.Transparent;
            this.picRec06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec06.Image = ((System.Drawing.Image)(resources.GetObject("picRec06.Image")));
            this.picRec06.Location = new System.Drawing.Point(248, 101);
            this.picRec06.Name = "picRec06";
            this.picRec06.Size = new System.Drawing.Size(20, 12);
            this.picRec06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec06.TabIndex = 158;
            this.picRec06.TabStop = false;
            this.picRec06.Click += new System.EventHandler(this.picRec06_Click);
            this.picRec06.MouseLeave += new System.EventHandler(this.picRec06_MouseLeave);
            this.picRec06.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec06_MouseMove);
            // 
            // picRep2Cam07
            // 
            this.picRep2Cam07.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam07.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam07.Image")));
            this.picRep2Cam07.Location = new System.Drawing.Point(25, 116);
            this.picRep2Cam07.Name = "picRep2Cam07";
            this.picRep2Cam07.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam07.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam07.TabIndex = 166;
            this.picRep2Cam07.TabStop = false;
            // 
            // picGps2Cam03
            // 
            this.picGps2Cam03.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam03.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam03.Image")));
            this.picGps2Cam03.Location = new System.Drawing.Point(47, 63);
            this.picGps2Cam03.Name = "picGps2Cam03";
            this.picGps2Cam03.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam03.TabIndex = 175;
            this.picGps2Cam03.TabStop = false;
            // 
            // picRec05
            // 
            this.picRec05.BackColor = System.Drawing.Color.Transparent;
            this.picRec05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec05.Image = ((System.Drawing.Image)(resources.GetObject("picRec05.Image")));
            this.picRec05.Location = new System.Drawing.Point(248, 87);
            this.picRec05.Name = "picRec05";
            this.picRec05.Size = new System.Drawing.Size(20, 12);
            this.picRec05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec05.TabIndex = 157;
            this.picRec05.TabStop = false;
            this.picRec05.Click += new System.EventHandler(this.picRec05_Click);
            this.picRec05.MouseLeave += new System.EventHandler(this.picRec05_MouseLeave);
            this.picRec05.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec05_MouseMove);
            // 
            // picGps2Cam02
            // 
            this.picGps2Cam02.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam02.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam02.Image")));
            this.picGps2Cam02.Location = new System.Drawing.Point(47, 50);
            this.picGps2Cam02.Name = "picGps2Cam02";
            this.picGps2Cam02.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam02.TabIndex = 174;
            this.picGps2Cam02.TabStop = false;
            // 
            // picRec04
            // 
            this.picRec04.BackColor = System.Drawing.Color.Transparent;
            this.picRec04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec04.Image = ((System.Drawing.Image)(resources.GetObject("picRec04.Image")));
            this.picRec04.Location = new System.Drawing.Point(248, 74);
            this.picRec04.Name = "picRec04";
            this.picRec04.Size = new System.Drawing.Size(20, 12);
            this.picRec04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec04.TabIndex = 156;
            this.picRec04.TabStop = false;
            this.picRec04.Click += new System.EventHandler(this.picRec04_Click);
            this.picRec04.MouseLeave += new System.EventHandler(this.picRec04_MouseLeave);
            this.picRec04.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec04_MouseMove);
            // 
            // picRep2Cam06
            // 
            this.picRep2Cam06.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam06.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam06.Image")));
            this.picRep2Cam06.Location = new System.Drawing.Point(25, 102);
            this.picRep2Cam06.Name = "picRep2Cam06";
            this.picRep2Cam06.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam06.TabIndex = 164;
            this.picRep2Cam06.TabStop = false;
            // 
            // picGps2Cam01
            // 
            this.picGps2Cam01.BackColor = System.Drawing.Color.Transparent;
            this.picGps2Cam01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGps2Cam01.Image = ((System.Drawing.Image)(resources.GetObject("picGps2Cam01.Image")));
            this.picGps2Cam01.Location = new System.Drawing.Point(47, 36);
            this.picGps2Cam01.Name = "picGps2Cam01";
            this.picGps2Cam01.Size = new System.Drawing.Size(19, 10);
            this.picGps2Cam01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGps2Cam01.TabIndex = 173;
            this.picGps2Cam01.TabStop = false;
            // 
            // picRec03
            // 
            this.picRec03.BackColor = System.Drawing.Color.Transparent;
            this.picRec03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec03.Image = ((System.Drawing.Image)(resources.GetObject("picRec03.Image")));
            this.picRec03.Location = new System.Drawing.Point(248, 61);
            this.picRec03.Name = "picRec03";
            this.picRec03.Size = new System.Drawing.Size(20, 12);
            this.picRec03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec03.TabIndex = 155;
            this.picRec03.TabStop = false;
            this.picRec03.Click += new System.EventHandler(this.picRec03_Click);
            this.picRec03.MouseLeave += new System.EventHandler(this.picRec03_MouseLeave);
            this.picRec03.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec03_MouseMove);
            // 
            // picRec02
            // 
            this.picRec02.BackColor = System.Drawing.Color.Transparent;
            this.picRec02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec02.Image = ((System.Drawing.Image)(resources.GetObject("picRec02.Image")));
            this.picRec02.Location = new System.Drawing.Point(248, 48);
            this.picRec02.Name = "picRec02";
            this.picRec02.Size = new System.Drawing.Size(20, 12);
            this.picRec02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec02.TabIndex = 154;
            this.picRec02.TabStop = false;
            this.picRec02.Click += new System.EventHandler(this.picRec02_Click);
            this.picRec02.MouseLeave += new System.EventHandler(this.picRec02_MouseLeave);
            this.picRec02.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec02_MouseMove);
            // 
            // picRep2Cam05
            // 
            this.picRep2Cam05.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam05.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam05.Image")));
            this.picRep2Cam05.Location = new System.Drawing.Point(25, 89);
            this.picRep2Cam05.Name = "picRep2Cam05";
            this.picRep2Cam05.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam05.TabIndex = 162;
            this.picRep2Cam05.TabStop = false;
            // 
            // picRec01
            // 
            this.picRec01.BackColor = System.Drawing.Color.Transparent;
            this.picRec01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRec01.Image = ((System.Drawing.Image)(resources.GetObject("picRec01.Image")));
            this.picRec01.Location = new System.Drawing.Point(248, 34);
            this.picRec01.Name = "picRec01";
            this.picRec01.Size = new System.Drawing.Size(20, 12);
            this.picRec01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRec01.TabIndex = 153;
            this.picRec01.TabStop = false;
            this.picRec01.Click += new System.EventHandler(this.picRec01_Click);
            this.picRec01.MouseLeave += new System.EventHandler(this.picRec01_MouseLeave);
            this.picRec01.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRec01_MouseMove);
            // 
            // picRep2Cam04
            // 
            this.picRep2Cam04.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam04.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam04.Image")));
            this.picRep2Cam04.Location = new System.Drawing.Point(25, 76);
            this.picRep2Cam04.Name = "picRep2Cam04";
            this.picRep2Cam04.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam04.TabIndex = 161;
            this.picRep2Cam04.TabStop = false;
            // 
            // picRep2Cam03
            // 
            this.picRep2Cam03.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam03.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam03.Image")));
            this.picRep2Cam03.Location = new System.Drawing.Point(25, 63);
            this.picRep2Cam03.Name = "picRep2Cam03";
            this.picRep2Cam03.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam03.TabIndex = 160;
            this.picRep2Cam03.TabStop = false;
            // 
            // picRep2Cam02
            // 
            this.picRep2Cam02.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam02.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam02.Image")));
            this.picRep2Cam02.Location = new System.Drawing.Point(25, 50);
            this.picRep2Cam02.Name = "picRep2Cam02";
            this.picRep2Cam02.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam02.TabIndex = 159;
            this.picRep2Cam02.TabStop = false;
            // 
            // picRep2Cam01
            // 
            this.picRep2Cam01.BackColor = System.Drawing.Color.Transparent;
            this.picRep2Cam01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRep2Cam01.Image = ((System.Drawing.Image)(resources.GetObject("picRep2Cam01.Image")));
            this.picRep2Cam01.Location = new System.Drawing.Point(25, 36);
            this.picRep2Cam01.Name = "picRep2Cam01";
            this.picRep2Cam01.Size = new System.Drawing.Size(19, 10);
            this.picRep2Cam01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep2Cam01.TabIndex = 158;
            this.picRep2Cam01.TabStop = false;
            // 
            // lblpBv15
            // 
            this.lblpBv15.AutoSize = true;
            this.lblpBv15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv15.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv15.Location = new System.Drawing.Point(123, 227);
            this.lblpBv15.Name = "lblpBv15";
            this.lblpBv15.Size = new System.Drawing.Size(11, 12);
            this.lblpBv15.TabIndex = 139;
            this.lblpBv15.Text = "0";
            // 
            // lblpBv14
            // 
            this.lblpBv14.AutoSize = true;
            this.lblpBv14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv14.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv14.Location = new System.Drawing.Point(123, 212);
            this.lblpBv14.Name = "lblpBv14";
            this.lblpBv14.Size = new System.Drawing.Size(11, 12);
            this.lblpBv14.TabIndex = 138;
            this.lblpBv14.Text = "0";
            // 
            // lblpBv13
            // 
            this.lblpBv13.AutoSize = true;
            this.lblpBv13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv13.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv13.Location = new System.Drawing.Point(123, 198);
            this.lblpBv13.Name = "lblpBv13";
            this.lblpBv13.Size = new System.Drawing.Size(11, 12);
            this.lblpBv13.TabIndex = 137;
            this.lblpBv13.Text = "0";
            // 
            // lblpBv12
            // 
            this.lblpBv12.AutoSize = true;
            this.lblpBv12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv12.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv12.Location = new System.Drawing.Point(123, 185);
            this.lblpBv12.Name = "lblpBv12";
            this.lblpBv12.Size = new System.Drawing.Size(11, 12);
            this.lblpBv12.TabIndex = 136;
            this.lblpBv12.Text = "0";
            // 
            // lblpBv11
            // 
            this.lblpBv11.AutoSize = true;
            this.lblpBv11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv11.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv11.Location = new System.Drawing.Point(123, 171);
            this.lblpBv11.Name = "lblpBv11";
            this.lblpBv11.Size = new System.Drawing.Size(11, 12);
            this.lblpBv11.TabIndex = 135;
            this.lblpBv11.Text = "0";
            // 
            // lblpBv10
            // 
            this.lblpBv10.AutoSize = true;
            this.lblpBv10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv10.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv10.Location = new System.Drawing.Point(123, 157);
            this.lblpBv10.Name = "lblpBv10";
            this.lblpBv10.Size = new System.Drawing.Size(11, 12);
            this.lblpBv10.TabIndex = 134;
            this.lblpBv10.Text = "0";
            // 
            // lblpBv09
            // 
            this.lblpBv09.AutoSize = true;
            this.lblpBv09.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv09.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv09.Location = new System.Drawing.Point(123, 143);
            this.lblpBv09.Name = "lblpBv09";
            this.lblpBv09.Size = new System.Drawing.Size(11, 12);
            this.lblpBv09.TabIndex = 133;
            this.lblpBv09.Text = "0";
            // 
            // lblpBv08
            // 
            this.lblpBv08.AutoSize = true;
            this.lblpBv08.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv08.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv08.Location = new System.Drawing.Point(123, 129);
            this.lblpBv08.Name = "lblpBv08";
            this.lblpBv08.Size = new System.Drawing.Size(11, 12);
            this.lblpBv08.TabIndex = 132;
            this.lblpBv08.Text = "0";
            // 
            // lblpBv07
            // 
            this.lblpBv07.AutoSize = true;
            this.lblpBv07.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv07.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv07.Location = new System.Drawing.Point(123, 115);
            this.lblpBv07.Name = "lblpBv07";
            this.lblpBv07.Size = new System.Drawing.Size(11, 12);
            this.lblpBv07.TabIndex = 131;
            this.lblpBv07.Text = "0";
            // 
            // lblpBv06
            // 
            this.lblpBv06.AutoSize = true;
            this.lblpBv06.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv06.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv06.Location = new System.Drawing.Point(123, 101);
            this.lblpBv06.Name = "lblpBv06";
            this.lblpBv06.Size = new System.Drawing.Size(11, 12);
            this.lblpBv06.TabIndex = 130;
            this.lblpBv06.Text = "0";
            // 
            // lblpBv05
            // 
            this.lblpBv05.AutoSize = true;
            this.lblpBv05.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv05.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv05.Location = new System.Drawing.Point(123, 87);
            this.lblpBv05.Name = "lblpBv05";
            this.lblpBv05.Size = new System.Drawing.Size(11, 12);
            this.lblpBv05.TabIndex = 129;
            this.lblpBv05.Text = "0";
            // 
            // lblpBv04
            // 
            this.lblpBv04.AutoSize = true;
            this.lblpBv04.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv04.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv04.Location = new System.Drawing.Point(123, 74);
            this.lblpBv04.Name = "lblpBv04";
            this.lblpBv04.Size = new System.Drawing.Size(11, 12);
            this.lblpBv04.TabIndex = 128;
            this.lblpBv04.Text = "0";
            // 
            // lblpBv03
            // 
            this.lblpBv03.AutoSize = true;
            this.lblpBv03.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv03.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv03.Location = new System.Drawing.Point(123, 61);
            this.lblpBv03.Name = "lblpBv03";
            this.lblpBv03.Size = new System.Drawing.Size(11, 12);
            this.lblpBv03.TabIndex = 127;
            this.lblpBv03.Text = "0";
            // 
            // lblpBv02
            // 
            this.lblpBv02.AutoSize = true;
            this.lblpBv02.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv02.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv02.Location = new System.Drawing.Point(123, 48);
            this.lblpBv02.Name = "lblpBv02";
            this.lblpBv02.Size = new System.Drawing.Size(11, 12);
            this.lblpBv02.TabIndex = 126;
            this.lblpBv02.Text = "0";
            // 
            // lblpBv01
            // 
            this.lblpBv01.AutoSize = true;
            this.lblpBv01.BackColor = System.Drawing.SystemColors.Control;
            this.lblpBv01.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBv01.ForeColor = System.Drawing.Color.Silver;
            this.lblpBv01.Location = new System.Drawing.Point(123, 35);
            this.lblpBv01.Name = "lblpBv01";
            this.lblpBv01.Size = new System.Drawing.Size(11, 12);
            this.lblpBv01.TabIndex = 125;
            this.lblpBv01.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(123, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 9);
            this.label3.TabIndex = 140;
            this.label3.Text = "VEL";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label34.Location = new System.Drawing.Point(68, 22);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(26, 9);
            this.label34.TabIndex = 124;
            this.label34.Text = "COR";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label33.Location = new System.Drawing.Point(153, 22);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(25, 9);
            this.label33.TabIndex = 123;
            this.label33.Text = "PILA";
            // 
            // lblpBb15
            // 
            this.lblpBb15.AutoSize = true;
            this.lblpBb15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb15.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb15.Location = new System.Drawing.Point(153, 227);
            this.lblpBb15.Name = "lblpBb15";
            this.lblpBb15.Size = new System.Drawing.Size(11, 12);
            this.lblpBb15.TabIndex = 122;
            this.lblpBb15.Text = "0";
            // 
            // lblpBb14
            // 
            this.lblpBb14.AutoSize = true;
            this.lblpBb14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb14.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb14.Location = new System.Drawing.Point(153, 212);
            this.lblpBb14.Name = "lblpBb14";
            this.lblpBb14.Size = new System.Drawing.Size(11, 12);
            this.lblpBb14.TabIndex = 121;
            this.lblpBb14.Text = "0";
            // 
            // lblpBb13
            // 
            this.lblpBb13.AutoSize = true;
            this.lblpBb13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb13.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb13.Location = new System.Drawing.Point(153, 198);
            this.lblpBb13.Name = "lblpBb13";
            this.lblpBb13.Size = new System.Drawing.Size(11, 12);
            this.lblpBb13.TabIndex = 120;
            this.lblpBb13.Text = "0";
            // 
            // lblpBb12
            // 
            this.lblpBb12.AutoSize = true;
            this.lblpBb12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb12.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb12.Location = new System.Drawing.Point(153, 185);
            this.lblpBb12.Name = "lblpBb12";
            this.lblpBb12.Size = new System.Drawing.Size(11, 12);
            this.lblpBb12.TabIndex = 119;
            this.lblpBb12.Text = "0";
            // 
            // lblpBb11
            // 
            this.lblpBb11.AutoSize = true;
            this.lblpBb11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb11.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb11.Location = new System.Drawing.Point(153, 171);
            this.lblpBb11.Name = "lblpBb11";
            this.lblpBb11.Size = new System.Drawing.Size(11, 12);
            this.lblpBb11.TabIndex = 118;
            this.lblpBb11.Text = "0";
            // 
            // lblpBb10
            // 
            this.lblpBb10.AutoSize = true;
            this.lblpBb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb10.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb10.Location = new System.Drawing.Point(153, 157);
            this.lblpBb10.Name = "lblpBb10";
            this.lblpBb10.Size = new System.Drawing.Size(11, 12);
            this.lblpBb10.TabIndex = 117;
            this.lblpBb10.Text = "0";
            // 
            // lblpBb09
            // 
            this.lblpBb09.AutoSize = true;
            this.lblpBb09.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb09.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb09.Location = new System.Drawing.Point(153, 143);
            this.lblpBb09.Name = "lblpBb09";
            this.lblpBb09.Size = new System.Drawing.Size(11, 12);
            this.lblpBb09.TabIndex = 116;
            this.lblpBb09.Text = "0";
            // 
            // lblpBb08
            // 
            this.lblpBb08.AutoSize = true;
            this.lblpBb08.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb08.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb08.Location = new System.Drawing.Point(153, 129);
            this.lblpBb08.Name = "lblpBb08";
            this.lblpBb08.Size = new System.Drawing.Size(11, 12);
            this.lblpBb08.TabIndex = 115;
            this.lblpBb08.Text = "0";
            // 
            // lblpBb07
            // 
            this.lblpBb07.AutoSize = true;
            this.lblpBb07.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb07.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb07.Location = new System.Drawing.Point(153, 115);
            this.lblpBb07.Name = "lblpBb07";
            this.lblpBb07.Size = new System.Drawing.Size(11, 12);
            this.lblpBb07.TabIndex = 114;
            this.lblpBb07.Text = "0";
            // 
            // lblpBb06
            // 
            this.lblpBb06.AutoSize = true;
            this.lblpBb06.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb06.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb06.Location = new System.Drawing.Point(153, 101);
            this.lblpBb06.Name = "lblpBb06";
            this.lblpBb06.Size = new System.Drawing.Size(11, 12);
            this.lblpBb06.TabIndex = 113;
            this.lblpBb06.Text = "0";
            this.lblpBb06.Click += new System.EventHandler(this.label42_Click);
            // 
            // lblpBb05
            // 
            this.lblpBb05.AutoSize = true;
            this.lblpBb05.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb05.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb05.Location = new System.Drawing.Point(153, 87);
            this.lblpBb05.Name = "lblpBb05";
            this.lblpBb05.Size = new System.Drawing.Size(11, 12);
            this.lblpBb05.TabIndex = 112;
            this.lblpBb05.Text = "0";
            // 
            // lblpBb04
            // 
            this.lblpBb04.AutoSize = true;
            this.lblpBb04.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb04.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb04.Location = new System.Drawing.Point(153, 74);
            this.lblpBb04.Name = "lblpBb04";
            this.lblpBb04.Size = new System.Drawing.Size(11, 12);
            this.lblpBb04.TabIndex = 111;
            this.lblpBb04.Text = "0";
            // 
            // lblpBb03
            // 
            this.lblpBb03.AutoSize = true;
            this.lblpBb03.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb03.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb03.Location = new System.Drawing.Point(153, 61);
            this.lblpBb03.Name = "lblpBb03";
            this.lblpBb03.Size = new System.Drawing.Size(11, 12);
            this.lblpBb03.TabIndex = 110;
            this.lblpBb03.Text = "0";
            // 
            // lblpBb02
            // 
            this.lblpBb02.AutoSize = true;
            this.lblpBb02.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb02.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb02.Location = new System.Drawing.Point(153, 48);
            this.lblpBb02.Name = "lblpBb02";
            this.lblpBb02.Size = new System.Drawing.Size(11, 12);
            this.lblpBb02.TabIndex = 109;
            this.lblpBb02.Text = "0";
            // 
            // lblpBb01
            // 
            this.lblpBb01.AutoSize = true;
            this.lblpBb01.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBb01.ForeColor = System.Drawing.Color.Silver;
            this.lblpBb01.Location = new System.Drawing.Point(153, 35);
            this.lblpBb01.Name = "lblpBb01";
            this.lblpBb01.Size = new System.Drawing.Size(11, 12);
            this.lblpBb01.TabIndex = 108;
            this.lblpBb01.Text = "0";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label32.Location = new System.Drawing.Point(96, 22);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(25, 9);
            this.label32.TabIndex = 107;
            this.label32.Text = "RAC";
            // 
            // picBs15
            // 
            this.picBs15.BackColor = System.Drawing.Color.Transparent;
            this.picBs15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs15.Location = new System.Drawing.Point(285, 226);
            this.picBs15.Name = "picBs15";
            this.picBs15.Size = new System.Drawing.Size(10, 9);
            this.picBs15.TabIndex = 105;
            this.picBs15.TabStop = false;
            // 
            // picBs14
            // 
            this.picBs14.BackColor = System.Drawing.Color.Transparent;
            this.picBs14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs14.Location = new System.Drawing.Point(285, 211);
            this.picBs14.Name = "picBs14";
            this.picBs14.Size = new System.Drawing.Size(10, 9);
            this.picBs14.TabIndex = 104;
            this.picBs14.TabStop = false;
            // 
            // picBs13
            // 
            this.picBs13.BackColor = System.Drawing.Color.Transparent;
            this.picBs13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs13.Location = new System.Drawing.Point(285, 197);
            this.picBs13.Name = "picBs13";
            this.picBs13.Size = new System.Drawing.Size(10, 9);
            this.picBs13.TabIndex = 103;
            this.picBs13.TabStop = false;
            // 
            // picBs12
            // 
            this.picBs12.BackColor = System.Drawing.Color.Transparent;
            this.picBs12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs12.Location = new System.Drawing.Point(285, 184);
            this.picBs12.Name = "picBs12";
            this.picBs12.Size = new System.Drawing.Size(10, 9);
            this.picBs12.TabIndex = 102;
            this.picBs12.TabStop = false;
            // 
            // picBs11
            // 
            this.picBs11.BackColor = System.Drawing.Color.Transparent;
            this.picBs11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs11.Location = new System.Drawing.Point(285, 170);
            this.picBs11.Name = "picBs11";
            this.picBs11.Size = new System.Drawing.Size(10, 9);
            this.picBs11.TabIndex = 101;
            this.picBs11.TabStop = false;
            // 
            // picBs10
            // 
            this.picBs10.BackColor = System.Drawing.Color.Transparent;
            this.picBs10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs10.Location = new System.Drawing.Point(285, 156);
            this.picBs10.Name = "picBs10";
            this.picBs10.Size = new System.Drawing.Size(10, 9);
            this.picBs10.TabIndex = 100;
            this.picBs10.TabStop = false;
            // 
            // picBs09
            // 
            this.picBs09.BackColor = System.Drawing.Color.Transparent;
            this.picBs09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs09.Location = new System.Drawing.Point(285, 142);
            this.picBs09.Name = "picBs09";
            this.picBs09.Size = new System.Drawing.Size(10, 9);
            this.picBs09.TabIndex = 99;
            this.picBs09.TabStop = false;
            // 
            // picBs08
            // 
            this.picBs08.BackColor = System.Drawing.Color.Transparent;
            this.picBs08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs08.Location = new System.Drawing.Point(285, 127);
            this.picBs08.Name = "picBs08";
            this.picBs08.Size = new System.Drawing.Size(10, 9);
            this.picBs08.TabIndex = 98;
            this.picBs08.TabStop = false;
            // 
            // picBs07
            // 
            this.picBs07.BackColor = System.Drawing.Color.Transparent;
            this.picBs07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs07.Location = new System.Drawing.Point(285, 113);
            this.picBs07.Name = "picBs07";
            this.picBs07.Size = new System.Drawing.Size(10, 9);
            this.picBs07.TabIndex = 97;
            this.picBs07.TabStop = false;
            // 
            // picBs06
            // 
            this.picBs06.BackColor = System.Drawing.Color.Transparent;
            this.picBs06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs06.Location = new System.Drawing.Point(285, 99);
            this.picBs06.Name = "picBs06";
            this.picBs06.Size = new System.Drawing.Size(10, 9);
            this.picBs06.TabIndex = 96;
            this.picBs06.TabStop = false;
            // 
            // picBs05
            // 
            this.picBs05.BackColor = System.Drawing.Color.Transparent;
            this.picBs05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs05.Location = new System.Drawing.Point(285, 85);
            this.picBs05.Name = "picBs05";
            this.picBs05.Size = new System.Drawing.Size(10, 9);
            this.picBs05.TabIndex = 95;
            this.picBs05.TabStop = false;
            // 
            // picBs04
            // 
            this.picBs04.BackColor = System.Drawing.Color.Transparent;
            this.picBs04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs04.Location = new System.Drawing.Point(285, 72);
            this.picBs04.Name = "picBs04";
            this.picBs04.Size = new System.Drawing.Size(10, 9);
            this.picBs04.TabIndex = 94;
            this.picBs04.TabStop = false;
            // 
            // picBs03
            // 
            this.picBs03.BackColor = System.Drawing.Color.Transparent;
            this.picBs03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs03.Location = new System.Drawing.Point(285, 59);
            this.picBs03.Name = "picBs03";
            this.picBs03.Size = new System.Drawing.Size(10, 9);
            this.picBs03.TabIndex = 93;
            this.picBs03.TabStop = false;
            // 
            // picBs02
            // 
            this.picBs02.BackColor = System.Drawing.Color.Transparent;
            this.picBs02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs02.Location = new System.Drawing.Point(285, 46);
            this.picBs02.Name = "picBs02";
            this.picBs02.Size = new System.Drawing.Size(10, 9);
            this.picBs02.TabIndex = 92;
            this.picBs02.TabStop = false;
            // 
            // picBs01
            // 
            this.picBs01.BackColor = System.Drawing.Color.Transparent;
            this.picBs01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBs01.Location = new System.Drawing.Point(285, 33);
            this.picBs01.Name = "picBs01";
            this.picBs01.Size = new System.Drawing.Size(10, 9);
            this.picBs01.TabIndex = 91;
            this.picBs01.TabStop = false;
            // 
            // lblpBs15
            // 
            this.lblpBs15.AutoSize = true;
            this.lblpBs15.Location = new System.Drawing.Point(327, 213);
            this.lblpBs15.Name = "lblpBs15";
            this.lblpBs15.Size = new System.Drawing.Size(13, 13);
            this.lblpBs15.TabIndex = 90;
            this.lblpBs15.Text = "0";
            this.lblpBs15.Visible = false;
            // 
            // lblpBs14
            // 
            this.lblpBs14.AutoSize = true;
            this.lblpBs14.Location = new System.Drawing.Point(327, 197);
            this.lblpBs14.Name = "lblpBs14";
            this.lblpBs14.Size = new System.Drawing.Size(13, 13);
            this.lblpBs14.TabIndex = 89;
            this.lblpBs14.Text = "0";
            this.lblpBs14.Visible = false;
            // 
            // lblpBs13
            // 
            this.lblpBs13.AutoSize = true;
            this.lblpBs13.Location = new System.Drawing.Point(327, 183);
            this.lblpBs13.Name = "lblpBs13";
            this.lblpBs13.Size = new System.Drawing.Size(13, 13);
            this.lblpBs13.TabIndex = 88;
            this.lblpBs13.Text = "0";
            this.lblpBs13.Visible = false;
            // 
            // lblpBs12
            // 
            this.lblpBs12.AutoSize = true;
            this.lblpBs12.Location = new System.Drawing.Point(327, 169);
            this.lblpBs12.Name = "lblpBs12";
            this.lblpBs12.Size = new System.Drawing.Size(13, 13);
            this.lblpBs12.TabIndex = 87;
            this.lblpBs12.Text = "0";
            this.lblpBs12.Visible = false;
            // 
            // lblpBs11
            // 
            this.lblpBs11.AutoSize = true;
            this.lblpBs11.Location = new System.Drawing.Point(327, 156);
            this.lblpBs11.Name = "lblpBs11";
            this.lblpBs11.Size = new System.Drawing.Size(13, 13);
            this.lblpBs11.TabIndex = 86;
            this.lblpBs11.Text = "0";
            this.lblpBs11.Visible = false;
            // 
            // lblpBs10
            // 
            this.lblpBs10.AutoSize = true;
            this.lblpBs10.Location = new System.Drawing.Point(327, 143);
            this.lblpBs10.Name = "lblpBs10";
            this.lblpBs10.Size = new System.Drawing.Size(13, 13);
            this.lblpBs10.TabIndex = 85;
            this.lblpBs10.Text = "0";
            this.lblpBs10.Visible = false;
            // 
            // lblpBs09
            // 
            this.lblpBs09.AutoSize = true;
            this.lblpBs09.Location = new System.Drawing.Point(327, 130);
            this.lblpBs09.Name = "lblpBs09";
            this.lblpBs09.Size = new System.Drawing.Size(13, 13);
            this.lblpBs09.TabIndex = 84;
            this.lblpBs09.Text = "0";
            this.lblpBs09.Visible = false;
            // 
            // lblpBs08
            // 
            this.lblpBs08.AutoSize = true;
            this.lblpBs08.Location = new System.Drawing.Point(327, 118);
            this.lblpBs08.Name = "lblpBs08";
            this.lblpBs08.Size = new System.Drawing.Size(13, 13);
            this.lblpBs08.TabIndex = 83;
            this.lblpBs08.Text = "0";
            this.lblpBs08.Visible = false;
            // 
            // lblpBs07
            // 
            this.lblpBs07.AutoSize = true;
            this.lblpBs07.Location = new System.Drawing.Point(327, 105);
            this.lblpBs07.Name = "lblpBs07";
            this.lblpBs07.Size = new System.Drawing.Size(13, 13);
            this.lblpBs07.TabIndex = 82;
            this.lblpBs07.Text = "0";
            this.lblpBs07.Visible = false;
            // 
            // lblpBs06
            // 
            this.lblpBs06.AutoSize = true;
            this.lblpBs06.Location = new System.Drawing.Point(327, 92);
            this.lblpBs06.Name = "lblpBs06";
            this.lblpBs06.Size = new System.Drawing.Size(13, 13);
            this.lblpBs06.TabIndex = 81;
            this.lblpBs06.Text = "0";
            this.lblpBs06.Visible = false;
            // 
            // lblpBs05
            // 
            this.lblpBs05.AutoSize = true;
            this.lblpBs05.Location = new System.Drawing.Point(327, 84);
            this.lblpBs05.Name = "lblpBs05";
            this.lblpBs05.Size = new System.Drawing.Size(13, 13);
            this.lblpBs05.TabIndex = 80;
            this.lblpBs05.Text = "0";
            this.lblpBs05.Visible = false;
            // 
            // lblpBs04
            // 
            this.lblpBs04.AutoSize = true;
            this.lblpBs04.Location = new System.Drawing.Point(327, 71);
            this.lblpBs04.Name = "lblpBs04";
            this.lblpBs04.Size = new System.Drawing.Size(13, 13);
            this.lblpBs04.TabIndex = 79;
            this.lblpBs04.Text = "0";
            this.lblpBs04.Visible = false;
            // 
            // lblpBs03
            // 
            this.lblpBs03.AutoSize = true;
            this.lblpBs03.Location = new System.Drawing.Point(327, 58);
            this.lblpBs03.Name = "lblpBs03";
            this.lblpBs03.Size = new System.Drawing.Size(13, 13);
            this.lblpBs03.TabIndex = 78;
            this.lblpBs03.Text = "0";
            this.lblpBs03.Visible = false;
            // 
            // lblpBs02
            // 
            this.lblpBs02.AutoSize = true;
            this.lblpBs02.Location = new System.Drawing.Point(327, 45);
            this.lblpBs02.Name = "lblpBs02";
            this.lblpBs02.Size = new System.Drawing.Size(13, 13);
            this.lblpBs02.TabIndex = 77;
            this.lblpBs02.Text = "0";
            this.lblpBs02.Visible = false;
            // 
            // lblpBs01
            // 
            this.lblpBs01.AutoSize = true;
            this.lblpBs01.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblpBs01.Location = new System.Drawing.Point(327, 32);
            this.lblpBs01.Name = "lblpBs01";
            this.lblpBs01.Size = new System.Drawing.Size(13, 13);
            this.lblpBs01.TabIndex = 76;
            this.lblpBs01.Text = "0";
            this.lblpBs01.Visible = false;
            // 
            // lblpB15
            // 
            this.lblpB15.AutoSize = true;
            this.lblpB15.BackColor = System.Drawing.Color.Transparent;
            this.lblpB15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB15.Location = new System.Drawing.Point(356, 216);
            this.lblpB15.Name = "lblpB15";
            this.lblpB15.Size = new System.Drawing.Size(18, 9);
            this.lblpB15.TabIndex = 44;
            this.lblpB15.Text = "0 %";
            this.lblpB15.Visible = false;
            // 
            // lblpB14
            // 
            this.lblpB14.AutoSize = true;
            this.lblpB14.BackColor = System.Drawing.Color.Transparent;
            this.lblpB14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB14.Location = new System.Drawing.Point(356, 203);
            this.lblpB14.Name = "lblpB14";
            this.lblpB14.Size = new System.Drawing.Size(18, 9);
            this.lblpB14.TabIndex = 43;
            this.lblpB14.Text = "0 %";
            this.lblpB14.Visible = false;
            // 
            // lblpB13
            // 
            this.lblpB13.AutoSize = true;
            this.lblpB13.BackColor = System.Drawing.Color.Transparent;
            this.lblpB13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB13.Location = new System.Drawing.Point(356, 190);
            this.lblpB13.Name = "lblpB13";
            this.lblpB13.Size = new System.Drawing.Size(18, 9);
            this.lblpB13.TabIndex = 42;
            this.lblpB13.Text = "0 %";
            this.lblpB13.Visible = false;
            // 
            // lblpB12
            // 
            this.lblpB12.AutoSize = true;
            this.lblpB12.BackColor = System.Drawing.Color.Transparent;
            this.lblpB12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB12.Location = new System.Drawing.Point(356, 177);
            this.lblpB12.Name = "lblpB12";
            this.lblpB12.Size = new System.Drawing.Size(18, 9);
            this.lblpB12.TabIndex = 41;
            this.lblpB12.Text = "0 %";
            this.lblpB12.Visible = false;
            // 
            // lblpB11
            // 
            this.lblpB11.AutoSize = true;
            this.lblpB11.BackColor = System.Drawing.Color.Transparent;
            this.lblpB11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB11.Location = new System.Drawing.Point(356, 164);
            this.lblpB11.Name = "lblpB11";
            this.lblpB11.Size = new System.Drawing.Size(18, 9);
            this.lblpB11.TabIndex = 40;
            this.lblpB11.Text = "0 %";
            this.lblpB11.Visible = false;
            // 
            // lblpB10
            // 
            this.lblpB10.AutoSize = true;
            this.lblpB10.BackColor = System.Drawing.Color.Transparent;
            this.lblpB10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB10.Location = new System.Drawing.Point(356, 151);
            this.lblpB10.Name = "lblpB10";
            this.lblpB10.Size = new System.Drawing.Size(18, 9);
            this.lblpB10.TabIndex = 39;
            this.lblpB10.Text = "0 %";
            this.lblpB10.Visible = false;
            // 
            // lblpB09
            // 
            this.lblpB09.AutoSize = true;
            this.lblpB09.BackColor = System.Drawing.Color.Transparent;
            this.lblpB09.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB09.Location = new System.Drawing.Point(356, 138);
            this.lblpB09.Name = "lblpB09";
            this.lblpB09.Size = new System.Drawing.Size(18, 9);
            this.lblpB09.TabIndex = 38;
            this.lblpB09.Text = "0 %";
            this.lblpB09.Visible = false;
            // 
            // lblpB08
            // 
            this.lblpB08.AutoSize = true;
            this.lblpB08.BackColor = System.Drawing.Color.Transparent;
            this.lblpB08.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB08.Location = new System.Drawing.Point(356, 126);
            this.lblpB08.Name = "lblpB08";
            this.lblpB08.Size = new System.Drawing.Size(18, 9);
            this.lblpB08.TabIndex = 37;
            this.lblpB08.Text = "0 %";
            this.lblpB08.Visible = false;
            // 
            // lblpB07
            // 
            this.lblpB07.AutoSize = true;
            this.lblpB07.BackColor = System.Drawing.Color.Transparent;
            this.lblpB07.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB07.Location = new System.Drawing.Point(356, 113);
            this.lblpB07.Name = "lblpB07";
            this.lblpB07.Size = new System.Drawing.Size(18, 9);
            this.lblpB07.TabIndex = 36;
            this.lblpB07.Text = "0 %";
            this.lblpB07.Visible = false;
            // 
            // lblpB06
            // 
            this.lblpB06.AutoSize = true;
            this.lblpB06.BackColor = System.Drawing.Color.Transparent;
            this.lblpB06.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB06.Location = new System.Drawing.Point(356, 100);
            this.lblpB06.Name = "lblpB06";
            this.lblpB06.Size = new System.Drawing.Size(18, 9);
            this.lblpB06.TabIndex = 35;
            this.lblpB06.Text = "0 %";
            this.lblpB06.Visible = false;
            // 
            // lblpB05
            // 
            this.lblpB05.AutoSize = true;
            this.lblpB05.BackColor = System.Drawing.Color.Transparent;
            this.lblpB05.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB05.Location = new System.Drawing.Point(356, 87);
            this.lblpB05.Name = "lblpB05";
            this.lblpB05.Size = new System.Drawing.Size(18, 9);
            this.lblpB05.TabIndex = 34;
            this.lblpB05.Text = "0 %";
            this.lblpB05.Visible = false;
            // 
            // lblpB04
            // 
            this.lblpB04.AutoSize = true;
            this.lblpB04.BackColor = System.Drawing.Color.Transparent;
            this.lblpB04.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB04.Location = new System.Drawing.Point(356, 74);
            this.lblpB04.Name = "lblpB04";
            this.lblpB04.Size = new System.Drawing.Size(18, 9);
            this.lblpB04.TabIndex = 33;
            this.lblpB04.Text = "0 %";
            this.lblpB04.Visible = false;
            // 
            // lblpB03
            // 
            this.lblpB03.AutoSize = true;
            this.lblpB03.BackColor = System.Drawing.Color.Transparent;
            this.lblpB03.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB03.Location = new System.Drawing.Point(356, 61);
            this.lblpB03.Name = "lblpB03";
            this.lblpB03.Size = new System.Drawing.Size(18, 9);
            this.lblpB03.TabIndex = 32;
            this.lblpB03.Text = "0 %";
            this.lblpB03.Visible = false;
            // 
            // lblpB02
            // 
            this.lblpB02.AutoSize = true;
            this.lblpB02.BackColor = System.Drawing.Color.Transparent;
            this.lblpB02.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB02.Location = new System.Drawing.Point(356, 48);
            this.lblpB02.Name = "lblpB02";
            this.lblpB02.Size = new System.Drawing.Size(18, 9);
            this.lblpB02.TabIndex = 31;
            this.lblpB02.Text = "0 %";
            this.lblpB02.Visible = false;
            // 
            // lblpB01
            // 
            this.lblpB01.AutoSize = true;
            this.lblpB01.BackColor = System.Drawing.Color.Transparent;
            this.lblpB01.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpB01.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblpB01.Location = new System.Drawing.Point(356, 35);
            this.lblpB01.Name = "lblpB01";
            this.lblpB01.Size = new System.Drawing.Size(18, 9);
            this.lblpB01.TabIndex = 30;
            this.lblpB01.Text = "0 %";
            this.lblpB01.Visible = false;
            // 
            // lblpBc27
            // 
            this.lblpBc27.AutoSize = true;
            this.lblpBc27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc27.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc27.Location = new System.Drawing.Point(25, 40);
            this.lblpBc27.Name = "lblpBc27";
            this.lblpBc27.Size = new System.Drawing.Size(11, 12);
            this.lblpBc27.TabIndex = 329;
            this.lblpBc27.Text = "0";
            // 
            // lblpBc26
            // 
            this.lblpBc26.AutoSize = true;
            this.lblpBc26.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc26.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc26.Location = new System.Drawing.Point(25, 37);
            this.lblpBc26.Name = "lblpBc26";
            this.lblpBc26.Size = new System.Drawing.Size(11, 12);
            this.lblpBc26.TabIndex = 320;
            this.lblpBc26.Text = "0";
            // 
            // lblpBc25
            // 
            this.lblpBc25.AutoSize = true;
            this.lblpBc25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc25.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc25.Location = new System.Drawing.Point(22, 40);
            this.lblpBc25.Name = "lblpBc25";
            this.lblpBc25.Size = new System.Drawing.Size(11, 12);
            this.lblpBc25.TabIndex = 311;
            this.lblpBc25.Text = "0";
            // 
            // lblpBc24
            // 
            this.lblpBc24.AutoSize = true;
            this.lblpBc24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc24.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc24.Location = new System.Drawing.Point(26, 38);
            this.lblpBc24.Name = "lblpBc24";
            this.lblpBc24.Size = new System.Drawing.Size(11, 12);
            this.lblpBc24.TabIndex = 302;
            this.lblpBc24.Text = "0";
            // 
            // lblpBc23
            // 
            this.lblpBc23.AutoSize = true;
            this.lblpBc23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc23.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc23.Location = new System.Drawing.Point(26, 43);
            this.lblpBc23.Name = "lblpBc23";
            this.lblpBc23.Size = new System.Drawing.Size(11, 12);
            this.lblpBc23.TabIndex = 293;
            this.lblpBc23.Text = "0";
            // 
            // lblpBc22
            // 
            this.lblpBc22.AutoSize = true;
            this.lblpBc22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc22.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc22.Location = new System.Drawing.Point(27, 38);
            this.lblpBc22.Name = "lblpBc22";
            this.lblpBc22.Size = new System.Drawing.Size(11, 12);
            this.lblpBc22.TabIndex = 249;
            this.lblpBc22.Text = "0";
            // 
            // lblpBc21
            // 
            this.lblpBc21.AutoSize = true;
            this.lblpBc21.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc21.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc21.Location = new System.Drawing.Point(22, 38);
            this.lblpBc21.Name = "lblpBc21";
            this.lblpBc21.Size = new System.Drawing.Size(11, 12);
            this.lblpBc21.TabIndex = 224;
            this.lblpBc21.Text = "0";
            // 
            // lblpBc28
            // 
            this.lblpBc28.AutoSize = true;
            this.lblpBc28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc28.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc28.Location = new System.Drawing.Point(22, 44);
            this.lblpBc28.Name = "lblpBc28";
            this.lblpBc28.Size = new System.Drawing.Size(11, 12);
            this.lblpBc28.TabIndex = 338;
            this.lblpBc28.Text = "0";
            // 
            // picMov22
            // 
            this.picMov22.BackColor = System.Drawing.Color.Transparent;
            this.picMov22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov22.Location = new System.Drawing.Point(44, 5);
            this.picMov22.Name = "picMov22";
            this.picMov22.Size = new System.Drawing.Size(10, 9);
            this.picMov22.TabIndex = 314;
            this.picMov22.TabStop = false;
            // 
            // picMov21
            // 
            this.picMov21.BackColor = System.Drawing.Color.Transparent;
            this.picMov21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov21.Location = new System.Drawing.Point(41, 5);
            this.picMov21.Name = "picMov21";
            this.picMov21.Size = new System.Drawing.Size(10, 9);
            this.picMov21.TabIndex = 313;
            this.picMov21.TabStop = false;
            // 
            // pBar22
            // 
            this.pBar22.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar22.Location = new System.Drawing.Point(24, 94);
            this.pBar22.Maximum = 500;
            this.pBar22.Name = "pBar22";
            this.pBar22.Size = new System.Drawing.Size(20, 3);
            this.pBar22.TabIndex = 279;
            // 
            // pBar21
            // 
            this.pBar21.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar21.Location = new System.Drawing.Point(21, 94);
            this.pBar21.Maximum = 500;
            this.pBar21.Name = "pBar21";
            this.pBar21.Size = new System.Drawing.Size(20, 3);
            this.pBar21.TabIndex = 273;
            // 
            // lblpAct22
            // 
            this.lblpAct22.AutoSize = true;
            this.lblpAct22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct22.ForeColor = System.Drawing.Color.Black;
            this.lblpAct22.Location = new System.Drawing.Point(7, 88);
            this.lblpAct22.Name = "lblpAct22";
            this.lblpAct22.Size = new System.Drawing.Size(11, 12);
            this.lblpAct22.TabIndex = 268;
            this.lblpAct22.Text = "_";
            // 
            // lblpAct21
            // 
            this.lblpAct21.AutoSize = true;
            this.lblpAct21.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct21.ForeColor = System.Drawing.Color.Black;
            this.lblpAct21.Location = new System.Drawing.Point(3, 88);
            this.lblpAct21.Name = "lblpAct21";
            this.lblpAct21.Size = new System.Drawing.Size(11, 12);
            this.lblpAct21.TabIndex = 267;
            this.lblpAct21.Text = "_";
            // 
            // lblpBr22
            // 
            this.lblpBr22.AutoSize = true;
            this.lblpBr22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr22.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr22.Location = new System.Drawing.Point(18, 79);
            this.lblpBr22.Name = "lblpBr22";
            this.lblpBr22.Size = new System.Drawing.Size(11, 12);
            this.lblpBr22.TabIndex = 251;
            this.lblpBr22.Text = "_";
            // 
            // lblCam22
            // 
            this.lblCam22.AutoSize = true;
            this.lblCam22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam22.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam22.Location = new System.Drawing.Point(10, 8);
            this.lblCam22.Name = "lblCam22";
            this.lblCam22.Size = new System.Drawing.Size(45, 30);
            this.lblCam22.TabIndex = 248;
            this.lblCam22.Text = "22";
            this.lblCam22.Click += new System.EventHandler(this.lblCam22_Click);
            // 
            // lblpBr21
            // 
            this.lblpBr21.AutoSize = true;
            this.lblpBr21.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr21.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr21.Location = new System.Drawing.Point(17, 79);
            this.lblpBr21.Name = "lblpBr21";
            this.lblpBr21.Size = new System.Drawing.Size(11, 12);
            this.lblpBr21.TabIndex = 229;
            this.lblpBr21.Text = "_";
            // 
            // lblCam21
            // 
            this.lblCam21.AutoSize = true;
            this.lblCam21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam21.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam21.Location = new System.Drawing.Point(10, 6);
            this.lblCam21.Name = "lblCam21";
            this.lblCam21.Size = new System.Drawing.Size(45, 30);
            this.lblCam21.TabIndex = 219;
            this.lblCam21.Text = "21";
            this.lblCam21.Click += new System.EventHandler(this.lblCam21_Click);
            // 
            // lblpAct17
            // 
            this.lblpAct17.AutoSize = true;
            this.lblpAct17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct17.ForeColor = System.Drawing.Color.Black;
            this.lblpAct17.Location = new System.Drawing.Point(7, 88);
            this.lblpAct17.Name = "lblpAct17";
            this.lblpAct17.Size = new System.Drawing.Size(11, 12);
            this.lblpAct17.TabIndex = 263;
            this.lblpAct17.Text = "_";
            // 
            // lblpAct20
            // 
            this.lblpAct20.AutoSize = true;
            this.lblpAct20.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct20.ForeColor = System.Drawing.Color.Black;
            this.lblpAct20.Location = new System.Drawing.Point(7, 88);
            this.lblpAct20.Name = "lblpAct20";
            this.lblpAct20.Size = new System.Drawing.Size(11, 12);
            this.lblpAct20.TabIndex = 266;
            this.lblpAct20.Text = "_";
            // 
            // lblpAct16
            // 
            this.lblpAct16.AutoSize = true;
            this.lblpAct16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct16.ForeColor = System.Drawing.Color.Black;
            this.lblpAct16.Location = new System.Drawing.Point(7, 87);
            this.lblpAct16.Name = "lblpAct16";
            this.lblpAct16.Size = new System.Drawing.Size(11, 12);
            this.lblpAct16.TabIndex = 213;
            this.lblpAct16.Text = "_";
            // 
            // lblpAct15
            // 
            this.lblpAct15.AutoSize = true;
            this.lblpAct15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct15.ForeColor = System.Drawing.Color.Black;
            this.lblpAct15.Location = new System.Drawing.Point(7, 87);
            this.lblpAct15.Name = "lblpAct15";
            this.lblpAct15.Size = new System.Drawing.Size(11, 12);
            this.lblpAct15.TabIndex = 212;
            this.lblpAct15.Text = "_";
            // 
            // lblpAct14
            // 
            this.lblpAct14.AutoSize = true;
            this.lblpAct14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct14.ForeColor = System.Drawing.Color.Black;
            this.lblpAct14.Location = new System.Drawing.Point(7, 87);
            this.lblpAct14.Name = "lblpAct14";
            this.lblpAct14.Size = new System.Drawing.Size(11, 12);
            this.lblpAct14.TabIndex = 211;
            this.lblpAct14.Text = "_";
            // 
            // lblpAct13
            // 
            this.lblpAct13.AutoSize = true;
            this.lblpAct13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct13.ForeColor = System.Drawing.Color.Black;
            this.lblpAct13.Location = new System.Drawing.Point(9, 88);
            this.lblpAct13.Name = "lblpAct13";
            this.lblpAct13.Size = new System.Drawing.Size(11, 12);
            this.lblpAct13.TabIndex = 210;
            this.lblpAct13.Text = "_";
            // 
            // lblpAct12
            // 
            this.lblpAct12.AutoSize = true;
            this.lblpAct12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct12.ForeColor = System.Drawing.Color.Black;
            this.lblpAct12.Location = new System.Drawing.Point(7, 88);
            this.lblpAct12.Name = "lblpAct12";
            this.lblpAct12.Size = new System.Drawing.Size(11, 12);
            this.lblpAct12.TabIndex = 209;
            this.lblpAct12.Text = "_";
            // 
            // lblpAct11
            // 
            this.lblpAct11.AutoSize = true;
            this.lblpAct11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct11.ForeColor = System.Drawing.Color.Black;
            this.lblpAct11.Location = new System.Drawing.Point(5, 87);
            this.lblpAct11.Name = "lblpAct11";
            this.lblpAct11.Size = new System.Drawing.Size(11, 12);
            this.lblpAct11.TabIndex = 208;
            this.lblpAct11.Text = "_";
            // 
            // lblpAct10
            // 
            this.lblpAct10.AutoSize = true;
            this.lblpAct10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct10.ForeColor = System.Drawing.Color.Black;
            this.lblpAct10.Location = new System.Drawing.Point(3, 88);
            this.lblpAct10.Name = "lblpAct10";
            this.lblpAct10.Size = new System.Drawing.Size(11, 12);
            this.lblpAct10.TabIndex = 207;
            this.lblpAct10.Text = "_";
            // 
            // lblpAct09
            // 
            this.lblpAct09.AutoSize = true;
            this.lblpAct09.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct09.ForeColor = System.Drawing.Color.Black;
            this.lblpAct09.Location = new System.Drawing.Point(4, 87);
            this.lblpAct09.Name = "lblpAct09";
            this.lblpAct09.Size = new System.Drawing.Size(11, 12);
            this.lblpAct09.TabIndex = 206;
            this.lblpAct09.Text = "_";
            // 
            // lblpAct08
            // 
            this.lblpAct08.AutoSize = true;
            this.lblpAct08.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct08.ForeColor = System.Drawing.Color.Black;
            this.lblpAct08.Location = new System.Drawing.Point(6, 85);
            this.lblpAct08.Name = "lblpAct08";
            this.lblpAct08.Size = new System.Drawing.Size(11, 12);
            this.lblpAct08.TabIndex = 205;
            this.lblpAct08.Text = "_";
            // 
            // lblpAct07
            // 
            this.lblpAct07.AutoSize = true;
            this.lblpAct07.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct07.ForeColor = System.Drawing.Color.Black;
            this.lblpAct07.Location = new System.Drawing.Point(4, 85);
            this.lblpAct07.Name = "lblpAct07";
            this.lblpAct07.Size = new System.Drawing.Size(11, 12);
            this.lblpAct07.TabIndex = 204;
            this.lblpAct07.Text = "_";
            // 
            // lblpAct06
            // 
            this.lblpAct06.AutoSize = true;
            this.lblpAct06.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct06.ForeColor = System.Drawing.Color.Black;
            this.lblpAct06.Location = new System.Drawing.Point(3, 85);
            this.lblpAct06.Name = "lblpAct06";
            this.lblpAct06.Size = new System.Drawing.Size(11, 12);
            this.lblpAct06.TabIndex = 203;
            this.lblpAct06.Text = "_";
            // 
            // lblpAct05
            // 
            this.lblpAct05.AutoSize = true;
            this.lblpAct05.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct05.ForeColor = System.Drawing.Color.Black;
            this.lblpAct05.Location = new System.Drawing.Point(4, 87);
            this.lblpAct05.Name = "lblpAct05";
            this.lblpAct05.Size = new System.Drawing.Size(11, 12);
            this.lblpAct05.TabIndex = 202;
            this.lblpAct05.Text = "_";
            // 
            // lblpAct04
            // 
            this.lblpAct04.AutoSize = true;
            this.lblpAct04.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct04.ForeColor = System.Drawing.Color.Black;
            this.lblpAct04.Location = new System.Drawing.Point(6, 87);
            this.lblpAct04.Name = "lblpAct04";
            this.lblpAct04.Size = new System.Drawing.Size(11, 12);
            this.lblpAct04.TabIndex = 201;
            this.lblpAct04.Text = "_";
            // 
            // lblpAct03
            // 
            this.lblpAct03.AutoSize = true;
            this.lblpAct03.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct03.ForeColor = System.Drawing.Color.Black;
            this.lblpAct03.Location = new System.Drawing.Point(3, 87);
            this.lblpAct03.Name = "lblpAct03";
            this.lblpAct03.Size = new System.Drawing.Size(11, 12);
            this.lblpAct03.TabIndex = 200;
            this.lblpAct03.Text = "_";
            // 
            // lblpAct02
            // 
            this.lblpAct02.AutoSize = true;
            this.lblpAct02.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct02.ForeColor = System.Drawing.Color.Black;
            this.lblpAct02.Location = new System.Drawing.Point(7, 85);
            this.lblpAct02.Name = "lblpAct02";
            this.lblpAct02.Size = new System.Drawing.Size(11, 12);
            this.lblpAct02.TabIndex = 199;
            this.lblpAct02.Text = "_";
            // 
            // lblpAct01
            // 
            this.lblpAct01.AutoSize = true;
            this.lblpAct01.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct01.ForeColor = System.Drawing.Color.Black;
            this.lblpAct01.Location = new System.Drawing.Point(17, 37);
            this.lblpAct01.Name = "lblpAct01";
            this.lblpAct01.Size = new System.Drawing.Size(11, 12);
            this.lblpAct01.TabIndex = 198;
            this.lblpAct01.Text = "_";
            this.lblpAct01.Visible = false;
            // 
            // lblpAct19
            // 
            this.lblpAct19.AutoSize = true;
            this.lblpAct19.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct19.ForeColor = System.Drawing.Color.Black;
            this.lblpAct19.Location = new System.Drawing.Point(7, 88);
            this.lblpAct19.Name = "lblpAct19";
            this.lblpAct19.Size = new System.Drawing.Size(11, 12);
            this.lblpAct19.TabIndex = 265;
            this.lblpAct19.Text = "_";
            // 
            // lblpAct18
            // 
            this.lblpAct18.AutoSize = true;
            this.lblpAct18.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct18.ForeColor = System.Drawing.Color.Black;
            this.lblpAct18.Location = new System.Drawing.Point(7, 88);
            this.lblpAct18.Name = "lblpAct18";
            this.lblpAct18.Size = new System.Drawing.Size(11, 12);
            this.lblpAct18.TabIndex = 264;
            this.lblpAct18.Text = "_";
            // 
            // pBar17
            // 
            this.pBar17.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar17.Location = new System.Drawing.Point(9, 94);
            this.pBar17.Maximum = 500;
            this.pBar17.Name = "pBar17";
            this.pBar17.Size = new System.Drawing.Size(20, 3);
            this.pBar17.TabIndex = 269;
            // 
            // pBar20
            // 
            this.pBar20.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar20.Location = new System.Drawing.Point(6, 94);
            this.pBar20.Maximum = 500;
            this.pBar20.Name = "pBar20";
            this.pBar20.Size = new System.Drawing.Size(20, 3);
            this.pBar20.TabIndex = 272;
            // 
            // pBar19
            // 
            this.pBar19.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar19.Location = new System.Drawing.Point(7, 94);
            this.pBar19.Maximum = 500;
            this.pBar19.Name = "pBar19";
            this.pBar19.Size = new System.Drawing.Size(20, 3);
            this.pBar19.TabIndex = 271;
            // 
            // pBar18
            // 
            this.pBar18.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar18.Location = new System.Drawing.Point(9, 94);
            this.pBar18.Maximum = 500;
            this.pBar18.Name = "pBar18";
            this.pBar18.Size = new System.Drawing.Size(20, 3);
            this.pBar18.TabIndex = 270;
            // 
            // pBar16
            // 
            this.pBar16.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar16.Location = new System.Drawing.Point(6, 92);
            this.pBar16.Maximum = 500;
            this.pBar16.Name = "pBar16";
            this.pBar16.Size = new System.Drawing.Size(20, 3);
            this.pBar16.TabIndex = 176;
            // 
            // pBar15
            // 
            this.pBar15.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar15.Location = new System.Drawing.Point(0, 93);
            this.pBar15.Maximum = 500;
            this.pBar15.Name = "pBar15";
            this.pBar15.Size = new System.Drawing.Size(20, 3);
            this.pBar15.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar15.TabIndex = 28;
            // 
            // pBar14
            // 
            this.pBar14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar14.Location = new System.Drawing.Point(9, 92);
            this.pBar14.Maximum = 500;
            this.pBar14.Name = "pBar14";
            this.pBar14.Size = new System.Drawing.Size(20, 3);
            this.pBar14.TabIndex = 26;
            // 
            // pBar13
            // 
            this.pBar13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar13.Location = new System.Drawing.Point(6, 92);
            this.pBar13.Maximum = 500;
            this.pBar13.Name = "pBar13";
            this.pBar13.Size = new System.Drawing.Size(20, 3);
            this.pBar13.TabIndex = 24;
            // 
            // pBar12
            // 
            this.pBar12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar12.Location = new System.Drawing.Point(6, 92);
            this.pBar12.Maximum = 500;
            this.pBar12.Name = "pBar12";
            this.pBar12.Size = new System.Drawing.Size(20, 3);
            this.pBar12.TabIndex = 22;
            // 
            // pBar11
            // 
            this.pBar11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar11.Location = new System.Drawing.Point(3, 94);
            this.pBar11.Maximum = 500;
            this.pBar11.Name = "pBar11";
            this.pBar11.Size = new System.Drawing.Size(20, 3);
            this.pBar11.TabIndex = 20;
            // 
            // pBar10
            // 
            this.pBar10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar10.Location = new System.Drawing.Point(11, 94);
            this.pBar10.Maximum = 500;
            this.pBar10.Name = "pBar10";
            this.pBar10.Size = new System.Drawing.Size(20, 3);
            this.pBar10.TabIndex = 18;
            // 
            // pBar09
            // 
            this.pBar09.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar09.Location = new System.Drawing.Point(3, 95);
            this.pBar09.Maximum = 500;
            this.pBar09.Name = "pBar09";
            this.pBar09.Size = new System.Drawing.Size(20, 3);
            this.pBar09.TabIndex = 16;
            // 
            // pBar08
            // 
            this.pBar08.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar08.Location = new System.Drawing.Point(4, 94);
            this.pBar08.Maximum = 500;
            this.pBar08.Name = "pBar08";
            this.pBar08.Size = new System.Drawing.Size(20, 3);
            this.pBar08.TabIndex = 14;
            // 
            // pBar07
            // 
            this.pBar07.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar07.Location = new System.Drawing.Point(6, 93);
            this.pBar07.Maximum = 500;
            this.pBar07.Name = "pBar07";
            this.pBar07.Size = new System.Drawing.Size(20, 3);
            this.pBar07.TabIndex = 12;
            // 
            // pBar06
            // 
            this.pBar06.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar06.Location = new System.Drawing.Point(3, 92);
            this.pBar06.Maximum = 500;
            this.pBar06.Name = "pBar06";
            this.pBar06.Size = new System.Drawing.Size(20, 3);
            this.pBar06.TabIndex = 10;
            // 
            // pBar05
            // 
            this.pBar05.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar05.Location = new System.Drawing.Point(8, 94);
            this.pBar05.Maximum = 500;
            this.pBar05.Name = "pBar05";
            this.pBar05.Size = new System.Drawing.Size(20, 3);
            this.pBar05.TabIndex = 8;
            // 
            // pBar04
            // 
            this.pBar04.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar04.Location = new System.Drawing.Point(6, 94);
            this.pBar04.Maximum = 500;
            this.pBar04.Name = "pBar04";
            this.pBar04.Size = new System.Drawing.Size(20, 3);
            this.pBar04.TabIndex = 6;
            // 
            // pBar03
            // 
            this.pBar03.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar03.Location = new System.Drawing.Point(12, 94);
            this.pBar03.Maximum = 500;
            this.pBar03.Name = "pBar03";
            this.pBar03.Size = new System.Drawing.Size(20, 3);
            this.pBar03.TabIndex = 4;
            // 
            // pBar02
            // 
            this.pBar02.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar02.Location = new System.Drawing.Point(3, 94);
            this.pBar02.Maximum = 500;
            this.pBar02.Name = "pBar02";
            this.pBar02.Size = new System.Drawing.Size(20, 3);
            this.pBar02.TabIndex = 2;
            // 
            // pBar01
            // 
            this.pBar01.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar01.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBar01.Location = new System.Drawing.Point(0, 35);
            this.pBar01.Maximum = 500;
            this.pBar01.Name = "pBar01";
            this.pBar01.Size = new System.Drawing.Size(47, 0);
            this.pBar01.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar01.TabIndex = 0;
            this.pBar01.Visible = false;
            // 
            // picMov20
            // 
            this.picMov20.BackColor = System.Drawing.Color.Transparent;
            this.picMov20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov20.Location = new System.Drawing.Point(45, 5);
            this.picMov20.Name = "picMov20";
            this.picMov20.Size = new System.Drawing.Size(10, 9);
            this.picMov20.TabIndex = 312;
            this.picMov20.TabStop = false;
            // 
            // picMov19
            // 
            this.picMov19.BackColor = System.Drawing.Color.Transparent;
            this.picMov19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov19.Location = new System.Drawing.Point(43, 7);
            this.picMov19.Name = "picMov19";
            this.picMov19.Size = new System.Drawing.Size(10, 9);
            this.picMov19.TabIndex = 311;
            this.picMov19.TabStop = false;
            // 
            // picMov18
            // 
            this.picMov18.BackColor = System.Drawing.Color.Transparent;
            this.picMov18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov18.Location = new System.Drawing.Point(45, 5);
            this.picMov18.Name = "picMov18";
            this.picMov18.Size = new System.Drawing.Size(10, 9);
            this.picMov18.TabIndex = 310;
            this.picMov18.TabStop = false;
            // 
            // picMov15
            // 
            this.picMov15.BackColor = System.Drawing.Color.Transparent;
            this.picMov15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov15.Location = new System.Drawing.Point(43, 3);
            this.picMov15.Name = "picMov15";
            this.picMov15.Size = new System.Drawing.Size(10, 9);
            this.picMov15.TabIndex = 307;
            this.picMov15.TabStop = false;
            // 
            // picMov14
            // 
            this.picMov14.BackColor = System.Drawing.Color.Transparent;
            this.picMov14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov14.Location = new System.Drawing.Point(45, 3);
            this.picMov14.Name = "picMov14";
            this.picMov14.Size = new System.Drawing.Size(10, 9);
            this.picMov14.TabIndex = 306;
            this.picMov14.TabStop = false;
            // 
            // picMov13
            // 
            this.picMov13.BackColor = System.Drawing.Color.Transparent;
            this.picMov13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov13.Location = new System.Drawing.Point(44, 3);
            this.picMov13.Name = "picMov13";
            this.picMov13.Size = new System.Drawing.Size(10, 9);
            this.picMov13.TabIndex = 305;
            this.picMov13.TabStop = false;
            // 
            // picMov12
            // 
            this.picMov12.BackColor = System.Drawing.Color.Transparent;
            this.picMov12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov12.Location = new System.Drawing.Point(45, 3);
            this.picMov12.Name = "picMov12";
            this.picMov12.Size = new System.Drawing.Size(10, 9);
            this.picMov12.TabIndex = 304;
            this.picMov12.TabStop = false;
            // 
            // picMov11
            // 
            this.picMov11.BackColor = System.Drawing.Color.Transparent;
            this.picMov11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov11.Location = new System.Drawing.Point(45, 4);
            this.picMov11.Name = "picMov11";
            this.picMov11.Size = new System.Drawing.Size(10, 9);
            this.picMov11.TabIndex = 303;
            this.picMov11.TabStop = false;
            // 
            // picMov10
            // 
            this.picMov10.BackColor = System.Drawing.Color.Transparent;
            this.picMov10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov10.Location = new System.Drawing.Point(45, 4);
            this.picMov10.Name = "picMov10";
            this.picMov10.Size = new System.Drawing.Size(10, 9);
            this.picMov10.TabIndex = 302;
            this.picMov10.TabStop = false;
            // 
            // picMov09
            // 
            this.picMov09.BackColor = System.Drawing.Color.Transparent;
            this.picMov09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov09.Location = new System.Drawing.Point(44, 4);
            this.picMov09.Name = "picMov09";
            this.picMov09.Size = new System.Drawing.Size(10, 9);
            this.picMov09.TabIndex = 301;
            this.picMov09.TabStop = false;
            // 
            // picMov08
            // 
            this.picMov08.BackColor = System.Drawing.Color.Transparent;
            this.picMov08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov08.Location = new System.Drawing.Point(45, 3);
            this.picMov08.Name = "picMov08";
            this.picMov08.Size = new System.Drawing.Size(10, 9);
            this.picMov08.TabIndex = 300;
            this.picMov08.TabStop = false;
            // 
            // picMov07
            // 
            this.picMov07.BackColor = System.Drawing.Color.Transparent;
            this.picMov07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov07.Location = new System.Drawing.Point(45, 3);
            this.picMov07.Name = "picMov07";
            this.picMov07.Size = new System.Drawing.Size(10, 9);
            this.picMov07.TabIndex = 299;
            this.picMov07.TabStop = false;
            // 
            // picMov06
            // 
            this.picMov06.BackColor = System.Drawing.Color.Transparent;
            this.picMov06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov06.Location = new System.Drawing.Point(45, 3);
            this.picMov06.Name = "picMov06";
            this.picMov06.Size = new System.Drawing.Size(10, 9);
            this.picMov06.TabIndex = 298;
            this.picMov06.TabStop = false;
            // 
            // picMov05
            // 
            this.picMov05.BackColor = System.Drawing.Color.Transparent;
            this.picMov05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov05.Location = new System.Drawing.Point(44, 3);
            this.picMov05.Name = "picMov05";
            this.picMov05.Size = new System.Drawing.Size(10, 9);
            this.picMov05.TabIndex = 297;
            this.picMov05.TabStop = false;
            // 
            // picMov04
            // 
            this.picMov04.BackColor = System.Drawing.Color.Transparent;
            this.picMov04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov04.Location = new System.Drawing.Point(45, 3);
            this.picMov04.Name = "picMov04";
            this.picMov04.Size = new System.Drawing.Size(10, 9);
            this.picMov04.TabIndex = 296;
            this.picMov04.TabStop = false;
            // 
            // picMov03
            // 
            this.picMov03.BackColor = System.Drawing.Color.Transparent;
            this.picMov03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov03.Location = new System.Drawing.Point(45, 3);
            this.picMov03.Name = "picMov03";
            this.picMov03.Size = new System.Drawing.Size(10, 9);
            this.picMov03.TabIndex = 295;
            this.picMov03.TabStop = false;
            // 
            // picMov02
            // 
            this.picMov02.BackColor = System.Drawing.Color.Transparent;
            this.picMov02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov02.Location = new System.Drawing.Point(45, 3);
            this.picMov02.Name = "picMov02";
            this.picMov02.Size = new System.Drawing.Size(10, 9);
            this.picMov02.TabIndex = 294;
            this.picMov02.TabStop = false;
            // 
            // picMov01
            // 
            this.picMov01.BackColor = System.Drawing.Color.Transparent;
            this.picMov01.Location = new System.Drawing.Point(34, 3);
            this.picMov01.Name = "picMov01";
            this.picMov01.Size = new System.Drawing.Size(1, 1);
            this.picMov01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMov01.TabIndex = 293;
            this.picMov01.TabStop = false;
            // 
            // lblpBr20
            // 
            this.lblpBr20.AutoSize = true;
            this.lblpBr20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr20.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr20.Location = new System.Drawing.Point(16, 63);
            this.lblpBr20.Name = "lblpBr20";
            this.lblpBr20.Size = new System.Drawing.Size(23, 25);
            this.lblpBr20.TabIndex = 228;
            this.lblpBr20.Text = "_";
            // 
            // lblpBr19
            // 
            this.lblpBr19.AutoSize = true;
            this.lblpBr19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr19.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr19.Location = new System.Drawing.Point(13, 70);
            this.lblpBr19.Name = "lblpBr19";
            this.lblpBr19.Size = new System.Drawing.Size(23, 25);
            this.lblpBr19.TabIndex = 227;
            this.lblpBr19.Text = "_";
            // 
            // lblpBr18
            // 
            this.lblpBr18.AutoSize = true;
            this.lblpBr18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr18.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr18.Location = new System.Drawing.Point(13, 63);
            this.lblpBr18.Name = "lblpBr18";
            this.lblpBr18.Size = new System.Drawing.Size(23, 25);
            this.lblpBr18.TabIndex = 226;
            this.lblpBr18.Text = "_";
            // 
            // lblpBc20
            // 
            this.lblpBc20.AutoSize = true;
            this.lblpBc20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc20.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc20.Location = new System.Drawing.Point(16, 44);
            this.lblpBc20.Name = "lblpBc20";
            this.lblpBc20.Size = new System.Drawing.Size(23, 25);
            this.lblpBc20.TabIndex = 223;
            this.lblpBc20.Text = "0";
            // 
            // lblpBc19
            // 
            this.lblpBc19.AutoSize = true;
            this.lblpBc19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc19.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc19.Location = new System.Drawing.Point(13, 45);
            this.lblpBc19.Name = "lblpBc19";
            this.lblpBc19.Size = new System.Drawing.Size(23, 25);
            this.lblpBc19.TabIndex = 222;
            this.lblpBc19.Text = "0";
            // 
            // lblpBc18
            // 
            this.lblpBc18.AutoSize = true;
            this.lblpBc18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc18.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc18.Location = new System.Drawing.Point(13, 37);
            this.lblpBc18.Name = "lblpBc18";
            this.lblpBc18.Size = new System.Drawing.Size(23, 25);
            this.lblpBc18.TabIndex = 221;
            this.lblpBc18.Text = "0";
            // 
            // lblCam20
            // 
            this.lblCam20.AutoSize = true;
            this.lblCam20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam20.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam20.Location = new System.Drawing.Point(12, 8);
            this.lblCam20.Name = "lblCam20";
            this.lblCam20.Size = new System.Drawing.Size(45, 30);
            this.lblCam20.TabIndex = 218;
            this.lblCam20.Text = "20";
            this.lblCam20.Click += new System.EventHandler(this.lblCam20_Click);
            // 
            // lblCam19
            // 
            this.lblCam19.AutoSize = true;
            this.lblCam19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam19.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam19.Location = new System.Drawing.Point(9, 8);
            this.lblCam19.Name = "lblCam19";
            this.lblCam19.Size = new System.Drawing.Size(45, 30);
            this.lblCam19.TabIndex = 217;
            this.lblCam19.Text = "19";
            this.lblCam19.Click += new System.EventHandler(this.lblCam19_Click);
            // 
            // lblCam18
            // 
            this.lblCam18.AutoSize = true;
            this.lblCam18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam18.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam18.Location = new System.Drawing.Point(12, 7);
            this.lblCam18.Name = "lblCam18";
            this.lblCam18.Size = new System.Drawing.Size(45, 30);
            this.lblCam18.TabIndex = 216;
            this.lblCam18.Text = "18";
            this.lblCam18.Click += new System.EventHandler(this.lblCam18_Click);
            // 
            // lblpBr15
            // 
            this.lblpBr15.AutoSize = true;
            this.lblpBr15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr15.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr15.Location = new System.Drawing.Point(13, 68);
            this.lblpBr15.Name = "lblpBr15";
            this.lblpBr15.Size = new System.Drawing.Size(23, 25);
            this.lblpBr15.TabIndex = 75;
            this.lblpBr15.Text = "_";
            // 
            // lblpBr14
            // 
            this.lblpBr14.AutoSize = true;
            this.lblpBr14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr14.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr14.Location = new System.Drawing.Point(13, 63);
            this.lblpBr14.Name = "lblpBr14";
            this.lblpBr14.Size = new System.Drawing.Size(23, 25);
            this.lblpBr14.TabIndex = 74;
            this.lblpBr14.Text = "_";
            // 
            // lblpBr13
            // 
            this.lblpBr13.AutoSize = true;
            this.lblpBr13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr13.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr13.Location = new System.Drawing.Point(15, 60);
            this.lblpBr13.Name = "lblpBr13";
            this.lblpBr13.Size = new System.Drawing.Size(23, 25);
            this.lblpBr13.TabIndex = 73;
            this.lblpBr13.Text = "_";
            // 
            // lblpBr12
            // 
            this.lblpBr12.AutoSize = true;
            this.lblpBr12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr12.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr12.Location = new System.Drawing.Point(12, 69);
            this.lblpBr12.Name = "lblpBr12";
            this.lblpBr12.Size = new System.Drawing.Size(23, 25);
            this.lblpBr12.TabIndex = 72;
            this.lblpBr12.Text = "_";
            // 
            // lblpBr11
            // 
            this.lblpBr11.AutoSize = true;
            this.lblpBr11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr11.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr11.Location = new System.Drawing.Point(13, 70);
            this.lblpBr11.Name = "lblpBr11";
            this.lblpBr11.Size = new System.Drawing.Size(23, 25);
            this.lblpBr11.TabIndex = 71;
            this.lblpBr11.Text = "_";
            // 
            // lblpBr10
            // 
            this.lblpBr10.AutoSize = true;
            this.lblpBr10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr10.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr10.Location = new System.Drawing.Point(13, 63);
            this.lblpBr10.Name = "lblpBr10";
            this.lblpBr10.Size = new System.Drawing.Size(23, 25);
            this.lblpBr10.TabIndex = 70;
            this.lblpBr10.Text = "_";
            // 
            // lblpBr09
            // 
            this.lblpBr09.AutoSize = true;
            this.lblpBr09.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr09.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr09.Location = new System.Drawing.Point(16, 63);
            this.lblpBr09.Name = "lblpBr09";
            this.lblpBr09.Size = new System.Drawing.Size(23, 25);
            this.lblpBr09.TabIndex = 69;
            this.lblpBr09.Text = "_";
            // 
            // lblpBr08
            // 
            this.lblpBr08.AutoSize = true;
            this.lblpBr08.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr08.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr08.Location = new System.Drawing.Point(16, 75);
            this.lblpBr08.Name = "lblpBr08";
            this.lblpBr08.Size = new System.Drawing.Size(23, 25);
            this.lblpBr08.TabIndex = 68;
            this.lblpBr08.Text = "_";
            // 
            // lblpBr07
            // 
            this.lblpBr07.AutoSize = true;
            this.lblpBr07.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr07.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr07.Location = new System.Drawing.Point(22, 70);
            this.lblpBr07.Name = "lblpBr07";
            this.lblpBr07.Size = new System.Drawing.Size(23, 25);
            this.lblpBr07.TabIndex = 67;
            this.lblpBr07.Text = "_";
            // 
            // lblpBr06
            // 
            this.lblpBr06.AutoSize = true;
            this.lblpBr06.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr06.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr06.Location = new System.Drawing.Point(13, 77);
            this.lblpBr06.Name = "lblpBr06";
            this.lblpBr06.Size = new System.Drawing.Size(23, 25);
            this.lblpBr06.TabIndex = 66;
            this.lblpBr06.Text = "_";
            // 
            // lblpBr05
            // 
            this.lblpBr05.AutoSize = true;
            this.lblpBr05.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr05.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr05.Location = new System.Drawing.Point(15, 75);
            this.lblpBr05.Name = "lblpBr05";
            this.lblpBr05.Size = new System.Drawing.Size(23, 25);
            this.lblpBr05.TabIndex = 65;
            this.lblpBr05.Text = "_";
            // 
            // lblpBr04
            // 
            this.lblpBr04.AutoSize = true;
            this.lblpBr04.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr04.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr04.Location = new System.Drawing.Point(12, 63);
            this.lblpBr04.Name = "lblpBr04";
            this.lblpBr04.Size = new System.Drawing.Size(23, 25);
            this.lblpBr04.TabIndex = 64;
            this.lblpBr04.Text = "_";
            // 
            // lblpBr03
            // 
            this.lblpBr03.AutoSize = true;
            this.lblpBr03.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr03.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr03.Location = new System.Drawing.Point(22, 74);
            this.lblpBr03.Name = "lblpBr03";
            this.lblpBr03.Size = new System.Drawing.Size(23, 25);
            this.lblpBr03.TabIndex = 63;
            this.lblpBr03.Text = "_";
            this.lblpBr03.Click += new System.EventHandler(this.lblpBr03_Click);
            // 
            // lblpBr02
            // 
            this.lblpBr02.AutoSize = true;
            this.lblpBr02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr02.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr02.Location = new System.Drawing.Point(13, 74);
            this.lblpBr02.Name = "lblpBr02";
            this.lblpBr02.Size = new System.Drawing.Size(23, 25);
            this.lblpBr02.TabIndex = 62;
            this.lblpBr02.Text = "_";
            // 
            // lblpBr01
            // 
            this.lblpBr01.BackColor = System.Drawing.Color.Transparent;
            this.lblpBr01.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblpBr01.Font = new System.Drawing.Font("Courier", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblpBr01.Location = new System.Drawing.Point(0, 35);
            this.lblpBr01.Name = "lblpBr01";
            this.lblpBr01.Size = new System.Drawing.Size(47, 0);
            this.lblpBr01.TabIndex = 61;
            this.lblpBr01.Text = ".";
            this.lblpBr01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpBc15
            // 
            this.lblpBc15.AutoSize = true;
            this.lblpBc15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc15.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc15.Location = new System.Drawing.Point(13, 39);
            this.lblpBc15.Name = "lblpBc15";
            this.lblpBc15.Size = new System.Drawing.Size(23, 25);
            this.lblpBc15.TabIndex = 60;
            this.lblpBc15.Text = "0";
            // 
            // lblpBc14
            // 
            this.lblpBc14.AutoSize = true;
            this.lblpBc14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc14.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc14.Location = new System.Drawing.Point(13, 35);
            this.lblpBc14.Name = "lblpBc14";
            this.lblpBc14.Size = new System.Drawing.Size(23, 25);
            this.lblpBc14.TabIndex = 59;
            this.lblpBc14.Text = "0";
            // 
            // lblpBc13
            // 
            this.lblpBc13.AutoSize = true;
            this.lblpBc13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc13.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc13.Location = new System.Drawing.Point(15, 35);
            this.lblpBc13.Name = "lblpBc13";
            this.lblpBc13.Size = new System.Drawing.Size(23, 25);
            this.lblpBc13.TabIndex = 58;
            this.lblpBc13.Text = "0";
            // 
            // lblpBc12
            // 
            this.lblpBc12.AutoSize = true;
            this.lblpBc12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc12.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc12.Location = new System.Drawing.Point(12, 49);
            this.lblpBc12.Name = "lblpBc12";
            this.lblpBc12.Size = new System.Drawing.Size(23, 25);
            this.lblpBc12.TabIndex = 57;
            this.lblpBc12.Text = "0";
            // 
            // lblpBc11
            // 
            this.lblpBc11.AutoSize = true;
            this.lblpBc11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc11.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc11.Location = new System.Drawing.Point(9, 44);
            this.lblpBc11.Name = "lblpBc11";
            this.lblpBc11.Size = new System.Drawing.Size(23, 25);
            this.lblpBc11.TabIndex = 56;
            this.lblpBc11.Text = "0";
            // 
            // lblpBc10
            // 
            this.lblpBc10.AutoSize = true;
            this.lblpBc10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc10.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc10.Location = new System.Drawing.Point(12, 43);
            this.lblpBc10.Name = "lblpBc10";
            this.lblpBc10.Size = new System.Drawing.Size(23, 25);
            this.lblpBc10.TabIndex = 55;
            this.lblpBc10.Text = "0";
            // 
            // lblpBc09
            // 
            this.lblpBc09.AutoSize = true;
            this.lblpBc09.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc09.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc09.Location = new System.Drawing.Point(12, 46);
            this.lblpBc09.Name = "lblpBc09";
            this.lblpBc09.Size = new System.Drawing.Size(23, 25);
            this.lblpBc09.TabIndex = 54;
            this.lblpBc09.Text = "0";
            // 
            // lblpBc08
            // 
            this.lblpBc08.AutoSize = true;
            this.lblpBc08.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc08.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc08.Location = new System.Drawing.Point(12, 44);
            this.lblpBc08.Name = "lblpBc08";
            this.lblpBc08.Size = new System.Drawing.Size(23, 25);
            this.lblpBc08.TabIndex = 53;
            this.lblpBc08.Text = "0";
            // 
            // lblpBc07
            // 
            this.lblpBc07.AutoSize = true;
            this.lblpBc07.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc07.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc07.Location = new System.Drawing.Point(22, 39);
            this.lblpBc07.Name = "lblpBc07";
            this.lblpBc07.Size = new System.Drawing.Size(23, 25);
            this.lblpBc07.TabIndex = 52;
            this.lblpBc07.Text = "0";
            // 
            // lblpBc06
            // 
            this.lblpBc06.AutoSize = true;
            this.lblpBc06.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc06.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc06.Location = new System.Drawing.Point(13, 46);
            this.lblpBc06.Name = "lblpBc06";
            this.lblpBc06.Size = new System.Drawing.Size(23, 25);
            this.lblpBc06.TabIndex = 51;
            this.lblpBc06.Text = "0";
            // 
            // lblpBc05
            // 
            this.lblpBc05.AutoSize = true;
            this.lblpBc05.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc05.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc05.Location = new System.Drawing.Point(16, 49);
            this.lblpBc05.Name = "lblpBc05";
            this.lblpBc05.Size = new System.Drawing.Size(23, 25);
            this.lblpBc05.TabIndex = 50;
            this.lblpBc05.Text = "0";
            // 
            // lblpBc04
            // 
            this.lblpBc04.AutoSize = true;
            this.lblpBc04.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc04.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc04.Location = new System.Drawing.Point(9, 38);
            this.lblpBc04.Name = "lblpBc04";
            this.lblpBc04.Size = new System.Drawing.Size(23, 25);
            this.lblpBc04.TabIndex = 49;
            this.lblpBc04.Text = "0";
            // 
            // lblpBc03
            // 
            this.lblpBc03.AutoSize = true;
            this.lblpBc03.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc03.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc03.Location = new System.Drawing.Point(3, 37);
            this.lblpBc03.Name = "lblpBc03";
            this.lblpBc03.Size = new System.Drawing.Size(23, 25);
            this.lblpBc03.TabIndex = 48;
            this.lblpBc03.Text = "0";
            // 
            // lblpBc02
            // 
            this.lblpBc02.AutoSize = true;
            this.lblpBc02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc02.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc02.Location = new System.Drawing.Point(6, 37);
            this.lblpBc02.Name = "lblpBc02";
            this.lblpBc02.Size = new System.Drawing.Size(23, 25);
            this.lblpBc02.TabIndex = 47;
            this.lblpBc02.Text = "0";
            // 
            // lblpBc01
            // 
            this.lblpBc01.BackColor = System.Drawing.Color.Transparent;
            this.lblpBc01.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc01.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc01.Location = new System.Drawing.Point(0, 24);
            this.lblpBc01.Name = "lblpBc01";
            this.lblpBc01.Size = new System.Drawing.Size(45, 8);
            this.lblpBc01.TabIndex = 46;
            this.lblpBc01.Text = "0";
            this.lblpBc01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblpBc01.Click += new System.EventHandler(this.lblpBc01_Click);
            // 
            // lblCam15
            // 
            this.lblCam15.AutoSize = true;
            this.lblCam15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam15.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam15.Location = new System.Drawing.Point(3, 6);
            this.lblCam15.Name = "lblCam15";
            this.lblCam15.Size = new System.Drawing.Size(45, 30);
            this.lblCam15.TabIndex = 29;
            this.lblCam15.Text = "15";
            this.lblCam15.Click += new System.EventHandler(this.lblCam15_Click);
            // 
            // lblCam14
            // 
            this.lblCam14.AutoSize = true;
            this.lblCam14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam14.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam14.Location = new System.Drawing.Point(12, 6);
            this.lblCam14.Name = "lblCam14";
            this.lblCam14.Size = new System.Drawing.Size(45, 30);
            this.lblCam14.TabIndex = 27;
            this.lblCam14.Text = "14";
            this.lblCam14.Click += new System.EventHandler(this.lblCam14_Click);
            // 
            // lblCam13
            // 
            this.lblCam13.AutoSize = true;
            this.lblCam13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam13.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam13.Location = new System.Drawing.Point(10, 7);
            this.lblCam13.Name = "lblCam13";
            this.lblCam13.Size = new System.Drawing.Size(45, 30);
            this.lblCam13.TabIndex = 25;
            this.lblCam13.Text = "13";
            this.lblCam13.Click += new System.EventHandler(this.lblCam13_Click);
            // 
            // lblCam12
            // 
            this.lblCam12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCam12.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam12.Location = new System.Drawing.Point(0, 0);
            this.lblCam12.Name = "lblCam12";
            this.lblCam12.Size = new System.Drawing.Size(45, 100);
            this.lblCam12.TabIndex = 23;
            this.lblCam12.Text = "12";
            this.lblCam12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCam12.Click += new System.EventHandler(this.lblCam12_Click);
            // 
            // lblCam11
            // 
            this.lblCam11.AutoSize = true;
            this.lblCam11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam11.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam11.Location = new System.Drawing.Point(13, 7);
            this.lblCam11.Name = "lblCam11";
            this.lblCam11.Size = new System.Drawing.Size(45, 30);
            this.lblCam11.TabIndex = 21;
            this.lblCam11.Text = "11";
            this.lblCam11.Click += new System.EventHandler(this.lblCam11_Click);
            // 
            // lblCam10
            // 
            this.lblCam10.AutoSize = true;
            this.lblCam10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam10.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam10.Location = new System.Drawing.Point(12, 7);
            this.lblCam10.Name = "lblCam10";
            this.lblCam10.Size = new System.Drawing.Size(45, 30);
            this.lblCam10.TabIndex = 19;
            this.lblCam10.Text = "10";
            this.lblCam10.Click += new System.EventHandler(this.lblCam10_Click);
            // 
            // lblCam09
            // 
            this.lblCam09.AutoSize = true;
            this.lblCam09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam09.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam09.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam09.Location = new System.Drawing.Point(12, 6);
            this.lblCam09.Name = "lblCam09";
            this.lblCam09.Size = new System.Drawing.Size(45, 30);
            this.lblCam09.TabIndex = 17;
            this.lblCam09.Text = "09";
            this.lblCam09.Click += new System.EventHandler(this.lblCam09_Click);
            // 
            // lblCam08
            // 
            this.lblCam08.AutoSize = true;
            this.lblCam08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam08.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam08.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam08.Location = new System.Drawing.Point(12, 11);
            this.lblCam08.Name = "lblCam08";
            this.lblCam08.Size = new System.Drawing.Size(45, 30);
            this.lblCam08.TabIndex = 15;
            this.lblCam08.Text = "08";
            this.lblCam08.Click += new System.EventHandler(this.lblCam08_Click);
            // 
            // lblCam07
            // 
            this.lblCam07.AutoSize = true;
            this.lblCam07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam07.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam07.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam07.Location = new System.Drawing.Point(13, 10);
            this.lblCam07.Name = "lblCam07";
            this.lblCam07.Size = new System.Drawing.Size(45, 30);
            this.lblCam07.TabIndex = 13;
            this.lblCam07.Text = "07";
            this.lblCam07.Click += new System.EventHandler(this.lblCam07_Click);
            // 
            // lblCam06
            // 
            this.lblCam06.AutoSize = true;
            this.lblCam06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam06.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam06.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam06.Location = new System.Drawing.Point(12, 10);
            this.lblCam06.Name = "lblCam06";
            this.lblCam06.Size = new System.Drawing.Size(45, 30);
            this.lblCam06.TabIndex = 11;
            this.lblCam06.Text = "06";
            this.lblCam06.Click += new System.EventHandler(this.lblCam06_Click);
            // 
            // lblCam05
            // 
            this.lblCam05.AutoSize = true;
            this.lblCam05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam05.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam05.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam05.Location = new System.Drawing.Point(10, 9);
            this.lblCam05.Name = "lblCam05";
            this.lblCam05.Size = new System.Drawing.Size(45, 30);
            this.lblCam05.TabIndex = 9;
            this.lblCam05.Text = "05";
            this.lblCam05.Click += new System.EventHandler(this.lblCam05_Click);
            // 
            // lblCam04
            // 
            this.lblCam04.AutoSize = true;
            this.lblCam04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam04.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam04.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam04.Location = new System.Drawing.Point(5, 9);
            this.lblCam04.Name = "lblCam04";
            this.lblCam04.Size = new System.Drawing.Size(45, 30);
            this.lblCam04.TabIndex = 7;
            this.lblCam04.Text = "04";
            this.lblCam04.Click += new System.EventHandler(this.lblCam04_Click);
            // 
            // lblCam03
            // 
            this.lblCam03.AutoSize = true;
            this.lblCam03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam03.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam03.Location = new System.Drawing.Point(9, 12);
            this.lblCam03.Name = "lblCam03";
            this.lblCam03.Size = new System.Drawing.Size(45, 30);
            this.lblCam03.TabIndex = 5;
            this.lblCam03.Text = "03";
            this.lblCam03.Click += new System.EventHandler(this.lblCam03_Click);
            // 
            // lblCam02
            // 
            this.lblCam02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCam02.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam02.Location = new System.Drawing.Point(0, 0);
            this.lblCam02.Name = "lblCam02";
            this.lblCam02.Size = new System.Drawing.Size(45, 100);
            this.lblCam02.TabIndex = 3;
            this.lblCam02.Text = "02";
            this.lblCam02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCam02.Click += new System.EventHandler(this.lblCam02_Click);
            // 
            // lblCam01
            // 
            this.lblCam01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCam01.Font = new System.Drawing.Font("Courier", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam01.Location = new System.Drawing.Point(0, 0);
            this.lblCam01.Name = "lblCam01";
            this.lblCam01.Size = new System.Drawing.Size(47, 35);
            this.lblCam01.TabIndex = 1;
            this.lblCam01.Text = "01";
            this.lblCam01.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCam01.Click += new System.EventHandler(this.lblCam01_Click);
            // 
            // lblpBr17
            // 
            this.lblpBr17.AutoSize = true;
            this.lblpBr17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr17.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr17.Location = new System.Drawing.Point(3, 70);
            this.lblpBr17.Name = "lblpBr17";
            this.lblpBr17.Size = new System.Drawing.Size(23, 25);
            this.lblpBr17.TabIndex = 225;
            this.lblpBr17.Text = "_";
            // 
            // lblpBc17
            // 
            this.lblpBc17.AutoSize = true;
            this.lblpBc17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc17.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc17.Location = new System.Drawing.Point(3, 39);
            this.lblpBc17.Name = "lblpBc17";
            this.lblpBc17.Size = new System.Drawing.Size(23, 25);
            this.lblpBc17.TabIndex = 220;
            this.lblpBc17.Text = "0";
            // 
            // lblCam17
            // 
            this.lblCam17.AutoSize = true;
            this.lblCam17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam17.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam17.Location = new System.Drawing.Point(10, 8);
            this.lblCam17.Name = "lblCam17";
            this.lblCam17.Size = new System.Drawing.Size(45, 30);
            this.lblCam17.TabIndex = 215;
            this.lblCam17.Text = "17";
            this.lblCam17.Click += new System.EventHandler(this.lblCam17_Click);
            // 
            // lblpBr16
            // 
            this.lblpBr16.AutoSize = true;
            this.lblpBr16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr16.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr16.Location = new System.Drawing.Point(3, 70);
            this.lblpBr16.Name = "lblpBr16";
            this.lblpBr16.Size = new System.Drawing.Size(23, 25);
            this.lblpBr16.TabIndex = 172;
            this.lblpBr16.Text = "_";
            // 
            // lblpBc16
            // 
            this.lblpBc16.AutoSize = true;
            this.lblpBc16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc16.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc16.Location = new System.Drawing.Point(3, 39);
            this.lblpBc16.Name = "lblpBc16";
            this.lblpBc16.Size = new System.Drawing.Size(23, 25);
            this.lblpBc16.TabIndex = 171;
            this.lblpBc16.Text = "0";
            // 
            // lblCam16
            // 
            this.lblCam16.AutoSize = true;
            this.lblCam16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam16.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam16.Location = new System.Drawing.Point(9, 8);
            this.lblCam16.Name = "lblCam16";
            this.lblCam16.Size = new System.Drawing.Size(45, 30);
            this.lblCam16.TabIndex = 170;
            this.lblCam16.Text = "16";
            this.lblCam16.Click += new System.EventHandler(this.lblCam16_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(346, 97);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(22, 12);
            this.label26.TabIndex = 152;
            this.label26.Text = "PM";
            this.label26.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Lime;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(336, 99);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 9);
            this.pictureBox5.TabIndex = 151;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(346, 84);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 12);
            this.label27.TabIndex = 150;
            this.label27.Text = "AM";
            this.label27.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Orange;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(336, 86);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 9);
            this.pictureBox6.TabIndex = 149;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(405, 98);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 12);
            this.label24.TabIndex = 148;
            this.label24.Text = "Paro";
            this.label24.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Red;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(395, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 9);
            this.pictureBox3.TabIndex = 147;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(405, 85);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 12);
            this.label25.TabIndex = 146;
            this.label25.Text = "Mov";
            this.label25.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Lime;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(395, 87);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 9);
            this.pictureBox4.TabIndex = 145;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(446, 98);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(19, 12);
            this.label23.TabIndex = 144;
            this.label23.Text = "No";
            this.label23.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(436, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 9);
            this.pictureBox2.TabIndex = 143;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(446, 85);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 12);
            this.label22.TabIndex = 142;
            this.label22.Text = "Si";
            this.label22.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(436, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 9);
            this.pictureBox1.TabIndex = 141;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btnCerrarPanel
            // 
            this.btnCerrarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.btnCerrarPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrarPanel.Location = new System.Drawing.Point(665, 185);
            this.btnCerrarPanel.Name = "btnCerrarPanel";
            this.btnCerrarPanel.Size = new System.Drawing.Size(47, 13);
            this.btnCerrarPanel.TabIndex = 95;
            this.btnCerrarPanel.Text = "+";
            this.btnCerrarPanel.UseVisualStyleBackColor = false;
            this.btnCerrarPanel.Visible = false;
            this.btnCerrarPanel.Click += new System.EventHandler(this.btnCerrarPanel_Click);
            // 
            // btnAbrirCerrarPanel
            // 
            this.btnAbrirCerrarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.btnAbrirCerrarPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirCerrarPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirCerrarPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCerrarPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbrirCerrarPanel.Location = new System.Drawing.Point(367, 126);
            this.btnAbrirCerrarPanel.Name = "btnAbrirCerrarPanel";
            this.btnAbrirCerrarPanel.Size = new System.Drawing.Size(18, 123);
            this.btnAbrirCerrarPanel.TabIndex = 96;
            this.btnAbrirCerrarPanel.Text = "+";
            this.btnAbrirCerrarPanel.UseVisualStyleBackColor = false;
            this.btnAbrirCerrarPanel.Visible = false;
            this.btnAbrirCerrarPanel.Click += new System.EventHandler(this.btnAbrirCerrarPanel_Click);
            // 
            // lblClasicConn
            // 
            this.lblClasicConn.AutoSize = true;
            this.lblClasicConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasicConn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClasicConn.Location = new System.Drawing.Point(415, 197);
            this.lblClasicConn.Name = "lblClasicConn";
            this.lblClasicConn.Size = new System.Drawing.Size(93, 22);
            this.lblClasicConn.TabIndex = 153;
            this.lblClasicConn.Text = "Clasicos #";
            this.lblClasicConn.Visible = false;
            // 
            // lblEcoConn
            // 
            this.lblEcoConn.AutoSize = true;
            this.lblEcoConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcoConn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEcoConn.Location = new System.Drawing.Point(524, 200);
            this.lblEcoConn.Name = "lblEcoConn";
            this.lblEcoConn.Size = new System.Drawing.Size(112, 22);
            this.lblEcoConn.TabIndex = 154;
            this.lblEcoConn.Text = "Ecologicos #";
            this.lblEcoConn.Visible = false;
            // 
            // panelCam17
            // 
            this.panelCam17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam17.Controls.Add(this.picPila17);
            this.panelCam17.Controls.Add(this.lblTablet17);
            this.panelCam17.Controls.Add(this.picWifi17);
            this.panelCam17.Controls.Add(this.picCamion17);
            this.panelCam17.Controls.Add(this.picMov17);
            this.panelCam17.Controls.Add(this.lblCam17);
            this.panelCam17.Controls.Add(this.lblpBc17);
            this.panelCam17.Controls.Add(this.pBar17);
            this.panelCam17.Controls.Add(this.lblpBr17);
            this.panelCam17.Controls.Add(this.lblpAct17);
            this.panelCam17.Location = new System.Drawing.Point(429, 25);
            this.panelCam17.Name = "panelCam17";
            this.panelCam17.Size = new System.Drawing.Size(47, 102);
            this.panelCam17.TabIndex = 293;
            this.panelCam17.Visible = false;
            // 
            // picPila17
            // 
            this.picPila17.BackColor = System.Drawing.Color.Transparent;
            this.picPila17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila17.Location = new System.Drawing.Point(47, 50);
            this.picPila17.Name = "picPila17";
            this.picPila17.Size = new System.Drawing.Size(12, 15);
            this.picPila17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila17.TabIndex = 353;
            this.picPila17.TabStop = false;
            // 
            // lblTablet17
            // 
            this.lblTablet17.AutoSize = true;
            this.lblTablet17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet17.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet17.Location = new System.Drawing.Point(43, 88);
            this.lblTablet17.Name = "lblTablet17";
            this.lblTablet17.Size = new System.Drawing.Size(11, 12);
            this.lblTablet17.TabIndex = 352;
            this.lblTablet17.Text = "0";
            // 
            // picWifi17
            // 
            this.picWifi17.BackColor = System.Drawing.Color.Transparent;
            this.picWifi17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi17.Location = new System.Drawing.Point(39, 21);
            this.picWifi17.Name = "picWifi17";
            this.picWifi17.Size = new System.Drawing.Size(15, 14);
            this.picWifi17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi17.TabIndex = 349;
            this.picWifi17.TabStop = false;
            // 
            // picCamion17
            // 
            this.picCamion17.BackColor = System.Drawing.Color.Transparent;
            this.picCamion17.Location = new System.Drawing.Point(30, 54);
            this.picCamion17.Name = "picCamion17";
            this.picCamion17.Size = new System.Drawing.Size(15, 24);
            this.picCamion17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion17.TabIndex = 299;
            this.picCamion17.TabStop = false;
            // 
            // picMov17
            // 
            this.picMov17.BackColor = System.Drawing.Color.Transparent;
            this.picMov17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov17.Location = new System.Drawing.Point(44, 3);
            this.picMov17.Name = "picMov17";
            this.picMov17.Size = new System.Drawing.Size(10, 9);
            this.picMov17.TabIndex = 309;
            this.picMov17.TabStop = false;
            // 
            // panelCam16
            // 
            this.panelCam16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam16.Controls.Add(this.picPila16);
            this.panelCam16.Controls.Add(this.lblTablet16);
            this.panelCam16.Controls.Add(this.picWifi16);
            this.panelCam16.Controls.Add(this.picCamion16);
            this.panelCam16.Controls.Add(this.lblCam16);
            this.panelCam16.Controls.Add(this.lblpBc16);
            this.panelCam16.Controls.Add(this.lblpBr16);
            this.panelCam16.Controls.Add(this.picMov16);
            this.panelCam16.Controls.Add(this.pBar16);
            this.panelCam16.Controls.Add(this.lblpAct16);
            this.panelCam16.Location = new System.Drawing.Point(371, 131);
            this.panelCam16.Name = "panelCam16";
            this.panelCam16.Size = new System.Drawing.Size(47, 102);
            this.panelCam16.TabIndex = 294;
            this.panelCam16.Visible = false;
            // 
            // picPila16
            // 
            this.picPila16.BackColor = System.Drawing.Color.Transparent;
            this.picPila16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila16.Location = new System.Drawing.Point(44, 43);
            this.picPila16.Name = "picPila16";
            this.picPila16.Size = new System.Drawing.Size(12, 15);
            this.picPila16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila16.TabIndex = 354;
            this.picPila16.TabStop = false;
            // 
            // lblTablet16
            // 
            this.lblTablet16.AutoSize = true;
            this.lblTablet16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet16.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet16.Location = new System.Drawing.Point(39, 83);
            this.lblTablet16.Name = "lblTablet16";
            this.lblTablet16.Size = new System.Drawing.Size(11, 12);
            this.lblTablet16.TabIndex = 353;
            this.lblTablet16.Text = "0";
            // 
            // picWifi16
            // 
            this.picWifi16.BackColor = System.Drawing.Color.Transparent;
            this.picWifi16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi16.Location = new System.Drawing.Point(39, 22);
            this.picWifi16.Name = "picWifi16";
            this.picWifi16.Size = new System.Drawing.Size(15, 14);
            this.picWifi16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi16.TabIndex = 349;
            this.picWifi16.TabStop = false;
            // 
            // picCamion16
            // 
            this.picCamion16.BackColor = System.Drawing.Color.Transparent;
            this.picCamion16.Location = new System.Drawing.Point(4, 40);
            this.picCamion16.Name = "picCamion16";
            this.picCamion16.Size = new System.Drawing.Size(42, 45);
            this.picCamion16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion16.TabIndex = 302;
            this.picCamion16.TabStop = false;
            // 
            // picMov16
            // 
            this.picMov16.BackColor = System.Drawing.Color.Transparent;
            this.picMov16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov16.Location = new System.Drawing.Point(45, 7);
            this.picMov16.Name = "picMov16";
            this.picMov16.Size = new System.Drawing.Size(10, 9);
            this.picMov16.TabIndex = 308;
            this.picMov16.TabStop = false;
            // 
            // panelCam15
            // 
            this.panelCam15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam15.Controls.Add(this.picPila15);
            this.panelCam15.Controls.Add(this.lblTablet15);
            this.panelCam15.Controls.Add(this.picWifi15);
            this.panelCam15.Controls.Add(this.picCamion15);
            this.panelCam15.Controls.Add(this.lblCam15);
            this.panelCam15.Controls.Add(this.lblpBc15);
            this.panelCam15.Controls.Add(this.lblpBr15);
            this.panelCam15.Controls.Add(this.picMov15);
            this.panelCam15.Controls.Add(this.pBar15);
            this.panelCam15.Controls.Add(this.lblpAct15);
            this.panelCam15.Location = new System.Drawing.Point(380, 25);
            this.panelCam15.Name = "panelCam15";
            this.panelCam15.Size = new System.Drawing.Size(47, 102);
            this.panelCam15.TabIndex = 295;
            this.panelCam15.Visible = false;
            // 
            // picPila15
            // 
            this.picPila15.BackColor = System.Drawing.Color.Transparent;
            this.picPila15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila15.Location = new System.Drawing.Point(42, 42);
            this.picPila15.Name = "picPila15";
            this.picPila15.Size = new System.Drawing.Size(12, 15);
            this.picPila15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila15.TabIndex = 354;
            this.picPila15.TabStop = false;
            // 
            // lblTablet15
            // 
            this.lblTablet15.AutoSize = true;
            this.lblTablet15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet15.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet15.Location = new System.Drawing.Point(37, 83);
            this.lblTablet15.Name = "lblTablet15";
            this.lblTablet15.Size = new System.Drawing.Size(11, 12);
            this.lblTablet15.TabIndex = 353;
            this.lblTablet15.Text = "0";
            // 
            // picWifi15
            // 
            this.picWifi15.BackColor = System.Drawing.Color.Transparent;
            this.picWifi15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi15.Location = new System.Drawing.Point(37, 22);
            this.picWifi15.Name = "picWifi15";
            this.picWifi15.Size = new System.Drawing.Size(15, 14);
            this.picWifi15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi15.TabIndex = 349;
            this.picWifi15.TabStop = false;
            // 
            // picCamion15
            // 
            this.picCamion15.BackColor = System.Drawing.Color.Transparent;
            this.picCamion15.Location = new System.Drawing.Point(3, 35);
            this.picCamion15.Name = "picCamion15";
            this.picCamion15.Size = new System.Drawing.Size(42, 45);
            this.picCamion15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion15.TabIndex = 301;
            this.picCamion15.TabStop = false;
            // 
            // panelCam14
            // 
            this.panelCam14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam14.Controls.Add(this.picCamion14);
            this.panelCam14.Controls.Add(this.picPila14);
            this.panelCam14.Controls.Add(this.lblTablet14);
            this.panelCam14.Controls.Add(this.picWifi14);
            this.panelCam14.Controls.Add(this.lblCam14);
            this.panelCam14.Controls.Add(this.lblpBc14);
            this.panelCam14.Controls.Add(this.lblpBr14);
            this.panelCam14.Controls.Add(this.picMov14);
            this.panelCam14.Controls.Add(this.pBar14);
            this.panelCam14.Controls.Add(this.lblpAct14);
            this.panelCam14.Location = new System.Drawing.Point(321, 131);
            this.panelCam14.Name = "panelCam14";
            this.panelCam14.Size = new System.Drawing.Size(47, 102);
            this.panelCam14.TabIndex = 296;
            this.panelCam14.Visible = false;
            // 
            // picCamion14
            // 
            this.picCamion14.BackColor = System.Drawing.Color.Transparent;
            this.picCamion14.Location = new System.Drawing.Point(3, 35);
            this.picCamion14.Name = "picCamion14";
            this.picCamion14.Size = new System.Drawing.Size(42, 45);
            this.picCamion14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion14.TabIndex = 300;
            this.picCamion14.TabStop = false;
            // 
            // picPila14
            // 
            this.picPila14.BackColor = System.Drawing.Color.Transparent;
            this.picPila14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila14.Location = new System.Drawing.Point(44, 40);
            this.picPila14.Name = "picPila14";
            this.picPila14.Size = new System.Drawing.Size(12, 15);
            this.picPila14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila14.TabIndex = 354;
            this.picPila14.TabStop = false;
            // 
            // lblTablet14
            // 
            this.lblTablet14.AutoSize = true;
            this.lblTablet14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet14.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet14.Location = new System.Drawing.Point(37, 82);
            this.lblTablet14.Name = "lblTablet14";
            this.lblTablet14.Size = new System.Drawing.Size(11, 12);
            this.lblTablet14.TabIndex = 353;
            this.lblTablet14.Text = "0";
            // 
            // picWifi14
            // 
            this.picWifi14.BackColor = System.Drawing.Color.Transparent;
            this.picWifi14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi14.Location = new System.Drawing.Point(39, 19);
            this.picWifi14.Name = "picWifi14";
            this.picWifi14.Size = new System.Drawing.Size(15, 14);
            this.picWifi14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi14.TabIndex = 349;
            this.picWifi14.TabStop = false;
            // 
            // panelCamion2
            // 
            this.panelCamion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.panelCamion2.Controls.Add(this.lblEtiquetaConCabSinServir);
            this.panelCamion2.Controls.Add(this.lblEtiquetaTaller);
            this.panelCamion2.Controls.Add(this.button1);
            this.panelCamion2.Controls.Add(this.lblEtiquetaRutas);
            this.panelCamion2.Controls.Add(this.panelDescripciones);
            this.panelCamion2.Controls.Add(this.panelCam36);
            this.panelCamion2.Controls.Add(this.panelCam32);
            this.panelCamion2.Controls.Add(this.panelCam35);
            this.panelCamion2.Controls.Add(this.panelCam31);
            this.panelCamion2.Controls.Add(this.panelCam34);
            this.panelCamion2.Controls.Add(this.panelCam30);
            this.panelCamion2.Controls.Add(this.panelCam33);
            this.panelCamion2.Controls.Add(this.panelCam28);
            this.panelCamion2.Controls.Add(this.panelCam29);
            this.panelCamion2.Controls.Add(this.panelCam24);
            this.panelCamion2.Controls.Add(this.panelCam27);
            this.panelCamion2.Controls.Add(this.panelCam23);
            this.panelCamion2.Controls.Add(this.panelCam26);
            this.panelCamion2.Controls.Add(this.panelCam21);
            this.panelCamion2.Controls.Add(this.panelCam25);
            this.panelCamion2.Controls.Add(this.panelCam22);
            this.panelCamion2.Controls.Add(this.label38);
            this.panelCamion2.Controls.Add(this.label37);
            this.panelCamion2.Controls.Add(this.panelCam18);
            this.panelCamion2.Controls.Add(this.panelCam04);
            this.panelCamion2.Controls.Add(this.panelCam19);
            this.panelCamion2.Controls.Add(this.panelCam20);
            this.panelCamion2.Controls.Add(this.panelCam08);
            this.panelCamion2.Controls.Add(this.panelCam01);
            this.panelCamion2.Controls.Add(this.panelCam02);
            this.panelCamion2.Controls.Add(this.panelCam12);
            this.panelCamion2.Controls.Add(this.panelCam03);
            this.panelCamion2.Controls.Add(this.panelCam05);
            this.panelCamion2.Controls.Add(this.panelCam09);
            this.panelCamion2.Controls.Add(this.panelCam06);
            this.panelCamion2.Controls.Add(this.panelCam07);
            this.panelCamion2.Controls.Add(this.panelCam13);
            this.panelCamion2.Controls.Add(this.panelCam10);
            this.panelCamion2.Controls.Add(this.panelCam17);
            this.panelCamion2.Controls.Add(this.panelCam11);
            this.panelCamion2.Controls.Add(this.panelCam14);
            this.panelCamion2.Controls.Add(this.panelCam15);
            this.panelCamion2.Controls.Add(this.panelCam16);
            this.panelCamion2.Location = new System.Drawing.Point(12, 448);
            this.panelCamion2.Name = "panelCamion2";
            this.panelCamion2.Size = new System.Drawing.Size(1325, 244);
            this.panelCamion2.TabIndex = 297;
            this.panelCamion2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCamion2_Paint);
            // 
            // lblEtiquetaConCabSinServir
            // 
            this.lblEtiquetaConCabSinServir.AutoSize = true;
            this.lblEtiquetaConCabSinServir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEtiquetaConCabSinServir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEtiquetaConCabSinServir.Location = new System.Drawing.Point(584, 2);
            this.lblEtiquetaConCabSinServir.Name = "lblEtiquetaConCabSinServir";
            this.lblEtiquetaConCabSinServir.Size = new System.Drawing.Size(34, 13);
            this.lblEtiquetaConCabSinServir.TabIndex = 374;
            this.lblEtiquetaConCabSinServir.Text = "C A B";
            this.lblEtiquetaConCabSinServir.Visible = false;
            this.lblEtiquetaConCabSinServir.Click += new System.EventHandler(this.lblEtiquetaConCabSinServir_Click);
            // 
            // lblEtiquetaTaller
            // 
            this.lblEtiquetaTaller.AutoSize = true;
            this.lblEtiquetaTaller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEtiquetaTaller.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEtiquetaTaller.Location = new System.Drawing.Point(488, 3);
            this.lblEtiquetaTaller.Name = "lblEtiquetaTaller";
            this.lblEtiquetaTaller.Size = new System.Drawing.Size(63, 13);
            this.lblEtiquetaTaller.TabIndex = 373;
            this.lblEtiquetaTaller.Text = "T A L L E R";
            this.lblEtiquetaTaller.Visible = false;
            this.lblEtiquetaTaller.Click += new System.EventHandler(this.lblEtiquetaTaller_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(930, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 11);
            this.button1.TabIndex = 372;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEtiquetaRutas
            // 
            this.lblEtiquetaRutas.AutoSize = true;
            this.lblEtiquetaRutas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEtiquetaRutas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEtiquetaRutas.Location = new System.Drawing.Point(10, 3);
            this.lblEtiquetaRutas.Name = "lblEtiquetaRutas";
            this.lblEtiquetaRutas.Size = new System.Drawing.Size(84, 13);
            this.lblEtiquetaRutas.TabIndex = 371;
            this.lblEtiquetaRutas.Text = "C A M I O N E S";
            this.lblEtiquetaRutas.Click += new System.EventHandler(this.lblEtiquetaRutas_Click);
            // 
            // panelDescripciones
            // 
            this.panelDescripciones.Controls.Add(this.panel2);
            this.panelDescripciones.Controls.Add(this.lblHoraMapa);
            this.panelDescripciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDescripciones.Location = new System.Drawing.Point(1049, 0);
            this.panelDescripciones.Name = "panelDescripciones";
            this.panelDescripciones.Size = new System.Drawing.Size(276, 244);
            this.panelDescripciones.TabIndex = 370;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalCamActDesConect);
            this.panel2.Controls.Add(this.label61);
            this.panel2.Controls.Add(this.lblTotalCamActConect);
            this.panel2.Controls.Add(this.pictureBox20);
            this.panel2.Controls.Add(this.lblTotalCamAct);
            this.panel2.Controls.Add(this.label62);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pictureBox24);
            this.panel2.Controls.Add(this.pictureBox16);
            this.panel2.Location = new System.Drawing.Point(16, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(59, 55);
            this.panel2.TabIndex = 374;
            // 
            // lblTotalCamActDesConect
            // 
            this.lblTotalCamActDesConect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCamActDesConect.Font = new System.Drawing.Font("Courier", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCamActDesConect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalCamActDesConect.Location = new System.Drawing.Point(141, 106);
            this.lblTotalCamActDesConect.Name = "lblTotalCamActDesConect";
            this.lblTotalCamActDesConect.Size = new System.Drawing.Size(42, 23);
            this.lblTotalCamActDesConect.TabIndex = 373;
            this.lblTotalCamActDesConect.Text = "0";
            this.lblTotalCamActDesConect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalCamActDesConect.Visible = false;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label61.Location = new System.Drawing.Point(81, 10);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(51, 13);
            this.label61.TabIndex = 366;
            this.label61.Text = "CONECT";
            this.label61.Visible = false;
            // 
            // lblTotalCamActConect
            // 
            this.lblTotalCamActConect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCamActConect.Font = new System.Drawing.Font("Courier", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCamActConect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalCamActConect.Location = new System.Drawing.Point(90, 106);
            this.lblTotalCamActConect.Name = "lblTotalCamActConect";
            this.lblTotalCamActConect.Size = new System.Drawing.Size(42, 23);
            this.lblTotalCamActConect.TabIndex = 372;
            this.lblTotalCamActConect.Text = "0";
            this.lblTotalCamActConect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalCamActConect.Visible = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Green;
            this.pictureBox20.Location = new System.Drawing.Point(91, 81);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(41, 21);
            this.pictureBox20.TabIndex = 367;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Visible = false;
            this.pictureBox20.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox20_Paint);
            // 
            // lblTotalCamAct
            // 
            this.lblTotalCamAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCamAct.Font = new System.Drawing.Font("Courier", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCamAct.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalCamAct.Location = new System.Drawing.Point(90, 132);
            this.lblTotalCamAct.Name = "lblTotalCamAct";
            this.lblTotalCamAct.Size = new System.Drawing.Size(93, 24);
            this.lblTotalCamAct.TabIndex = 371;
            this.lblTotalCamAct.Text = "0";
            this.lblTotalCamAct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalCamAct.Visible = false;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label62.Location = new System.Drawing.Point(140, 10);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(73, 13);
            this.label62.TabIndex = 368;
            this.label62.Text = "DESCONECT";
            this.label62.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label65);
            this.panel1.Controls.Add(this.label66);
            this.panel1.Controls.Add(this.label64);
            this.panel1.Location = new System.Drawing.Point(18, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 116);
            this.panel1.TabIndex = 370;
            this.panel1.Visible = false;
            // 
            // label65
            // 
            this.label65.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label65.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label65.Location = new System.Drawing.Point(0, 71);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(56, 21);
            this.label65.TabIndex = 366;
            this.label65.Text = "RACION";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label66
            // 
            this.label66.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label66.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label66.Location = new System.Drawing.Point(0, 92);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(56, 22);
            this.label66.TabIndex = 367;
            this.label66.Text = "TABLET";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label64
            // 
            this.label64.Dock = System.Windows.Forms.DockStyle.Top;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label64.Location = new System.Drawing.Point(0, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(56, 41);
            this.label64.TabIndex = 365;
            this.label64.Text = "CAMION SAP";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))));
            this.pictureBox24.Location = new System.Drawing.Point(143, 38);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(41, 64);
            this.pictureBox24.TabIndex = 369;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Visible = false;
            this.pictureBox24.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox24_Paint);
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Lime;
            this.pictureBox16.Location = new System.Drawing.Point(91, 38);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(41, 40);
            this.pictureBox16.TabIndex = 365;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Visible = false;
            this.pictureBox16.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox16_Paint);
            // 
            // lblHoraMapa
            // 
            this.lblHoraMapa.Font = new System.Drawing.Font("Courier", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraMapa.ForeColor = System.Drawing.Color.White;
            this.lblHoraMapa.Location = new System.Drawing.Point(26, 96);
            this.lblHoraMapa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraMapa.Name = "lblHoraMapa";
            this.lblHoraMapa.Size = new System.Drawing.Size(218, 43);
            this.lblHoraMapa.TabIndex = 313;
            this.lblHoraMapa.Text = "00:00:00";
            this.lblHoraMapa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCam36
            // 
            this.panelCam36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam36.Controls.Add(this.lblpBc36);
            this.panelCam36.Controls.Add(this.pictureBox29);
            this.panelCam36.Controls.Add(this.lblTablet36);
            this.panelCam36.Controls.Add(this.pictureBox30);
            this.panelCam36.Controls.Add(this.pictureBox31);
            this.panelCam36.Controls.Add(this.picCamion36);
            this.panelCam36.Controls.Add(this.lblCam36);
            this.panelCam36.Controls.Add(this.label67);
            this.panelCam36.Controls.Add(this.lblpBr36);
            this.panelCam36.Controls.Add(this.pBar36);
            this.panelCam36.Location = new System.Drawing.Point(863, 131);
            this.panelCam36.Name = "panelCam36";
            this.panelCam36.Size = new System.Drawing.Size(47, 102);
            this.panelCam36.TabIndex = 363;
            this.panelCam36.Visible = false;
            // 
            // lblpBc36
            // 
            this.lblpBc36.AutoSize = true;
            this.lblpBc36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc36.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc36.Location = new System.Drawing.Point(11, 38);
            this.lblpBc36.Name = "lblpBc36";
            this.lblpBc36.Size = new System.Drawing.Size(23, 25);
            this.lblpBc36.TabIndex = 359;
            this.lblpBc36.Text = "0";
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox29.Location = new System.Drawing.Point(41, 38);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(12, 15);
            this.pictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox29.TabIndex = 355;
            this.pictureBox29.TabStop = false;
            // 
            // lblTablet36
            // 
            this.lblTablet36.AutoSize = true;
            this.lblTablet36.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet36.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet36.Location = new System.Drawing.Point(6, 38);
            this.lblTablet36.Name = "lblTablet36";
            this.lblTablet36.Size = new System.Drawing.Size(11, 12);
            this.lblTablet36.TabIndex = 354;
            this.lblTablet36.Text = "0";
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox30.Location = new System.Drawing.Point(41, 20);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(15, 14);
            this.pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox30.TabIndex = 349;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox31.Location = new System.Drawing.Point(44, 5);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(10, 9);
            this.pictureBox31.TabIndex = 314;
            this.pictureBox31.TabStop = false;
            // 
            // picCamion36
            // 
            this.picCamion36.BackColor = System.Drawing.Color.Transparent;
            this.picCamion36.Location = new System.Drawing.Point(24, 57);
            this.picCamion36.Name = "picCamion36";
            this.picCamion36.Size = new System.Drawing.Size(27, 23);
            this.picCamion36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion36.TabIndex = 302;
            this.picCamion36.TabStop = false;
            // 
            // lblCam36
            // 
            this.lblCam36.AutoSize = true;
            this.lblCam36.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam36.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam36.Location = new System.Drawing.Point(10, 8);
            this.lblCam36.Name = "lblCam36";
            this.lblCam36.Size = new System.Drawing.Size(45, 30);
            this.lblCam36.TabIndex = 248;
            this.lblCam36.Text = "36";
            this.lblCam36.Click += new System.EventHandler(this.lblCam36_Click);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.Black;
            this.label67.Location = new System.Drawing.Point(7, 88);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(11, 12);
            this.label67.TabIndex = 268;
            this.label67.Text = "_";
            // 
            // lblpBr36
            // 
            this.lblpBr36.AutoSize = true;
            this.lblpBr36.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr36.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr36.Location = new System.Drawing.Point(18, 79);
            this.lblpBr36.Name = "lblpBr36";
            this.lblpBr36.Size = new System.Drawing.Size(11, 12);
            this.lblpBr36.TabIndex = 251;
            this.lblpBr36.Text = "_";
            // 
            // pBar36
            // 
            this.pBar36.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar36.Location = new System.Drawing.Point(24, 94);
            this.pBar36.Maximum = 500;
            this.pBar36.Name = "pBar36";
            this.pBar36.Size = new System.Drawing.Size(20, 3);
            this.pBar36.TabIndex = 279;
            // 
            // panelCam32
            // 
            this.panelCam32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam32.Controls.Add(this.lblpBc32);
            this.panelCam32.Controls.Add(this.pictureBox21);
            this.panelCam32.Controls.Add(this.lblTablet32);
            this.panelCam32.Controls.Add(this.pictureBox22);
            this.panelCam32.Controls.Add(this.pictureBox23);
            this.panelCam32.Controls.Add(this.picCamion32);
            this.panelCam32.Controls.Add(this.lblCam32);
            this.panelCam32.Controls.Add(this.label59);
            this.panelCam32.Controls.Add(this.lblpBr32);
            this.panelCam32.Controls.Add(this.pBar32);
            this.panelCam32.Location = new System.Drawing.Point(764, 131);
            this.panelCam32.Name = "panelCam32";
            this.panelCam32.Size = new System.Drawing.Size(47, 102);
            this.panelCam32.TabIndex = 359;
            this.panelCam32.Visible = false;
            // 
            // lblpBc32
            // 
            this.lblpBc32.AutoSize = true;
            this.lblpBc32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc32.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc32.Location = new System.Drawing.Point(19, 38);
            this.lblpBc32.Name = "lblpBc32";
            this.lblpBc32.Size = new System.Drawing.Size(23, 25);
            this.lblpBc32.TabIndex = 359;
            this.lblpBc32.Text = "0";
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox21.Location = new System.Drawing.Point(41, 38);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(12, 15);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 355;
            this.pictureBox21.TabStop = false;
            // 
            // lblTablet32
            // 
            this.lblTablet32.AutoSize = true;
            this.lblTablet32.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet32.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet32.Location = new System.Drawing.Point(6, 38);
            this.lblTablet32.Name = "lblTablet32";
            this.lblTablet32.Size = new System.Drawing.Size(11, 12);
            this.lblTablet32.TabIndex = 354;
            this.lblTablet32.Text = "0";
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox22.Location = new System.Drawing.Point(41, 20);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(15, 14);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 349;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox23.Location = new System.Drawing.Point(44, 5);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(10, 9);
            this.pictureBox23.TabIndex = 314;
            this.pictureBox23.TabStop = false;
            // 
            // picCamion32
            // 
            this.picCamion32.BackColor = System.Drawing.Color.Transparent;
            this.picCamion32.Location = new System.Drawing.Point(24, 57);
            this.picCamion32.Name = "picCamion32";
            this.picCamion32.Size = new System.Drawing.Size(27, 23);
            this.picCamion32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion32.TabIndex = 302;
            this.picCamion32.TabStop = false;
            // 
            // lblCam32
            // 
            this.lblCam32.AutoSize = true;
            this.lblCam32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam32.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam32.Location = new System.Drawing.Point(10, 8);
            this.lblCam32.Name = "lblCam32";
            this.lblCam32.Size = new System.Drawing.Size(45, 30);
            this.lblCam32.TabIndex = 248;
            this.lblCam32.Text = "32";
            this.lblCam32.Click += new System.EventHandler(this.lblCam32_Click);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Black;
            this.label59.Location = new System.Drawing.Point(7, 88);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(11, 12);
            this.label59.TabIndex = 268;
            this.label59.Text = "_";
            // 
            // lblpBr32
            // 
            this.lblpBr32.AutoSize = true;
            this.lblpBr32.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr32.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr32.Location = new System.Drawing.Point(18, 79);
            this.lblpBr32.Name = "lblpBr32";
            this.lblpBr32.Size = new System.Drawing.Size(11, 12);
            this.lblpBr32.TabIndex = 251;
            this.lblpBr32.Text = "_";
            // 
            // pBar32
            // 
            this.pBar32.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar32.Location = new System.Drawing.Point(24, 94);
            this.pBar32.Maximum = 500;
            this.pBar32.Name = "pBar32";
            this.pBar32.Size = new System.Drawing.Size(20, 3);
            this.pBar32.TabIndex = 279;
            // 
            // panelCam35
            // 
            this.panelCam35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam35.Controls.Add(this.lblpBc35);
            this.panelCam35.Controls.Add(this.pictureBox33);
            this.panelCam35.Controls.Add(this.lblTablet35);
            this.panelCam35.Controls.Add(this.pictureBox34);
            this.panelCam35.Controls.Add(this.pictureBox35);
            this.panelCam35.Controls.Add(this.picCamion35);
            this.panelCam35.Controls.Add(this.lblCam35);
            this.panelCam35.Controls.Add(this.label71);
            this.panelCam35.Controls.Add(this.lblpBr35);
            this.panelCam35.Controls.Add(this.pBar35);
            this.panelCam35.Location = new System.Drawing.Point(872, 25);
            this.panelCam35.Name = "panelCam35";
            this.panelCam35.Size = new System.Drawing.Size(47, 102);
            this.panelCam35.TabIndex = 362;
            this.panelCam35.Visible = false;
            // 
            // lblpBc35
            // 
            this.lblpBc35.AutoSize = true;
            this.lblpBc35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc35.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc35.Location = new System.Drawing.Point(11, 38);
            this.lblpBc35.Name = "lblpBc35";
            this.lblpBc35.Size = new System.Drawing.Size(23, 25);
            this.lblpBc35.TabIndex = 359;
            this.lblpBc35.Text = "0";
            // 
            // pictureBox33
            // 
            this.pictureBox33.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox33.Location = new System.Drawing.Point(42, 34);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(12, 15);
            this.pictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox33.TabIndex = 355;
            this.pictureBox33.TabStop = false;
            // 
            // lblTablet35
            // 
            this.lblTablet35.AutoSize = true;
            this.lblTablet35.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet35.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet35.Location = new System.Drawing.Point(7, 38);
            this.lblTablet35.Name = "lblTablet35";
            this.lblTablet35.Size = new System.Drawing.Size(11, 12);
            this.lblTablet35.TabIndex = 354;
            this.lblTablet35.Text = "0";
            // 
            // pictureBox34
            // 
            this.pictureBox34.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox34.Location = new System.Drawing.Point(39, 21);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(15, 14);
            this.pictureBox34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox34.TabIndex = 349;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox35.Location = new System.Drawing.Point(44, 5);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(10, 9);
            this.pictureBox35.TabIndex = 314;
            this.pictureBox35.TabStop = false;
            // 
            // picCamion35
            // 
            this.picCamion35.BackColor = System.Drawing.Color.Transparent;
            this.picCamion35.Location = new System.Drawing.Point(26, 58);
            this.picCamion35.Name = "picCamion35";
            this.picCamion35.Size = new System.Drawing.Size(25, 23);
            this.picCamion35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion35.TabIndex = 302;
            this.picCamion35.TabStop = false;
            // 
            // lblCam35
            // 
            this.lblCam35.AutoSize = true;
            this.lblCam35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam35.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam35.Location = new System.Drawing.Point(10, 8);
            this.lblCam35.Name = "lblCam35";
            this.lblCam35.Size = new System.Drawing.Size(45, 30);
            this.lblCam35.TabIndex = 248;
            this.lblCam35.Text = "35";
            this.lblCam35.Click += new System.EventHandler(this.lblCam35_Click);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.ForeColor = System.Drawing.Color.Black;
            this.label71.Location = new System.Drawing.Point(7, 88);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(11, 12);
            this.label71.TabIndex = 268;
            this.label71.Text = "_";
            // 
            // lblpBr35
            // 
            this.lblpBr35.AutoSize = true;
            this.lblpBr35.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr35.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr35.Location = new System.Drawing.Point(18, 79);
            this.lblpBr35.Name = "lblpBr35";
            this.lblpBr35.Size = new System.Drawing.Size(11, 12);
            this.lblpBr35.TabIndex = 251;
            this.lblpBr35.Text = "_";
            // 
            // pBar35
            // 
            this.pBar35.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar35.Location = new System.Drawing.Point(24, 94);
            this.pBar35.Maximum = 500;
            this.pBar35.Name = "pBar35";
            this.pBar35.Size = new System.Drawing.Size(20, 3);
            this.pBar35.TabIndex = 279;
            // 
            // panelCam31
            // 
            this.panelCam31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam31.Controls.Add(this.lblpBc31);
            this.panelCam31.Controls.Add(this.pictureBox25);
            this.panelCam31.Controls.Add(this.lblTablet31);
            this.panelCam31.Controls.Add(this.pictureBox26);
            this.panelCam31.Controls.Add(this.pictureBox27);
            this.panelCam31.Controls.Add(this.picCamion31);
            this.panelCam31.Controls.Add(this.lblCam31);
            this.panelCam31.Controls.Add(this.label63);
            this.panelCam31.Controls.Add(this.lblpBr31);
            this.panelCam31.Controls.Add(this.pBar31);
            this.panelCam31.Location = new System.Drawing.Point(773, 25);
            this.panelCam31.Name = "panelCam31";
            this.panelCam31.Size = new System.Drawing.Size(47, 102);
            this.panelCam31.TabIndex = 358;
            this.panelCam31.Visible = false;
            // 
            // lblpBc31
            // 
            this.lblpBc31.AutoSize = true;
            this.lblpBc31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc31.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc31.Location = new System.Drawing.Point(19, 38);
            this.lblpBc31.Name = "lblpBc31";
            this.lblpBc31.Size = new System.Drawing.Size(23, 25);
            this.lblpBc31.TabIndex = 358;
            this.lblpBc31.Text = "0";
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox25.Location = new System.Drawing.Point(42, 34);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(12, 15);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox25.TabIndex = 355;
            this.pictureBox25.TabStop = false;
            // 
            // lblTablet31
            // 
            this.lblTablet31.AutoSize = true;
            this.lblTablet31.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet31.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet31.Location = new System.Drawing.Point(7, 38);
            this.lblTablet31.Name = "lblTablet31";
            this.lblTablet31.Size = new System.Drawing.Size(11, 12);
            this.lblTablet31.TabIndex = 354;
            this.lblTablet31.Text = "0";
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox26.Location = new System.Drawing.Point(39, 21);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(15, 14);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox26.TabIndex = 349;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox27.Location = new System.Drawing.Point(44, 5);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(10, 9);
            this.pictureBox27.TabIndex = 314;
            this.pictureBox27.TabStop = false;
            // 
            // picCamion31
            // 
            this.picCamion31.BackColor = System.Drawing.Color.Transparent;
            this.picCamion31.Location = new System.Drawing.Point(26, 58);
            this.picCamion31.Name = "picCamion31";
            this.picCamion31.Size = new System.Drawing.Size(25, 23);
            this.picCamion31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion31.TabIndex = 302;
            this.picCamion31.TabStop = false;
            // 
            // lblCam31
            // 
            this.lblCam31.AutoSize = true;
            this.lblCam31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam31.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam31.Location = new System.Drawing.Point(10, 8);
            this.lblCam31.Name = "lblCam31";
            this.lblCam31.Size = new System.Drawing.Size(45, 30);
            this.lblCam31.TabIndex = 248;
            this.lblCam31.Text = "31";
            this.lblCam31.Click += new System.EventHandler(this.lblCam31_Click);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.Black;
            this.label63.Location = new System.Drawing.Point(7, 88);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(11, 12);
            this.label63.TabIndex = 268;
            this.label63.Text = "_";
            // 
            // lblpBr31
            // 
            this.lblpBr31.AutoSize = true;
            this.lblpBr31.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr31.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr31.Location = new System.Drawing.Point(18, 79);
            this.lblpBr31.Name = "lblpBr31";
            this.lblpBr31.Size = new System.Drawing.Size(11, 12);
            this.lblpBr31.TabIndex = 251;
            this.lblpBr31.Text = "_";
            // 
            // pBar31
            // 
            this.pBar31.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar31.Location = new System.Drawing.Point(24, 94);
            this.pBar31.Maximum = 500;
            this.pBar31.Name = "pBar31";
            this.pBar31.Size = new System.Drawing.Size(20, 3);
            this.pBar31.TabIndex = 279;
            // 
            // panelCam34
            // 
            this.panelCam34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam34.Controls.Add(this.lblpBc34);
            this.panelCam34.Controls.Add(this.pictureBox37);
            this.panelCam34.Controls.Add(this.lblTablet34);
            this.panelCam34.Controls.Add(this.pictureBox38);
            this.panelCam34.Controls.Add(this.pictureBox39);
            this.panelCam34.Controls.Add(this.picCamion34);
            this.panelCam34.Controls.Add(this.lblCam34);
            this.panelCam34.Controls.Add(this.label75);
            this.panelCam34.Controls.Add(this.lblpBr34);
            this.panelCam34.Controls.Add(this.pBar34);
            this.panelCam34.Location = new System.Drawing.Point(813, 131);
            this.panelCam34.Name = "panelCam34";
            this.panelCam34.Size = new System.Drawing.Size(47, 102);
            this.panelCam34.TabIndex = 361;
            this.panelCam34.Visible = false;
            // 
            // lblpBc34
            // 
            this.lblpBc34.AutoSize = true;
            this.lblpBc34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc34.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc34.Location = new System.Drawing.Point(11, 38);
            this.lblpBc34.Name = "lblpBc34";
            this.lblpBc34.Size = new System.Drawing.Size(23, 25);
            this.lblpBc34.TabIndex = 359;
            this.lblpBc34.Text = "0";
            // 
            // pictureBox37
            // 
            this.pictureBox37.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox37.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox37.Location = new System.Drawing.Point(41, 38);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(12, 15);
            this.pictureBox37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox37.TabIndex = 355;
            this.pictureBox37.TabStop = false;
            // 
            // lblTablet34
            // 
            this.lblTablet34.AutoSize = true;
            this.lblTablet34.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet34.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet34.Location = new System.Drawing.Point(6, 38);
            this.lblTablet34.Name = "lblTablet34";
            this.lblTablet34.Size = new System.Drawing.Size(11, 12);
            this.lblTablet34.TabIndex = 354;
            this.lblTablet34.Text = "0";
            // 
            // pictureBox38
            // 
            this.pictureBox38.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox38.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox38.Location = new System.Drawing.Point(41, 20);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(15, 14);
            this.pictureBox38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox38.TabIndex = 349;
            this.pictureBox38.TabStop = false;
            // 
            // pictureBox39
            // 
            this.pictureBox39.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox39.Location = new System.Drawing.Point(44, 5);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(10, 9);
            this.pictureBox39.TabIndex = 314;
            this.pictureBox39.TabStop = false;
            // 
            // picCamion34
            // 
            this.picCamion34.BackColor = System.Drawing.Color.Transparent;
            this.picCamion34.Location = new System.Drawing.Point(24, 57);
            this.picCamion34.Name = "picCamion34";
            this.picCamion34.Size = new System.Drawing.Size(27, 23);
            this.picCamion34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion34.TabIndex = 302;
            this.picCamion34.TabStop = false;
            // 
            // lblCam34
            // 
            this.lblCam34.AutoSize = true;
            this.lblCam34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam34.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam34.Location = new System.Drawing.Point(10, 8);
            this.lblCam34.Name = "lblCam34";
            this.lblCam34.Size = new System.Drawing.Size(45, 30);
            this.lblCam34.TabIndex = 248;
            this.lblCam34.Text = "34";
            this.lblCam34.Click += new System.EventHandler(this.lblCam34_Click);
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.ForeColor = System.Drawing.Color.Black;
            this.label75.Location = new System.Drawing.Point(7, 88);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(11, 12);
            this.label75.TabIndex = 268;
            this.label75.Text = "_";
            // 
            // lblpBr34
            // 
            this.lblpBr34.AutoSize = true;
            this.lblpBr34.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr34.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr34.Location = new System.Drawing.Point(18, 79);
            this.lblpBr34.Name = "lblpBr34";
            this.lblpBr34.Size = new System.Drawing.Size(11, 12);
            this.lblpBr34.TabIndex = 251;
            this.lblpBr34.Text = "_";
            // 
            // pBar34
            // 
            this.pBar34.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar34.Location = new System.Drawing.Point(24, 94);
            this.pBar34.Maximum = 500;
            this.pBar34.Name = "pBar34";
            this.pBar34.Size = new System.Drawing.Size(20, 3);
            this.pBar34.TabIndex = 279;
            // 
            // panelCam30
            // 
            this.panelCam30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam30.Controls.Add(this.lblpBc30);
            this.panelCam30.Controls.Add(this.pictureBox7);
            this.panelCam30.Controls.Add(this.lblTablet30);
            this.panelCam30.Controls.Add(this.pictureBox14);
            this.panelCam30.Controls.Add(this.pictureBox15);
            this.panelCam30.Controls.Add(this.picCamion30);
            this.panelCam30.Controls.Add(this.lblCam30);
            this.panelCam30.Controls.Add(this.label42);
            this.panelCam30.Controls.Add(this.lblpBr30);
            this.panelCam30.Controls.Add(this.pBar30);
            this.panelCam30.Location = new System.Drawing.Point(715, 131);
            this.panelCam30.Name = "panelCam30";
            this.panelCam30.Size = new System.Drawing.Size(47, 102);
            this.panelCam30.TabIndex = 357;
            this.panelCam30.Visible = false;
            // 
            // lblpBc30
            // 
            this.lblpBc30.AutoSize = true;
            this.lblpBc30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc30.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc30.Location = new System.Drawing.Point(21, 37);
            this.lblpBc30.Name = "lblpBc30";
            this.lblpBc30.Size = new System.Drawing.Size(23, 25);
            this.lblpBc30.TabIndex = 357;
            this.lblpBc30.Text = "0";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(41, 38);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(12, 15);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 355;
            this.pictureBox7.TabStop = false;
            // 
            // lblTablet30
            // 
            this.lblTablet30.AutoSize = true;
            this.lblTablet30.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet30.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet30.Location = new System.Drawing.Point(6, 38);
            this.lblTablet30.Name = "lblTablet30";
            this.lblTablet30.Size = new System.Drawing.Size(11, 12);
            this.lblTablet30.TabIndex = 354;
            this.lblTablet30.Text = "0";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox14.Location = new System.Drawing.Point(41, 20);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(15, 14);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 349;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox15.Location = new System.Drawing.Point(44, 5);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(10, 9);
            this.pictureBox15.TabIndex = 314;
            this.pictureBox15.TabStop = false;
            // 
            // picCamion30
            // 
            this.picCamion30.BackColor = System.Drawing.Color.Transparent;
            this.picCamion30.Location = new System.Drawing.Point(24, 57);
            this.picCamion30.Name = "picCamion30";
            this.picCamion30.Size = new System.Drawing.Size(27, 23);
            this.picCamion30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion30.TabIndex = 302;
            this.picCamion30.TabStop = false;
            // 
            // lblCam30
            // 
            this.lblCam30.AutoSize = true;
            this.lblCam30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam30.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam30.Location = new System.Drawing.Point(10, 8);
            this.lblCam30.Name = "lblCam30";
            this.lblCam30.Size = new System.Drawing.Size(45, 30);
            this.lblCam30.TabIndex = 248;
            this.lblCam30.Text = "30";
            this.lblCam30.Click += new System.EventHandler(this.lblCam30_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.Black;
            this.label42.Location = new System.Drawing.Point(7, 88);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(11, 12);
            this.label42.TabIndex = 268;
            this.label42.Text = "_";
            // 
            // lblpBr30
            // 
            this.lblpBr30.AutoSize = true;
            this.lblpBr30.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr30.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr30.Location = new System.Drawing.Point(18, 79);
            this.lblpBr30.Name = "lblpBr30";
            this.lblpBr30.Size = new System.Drawing.Size(11, 12);
            this.lblpBr30.TabIndex = 251;
            this.lblpBr30.Text = "_";
            // 
            // pBar30
            // 
            this.pBar30.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar30.Location = new System.Drawing.Point(24, 94);
            this.pBar30.Maximum = 500;
            this.pBar30.Name = "pBar30";
            this.pBar30.Size = new System.Drawing.Size(20, 3);
            this.pBar30.TabIndex = 279;
            // 
            // panelCam33
            // 
            this.panelCam33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam33.Controls.Add(this.lblpBc33);
            this.panelCam33.Controls.Add(this.pictureBox41);
            this.panelCam33.Controls.Add(this.lblTablet33);
            this.panelCam33.Controls.Add(this.pictureBox42);
            this.panelCam33.Controls.Add(this.pictureBox43);
            this.panelCam33.Controls.Add(this.picCamion33);
            this.panelCam33.Controls.Add(this.lblCam33);
            this.panelCam33.Controls.Add(this.label79);
            this.panelCam33.Controls.Add(this.lblpBr33);
            this.panelCam33.Controls.Add(this.pBar33);
            this.panelCam33.Location = new System.Drawing.Point(822, 25);
            this.panelCam33.Name = "panelCam33";
            this.panelCam33.Size = new System.Drawing.Size(47, 102);
            this.panelCam33.TabIndex = 360;
            this.panelCam33.Visible = false;
            // 
            // lblpBc33
            // 
            this.lblpBc33.AutoSize = true;
            this.lblpBc33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc33.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc33.Location = new System.Drawing.Point(11, 38);
            this.lblpBc33.Name = "lblpBc33";
            this.lblpBc33.Size = new System.Drawing.Size(23, 25);
            this.lblpBc33.TabIndex = 359;
            this.lblpBc33.Text = "0";
            // 
            // pictureBox41
            // 
            this.pictureBox41.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox41.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox41.Location = new System.Drawing.Point(42, 34);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(12, 15);
            this.pictureBox41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox41.TabIndex = 355;
            this.pictureBox41.TabStop = false;
            // 
            // lblTablet33
            // 
            this.lblTablet33.AutoSize = true;
            this.lblTablet33.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet33.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet33.Location = new System.Drawing.Point(7, 38);
            this.lblTablet33.Name = "lblTablet33";
            this.lblTablet33.Size = new System.Drawing.Size(11, 12);
            this.lblTablet33.TabIndex = 354;
            this.lblTablet33.Text = "0";
            // 
            // pictureBox42
            // 
            this.pictureBox42.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox42.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox42.Location = new System.Drawing.Point(39, 21);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(15, 14);
            this.pictureBox42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox42.TabIndex = 349;
            this.pictureBox42.TabStop = false;
            // 
            // pictureBox43
            // 
            this.pictureBox43.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox43.Location = new System.Drawing.Point(44, 5);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(10, 9);
            this.pictureBox43.TabIndex = 314;
            this.pictureBox43.TabStop = false;
            // 
            // picCamion33
            // 
            this.picCamion33.BackColor = System.Drawing.Color.Transparent;
            this.picCamion33.Location = new System.Drawing.Point(26, 58);
            this.picCamion33.Name = "picCamion33";
            this.picCamion33.Size = new System.Drawing.Size(25, 23);
            this.picCamion33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion33.TabIndex = 302;
            this.picCamion33.TabStop = false;
            // 
            // lblCam33
            // 
            this.lblCam33.AutoSize = true;
            this.lblCam33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam33.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam33.Location = new System.Drawing.Point(10, 8);
            this.lblCam33.Name = "lblCam33";
            this.lblCam33.Size = new System.Drawing.Size(45, 30);
            this.lblCam33.TabIndex = 248;
            this.lblCam33.Text = "33";
            this.lblCam33.Click += new System.EventHandler(this.lblCam33_Click);
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.Color.Black;
            this.label79.Location = new System.Drawing.Point(7, 88);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(11, 12);
            this.label79.TabIndex = 268;
            this.label79.Text = "_";
            // 
            // lblpBr33
            // 
            this.lblpBr33.AutoSize = true;
            this.lblpBr33.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr33.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr33.Location = new System.Drawing.Point(18, 79);
            this.lblpBr33.Name = "lblpBr33";
            this.lblpBr33.Size = new System.Drawing.Size(11, 12);
            this.lblpBr33.TabIndex = 251;
            this.lblpBr33.Text = "_";
            // 
            // pBar33
            // 
            this.pBar33.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar33.Location = new System.Drawing.Point(24, 94);
            this.pBar33.Maximum = 500;
            this.pBar33.Name = "pBar33";
            this.pBar33.Size = new System.Drawing.Size(20, 3);
            this.pBar33.TabIndex = 279;
            // 
            // panelCam28
            // 
            this.panelCam28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam28.Controls.Add(this.picPila28);
            this.panelCam28.Controls.Add(this.lblTablet28);
            this.panelCam28.Controls.Add(this.picWifi28);
            this.panelCam28.Controls.Add(this.picMov28);
            this.panelCam28.Controls.Add(this.picCamion28);
            this.panelCam28.Controls.Add(this.lblCam28);
            this.panelCam28.Controls.Add(this.lblpAct28);
            this.panelCam28.Controls.Add(this.lblpBr28);
            this.panelCam28.Controls.Add(this.lblpBc28);
            this.panelCam28.Controls.Add(this.pBar28);
            this.panelCam28.Location = new System.Drawing.Point(666, 131);
            this.panelCam28.Name = "panelCam28";
            this.panelCam28.Size = new System.Drawing.Size(47, 102);
            this.panelCam28.TabIndex = 320;
            this.panelCam28.Visible = false;
            // 
            // picPila28
            // 
            this.picPila28.BackColor = System.Drawing.Color.Transparent;
            this.picPila28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila28.Location = new System.Drawing.Point(41, 38);
            this.picPila28.Name = "picPila28";
            this.picPila28.Size = new System.Drawing.Size(12, 15);
            this.picPila28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila28.TabIndex = 355;
            this.picPila28.TabStop = false;
            // 
            // lblTablet28
            // 
            this.lblTablet28.AutoSize = true;
            this.lblTablet28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet28.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet28.Location = new System.Drawing.Point(6, 38);
            this.lblTablet28.Name = "lblTablet28";
            this.lblTablet28.Size = new System.Drawing.Size(11, 12);
            this.lblTablet28.TabIndex = 354;
            this.lblTablet28.Text = "0";
            // 
            // picWifi28
            // 
            this.picWifi28.BackColor = System.Drawing.Color.Transparent;
            this.picWifi28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi28.Location = new System.Drawing.Point(41, 20);
            this.picWifi28.Name = "picWifi28";
            this.picWifi28.Size = new System.Drawing.Size(15, 14);
            this.picWifi28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi28.TabIndex = 349;
            this.picWifi28.TabStop = false;
            // 
            // picMov28
            // 
            this.picMov28.BackColor = System.Drawing.Color.Transparent;
            this.picMov28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov28.Location = new System.Drawing.Point(44, 5);
            this.picMov28.Name = "picMov28";
            this.picMov28.Size = new System.Drawing.Size(10, 9);
            this.picMov28.TabIndex = 314;
            this.picMov28.TabStop = false;
            // 
            // picCamion28
            // 
            this.picCamion28.BackColor = System.Drawing.Color.Transparent;
            this.picCamion28.Location = new System.Drawing.Point(24, 57);
            this.picCamion28.Name = "picCamion28";
            this.picCamion28.Size = new System.Drawing.Size(27, 23);
            this.picCamion28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion28.TabIndex = 302;
            this.picCamion28.TabStop = false;
            // 
            // lblCam28
            // 
            this.lblCam28.AutoSize = true;
            this.lblCam28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam28.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam28.Location = new System.Drawing.Point(10, 8);
            this.lblCam28.Name = "lblCam28";
            this.lblCam28.Size = new System.Drawing.Size(45, 30);
            this.lblCam28.TabIndex = 248;
            this.lblCam28.Text = "28";
            this.lblCam28.Click += new System.EventHandler(this.lblCam28_Click);
            // 
            // lblpAct28
            // 
            this.lblpAct28.AutoSize = true;
            this.lblpAct28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct28.ForeColor = System.Drawing.Color.Black;
            this.lblpAct28.Location = new System.Drawing.Point(7, 88);
            this.lblpAct28.Name = "lblpAct28";
            this.lblpAct28.Size = new System.Drawing.Size(11, 12);
            this.lblpAct28.TabIndex = 268;
            this.lblpAct28.Text = "_";
            // 
            // lblpBr28
            // 
            this.lblpBr28.AutoSize = true;
            this.lblpBr28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr28.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr28.Location = new System.Drawing.Point(18, 79);
            this.lblpBr28.Name = "lblpBr28";
            this.lblpBr28.Size = new System.Drawing.Size(11, 12);
            this.lblpBr28.TabIndex = 251;
            this.lblpBr28.Text = "_";
            // 
            // pBar28
            // 
            this.pBar28.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar28.Location = new System.Drawing.Point(24, 94);
            this.pBar28.Maximum = 500;
            this.pBar28.Name = "pBar28";
            this.pBar28.Size = new System.Drawing.Size(20, 3);
            this.pBar28.TabIndex = 279;
            // 
            // panelCam29
            // 
            this.panelCam29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam29.Controls.Add(this.lblpBc29);
            this.panelCam29.Controls.Add(this.pictureBox17);
            this.panelCam29.Controls.Add(this.lblTablet29);
            this.panelCam29.Controls.Add(this.pictureBox18);
            this.panelCam29.Controls.Add(this.pictureBox19);
            this.panelCam29.Controls.Add(this.picCamion29);
            this.panelCam29.Controls.Add(this.lblCam29);
            this.panelCam29.Controls.Add(this.label55);
            this.panelCam29.Controls.Add(this.lblpBr29);
            this.panelCam29.Controls.Add(this.pBar29);
            this.panelCam29.Location = new System.Drawing.Point(724, 25);
            this.panelCam29.Name = "panelCam29";
            this.panelCam29.Size = new System.Drawing.Size(47, 102);
            this.panelCam29.TabIndex = 356;
            this.panelCam29.Visible = false;
            // 
            // lblpBc29
            // 
            this.lblpBc29.AutoSize = true;
            this.lblpBc29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBc29.ForeColor = System.Drawing.Color.Silver;
            this.lblpBc29.Location = new System.Drawing.Point(19, 35);
            this.lblpBc29.Name = "lblpBc29";
            this.lblpBc29.Size = new System.Drawing.Size(23, 25);
            this.lblpBc29.TabIndex = 356;
            this.lblpBc29.Text = "0";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox17.Location = new System.Drawing.Point(42, 34);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(12, 15);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 355;
            this.pictureBox17.TabStop = false;
            // 
            // lblTablet29
            // 
            this.lblTablet29.AutoSize = true;
            this.lblTablet29.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet29.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet29.Location = new System.Drawing.Point(7, 38);
            this.lblTablet29.Name = "lblTablet29";
            this.lblTablet29.Size = new System.Drawing.Size(11, 12);
            this.lblTablet29.TabIndex = 354;
            this.lblTablet29.Text = "0";
            this.lblTablet29.Click += new System.EventHandler(this.label53_Click);
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox18.Location = new System.Drawing.Point(39, 21);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(15, 14);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 349;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox19.Location = new System.Drawing.Point(44, 5);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(10, 9);
            this.pictureBox19.TabIndex = 314;
            this.pictureBox19.TabStop = false;
            // 
            // picCamion29
            // 
            this.picCamion29.BackColor = System.Drawing.Color.Transparent;
            this.picCamion29.Location = new System.Drawing.Point(26, 58);
            this.picCamion29.Name = "picCamion29";
            this.picCamion29.Size = new System.Drawing.Size(25, 23);
            this.picCamion29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion29.TabIndex = 302;
            this.picCamion29.TabStop = false;
            // 
            // lblCam29
            // 
            this.lblCam29.AutoSize = true;
            this.lblCam29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam29.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam29.Location = new System.Drawing.Point(10, 8);
            this.lblCam29.Name = "lblCam29";
            this.lblCam29.Size = new System.Drawing.Size(45, 30);
            this.lblCam29.TabIndex = 248;
            this.lblCam29.Text = "29";
            this.lblCam29.Click += new System.EventHandler(this.lblCam29_Click);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.Black;
            this.label55.Location = new System.Drawing.Point(7, 88);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(11, 12);
            this.label55.TabIndex = 268;
            this.label55.Text = "_";
            // 
            // lblpBr29
            // 
            this.lblpBr29.AutoSize = true;
            this.lblpBr29.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr29.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr29.Location = new System.Drawing.Point(18, 79);
            this.lblpBr29.Name = "lblpBr29";
            this.lblpBr29.Size = new System.Drawing.Size(11, 12);
            this.lblpBr29.TabIndex = 251;
            this.lblpBr29.Text = "_";
            // 
            // pBar29
            // 
            this.pBar29.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar29.Location = new System.Drawing.Point(24, 94);
            this.pBar29.Maximum = 500;
            this.pBar29.Name = "pBar29";
            this.pBar29.Size = new System.Drawing.Size(20, 3);
            this.pBar29.TabIndex = 279;
            // 
            // panelCam24
            // 
            this.panelCam24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam24.Controls.Add(this.picPila24);
            this.panelCam24.Controls.Add(this.lblTablet24);
            this.panelCam24.Controls.Add(this.picWifi24);
            this.panelCam24.Controls.Add(this.picMov24);
            this.panelCam24.Controls.Add(this.picCamion24);
            this.panelCam24.Controls.Add(this.lblCam24);
            this.panelCam24.Controls.Add(this.lblpAct24);
            this.panelCam24.Controls.Add(this.lblpBr24);
            this.panelCam24.Controls.Add(this.pBar24);
            this.panelCam24.Controls.Add(this.lblpBc24);
            this.panelCam24.Location = new System.Drawing.Point(568, 131);
            this.panelCam24.Name = "panelCam24";
            this.panelCam24.Size = new System.Drawing.Size(47, 102);
            this.panelCam24.TabIndex = 316;
            this.panelCam24.Visible = false;
            // 
            // picPila24
            // 
            this.picPila24.BackColor = System.Drawing.Color.Transparent;
            this.picPila24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila24.Location = new System.Drawing.Point(43, 42);
            this.picPila24.Name = "picPila24";
            this.picPila24.Size = new System.Drawing.Size(12, 15);
            this.picPila24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila24.TabIndex = 354;
            this.picPila24.TabStop = false;
            // 
            // lblTablet24
            // 
            this.lblTablet24.AutoSize = true;
            this.lblTablet24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet24.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet24.Location = new System.Drawing.Point(41, 84);
            this.lblTablet24.Name = "lblTablet24";
            this.lblTablet24.Size = new System.Drawing.Size(11, 12);
            this.lblTablet24.TabIndex = 353;
            this.lblTablet24.Text = "0";
            // 
            // picWifi24
            // 
            this.picWifi24.BackColor = System.Drawing.Color.Transparent;
            this.picWifi24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi24.Location = new System.Drawing.Point(39, 21);
            this.picWifi24.Name = "picWifi24";
            this.picWifi24.Size = new System.Drawing.Size(15, 14);
            this.picWifi24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi24.TabIndex = 349;
            this.picWifi24.TabStop = false;
            // 
            // picMov24
            // 
            this.picMov24.BackColor = System.Drawing.Color.Transparent;
            this.picMov24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov24.Location = new System.Drawing.Point(44, 5);
            this.picMov24.Name = "picMov24";
            this.picMov24.Size = new System.Drawing.Size(10, 9);
            this.picMov24.TabIndex = 314;
            this.picMov24.TabStop = false;
            // 
            // picCamion24
            // 
            this.picCamion24.BackColor = System.Drawing.Color.Transparent;
            this.picCamion24.Location = new System.Drawing.Point(24, 56);
            this.picCamion24.Name = "picCamion24";
            this.picCamion24.Size = new System.Drawing.Size(27, 25);
            this.picCamion24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion24.TabIndex = 302;
            this.picCamion24.TabStop = false;
            // 
            // lblCam24
            // 
            this.lblCam24.AutoSize = true;
            this.lblCam24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam24.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam24.Location = new System.Drawing.Point(10, 8);
            this.lblCam24.Name = "lblCam24";
            this.lblCam24.Size = new System.Drawing.Size(45, 30);
            this.lblCam24.TabIndex = 248;
            this.lblCam24.Text = "24";
            this.lblCam24.Click += new System.EventHandler(this.lblCam24_Click);
            // 
            // lblpAct24
            // 
            this.lblpAct24.AutoSize = true;
            this.lblpAct24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct24.ForeColor = System.Drawing.Color.Black;
            this.lblpAct24.Location = new System.Drawing.Point(7, 88);
            this.lblpAct24.Name = "lblpAct24";
            this.lblpAct24.Size = new System.Drawing.Size(11, 12);
            this.lblpAct24.TabIndex = 268;
            this.lblpAct24.Text = "_";
            // 
            // lblpBr24
            // 
            this.lblpBr24.AutoSize = true;
            this.lblpBr24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr24.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr24.Location = new System.Drawing.Point(18, 79);
            this.lblpBr24.Name = "lblpBr24";
            this.lblpBr24.Size = new System.Drawing.Size(11, 12);
            this.lblpBr24.TabIndex = 251;
            this.lblpBr24.Text = "_";
            // 
            // pBar24
            // 
            this.pBar24.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar24.Location = new System.Drawing.Point(24, 94);
            this.pBar24.Maximum = 500;
            this.pBar24.Name = "pBar24";
            this.pBar24.Size = new System.Drawing.Size(20, 3);
            this.pBar24.TabIndex = 279;
            // 
            // panelCam27
            // 
            this.panelCam27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam27.Controls.Add(this.picPila27);
            this.panelCam27.Controls.Add(this.lblTablet27);
            this.panelCam27.Controls.Add(this.picWifi27);
            this.panelCam27.Controls.Add(this.picMov27);
            this.panelCam27.Controls.Add(this.picCamion27);
            this.panelCam27.Controls.Add(this.lblCam27);
            this.panelCam27.Controls.Add(this.lblpAct27);
            this.panelCam27.Controls.Add(this.lblpBr27);
            this.panelCam27.Controls.Add(this.pBar27);
            this.panelCam27.Controls.Add(this.lblpBc27);
            this.panelCam27.Location = new System.Drawing.Point(675, 25);
            this.panelCam27.Name = "panelCam27";
            this.panelCam27.Size = new System.Drawing.Size(47, 102);
            this.panelCam27.TabIndex = 319;
            this.panelCam27.Visible = false;
            // 
            // picPila27
            // 
            this.picPila27.BackColor = System.Drawing.Color.Transparent;
            this.picPila27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila27.Location = new System.Drawing.Point(42, 34);
            this.picPila27.Name = "picPila27";
            this.picPila27.Size = new System.Drawing.Size(12, 15);
            this.picPila27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila27.TabIndex = 355;
            this.picPila27.TabStop = false;
            // 
            // lblTablet27
            // 
            this.lblTablet27.AutoSize = true;
            this.lblTablet27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet27.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet27.Location = new System.Drawing.Point(7, 38);
            this.lblTablet27.Name = "lblTablet27";
            this.lblTablet27.Size = new System.Drawing.Size(11, 12);
            this.lblTablet27.TabIndex = 354;
            this.lblTablet27.Text = "0";
            // 
            // picWifi27
            // 
            this.picWifi27.BackColor = System.Drawing.Color.Transparent;
            this.picWifi27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi27.Location = new System.Drawing.Point(39, 21);
            this.picWifi27.Name = "picWifi27";
            this.picWifi27.Size = new System.Drawing.Size(15, 14);
            this.picWifi27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi27.TabIndex = 349;
            this.picWifi27.TabStop = false;
            // 
            // picMov27
            // 
            this.picMov27.BackColor = System.Drawing.Color.Transparent;
            this.picMov27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov27.Location = new System.Drawing.Point(44, 5);
            this.picMov27.Name = "picMov27";
            this.picMov27.Size = new System.Drawing.Size(10, 9);
            this.picMov27.TabIndex = 314;
            this.picMov27.TabStop = false;
            // 
            // picCamion27
            // 
            this.picCamion27.BackColor = System.Drawing.Color.Transparent;
            this.picCamion27.Location = new System.Drawing.Point(26, 58);
            this.picCamion27.Name = "picCamion27";
            this.picCamion27.Size = new System.Drawing.Size(25, 23);
            this.picCamion27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion27.TabIndex = 302;
            this.picCamion27.TabStop = false;
            // 
            // lblCam27
            // 
            this.lblCam27.AutoSize = true;
            this.lblCam27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam27.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam27.Location = new System.Drawing.Point(10, 8);
            this.lblCam27.Name = "lblCam27";
            this.lblCam27.Size = new System.Drawing.Size(45, 30);
            this.lblCam27.TabIndex = 248;
            this.lblCam27.Text = "27";
            this.lblCam27.Click += new System.EventHandler(this.lblCam27_Click);
            // 
            // lblpAct27
            // 
            this.lblpAct27.AutoSize = true;
            this.lblpAct27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct27.ForeColor = System.Drawing.Color.Black;
            this.lblpAct27.Location = new System.Drawing.Point(7, 88);
            this.lblpAct27.Name = "lblpAct27";
            this.lblpAct27.Size = new System.Drawing.Size(11, 12);
            this.lblpAct27.TabIndex = 268;
            this.lblpAct27.Text = "_";
            // 
            // lblpBr27
            // 
            this.lblpBr27.AutoSize = true;
            this.lblpBr27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr27.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr27.Location = new System.Drawing.Point(18, 79);
            this.lblpBr27.Name = "lblpBr27";
            this.lblpBr27.Size = new System.Drawing.Size(11, 12);
            this.lblpBr27.TabIndex = 251;
            this.lblpBr27.Text = "_";
            // 
            // pBar27
            // 
            this.pBar27.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar27.Location = new System.Drawing.Point(24, 94);
            this.pBar27.Maximum = 500;
            this.pBar27.Name = "pBar27";
            this.pBar27.Size = new System.Drawing.Size(20, 3);
            this.pBar27.TabIndex = 279;
            // 
            // panelCam23
            // 
            this.panelCam23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam23.Controls.Add(this.picPila23);
            this.panelCam23.Controls.Add(this.lblTablet23);
            this.panelCam23.Controls.Add(this.picWifi23);
            this.panelCam23.Controls.Add(this.picMov23);
            this.panelCam23.Controls.Add(this.picCamion23);
            this.panelCam23.Controls.Add(this.lblCam23);
            this.panelCam23.Controls.Add(this.lblpAct23);
            this.panelCam23.Controls.Add(this.lblpBr23);
            this.panelCam23.Controls.Add(this.pBar23);
            this.panelCam23.Controls.Add(this.lblpBc23);
            this.panelCam23.Location = new System.Drawing.Point(577, 25);
            this.panelCam23.Name = "panelCam23";
            this.panelCam23.Size = new System.Drawing.Size(47, 102);
            this.panelCam23.TabIndex = 315;
            this.panelCam23.Visible = false;
            // 
            // picPila23
            // 
            this.picPila23.BackColor = System.Drawing.Color.Transparent;
            this.picPila23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila23.Location = new System.Drawing.Point(43, 40);
            this.picPila23.Name = "picPila23";
            this.picPila23.Size = new System.Drawing.Size(12, 15);
            this.picPila23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila23.TabIndex = 354;
            this.picPila23.TabStop = false;
            // 
            // lblTablet23
            // 
            this.lblTablet23.AutoSize = true;
            this.lblTablet23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet23.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet23.Location = new System.Drawing.Point(40, 84);
            this.lblTablet23.Name = "lblTablet23";
            this.lblTablet23.Size = new System.Drawing.Size(11, 12);
            this.lblTablet23.TabIndex = 353;
            this.lblTablet23.Text = "0";
            // 
            // picWifi23
            // 
            this.picWifi23.BackColor = System.Drawing.Color.Transparent;
            this.picWifi23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi23.Location = new System.Drawing.Point(42, 21);
            this.picWifi23.Name = "picWifi23";
            this.picWifi23.Size = new System.Drawing.Size(15, 14);
            this.picWifi23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi23.TabIndex = 349;
            this.picWifi23.TabStop = false;
            // 
            // picMov23
            // 
            this.picMov23.BackColor = System.Drawing.Color.Transparent;
            this.picMov23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov23.Location = new System.Drawing.Point(44, 5);
            this.picMov23.Name = "picMov23";
            this.picMov23.Size = new System.Drawing.Size(10, 9);
            this.picMov23.TabIndex = 314;
            this.picMov23.TabStop = false;
            // 
            // picCamion23
            // 
            this.picCamion23.BackColor = System.Drawing.Color.Transparent;
            this.picCamion23.Location = new System.Drawing.Point(33, 62);
            this.picCamion23.Name = "picCamion23";
            this.picCamion23.Size = new System.Drawing.Size(18, 18);
            this.picCamion23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion23.TabIndex = 302;
            this.picCamion23.TabStop = false;
            // 
            // lblCam23
            // 
            this.lblCam23.AutoSize = true;
            this.lblCam23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam23.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam23.Location = new System.Drawing.Point(10, 8);
            this.lblCam23.Name = "lblCam23";
            this.lblCam23.Size = new System.Drawing.Size(45, 30);
            this.lblCam23.TabIndex = 248;
            this.lblCam23.Text = "23";
            this.lblCam23.Click += new System.EventHandler(this.lblCam23_Click);
            // 
            // lblpAct23
            // 
            this.lblpAct23.AutoSize = true;
            this.lblpAct23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct23.ForeColor = System.Drawing.Color.Black;
            this.lblpAct23.Location = new System.Drawing.Point(7, 88);
            this.lblpAct23.Name = "lblpAct23";
            this.lblpAct23.Size = new System.Drawing.Size(11, 12);
            this.lblpAct23.TabIndex = 268;
            this.lblpAct23.Text = "_";
            // 
            // lblpBr23
            // 
            this.lblpBr23.AutoSize = true;
            this.lblpBr23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr23.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr23.Location = new System.Drawing.Point(18, 79);
            this.lblpBr23.Name = "lblpBr23";
            this.lblpBr23.Size = new System.Drawing.Size(11, 12);
            this.lblpBr23.TabIndex = 251;
            this.lblpBr23.Text = "_";
            // 
            // pBar23
            // 
            this.pBar23.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar23.Location = new System.Drawing.Point(24, 94);
            this.pBar23.Maximum = 500;
            this.pBar23.Name = "pBar23";
            this.pBar23.Size = new System.Drawing.Size(20, 3);
            this.pBar23.TabIndex = 279;
            // 
            // panelCam26
            // 
            this.panelCam26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam26.Controls.Add(this.picPila26);
            this.panelCam26.Controls.Add(this.lblTablet26);
            this.panelCam26.Controls.Add(this.picWifi26);
            this.panelCam26.Controls.Add(this.picMov26);
            this.panelCam26.Controls.Add(this.picCamion26);
            this.panelCam26.Controls.Add(this.lblCam26);
            this.panelCam26.Controls.Add(this.lblpAct26);
            this.panelCam26.Controls.Add(this.lblpBr26);
            this.panelCam26.Controls.Add(this.pBar26);
            this.panelCam26.Controls.Add(this.lblpBc26);
            this.panelCam26.Location = new System.Drawing.Point(617, 131);
            this.panelCam26.Name = "panelCam26";
            this.panelCam26.Size = new System.Drawing.Size(47, 102);
            this.panelCam26.TabIndex = 318;
            this.panelCam26.Visible = false;
            // 
            // picPila26
            // 
            this.picPila26.BackColor = System.Drawing.Color.Transparent;
            this.picPila26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila26.Location = new System.Drawing.Point(44, 34);
            this.picPila26.Name = "picPila26";
            this.picPila26.Size = new System.Drawing.Size(12, 15);
            this.picPila26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila26.TabIndex = 355;
            this.picPila26.TabStop = false;
            // 
            // lblTablet26
            // 
            this.lblTablet26.AutoSize = true;
            this.lblTablet26.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet26.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet26.Location = new System.Drawing.Point(8, 38);
            this.lblTablet26.Name = "lblTablet26";
            this.lblTablet26.Size = new System.Drawing.Size(11, 12);
            this.lblTablet26.TabIndex = 354;
            this.lblTablet26.Text = "0";
            // 
            // picWifi26
            // 
            this.picWifi26.BackColor = System.Drawing.Color.Transparent;
            this.picWifi26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi26.Location = new System.Drawing.Point(39, 20);
            this.picWifi26.Name = "picWifi26";
            this.picWifi26.Size = new System.Drawing.Size(15, 14);
            this.picWifi26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi26.TabIndex = 349;
            this.picWifi26.TabStop = false;
            // 
            // picMov26
            // 
            this.picMov26.BackColor = System.Drawing.Color.Transparent;
            this.picMov26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov26.Location = new System.Drawing.Point(44, 5);
            this.picMov26.Name = "picMov26";
            this.picMov26.Size = new System.Drawing.Size(10, 9);
            this.picMov26.TabIndex = 314;
            this.picMov26.TabStop = false;
            // 
            // picCamion26
            // 
            this.picCamion26.BackColor = System.Drawing.Color.Transparent;
            this.picCamion26.Location = new System.Drawing.Point(24, 50);
            this.picCamion26.Name = "picCamion26";
            this.picCamion26.Size = new System.Drawing.Size(27, 31);
            this.picCamion26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion26.TabIndex = 302;
            this.picCamion26.TabStop = false;
            // 
            // lblCam26
            // 
            this.lblCam26.AutoSize = true;
            this.lblCam26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam26.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam26.Location = new System.Drawing.Point(10, 8);
            this.lblCam26.Name = "lblCam26";
            this.lblCam26.Size = new System.Drawing.Size(45, 30);
            this.lblCam26.TabIndex = 248;
            this.lblCam26.Text = "26";
            this.lblCam26.Click += new System.EventHandler(this.lblCam26_Click);
            // 
            // lblpAct26
            // 
            this.lblpAct26.AutoSize = true;
            this.lblpAct26.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct26.ForeColor = System.Drawing.Color.Black;
            this.lblpAct26.Location = new System.Drawing.Point(7, 88);
            this.lblpAct26.Name = "lblpAct26";
            this.lblpAct26.Size = new System.Drawing.Size(11, 12);
            this.lblpAct26.TabIndex = 268;
            this.lblpAct26.Text = "_";
            // 
            // lblpBr26
            // 
            this.lblpBr26.AutoSize = true;
            this.lblpBr26.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr26.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr26.Location = new System.Drawing.Point(18, 79);
            this.lblpBr26.Name = "lblpBr26";
            this.lblpBr26.Size = new System.Drawing.Size(11, 12);
            this.lblpBr26.TabIndex = 251;
            this.lblpBr26.Text = "_";
            // 
            // pBar26
            // 
            this.pBar26.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar26.Location = new System.Drawing.Point(24, 94);
            this.pBar26.Maximum = 500;
            this.pBar26.Name = "pBar26";
            this.pBar26.Size = new System.Drawing.Size(20, 3);
            this.pBar26.TabIndex = 279;
            // 
            // panelCam21
            // 
            this.panelCam21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam21.Controls.Add(this.picPila21);
            this.panelCam21.Controls.Add(this.lblTablet21);
            this.panelCam21.Controls.Add(this.picWifi21);
            this.panelCam21.Controls.Add(this.picCamion21);
            this.panelCam21.Controls.Add(this.picMov21);
            this.panelCam21.Controls.Add(this.lblCam21);
            this.panelCam21.Controls.Add(this.lblpAct21);
            this.panelCam21.Controls.Add(this.lblpBr21);
            this.panelCam21.Controls.Add(this.pBar21);
            this.panelCam21.Controls.Add(this.lblpBc21);
            this.panelCam21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCam21.Location = new System.Drawing.Point(528, 25);
            this.panelCam21.Name = "panelCam21";
            this.panelCam21.Size = new System.Drawing.Size(47, 102);
            this.panelCam21.TabIndex = 313;
            this.panelCam21.Visible = false;
            // 
            // picPila21
            // 
            this.picPila21.BackColor = System.Drawing.Color.Transparent;
            this.picPila21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila21.Location = new System.Drawing.Point(44, 38);
            this.picPila21.Name = "picPila21";
            this.picPila21.Size = new System.Drawing.Size(12, 15);
            this.picPila21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila21.TabIndex = 354;
            this.picPila21.TabStop = false;
            // 
            // lblTablet21
            // 
            this.lblTablet21.AutoSize = true;
            this.lblTablet21.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet21.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet21.Location = new System.Drawing.Point(32, 79);
            this.lblTablet21.Name = "lblTablet21";
            this.lblTablet21.Size = new System.Drawing.Size(11, 12);
            this.lblTablet21.TabIndex = 353;
            this.lblTablet21.Text = "0";
            // 
            // picWifi21
            // 
            this.picWifi21.BackColor = System.Drawing.Color.Transparent;
            this.picWifi21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi21.Location = new System.Drawing.Point(41, 20);
            this.picWifi21.Name = "picWifi21";
            this.picWifi21.Size = new System.Drawing.Size(15, 14);
            this.picWifi21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi21.TabIndex = 349;
            this.picWifi21.TabStop = false;
            // 
            // picCamion21
            // 
            this.picCamion21.BackColor = System.Drawing.Color.Transparent;
            this.picCamion21.Location = new System.Drawing.Point(39, 53);
            this.picCamion21.Name = "picCamion21";
            this.picCamion21.Size = new System.Drawing.Size(13, 30);
            this.picCamion21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion21.TabIndex = 301;
            this.picCamion21.TabStop = false;
            // 
            // panelCam25
            // 
            this.panelCam25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam25.Controls.Add(this.picPila25);
            this.panelCam25.Controls.Add(this.lblTablet25);
            this.panelCam25.Controls.Add(this.picWifi25);
            this.panelCam25.Controls.Add(this.picMov25);
            this.panelCam25.Controls.Add(this.picCamion25);
            this.panelCam25.Controls.Add(this.lblCam25);
            this.panelCam25.Controls.Add(this.lblpAct25);
            this.panelCam25.Controls.Add(this.lblpBr25);
            this.panelCam25.Controls.Add(this.pBar25);
            this.panelCam25.Controls.Add(this.lblpBc25);
            this.panelCam25.Location = new System.Drawing.Point(626, 25);
            this.panelCam25.Name = "panelCam25";
            this.panelCam25.Size = new System.Drawing.Size(47, 102);
            this.panelCam25.TabIndex = 317;
            this.panelCam25.Visible = false;
            // 
            // picPila25
            // 
            this.picPila25.BackColor = System.Drawing.Color.Transparent;
            this.picPila25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila25.Location = new System.Drawing.Point(44, 32);
            this.picPila25.Name = "picPila25";
            this.picPila25.Size = new System.Drawing.Size(12, 15);
            this.picPila25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila25.TabIndex = 355;
            this.picPila25.TabStop = false;
            // 
            // lblTablet25
            // 
            this.lblTablet25.AutoSize = true;
            this.lblTablet25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet25.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet25.Location = new System.Drawing.Point(5, 37);
            this.lblTablet25.Name = "lblTablet25";
            this.lblTablet25.Size = new System.Drawing.Size(11, 12);
            this.lblTablet25.TabIndex = 354;
            this.lblTablet25.Text = "0";
            // 
            // picWifi25
            // 
            this.picWifi25.BackColor = System.Drawing.Color.Transparent;
            this.picWifi25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi25.Location = new System.Drawing.Point(39, 20);
            this.picWifi25.Name = "picWifi25";
            this.picWifi25.Size = new System.Drawing.Size(15, 14);
            this.picWifi25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi25.TabIndex = 349;
            this.picWifi25.TabStop = false;
            // 
            // picMov25
            // 
            this.picMov25.BackColor = System.Drawing.Color.Transparent;
            this.picMov25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMov25.Location = new System.Drawing.Point(44, 5);
            this.picMov25.Name = "picMov25";
            this.picMov25.Size = new System.Drawing.Size(10, 9);
            this.picMov25.TabIndex = 314;
            this.picMov25.TabStop = false;
            // 
            // picCamion25
            // 
            this.picCamion25.BackColor = System.Drawing.Color.Transparent;
            this.picCamion25.Location = new System.Drawing.Point(30, 50);
            this.picCamion25.Name = "picCamion25";
            this.picCamion25.Size = new System.Drawing.Size(21, 31);
            this.picCamion25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion25.TabIndex = 302;
            this.picCamion25.TabStop = false;
            // 
            // lblCam25
            // 
            this.lblCam25.AutoSize = true;
            this.lblCam25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCam25.Font = new System.Drawing.Font("Courier", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.lblCam25.Location = new System.Drawing.Point(10, 8);
            this.lblCam25.Name = "lblCam25";
            this.lblCam25.Size = new System.Drawing.Size(45, 30);
            this.lblCam25.TabIndex = 248;
            this.lblCam25.Text = "25";
            this.lblCam25.Click += new System.EventHandler(this.lblCam25_Click);
            // 
            // lblpAct25
            // 
            this.lblpAct25.AutoSize = true;
            this.lblpAct25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpAct25.ForeColor = System.Drawing.Color.Black;
            this.lblpAct25.Location = new System.Drawing.Point(7, 88);
            this.lblpAct25.Name = "lblpAct25";
            this.lblpAct25.Size = new System.Drawing.Size(11, 12);
            this.lblpAct25.TabIndex = 268;
            this.lblpAct25.Text = "_";
            // 
            // lblpBr25
            // 
            this.lblpBr25.AutoSize = true;
            this.lblpBr25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpBr25.ForeColor = System.Drawing.Color.Silver;
            this.lblpBr25.Location = new System.Drawing.Point(18, 79);
            this.lblpBr25.Name = "lblpBr25";
            this.lblpBr25.Size = new System.Drawing.Size(11, 12);
            this.lblpBr25.TabIndex = 251;
            this.lblpBr25.Text = "_";
            // 
            // pBar25
            // 
            this.pBar25.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBar25.Location = new System.Drawing.Point(24, 94);
            this.pBar25.Maximum = 500;
            this.pBar25.Name = "pBar25";
            this.pBar25.Size = new System.Drawing.Size(20, 3);
            this.pBar25.TabIndex = 279;
            // 
            // panelCam22
            // 
            this.panelCam22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam22.Controls.Add(this.picPila22);
            this.panelCam22.Controls.Add(this.lblTablet22);
            this.panelCam22.Controls.Add(this.picWifi22);
            this.panelCam22.Controls.Add(this.picMov22);
            this.panelCam22.Controls.Add(this.picCamion22);
            this.panelCam22.Controls.Add(this.lblCam22);
            this.panelCam22.Controls.Add(this.lblpAct22);
            this.panelCam22.Controls.Add(this.lblpBr22);
            this.panelCam22.Controls.Add(this.pBar22);
            this.panelCam22.Controls.Add(this.lblpBc22);
            this.panelCam22.Location = new System.Drawing.Point(519, 131);
            this.panelCam22.Name = "panelCam22";
            this.panelCam22.Size = new System.Drawing.Size(47, 102);
            this.panelCam22.TabIndex = 312;
            this.panelCam22.Visible = false;
            // 
            // picPila22
            // 
            this.picPila22.BackColor = System.Drawing.Color.Transparent;
            this.picPila22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila22.Location = new System.Drawing.Point(43, 40);
            this.picPila22.Name = "picPila22";
            this.picPila22.Size = new System.Drawing.Size(12, 15);
            this.picPila22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila22.TabIndex = 354;
            this.picPila22.TabStop = false;
            // 
            // lblTablet22
            // 
            this.lblTablet22.AutoSize = true;
            this.lblTablet22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet22.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet22.Location = new System.Drawing.Point(35, 80);
            this.lblTablet22.Name = "lblTablet22";
            this.lblTablet22.Size = new System.Drawing.Size(11, 12);
            this.lblTablet22.TabIndex = 353;
            this.lblTablet22.Text = "0";
            // 
            // picWifi22
            // 
            this.picWifi22.BackColor = System.Drawing.Color.Transparent;
            this.picWifi22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi22.Location = new System.Drawing.Point(44, 20);
            this.picWifi22.Name = "picWifi22";
            this.picWifi22.Size = new System.Drawing.Size(15, 14);
            this.picWifi22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi22.TabIndex = 349;
            this.picWifi22.TabStop = false;
            // 
            // picCamion22
            // 
            this.picCamion22.BackColor = System.Drawing.Color.Transparent;
            this.picCamion22.Location = new System.Drawing.Point(33, 62);
            this.picCamion22.Name = "picCamion22";
            this.picCamion22.Size = new System.Drawing.Size(18, 19);
            this.picCamion22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion22.TabIndex = 302;
            this.picCamion22.TabStop = false;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(212, 692);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(39, 13);
            this.label38.TabIndex = 311;
            this.label38.Text = "FALLA";
            this.label38.Visible = false;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(203, 661);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(48, 13);
            this.label37.TabIndex = 309;
            this.label37.Text = "TALLER";
            this.label37.Visible = false;
            // 
            // panelCam18
            // 
            this.panelCam18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam18.Controls.Add(this.picPila18);
            this.panelCam18.Controls.Add(this.lblTablet18);
            this.panelCam18.Controls.Add(this.picWifi18);
            this.panelCam18.Controls.Add(this.picCamion18);
            this.panelCam18.Controls.Add(this.lblCam18);
            this.panelCam18.Controls.Add(this.lblpBc18);
            this.panelCam18.Controls.Add(this.lblpBr18);
            this.panelCam18.Controls.Add(this.picMov18);
            this.panelCam18.Controls.Add(this.pBar18);
            this.panelCam18.Controls.Add(this.lblpAct18);
            this.panelCam18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCam18.Location = new System.Drawing.Point(420, 131);
            this.panelCam18.Name = "panelCam18";
            this.panelCam18.Size = new System.Drawing.Size(47, 102);
            this.panelCam18.TabIndex = 300;
            this.panelCam18.Visible = false;
            // 
            // picPila18
            // 
            this.picPila18.BackColor = System.Drawing.Color.Transparent;
            this.picPila18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila18.Location = new System.Drawing.Point(43, 40);
            this.picPila18.Name = "picPila18";
            this.picPila18.Size = new System.Drawing.Size(12, 15);
            this.picPila18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila18.TabIndex = 352;
            this.picPila18.TabStop = false;
            // 
            // lblTablet18
            // 
            this.lblTablet18.AutoSize = true;
            this.lblTablet18.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet18.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet18.Location = new System.Drawing.Point(41, 86);
            this.lblTablet18.Name = "lblTablet18";
            this.lblTablet18.Size = new System.Drawing.Size(11, 12);
            this.lblTablet18.TabIndex = 351;
            this.lblTablet18.Text = "0";
            // 
            // picWifi18
            // 
            this.picWifi18.BackColor = System.Drawing.Color.Transparent;
            this.picWifi18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi18.Location = new System.Drawing.Point(40, 26);
            this.picWifi18.Name = "picWifi18";
            this.picWifi18.Size = new System.Drawing.Size(15, 14);
            this.picWifi18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi18.TabIndex = 349;
            this.picWifi18.TabStop = false;
            // 
            // picCamion18
            // 
            this.picCamion18.BackColor = System.Drawing.Color.Transparent;
            this.picCamion18.Location = new System.Drawing.Point(24, 56);
            this.picCamion18.Name = "picCamion18";
            this.picCamion18.Size = new System.Drawing.Size(27, 27);
            this.picCamion18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion18.TabIndex = 300;
            this.picCamion18.TabStop = false;
            // 
            // panelCam04
            // 
            this.panelCam04.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCam04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam04.Controls.Add(this.picPila04);
            this.panelCam04.Controls.Add(this.lblTablet04);
            this.panelCam04.Controls.Add(this.picWifi04);
            this.panelCam04.Controls.Add(this.picCamion04);
            this.panelCam04.Controls.Add(this.lblCam04);
            this.panelCam04.Controls.Add(this.lblpBc04);
            this.panelCam04.Controls.Add(this.lblpBr04);
            this.panelCam04.Controls.Add(this.picMov04);
            this.panelCam04.Controls.Add(this.pBar04);
            this.panelCam04.Controls.Add(this.lblpAct04);
            this.panelCam04.Location = new System.Drawing.Point(72, 131);
            this.panelCam04.Name = "panelCam04";
            this.panelCam04.Size = new System.Drawing.Size(47, 102);
            this.panelCam04.TabIndex = 306;
            this.panelCam04.Visible = false;
            // 
            // picPila04
            // 
            this.picPila04.BackColor = System.Drawing.Color.Transparent;
            this.picPila04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila04.Location = new System.Drawing.Point(43, 40);
            this.picPila04.Name = "picPila04";
            this.picPila04.Size = new System.Drawing.Size(12, 15);
            this.picPila04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila04.TabIndex = 354;
            this.picPila04.TabStop = false;
            // 
            // lblTablet04
            // 
            this.lblTablet04.AutoSize = true;
            this.lblTablet04.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet04.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet04.Location = new System.Drawing.Point(43, 87);
            this.lblTablet04.Name = "lblTablet04";
            this.lblTablet04.Size = new System.Drawing.Size(11, 12);
            this.lblTablet04.TabIndex = 353;
            this.lblTablet04.Text = "0";
            // 
            // picWifi04
            // 
            this.picWifi04.BackColor = System.Drawing.Color.Transparent;
            this.picWifi04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi04.Location = new System.Drawing.Point(39, 21);
            this.picWifi04.Name = "picWifi04";
            this.picWifi04.Size = new System.Drawing.Size(15, 14);
            this.picWifi04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi04.TabIndex = 348;
            this.picWifi04.TabStop = false;
            // 
            // picCamion04
            // 
            this.picCamion04.BackColor = System.Drawing.Color.Transparent;
            this.picCamion04.Location = new System.Drawing.Point(4, 43);
            this.picCamion04.Name = "picCamion04";
            this.picCamion04.Size = new System.Drawing.Size(40, 46);
            this.picCamion04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion04.TabIndex = 301;
            this.picCamion04.TabStop = false;
            // 
            // panelCam19
            // 
            this.panelCam19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam19.Controls.Add(this.picPila19);
            this.panelCam19.Controls.Add(this.lblTablet19);
            this.panelCam19.Controls.Add(this.picWifi19);
            this.panelCam19.Controls.Add(this.picCamion19);
            this.panelCam19.Controls.Add(this.lblCam19);
            this.panelCam19.Controls.Add(this.lblpBc19);
            this.panelCam19.Controls.Add(this.lblpBr19);
            this.panelCam19.Controls.Add(this.picMov19);
            this.panelCam19.Controls.Add(this.pBar19);
            this.panelCam19.Controls.Add(this.lblpAct19);
            this.panelCam19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCam19.Location = new System.Drawing.Point(478, 25);
            this.panelCam19.Name = "panelCam19";
            this.panelCam19.Size = new System.Drawing.Size(47, 102);
            this.panelCam19.TabIndex = 299;
            this.panelCam19.Visible = false;
            // 
            // picPila19
            // 
            this.picPila19.BackColor = System.Drawing.Color.Transparent;
            this.picPila19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila19.Location = new System.Drawing.Point(44, 40);
            this.picPila19.Name = "picPila19";
            this.picPila19.Size = new System.Drawing.Size(12, 15);
            this.picPila19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila19.TabIndex = 352;
            this.picPila19.TabStop = false;
            // 
            // lblTablet19
            // 
            this.lblTablet19.AutoSize = true;
            this.lblTablet19.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet19.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet19.Location = new System.Drawing.Point(40, 88);
            this.lblTablet19.Name = "lblTablet19";
            this.lblTablet19.Size = new System.Drawing.Size(11, 12);
            this.lblTablet19.TabIndex = 351;
            this.lblTablet19.Text = "0";
            // 
            // picWifi19
            // 
            this.picWifi19.BackColor = System.Drawing.Color.Transparent;
            this.picWifi19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi19.Location = new System.Drawing.Point(39, 23);
            this.picWifi19.Name = "picWifi19";
            this.picWifi19.Size = new System.Drawing.Size(15, 14);
            this.picWifi19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi19.TabIndex = 349;
            this.picWifi19.TabStop = false;
            // 
            // picCamion19
            // 
            this.picCamion19.BackColor = System.Drawing.Color.Transparent;
            this.picCamion19.Location = new System.Drawing.Point(26, 62);
            this.picCamion19.Name = "picCamion19";
            this.picCamion19.Size = new System.Drawing.Size(25, 21);
            this.picCamion19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion19.TabIndex = 301;
            this.picCamion19.TabStop = false;
            // 
            // panelCam20
            // 
            this.panelCam20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam20.Controls.Add(this.picPila20);
            this.panelCam20.Controls.Add(this.lblTablet20);
            this.panelCam20.Controls.Add(this.picWifi20);
            this.panelCam20.Controls.Add(this.picCamion20);
            this.panelCam20.Controls.Add(this.lblCam20);
            this.panelCam20.Controls.Add(this.lblpBc20);
            this.panelCam20.Controls.Add(this.lblpBr20);
            this.panelCam20.Controls.Add(this.picMov20);
            this.panelCam20.Controls.Add(this.pBar20);
            this.panelCam20.Controls.Add(this.lblpAct20);
            this.panelCam20.Location = new System.Drawing.Point(469, 131);
            this.panelCam20.Name = "panelCam20";
            this.panelCam20.Size = new System.Drawing.Size(47, 102);
            this.panelCam20.TabIndex = 298;
            this.panelCam20.Visible = false;
            // 
            // picPila20
            // 
            this.picPila20.BackColor = System.Drawing.Color.Transparent;
            this.picPila20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila20.Location = new System.Drawing.Point(43, 46);
            this.picPila20.Name = "picPila20";
            this.picPila20.Size = new System.Drawing.Size(12, 15);
            this.picPila20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila20.TabIndex = 351;
            this.picPila20.TabStop = false;
            // 
            // lblTablet20
            // 
            this.lblTablet20.AutoSize = true;
            this.lblTablet20.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet20.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet20.Location = new System.Drawing.Point(36, 86);
            this.lblTablet20.Name = "lblTablet20";
            this.lblTablet20.Size = new System.Drawing.Size(11, 12);
            this.lblTablet20.TabIndex = 350;
            this.lblTablet20.Text = "0";
            // 
            // picWifi20
            // 
            this.picWifi20.BackColor = System.Drawing.Color.Transparent;
            this.picWifi20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi20.Location = new System.Drawing.Point(40, 24);
            this.picWifi20.Name = "picWifi20";
            this.picWifi20.Size = new System.Drawing.Size(15, 14);
            this.picWifi20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi20.TabIndex = 349;
            this.picWifi20.TabStop = false;
            // 
            // picCamion20
            // 
            this.picCamion20.BackColor = System.Drawing.Color.Transparent;
            this.picCamion20.Location = new System.Drawing.Point(25, 66);
            this.picCamion20.Name = "picCamion20";
            this.picCamion20.Size = new System.Drawing.Size(27, 21);
            this.picCamion20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion20.TabIndex = 302;
            this.picCamion20.TabStop = false;
            // 
            // panelCam08
            // 
            this.panelCam08.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCam08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam08.Controls.Add(this.picPila08);
            this.panelCam08.Controls.Add(this.lblTablet08);
            this.panelCam08.Controls.Add(this.picWifi08);
            this.panelCam08.Controls.Add(this.picCamion08);
            this.panelCam08.Controls.Add(this.lblCam08);
            this.panelCam08.Controls.Add(this.lblpBc08);
            this.panelCam08.Controls.Add(this.lblpBr08);
            this.panelCam08.Controls.Add(this.picMov08);
            this.panelCam08.Controls.Add(this.pBar08);
            this.panelCam08.Controls.Add(this.lblpAct08);
            this.panelCam08.Location = new System.Drawing.Point(173, 131);
            this.panelCam08.Name = "panelCam08";
            this.panelCam08.Size = new System.Drawing.Size(47, 102);
            this.panelCam08.TabIndex = 302;
            this.panelCam08.Visible = false;
            // 
            // picPila08
            // 
            this.picPila08.BackColor = System.Drawing.Color.Transparent;
            this.picPila08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila08.Location = new System.Drawing.Point(43, 40);
            this.picPila08.Name = "picPila08";
            this.picPila08.Size = new System.Drawing.Size(12, 15);
            this.picPila08.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila08.TabIndex = 354;
            this.picPila08.TabStop = false;
            // 
            // lblTablet08
            // 
            this.lblTablet08.AutoSize = true;
            this.lblTablet08.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet08.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet08.Location = new System.Drawing.Point(39, 87);
            this.lblTablet08.Name = "lblTablet08";
            this.lblTablet08.Size = new System.Drawing.Size(11, 12);
            this.lblTablet08.TabIndex = 353;
            this.lblTablet08.Text = "0";
            // 
            // picWifi08
            // 
            this.picWifi08.BackColor = System.Drawing.Color.Transparent;
            this.picWifi08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi08.Location = new System.Drawing.Point(39, 20);
            this.picWifi08.Name = "picWifi08";
            this.picWifi08.Size = new System.Drawing.Size(15, 14);
            this.picWifi08.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi08.TabIndex = 349;
            this.picWifi08.TabStop = false;
            // 
            // picCamion08
            // 
            this.picCamion08.BackColor = System.Drawing.Color.Transparent;
            this.picCamion08.Location = new System.Drawing.Point(4, 41);
            this.picCamion08.Name = "picCamion08";
            this.picCamion08.Size = new System.Drawing.Size(40, 46);
            this.picCamion08.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion08.TabIndex = 300;
            this.picCamion08.TabStop = false;
            // 
            // panelCam01
            // 
            this.panelCam01.Controls.Add(this.lblpBc01);
            this.panelCam01.Controls.Add(this.picCamion01);
            this.panelCam01.Controls.Add(this.lblpBr01);
            this.panelCam01.Controls.Add(this.lblTablet01);
            this.panelCam01.Controls.Add(this.lblCam01);
            this.panelCam01.Controls.Add(this.picPila01);
            this.panelCam01.Controls.Add(this.picWifi01);
            this.panelCam01.Controls.Add(this.picMov01);
            this.panelCam01.Controls.Add(this.pBar01);
            this.panelCam01.Controls.Add(this.lblpAct01);
            this.panelCam01.Location = new System.Drawing.Point(21, 27);
            this.panelCam01.Name = "panelCam01";
            this.panelCam01.Size = new System.Drawing.Size(47, 35);
            this.panelCam01.TabIndex = 308;
            this.panelCam01.Visible = false;
            // 
            // picCamion01
            // 
            this.picCamion01.BackColor = System.Drawing.Color.Transparent;
            this.picCamion01.Location = new System.Drawing.Point(7, 46);
            this.picCamion01.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.picCamion01.Name = "picCamion01";
            this.picCamion01.Size = new System.Drawing.Size(31, 0);
            this.picCamion01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion01.TabIndex = 298;
            this.picCamion01.TabStop = false;
            // 
            // lblTablet01
            // 
            this.lblTablet01.BackColor = System.Drawing.Color.Transparent;
            this.lblTablet01.Font = new System.Drawing.Font("Courier", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet01.ForeColor = System.Drawing.Color.White;
            this.lblTablet01.Location = new System.Drawing.Point(20, 50);
            this.lblTablet01.Name = "lblTablet01";
            this.lblTablet01.Size = new System.Drawing.Size(26, 10);
            this.lblTablet01.TabIndex = 299;
            this.lblTablet01.Text = "000";
            this.lblTablet01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPila01
            // 
            this.picPila01.BackColor = System.Drawing.Color.Transparent;
            this.picPila01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila01.Location = new System.Drawing.Point(9, 38);
            this.picPila01.Name = "picPila01";
            this.picPila01.Size = new System.Drawing.Size(27, 22);
            this.picPila01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila01.TabIndex = 348;
            this.picPila01.TabStop = false;
            // 
            // picWifi01
            // 
            this.picWifi01.BackColor = System.Drawing.Color.Transparent;
            this.picWifi01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi01.Location = new System.Drawing.Point(19, 37);
            this.picWifi01.Name = "picWifi01";
            this.picWifi01.Size = new System.Drawing.Size(19, 19);
            this.picWifi01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi01.TabIndex = 347;
            this.picWifi01.TabStop = false;
            // 
            // panelCam02
            // 
            this.panelCam02.BackColor = System.Drawing.Color.Transparent;
            this.panelCam02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam02.Controls.Add(this.picCamion02);
            this.panelCam02.Controls.Add(this.lblTablet02);
            this.panelCam02.Controls.Add(this.lblCam02);
            this.panelCam02.Controls.Add(this.picPila02);
            this.panelCam02.Controls.Add(this.picWifi02);
            this.panelCam02.Controls.Add(this.lblpBc02);
            this.panelCam02.Controls.Add(this.lblpBr02);
            this.panelCam02.Controls.Add(this.picMov02);
            this.panelCam02.Controls.Add(this.pBar02);
            this.panelCam02.Controls.Add(this.lblpAct02);
            this.panelCam02.Location = new System.Drawing.Point(21, 131);
            this.panelCam02.Name = "panelCam02";
            this.panelCam02.Size = new System.Drawing.Size(47, 102);
            this.panelCam02.TabIndex = 307;
            this.panelCam02.Visible = false;
            // 
            // picCamion02
            // 
            this.picCamion02.BackColor = System.Drawing.Color.Transparent;
            this.picCamion02.Location = new System.Drawing.Point(3, 45);
            this.picCamion02.Name = "picCamion02";
            this.picCamion02.Size = new System.Drawing.Size(37, 42);
            this.picCamion02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion02.TabIndex = 299;
            this.picCamion02.TabStop = false;
            // 
            // lblTablet02
            // 
            this.lblTablet02.AutoSize = true;
            this.lblTablet02.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet02.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet02.Location = new System.Drawing.Point(11, 8);
            this.lblTablet02.Name = "lblTablet02";
            this.lblTablet02.Size = new System.Drawing.Size(11, 12);
            this.lblTablet02.TabIndex = 353;
            this.lblTablet02.Text = "0";
            // 
            // picPila02
            // 
            this.picPila02.BackColor = System.Drawing.Color.Transparent;
            this.picPila02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila02.Location = new System.Drawing.Point(41, 40);
            this.picPila02.Name = "picPila02";
            this.picPila02.Size = new System.Drawing.Size(12, 15);
            this.picPila02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila02.TabIndex = 354;
            this.picPila02.TabStop = false;
            // 
            // picWifi02
            // 
            this.picWifi02.BackColor = System.Drawing.Color.Transparent;
            this.picWifi02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi02.Location = new System.Drawing.Point(41, 21);
            this.picWifi02.Name = "picWifi02";
            this.picWifi02.Size = new System.Drawing.Size(15, 14);
            this.picWifi02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi02.TabIndex = 348;
            this.picWifi02.TabStop = false;
            // 
            // panelCam12
            // 
            this.panelCam12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam12.Controls.Add(this.lblTablet12);
            this.panelCam12.Controls.Add(this.lblCam12);
            this.panelCam12.Controls.Add(this.picPila12);
            this.panelCam12.Controls.Add(this.picWifi12);
            this.panelCam12.Controls.Add(this.picCamion12);
            this.panelCam12.Controls.Add(this.lblpBc12);
            this.panelCam12.Controls.Add(this.lblpBr12);
            this.panelCam12.Controls.Add(this.picMov12);
            this.panelCam12.Controls.Add(this.pBar12);
            this.panelCam12.Controls.Add(this.lblpAct12);
            this.panelCam12.Location = new System.Drawing.Point(271, 131);
            this.panelCam12.Name = "panelCam12";
            this.panelCam12.Size = new System.Drawing.Size(47, 102);
            this.panelCam12.TabIndex = 299;
            this.panelCam12.Visible = false;
            // 
            // lblTablet12
            // 
            this.lblTablet12.AutoSize = true;
            this.lblTablet12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet12.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet12.Location = new System.Drawing.Point(12, 4);
            this.lblTablet12.Name = "lblTablet12";
            this.lblTablet12.Size = new System.Drawing.Size(11, 12);
            this.lblTablet12.TabIndex = 353;
            this.lblTablet12.Text = "0";
            // 
            // picPila12
            // 
            this.picPila12.BackColor = System.Drawing.Color.Transparent;
            this.picPila12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila12.Location = new System.Drawing.Point(45, 42);
            this.picPila12.Name = "picPila12";
            this.picPila12.Size = new System.Drawing.Size(12, 15);
            this.picPila12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila12.TabIndex = 354;
            this.picPila12.TabStop = false;
            // 
            // picWifi12
            // 
            this.picWifi12.BackColor = System.Drawing.Color.Transparent;
            this.picWifi12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi12.Location = new System.Drawing.Point(37, 23);
            this.picWifi12.Name = "picWifi12";
            this.picWifi12.Size = new System.Drawing.Size(15, 14);
            this.picWifi12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi12.TabIndex = 349;
            this.picWifi12.TabStop = false;
            // 
            // picCamion12
            // 
            this.picCamion12.BackColor = System.Drawing.Color.Transparent;
            this.picCamion12.Location = new System.Drawing.Point(4, 40);
            this.picCamion12.Name = "picCamion12";
            this.picCamion12.Size = new System.Drawing.Size(42, 45);
            this.picCamion12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion12.TabIndex = 301;
            this.picCamion12.TabStop = false;
            // 
            // panelCam03
            // 
            this.panelCam03.BackColor = System.Drawing.Color.Transparent;
            this.panelCam03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam03.Controls.Add(this.picPila03);
            this.panelCam03.Controls.Add(this.lblTablet03);
            this.panelCam03.Controls.Add(this.picWifi03);
            this.panelCam03.Controls.Add(this.picCamion03);
            this.panelCam03.Controls.Add(this.lblCam03);
            this.panelCam03.Controls.Add(this.lblpBc03);
            this.panelCam03.Controls.Add(this.lblpBr03);
            this.panelCam03.Controls.Add(this.picMov03);
            this.panelCam03.Controls.Add(this.pBar03);
            this.panelCam03.Controls.Add(this.lblpAct03);
            this.panelCam03.Location = new System.Drawing.Point(72, 25);
            this.panelCam03.Name = "panelCam03";
            this.panelCam03.Size = new System.Drawing.Size(47, 102);
            this.panelCam03.TabIndex = 305;
            this.panelCam03.Visible = false;
            // 
            // picPila03
            // 
            this.picPila03.BackColor = System.Drawing.Color.Transparent;
            this.picPila03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila03.Location = new System.Drawing.Point(41, 38);
            this.picPila03.Name = "picPila03";
            this.picPila03.Size = new System.Drawing.Size(12, 15);
            this.picPila03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila03.TabIndex = 354;
            this.picPila03.TabStop = false;
            // 
            // lblTablet03
            // 
            this.lblTablet03.AutoSize = true;
            this.lblTablet03.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet03.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet03.Location = new System.Drawing.Point(41, 83);
            this.lblTablet03.Name = "lblTablet03";
            this.lblTablet03.Size = new System.Drawing.Size(11, 12);
            this.lblTablet03.TabIndex = 353;
            this.lblTablet03.Text = "0";
            // 
            // picWifi03
            // 
            this.picWifi03.BackColor = System.Drawing.Color.Transparent;
            this.picWifi03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi03.Location = new System.Drawing.Point(39, 18);
            this.picWifi03.Name = "picWifi03";
            this.picWifi03.Size = new System.Drawing.Size(15, 14);
            this.picWifi03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi03.TabIndex = 348;
            this.picWifi03.TabStop = false;
            // 
            // picCamion03
            // 
            this.picCamion03.BackColor = System.Drawing.Color.Transparent;
            this.picCamion03.Location = new System.Drawing.Point(3, 43);
            this.picCamion03.Name = "picCamion03";
            this.picCamion03.Size = new System.Drawing.Size(40, 46);
            this.picCamion03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion03.TabIndex = 300;
            this.picCamion03.TabStop = false;
            // 
            // panelCam05
            // 
            this.panelCam05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam05.Controls.Add(this.picPila05);
            this.panelCam05.Controls.Add(this.lblTablet05);
            this.panelCam05.Controls.Add(this.picWifi05);
            this.panelCam05.Controls.Add(this.picCamion05);
            this.panelCam05.Controls.Add(this.lblCam05);
            this.panelCam05.Controls.Add(this.lblpBc05);
            this.panelCam05.Controls.Add(this.lblpBr05);
            this.panelCam05.Controls.Add(this.picMov05);
            this.panelCam05.Controls.Add(this.pBar05);
            this.panelCam05.Controls.Add(this.lblpAct05);
            this.panelCam05.Location = new System.Drawing.Point(123, 25);
            this.panelCam05.Name = "panelCam05";
            this.panelCam05.Size = new System.Drawing.Size(47, 102);
            this.panelCam05.TabIndex = 304;
            this.panelCam05.Visible = false;
            // 
            // picPila05
            // 
            this.picPila05.BackColor = System.Drawing.Color.Transparent;
            this.picPila05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila05.Location = new System.Drawing.Point(46, 38);
            this.picPila05.Name = "picPila05";
            this.picPila05.Size = new System.Drawing.Size(12, 15);
            this.picPila05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila05.TabIndex = 354;
            this.picPila05.TabStop = false;
            // 
            // lblTablet05
            // 
            this.lblTablet05.AutoSize = true;
            this.lblTablet05.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet05.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet05.Location = new System.Drawing.Point(37, 87);
            this.lblTablet05.Name = "lblTablet05";
            this.lblTablet05.Size = new System.Drawing.Size(11, 12);
            this.lblTablet05.TabIndex = 353;
            this.lblTablet05.Text = "0";
            // 
            // picWifi05
            // 
            this.picWifi05.BackColor = System.Drawing.Color.Transparent;
            this.picWifi05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi05.Location = new System.Drawing.Point(41, 20);
            this.picWifi05.Name = "picWifi05";
            this.picWifi05.Size = new System.Drawing.Size(15, 14);
            this.picWifi05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi05.TabIndex = 349;
            this.picWifi05.TabStop = false;
            // 
            // picCamion05
            // 
            this.picCamion05.BackColor = System.Drawing.Color.Transparent;
            this.picCamion05.Location = new System.Drawing.Point(33, 60);
            this.picCamion05.Name = "picCamion05";
            this.picCamion05.Size = new System.Drawing.Size(16, 27);
            this.picCamion05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion05.TabIndex = 299;
            this.picCamion05.TabStop = false;
            // 
            // panelCam09
            // 
            this.panelCam09.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCam09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam09.Controls.Add(this.picPila09);
            this.panelCam09.Controls.Add(this.lblTablet09);
            this.panelCam09.Controls.Add(this.picWifi09);
            this.panelCam09.Controls.Add(this.picCamion09);
            this.panelCam09.Controls.Add(this.lblCam09);
            this.panelCam09.Controls.Add(this.lblpBc09);
            this.panelCam09.Controls.Add(this.lblpBr09);
            this.panelCam09.Controls.Add(this.picMov09);
            this.panelCam09.Controls.Add(this.pBar09);
            this.panelCam09.Controls.Add(this.lblpAct09);
            this.panelCam09.Location = new System.Drawing.Point(222, 25);
            this.panelCam09.Name = "panelCam09";
            this.panelCam09.Size = new System.Drawing.Size(47, 102);
            this.panelCam09.TabIndex = 300;
            this.panelCam09.Visible = false;
            // 
            // picPila09
            // 
            this.picPila09.BackColor = System.Drawing.Color.Transparent;
            this.picPila09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila09.Location = new System.Drawing.Point(47, 32);
            this.picPila09.Name = "picPila09";
            this.picPila09.Size = new System.Drawing.Size(12, 15);
            this.picPila09.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila09.TabIndex = 354;
            this.picPila09.TabStop = false;
            // 
            // lblTablet09
            // 
            this.lblTablet09.AutoSize = true;
            this.lblTablet09.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet09.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet09.Location = new System.Drawing.Point(39, 82);
            this.lblTablet09.Name = "lblTablet09";
            this.lblTablet09.Size = new System.Drawing.Size(11, 12);
            this.lblTablet09.TabIndex = 353;
            this.lblTablet09.Text = "0";
            // 
            // picWifi09
            // 
            this.picWifi09.BackColor = System.Drawing.Color.Transparent;
            this.picWifi09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi09.Location = new System.Drawing.Point(39, 28);
            this.picWifi09.Name = "picWifi09";
            this.picWifi09.Size = new System.Drawing.Size(15, 14);
            this.picWifi09.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi09.TabIndex = 349;
            this.picWifi09.TabStop = false;
            // 
            // picCamion09
            // 
            this.picCamion09.BackColor = System.Drawing.Color.Transparent;
            this.picCamion09.Location = new System.Drawing.Point(9, 42);
            this.picCamion09.Name = "picCamion09";
            this.picCamion09.Size = new System.Drawing.Size(42, 45);
            this.picCamion09.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion09.TabIndex = 301;
            this.picCamion09.TabStop = false;
            // 
            // panelCam06
            // 
            this.panelCam06.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCam06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam06.Controls.Add(this.picPila06);
            this.panelCam06.Controls.Add(this.lblTablet06);
            this.panelCam06.Controls.Add(this.picWifi06);
            this.panelCam06.Controls.Add(this.picCamion06);
            this.panelCam06.Controls.Add(this.lblCam06);
            this.panelCam06.Controls.Add(this.lblpBc06);
            this.panelCam06.Controls.Add(this.lblpBr06);
            this.panelCam06.Controls.Add(this.picMov06);
            this.panelCam06.Controls.Add(this.pBar06);
            this.panelCam06.Controls.Add(this.lblpAct06);
            this.panelCam06.Location = new System.Drawing.Point(123, 131);
            this.panelCam06.Name = "panelCam06";
            this.panelCam06.Size = new System.Drawing.Size(47, 102);
            this.panelCam06.TabIndex = 303;
            this.panelCam06.Visible = false;
            // 
            // picPila06
            // 
            this.picPila06.BackColor = System.Drawing.Color.Transparent;
            this.picPila06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila06.Location = new System.Drawing.Point(45, 41);
            this.picPila06.Name = "picPila06";
            this.picPila06.Size = new System.Drawing.Size(12, 15);
            this.picPila06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila06.TabIndex = 354;
            this.picPila06.TabStop = false;
            // 
            // lblTablet06
            // 
            this.lblTablet06.AutoSize = true;
            this.lblTablet06.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet06.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet06.Location = new System.Drawing.Point(37, 86);
            this.lblTablet06.Name = "lblTablet06";
            this.lblTablet06.Size = new System.Drawing.Size(11, 12);
            this.lblTablet06.TabIndex = 353;
            this.lblTablet06.Text = "0";
            // 
            // picWifi06
            // 
            this.picWifi06.BackColor = System.Drawing.Color.Transparent;
            this.picWifi06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi06.Location = new System.Drawing.Point(35, 28);
            this.picWifi06.Name = "picWifi06";
            this.picWifi06.Size = new System.Drawing.Size(15, 14);
            this.picWifi06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi06.TabIndex = 349;
            this.picWifi06.TabStop = false;
            // 
            // picCamion06
            // 
            this.picCamion06.BackColor = System.Drawing.Color.Transparent;
            this.picCamion06.Location = new System.Drawing.Point(9, 40);
            this.picCamion06.Name = "picCamion06";
            this.picCamion06.Size = new System.Drawing.Size(40, 46);
            this.picCamion06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion06.TabIndex = 300;
            this.picCamion06.TabStop = false;
            // 
            // panelCam07
            // 
            this.panelCam07.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCam07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam07.Controls.Add(this.picPila07);
            this.panelCam07.Controls.Add(this.lblTablet07);
            this.panelCam07.Controls.Add(this.picWifi07);
            this.panelCam07.Controls.Add(this.picCamion07);
            this.panelCam07.Controls.Add(this.lblCam07);
            this.panelCam07.Controls.Add(this.lblpBc07);
            this.panelCam07.Controls.Add(this.lblpBr07);
            this.panelCam07.Controls.Add(this.picMov07);
            this.panelCam07.Controls.Add(this.pBar07);
            this.panelCam07.Controls.Add(this.lblpAct07);
            this.panelCam07.Location = new System.Drawing.Point(173, 25);
            this.panelCam07.Name = "panelCam07";
            this.panelCam07.Size = new System.Drawing.Size(47, 102);
            this.panelCam07.TabIndex = 301;
            this.panelCam07.Visible = false;
            this.panelCam07.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCam07_Paint);
            // 
            // picPila07
            // 
            this.picPila07.BackColor = System.Drawing.Color.Transparent;
            this.picPila07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila07.Location = new System.Drawing.Point(43, 44);
            this.picPila07.Name = "picPila07";
            this.picPila07.Size = new System.Drawing.Size(12, 15);
            this.picPila07.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila07.TabIndex = 354;
            this.picPila07.TabStop = false;
            // 
            // lblTablet07
            // 
            this.lblTablet07.AutoSize = true;
            this.lblTablet07.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet07.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet07.Location = new System.Drawing.Point(37, 85);
            this.lblTablet07.Name = "lblTablet07";
            this.lblTablet07.Size = new System.Drawing.Size(11, 12);
            this.lblTablet07.TabIndex = 353;
            this.lblTablet07.Text = "0";
            // 
            // picWifi07
            // 
            this.picWifi07.BackColor = System.Drawing.Color.Transparent;
            this.picWifi07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi07.Location = new System.Drawing.Point(39, 28);
            this.picWifi07.Name = "picWifi07";
            this.picWifi07.Size = new System.Drawing.Size(15, 14);
            this.picWifi07.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi07.TabIndex = 349;
            this.picWifi07.TabStop = false;
            // 
            // picCamion07
            // 
            this.picCamion07.BackColor = System.Drawing.Color.Transparent;
            this.picCamion07.Location = new System.Drawing.Point(7, 40);
            this.picCamion07.Name = "picCamion07";
            this.picCamion07.Size = new System.Drawing.Size(40, 46);
            this.picCamion07.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion07.TabIndex = 299;
            this.picCamion07.TabStop = false;
            // 
            // panelCam13
            // 
            this.panelCam13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam13.Controls.Add(this.picCamion13);
            this.panelCam13.Controls.Add(this.picPila13);
            this.panelCam13.Controls.Add(this.lblTablet13);
            this.panelCam13.Controls.Add(this.picWifi13);
            this.panelCam13.Controls.Add(this.lblCam13);
            this.panelCam13.Controls.Add(this.lblpBc13);
            this.panelCam13.Controls.Add(this.lblpBr13);
            this.panelCam13.Controls.Add(this.picMov13);
            this.panelCam13.Controls.Add(this.pBar13);
            this.panelCam13.Controls.Add(this.lblpAct13);
            this.panelCam13.Location = new System.Drawing.Point(330, 25);
            this.panelCam13.Name = "panelCam13";
            this.panelCam13.Size = new System.Drawing.Size(47, 102);
            this.panelCam13.TabIndex = 297;
            this.panelCam13.Visible = false;
            // 
            // picCamion13
            // 
            this.picCamion13.BackColor = System.Drawing.Color.Transparent;
            this.picCamion13.Location = new System.Drawing.Point(4, 56);
            this.picCamion13.Name = "picCamion13";
            this.picCamion13.Size = new System.Drawing.Size(30, 18);
            this.picCamion13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion13.TabIndex = 299;
            this.picCamion13.TabStop = false;
            // 
            // picPila13
            // 
            this.picPila13.BackColor = System.Drawing.Color.Transparent;
            this.picPila13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila13.Location = new System.Drawing.Point(43, 42);
            this.picPila13.Name = "picPila13";
            this.picPila13.Size = new System.Drawing.Size(12, 15);
            this.picPila13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila13.TabIndex = 354;
            this.picPila13.TabStop = false;
            // 
            // lblTablet13
            // 
            this.lblTablet13.AutoSize = true;
            this.lblTablet13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet13.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet13.Location = new System.Drawing.Point(41, 85);
            this.lblTablet13.Name = "lblTablet13";
            this.lblTablet13.Size = new System.Drawing.Size(11, 12);
            this.lblTablet13.TabIndex = 353;
            this.lblTablet13.Text = "0";
            // 
            // picWifi13
            // 
            this.picWifi13.BackColor = System.Drawing.Color.Transparent;
            this.picWifi13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi13.Location = new System.Drawing.Point(36, 27);
            this.picWifi13.Name = "picWifi13";
            this.picWifi13.Size = new System.Drawing.Size(15, 14);
            this.picWifi13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi13.TabIndex = 349;
            this.picWifi13.TabStop = false;
            // 
            // panelCam10
            // 
            this.panelCam10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam10.Controls.Add(this.picPila10);
            this.panelCam10.Controls.Add(this.lblTablet10);
            this.panelCam10.Controls.Add(this.picWifi10);
            this.panelCam10.Controls.Add(this.picCamion10);
            this.panelCam10.Controls.Add(this.lblCam10);
            this.panelCam10.Controls.Add(this.lblpBc10);
            this.panelCam10.Controls.Add(this.lblpBr10);
            this.panelCam10.Controls.Add(this.picMov10);
            this.panelCam10.Controls.Add(this.pBar10);
            this.panelCam10.Controls.Add(this.lblpAct10);
            this.panelCam10.Location = new System.Drawing.Point(222, 131);
            this.panelCam10.Name = "panelCam10";
            this.panelCam10.Size = new System.Drawing.Size(47, 102);
            this.panelCam10.TabIndex = 299;
            this.panelCam10.Visible = false;
            // 
            // picPila10
            // 
            this.picPila10.BackColor = System.Drawing.Color.Transparent;
            this.picPila10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila10.Location = new System.Drawing.Point(43, 42);
            this.picPila10.Name = "picPila10";
            this.picPila10.Size = new System.Drawing.Size(12, 15);
            this.picPila10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila10.TabIndex = 354;
            this.picPila10.TabStop = false;
            // 
            // lblTablet10
            // 
            this.lblTablet10.AutoSize = true;
            this.lblTablet10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet10.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet10.Location = new System.Drawing.Point(38, 87);
            this.lblTablet10.Name = "lblTablet10";
            this.lblTablet10.Size = new System.Drawing.Size(11, 12);
            this.lblTablet10.TabIndex = 353;
            this.lblTablet10.Text = "0";
            // 
            // picWifi10
            // 
            this.picWifi10.BackColor = System.Drawing.Color.Transparent;
            this.picWifi10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi10.Location = new System.Drawing.Point(37, 28);
            this.picWifi10.Name = "picWifi10";
            this.picWifi10.Size = new System.Drawing.Size(15, 14);
            this.picWifi10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi10.TabIndex = 349;
            this.picWifi10.TabStop = false;
            // 
            // picCamion10
            // 
            this.picCamion10.BackColor = System.Drawing.Color.Transparent;
            this.picCamion10.Location = new System.Drawing.Point(3, 41);
            this.picCamion10.Name = "picCamion10";
            this.picCamion10.Size = new System.Drawing.Size(42, 45);
            this.picCamion10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion10.TabIndex = 299;
            this.picCamion10.TabStop = false;
            // 
            // panelCam11
            // 
            this.panelCam11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCam11.Controls.Add(this.picPila11);
            this.panelCam11.Controls.Add(this.lblTablet11);
            this.panelCam11.Controls.Add(this.picWifi11);
            this.panelCam11.Controls.Add(this.picCamion11);
            this.panelCam11.Controls.Add(this.lblCam11);
            this.panelCam11.Controls.Add(this.lblpBc11);
            this.panelCam11.Controls.Add(this.lblpBr11);
            this.panelCam11.Controls.Add(this.picMov11);
            this.panelCam11.Controls.Add(this.pBar11);
            this.panelCam11.Controls.Add(this.lblpAct11);
            this.panelCam11.Location = new System.Drawing.Point(271, 25);
            this.panelCam11.Name = "panelCam11";
            this.panelCam11.Size = new System.Drawing.Size(47, 102);
            this.panelCam11.TabIndex = 298;
            this.panelCam11.Visible = false;
            // 
            // picPila11
            // 
            this.picPila11.BackColor = System.Drawing.Color.Transparent;
            this.picPila11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPila11.Location = new System.Drawing.Point(45, 40);
            this.picPila11.Name = "picPila11";
            this.picPila11.Size = new System.Drawing.Size(12, 15);
            this.picPila11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila11.TabIndex = 354;
            this.picPila11.TabStop = false;
            // 
            // lblTablet11
            // 
            this.lblTablet11.AutoSize = true;
            this.lblTablet11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablet11.ForeColor = System.Drawing.Color.Silver;
            this.lblTablet11.Location = new System.Drawing.Point(37, 85);
            this.lblTablet11.Name = "lblTablet11";
            this.lblTablet11.Size = new System.Drawing.Size(11, 12);
            this.lblTablet11.TabIndex = 353;
            this.lblTablet11.Text = "0";
            // 
            // picWifi11
            // 
            this.picWifi11.BackColor = System.Drawing.Color.Transparent;
            this.picWifi11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWifi11.Location = new System.Drawing.Point(34, 26);
            this.picWifi11.Name = "picWifi11";
            this.picWifi11.Size = new System.Drawing.Size(15, 14);
            this.picWifi11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi11.TabIndex = 349;
            this.picWifi11.TabStop = false;
            // 
            // picCamion11
            // 
            this.picCamion11.BackColor = System.Drawing.Color.Transparent;
            this.picCamion11.Location = new System.Drawing.Point(7, 39);
            this.picCamion11.Name = "picCamion11";
            this.picCamion11.Size = new System.Drawing.Size(42, 45);
            this.picCamion11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamion11.TabIndex = 300;
            this.picCamion11.TabStop = false;
            // 
            // panelReloj
            // 
            this.panelReloj.Location = new System.Drawing.Point(35, 377);
            this.panelReloj.Name = "panelReloj";
            this.panelReloj.Size = new System.Drawing.Size(48, 54);
            this.panelReloj.TabIndex = 375;
            this.panelReloj.Visible = false;
            this.panelReloj.Click += new System.EventHandler(this.panelReloj_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox8.Location = new System.Drawing.Point(13, 112);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(19, 11);
            this.pictureBox8.TabIndex = 312;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // imageListCamiones
            // 
            this.imageListCamiones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCamiones.ImageStream")));
            this.imageListCamiones.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCamiones.Images.SetKeyName(0, "truck_gris.png");
            this.imageListCamiones.Images.SetKeyName(1, "spinner-100.png");
            this.imageListCamiones.Images.SetKeyName(2, "mov-circle-100.png");
            this.imageListCamiones.Images.SetKeyName(3, "stop.png");
            this.imageListCamiones.Images.SetKeyName(4, "vacio.png");
            this.imageListCamiones.Images.SetKeyName(5, "icons8-nada-96.png");
            // 
            // imageListSignal
            // 
            this.imageListSignal.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSignal.ImageStream")));
            this.imageListSignal.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSignal.Images.SetKeyName(0, "spinner-100.png");
            this.imageListSignal.Images.SetKeyName(1, "signal_gris.png");
            this.imageListSignal.Images.SetKeyName(2, "signal_ azul.png");
            this.imageListSignal.Images.SetKeyName(3, "signal_negro.png");
            this.imageListSignal.Images.SetKeyName(4, "signal_rojo.png");
            this.imageListSignal.Images.SetKeyName(5, "signal_verde.png");
            this.imageListSignal.Images.SetKeyName(6, "signal_naranja.png");
            // 
            // imageListMov
            // 
            this.imageListMov.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMov.ImageStream")));
            this.imageListMov.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMov.Images.SetKeyName(0, "avanzar.png");
            this.imageListMov.Images.SetKeyName(1, "pausa.png");
            // 
            // imageListEstado
            // 
            this.imageListEstado.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListEstado.ImageStream")));
            this.imageListEstado.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListEstado.Images.SetKeyName(0, "icons8-tools-100.png");
            this.imageListEstado.Images.SetKeyName(1, "icons8-engine-96 (1).png");
            this.imageListEstado.Images.SetKeyName(2, "icons8-engine-96.png");
            this.imageListEstado.Images.SetKeyName(3, "tools-100.png");
            this.imageListEstado.Images.SetKeyName(4, "icons8-tools-94.png");
            // 
            // imageListWifi
            // 
            this.imageListWifi.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListWifi.ImageStream")));
            this.imageListWifi.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListWifi.Images.SetKeyName(0, "wifi-100.png");
            this.imageListWifi.Images.SetKeyName(1, "data-transfers-100.png");
            this.imageListWifi.Images.SetKeyName(2, "icons8-disconnect-100.png");
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(24, 30);
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(24, 30);
            this.toolStripButton13.Text = "toolStripButton13";
            this.toolStripButton13.ToolTipText = "Compass";
            this.toolStripButton13.Click += new System.EventHandler(this.toolStripButton13_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(63, 30);
            this.toolStripButton5.Text = "Capas";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click_1);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satelitalToolStripMenuItem,
            this.toolStripMenuItem1,
            this.relieveToolStripMenuItem});
            this.toolStripSplitButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(84, 30);
            this.toolStripSplitButton1.Text = "Satelital";
            this.toolStripSplitButton1.ToolTipText = "Todo";
            this.toolStripSplitButton1.Visible = false;
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // satelitalToolStripMenuItem
            // 
            this.satelitalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.satelitalToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.satelitalToolStripMenuItem.Name = "satelitalToolStripMenuItem";
            this.satelitalToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.satelitalToolStripMenuItem.Text = "Satelital";
            this.satelitalToolStripMenuItem.Click += new System.EventHandler(this.satelitalToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItem1.Text = "Normal";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // relieveToolStripMenuItem
            // 
            this.relieveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.relieveToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.relieveToolStripMenuItem.Name = "relieveToolStripMenuItem";
            this.relieveToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.relieveToolStripMenuItem.Text = "Relieve";
            this.relieveToolStripMenuItem.Click += new System.EventHandler(this.relieveToolStripMenuItem_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(49, 30);
            this.toolStripLabel6.Text = "Pantalla";
            this.toolStripLabel6.Visible = false;
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todoToolStripMenuItem,
            this.corralesToolStripMenuItem,
            this.ecologicosToolStripMenuItem,
            this.empacadoraToolStripMenuItem});
            this.toolStripSplitButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(70, 30);
            this.toolStripSplitButton2.Text = "Todo";
            this.toolStripSplitButton2.ButtonClick += new System.EventHandler(this.toolStripSplitButton2_ButtonClick);
            // 
            // todoToolStripMenuItem
            // 
            this.todoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.todoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.todoToolStripMenuItem.Name = "todoToolStripMenuItem";
            this.todoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.todoToolStripMenuItem.Text = "Todo";
            this.todoToolStripMenuItem.Click += new System.EventHandler(this.todoToolStripMenuItem_Click);
            // 
            // corralesToolStripMenuItem
            // 
            this.corralesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.corralesToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.corralesToolStripMenuItem.Name = "corralesToolStripMenuItem";
            this.corralesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.corralesToolStripMenuItem.Text = "Clasicos";
            this.corralesToolStripMenuItem.Click += new System.EventHandler(this.corralesToolStripMenuItem_Click);
            // 
            // ecologicosToolStripMenuItem
            // 
            this.ecologicosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.ecologicosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ecologicosToolStripMenuItem.Name = "ecologicosToolStripMenuItem";
            this.ecologicosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ecologicosToolStripMenuItem.Text = "Ecologicos";
            this.ecologicosToolStripMenuItem.Click += new System.EventHandler(this.ecologicosToolStripMenuItem_Click);
            // 
            // empacadoraToolStripMenuItem
            // 
            this.empacadoraToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.empacadoraToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.empacadoraToolStripMenuItem.Name = "empacadoraToolStripMenuItem";
            this.empacadoraToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.empacadoraToolStripMenuItem.Text = "Empacadora";
            this.empacadoraToolStripMenuItem.Visible = false;
            this.empacadoraToolStripMenuItem.Click += new System.EventHandler(this.empacadoraToolStripMenuItem_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(32, 30);
            this.toolStripLabel5.Text = "Vista";
            this.toolStripLabel5.Visible = false;
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servidasToolStripMenuItem,
            this.racionToolStripMenuItem,
            this.camionToolStripMenuItem,
            this.planeadoToolStripMenuItem,
            this.cabezasToolStripMenuItem,
            this.servidaToolStripMenuItem,
            this.dimensionesToolStripMenuItem});
            this.toolStripSplitButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(82, 30);
            this.toolStripSplitButton3.Text = "Servido";
            this.toolStripSplitButton3.ToolTipText = "Vista";
            this.toolStripSplitButton3.ButtonClick += new System.EventHandler(this.toolStripSplitButton3_ButtonClick);
            // 
            // servidasToolStripMenuItem
            // 
            this.servidasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.servidasToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.servidasToolStripMenuItem.Name = "servidasToolStripMenuItem";
            this.servidasToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.servidasToolStripMenuItem.Text = "Servido";
            this.servidasToolStripMenuItem.Click += new System.EventHandler(this.servidasToolStripMenuItem_Click);
            // 
            // racionToolStripMenuItem
            // 
            this.racionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.racionToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.racionToolStripMenuItem.Name = "racionToolStripMenuItem";
            this.racionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.racionToolStripMenuItem.Text = "Racion";
            this.racionToolStripMenuItem.Click += new System.EventHandler(this.racionToolStripMenuItem_Click);
            // 
            // camionToolStripMenuItem
            // 
            this.camionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.camionToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.camionToolStripMenuItem.Name = "camionToolStripMenuItem";
            this.camionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.camionToolStripMenuItem.Text = "Camion";
            this.camionToolStripMenuItem.Click += new System.EventHandler(this.camionToolStripMenuItem_Click);
            // 
            // planeadoToolStripMenuItem
            // 
            this.planeadoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.planeadoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.planeadoToolStripMenuItem.Name = "planeadoToolStripMenuItem";
            this.planeadoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.planeadoToolStripMenuItem.Text = "Planeado";
            this.planeadoToolStripMenuItem.Click += new System.EventHandler(this.planeadoToolStripMenuItem_Click);
            // 
            // cabezasToolStripMenuItem
            // 
            this.cabezasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.cabezasToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cabezasToolStripMenuItem.Name = "cabezasToolStripMenuItem";
            this.cabezasToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cabezasToolStripMenuItem.Text = "Cabezas";
            this.cabezasToolStripMenuItem.Click += new System.EventHandler(this.cabezasToolStripMenuItem_Click);
            // 
            // servidaToolStripMenuItem
            // 
            this.servidaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.servidaToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.servidaToolStripMenuItem.Name = "servidaToolStripMenuItem";
            this.servidaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.servidaToolStripMenuItem.Text = "Servida";
            this.servidaToolStripMenuItem.Click += new System.EventHandler(this.servidaToolStripMenuItem_Click);
            // 
            // dimensionesToolStripMenuItem
            // 
            this.dimensionesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.dimensionesToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dimensionesToolStripMenuItem.Name = "dimensionesToolStripMenuItem";
            this.dimensionesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.dimensionesToolStripMenuItem.Text = "Dimensiones";
            this.dimensionesToolStripMenuItem.Click += new System.EventHandler(this.dimensionesToolStripMenuItem_Click);
            // 
            // cmbFiltroVista
            // 
            this.cmbFiltroVista.BackColor = System.Drawing.Color.Black;
            this.cmbFiltroVista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroVista.ForeColor = System.Drawing.Color.White;
            this.cmbFiltroVista.Name = "cmbFiltroVista";
            this.cmbFiltroVista.Size = new System.Drawing.Size(75, 33);
            this.cmbFiltroVista.Visible = false;
            this.cmbFiltroVista.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroVista_SelectedIndexChanged);
            this.cmbFiltroVista.Click += new System.EventHandler(this.cmbFiltroVista_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(95, 30);
            this.toolStripButton1.Text = "Ubicaciones";
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.Visible = false;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // cmbColorCapas
            // 
            this.cmbColorCapas.BackColor = System.Drawing.Color.Black;
            this.cmbColorCapas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorCapas.ForeColor = System.Drawing.Color.White;
            this.cmbColorCapas.Name = "cmbColorCapas";
            this.cmbColorCapas.Size = new System.Drawing.Size(80, 33);
            this.cmbColorCapas.Visible = false;
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoyToolStripMenuItem,
            this.fechaToolStripMenuItem});
            this.toolStripSplitButton4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(45, 30);
            this.toolStripSplitButton4.Text = "Hoy";
            this.toolStripSplitButton4.ButtonClick += new System.EventHandler(this.toolStripSplitButton4_ButtonClick);
            // 
            // hoyToolStripMenuItem
            // 
            this.hoyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.hoyToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hoyToolStripMenuItem.Name = "hoyToolStripMenuItem";
            this.hoyToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.hoyToolStripMenuItem.Text = "Hoy";
            this.hoyToolStripMenuItem.Click += new System.EventHandler(this.hoyToolStripMenuItem_Click);
            // 
            // fechaToolStripMenuItem
            // 
            this.fechaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.fechaToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fechaToolStripMenuItem.Name = "fechaToolStripMenuItem";
            this.fechaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.fechaToolStripMenuItem.Text = "Fecha";
            this.fechaToolStripMenuItem.Click += new System.EventHandler(this.fechaToolStripMenuItem_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(48, 33);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(24, 30);
            this.toolStripButton10.Text = "Calendario";
            this.toolStripButton10.ToolTipText = "Calendario";
            this.toolStripButton10.Visible = false;
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(87, 30);
            this.toolStripButton3.Text = "Recorridos";
            this.toolStripButton3.Visible = false;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 30);
            this.toolStripLabel1.Text = "Corral";
            // 
            // txtBuscarUbicacion
            // 
            this.txtBuscarUbicacion.BackColor = System.Drawing.Color.Black;
            this.txtBuscarUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarUbicacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarUbicacion.ForeColor = System.Drawing.Color.White;
            this.txtBuscarUbicacion.MaxLength = 4;
            this.txtBuscarUbicacion.Name = "txtBuscarUbicacion";
            this.txtBuscarUbicacion.Size = new System.Drawing.Size(34, 33);
            this.txtBuscarUbicacion.Click += new System.EventHandler(this.txtBuscarUbicacion_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 30);
            this.toolStripButton2.Text = "Buscar Corral";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(24, 30);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(49, 30);
            this.toolStripLabel2.Text = "Camion";
            this.toolStripLabel2.Visible = false;
            // 
            // cmbCamiones
            // 
            this.cmbCamiones.BackColor = System.Drawing.Color.Black;
            this.cmbCamiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamiones.ForeColor = System.Drawing.Color.White;
            this.cmbCamiones.Name = "cmbCamiones";
            this.cmbCamiones.Size = new System.Drawing.Size(75, 33);
            this.cmbCamiones.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(62, 30);
            this.toolStripButton4.Text = "Clima";
            this.toolStripButton4.Visible = false;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // lblcmbCamionRuta
            // 
            this.lblcmbCamionRuta.Name = "lblcmbCamionRuta";
            this.lblcmbCamionRuta.Size = new System.Drawing.Size(49, 30);
            this.lblcmbCamionRuta.Text = "Camion";
            // 
            // cmbCamionRuta
            // 
            this.cmbCamionRuta.BackColor = System.Drawing.Color.Black;
            this.cmbCamionRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamionRuta.ForeColor = System.Drawing.Color.White;
            this.cmbCamionRuta.Name = "cmbCamionRuta";
            this.cmbCamionRuta.Size = new System.Drawing.Size(75, 33);
            this.cmbCamionRuta.Click += new System.EventHandler(this.cmbCamionRuta_Click);
            // 
            // btnBuscarcamionruta
            // 
            this.btnBuscarcamionruta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscarcamionruta.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarcamionruta.Image")));
            this.btnBuscarcamionruta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscarcamionruta.Name = "btnBuscarcamionruta";
            this.btnBuscarcamionruta.Size = new System.Drawing.Size(24, 30);
            this.btnBuscarcamionruta.Text = "Buscar Camion";
            this.btnBuscarcamionruta.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(24, 30);
            this.toolStripButton6.Text = "Reparto";
            this.toolStripButton6.ToolTipText = "Recorrido";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click_1);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(28, 30);
            this.toolStripLabel8.Text = "GPS";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(24, 30);
            this.toolStripButton9.Text = "Recorridos";
            this.toolStripButton9.ToolTipText = "Recorridos";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.Size = new System.Drawing.Size(24, 30);
            this.toolStripButton16.Text = "Repartos";
            this.toolStripButton16.Click += new System.EventHandler(this.toolStripButton16_Click);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(24, 30);
            this.toolStripButton12.Text = "toolStripButton12";
            this.toolStripButton12.Visible = false;
            this.toolStripButton12.Click += new System.EventHandler(this.toolStripButton12_Click);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(24, 30);
            this.toolStripButton14.Text = "toolStripButton14";
            this.toolStripButton14.ToolTipText = "Recorrido";
            this.toolStripButton14.Visible = false;
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(24, 30);
            this.toolStripButton8.Text = "Cerrar";
            this.toolStripButton8.ToolTipText = "Cerrar Rutas";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(29, 30);
            this.toolStripLabel3.Text = "Serv";
            // 
            // cmbServidas
            // 
            this.cmbServidas.BackColor = System.Drawing.Color.Black;
            this.cmbServidas.DropDownWidth = 50;
            this.cmbServidas.ForeColor = System.Drawing.Color.White;
            this.cmbServidas.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbServidas.Name = "cmbServidas";
            this.cmbServidas.Size = new System.Drawing.Size(75, 33);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(32, 30);
            this.toolStripLabel7.Text = "Cam";
            // 
            // cmbCamion
            // 
            this.cmbCamion.BackColor = System.Drawing.Color.Black;
            this.cmbCamion.ForeColor = System.Drawing.Color.White;
            this.cmbCamion.Name = "cmbCamion";
            this.cmbCamion.Size = new System.Drawing.Size(75, 23);
            this.cmbCamion.SelectedIndexChanged += new System.EventHandler(this.cmbCamion_SelectedIndexChanged);
            this.cmbCamion.Click += new System.EventHandler(this.cmbCamion_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(26, 15);
            this.toolStripLabel4.Text = "Rac";
            // 
            // cmbRaciones
            // 
            this.cmbRaciones.BackColor = System.Drawing.Color.Black;
            this.cmbRaciones.ForeColor = System.Drawing.Color.White;
            this.cmbRaciones.Name = "cmbRaciones";
            this.cmbRaciones.Size = new System.Drawing.Size(75, 23);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton15.Text = "Refrescar";
            this.toolStripButton15.Visible = false;
            this.toolStripButton15.Click += new System.EventHandler(this.toolStripButton15_Click);
            // 
            // toolStripButton20
            // 
            this.toolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton20.Image")));
            this.toolStripButton20.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton20.Name = "toolStripButton20";
            this.toolStripButton20.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton20.Text = "toolStripButton20";
            this.toolStripButton20.Visible = false;
            this.toolStripButton20.Click += new System.EventHandler(this.toolStripButton20_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton11,
            this.toolStripButton13,
            this.toolStripButton5,
            this.toolStripSplitButton1,
            this.toolStripLabel6,
            this.toolStripSplitButton2,
            this.toolStripLabel5,
            this.toolStripSplitButton3,
            this.cmbFiltroVista,
            this.toolStripButton1,
            this.cmbColorCapas,
            this.toolStripSplitButton4,
            this.txtFecha,
            this.toolStripButton10,
            this.toolStripButton3,
            this.toolStripLabel1,
            this.txtBuscarUbicacion,
            this.toolStripButton2,
            this.toolStripButton7,
            this.toolStripLabel2,
            this.cmbCamiones,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.lblcmbCamionRuta,
            this.cmbCamionRuta,
            this.btnBuscarcamionruta,
            this.toolStripSeparator15,
            this.toolStripButton6,
            this.toolStripLabel8,
            this.toolStripButton9,
            this.toolStripButton16,
            this.toolStripButton12,
            this.toolStripButton14,
            this.toolStripButton8,
            this.toolStripLabel3,
            this.cmbServidas,
            this.toolStripLabel7,
            this.cmbCamion,
            this.toolStripLabel4,
            this.cmbRaciones,
            this.toolStripButton15,
            this.toolStripButton20});
            this.toolStrip1.Location = new System.Drawing.Point(6, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(986, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.toolStrip1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 25);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1423, 32);
            this.panelMenu.TabIndex = 298;
            this.panelMenu.Visible = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label40.Location = new System.Drawing.Point(137, 88);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(102, 12);
            this.label40.TabIndex = 152;
            this.label40.Text = "GEO LOCALIZADO";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label39.Location = new System.Drawing.Point(29, 88);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(74, 12);
            this.label39.TabIndex = 151;
            this.label39.Text = "CONECTADO";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Green;
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox10.Location = new System.Drawing.Point(14, 88);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(10, 9);
            this.pictureBox10.TabIndex = 150;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Lime;
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Location = new System.Drawing.Point(125, 88);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(10, 9);
            this.pictureBox9.TabIndex = 146;
            this.pictureBox9.TabStop = false;
            // 
            // imageListPila
            // 
            this.imageListPila.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPila.ImageStream")));
            this.imageListPila.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPila.Images.SetKeyName(0, "plug-100.png");
            this.imageListPila.Images.SetKeyName(1, "icons8-battery-0 - rojo - 100.png");
            this.imageListPila.Images.SetKeyName(2, "icons8-battery-50 - rojo - 100.png");
            this.imageListPila.Images.SetKeyName(3, "icons8-battery-100 - rojo - 100.png");
            // 
            // panelDescrip
            // 
            this.panelDescrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDescrip.Controls.Add(this.label51);
            this.panelDescrip.Controls.Add(this.label40);
            this.panelDescrip.Controls.Add(this.label39);
            this.panelDescrip.Controls.Add(this.pictureBox13);
            this.panelDescrip.Controls.Add(this.pictureBox10);
            this.panelDescrip.Controls.Add(this.label49);
            this.panelDescrip.Controls.Add(this.pictureBox9);
            this.panelDescrip.Controls.Add(this.pictureBox11);
            this.panelDescrip.Controls.Add(this.label44);
            this.panelDescrip.Controls.Add(this.label45);
            this.panelDescrip.Controls.Add(this.pictureBox12);
            this.panelDescrip.Location = new System.Drawing.Point(1096, 287);
            this.panelDescrip.Margin = new System.Windows.Forms.Padding(2);
            this.panelDescrip.Name = "panelDescrip";
            this.panelDescrip.Size = new System.Drawing.Size(241, 111);
            this.panelDescrip.TabIndex = 300;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label51.Location = new System.Drawing.Point(48, 25);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(80, 12);
            this.label51.TabIndex = 157;
            this.label51.Text = "MOVIENDOSE";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(11, 14);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(35, 31);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 156;
            this.pictureBox13.TabStop = false;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label49.Location = new System.Drawing.Point(171, 26);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(61, 12);
            this.label49.TabIndex = 155;
            this.label49.Text = "DETENIDO";
            this.label49.Click += new System.EventHandler(this.label49_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(133, 16);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(35, 31);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 154;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label44.Location = new System.Drawing.Point(94, 3);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(73, 13);
            this.label44.TabIndex = 153;
            this.label44.Text = "A C C I O N";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label45.Location = new System.Drawing.Point(48, 57);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(46, 12);
            this.label45.TabIndex = 152;
            this.label45.Text = "TALLER";
            this.label45.Click += new System.EventHandler(this.label45_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(11, 46);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(35, 31);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 146;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // imageListTruck
            // 
            this.imageListTruck.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTruck.ImageStream")));
            this.imageListTruck.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTruck.Images.SetKeyName(0, "icons8-truck-100 retro - activ.png");
            this.imageListTruck.Images.SetKeyName(1, "icons8-truck-100 retro - no activ.png");
            this.imageListTruck.Images.SetKeyName(2, "icons8-truck-top-view-96.png");
            this.imageListTruck.Images.SetKeyName(3, "icons8-truck-top-view-96-inact.png");
            this.imageListTruck.Images.SetKeyName(4, "icons8-truck-100 - act.png");
            this.imageListTruck.Images.SetKeyName(5, "icons8-truck-100 - noact.png");
            // 
            // timerClockMin
            // 
            this.timerClockMin.Enabled = true;
            this.timerClockMin.Interval = 60000;
            this.timerClockMin.Tick += new System.EventHandler(this.timerClockMin_Tick);
            // 
            // timerRepartos
            // 
            this.timerRepartos.Enabled = true;
            this.timerRepartos.Interval = 30000;
            this.timerRepartos.Tick += new System.EventHandler(this.timerRepartos_Tick);
            // 
            // panelIndicador02
            // 
            this.panelIndicador02.Location = new System.Drawing.Point(153, 380);
            this.panelIndicador02.Name = "panelIndicador02";
            this.panelIndicador02.Size = new System.Drawing.Size(35, 29);
            this.panelIndicador02.TabIndex = 1;
            this.panelIndicador02.Visible = false;
            this.panelIndicador02.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIndicador02_Paint);
            // 
            // picIndicador01
            // 
            this.picIndicador01.BackColor = System.Drawing.Color.Transparent;
            this.picIndicador01.Image = ((System.Drawing.Image)(resources.GetObject("picIndicador01.Image")));
            this.picIndicador01.Location = new System.Drawing.Point(100, 384);
            this.picIndicador01.Name = "picIndicador01";
            this.picIndicador01.Size = new System.Drawing.Size(11, 22);
            this.picIndicador01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIndicador01.TabIndex = 376;
            this.picIndicador01.TabStop = false;
            this.picIndicador01.Click += new System.EventHandler(this.picIndicador01_Click);
            // 
            // lblEcologicosCorrrales
            // 
            this.lblEcologicosCorrrales.AutoSize = true;
            this.lblEcologicosCorrrales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcologicosCorrrales.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEcologicosCorrrales.Location = new System.Drawing.Point(109, 418);
            this.lblEcologicosCorrrales.Name = "lblEcologicosCorrrales";
            this.lblEcologicosCorrrales.Size = new System.Drawing.Size(86, 13);
            this.lblEcologicosCorrrales.TabIndex = 377;
            this.lblEcologicosCorrrales.Text = "ECOLOGICOS";
            // 
            // lblClasicosCorrrales
            // 
            this.lblClasicosCorrrales.AutoSize = true;
            this.lblClasicosCorrrales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasicosCorrrales.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClasicosCorrrales.Location = new System.Drawing.Point(217, 420);
            this.lblClasicosCorrrales.Name = "lblClasicosCorrrales";
            this.lblClasicosCorrrales.Size = new System.Drawing.Size(67, 13);
            this.lblClasicosCorrrales.TabIndex = 378;
            this.lblClasicosCorrrales.Text = "CLASICOS";
            // 
            // frmMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1423, 706);
            this.ControlBox = false;
            this.Controls.Add(this.lblClasicosCorrrales);
            this.Controls.Add(this.lblEcologicosCorrrales);
            this.Controls.Add(this.picIndicador01);
            this.Controls.Add(this.panelReloj);
            this.Controls.Add(this.panelIndicador02);
            this.Controls.Add(this.panelIndicador01);
            this.Controls.Add(this.panelDescrip);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.btnCerrarPanel);
            this.Controls.Add(this.panelCamion2);
            this.Controls.Add(this.lblEcoConn);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.lblClasicConn);
            this.Controls.Add(this.btnAbrirCerrarPanel);
            this.Controls.Add(this.panelLeyenda);
            this.Controls.Add(this.panelLeyendas);
            this.Controls.Add(this.panelCamion);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.panelDetalles);
            this.Controls.Add(this.panelCamiones);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.btnRotarIzq);
            this.Controls.Add(this.btnRotarDer);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.panelFecha);
            this.Controls.Add(this.panelTrack);
            this.Controls.Add(this.webBClima);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitContainerMapa);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.toolStrip2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmMapa";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMapa_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMapa_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.frmMapa_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMapa_KeyPress);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStripMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panelLeyenda.ResumeLayout(false);
            this.panelLeyenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox717)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox716)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox715)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox714)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox713)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox712)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox711)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox710)).EndInit();
            this.panelTrack.ResumeLayout(false);
            this.panelTrack.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panelFecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelLeyendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVista)).EndInit();
            this.panelCamiones.ResumeLayout(false);
            this.panelCamiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpsCam01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam01)).EndInit();
            this.panelDetalles.ResumeLayout(false);
            this.panelDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.splitContainerMapa.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMapa)).EndInit();
            this.splitContainerMapa.ResumeLayout(false);
            this.splitContainerMapas.Panel1.ResumeLayout(false);
            this.splitContainerMapas.Panel2.ResumeLayout(false);
            this.splitContainerMapas.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMapas)).EndInit();
            this.splitContainerMapas.ResumeLayout(false);
            this.panelCamion.ResumeLayout(false);
            this.panelCamion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBs28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecLimpia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGps2Cam01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRec01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRep2Cam01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBs01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCam17.ResumeLayout(false);
            this.panelCam17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov17)).EndInit();
            this.panelCam16.ResumeLayout(false);
            this.panelCam16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov16)).EndInit();
            this.panelCam15.ResumeLayout(false);
            this.panelCam15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion15)).EndInit();
            this.panelCam14.ResumeLayout(false);
            this.panelCam14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPila14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi14)).EndInit();
            this.panelCamion2.ResumeLayout(false);
            this.panelCamion2.PerformLayout();
            this.panelDescripciones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.panelCam36.ResumeLayout(false);
            this.panelCam36.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion36)).EndInit();
            this.panelCam32.ResumeLayout(false);
            this.panelCam32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion32)).EndInit();
            this.panelCam35.ResumeLayout(false);
            this.panelCam35.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion35)).EndInit();
            this.panelCam31.ResumeLayout(false);
            this.panelCam31.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion31)).EndInit();
            this.panelCam34.ResumeLayout(false);
            this.panelCam34.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion34)).EndInit();
            this.panelCam30.ResumeLayout(false);
            this.panelCam30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion30)).EndInit();
            this.panelCam33.ResumeLayout(false);
            this.panelCam33.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion33)).EndInit();
            this.panelCam28.ResumeLayout(false);
            this.panelCam28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion28)).EndInit();
            this.panelCam29.ResumeLayout(false);
            this.panelCam29.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion29)).EndInit();
            this.panelCam24.ResumeLayout(false);
            this.panelCam24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion24)).EndInit();
            this.panelCam27.ResumeLayout(false);
            this.panelCam27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion27)).EndInit();
            this.panelCam23.ResumeLayout(false);
            this.panelCam23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion23)).EndInit();
            this.panelCam26.ResumeLayout(false);
            this.panelCam26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion26)).EndInit();
            this.panelCam21.ResumeLayout(false);
            this.panelCam21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion21)).EndInit();
            this.panelCam25.ResumeLayout(false);
            this.panelCam25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMov25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion25)).EndInit();
            this.panelCam22.ResumeLayout(false);
            this.panelCam22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion22)).EndInit();
            this.panelCam18.ResumeLayout(false);
            this.panelCam18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion18)).EndInit();
            this.panelCam04.ResumeLayout(false);
            this.panelCam04.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion04)).EndInit();
            this.panelCam19.ResumeLayout(false);
            this.panelCam19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion19)).EndInit();
            this.panelCam20.ResumeLayout(false);
            this.panelCam20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion20)).EndInit();
            this.panelCam08.ResumeLayout(false);
            this.panelCam08.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion08)).EndInit();
            this.panelCam01.ResumeLayout(false);
            this.panelCam01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPila01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi01)).EndInit();
            this.panelCam02.ResumeLayout(false);
            this.panelCam02.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPila02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi02)).EndInit();
            this.panelCam12.ResumeLayout(false);
            this.panelCam12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion12)).EndInit();
            this.panelCam03.ResumeLayout(false);
            this.panelCam03.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion03)).EndInit();
            this.panelCam05.ResumeLayout(false);
            this.panelCam05.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion05)).EndInit();
            this.panelCam09.ResumeLayout(false);
            this.panelCam09.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion09)).EndInit();
            this.panelCam06.ResumeLayout(false);
            this.panelCam06.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion06)).EndInit();
            this.panelCam07.ResumeLayout(false);
            this.panelCam07.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion07)).EndInit();
            this.panelCam13.ResumeLayout(false);
            this.panelCam13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPila13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi13)).EndInit();
            this.panelCam10.ResumeLayout(false);
            this.panelCam10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion10)).EndInit();
            this.panelCam11.ResumeLayout(false);
            this.panelCam11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPila11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamion11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panelDescrip.ResumeLayout(false);
            this.panelDescrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIndicador01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timerCamion;
        private System.Windows.Forms.Button btnRotarIzq;
        private System.Windows.Forms.Button btnRotarDer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopiar;
        private System.Windows.Forms.ImageList imageListColor;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel lblCoordenadas;
        private System.Windows.Forms.ToolStripLabel lblDistancia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ubicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moverToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lblip;
        private System.Windows.Forms.ToolStripLabel lblLatencia;
        private System.Windows.Forms.WebBrowser webBClima;
        private System.Windows.Forms.ToolStripMenuItem marcadoresToolStripMenuItem;
        private System.Windows.Forms.Panel panelLeyenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox717;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox716;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox715;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox714;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox713;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox712;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox711;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox710;
        private System.Windows.Forms.Panel panelTrack;
        private System.Windows.Forms.ToolStripLabel lblInstancia;
        private System.Windows.Forms.ToolStripLabel lblOrigenDatos;
        private System.Windows.Forms.ToolStripLabel lblZomm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnCerrarFecha;
        private System.Windows.Forms.Panel panelFecha;
        private System.Windows.Forms.Button btnActualizaFecha;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripLabel lblErrores;
        private System.Windows.Forms.ListBox listBoxLeyendas;
        private System.Windows.Forms.Panel panelLeyendas;
        private System.Windows.Forms.Label labelLeyendas;
        private System.Windows.Forms.ToolStripLabel lblServer;
        private System.Windows.Forms.ToolStripLabel lblMandante;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.DataGridView dataGridVista;
        private System.Windows.Forms.ToolStripLabel lblCorral;
        private System.Windows.Forms.ToolStripMenuItem modifcarToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lblGiro;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem ajustarToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lblProveedor;
        private System.Windows.Forms.ToolStripLabel lblCtrl;
        private System.Windows.Forms.ToolStripMenuItem alinearToolStripMenuItem;
        private System.Windows.Forms.Timer timerPing;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripLabel lblPing;
        private System.Windows.Forms.Panel panelCamiones;
        private System.Windows.Forms.PictureBox picCam01;
        private System.Windows.Forms.PictureBox picCam03;
        private System.Windows.Forms.PictureBox picCam05;
        private System.Windows.Forms.PictureBox picCam14;
        private System.Windows.Forms.PictureBox picCam15;
        private System.Windows.Forms.PictureBox picCam13;
        private System.Windows.Forms.PictureBox picCam11;
        private System.Windows.Forms.PictureBox picCam12;
        private System.Windows.Forms.PictureBox picCam10;
        private System.Windows.Forms.PictureBox picCam08;
        private System.Windows.Forms.PictureBox picCam09;
        private System.Windows.Forms.PictureBox picCam07;
        private System.Windows.Forms.PictureBox picCam04;
        private System.Windows.Forms.PictureBox picCam06;
        private System.Windows.Forms.PictureBox picCam02;
        private System.Windows.Forms.ToolStripButton btnPing;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.ToolStripMenuItem buscarCoordenadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarCoordenadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCoordenadasToolStripMenuItem;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label labelDetalles;
        public System.Windows.Forms.ToolStripProgressBar lblConectadoF;
        private System.Windows.Forms.ToolStripMenuItem verOcultarCoordenadasCamionToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lblDistanciaMin;
        private System.Windows.Forms.ToolStripLabel lblOrientacion;
        private System.Windows.Forms.ToolStripLabel lblAngulo;
        private System.Windows.Forms.ToolStripLabel lblHora;
        private System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.ToolStripLabel lblTimer;
        private System.Windows.Forms.PictureBox picRepCam01;
        private System.Windows.Forms.PictureBox picRepCam02;
        private System.Windows.Forms.PictureBox picRepCam08;
        private System.Windows.Forms.PictureBox picRepCam07;
        private System.Windows.Forms.PictureBox picRepCam06;
        private System.Windows.Forms.PictureBox picRepCam05;
        private System.Windows.Forms.PictureBox picRepCam04;
        private System.Windows.Forms.PictureBox picRepCam03;
        private System.Windows.Forms.PictureBox picRepCam15;
        private System.Windows.Forms.PictureBox picRepCam14;
        private System.Windows.Forms.PictureBox picRepCam13;
        private System.Windows.Forms.PictureBox picRepCam12;
        private System.Windows.Forms.PictureBox picRepCam11;
        private System.Windows.Forms.PictureBox picRepCam10;
        private System.Windows.Forms.PictureBox picRepCam09;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnOcultarCuadro;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripLabel lblMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.PictureBox picGpsCam01;
        private System.Windows.Forms.Label lbl04;
        private System.Windows.Forms.Label lbl03;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.PictureBox picGpsCam04;
        private System.Windows.Forms.PictureBox picGpsCam03;
        private System.Windows.Forms.PictureBox picGpsCam02;
        private System.Windows.Forms.Label lbl15;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl09;
        private System.Windows.Forms.Label lbl08;
        private System.Windows.Forms.Label lbl07;
        private System.Windows.Forms.Label lbl06;
        private System.Windows.Forms.Label lbl05;
        private System.Windows.Forms.PictureBox picGpsCam08;
        private System.Windows.Forms.PictureBox picGpsCam07;
        private System.Windows.Forms.PictureBox picGpsCam06;
        private System.Windows.Forms.PictureBox picGpsCam05;
        private System.Windows.Forms.PictureBox picGpsCam15;
        private System.Windows.Forms.PictureBox picGpsCam14;
        private System.Windows.Forms.PictureBox picGpsCam13;
        private System.Windows.Forms.PictureBox picGpsCam12;
        private System.Windows.Forms.PictureBox picGpsCam11;
        private System.Windows.Forms.PictureBox picGpsCam10;
        private System.Windows.Forms.PictureBox picGpsCam09;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblCamPorc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.ToolStripButton toolStripButton21;
        private System.Windows.Forms.Panel panelCamion;
        private System.Windows.Forms.ProgressBar pBar01;
        private System.Windows.Forms.Label lblCam01;
        private System.Windows.Forms.Label lblCam02;
        private System.Windows.Forms.ProgressBar pBar02;
        private System.Windows.Forms.Label lblCam04;
        private System.Windows.Forms.ProgressBar pBar04;
        private System.Windows.Forms.Label lblCam03;
        private System.Windows.Forms.ProgressBar pBar03;
        private System.Windows.Forms.Label lblCam08;
        private System.Windows.Forms.ProgressBar pBar08;
        private System.Windows.Forms.Label lblCam07;
        private System.Windows.Forms.ProgressBar pBar07;
        private System.Windows.Forms.Label lblCam06;
        private System.Windows.Forms.ProgressBar pBar06;
        private System.Windows.Forms.Label lblCam05;
        private System.Windows.Forms.ProgressBar pBar05;
        private System.Windows.Forms.Label lblCam15;
        private System.Windows.Forms.ProgressBar pBar15;
        private System.Windows.Forms.Label lblCam14;
        private System.Windows.Forms.ProgressBar pBar14;
        private System.Windows.Forms.Label lblCam13;
        private System.Windows.Forms.ProgressBar pBar13;
        private System.Windows.Forms.Label lblCam12;
        private System.Windows.Forms.ProgressBar pBar12;
        private System.Windows.Forms.Label lblCam11;
        private System.Windows.Forms.ProgressBar pBar11;
        private System.Windows.Forms.Label lblCam10;
        private System.Windows.Forms.ProgressBar pBar10;
        private System.Windows.Forms.Label lblCam09;
        private System.Windows.Forms.ProgressBar pBar09;
        private System.Windows.Forms.Label lblpB15;
        private System.Windows.Forms.Label lblpB14;
        private System.Windows.Forms.Label lblpB13;
        private System.Windows.Forms.Label lblpB12;
        private System.Windows.Forms.Label lblpB11;
        private System.Windows.Forms.Label lblpB10;
        private System.Windows.Forms.Label lblpB09;
        private System.Windows.Forms.Label lblpB08;
        private System.Windows.Forms.Label lblpB07;
        private System.Windows.Forms.Label lblpB06;
        private System.Windows.Forms.Label lblpB05;
        private System.Windows.Forms.Label lblpB04;
        private System.Windows.Forms.Label lblpB03;
        private System.Windows.Forms.Label lblpB02;
        private System.Windows.Forms.Label lblpB01;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblpBc15;
        private System.Windows.Forms.Label lblpBc14;
        private System.Windows.Forms.Label lblpBc13;
        private System.Windows.Forms.Label lblpBc12;
        private System.Windows.Forms.Label lblpBc11;
        private System.Windows.Forms.Label lblpBc10;
        private System.Windows.Forms.Label lblpBc09;
        private System.Windows.Forms.Label lblpBc08;
        private System.Windows.Forms.Label lblpBc07;
        private System.Windows.Forms.Label lblpBc06;
        private System.Windows.Forms.Label lblpBc05;
        private System.Windows.Forms.Label lblpBc04;
        private System.Windows.Forms.Label lblpBc03;
        private System.Windows.Forms.Label lblpBc02;
        private System.Windows.Forms.Label lblpBc01;
        private System.Windows.Forms.Label lblpBr15;
        private System.Windows.Forms.Label lblpBr14;
        private System.Windows.Forms.Label lblpBr13;
        private System.Windows.Forms.Label lblpBr12;
        private System.Windows.Forms.Label lblpBr11;
        private System.Windows.Forms.Label lblpBr10;
        private System.Windows.Forms.Label lblpBr09;
        private System.Windows.Forms.Label lblpBr08;
        private System.Windows.Forms.Label lblpBr07;
        private System.Windows.Forms.Label lblpBr06;
        private System.Windows.Forms.Label lblpBr05;
        private System.Windows.Forms.Label lblpBr04;
        private System.Windows.Forms.Label lblpBr03;
        private System.Windows.Forms.Label lblpBr02;
        private System.Windows.Forms.Label lblpBr01;
        private System.Windows.Forms.Label lblpBs15;
        private System.Windows.Forms.Label lblpBs14;
        private System.Windows.Forms.Label lblpBs13;
        private System.Windows.Forms.Label lblpBs12;
        private System.Windows.Forms.Label lblpBs11;
        private System.Windows.Forms.Label lblpBs10;
        private System.Windows.Forms.Label lblpBs09;
        private System.Windows.Forms.Label lblpBs08;
        private System.Windows.Forms.Label lblpBs07;
        private System.Windows.Forms.Label lblpBs06;
        private System.Windows.Forms.Label lblpBs05;
        private System.Windows.Forms.Label lblpBs04;
        private System.Windows.Forms.Label lblpBs03;
        private System.Windows.Forms.Label lblpBs02;
        private System.Windows.Forms.Label lblpBs01;
        private System.Windows.Forms.PictureBox picBs01;
        private System.Windows.Forms.PictureBox picBs02;
        private System.Windows.Forms.PictureBox picBs04;
        private System.Windows.Forms.PictureBox picBs03;
        private System.Windows.Forms.PictureBox picBs13;
        private System.Windows.Forms.PictureBox picBs12;
        private System.Windows.Forms.PictureBox picBs11;
        private System.Windows.Forms.PictureBox picBs10;
        private System.Windows.Forms.PictureBox picBs09;
        private System.Windows.Forms.PictureBox picBs08;
        private System.Windows.Forms.PictureBox picBs07;
        private System.Windows.Forms.PictureBox picBs06;
        private System.Windows.Forms.PictureBox picBs05;
        private System.Windows.Forms.PictureBox picBs15;
        private System.Windows.Forms.PictureBox picBs14;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblpBb15;
        private System.Windows.Forms.Label lblpBb14;
        private System.Windows.Forms.Label lblpBb13;
        private System.Windows.Forms.Label lblpBb12;
        private System.Windows.Forms.Label lblpBb11;
        private System.Windows.Forms.Label lblpBb10;
        private System.Windows.Forms.Label lblpBb09;
        private System.Windows.Forms.Label lblpBb08;
        private System.Windows.Forms.Label lblpBb07;
        private System.Windows.Forms.Label lblpBb06;
        private System.Windows.Forms.Label lblpBb05;
        private System.Windows.Forms.Label lblpBb04;
        private System.Windows.Forms.Label lblpBb03;
        private System.Windows.Forms.Label lblpBb02;
        private System.Windows.Forms.Label lblpBb01;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblpBv15;
        private System.Windows.Forms.Label lblpBv14;
        private System.Windows.Forms.Label lblpBv13;
        private System.Windows.Forms.Label lblpBv12;
        private System.Windows.Forms.Label lblpBv11;
        private System.Windows.Forms.Label lblpBv10;
        private System.Windows.Forms.Label lblpBv09;
        private System.Windows.Forms.Label lblpBv08;
        private System.Windows.Forms.Label lblpBv07;
        private System.Windows.Forms.Label lblpBv06;
        private System.Windows.Forms.Label lblpBv05;
        private System.Windows.Forms.Label lblpBv04;
        private System.Windows.Forms.Label lblpBv03;
        private System.Windows.Forms.Label lblpBv02;
        private System.Windows.Forms.Label lblpBv01;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picGpsCam22;
        private System.Windows.Forms.PictureBox picGpsCam21;
        private System.Windows.Forms.PictureBox picGpsCam20;
        private System.Windows.Forms.PictureBox picGpsCam19;
        private System.Windows.Forms.PictureBox picGpsCam18;
        private System.Windows.Forms.PictureBox picGpsCam17;
        private System.Windows.Forms.PictureBox picGpsCam16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl16;
        private System.Windows.Forms.PictureBox picRepCam22;
        private System.Windows.Forms.PictureBox picRepCam21;
        private System.Windows.Forms.PictureBox picRepCam20;
        private System.Windows.Forms.PictureBox picRepCam19;
        private System.Windows.Forms.PictureBox picRepCam18;
        private System.Windows.Forms.PictureBox picRepCam17;
        private System.Windows.Forms.PictureBox picRepCam16;
        private System.Windows.Forms.Button btnAbrirCerrarPanel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox picRec01;
        private System.Windows.Forms.PictureBox picRec04;
        private System.Windows.Forms.PictureBox picRec03;
        private System.Windows.Forms.PictureBox picRec02;
        private System.Windows.Forms.PictureBox picRec14;
        private System.Windows.Forms.PictureBox picRec13;
        private System.Windows.Forms.PictureBox picRec12;
        private System.Windows.Forms.PictureBox picRec11;
        private System.Windows.Forms.PictureBox picRec10;
        private System.Windows.Forms.PictureBox picRec09;
        private System.Windows.Forms.PictureBox picRec08;
        private System.Windows.Forms.PictureBox picRec07;
        private System.Windows.Forms.PictureBox picRec06;
        private System.Windows.Forms.PictureBox picRec05;
        private System.Windows.Forms.PictureBox picRec15;
        private System.Windows.Forms.PictureBox picRecLimpia;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.PictureBox picRec16;
        private System.Windows.Forms.Label lblpBv16;
        private System.Windows.Forms.Label lblpBb16;
        private System.Windows.Forms.Label lblpBr16;
        private System.Windows.Forms.Label lblpBc16;
        private System.Windows.Forms.Label lblCam16;
        private System.Windows.Forms.ProgressBar pBar16;
        private System.Windows.Forms.PictureBox picBs16;
        private System.Windows.Forms.Label lblpBs16;
        private System.Windows.Forms.Label lblpB16;
        private System.Windows.Forms.PictureBox picCam16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox listBoxRutaError;
        private System.Windows.Forms.Label lblRutaError;
        private System.Windows.Forms.PictureBox picGps2Cam16;
        private System.Windows.Forms.PictureBox picRep2Cam16;
        private System.Windows.Forms.PictureBox picGps2Cam15;
        private System.Windows.Forms.PictureBox picGps2Cam14;
        private System.Windows.Forms.PictureBox picGps2Cam13;
        private System.Windows.Forms.PictureBox picGps2Cam12;
        private System.Windows.Forms.PictureBox picGps2Cam11;
        private System.Windows.Forms.PictureBox picGps2Cam10;
        private System.Windows.Forms.PictureBox picGps2Cam09;
        private System.Windows.Forms.PictureBox picGps2Cam08;
        private System.Windows.Forms.PictureBox picGps2Cam07;
        private System.Windows.Forms.PictureBox picGps2Cam06;
        private System.Windows.Forms.PictureBox picGps2Cam05;
        private System.Windows.Forms.PictureBox picGps2Cam04;
        private System.Windows.Forms.PictureBox picGps2Cam03;
        private System.Windows.Forms.PictureBox picGps2Cam02;
        private System.Windows.Forms.PictureBox picGps2Cam01;
        private System.Windows.Forms.PictureBox picRep2Cam15;
        private System.Windows.Forms.PictureBox picRep2Cam14;
        private System.Windows.Forms.PictureBox picRep2Cam13;
        private System.Windows.Forms.PictureBox picRep2Cam12;
        private System.Windows.Forms.PictureBox picRep2Cam11;
        private System.Windows.Forms.PictureBox picRep2Cam08;
        private System.Windows.Forms.PictureBox picRep2Cam10;
        private System.Windows.Forms.PictureBox picRep2Cam07;
        private System.Windows.Forms.PictureBox picRep2Cam09;
        private System.Windows.Forms.PictureBox picRep2Cam06;
        private System.Windows.Forms.PictureBox picRep2Cam05;
        private System.Windows.Forms.PictureBox picRep2Cam04;
        private System.Windows.Forms.PictureBox picRep2Cam03;
        private System.Windows.Forms.PictureBox picRep2Cam02;
        private System.Windows.Forms.PictureBox picRep2Cam01;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblpAct16;
        private System.Windows.Forms.Label lblpAct15;
        private System.Windows.Forms.Label lblpAct14;
        private System.Windows.Forms.Label lblpAct13;
        private System.Windows.Forms.Label lblpAct12;
        private System.Windows.Forms.Label lblpAct11;
        private System.Windows.Forms.Label lblpAct10;
        private System.Windows.Forms.Label lblpAct09;
        private System.Windows.Forms.Label lblpAct08;
        private System.Windows.Forms.Label lblpAct07;
        private System.Windows.Forms.Label lblpAct06;
        private System.Windows.Forms.Label lblpAct05;
        private System.Windows.Forms.Label lblpAct04;
        private System.Windows.Forms.Label lblpAct03;
        private System.Windows.Forms.Label lblpAct02;
        private System.Windows.Forms.Label lblpAct01;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label lblpAct22;
        private System.Windows.Forms.Label lblpAct21;
        private System.Windows.Forms.Label lblpAct20;
        private System.Windows.Forms.Label lblpAct19;
        private System.Windows.Forms.Label lblpAct18;
        private System.Windows.Forms.Label lblpAct17;
        private System.Windows.Forms.PictureBox picGps2Cam22;
        private System.Windows.Forms.PictureBox picRec22;
        private System.Windows.Forms.Label lblpBv22;
        private System.Windows.Forms.Label lblpBb22;
        private System.Windows.Forms.Label lblpBr22;
        private System.Windows.Forms.Label lblpBc22;
        private System.Windows.Forms.PictureBox picRep2Cam22;
        private System.Windows.Forms.Label lblCam22;
        private System.Windows.Forms.PictureBox picGps2Cam21;
        private System.Windows.Forms.PictureBox picRep2Cam21;
        private System.Windows.Forms.PictureBox picGps2Cam20;
        private System.Windows.Forms.PictureBox picRep2Cam20;
        private System.Windows.Forms.PictureBox picGps2Cam19;
        private System.Windows.Forms.PictureBox picRec21;
        private System.Windows.Forms.PictureBox picGps2Cam18;
        private System.Windows.Forms.PictureBox picRep2Cam19;
        private System.Windows.Forms.PictureBox picRec20;
        private System.Windows.Forms.PictureBox picGps2Cam17;
        private System.Windows.Forms.PictureBox picRec19;
        private System.Windows.Forms.PictureBox picRep2Cam18;
        private System.Windows.Forms.PictureBox picRec18;
        private System.Windows.Forms.PictureBox picRep2Cam17;
        private System.Windows.Forms.PictureBox picRec17;
        private System.Windows.Forms.Label lblpBv21;
        private System.Windows.Forms.Label lblpBv20;
        private System.Windows.Forms.Label lblpBv19;
        private System.Windows.Forms.Label lblpBv18;
        private System.Windows.Forms.Label lblpBv17;
        private System.Windows.Forms.Label lblpBb21;
        private System.Windows.Forms.Label lblpBb20;
        private System.Windows.Forms.Label lblpBb19;
        private System.Windows.Forms.Label lblpBb18;
        private System.Windows.Forms.Label lblpBb17;
        private System.Windows.Forms.Label lblpBr21;
        private System.Windows.Forms.Label lblpBr20;
        private System.Windows.Forms.Label lblpBr19;
        private System.Windows.Forms.Label lblpBr18;
        private System.Windows.Forms.Label lblpBr17;
        private System.Windows.Forms.Label lblpBc21;
        private System.Windows.Forms.Label lblpBc20;
        private System.Windows.Forms.Label lblpBc19;
        private System.Windows.Forms.Label lblpBc18;
        private System.Windows.Forms.Label lblpBc17;
        private System.Windows.Forms.Label lblCam21;
        private System.Windows.Forms.Label lblCam20;
        private System.Windows.Forms.Label lblCam19;
        private System.Windows.Forms.Label lblCam18;
        private System.Windows.Forms.Label lblCam17;
        private System.Windows.Forms.PictureBox picCam22;
        private System.Windows.Forms.PictureBox picCam20;
        private System.Windows.Forms.PictureBox picCam21;
        private System.Windows.Forms.PictureBox picCam19;
        private System.Windows.Forms.PictureBox picCam17;
        private System.Windows.Forms.PictureBox picCam18;
        private System.Windows.Forms.ProgressBar pBar22;
        private System.Windows.Forms.PictureBox picBs22;
        private System.Windows.Forms.ProgressBar pBar21;
        private System.Windows.Forms.PictureBox picBs21;
        private System.Windows.Forms.PictureBox picBs20;
        private System.Windows.Forms.PictureBox picBs19;
        private System.Windows.Forms.PictureBox picBs18;
        private System.Windows.Forms.PictureBox picBs17;
        private System.Windows.Forms.ProgressBar pBar20;
        private System.Windows.Forms.ProgressBar pBar19;
        private System.Windows.Forms.ProgressBar pBar18;
        private System.Windows.Forms.ProgressBar pBar17;
        private System.Windows.Forms.Label lblpB22;
        private System.Windows.Forms.Label lblpB21;
        private System.Windows.Forms.Label lblpB20;
        private System.Windows.Forms.Label lblpB19;
        private System.Windows.Forms.Label lblpB18;
        private System.Windows.Forms.Label lblpB17;
        private System.Windows.Forms.Label lblpBs21;
        private System.Windows.Forms.Label lblpBs20;
        private System.Windows.Forms.Label lblpBs19;
        private System.Windows.Forms.Label lblpBs18;
        private System.Windows.Forms.Label lblpBs17;
        private System.Windows.Forms.Label lblpBs22;
		private System.Windows.Forms.Label lblClasicConn;
		private System.Windows.Forms.Label lblEcoConn;
		private System.Windows.Forms.Panel panelCam17;
		private System.Windows.Forms.Panel panelCam16;
		private System.Windows.Forms.Panel panelCam14;
		private System.Windows.Forms.Panel panelCam15;
		private System.Windows.Forms.Panel panelCamion2;
		private System.Windows.Forms.Panel panelCam13;
		private System.Windows.Forms.Panel panelCam12;
		private System.Windows.Forms.Panel panelCam09;
		private System.Windows.Forms.Panel panelCam10;
		private System.Windows.Forms.Panel panelCam11;
		private System.Windows.Forms.Panel panelCam04;
		private System.Windows.Forms.Panel panelCam08;
		private System.Windows.Forms.Panel panelCam01;
		private System.Windows.Forms.Panel panelCam02;
		private System.Windows.Forms.Panel panelCam03;
		private System.Windows.Forms.Panel panelCam05;
		private System.Windows.Forms.Panel panelCam06;
		private System.Windows.Forms.Panel panelCam07;
		private System.Windows.Forms.Panel panelCam18;
		private System.Windows.Forms.Panel panelCam19;
		private System.Windows.Forms.Panel panelCam20;
		private System.Windows.Forms.PictureBox picMov17;
		private System.Windows.Forms.PictureBox picMov22;
		private System.Windows.Forms.PictureBox picMov21;
		private System.Windows.Forms.PictureBox picMov20;
		private System.Windows.Forms.PictureBox picMov19;
		private System.Windows.Forms.PictureBox picMov18;
		private System.Windows.Forms.PictureBox picMov16;
		private System.Windows.Forms.PictureBox picMov15;
		private System.Windows.Forms.PictureBox picMov14;
		private System.Windows.Forms.PictureBox picMov13;
		private System.Windows.Forms.PictureBox picMov12;
		private System.Windows.Forms.PictureBox picMov11;
		private System.Windows.Forms.PictureBox picMov10;
		private System.Windows.Forms.PictureBox picMov09;
		private System.Windows.Forms.PictureBox picMov08;
		private System.Windows.Forms.PictureBox picMov07;
		private System.Windows.Forms.PictureBox picMov06;
		private System.Windows.Forms.PictureBox picMov05;
		private System.Windows.Forms.PictureBox picMov04;
		private System.Windows.Forms.PictureBox picMov03;
		private System.Windows.Forms.PictureBox picMov02;
		private System.Windows.Forms.PictureBox picMov01;
		private System.Windows.Forms.PictureBox picCamion01;
		private System.Windows.Forms.PictureBox picCamion04;
		private System.Windows.Forms.PictureBox picCamion02;
		private System.Windows.Forms.PictureBox picCamion03;
		private System.Windows.Forms.PictureBox picCamion17;
		private System.Windows.Forms.PictureBox picCamion16;
		private System.Windows.Forms.PictureBox picCamion15;
		private System.Windows.Forms.PictureBox picCamion14;
		private System.Windows.Forms.PictureBox picCamion18;
		private System.Windows.Forms.PictureBox picCamion19;
		private System.Windows.Forms.PictureBox picCamion20;
		private System.Windows.Forms.PictureBox picCamion08;
		private System.Windows.Forms.PictureBox picCamion12;
		private System.Windows.Forms.PictureBox picCamion05;
		private System.Windows.Forms.PictureBox picCamion09;
		private System.Windows.Forms.PictureBox picCamion06;
		private System.Windows.Forms.PictureBox picCamion07;
		private System.Windows.Forms.PictureBox picCamion13;
		private System.Windows.Forms.PictureBox picCamion10;
		private System.Windows.Forms.PictureBox picCamion11;
		private System.Windows.Forms.ImageList imageListCamiones;
		private System.Windows.Forms.ImageList imageListSignal;
		private System.Windows.Forms.ImageList imageListMov;
		private System.Windows.Forms.ImageList imageListEstado;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Panel panelCam21;
        private System.Windows.Forms.PictureBox picCamion21;
        private System.Windows.Forms.Panel panelCam22;
        private System.Windows.Forms.PictureBox picCamion22;
        private System.Windows.Forms.Panel panelCam23;
        private System.Windows.Forms.PictureBox picMov23;
        private System.Windows.Forms.PictureBox picCamion23;
        private System.Windows.Forms.Label lblCam23;
        private System.Windows.Forms.Label lblpAct23;
        private System.Windows.Forms.Label lblpBr23;
        private System.Windows.Forms.ProgressBar pBar23;
        private System.Windows.Forms.Label lblpBc23;
        private System.Windows.Forms.PictureBox picCam23;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.PictureBox picRepCam23;
        private System.Windows.Forms.PictureBox picGpsCam23;
        private System.Windows.Forms.Label lblpB23;
        private System.Windows.Forms.Label lblpBs23;
        private System.Windows.Forms.PictureBox picBs23;
        private System.Windows.Forms.PictureBox picRec23;
        private System.Windows.Forms.Label lblpBb23;
        private System.Windows.Forms.Label lblpBv23;
        private System.Windows.Forms.PictureBox picGps2Cam23;
        private System.Windows.Forms.PictureBox picRep2Cam23;
        private System.Windows.Forms.SplitContainer splitContainerMapas;
        private GMap.NET.WindowsForms.GMapControl gMapControl2;
        private System.Windows.Forms.Panel panelCam24;
        private System.Windows.Forms.PictureBox picMov24;
        private System.Windows.Forms.PictureBox picCamion24;
        private System.Windows.Forms.Label lblCam24;
        private System.Windows.Forms.Label lblpAct24;
        private System.Windows.Forms.Label lblpBr24;
        private System.Windows.Forms.ProgressBar pBar24;
        private System.Windows.Forms.Label lblpBc24;
        private System.Windows.Forms.PictureBox picGps2Cam24;
        private System.Windows.Forms.PictureBox picRep2Cam24;
        private System.Windows.Forms.Label lblpBb24;
        private System.Windows.Forms.Label lblpBv24;
        private System.Windows.Forms.PictureBox picBs24;
        private System.Windows.Forms.PictureBox picRec24;
        private System.Windows.Forms.Label lblpB24;
        private System.Windows.Forms.Label lblpBs24;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.PictureBox picGpsCam24;
        private System.Windows.Forms.PictureBox picRepCam24;
        private System.Windows.Forms.PictureBox picCam24;
        private System.Windows.Forms.Panel panelCam25;
        private System.Windows.Forms.PictureBox picMov25;
        private System.Windows.Forms.PictureBox picCamion25;
        private System.Windows.Forms.Label lblCam25;
        private System.Windows.Forms.Label lblpAct25;
        private System.Windows.Forms.Label lblpBr25;
        private System.Windows.Forms.ProgressBar pBar25;
        private System.Windows.Forms.Panel panelCam26;
        private System.Windows.Forms.PictureBox picMov26;
        private System.Windows.Forms.PictureBox picCamion26;
        private System.Windows.Forms.Label lblCam26;
        private System.Windows.Forms.Label lblpAct26;
        private System.Windows.Forms.Label lblpBr26;
        private System.Windows.Forms.ProgressBar pBar26;
        private System.Windows.Forms.Panel panelCam27;
        private System.Windows.Forms.PictureBox picMov27;
        private System.Windows.Forms.PictureBox picCamion27;
        private System.Windows.Forms.Label lblCam27;
        private System.Windows.Forms.Label lblpAct27;
        private System.Windows.Forms.Label lblpBr27;
        private System.Windows.Forms.ProgressBar pBar27;
        private System.Windows.Forms.Panel panelCam28;
        private System.Windows.Forms.PictureBox picMov28;
        private System.Windows.Forms.PictureBox picCamion28;
        private System.Windows.Forms.Label lblCam28;
        private System.Windows.Forms.Label lblpAct28;
        private System.Windows.Forms.Label lblpBr28;
        private System.Windows.Forms.ProgressBar pBar28;
        private System.Windows.Forms.Label lblpB28;
        private System.Windows.Forms.Label lblpBs28;
        private System.Windows.Forms.PictureBox picBs28;
        private System.Windows.Forms.PictureBox picRec28;
        private System.Windows.Forms.Label lblpBb28;
        private System.Windows.Forms.Label lblpBv28;
        private System.Windows.Forms.PictureBox picGps2Cam28;
        private System.Windows.Forms.PictureBox picRep2Cam28;
        private System.Windows.Forms.Label lblpBc28;
        private System.Windows.Forms.Label lblpB27;
        private System.Windows.Forms.Label lblpBs27;
        private System.Windows.Forms.PictureBox picBs27;
        private System.Windows.Forms.PictureBox picRec27;
        private System.Windows.Forms.Label lblpBb27;
        private System.Windows.Forms.Label lblpBv27;
        private System.Windows.Forms.PictureBox picGps2Cam27;
        private System.Windows.Forms.PictureBox picRep2Cam27;
        private System.Windows.Forms.Label lblpBc27;
        private System.Windows.Forms.Label lblpB26;
        private System.Windows.Forms.Label lblpBs26;
        private System.Windows.Forms.PictureBox picBs26;
        private System.Windows.Forms.PictureBox picRec26;
        private System.Windows.Forms.Label lblpBb26;
        private System.Windows.Forms.Label lblpBv26;
        private System.Windows.Forms.PictureBox picGps2Cam26;
        private System.Windows.Forms.PictureBox picRep2Cam26;
        private System.Windows.Forms.Label lblpBc26;
        private System.Windows.Forms.Label lblpB25;
        private System.Windows.Forms.Label lblpBs25;
        private System.Windows.Forms.PictureBox picBs25;
        private System.Windows.Forms.PictureBox picRec25;
        private System.Windows.Forms.Label lblpBb25;
        private System.Windows.Forms.Label lblpBv25;
        private System.Windows.Forms.PictureBox picGps2Cam25;
        private System.Windows.Forms.PictureBox picRep2Cam25;
        private System.Windows.Forms.Label lblpBc25;
        private System.Windows.Forms.PictureBox picCam28;
        private System.Windows.Forms.PictureBox picCam27;
        private System.Windows.Forms.PictureBox picCam26;
        private System.Windows.Forms.PictureBox picCam25;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.PictureBox picGpsCam28;
        private System.Windows.Forms.PictureBox picRepCam28;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.PictureBox picRepCam27;
        private System.Windows.Forms.PictureBox picGpsCam27;
        private System.Windows.Forms.PictureBox picGpsCam26;
        private System.Windows.Forms.PictureBox picGpsCam25;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.PictureBox picRepCam26;
        private System.Windows.Forms.PictureBox picRepCam25;
        private System.Windows.Forms.PictureBox picWifi01;
        private System.Windows.Forms.PictureBox picWifi17;
        private System.Windows.Forms.PictureBox picWifi16;
        private System.Windows.Forms.PictureBox picWifi15;
        private System.Windows.Forms.PictureBox picWifi14;
        private System.Windows.Forms.PictureBox picWifi28;
        private System.Windows.Forms.PictureBox picWifi24;
        private System.Windows.Forms.PictureBox picWifi27;
        private System.Windows.Forms.PictureBox picWifi23;
        private System.Windows.Forms.PictureBox picWifi26;
        private System.Windows.Forms.PictureBox picWifi21;
        private System.Windows.Forms.PictureBox picWifi25;
        private System.Windows.Forms.PictureBox picWifi22;
        private System.Windows.Forms.PictureBox picWifi18;
        private System.Windows.Forms.PictureBox picWifi04;
        private System.Windows.Forms.PictureBox picWifi19;
        private System.Windows.Forms.PictureBox picWifi20;
        private System.Windows.Forms.PictureBox picWifi08;
        private System.Windows.Forms.PictureBox picWifi02;
        private System.Windows.Forms.PictureBox picWifi12;
        private System.Windows.Forms.PictureBox picWifi03;
        private System.Windows.Forms.PictureBox picWifi05;
        private System.Windows.Forms.PictureBox picWifi09;
        private System.Windows.Forms.PictureBox picWifi06;
        private System.Windows.Forms.PictureBox picWifi07;
        private System.Windows.Forms.PictureBox picWifi13;
        private System.Windows.Forms.PictureBox picWifi10;
        private System.Windows.Forms.PictureBox picWifi11;
        private System.Windows.Forms.ImageList imageListWifi;
        private System.Windows.Forms.ToolStripLabel toolStripLabel20;
        private System.Windows.Forms.ToolStripLabel toolStripLabel19;
        private System.Windows.Forms.ToolStripLabel toolStripLabel18;
        private System.Windows.Forms.ToolStripLabel toolStripLabel17;
        private System.Windows.Forms.ToolStripLabel toolStripLabel16;
        private System.Windows.Forms.ToolStripLabel toolStripLabel15;
        private System.Windows.Forms.ToolStripLabel toolStripLabel14;
        private System.Windows.Forms.ToolStripLabel toolStripLabel13;
        private System.Windows.Forms.ToolStripLabel toolStripLabel12;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem satelitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relieveToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem todoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecologicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empacadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem servidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cabezasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cmbFiltroVista;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox cmbColorCapas;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private System.Windows.Forms.ToolStripMenuItem hoyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtFecha;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtBuscarUbicacion;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmbCamiones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel lblcmbCamionRuta;
        private System.Windows.Forms.ToolStripComboBox cmbCamionRuta;
        private System.Windows.Forms.ToolStripButton btnBuscarcamionruta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cmbServidas;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripComboBox cmbCamion;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox cmbRaciones;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripButton toolStripButton20;
        private System.Windows.Forms.Label lblTablet01;
        private System.Windows.Forms.Label lblTablet20;
        private System.Windows.Forms.Label lblTablet18;
        private System.Windows.Forms.Label lblTablet19;
        private System.Windows.Forms.Label lblTablet17;
        private System.Windows.Forms.Label lblTablet16;
        private System.Windows.Forms.Label lblTablet15;
        private System.Windows.Forms.Label lblTablet14;
        private System.Windows.Forms.Label lblTablet24;
        private System.Windows.Forms.Label lblTablet23;
        private System.Windows.Forms.Label lblTablet21;
        private System.Windows.Forms.Label lblTablet22;
        private System.Windows.Forms.Label lblTablet04;
        private System.Windows.Forms.Label lblTablet08;
        private System.Windows.Forms.Label lblTablet02;
        private System.Windows.Forms.Label lblTablet12;
        private System.Windows.Forms.Label lblTablet03;
        private System.Windows.Forms.Label lblTablet05;
        private System.Windows.Forms.Label lblTablet09;
        private System.Windows.Forms.Label lblTablet06;
        private System.Windows.Forms.Label lblTablet07;
        private System.Windows.Forms.Label lblTablet13;
        private System.Windows.Forms.Label lblTablet10;
        private System.Windows.Forms.Label lblTablet11;
        private System.Windows.Forms.Label lblTablet28;
        private System.Windows.Forms.Label lblTablet27;
        private System.Windows.Forms.Label lblTablet26;
        private System.Windows.Forms.Label lblTablet25;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox picPila01;
        private System.Windows.Forms.PictureBox picPila16;
        private System.Windows.Forms.PictureBox picPila15;
        private System.Windows.Forms.PictureBox picPila14;
        private System.Windows.Forms.PictureBox picPila04;
        private System.Windows.Forms.PictureBox picPila08;
        private System.Windows.Forms.PictureBox picPila02;
        private System.Windows.Forms.PictureBox picPila12;
        private System.Windows.Forms.PictureBox picPila03;
        private System.Windows.Forms.PictureBox picPila05;
        private System.Windows.Forms.PictureBox picPila09;
        private System.Windows.Forms.PictureBox picPila06;
        private System.Windows.Forms.PictureBox picPila07;
        private System.Windows.Forms.PictureBox picPila13;
        private System.Windows.Forms.PictureBox picPila10;
        private System.Windows.Forms.PictureBox picPila11;
        private System.Windows.Forms.PictureBox picPila17;
        private System.Windows.Forms.PictureBox picPila28;
        private System.Windows.Forms.PictureBox picPila24;
        private System.Windows.Forms.PictureBox picPila27;
        private System.Windows.Forms.PictureBox picPila23;
        private System.Windows.Forms.PictureBox picPila26;
        private System.Windows.Forms.PictureBox picPila21;
        private System.Windows.Forms.PictureBox picPila25;
        private System.Windows.Forms.PictureBox picPila22;
        private System.Windows.Forms.PictureBox picPila18;
        private System.Windows.Forms.PictureBox picPila19;
        private System.Windows.Forms.PictureBox picPila20;
        private System.Windows.Forms.ImageList imageListPila;
        private System.Windows.Forms.ToolStripButton toolStripButton23;
        private System.Windows.Forms.Panel panelDescrip;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.PictureBox pictureBox11;
        public System.Windows.Forms.Panel panelMenu;
        public System.Windows.Forms.Button btnCerrarPanel;
        public System.Windows.Forms.ToolStripButton toolStripButton22;
        public System.Windows.Forms.SplitContainer splitContainerMapa;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ImageList imageListTruck;
        private System.Windows.Forms.Panel panelCam32;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.Label lblTablet32;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox picCamion32;
        private System.Windows.Forms.Label lblCam32;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label lblpBr32;
        private System.Windows.Forms.ProgressBar pBar32;
        private System.Windows.Forms.Panel panelCam31;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.Label lblTablet31;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox picCamion31;
        private System.Windows.Forms.Label lblCam31;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label lblpBr31;
        private System.Windows.Forms.ProgressBar pBar31;
        private System.Windows.Forms.Panel panelCam30;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblTablet30;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox picCamion30;
        private System.Windows.Forms.Label lblCam30;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label lblpBr30;
        private System.Windows.Forms.ProgressBar pBar30;
        private System.Windows.Forms.Panel panelCam29;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Label lblTablet29;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox picCamion29;
        private System.Windows.Forms.Label lblCam29;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label lblpBr29;
        private System.Windows.Forms.ProgressBar pBar29;
        private System.Windows.Forms.Panel panelCam36;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.Label lblTablet36;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.PictureBox picCamion36;
        private System.Windows.Forms.Label lblCam36;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label lblpBr36;
        private System.Windows.Forms.ProgressBar pBar36;
        private System.Windows.Forms.Panel panelCam35;
        private System.Windows.Forms.PictureBox pictureBox33;
        private System.Windows.Forms.Label lblTablet35;
        private System.Windows.Forms.PictureBox pictureBox34;
        private System.Windows.Forms.PictureBox pictureBox35;
        private System.Windows.Forms.PictureBox picCamion35;
        private System.Windows.Forms.Label lblCam35;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label lblpBr35;
        private System.Windows.Forms.ProgressBar pBar35;
        private System.Windows.Forms.Panel panelCam34;
        private System.Windows.Forms.PictureBox pictureBox37;
        private System.Windows.Forms.Label lblTablet34;
        private System.Windows.Forms.PictureBox pictureBox38;
        private System.Windows.Forms.PictureBox pictureBox39;
        private System.Windows.Forms.PictureBox picCamion34;
        private System.Windows.Forms.Label lblCam34;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label lblpBr34;
        private System.Windows.Forms.ProgressBar pBar34;
        private System.Windows.Forms.Panel panelCam33;
        private System.Windows.Forms.PictureBox pictureBox41;
        private System.Windows.Forms.Label lblTablet33;
        private System.Windows.Forms.PictureBox pictureBox42;
        private System.Windows.Forms.PictureBox pictureBox43;
        private System.Windows.Forms.PictureBox picCamion33;
        private System.Windows.Forms.Label lblCam33;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label lblpBr33;
        private System.Windows.Forms.ProgressBar pBar33;
        private System.Windows.Forms.PictureBox picCam36;
        private System.Windows.Forms.PictureBox picCam35;
        private System.Windows.Forms.PictureBox picCam34;
        private System.Windows.Forms.PictureBox picCam33;
        private System.Windows.Forms.PictureBox picCam32;
        private System.Windows.Forms.PictureBox picCam31;
        private System.Windows.Forms.PictureBox picCam30;
        private System.Windows.Forms.PictureBox picCam29;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox picGpsCam36;
        private System.Windows.Forms.PictureBox picRepCam36;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox picRepCam35;
        private System.Windows.Forms.PictureBox picGpsCam35;
        private System.Windows.Forms.PictureBox picGpsCam34;
        private System.Windows.Forms.PictureBox picGpsCam33;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.PictureBox picRepCam34;
        private System.Windows.Forms.PictureBox picRepCam33;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.PictureBox picGpsCam32;
        private System.Windows.Forms.PictureBox picRepCam32;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.PictureBox picRepCam31;
        private System.Windows.Forms.PictureBox picGpsCam31;
        private System.Windows.Forms.PictureBox picGpsCam30;
        private System.Windows.Forms.PictureBox picGpsCam29;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.PictureBox picRepCam30;
        private System.Windows.Forms.PictureBox picRepCam29;
        public System.Windows.Forms.Panel panelActCamiones;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Panel panelDescripciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label lblTotalCamAct;
        private System.Windows.Forms.Label lblTotalCamActConect;
        private System.Windows.Forms.Label lblTotalCamActDesConect;
        private System.Windows.Forms.ToolStripMenuItem dimensionesToolStripMenuItem;
        private System.Windows.Forms.Label lblpBc29;
        private System.Windows.Forms.Label lblpBc36;
        private System.Windows.Forms.Label lblpBc32;
        private System.Windows.Forms.Label lblpBc35;
        private System.Windows.Forms.Label lblpBc31;
        private System.Windows.Forms.Label lblpBc34;
        private System.Windows.Forms.Label lblpBc30;
        private System.Windows.Forms.Label lblpBc33;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDetalleStatus;
        private System.Windows.Forms.Label lblEtiquetaRutas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelReloj;
        private System.Windows.Forms.Timer timerClockMin;
        private System.Windows.Forms.Timer timerRepartos;
        private System.Windows.Forms.Panel panelIndicador01;
        private System.Windows.Forms.Panel panelIndicador02;
        private System.Windows.Forms.Label lblEtiquetaTaller;
        private System.Windows.Forms.Label lblDetalleStatusTaller;
        private System.Windows.Forms.Label lblDetalleCabSinServir;
        private System.Windows.Forms.Label lblEtiquetaConCabSinServir;
        public System.Windows.Forms.Label lblHoraMapa;
        private System.Windows.Forms.PictureBox picIndicador01;
        private System.Windows.Forms.Label lblEcologicosCorrrales;
        private System.Windows.Forms.Label lblClasicosCorrrales;
    }
}

