using System;


namespace streamingcpanel
{
    public class Constantes
    {

         public static string COPYRIGHT = "CP 2020";
        public static decimal USERFORDEFAULT = 2;



        public static string CNN_STRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=USAINFO;Integrated Security=True";
        public static string PORTAL_URL = "http://localhost:50791/"; // streamingcpanel.Objects.GetSetConfigWeb.GetSetting("PortalUrl");

        //JOSE Comentarios
        //Estos datos cambiarlos antes de compilar
        //JOSE Todo; Pasamos esto al confy.
        //public static string CNN_STRING = "User=sa;pwd=19Soler@19; initial catalog=USAINFO ;Data Source=USA1-WEB-ICE\\SQLEXPRESS";// + streamingcpanel.Objects.GetSetConfigWeb.GetSetting("dserver");
        //public static string PORTAL_URL = "http://usastreams.info/"; // streamingcpanel.Objects.GetSetConfigWeb.GetSetting("PortalUrl");


        public static string creatreIframeResponsive(string url)
        {



            string dimensiones = " width='100%' height='600px' ";
            string html = "<iframe name='cont' " + dimensiones + " marginwidth=0 marginheight=0 " +
                " hspace=0 vspace=0 frameborder=0 frameborder='no'  scrolling=no src='" + url + "' ></iframe>";
            return html;

        }
    }
}