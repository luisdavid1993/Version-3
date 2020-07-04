using System;
using System.Globalization;

namespace usa.info
{
    public partial class hora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //this.LabelMenu.Text = menus.createMenuBootstrap("");
            mostrar();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {

            mostrar();


        }

        private void mostrar()
        {
            string data = mostrarAleatorio("");

            this.Label3.Text = data;
        }

        private string mostrarAleatorio(string nombre)
        {
            string data = "";

            string comillas = @"""";
            


            
            data = data + "<div class=" + comillas + "row" + comillas + "> ";
            
            DateTime dt = DateTime.Now.AddHours(-2);
            string date = dt.ToString("HH:mm:ss");           
            data = data + menus.CrearPanel("HORA Los Angeles", "<div class='grande'><center>" + date + "</center></div>");
            
            dt = DateTime.Now.AddHours(7);
            date = dt.ToString("HH:mm:ss");
            data = data + menus.CrearPanel("HORA Madrid", "<div class='grande'><center>" + date + "</center></div>");

            dt = DateTime.Now.AddHours(-1);
            date = dt.ToString("HH:mm:ss");
            data = data + menus.CrearPanel("HORA Costa Rica", "<div class='grande'><center>" + date + "</center></div>");
            

            dt = DateTime.Now.AddHours(2);
            date = dt.ToString("HH:mm:ss");
            data = data + menus.CrearPanel("HORA Argentina", "<div class='grande'><center>" + date + "</center></div>");

            dt = DateTime.Now.AddHours(1);
            date = dt.ToString("HH:mm:ss");
            data = data + menus.CrearPanel("HORA Miami", "<div class='grande'><center>" + date + "</center></div>");

            dt = DateTime.Now.AddHours(0);
            date = dt.ToString("HH:mm:ss");
            data = data + menus.CrearPanel("HORA Chicago", "<div class='grande'><center>" + date + "</center></div>");
            
            

            dt = DateTime.Now.AddHours(1);
            date = dt.ToString("HH:mm:ss");
            data = data + menus.CrearPanel("HORA Chile", "<div class='grande'><center>" + date + "</center></div>");



            data = data + "</div>";

            

            return data;


        }


        private string mostrarFormatos(string nombre)
        {
            string data = "";


            DateTime dt = DateTime.Now;
            string date = dt.ToString("T");

            
            // Create an array of all supported standard date and time format specifiers.
            string[] formats = {"d", "D", "f", "F", "g", "G", "m", "o", "r",
                          "s", "t", "T", "u", "U", "Y"};
            // Create an array of four cultures.                                 
            CultureInfo[] cultures = {CultureInfo.CreateSpecificCulture("de-DE"),
                                CultureInfo.CreateSpecificCulture("en-US"),
                                CultureInfo.CreateSpecificCulture("es-ES"),
                                CultureInfo.CreateSpecificCulture("fr-FR")};
            // Define date to be displayed.
            DateTime dateToDisplay = DateTime.Now; // DateTime(2008, 10, 1, 17, 4, 32);

            // Iterate each standard format specifier.
            foreach (string formatSpecifier in formats)
            {
                foreach (CultureInfo culture in cultures)
                {
                    data = data + "<div class='bajo'><center>" + dateToDisplay.ToString(formatSpecifier, culture) + "</center></div>";

                }
            }

            return data;


        }

    }
}