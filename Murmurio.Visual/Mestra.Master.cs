using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Murmurio.Visual
{
    public partial class Mestra : System.Web.UI.MasterPage
    {

        public ContentPlaceHolder plch = new ContentPlaceHolder();


        protected void Page_Load(object sender, EventArgs e)
        {
           // ScriptManager.RegisterStartupScript(Page, GetType(), "JsStatus", "Video('alo');", true);
        }

        public void Recarrega(object sender, EventArgs e)
        {
           // Response.Redirect("Usuario.aspx?Id=" + Session["UsuarioID"].ToString());

             
        }


        /// <summary>
        /// Este método chama a função da index.js que envia as informações de videos para a Tubular.
        /// </summary>
        /// <param name="video"></param>
        public void ChamaVideo(string video)
        {
            ScriptManager.RegisterStartupScript(Page, GetType(), "JsStatus", "Video('alo');", true);
        }
     

    }
}