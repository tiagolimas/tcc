using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Murmurio.Data;
using System.Data;
using System.Data.SqlClient;

namespace Murmurio.Visual
{
    
    public partial class Logon : System.Web.UI.UserControl
    {

        BaseDeDados dbClass = new BaseDeDados();
        public DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {

            var idAmigoAcionado = Session["AmigoAcionado"];
            
            if (Session["AmigoAcionado"] != null)
            {
                Session["AmigoAcionado"] = null;
                Response.Redirect("Usuario.aspx?Id=" + idAmigoAcionado.ToString());
            }


            var usuarioLogin = Session["UsuarioID"];
            
            if (usuarioLogin != null)
            {
               Response.Redirect("Usuario.aspx?Id=" + Session["UsuarioID"].ToString());
            }
        }


        protected void Autenticar(object sender, AuthenticateEventArgs e)
        {
            bool autenticado = false;

            autenticado = BuscaLogin(ControleLogin.UserName, ControleLogin.Password);
            //autenticado = BuscaLogin("teste", "teste");

            e.Authenticated = autenticado;

            if (e.Authenticated)
            {
                
                //original
                Response.Redirect("Usuario.aspx?Id=" + Session["UsuarioID"].ToString());

            }
        }

        protected bool BuscaLogin(string User, string Senha)
        {
            string testeConex = "select * from [usuario] where Email = '" + User + "' And Senha = '" + Senha + "' ";
            dt = dbClass.ConnectDataBaseReturnDT(testeConex);

            if (dt.Rows.Count > 0)
            {
                Session["UsuarioID"] = dt.Rows[0]["IdUsuario"].ToString();
                return true;
            }

            //if (User == "a" && Senha == "b")
            //{
            //    Session["UsuarioID"] = 1;
            //    return true;
            //}

            return false;
        }
    }
}