using System;


//using streamingcpanel.Objects;
using streamingcpanel.DataAccess;
using streamingcpanel;


namespace usa.info
{
    public class BasePage : System.Web.UI.Page
    {
        private string SESSION_KEY_CURRENT_USERDATA = "SESSION_KEY_CURRENT_USERDATA";
        private string SESSION_KEY_CURRENT_SoUND = "SESSION_KEY_CURRENT_SoUND";
        //private string SESSION_KEY_CURRENT_Autorizacion = "SESSION_KEY_CURRENT_Autorizacion";

        public string Session_CurrentSound
        {
            get
            {
                if (this.Session[SESSION_KEY_CURRENT_SoUND] != null)
                {
                    string myUser = (string)this.Session[SESSION_KEY_CURRENT_SoUND];
                    return myUser;
                }
                else
                {
                    
                    return "";
                }
            }
            set { this.Session.Add(SESSION_KEY_CURRENT_SoUND, value); }
        }

        public UserData Session_CurrentUserData
        {
            get
            {
                if (this.Session[SESSION_KEY_CURRENT_USERDATA] != null)
                {
                    UserData myUser = (UserData)this.Session[SESSION_KEY_CURRENT_USERDATA];
                    return myUser;
                }
                else
                {
                    return null;
                }
            }
            set { this.Session.Add(SESSION_KEY_CURRENT_USERDATA, value); }
        }

        //public int Session_Autorizacion
        //{
        //    get
        //    {
        //        if (this.Session[SESSION_KEY_CURRENT_Autorizacion] != null)
        //        {
        //            int Autorizacion = (int)this.Session[SESSION_KEY_CURRENT_Autorizacion];
        //            return Autorizacion;
        //        }
        //        else
        //        {
        //            //Response.Redirect(Constantes.PORTAL_URL + "Default.aspx", true);
        //            return 0;
        //        }
        //    }
        //    set { this.Session.Add(SESSION_KEY_CURRENT_USERDATA, value); }
        //}
    }
}