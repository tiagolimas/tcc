using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Murmurio.Data;

namespace Murmurio.Visual.Controles
{
    public partial class MsgUsuario : System.Web.UI.UserControl
    {
        BaseDeDados dbClass = new BaseDeDados();
        public DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetMensagensUsuario(int.Parse(Request.QueryString["Id"].ToString()));
            }
        }

        public void GetMensagensUsuario(int Id)
        {
            string getUserScraps = "SELECT u.IdUsuario as UserId,u.NomeUsuario,u.Imagem,s.IdOrigem,s.IdDestino,s.Mensagem,s.DataEnvio,s.IdMensagem as ScrapId FROM Usuario as u, Mensagem as s WHERE u.IdUsuario=s.IdOrigem AND s.IdDestino='" + Request.QueryString["Id"].ToString() + "'";
            dt = dbClass.ConnectDataBaseReturnDT(getUserScraps);
            if (dt.Rows.Count > 0)
            {
                GridViewUserScraps.DataSource = dt;
                GridViewUserScraps.DataBind();
            }
        }

        public string getHREF(object sURL)
        {
            DataRowView dRView = (DataRowView)sURL;
            string Id = dRView["UserId"].ToString();
            return ResolveUrl("~/Usuario.aspx?Id=" + Id);
        }

        public string getSRC(object imgSRC)
        {
            DataRowView dRView = (DataRowView)imgSRC;
            string ImageName = dRView["Imagem"].ToString();
            if (ImageName == "NoImage")
            {
                return ResolveUrl(@"~/media/Perfis/missing.jpg");
            }
            else
            {
                return ResolveUrl("~/media/Perfis/" + dRView["Imagem"].ToString());

            }
        }
    }
}