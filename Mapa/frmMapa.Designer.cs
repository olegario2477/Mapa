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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
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
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.planeadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cabezasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbFiltroVista = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.cmbColorCapas = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.hoyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFecha = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
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
            this.imageListColor = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lblHora = new System.Windows.Forms.ToolStripLabel();
            this.lblConectadoF = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lblServer = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.lblMandante = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.lblProveedor = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.lblDistancia = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.lblZomm = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.lblGiro = new System.Windows.Forms.ToolStripLabel();
            this.lblLatencia = new System.Windows.Forms.ToolStripLabel();
            this.lblip = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.lblInstancia = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.lblOrigenDatos = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.lblCorral = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.lblCoordenadas = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
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
            this.toolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTimer = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
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
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.dataGridVista = new System.Windows.Forms.DataGridView();
            this.labelLeyendas = new System.Windows.Forms.Label();
            this.timerPing = new System.Windows.Forms.Timer(this.components);
            this.panelCamiones = new System.Windows.Forms.Panel();
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
            this.picRepCam01 = new System.Windows.Forms.PictureBox();
            this.picCam14 = new System.Windows.Forms.PictureBox();
            this.picCam15 = new System.Windows.Forms.PictureBox();
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
            this.contextMenuStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam15)).BeginInit();
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
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.BackColor = System.Drawing.Color.Transparent;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.ContextMenuStrip = this.contextMenuStripMenu;
            this.gMapControl1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
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
            this.gMapControl1.Size = new System.Drawing.Size(1202, 488);
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
            this.trackBar1.BackColor = System.Drawing.Color.Gray;
            this.trackBar1.Location = new System.Drawing.Point(0, 20);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 15;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 185);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
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
            this.btnRotarIzq.Location = new System.Drawing.Point(63, 334);
            this.btnRotarIzq.Name = "btnRotarIzq";
            this.btnRotarIzq.Size = new System.Drawing.Size(50, 50);
            this.btnRotarIzq.TabIndex = 55;
            this.btnRotarIzq.UseVisualStyleBackColor = false;
            this.btnRotarIzq.Click += new System.EventHandler(this.btnRotarIzq_Click);
            // 
            // btnRotarDer
            // 
            this.btnRotarDer.BackColor = System.Drawing.Color.White;
            this.btnRotarDer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRotarDer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRotarDer.Image = ((System.Drawing.Image)(resources.GetObject("btnRotarDer.Image")));
            this.btnRotarDer.Location = new System.Drawing.Point(12, 334);
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
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton11,
            this.toolStripSeparator22,
            this.toolStripButton13,
            this.toolStripSplitButton1,
            this.toolStripLabel6,
            this.toolStripSplitButton2,
            this.toolStripLabel5,
            this.toolStripSplitButton3,
            this.cmbFiltroVista,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripButton5,
            this.cmbColorCapas,
            this.toolStripSeparator1,
            this.toolStripSplitButton4,
            this.txtFecha,
            this.toolStripButton10,
            this.toolStripSeparator4,
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
            this.toolStripButton15});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1170, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(24, 30);
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(6, 33);
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
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satelitalToolStripMenuItem,
            this.toolStripMenuItem1,
            this.relieveToolStripMenuItem});
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
            this.satelitalToolStripMenuItem.Name = "satelitalToolStripMenuItem";
            this.satelitalToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.satelitalToolStripMenuItem.Text = "Satelital";
            this.satelitalToolStripMenuItem.Click += new System.EventHandler(this.satelitalToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItem1.Text = "Normal";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // relieveToolStripMenuItem
            // 
            this.relieveToolStripMenuItem.Name = "relieveToolStripMenuItem";
            this.relieveToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.relieveToolStripMenuItem.Text = "Relieve";
            this.relieveToolStripMenuItem.Click += new System.EventHandler(this.relieveToolStripMenuItem_Click);
            // 
            // toolStripLabel6
            // 
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
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(69, 30);
            this.toolStripSplitButton2.Text = "Todo";
            this.toolStripSplitButton2.ButtonClick += new System.EventHandler(this.toolStripSplitButton2_ButtonClick);
            // 
            // todoToolStripMenuItem
            // 
            this.todoToolStripMenuItem.Name = "todoToolStripMenuItem";
            this.todoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.todoToolStripMenuItem.Text = "Todo";
            this.todoToolStripMenuItem.Click += new System.EventHandler(this.todoToolStripMenuItem_Click);
            // 
            // corralesToolStripMenuItem
            // 
            this.corralesToolStripMenuItem.Name = "corralesToolStripMenuItem";
            this.corralesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.corralesToolStripMenuItem.Text = "Clasicos";
            this.corralesToolStripMenuItem.Click += new System.EventHandler(this.corralesToolStripMenuItem_Click);
            // 
            // ecologicosToolStripMenuItem
            // 
            this.ecologicosToolStripMenuItem.Name = "ecologicosToolStripMenuItem";
            this.ecologicosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ecologicosToolStripMenuItem.Text = "Ecologicos";
            this.ecologicosToolStripMenuItem.Click += new System.EventHandler(this.ecologicosToolStripMenuItem_Click);
            // 
            // empacadoraToolStripMenuItem
            // 
            this.empacadoraToolStripMenuItem.Name = "empacadoraToolStripMenuItem";
            this.empacadoraToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.empacadoraToolStripMenuItem.Text = "Empacadora";
            this.empacadoraToolStripMenuItem.Visible = false;
            this.empacadoraToolStripMenuItem.Click += new System.EventHandler(this.empacadoraToolStripMenuItem_Click);
            // 
            // toolStripLabel5
            // 
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
            this.toolStripSeparator13,
            this.planeadoToolStripMenuItem,
            this.cabezasToolStripMenuItem});
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
            this.servidasToolStripMenuItem.Name = "servidasToolStripMenuItem";
            this.servidasToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.servidasToolStripMenuItem.Text = "Servido";
            this.servidasToolStripMenuItem.Click += new System.EventHandler(this.servidasToolStripMenuItem_Click);
            // 
            // racionToolStripMenuItem
            // 
            this.racionToolStripMenuItem.Name = "racionToolStripMenuItem";
            this.racionToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.racionToolStripMenuItem.Text = "Racion";
            this.racionToolStripMenuItem.Click += new System.EventHandler(this.racionToolStripMenuItem_Click);
            // 
            // camionToolStripMenuItem
            // 
            this.camionToolStripMenuItem.Name = "camionToolStripMenuItem";
            this.camionToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.camionToolStripMenuItem.Text = "Camion";
            this.camionToolStripMenuItem.Click += new System.EventHandler(this.camionToolStripMenuItem_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(120, 6);
            // 
            // planeadoToolStripMenuItem
            // 
            this.planeadoToolStripMenuItem.Name = "planeadoToolStripMenuItem";
            this.planeadoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.planeadoToolStripMenuItem.Text = "Planeado";
            this.planeadoToolStripMenuItem.Click += new System.EventHandler(this.planeadoToolStripMenuItem_Click);
            // 
            // cabezasToolStripMenuItem
            // 
            this.cabezasToolStripMenuItem.Name = "cabezasToolStripMenuItem";
            this.cabezasToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.cabezasToolStripMenuItem.Text = "Cabezas";
            this.cabezasToolStripMenuItem.Click += new System.EventHandler(this.cabezasToolStripMenuItem_Click);
            // 
            // cmbFiltroVista
            // 
            this.cmbFiltroVista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroVista.Name = "cmbFiltroVista";
            this.cmbFiltroVista.Size = new System.Drawing.Size(75, 33);
            this.cmbFiltroVista.Visible = false;
            this.cmbFiltroVista.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroVista_SelectedIndexChanged);
            this.cmbFiltroVista.Click += new System.EventHandler(this.cmbFiltroVista_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(95, 30);
            this.toolStripButton1.Text = "Ubicaciones";
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.Visible = false;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(63, 30);
            this.toolStripButton5.Text = "Capas";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click_1);
            // 
            // cmbColorCapas
            // 
            this.cmbColorCapas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorCapas.Name = "cmbColorCapas";
            this.cmbColorCapas.Size = new System.Drawing.Size(80, 33);
            this.cmbColorCapas.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoyToolStripMenuItem,
            this.fechaToolStripMenuItem});
            this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(45, 30);
            this.toolStripSplitButton4.Text = "Hoy";
            this.toolStripSplitButton4.ButtonClick += new System.EventHandler(this.toolStripSplitButton4_ButtonClick);
            // 
            // hoyToolStripMenuItem
            // 
            this.hoyToolStripMenuItem.Name = "hoyToolStripMenuItem";
            this.hoyToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.hoyToolStripMenuItem.Text = "Hoy";
            this.hoyToolStripMenuItem.Click += new System.EventHandler(this.hoyToolStripMenuItem_Click);
            // 
            // fechaToolStripMenuItem
            // 
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
            this.txtFecha.Size = new System.Drawing.Size(70, 33);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton3
            // 
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
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 30);
            this.toolStripLabel1.Text = "Corral";
            // 
            // txtBuscarUbicacion
            // 
            this.txtBuscarUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarUbicacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarUbicacion.MaxLength = 4;
            this.txtBuscarUbicacion.Name = "txtBuscarUbicacion";
            this.txtBuscarUbicacion.Size = new System.Drawing.Size(50, 33);
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
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(49, 30);
            this.toolStripLabel2.Text = "Camion";
            this.toolStripLabel2.Visible = false;
            // 
            // cmbCamiones
            // 
            this.cmbCamiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamiones.Name = "cmbCamiones";
            this.cmbCamiones.Size = new System.Drawing.Size(75, 23);
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
            this.toolStripButton4.Size = new System.Drawing.Size(62, 24);
            this.toolStripButton4.Text = "Clima";
            this.toolStripButton4.Visible = false;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // lblcmbCamionRuta
            // 
            this.lblcmbCamionRuta.Name = "lblcmbCamionRuta";
            this.lblcmbCamionRuta.Size = new System.Drawing.Size(49, 15);
            this.lblcmbCamionRuta.Text = "Camion";
            // 
            // cmbCamionRuta
            // 
            this.cmbCamionRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamionRuta.Name = "cmbCamionRuta";
            this.cmbCamionRuta.Size = new System.Drawing.Size(75, 23);
            // 
            // btnBuscarcamionruta
            // 
            this.btnBuscarcamionruta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscarcamionruta.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarcamionruta.Image")));
            this.btnBuscarcamionruta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscarcamionruta.Name = "btnBuscarcamionruta";
            this.btnBuscarcamionruta.Size = new System.Drawing.Size(24, 24);
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
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "Reparto";
            this.toolStripButton6.ToolTipText = "Recorrido";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click_1);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(28, 15);
            this.toolStripLabel8.Text = "GPS";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(24, 24);
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
            this.toolStripButton16.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton16.Text = "Repartos";
            this.toolStripButton16.Click += new System.EventHandler(this.toolStripButton16_Click);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(24, 24);
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
            this.toolStripButton14.Size = new System.Drawing.Size(24, 24);
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
            this.toolStripButton8.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton8.Text = "Cerrar";
            this.toolStripButton8.ToolTipText = "Cerrar Rutas";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(29, 15);
            this.toolStripLabel3.Text = "Serv";
            // 
            // cmbServidas
            // 
            this.cmbServidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServidas.DropDownWidth = 50;
            this.cmbServidas.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbServidas.Name = "cmbServidas";
            this.cmbServidas.Size = new System.Drawing.Size(75, 23);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(32, 15);
            this.toolStripLabel7.Text = "Cam";
            // 
            // cmbCamion
            // 
            this.cmbCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamion.Name = "cmbCamion";
            this.cmbCamion.Size = new System.Drawing.Size(75, 23);
            this.cmbCamion.SelectedIndexChanged += new System.EventHandler(this.cmbCamion_SelectedIndexChanged);
            this.cmbCamion.Click += new System.EventHandler(this.cmbCamion_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(26, 15);
            this.toolStripLabel4.Text = "Rac";
            // 
            // cmbRaciones
            // 
            this.cmbRaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // imageListColor
            // 
            this.imageListColor.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListColor.ImageStream")));
            this.imageListColor.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListColor.Images.SetKeyName(0, "rectángulo.png");
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHora,
            this.lblConectadoF,
            this.toolStripSeparator5,
            this.lblServer,
            this.toolStripSeparator16,
            this.lblMandante,
            this.toolStripSeparator14,
            this.lblProveedor,
            this.toolStripSeparator19,
            this.lblDistancia,
            this.toolStripSeparator6,
            this.lblZomm,
            this.toolStripSeparator12,
            this.lblGiro,
            this.lblLatencia,
            this.lblip,
            this.toolStripSeparator9,
            this.lblInstancia,
            this.toolStripSeparator10,
            this.lblOrigenDatos,
            this.toolStripSeparator11,
            this.lblCorral,
            this.toolStripSeparator18,
            this.lblCoordenadas,
            this.toolStripSeparator8,
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
            this.toolStripSeparator24,
            this.lblTimer,
            this.toolStripSeparator23});
            this.toolStrip2.Location = new System.Drawing.Point(0, 463);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1202, 25);
            this.toolStrip2.TabIndex = 70;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 22);
            this.lblHora.Text = "Hora";
            // 
            // lblConectadoF
            // 
            this.lblConectadoF.MarqueeAnimationSpeed = 1;
            this.lblConectadoF.Maximum = 1;
            this.lblConectadoF.Name = "lblConectadoF";
            this.lblConectadoF.Size = new System.Drawing.Size(10, 31);
            this.lblConectadoF.Visible = false;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // lblServer
            // 
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(39, 22);
            this.lblServer.Text = "Server";
            this.lblServer.Visible = false;
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator16.Visible = false;
            // 
            // lblMandante
            // 
            this.lblMandante.Name = "lblMandante";
            this.lblMandante.Size = new System.Drawing.Size(61, 22);
            this.lblMandante.Text = "Mandante";
            this.lblMandante.Visible = false;
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator14.Visible = false;
            // 
            // lblProveedor
            // 
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(86, 22);
            this.lblProveedor.Text = "toolStripLabel3";
            this.lblProveedor.Visible = false;
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator19.Visible = false;
            // 
            // lblDistancia
            // 
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(67, 22);
            this.lblDistancia.Text = "dist = 0 Km";
            this.lblDistancia.Visible = false;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator6.Visible = false;
            // 
            // lblZomm
            // 
            this.lblZomm.Name = "lblZomm";
            this.lblZomm.Size = new System.Drawing.Size(43, 22);
            this.lblZomm.Text = "Zomm";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator12.Visible = false;
            // 
            // lblGiro
            // 
            this.lblGiro.Name = "lblGiro";
            this.lblGiro.Size = new System.Drawing.Size(29, 22);
            this.lblGiro.Text = "Giro";
            this.lblGiro.Visible = false;
            // 
            // lblLatencia
            // 
            this.lblLatencia.Name = "lblLatencia";
            this.lblLatencia.Size = new System.Drawing.Size(51, 22);
            this.lblLatencia.Text = "Latencia";
            this.lblLatencia.Visible = false;
            // 
            // lblip
            // 
            this.lblip.Name = "lblip";
            this.lblip.Size = new System.Drawing.Size(17, 22);
            this.lblip.Text = "Ip";
            this.lblip.Visible = false;
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator9.Visible = false;
            // 
            // lblInstancia
            // 
            this.lblInstancia.Name = "lblInstancia";
            this.lblInstancia.Size = new System.Drawing.Size(54, 22);
            this.lblInstancia.Text = "Instancia";
            this.lblInstancia.Visible = false;
            this.lblInstancia.Click += new System.EventHandler(this.lblInstancia_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator10.Visible = false;
            // 
            // lblOrigenDatos
            // 
            this.lblOrigenDatos.Name = "lblOrigenDatos";
            this.lblOrigenDatos.Size = new System.Drawing.Size(71, 22);
            this.lblOrigenDatos.Text = "origenDatos";
            this.lblOrigenDatos.Visible = false;
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // lblCorral
            // 
            this.lblCorral.Name = "lblCorral";
            this.lblCorral.Size = new System.Drawing.Size(39, 22);
            this.lblCorral.Text = "Corral";
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(6, 25);
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(77, 22);
            this.lblCoordenadas.Text = "Coordenadas";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // lblErrores
            // 
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(43, 22);
            this.lblErrores.Text = "Errores";
            this.lblErrores.Visible = false;
            this.lblErrores.Click += new System.EventHandler(this.lblErrores_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator17.Visible = false;
            // 
            // lblCtrl
            // 
            this.lblCtrl.Name = "lblCtrl";
            this.lblCtrl.Size = new System.Drawing.Size(24, 22);
            this.lblCtrl.Text = "ctrl";
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator20.Visible = false;
            // 
            // btnPing
            // 
            this.btnPing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPing.Image = ((System.Drawing.Image)(resources.GetObject("btnPing.Image")));
            this.btnPing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(23, 22);
            this.btnPing.Text = "toolStripButton6";
            this.btnPing.ToolTipText = "\r\n";
            this.btnPing.Visible = false;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // lblPing
            // 
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(10, 22);
            this.lblPing.Text = ":";
            this.lblPing.Visible = false;
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator21.Visible = false;
            // 
            // lblDistanciaMin
            // 
            this.lblDistanciaMin.Name = "lblDistanciaMin";
            this.lblDistanciaMin.Size = new System.Drawing.Size(13, 22);
            this.lblDistanciaMin.Text = "0";
            this.lblDistanciaMin.Visible = false;
            // 
            // lblOrientacion
            // 
            this.lblOrientacion.Name = "lblOrientacion";
            this.lblOrientacion.Size = new System.Drawing.Size(13, 22);
            this.lblOrientacion.Text = "0";
            // 
            // lblAngulo
            // 
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(13, 22);
            this.lblAngulo.Text = "0";
            this.lblAngulo.Visible = false;
            // 
            // toolStripSeparator24
            // 
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            this.toolStripSeparator24.Size = new System.Drawing.Size(6, 25);
            // 
            // lblTimer
            // 
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(13, 22);
            this.lblTimer.Text = "0";
            // 
            // toolStripSeparator23
            // 
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            this.toolStripSeparator23.Size = new System.Drawing.Size(6, 25);
            // 
            // webBClima
            // 
            this.webBClima.Location = new System.Drawing.Point(145, 322);
            this.webBClima.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBClima.Name = "webBClima";
            this.webBClima.ScrollBarsEnabled = false;
            this.webBClima.Size = new System.Drawing.Size(143, 22);
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
            this.panelLeyenda.Location = new System.Drawing.Point(1016, 110);
            this.panelLeyenda.Name = "panelLeyenda";
            this.panelLeyenda.Size = new System.Drawing.Size(136, 234);
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
            this.panelTrack.Controls.Add(this.btnMax);
            this.panelTrack.Controls.Add(this.btnMin);
            this.panelTrack.Controls.Add(this.label15);
            this.panelTrack.Controls.Add(this.label14);
            this.panelTrack.Controls.Add(this.trackBar1);
            this.panelTrack.Location = new System.Drawing.Point(12, 84);
            this.panelTrack.Name = "panelTrack";
            this.panelTrack.Size = new System.Drawing.Size(32, 227);
            this.panelTrack.TabIndex = 79;
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(0, -2);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(32, 25);
            this.btnMax.TabIndex = 92;
            this.btnMax.Text = "+";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(-1, 202);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(33, 25);
            this.btnMin.TabIndex = 91;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "-";
            this.label15.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(14, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "+";
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
            this.tabControl1.Size = new System.Drawing.Size(1202, 25);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.pestanaOpcion);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1194, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor de Estado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1194, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monitor de Estado del Rancho [SAP]";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1194, 0);
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
            this.panelFecha.Location = new System.Drawing.Point(115, 95);
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
            this.chart2.BackColor = System.Drawing.SystemColors.Control;
            this.chart2.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Location = new System.Drawing.Point(400, 215);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(69, 83);
            this.chart2.TabIndex = 85;
            this.chart2.Text = "chart2";
            title1.Name = "Title1";
            title1.Text = "Grafico Servido %";
            this.chart2.Titles.Add(title1);
            this.chart2.Visible = false;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(400, 106);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series2.Name = "Series1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series3.Name = "Series2";
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(88, 107);
            this.chart1.TabIndex = 86;
            this.chart1.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Grafico Camion %";
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
            this.panelLeyendas.Controls.Add(this.dataGridVista);
            this.panelLeyendas.Controls.Add(this.labelLeyendas);
            this.panelLeyendas.Controls.Add(this.listBoxLeyendas);
            this.panelLeyendas.Location = new System.Drawing.Point(657, 110);
            this.panelLeyendas.Name = "panelLeyendas";
            this.panelLeyendas.Size = new System.Drawing.Size(134, 188);
            this.panelLeyendas.TabIndex = 88;
            // 
            // dataGridVista
            // 
            this.dataGridVista.AllowDrop = true;
            this.dataGridVista.AllowUserToAddRows = false;
            this.dataGridVista.AllowUserToDeleteRows = false;
            this.dataGridVista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridVista.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
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
            // 
            // labelLeyendas
            // 
            this.labelLeyendas.BackColor = System.Drawing.Color.Transparent;
            this.labelLeyendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLeyendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeyendas.Location = new System.Drawing.Point(0, 0);
            this.labelLeyendas.Name = "labelLeyendas";
            this.labelLeyendas.Size = new System.Drawing.Size(134, 25);
            this.labelLeyendas.TabIndex = 88;
            this.labelLeyendas.Text = "Servido";
            // 
            // timerPing
            // 
            this.timerPing.Interval = 5000;
            this.timerPing.Tick += new System.EventHandler(this.timerPing_Tick);
            // 
            // panelCamiones
            // 
            this.panelCamiones.BackColor = System.Drawing.Color.Transparent;
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
            this.panelCamiones.Controls.Add(this.picRepCam01);
            this.panelCamiones.Controls.Add(this.picCam14);
            this.panelCamiones.Controls.Add(this.picCam15);
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
            this.panelCamiones.Location = new System.Drawing.Point(345, 385);
            this.panelCamiones.Name = "panelCamiones";
            this.panelCamiones.Size = new System.Drawing.Size(469, 30);
            this.panelCamiones.TabIndex = 89;
            // 
            // picRepCam15
            // 
            this.picRepCam15.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam15.Location = new System.Drawing.Point(429, 0);
            this.picRepCam15.Name = "picRepCam15";
            this.picRepCam15.Size = new System.Drawing.Size(27, 6);
            this.picRepCam15.TabIndex = 101;
            this.picRepCam15.TabStop = false;
            // 
            // picRepCam14
            // 
            this.picRepCam14.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam14.Location = new System.Drawing.Point(399, 0);
            this.picRepCam14.Name = "picRepCam14";
            this.picRepCam14.Size = new System.Drawing.Size(27, 6);
            this.picRepCam14.TabIndex = 100;
            this.picRepCam14.TabStop = false;
            // 
            // picRepCam13
            // 
            this.picRepCam13.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam13.Location = new System.Drawing.Point(369, 0);
            this.picRepCam13.Name = "picRepCam13";
            this.picRepCam13.Size = new System.Drawing.Size(27, 6);
            this.picRepCam13.TabIndex = 99;
            this.picRepCam13.TabStop = false;
            // 
            // picRepCam12
            // 
            this.picRepCam12.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam12.Location = new System.Drawing.Point(339, 0);
            this.picRepCam12.Name = "picRepCam12";
            this.picRepCam12.Size = new System.Drawing.Size(27, 6);
            this.picRepCam12.TabIndex = 98;
            this.picRepCam12.TabStop = false;
            // 
            // picRepCam11
            // 
            this.picRepCam11.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam11.Location = new System.Drawing.Point(309, 0);
            this.picRepCam11.Name = "picRepCam11";
            this.picRepCam11.Size = new System.Drawing.Size(27, 6);
            this.picRepCam11.TabIndex = 97;
            this.picRepCam11.TabStop = false;
            // 
            // picRepCam08
            // 
            this.picRepCam08.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam08.Location = new System.Drawing.Point(219, 0);
            this.picRepCam08.Name = "picRepCam08";
            this.picRepCam08.Size = new System.Drawing.Size(27, 6);
            this.picRepCam08.TabIndex = 98;
            this.picRepCam08.TabStop = false;
            // 
            // picRepCam10
            // 
            this.picRepCam10.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam10.Location = new System.Drawing.Point(279, 0);
            this.picRepCam10.Name = "picRepCam10";
            this.picRepCam10.Size = new System.Drawing.Size(27, 6);
            this.picRepCam10.TabIndex = 96;
            this.picRepCam10.TabStop = false;
            // 
            // picRepCam07
            // 
            this.picRepCam07.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam07.Location = new System.Drawing.Point(189, 0);
            this.picRepCam07.Name = "picRepCam07";
            this.picRepCam07.Size = new System.Drawing.Size(27, 6);
            this.picRepCam07.TabIndex = 97;
            this.picRepCam07.TabStop = false;
            // 
            // picRepCam09
            // 
            this.picRepCam09.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam09.Location = new System.Drawing.Point(249, 0);
            this.picRepCam09.Name = "picRepCam09";
            this.picRepCam09.Size = new System.Drawing.Size(27, 6);
            this.picRepCam09.TabIndex = 95;
            this.picRepCam09.TabStop = false;
            // 
            // picRepCam06
            // 
            this.picRepCam06.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam06.Location = new System.Drawing.Point(159, 0);
            this.picRepCam06.Name = "picRepCam06";
            this.picRepCam06.Size = new System.Drawing.Size(27, 6);
            this.picRepCam06.TabIndex = 96;
            this.picRepCam06.TabStop = false;
            // 
            // picRepCam05
            // 
            this.picRepCam05.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam05.Location = new System.Drawing.Point(129, 0);
            this.picRepCam05.Name = "picRepCam05";
            this.picRepCam05.Size = new System.Drawing.Size(27, 6);
            this.picRepCam05.TabIndex = 95;
            this.picRepCam05.TabStop = false;
            // 
            // picRepCam04
            // 
            this.picRepCam04.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam04.Location = new System.Drawing.Point(99, 0);
            this.picRepCam04.Name = "picRepCam04";
            this.picRepCam04.Size = new System.Drawing.Size(27, 6);
            this.picRepCam04.TabIndex = 94;
            this.picRepCam04.TabStop = false;
            // 
            // picRepCam03
            // 
            this.picRepCam03.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam03.Location = new System.Drawing.Point(69, 0);
            this.picRepCam03.Name = "picRepCam03";
            this.picRepCam03.Size = new System.Drawing.Size(27, 6);
            this.picRepCam03.TabIndex = 93;
            this.picRepCam03.TabStop = false;
            // 
            // picRepCam02
            // 
            this.picRepCam02.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam02.Location = new System.Drawing.Point(39, 0);
            this.picRepCam02.Name = "picRepCam02";
            this.picRepCam02.Size = new System.Drawing.Size(27, 6);
            this.picRepCam02.TabIndex = 92;
            this.picRepCam02.TabStop = false;
            // 
            // picRepCam01
            // 
            this.picRepCam01.BackColor = System.Drawing.Color.Transparent;
            this.picRepCam01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRepCam01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepCam01.Location = new System.Drawing.Point(9, 0);
            this.picRepCam01.Name = "picRepCam01";
            this.picRepCam01.Size = new System.Drawing.Size(27, 6);
            this.picRepCam01.TabIndex = 91;
            this.picRepCam01.TabStop = false;
            // 
            // picCam14
            // 
            this.picCam14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam14.Image = ((System.Drawing.Image)(resources.GetObject("picCam14.Image")));
            this.picCam14.Location = new System.Drawing.Point(397, 4);
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
            this.picCam15.Location = new System.Drawing.Point(427, 4);
            this.picCam15.Name = "picCam15";
            this.picCam15.Size = new System.Drawing.Size(31, 24);
            this.picCam15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam15.TabIndex = 13;
            this.picCam15.TabStop = false;
            this.picCam15.Click += new System.EventHandler(this.picCam15_Click);
            // 
            // picCam13
            // 
            this.picCam13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCam13.Image = ((System.Drawing.Image)(resources.GetObject("picCam13.Image")));
            this.picCam13.Location = new System.Drawing.Point(367, 4);
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
            this.picCam11.Location = new System.Drawing.Point(307, 4);
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
            this.picCam12.Location = new System.Drawing.Point(337, 4);
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
            this.picCam10.Location = new System.Drawing.Point(277, 4);
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
            this.picCam08.Location = new System.Drawing.Point(217, 4);
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
            this.picCam09.Location = new System.Drawing.Point(247, 4);
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
            this.picCam07.Location = new System.Drawing.Point(187, 4);
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
            this.picCam04.Location = new System.Drawing.Point(97, 4);
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
            this.picCam06.Location = new System.Drawing.Point(157, 4);
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
            this.picCam02.Location = new System.Drawing.Point(37, 4);
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
            this.picCam03.Location = new System.Drawing.Point(67, 4);
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
            this.picCam05.Location = new System.Drawing.Point(127, 4);
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
            this.picCam01.Location = new System.Drawing.Point(7, 4);
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
            this.panelDetalles.Location = new System.Drawing.Point(836, 138);
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
            this.colorDialog1.AllowFullOpen = false;
            // 
            // frmMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 488);
            this.Controls.Add(this.panelDetalles);
            this.Controls.Add(this.panelCamiones);
            this.Controls.Add(this.panelLeyendas);
            this.Controls.Add(this.btnRotarIzq);
            this.Controls.Add(this.btnRotarDer);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.panelFecha);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelTrack);
            this.Controls.Add(this.panelLeyenda);
            this.Controls.Add(this.webBClima);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gMapControl1);
            this.MinimizeBox = false;
            this.Name = "frmMapa";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMapa_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMapa_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMapa_KeyPress);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStripMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.picRepCam01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam15)).EndInit();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem satelitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relieveToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem corralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecologicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtBuscarUbicacion;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ImageList imageListColor;
        private System.Windows.Forms.ToolStripComboBox cmbCamiones;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnBuscarcamionruta;
        private System.Windows.Forms.ToolStripMenuItem empacadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel lblCoordenadas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel lblDistancia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ubicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moverToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lblip;
        private System.Windows.Forms.ToolStripLabel lblLatencia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.WebBrowser webBClima;
        private System.Windows.Forms.ToolStripMenuItem marcadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
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
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.Panel panelTrack;
        private System.Windows.Forms.ToolStripMenuItem todoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripLabel lblInstancia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripLabel lblOrigenDatos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripLabel lblZomm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripComboBox cmbCamionRuta;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripLabel lblcmbCamionRuta;
        private System.Windows.Forms.ToolStripTextBox txtFecha;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnCerrarFecha;
        private System.Windows.Forms.Panel panelFecha;
        private System.Windows.Forms.Button btnActualizaFecha;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripLabel lblErrores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem servidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racionToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxLeyendas;
        private System.Windows.Forms.Panel panelLeyendas;
        private System.Windows.Forms.Label labelLeyendas;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripLabel lblServer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripLabel lblMandante;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripComboBox cmbColorCapas;
        private System.Windows.Forms.DataGridView dataGridVista;
        private System.Windows.Forms.ToolStripLabel lblCorral;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripMenuItem modifcarToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lblGiro;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripMenuItem camionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private System.Windows.Forms.ToolStripMenuItem hoyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem ajustarToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cmbFiltroVista;
        private System.Windows.Forms.ToolStripLabel lblProveedor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripLabel lblCtrl;
        private System.Windows.Forms.ToolStripMenuItem alinearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem planeadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
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
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripComboBox cmbServidas;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox cmbRaciones;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripComboBox cmbCamion;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripMenuItem buscarCoordenadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarCoordenadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCoordenadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cabezasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator22;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label labelDetalles;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        public System.Windows.Forms.ToolStripProgressBar lblConectadoF;
        private System.Windows.Forms.ToolStripMenuItem verOcultarCoordenadasCamionToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripLabel lblDistanciaMin;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.ToolStripLabel lblOrientacion;
        private System.Windows.Forms.ToolStripLabel lblAngulo;
        private System.Windows.Forms.ToolStripLabel lblHora;
        private System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.ToolStripLabel lblTimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator23;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator24;
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
    }
}

