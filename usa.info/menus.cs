using streamingcpanel.DataAccess;


namespace usa.info
{
    public class menus
    {



        public static string CrearPanel( string titulo, string contenido)
        {
            string comillas = @"""";
            string data = "";

            data = data + "<div class=" + comillas + "col-sm-3" + comillas + "> ";

            data = data + "<div class=" + comillas + "panel panel-info" + comillas + ">";
            data = data + "                <div class=" + comillas + "panel-heading" + comillas + ">"+titulo+"</div>";
            data = data + "                <div class=" + comillas + "panel-body" + comillas + ">";
            data = data + contenido;
            data = data + "                </div>";
            data = data + "                <div class=" + comillas + "panel-footer" + comillas + "></div>";
            data = data + "            </div>";

            data = data + "            </div>";

            return data;
        }

        
        public static string createMenuBootstrap(UserData myUser)
        {
            string comillas = @"""";
            //JOSE TERMINADO; Aqui recibo myUser completo, no solo el nombre

            string html = "";

            html = html + "<nav class=" + comillas + "navbar navbar-inverse" + comillas + " style='border-radius:0px !important'>";
            html = html + "                <div class=" + comillas + "container-fluid" + comillas + ">";
            html = html + "                    <div class=" + comillas + "navbar-header" + comillas + ">";
            html = html + "                        <button type=" + comillas + "button" + comillas + " class=" + comillas + "navbar-toggle" + comillas + " data-toggle=" + comillas + "collapse" + comillas + " data-target=" + comillas + "#myNavbar" + comillas + ">";
            html = html + "                            <span class=" + comillas + "icon-bar" + comillas + "></span>";
            html = html + "                            <span class=" + comillas + "icon-bar" + comillas + "></span>";
            html = html + "                            <span class=" + comillas + "icon-bar" + comillas + "></span>";
            html = html + "                        </button>";
            html = html + "                    </div>";
            html = html + "                    <div class=" + comillas + "collapse navbar-collapse" + comillas + " id=" + comillas + "myNavbar" + comillas + ">";
            html = html + "                        <ul class=" + comillas + "nav navbar-nav" + comillas + ">";
            html = html + "                            <li class=" + comillas + "dropdown" + comillas + "><a class=" + comillas + "dropdown-toggle" + comillas + " data-toggle=" + comillas + "dropdown" + comillas + "> Usuario : " + myUser.User_USerLogin + "</a>";
            html = html + "                            </li>";

            if (myUser.User_ID== streamingcpanel.Constantes.USERFORDEFAULT)
            {
                //JOSE DO; Si es invitado, agregamos el menu login y registrar
                //para eso pasamos el parametro myUser: UserData user = ((BasePage)this.Page).Session_CurrentUserData;
                //y comprobamos el ID          
                //html = html + "                            <li><a href=" + comillas + "../entrar.aspx" + comillas + "</a>Entrar</li>";
                //html = html + "                            <li><a href=" + comillas + "../registrar.aspx" + comillas + "</a>Registrarse</li>";

            }




            //JOSE TERMINADO; Pasamos el parametro default.aspx?logout=1, desde el menu para borrar la cookie
            html = html + "                            <li><a href=" + comillas + "../Default.aspx?logout=1" + comillas + "</a>Salir</li>";
            //html = html + "                            <li><a href=" + comillas + "#" + comillas + ">Page 3</a></li>";
            html = html + "                        </ul>";
            html = html + "                    </div>";
            html = html + "                </div>";
            html = html + "            </nav>";
            return html;
        }



    }



}