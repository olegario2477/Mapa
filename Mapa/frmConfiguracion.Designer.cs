namespace Mapa
{
    partial class frmConfiguracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtLatencia = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbInstancia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInactividad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUbicaciones = new System.Windows.Forms.Button();
            this.btnWS = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtRutaRed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnRecursos = new System.Windows.Forms.Button();
            this.dataGridSQLResultados = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSQLStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMandante = new System.Windows.Forms.TextBox();
            this.chkServidas = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelSQL = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtVerifica = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtLatencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInactividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSQLResultados)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(204, 38);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(236, 30);
            this.txtIP.TabIndex = 75;
            this.txtIP.Text = "0.0.0.0";
            this.txtIP.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(30, 43);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 25);
            this.label20.TabIndex = 76;
            this.label20.Text = "IP Ws";
            this.label20.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(1126, 623);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 49);
            this.btnCerrar.TabIndex = 78;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(1008, 623);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 49);
            this.btnGuardar.TabIndex = 77;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(372, 312);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 25);
            this.label21.TabIndex = 83;
            this.label21.Text = "Segundos";
            // 
            // txtLatencia
            // 
            this.txtLatencia.Location = new System.Drawing.Point(204, 308);
            this.txtLatencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLatencia.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtLatencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtLatencia.Name = "txtLatencia";
            this.txtLatencia.ReadOnly = true;
            this.txtLatencia.Size = new System.Drawing.Size(144, 26);
            this.txtLatencia.TabIndex = 82;
            this.txtLatencia.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(30, 309);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 25);
            this.label22.TabIndex = 81;
            this.label22.Text = "Latencia";
            // 
            // cmbInstancia
            // 
            this.cmbInstancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstancia.FormattingEnabled = true;
            this.cmbInstancia.Location = new System.Drawing.Point(204, 348);
            this.cmbInstancia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbInstancia.Name = "cmbInstancia";
            this.cmbInstancia.Size = new System.Drawing.Size(180, 28);
            this.cmbInstancia.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 89;
            this.label1.Text = "Instancia";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(204, 83);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(236, 30);
            this.txtUsuario.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 91;
            this.label2.Text = "Usuario";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(204, 128);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(236, 30);
            this.txtContrasena.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 394);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 96;
            this.label4.Text = "Minutos";
            // 
            // txtInactividad
            // 
            this.txtInactividad.Location = new System.Drawing.Point(204, 389);
            this.txtInactividad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInactividad.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtInactividad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtInactividad.Name = "txtInactividad";
            this.txtInactividad.ReadOnly = true;
            this.txtInactividad.Size = new System.Drawing.Size(144, 26);
            this.txtInactividad.TabIndex = 95;
            this.txtInactividad.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 391);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 94;
            this.label5.Text = "Inactividad";
            // 
            // btnUbicaciones
            // 
            this.btnUbicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbicaciones.Location = new System.Drawing.Point(45, 205);
            this.btnUbicaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUbicaciones.Name = "btnUbicaciones";
            this.btnUbicaciones.Size = new System.Drawing.Size(244, 151);
            this.btnUbicaciones.TabIndex = 97;
            this.btnUbicaciones.Text = "Traer Ubicaciones";
            this.btnUbicaciones.UseVisualStyleBackColor = true;
            this.btnUbicaciones.Click += new System.EventHandler(this.btnUbicaciones_Click);
            // 
            // btnWS
            // 
            this.btnWS.Location = new System.Drawing.Point(12, 520);
            this.btnWS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWS.Name = "btnWS";
            this.btnWS.Size = new System.Drawing.Size(62, 51);
            this.btnWS.TabIndex = 99;
            this.btnWS.Text = "WS";
            this.btnWS.UseVisualStyleBackColor = true;
            this.btnWS.Visible = false;
            this.btnWS.Click += new System.EventHandler(this.btnWS_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(27, 200);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(240, 148);
            this.btnActualizar.TabIndex = 100;
            this.btnActualizar.Text = "Actualizacion App";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtRutaRed
            // 
            this.txtRutaRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaRed.Location = new System.Drawing.Point(204, 263);
            this.txtRutaRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRutaRed.Name = "txtRutaRed";
            this.txtRutaRed.Size = new System.Drawing.Size(512, 30);
            this.txtRutaRed.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 102;
            this.label7.Text = "Ruta Red";
            // 
            // txtSQL
            // 
            this.txtSQL.AllowDrop = true;
            this.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQL.Location = new System.Drawing.Point(0, 0);
            this.txtSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSQL.Size = new System.Drawing.Size(1042, 359);
            this.txtSQL.TabIndex = 103;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(1071, 60);
            this.btnEjecutar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(156, 82);
            this.btnEjecutar.TabIndex = 104;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnRecursos
            // 
            this.btnRecursos.Location = new System.Drawing.Point(1071, 174);
            this.btnRecursos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecursos.Name = "btnRecursos";
            this.btnRecursos.Size = new System.Drawing.Size(156, 82);
            this.btnRecursos.TabIndex = 105;
            this.btnRecursos.Text = "Consultas Recursos";
            this.btnRecursos.UseVisualStyleBackColor = true;
            this.btnRecursos.Click += new System.EventHandler(this.btnRecursos_Click);
            // 
            // dataGridSQLResultados
            // 
            this.dataGridSQLResultados.AllowDrop = true;
            this.dataGridSQLResultados.AllowUserToAddRows = false;
            this.dataGridSQLResultados.AllowUserToDeleteRows = false;
            this.dataGridSQLResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSQLResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSQLResultados.Location = new System.Drawing.Point(0, 0);
            this.dataGridSQLResultados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridSQLResultados.Name = "dataGridSQLResultados";
            this.dataGridSQLResultados.ReadOnly = true;
            this.dataGridSQLResultados.RowHeadersWidth = 70;
            this.dataGridSQLResultados.RowTemplate.Height = 35;
            this.dataGridSQLResultados.Size = new System.Drawing.Size(1042, 180);
            this.dataGridSQLResultados.TabIndex = 106;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSQLStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 180);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1042, 32);
            this.statusStrip1.TabIndex = 107;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSQLStatus
            // 
            this.lblSQLStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSQLStatus.Name = "lblSQLStatus";
            this.lblSQLStatus.Size = new System.Drawing.Size(24, 25);
            this.lblSQLStatus.Text = "...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1251, 620);
            this.tabControl1.TabIndex = 108;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtServer);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtMandante);
            this.tabPage1.Controls.Add(this.chkServidas);
            this.tabPage1.Controls.Add(this.txtIP);
            this.tabPage1.Controls.Add(this.btnWS);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.txtLatencia);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.cmbInstancia);
            this.tabPage1.Controls.Add(this.txtRutaRed);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtUsuario);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtContrasena);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtInactividad);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1243, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 107;
            this.label8.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Enabled = false;
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(204, 218);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(236, 30);
            this.txtServer.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 105;
            this.label6.Text = "Mandante";
            // 
            // txtMandante
            // 
            this.txtMandante.Enabled = false;
            this.txtMandante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMandante.Location = new System.Drawing.Point(204, 172);
            this.txtMandante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMandante.Name = "txtMandante";
            this.txtMandante.Size = new System.Drawing.Size(236, 30);
            this.txtMandante.TabIndex = 104;
            // 
            // chkServidas
            // 
            this.chkServidas.AutoSize = true;
            this.chkServidas.Location = new System.Drawing.Point(204, 449);
            this.chkServidas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkServidas.Name = "chkServidas";
            this.chkServidas.Size = new System.Drawing.Size(125, 24);
            this.chkServidas.TabIndex = 103;
            this.chkServidas.Text = "Ver Servidas";
            this.chkServidas.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panelSQL);
            this.tabPage2.Controls.Add(this.btnEjecutar);
            this.tabPage2.Controls.Add(this.btnRecursos);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1243, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SQL";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panelSQL
            // 
            this.panelSQL.Controls.Add(this.splitContainer1);
            this.panelSQL.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSQL.Location = new System.Drawing.Point(4, 5);
            this.panelSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSQL.Name = "panelSQL";
            this.panelSQL.Size = new System.Drawing.Size(1042, 577);
            this.panelSQL.TabIndex = 108;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtSQL);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridSQLResultados);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1042, 577);
            this.splitContainer1.SplitterDistance = 359;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.btnUbicaciones);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(1243, 587);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Zonas";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.txtVerifica);
            this.tabPage4.Controls.Add(this.btnVerifica);
            this.tabPage4.Controls.Add(this.btnActualizar);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Size = new System.Drawing.Size(1243, 587);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mtto";
            // 
            // txtVerifica
            // 
            this.txtVerifica.Enabled = false;
            this.txtVerifica.Location = new System.Drawing.Point(303, 511);
            this.txtVerifica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVerifica.Multiline = true;
            this.txtVerifica.Name = "txtVerifica";
            this.txtVerifica.Size = new System.Drawing.Size(523, 41);
            this.txtVerifica.TabIndex = 102;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifica.Location = new System.Drawing.Point(27, 511);
            this.btnVerifica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(267, 43);
            this.btnVerifica.TabIndex = 101;
            this.btnVerifica.Text = "Version Windows";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 678);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLatencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInactividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSQLResultados)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelSQL.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown txtLatencia;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbInstancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtInactividad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUbicaciones;
        private System.Windows.Forms.Button btnWS;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtRutaRed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnRecursos;
        private System.Windows.Forms.DataGridView dataGridSQLResultados;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSQLStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panelSQL;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chkServidas;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.TextBox txtVerifica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMandante;
    }
}