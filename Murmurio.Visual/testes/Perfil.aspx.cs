using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Murmurio.Visual
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // ScriptManager.RegisterStartupScript(Page, GetType(), "JsStatus", "CortaCabeca();", true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //UpdatePanel1.Update();
            //Response.Redirect("Principal.aspx");

            //ScriptManager.RegisterStartupScript(Page, GetType(), "JsStatus", "ChamaLogon();", true);

            //Button1.Attributes.Add("onclick", "CortaCabeca();");
        }
    }
}