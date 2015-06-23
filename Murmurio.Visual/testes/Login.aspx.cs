using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Murmurio.Visual
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // ScriptManager.RegisterStartupScript(Page, GetType(), "JsStatus", "CortaCabeca();", true);
            
        }

        protected void Autenticar(object sender, AuthenticateEventArgs e)
        {
            bool autenticado = false;
            //CheckBox chBox = (CheckBox)ctlLogin.FindControl("RememberMe");
            // Authenticated = UserAuthenticate(ctlLogin.UserName, ctlLogin.Password);
            autenticado = true;
            e.Authenticated = autenticado;
            //if (Authenticated == true)
            //{
            //    if (chBox.Checked == true)
            //    {
            //        Response.Cookies["RFriend_Email"].Value = ctlLogin.UserName;
            //        Response.Cookies["RFriend_PWD"].Value = ctlLogin.Password;
            //        Response.Cookies["RFriend_UID"].Value = Session["UserId"].ToString();
            //        Response.Cookies["RFriend_Email"].Expires = DateTime.Now.AddMonths(3);
            //        Response.Cookies["RFriend_PWD"].Expires = DateTime.Now.AddMonths(3);
            //        Response.Cookies["RFriend_UID"].Expires = DateTime.Now.AddMonths(3);
            //    }
            //    Response.Redirect("UserDetails.aspx?Id=" + Session["UserId"].ToString());
            //}

            ScriptManager.RegisterStartupScript(Page, GetType(), "JsStatus", "ChamaPerfil();", true);

        }
    }
}