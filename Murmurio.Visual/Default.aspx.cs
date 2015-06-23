using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Murmurio.Visual
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ((Mestra)this.Master).ChamaVideo("asdf");
            
            //ScriptManager.RegisterStartupScript(Page, GetType(), "JsStatus", "Video('alo');", true);

        }

        public void TrocaFrame()
        {
            //((Mestra)this.Master).ChamaVideo("asdf");
            //ScriptManager.RegisterStartupScript(Page, GetType(), "JsStatus", "TrocaFrame();", true);
        }

    }
}