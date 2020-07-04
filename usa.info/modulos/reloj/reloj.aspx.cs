using System;
using System.Globalization;


namespace usa.info
{
    public partial class reloj : System.Web.UI.Page
    {
        //private static bool router = true;
        private static int desf = 1;
        private static int tarea = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //this.LabelMenu.Text = menus.createMenuBootstrap("");
                mostrar();

                
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {

            mostrar();


        }

        private void mostrar()
        {
            string data = "";

            DateTime dt = DateTime.Now.AddHours(7);
            string DataHora = dt.ToString("HH:mm:ss");

            CultureInfo culture = new CultureInfo("es-ES");
            string DataFecha = dt.ToString("f", culture);

            data = data + "<div><center><h1>" + DataFecha + "</h1></center></div>";
            data = data + "<div class='grande'><center>Madrid: " + DataHora + "</center></div>";

            dt = DateTime.Now.AddHours(-1);
            DataHora = dt.ToString("HH:mm:ss");            
            DataFecha = dt.ToString("f", culture);
            data = data + "<div><center><h1>" + DataFecha + "</h1></center></div>";
            data = data + "<div class='grande'><center>San Jose: " + DataHora + "</center></div>";

            



            this.Label3.Text = data;
        }
       
        private string mostrarAleatorio(string nombre)
        {
            string data = "";



            Random rnd = new Random();
            int usado1 = rnd.Next(20, 25);
            int usado2 = rnd.Next(40, 45);
            int usado3 = rnd.Next(60, 65);

            int total = usado3;

            int hora = DateTime.Now.Hour;
            if (hora < 10)
            {
                total = usado1;
            }
            else
            {
                if (hora < 14) total = usado2;
            }



            data = data + "<div><center><h1>En este momento</h1></center></div>";
            data = data + "<div class='grande'><center>" + total.ToString() + "</center></div>";
            data = data + "<div><center>Usuarios activos en: " + nombre + "</center></div>";
            int usa1 = rnd.Next(20, 25);
            int usa2 = rnd.Next(20, 30);
            int usaTmp = usa1 + usa2;
            int usa3 = 100 - usaTmp;
            data = data + "<div><center>Web...: <progress value='" + usa1.ToString() + "' max='100'></progress></center></div>";
            data = data + "<div><center>App...: <progress value='" + usa2.ToString() + "' max='100'></progress></center></div>";
            data = data + "<div><center>Rozila: <progress value='" + usa3.ToString() + "' max='100'></progress></center></div>";



            return data;
        }

        private string mostrarGraficos(string cnn)
        {
            string data = "";

            if (cnn.Equals("0"))
            {
                data = data + "<div><center>PC....: <progress value='0' max='100'></progress></center></div>";
                data = data + "<div><center>Mobil: <progress value='0' max='100'></progress></center></div>";
            }
            else if (cnn.Equals("1"))
            {
                data = data + "<div><center>PC....: <progress value='100' max='100'></progress></center></div>";
                data = data + "<div><center>Mobil: <progress value='0' max='100'></progress></center></div>";
            }
            else if (cnn.Equals("2"))
            {
                data = data + "<div><center>PC....: <progress value='50' max='100'></progress></center></div>";
                data = data + "<div><center>Mobil: <progress value='50' max='100'></progress></center></div>";
            }
            else
            {
                data = data + "<div><center>PC....: <progress value='30' max='100'></progress></center></div>";
                data = data + "<div><center>Mobil: <progress value='70' max='100'></progress></center></div>";
            }

            Random rnd = new Random();
            int usa1 = rnd.Next(5, 20);
            data = data + "<div><center>Red...: <progress value='" + usa1.ToString() + "' max='100'></progress></center></div>";


     

            return data;
        }


        
    }
}