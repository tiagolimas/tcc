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
    public partial class Amigos : System.Web.UI.UserControl
    {

        BaseDeDados dbClass = new BaseDeDados();
        public DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["AmigoAcionado"] = null;
            
            if (!Page.IsPostBack)
            {
                GetUserFriends(int.Parse(Request.QueryString["Id"].ToString()));
            }

            
           // Session["AmigoAcionado"] = Request.QueryString["Id"].ToString();
        }

        public void GetUserFriends(int Id)
        {
            //string getFriendQuery = "Select * FROM [User] where Id IN (SELECT MyId as Id FROM Friends WHERE FriendId='" + Id + "' AND FriendStatus=1 UNION SELECT FriendId as Id FROM Friends WHERE MyId='" + Id + "' AND FriendStatus=1) ";
            string getFriendQuery = "Select * FROM [usuario] where IdUsuario IN (SELECT IdMeu as Id FROM amigos WHERE IdAmigo='" + Id + "' AND StatusAmigo=1 UNION SELECT IdAmigo as Id FROM amigos WHERE IdMeu='" + Id + "' AND StatusAmigo=1 ) ";
            dt = dbClass.ConnectDataBaseReturnDT(getFriendQuery);
            if (dt.Rows.Count > 0)
            {

                ListaAmigos.DataSource = dt;
                ListaAmigos.DataBind();
            }
        }

        public string getHREF(object sURL)
        {
            DataRowView dRView = (DataRowView)sURL;
            string Id = dRView["IdUsuario"].ToString();
            //return ResolveUrl("~/Usuario.aspx?Id=" + Id);

            //if (Session["AmigoID"] == null)
            //{
            //    Session["AmigoID"] = Id;
            //}

            return ResolveUrl("~/Usuario.aspx?Id=" + Id + "&AcessaAmigo=" + Session["AmigoID"]);
        }

        public string PegaId(object sURL)
        {
            DataRowView dRView = (DataRowView)sURL;
            string id = dRView["IdUsuario"].ToString();

            
            //Session["AmigoAcionado"] = Convert.ToInt32(Id);
            if (Session["AmigoAcionado"] == null)
            {
                Session["AmigoAcionado"] = id;
            }

            Session["idVideoAmigo"] = id;

            //string id = string.Empty;
            return id;
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