using streamingcpanel;
using streamingcpanel.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace usa.info.dentro
{
    public partial class NotepadEditar : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                UserData user = ((BasePage)this.Page).Session_CurrentUserData;
                if (user == null)
                {
                    streamingcpanel.DataAccess.DAUsers muDBUser = new streamingcpanel.DataAccess.DAUsers();
                    user = muDBUser.GetOneUser(streamingcpanel.Constantes.USERFORDEFAULT);
                    muDBUser.cerrar();
                }

                string itemID = "";
                string tipo = "";
                string nota = "";
                if (this.Request.QueryString["tipo"] != null)
                {
                    //itemID = this.Request.QueryString["itemID"].ToString();
                    if (this.Request.QueryString["tipo"] != null)
                        tipo = this.Request.QueryString["tipo"].ToString();


                    if (tipo.Equals("Alertas"))
                    {
                        streamingcpanel.DataAccess.DAUsers muDBUser = new streamingcpanel.DataAccess.DAUsers();
                        nota = muDBUser.GetUserAlerta("1");
                        muDBUser.cerrar();
                        //this.UCTextBoxNotes.Text = nota;
                    }
                    if (tipo.Equals("Tareas"))
                    {
                        streamingcpanel.DataAccess.DANotas myDBSupp = new streamingcpanel.DataAccess.DANotas();
                        List<string> lstNotes = myDBSupp.traerNotasPorUsuario(user.User_ID);
                        myDBSupp.cerrar();
                        //this.UCTextBoxNotes.Text = nota;
                        if (lstNotes != null && lstNotes.Any())
                        {
                            string html = "<div class='col-sm-12 col-md-12 marginFromBoton row'>";
                            for (int i = 0; i < lstNotes.Count; i++)
                            {
                                html += "<div class='col-sm-6 col-md-5 divBoxNotes'> <span>" + lstNotes[i] + "</span> </div>";
                            }
                            html += "</div>";
                            LabeldinamicLabel.Text = html;
                        }
                        
                    }



                }
            }


        }


        protected void LinkButtonNewuser_Click(object sender, EventArgs e)
        {

            string itemID = "";
            string tipo = "";
            string nota = ""; //this.UCTextBoxNotes.Text;

            if (this.Request.QueryString["itemID"] != null)
            {
                itemID = this.Request.QueryString["itemID"].ToString();
                if (this.Request.QueryString["tipo"] != null)
                    tipo = this.Request.QueryString["tipo"].ToString();


                if (tipo.Equals("Alertas"))
                {
                    string query = "UPDATE G_Users SET Alerta = '" + nota + "' WHERE PK_ID = " + itemID;
                    streamingcpanel.DataAccess.ClassSQL mySQL = new streamingcpanel.DataAccess.ClassSQL();
                    mySQL.USER_RunDirectQuery(query);
                    mySQL.cerrar();
                }
                if (tipo.Equals("Tareas"))
                {
                    string query = "UPDATE G_Notas SET description = '" + nota + "' WHERE PK_ID = " + itemID;
                    streamingcpanel.DataAccess.ClassSQL mySQL = new streamingcpanel.DataAccess.ClassSQL();
                    mySQL.USER_RunDirectQuery(query);
                    mySQL.cerrar();

                    //streamingcpanel.DataAccess.DASupport myDBSupp = new streamingcpanel.DataAccess.DASupport();
                    //myDBSupp.salvarNota(itemID, nota);
                    //myDBSupp.cerrar();
                }

            }


        }
    }
}