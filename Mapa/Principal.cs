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
        public Principal()
        {
            InitializeComponent();
        }
        
        private void Principal_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " - Sistema Reparto Gusi - v" + Application.ProductVersion + " - " + bitModo();
            //abrirMapa(1);
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirMapa(1);
        }

        private void abrirMapa(int opc)
        {
            Form frm = new frmMapa(opc);
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.WindowsDefaultLocation;
            frm.Show();
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

        private void abrirConfiguracion()
        {
     

            Form frm = new frmConfiguracion();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.WindowsDefaultLocation;
            frm.Show();

            this.Refresh();

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
            Application.Exit();
        }

        private void cabezasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirMapa(2);
        }
    }
}
