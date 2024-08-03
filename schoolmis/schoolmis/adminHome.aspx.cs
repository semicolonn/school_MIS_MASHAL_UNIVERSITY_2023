using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class adminHome : System.Web.UI.Page
    {
        functions f = new functions();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                f.getAdminProfileImage(Master.img);

            }
        }
    }
}