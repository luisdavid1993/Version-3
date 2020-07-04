using System;

//using streamingcpanel.Objects;
using streamingcpanel.DataAccess;
using streamingcpanel;
using usa.info.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace usa.info.dentro
{
    public partial class home : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string data = "";
            

            try
            {
                if (!this.IsPostBack)
                {
                    UserData user = ((BasePage)this.Page).Session_CurrentUserData;
                    if (user == null)
                    {

                        //JOSE TODO;  
                        //El usuario no puede venir nulo, pues en default.aspx se carga el invitado si no hay cookie
                        //Se puede volver al login
                        //Response.Redirect(Constantes.PORTAL_URL + "../Default.aspx?logout=1", true);

                        //O bien 
                        //Se puede cargar el usuario default agregando el usuario a BasePage
                        streamingcpanel.DataAccess.DAUsers muDBUser = new streamingcpanel.DataAccess.DAUsers();
                        user = muDBUser.GetOneUser(streamingcpanel.Constantes.USERFORDEFAULT);
                        muDBUser.cerrar();
                        ((BasePage)this.Page).Session_CurrentUserData = user;
                    }


                    this.LabelMenu.Text = menus.createMenuBootstrap( user );
                  

                    DAModule daModulo = new DAModule();
                    List<DAModuleEntity> moduloEntityList = daModulo.traerModulosPorUsuarioyDefecto(user.User_ID);
                    daModulo.cerrar();
                    string moduleText = "";
                    if (moduloEntityList != null && moduloEntityList.Any()) {
                        for (int i = 0; i < moduloEntityList.Count; i++)
                        {
                            moduleText += PaintModule(moduloEntityList[i].Nombre, moduloEntityList[i].Imagen);
                        }
                    }

                    LabelInfoModule.Text = moduleText;
                }


            }
            catch (Exception ex)
            {
                data = ex.Message;
            }


            LabelDatos.Text = data;

        }

        public string PaintModule(string moduleName, string imagenBase64) {
            string moduleString = @"<a href = '#' >
                                      <div style = 'width: 95%; margin: 6px;'>
                                        <div class='panel panel-info' style='border-color: #bce8f1;'>
                                            <div class='panel-heading' style='background-color: #bce8f1; border-color: #bce8f1;text-align: center;'>
                                                <img src = '" + imagenBase64 + @"' style='width: 5em;height: 90px;'>
                                            </div>
                                            <div class='panel-body' style='border-color: #bce8f1;'>
                                                " + moduleName  + @"
                                            </div>
                                        </div>
                                      </div>
                                    </a>";

            return moduleString;
        }


    }
}