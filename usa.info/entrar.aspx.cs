using streamingcpanel;
using System;


namespace usa.info
{
    public partial class entrar : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                streamingcpanel.DataAccess.UserData myUser = ((BasePage)this.Page).Session_CurrentUserData;
                if (myUser == null)
                {
                    streamingcpanel.DataAccess.DAUsers muDBUser = new streamingcpanel.DataAccess.DAUsers();
                    myUser = muDBUser.GetOneUser(streamingcpanel.Constantes.USERFORDEFAULT);
                    muDBUser.cerrar();
                }

                string user = myUser.User_USerLogin;
                string pas = myUser.User_UserPassword;
                if (myUser.User_UserState == 1)
                {
                    Response.Redirect(streamingcpanel.Constantes.PORTAL_URL + "dentro/Home.aspx", true);
                }
                
            }
        }
    }
}