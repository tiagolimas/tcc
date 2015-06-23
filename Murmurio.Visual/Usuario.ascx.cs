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
    public partial class Usuario : System.Web.UI.UserControl
    {
        BaseDeDados dbClass = new BaseDeDados();
        public DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                DadosUsuario(int.Parse(Request.QueryString["Id"].ToString()));
                //if (!object.Equals(Session["UserId"], null))
                //{
                //    if (object.Equals(Session["UserId"], Request.QueryString["Id"]))
                //    {
                //        UserFriendRequest.Visible = true;
                //    }
                //    else
                //    {
                //        UserFriendRequest.Visible = false;
                //    }
                //}
            }

        }

        public void DadosUsuario(int id)
        {
            string getUserDetail = "Select ID,Email,Name,Country,Convert(varchar (20), RegisterDate, 106) RegisterDate,Convert(varchar (20), LastLogin, 106) LastLogin ,Description,ImageName FROM [User] where Id='" + id + "'";
            dt = dbClass.ConnectDataBaseReturnDT(getUserDetail);
            if (dt.Rows.Count > 0)
            {
                //UserImage.ImageUrl = "~/UserImage/" + dt.Rows[0]["ImageName"].ToString();
                //lblCreated.Text = dt.Rows[0]["RegisterDate"].ToString();
                //LabelLastLogin.Text = dt.Rows[0]["LastLogin"].ToString();
                //lblCreated.Text = dt.Rows[0]["RegisterDate"].ToString();
                //LabelAboutMe.Text = dt.Rows[0]["Description"].ToString();
            }
        }
    }
}