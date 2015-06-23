using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.IO;
using System.Text;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading;
using Murmurio.Data;

namespace Murmurio.Visual.Controles
{
    public partial class PedidosAmizade : System.Web.UI.UserControl
    {

        BaseDeDados dbClass = new BaseDeDados();
        public DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetUserFriendsRequest(int.Parse(Request.QueryString["Id"].ToString()));
            }
        }

        public void GetUserFriendsRequest(int Id)
        {
            string getFriendRequestQuery = "Select * FROM Usuario where IdUsuario IN (SELECT IdMeu as Id FROM Amigos WHERE IdAmigo='" + Id + "' AND StatusAmigo=0) ";
            dt = dbClass.ConnectDataBaseReturnDT(getFriendRequestQuery);
            if (dt.Rows.Count > 0)
            {
                ListaPedidosAmizade.DataSource = dt;
                ListaPedidosAmizade.DataBind();
            }
        }

        public string getHREF(object sURL)
        {
            DataRowView dRView = (DataRowView)sURL;
            string Id = dRView["IdUsuario"].ToString();
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



        protected void ListaPedidosAmizade_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (!object.Equals(Session["UsuarioID"], null))
            {
                if (e.CommandName == "Accept")
                {
                    string SenderFriendId = ((HtmlInputHidden)e.Item.FindControl("hiddenId")).Value;
                    string MyID = Session["UsuarioID"].ToString();
                    string AcceptFriendQuery = "Update Amigos set StatusAmigo=1 where IdMeu='" + SenderFriendId + "' AND IdAmigo='" + MyID + "'";
                    dbClass.ConnectDataBaseToInsert(AcceptFriendQuery);
                    Response.Redirect("Usuario.aspx?Id=" + Request.QueryString["Id"].ToString());
                }
                if (e.CommandName == "Deny")
                {
                    string SenderFriendId = ((HtmlInputHidden)e.Item.FindControl("hiddenId")).Value;
                    string MyID = Session["UsuarioID"].ToString();
                    string AcceptFriendQuery = "Update Amigos set StatusAmigo=NULL where IdMeu='" + SenderFriendId + "' AND IdAmigo='" + MyID + "'";
                    dbClass.ConnectDataBaseToInsert(AcceptFriendQuery);
                    Response.Redirect("Usuario.aspx?Id=" + Request.QueryString["Id"].ToString());
                }
            }
        }

    }
}