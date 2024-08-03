using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class teacherDashboard1 : System.Web.UI.MasterPage
    {

        public Image imge
        {
            get
            {
                return this.user_imge;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
                functions.connect.Close();

            }
            functions.connect.Close();

            userNametd.Text = Session["user"].ToString();
        }
    }
}