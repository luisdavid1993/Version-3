using System;
using System.Web;


using streamingcpanel.Objects;
using streamingcpanel;
using streamingcpanel.DataAccess;


namespace usa.info
{

    public partial class Default : BasePage
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
               

                if (!this.IsPostBack)
                {

                    this.LabelCopyright.Text = Constantes.COPYRIGHT;
                    System.Web.Security.FormsAuthentication.SignOut();

                    
                    if (this.Request.QueryString["Logout"] == null)
                    {
                        HttpCookie myCookie1 = new HttpCookie("info.usastreams");
                        myCookie1 = Request.Cookies["info.usastreams"];
                        if (myCookie1 != null)
                        {
                            string userID = myCookie1.Value;
                            streamingcpanel.DataAccess.DAUsers muDBUser = new streamingcpanel.DataAccess.DAUsers();
                            UserData myUser = muDBUser.GetOneUser(decimal.Parse(userID));
                            muDBUser.cerrar();
                            string user = myUser.User_USerLogin;
                            string pas = myUser.User_UserPassword;
                            if (myUser.User_UserState == 1)
                                login(user, pas, "COOKIE");
                        }
                        else
                        {
                            //JOSE TERMINADO; Esto significa que no existe la cookie.
                            //Entonces cargamos al usuario default, lo grabamos en basePage y entramos logeados como invitado
                            // Al hacer login con este usuario, aparecera un menu nuevo de registrarse y login.
                            //Si le da registrarse, grabamos la cookie con su usuario y entramos.
                            //si le da login, le permite cambiar de usuario invitado a su usuario.

                            streamingcpanel.DataAccess.DAUsers muDBUser = new streamingcpanel.DataAccess.DAUsers();
                            UserData user = ((BasePage)this.Page).Session_CurrentUserData;
                            user = muDBUser.GetOneUser(streamingcpanel.Constantes.USERFORDEFAULT);
                            muDBUser.cerrar();
                            ((BasePage)this.Page).Session_CurrentUserData = user;
                            System.Web.Security.FormsAuthentication.SetAuthCookie(UCTextBoxUser.Text, false);
                            Response.Redirect(Constantes.PORTAL_URL + "dentro/Home.aspx", true);


                        }
                    }
                    else
                    {
                        //JOSE TERMINADO; Pasamos el parametro default.aspx?logout=1, desde el menu para borrar la cookie
                        if (this.Request.QueryString["DeleteCookie"] != null)
                        {
                            if (Request.Cookies["info.usastreams"] != null)
                            {
                                HttpCookie myCookie = new HttpCookie("info.usastreams");
                                myCookie.Expires = DateTime.Now.AddDays(-2);
                                Response.Cookies.Add(myCookie);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LabelCopyright.Text = ex.Message;


            }

        }

     
        private bool checkLicenseVersion2()
        {

            return true;

        }

        protected void LinkButtonLogin_Click(object sender, EventArgs e)
        {
            //JOSE TO-DO; En todos los sitios donde leamos entradas del usuario 
            //debemos comprobar la seguridad
            //string user = FilesTools.checkSQLInjection(UCTextBoxUser.Text);
            //string pas = FilesTools.checkSQLInjection(this.UCTextBoxPass.Text);

            string user = UCTextBoxUser.Text;
            string pas = UCTextBoxPass.Text;

            login(user, pas, "BOTON");

        }

        protected void login(string user, string pas, string loginTipo)
        {
            try
            {

                if (!checkLicenseVersion2())
                {
                    return;
                }



                if (user.Equals("") || pas.Equals(""))
                {
                    //Response.Write("<script>javascript:alert('Please enter user name and password');</script>");
                    LabelCopyright.Text = "Usuario y clave obligatorios";
                    return;
                }


                UserData myUser = new UserData();

                streamingcpanel.DataAccess.DAUsers muDBUser = new streamingcpanel.DataAccess.DAUsers();
                myUser = muDBUser.ValidUser(user.Trim(), pas.Trim());
                muDBUser.cerrar();




                
                if (CheckBoxRemember.Checked)
                {
                    HttpCookie myCookie = new HttpCookie("info.usastreams");
                    myCookie.Value = myUser.User_ID.ToString();
                    myCookie.Expires = DateTime.Now.AddMonths(3);
                    Response.Cookies.Add(myCookie);
                }




                if (myUser.User_UserType == (int)enumUserType.Standar)
                {
                    System.Web.Security.FormsAuthentication.SetAuthCookie(UCTextBoxUser.Text, false);
                    Response.Redirect(Constantes.PORTAL_URL + "dentro/Home.aspx", true);
                }

                //JOSE TO-DO; En un futuro crearemos administradores.
                //if (myUser.User_UserType == (int)enumUserType.Admin)
                //{
                //    System.Web.Security.FormsAuthentication.SetAuthCookie(UCTextBoxUser.Text, false);
                //    Response.Redirect(Constantes.PORTAL_URL + "cmsAdmin/home.aspx", true);
                //}

                return;

            }
            catch (Exception ex)
            {
                this.LabelCopyright.Text = "ERROR: " + ex.Message;
                
            }

        }


    }
}