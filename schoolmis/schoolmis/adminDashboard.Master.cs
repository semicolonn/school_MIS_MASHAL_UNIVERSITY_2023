using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class adminDashboard : System.Web.UI.MasterPage
    {
        public Image img
        {
            get
            {
                return this.userProfPic;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                functions.connect.Close();
                Response.Redirect("Login.aspx");
            }
            functions.connect.Close();

            userNameLbl.Text = Session["user"].ToString();


        }
    }
}