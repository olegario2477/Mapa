using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace Mapa
{
    public partial class frmConfiguracion : Form
    {

        private ArrayList lista = new ArrayList();
        private String seleccion = "";
        ConnectedWs connectar;

        String usuario = "";
        String contrasena = "";

        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            comboListaIntancia();

            cargarConfig();

            usuario = obtenerConfig(3);
            contrasena = obtenerConfig(4);

        }

        private void comboListaIntancia()
        {
            cmbInstancia.Items.Add("Internet");
            cmbInstancia.Items.Add("Internet y local");
            cmbInstancia.Items.Add("Local");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardaConfig();
            this.Visible = false;

        }

        private void guardaConfig()
        {

            string rutadestino = "";

            rutadestino = Application.StartupPath + "\\Config.txt";

            this.Cursor = Cursors.WaitCursor;

            try
            {
                //Open the File
                //StreamWriter objWriter = new StreamWriter(saveFileDialog1.FileName);
                StreamWriter objWriter = new StreamWriter(rutadestino);
                string lv_cadena =


                txtIP.Text + "|" +
                txtLatencia.Value + "|" +
                cmbInstancia.SelectedIndex + "|" +
                txtUsuario.Text + "|" +
                txtContrasena.Text + "|" +
                txtInactividad.Value;

                objWriter.WriteLine(lv_cadena);

                objWriter.Close();

                //MessageBox.Show("Listo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch (Exception)
            {
                //MessageBox.Show("El archivo no se puede guardar");
            }

            //timerLocaliza.Interval = Convert.ToInt32(txtLatencia.Value) * 1000;

            this.Cursor = Cursors.Default;


        }
        
        private void cargarConfig()
        {

            string rutaorigen = "";

            rutaorigen = Application.StartupPath + "\\Config.txt";

            this.Cursor = Cursors.WaitCursor;

            try
            {

                StreamReader objReader = new StreamReader(rutaorigen);
                string sLine = "";

                sLine = objReader.ReadLine();

                string[] lines = sLine.Split('|');

                
                txtIP.Text = lines[0].Trim();
                txtLatencia.Text = lines[1].Trim();
                cmbInstancia.SelectedIndex = Convert.ToInt32(lines[2].Trim());
                txtUsuario.Text = lines[3].Trim();
                txtContrasena.Text = lines[4].Trim();
                txtInactividad.Text = lines[5].Trim();

                objReader.Close();

                //MessageBox.Show("Listo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch (Exception)
            {
                //MessageBox.Show("El archivo no se puede leer");
            }

            this.Cursor = Cursors.Default;
                       
        }

        private string activoCheck(bool valor)
        {
            if (valor)
            {
                return "1";
            }
            else
            {
                return "0";
            }

        }

        private void btnUbicaciones_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            String msgerr = "";

            Cursor = Cursors.WaitCursor;

            if (MessageBox.Show("¿ Desea actualizar ubicaciones ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 

                leerWsdlUbicacion(ref dt, ref msgerr);

                if (dt.Rows.Count > 0)
                {

                    guardaUbicaciones(dt);
                    //consultaUbicaciones();
                    //cargarUbicaciones();

                    MessageBox.Show("Listo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    MessageBox.Show("No actualizo ninguna ubicacion " + msgerr, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            Cursor = Cursors.Default;

        }

        private void guardaUbicaciones(DataTable dtentrada)
        {

            Datos datos = new Datos();
            DataTable dt = new DataTable();

            //this.Cursor = Cursors.WaitCursor;

            datos.p_sql = "DELETE FROM ubicacion";

            if (!datos.consultaSQL(ref dt, true))
            {
                //MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(datos.p_error, "Mensaje");
            }


            List<string> dbOperations = new List<string>();

            foreach (DataRow row in dtentrada.Rows)
            {
                dbOperations.Add("insert into ubicacion (corral,latitud,longitud,latitud1,longitud1,latitud2,longitud2,latitud3,longitud3,latitud4,longitud4) values('" + row["corral"].ToString() + "', " + row["lat"].ToString() + "," + row["lng"].ToString() + "," + row["lat1"].ToString() + "," + row["lng1"].ToString() + "," + row["lat2"].ToString() + "," + row["lng2"].ToString() + "," + row["lat3"].ToString() + "," + row["lng3"].ToString() + "," + row["lat4"].ToString() + "," + row["lng4"].ToString() + ")");
            }


            datos.p_sql_list = dbOperations;

            if (!datos.consultaSQLs(ref dt))
            {
                //MessageBox.Show(datos.p_error, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(datos.p_error, "Mensaje");
            }
            else
            {

            }

            //this.Cursor = Cursors.Default;

        }

        private void leerWsdlUbicacion(ref DataTable dt, ref String msgerr)
        {

            //Cursor = Cursors.WaitCursor;

            seleccion = "ALMACENES";

            Thread t = new Thread(() => { cargarWSDLSel(seleccion, DateTime.Today, DateTime.Today); });
            t.Name = seleccion;
            t.IsBackground = true;
            t.Start();

            //while (t.IsAlive)
            //{
            //    Thread.Sleep(50);//50
            //    Application.DoEvents();
            //}

            t.Join();


            lista = connectar.getList();
            String errormsg = connectar.getError();
            String emsg = connectar.getEmsg();

            //if (!errormsg.Equals(""))
            //{
            //    MessageBox.Show(errormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //}


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
                //if (!errormsg.Equals(""))
                //{
                //    MessageBox.Show(errormsg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                //}
            }
            

        }


        private void cargarWSDLSel(String catalogo, DateTime fechai, DateTime fechaf)
        {

            connectar = new ConnectedWs(Constants.OPERACION_CATALOGO, catalogo, usuario, contrasena, fechai.ToString("yyyy-MM-dd"), fechaf.ToString("yyyy-MM-dd"));
            connectar.getDataWs();

        }


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




    }
}
