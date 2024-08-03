using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class dashboardMaster : System.Web.UI.MasterPage
    {
        public Image imge
        {
            get
            {
                return this.Image1;
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