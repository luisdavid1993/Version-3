using System;


using streamingcpanel.Objects;
using streamingcpanel;
using streamingcpanel.DataAccess;


namespace usa.info.registro
{
    public partial class registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!this.IsPostBack)
                {

                    this.LabelCopyright.Text =  Constantes.COPYRIGHT;

                    System.Web.Security.FormsAuthentication.SignOut();
                    
                }



            }
            catch (Exception ex)
            {
                LabelCopyright.Text = ex.Message;
                string page = this.Request.Path.ToString().Trim();
                

            }

        }

        protected void LinkButtonSaveAccount_Click(object sender, EventArgs e)
        {
            try
            {

                UserData myUser = userPersonalData1.User_SetGetUserData;

                bool isNew = true;
                //decimal id = 0;
                //if (this.Request.QueryString["id"] != null)
                //{
                //    id = decimal.Parse(this.Request.QueryString["id"].ToString());
                //}

                decimal resellerID = 0;

                if (this.Request.QueryString["resellerID"] != null)
                {
                    resellerID = decimal.Parse(this.Request.QueryString["resellerID"].ToString());
                }

                if (resellerID == 0)
                {
                    myUser.User_EsGratis = 0;
                }

                string sPath = Constantes.PORTAL_URL + myUser.User_USerLogin + "\\";
                myUser.User_path = sPath;

                myUser.User_Alert = "** Usuario Nuevo, Registracion web";
                myUser.User_F_Expired = "1/1/2025";
                myUser.User_F_NextPayment = "1/1/2025";
                myUser.User_resellerID = resellerID;
                myUser.User_UserType = (int)enumUserType.Standar;
                myUser.User_UserState = 1;
                myUser.User_CRM = "2";

                streamingcpanel.DataAccess.DAUsers muDBUser = new streamingcpanel.DataAccess.DAUsers();
                myUser = muDBUser.SaveUser(myUser, isNew);
                muDBUser.cerrar();
            

                Response.Redirect("registroFinalizado.aspx?User="+ myUser.User_USerLogin, true);


            }
            catch (Exception ex)
            {
                this.LabelError.Text = "ERROR: " + ex.Message;
            }
        }
    }
}