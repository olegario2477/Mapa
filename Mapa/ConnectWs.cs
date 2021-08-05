using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Serialization;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Mapa.getSAPData;


namespace Mapa
{
    class ConnectWs
    {

        private String operacion;
        private String catalogo;
        private ArrayList lectura = new ArrayList();
        private String usuario;
        private String contrasena;
        private String fechai;
        private String fechaf;
        private ArrayList mList = new ArrayList();
        private String errormsg;
        private String emsg;
        private String url;

        String SEPARATOR = ",";



        public ConnectWs(String operacion, String catalogo, String usuario, String contrasena, String fechai, String fechaf)
        {
            this.operacion = operacion;
            this.catalogo = catalogo;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.fechai = fechai;
            this.fechaf = fechaf;
        }

        public ConnectWs(String operacion, ArrayList lectura, String usuario, String contrasena, String fechai, String fechaf)
        {
            this.operacion = operacion;
            this.lectura = lectura;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.fechai = fechai;
            this.fechaf = fechaf;
        }

        public void connect()
        {

            NetworkCredential cred = new NetworkCredential();
            
            zwsdl_map zwsdl = new zwsdl_map();

            url = zwsdl.Url;

            ZWsMapa ZWsMapas_Input = new ZWsMapa();
            ZWsMapaResponse ZWsMapas_Response = new ZWsMapaResponse();
            
            cred.UserName = usuario;
            cred.Password = contrasena;
            zwsdl.PreAuthenticate = true;
            zwsdl.Credentials = cred;

            zwsdl.Timeout = 10 * 1000;

            ZstLineasMap[] lineasI = { };
            ZstLineasMap[] lineasE = { };

            errormsg = "";
            emsg = "";

            switch (operacion) {
                case Constants.OPERACION_CATALOGO:

                    ZWsMapas_Input.ICatalogo = catalogo;
                    ZWsMapas_Input.IFechai = fechai; //"2020-07-22";
                    ZWsMapas_Input.IFechaf = fechaf; //"2020-07-22";
                    ZWsMapas_Input.ICentroi = "2000";
                    ZWsMapas_Input.ICentrof = "2000";
                    ZWsMapas_Input.IAlmaceni = "1000";
                    ZWsMapas_Input.IAlmacenf = "1000";
                    ZWsMapas_Input.IOperacion = operacion;
                                        

                    try
                    {

                        ZWsMapas_Response = zwsdl.ZWsMapa(ZWsMapas_Input);
                        lineasE = ZWsMapas_Response.ETabla;
                        
                        mList = obtenerLista(lineasE);
                        emsg = ZWsMapas_Response.EMsg;
      
                    }
                    catch (IOException ex) {
                        errormsg = ex.Message;
                    }

                    catch (Exception ex2)
                    {
                        errormsg = ex2.Message;
                    }

                    break;

                //case Constants.OPERACION_TRANSFERIR:

                //    ZWsMapas_Input.ICatalogo = "_";
                //    ZWsMapas_Input.IFechai = "01.01.2020";
                //    ZWsMapas_Input.IOperacion = operacion;

                //    try
                //    {

                //        ZWsMapas_Response = zwsdl_Med.ZWsMapa(ZWsMapas_Input);
                //        //lineasE = ZWsMedicamentos_Response.ETabla;

                //        //mList = obtenerLista(lineasE);
                //        emsg = ZWsMapas_Response.EMsg;

                //    }
                //    catch (IOException ex)
                //    {
                //        errormsg = ex.Message;
                //    }

                //    catch (Exception ex2)
                //    {
                //        errormsg = ex2.Message;
                //    }

                //    break;

            }
                       

        }        

        private ArrayList obtenerLista(ZstLineasMap[] lineasE)
        {

            ArrayList lista = new ArrayList();
            
            foreach (ZstLineasMap linease in lineasE)
            {
                lista.Add(linease.Linea);
            }
            
            return lista;

        }

        public ZstLineasMap[] tableData(ArrayList lectura)
        {

            ZstLineasMap[] lineasI2 = new ZstLineasMap[lectura.Count];
           
            int index = 0;

            foreach (String cadena in lectura)
            {       
                ZstLineasMap lineasI3 = new ZstLineasMap();
                lineasI3.Linea = cadena;
                lineasI3.Linea2 = "";
                lineasI3.Col01 = "";
                lineasI3.Col02 = "1";
                lineasI3.Col03 = DateTime.Now.ToString("dd/mm/yyyy");
                lineasI3.Col04 = DateTime.Now.ToString("HH:mm");
                lineasI3.Col05 = "";
                lineasI3.Col06 = "";
                lineasI3.Col07 = "";
                lineasI3.Col08 = "";
                lineasI3.Col09 = "";
                lineasI3.Col10 = "";

                                             
                lineasI2[index] = lineasI3;
                index++;
            }
                        


            return lineasI2;

        }

        public ArrayList getList() { return mList; }
        public String getError() { return errormsg; }
        public String getEmsg() { return emsg; }
        public String getUrl() { return url; }

    }

}

    
