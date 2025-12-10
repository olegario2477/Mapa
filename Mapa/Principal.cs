using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapa
{
    public partial class Principal : Form
    {
        string gnombre;
        bool vServidas =false;
        private Point _mouseLoc;

        public static Principal instance = null;

        public Principal()
        {
            instance = this;
            InitializeComponent();
        }
        
        private void Principal_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " - Sistema Reparto Gusi - v" + Application.ProductVersion + " - " + bitModo();
            //abrirMapa(1);
             cargarConfigDB();
        }

        private void Principal_Shown(object sender, EventArgs e)
        {            
            if (vServidas)
            {
                abrirMapa1(toolStripMenuItem1.Text);
                toolStripMenuItem2.Visible = true;
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //var itemText = (sender as ToolStripMenuItem).Text;
            //abrirMapa(1, itemText);
            abrirMapa1(toolStripMenuItem1.Text);
            
        }

        void abrirMapa1(string nombre)
        {
            var itemText = nombre; // (sender as ToolStripMenuItem).Text;
            abrirMapa(1, itemText);
        }


        private void abrirMapa(int opc, string nombre)
        {
            cerrarVentanas();

            Form frm = new frmMapa(opc, nombre);
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.WindowsDefaultLocation;
            frm.Show();

            //toolStripMenuItem2.Visible = true;
            toolStripMenuItem5.Visible = true;
            toolStripMenuItem7.Visible = true;
            toolStripMenuItem9.Visible = true;
            toolStripMenuItem10.Visible = true;
            toolStripMenuItem11.Visible = true;
            toolStripMenuItem14.Visible = true;

            if (opc == 1)
            {
                toolStripMenuItem6.Visible = true;
            }
            frmMapa.instance.btnCerrarPanel.Top = 0;

        }

        private void abrirMonitor()
        {
            //Form frm = new frmMonitor();
            //frm.MdiParent = this;
            //frm.StartPosition = FormStartPosition.WindowsDefaultLocation;
            //frm.Show();
        }

        private void abrirMonitorH()
        {
            //Form frm = new frmMonitorH();
            //frm.MdiParent = this;
            //frm.StartPosition = FormStartPosition.WindowsDefaultLocation;
            //frm.Show();
        }

        private String bitModo()
        {

            String valor = "";

            if (IntPtr.Size == 8)
            {
                valor = " 64 bits";
            }
            else if (IntPtr.Size == 4)
            {
                valor = " 32 bits";
            }

            return valor;
        }

        public void abrirConfiguracion()
        {
     

            Form frm = new frmConfiguracion();
            //frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.WindowsDefaultLocation;
            frm.ShowDialog();

           // this.Refresh();

        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirMonitor();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirConfiguracion();
        }

        private void monitorHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirMonitorH();
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirMonitor();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirMonitorH();
        }

        private void configuracionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            abrirConfiguracion();            
        }

        private void monitorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mosaicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir de la aplicacion?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cabezasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemText = (sender as ToolStripMenuItem).Text;
            abrirMapa(2, itemText);
        }

        private void aretesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemText = (sender as ToolStripMenuItem).Text;
            abrirMapa(3, itemText);
        }

        public void cerrarVentanas() 
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Principal")
                    Application.OpenForms[i].Close();
            }

            //toolStripMenuItem2.Visible = false;

        }

        private void cargarConfigDB()
        {

            try
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
                        vServidas = (Boolean)row["Servidas"];
                        toolStripMenuItem1.Visible = vServidas;

                        cabezasToolStripMenuItem.Visible = !vServidas;
                        aretesToolStripMenuItem.Visible = !vServidas;

                    }
                }
            }
            catch (Exception e)
            {

            }                                   

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            abrirConfiguracion();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmMapa.instance.fver2mapas();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmMapa.instance.toolStripButton22_Click(sender,e);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmMapa.instance.panelMenu.Visible = !frmMapa.instance.panelMenu.Visible;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmMapa.instance.fverPanelCamiones();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmMapa.instance.panelMenu.Visible = false;
            //frmMapa.instance.splitContainerMapa.Panel2Collapsed = true;
            //frmMapa.instance.panelActCamiones.Visible = false;
            frmMapa.instance.visPanelCamiones(false);
            frmMapa.instance.lblHoraMapa.Visible = true;

        }

        public void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void toolStripTextBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void toolStripTextBox2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmMapa.instance.giroDer();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmMapa.instance.verClasicos();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            frmMapa.instance.verEcologicos();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {            
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            frmMapa.instance.verHualul();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            frmMapa.instance.lblEtiquetaRutas_Click(sender, e);
        }
    }
}
