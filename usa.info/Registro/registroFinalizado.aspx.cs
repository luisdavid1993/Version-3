using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usa.info.Registro
{
    public partial class registroFinalizado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Request.QueryString["User"] != null)
            {
                this.LabelUser.Text = this.Request.QueryString["User"];
            }
            else {
                this.LabelUser.Text = "";
            }
           
        }
    }
}