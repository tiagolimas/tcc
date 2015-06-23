using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Murmurio.Data;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;

namespace Murmurio.Visual
{
    public partial class Usuario1 : System.Web.UI.Page
    {
        BaseDeDados dbClass = new BaseDeDados();
        public DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                Session["AmigoAcionado"] = null;
            }

            //string[,] infoVideos = new string[30,3];
            //infoVideos[0, 0] = "fCeeLnQP0ls";
            //infoVideos[0, 1] = "Usuario 1";
            //infoVideos[0, 2] = " - Video 1";
            //infoVideos[1, 0] = "S9lRdmfCw3I";
            //infoVideos[1, 1] = "Usuario 2";
            //infoVideos[1, 2] = " - Video 2";

            //string serializedinfoVideos = (new JavaScriptSerializer()).Serialize(infoVideos);

            if (Session["AmigoAcionado"] != null)
            {
                VideosAmigos(int.Parse(Request.QueryString["Id"].ToString()));
                //ScriptManager.RegisterStartupScript(Page, GetType(), "JsStatus", "recarregaPagina(" + serializedinfoVideos + ");", true);
            }
           
            DadosUsuario(int.Parse(Request.QueryString["Id"].ToString()));

            if (!object.Equals(Session["UsuarioID"], null))
            {
                if (object.Equals(Session["UsuarioID"], Request.QueryString["Id"]))
                {
                    PedidosAmizade.Visible = true;
                }
                else
                {
                    PedidosAmizade.Visible = false;
                }
            }
        }

        public void DadosUsuario(int id)
        {
            //string getUserDetail = "Select ID,Email,Name,Country,Convert(varchar (20), RegisterDate, 106) RegisterDate,Convert(varchar (20), LastLogin, 106) LastLogin ,Description,ImageName FROM [User] where Id='" + id + "'";

            string pegaUsuario = @"select  IdUsuario, 
		                                    NomeUsuario,
		                                    Imagem,
		                                    Senha,
		                                    Email,
		                                    Descricao,
		                                    CidadeAtual
                                    from dbo.Usuario
                                    where IdUsuario = '" + id + "'";

            dt = dbClass.ConnectDataBaseReturnDT(pegaUsuario);
            if (dt.Rows.Count > 0)
            {
                LblNomeUsuario.Text = dt.Rows[0]["NomeUsuario"].ToString();
                ImagemUsuario.ImageUrl = "~/media/Perfis/" + dt.Rows[0]["Imagem"].ToString();
                //ImageUrl="~/media/Perfis/will.jpg"
                //UserImage.ImageUrl = "~/UserImage/" + dt.Rows[0]["ImageName"].ToString();
                //lblCreated.Text = dt.Rows[0]["RegisterDate"].ToString();
                //LabelLastLogin.Text = dt.Rows[0]["LastLogin"].ToString();
                //lblCreated.Text = dt.Rows[0]["RegisterDate"].ToString();
                //LabelAboutMe.Text = dt.Rows[0]["Description"].ToString();
            }
        }


        protected void AddAmigo_Click(object sender, EventArgs e)
        {
            if (!object.Equals(Session["UsuarioID"], null))
            {
                if (Object.Equals(Session["UsuarioID"], Request.QueryString["IdUsuario"]))
                {
                    lblErro.Text = "Seu perfil";
                    lblErro.Visible = true;
                }
                else
                {
                    string chkfriendRequest = "SELECT * FROM Amigos WHERE (IdMeu='" + Session["UsuarioID"].ToString() + "' and IdAmigo='" + Request.QueryString["Id"].ToString() + "') OR (IdMeu='" + Request.QueryString["Id"].ToString() + "' and IdAmigo='" + Session["UsuarioID"].ToString() + "')";
                    DataTable dt1 = new DataTable();
                    dt1 = dbClass.ConnectDataBaseReturnDT(chkfriendRequest);
                    if (dt1.Rows.Count > 0)
                    {
                        if (dt1.Rows[0]["StatusAmigo"].ToString() == "True")
                        {
                            lblErro.Text = "Este amigo já esta na sua lista";
                            lblErro.Visible = true;
                        }
                        if (dt1.Rows[0]["StatusAmigo"].ToString() == "False")
                        {
                            lblErro.Text = "Seu pedido está pendente";
                            lblErro.Visible = true;
                        }
                        if (dt1.Rows[0]["StatusAmigo"].ToString() == "2")
                        {
                            lblErro.Text = "Seu pedido foi negado";
                            lblErro.Visible = true;
                        }
                    }
                    else
                    {
                        string friendRequest = "Insert INTO Amigos (IdMeu,IdAmigo,StatusAmigo) VALUES('" + Session["UsuarioID"].ToString() + "','" + Request.QueryString["Id"].ToString() + "', 0)";
                        dbClass.ConnectDataBaseToInsert(friendRequest);
                        lblErro.Text = "Pedido Enviado!";
                        lblErro.Visible = true;
                    }
                }
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }

        }

        protected void btnMurmurar_Click(object sender, EventArgs e)
        {

            //ScriptManager.RegisterStartupScript(Page, GetType(), "JsStatus", "recarregaPagina();", true);

            //if (txtMurmurar.Text == string.Empty)
            //{
            //    ScriptManager.RegisterStartupScript(Page, GetType(), "JsStatus", "ChamaLogon();", true);
            //}

            if (!object.Equals(Session["UsuarioID"], null))
            {
                string postScrap = "Insert INTO Mensagem (IdOrigem,IdDestino,Mensagem) VALUES('" + Session["UsuarioID"].ToString() + "','" + Request.QueryString["Id"].ToString() + "','" + txtMurmurar.Text + "')";
                dbClass.ConnectDataBaseToInsert(postScrap);
                Response.Redirect("Usuario.aspx?Id=" + Request.QueryString["Id"].ToString());
            }
            else
            {
                Response.Redirect("Logar.aspx");
            }



            /////listMural.Items.Add(txtMurmurar.Text);
        }

        //string getUserDetail = "Select ID,Email,Name,Country,Convert(varchar (20), RegisterDate, 106) RegisterDate,Convert(varchar (20), LastLogin, 106) LastLogin ,Description,ImageName FROM [User] where Id='" + id + "'";
        public void VideosAmigos(int id)
        {
            string pegaUsuario = @"select  TituloVideo, 
		                                    AutorVideo,
		                                    UrlVideo
                                   from dbo.VideosUsuario
                                   where IdMeu = '" + id + "'";

            dt = dbClass.ConnectDataBaseReturnDT(pegaUsuario);
            if (dt.Rows.Count > 0)
            {
                string[,] infoVideos = new string[30, 3];
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    infoVideos[i, 0] = dt.Rows[i]["UrlVideo"].ToString();
                    infoVideos[i, 1] = dt.Rows[i]["AutorVideo"].ToString();
                    infoVideos[i, 2] = dt.Rows[i]["TituloVideo"].ToString();   
                }

                string serializedinfoVideos = (new JavaScriptSerializer()).Serialize(infoVideos);
                ScriptManager.RegisterStartupScript(Page, GetType(), 
                                                    "JsStatus", 
                                                    "recarregaPagina(" + serializedinfoVideos + ");", 
                                                    true);
            }
        }
    }
}