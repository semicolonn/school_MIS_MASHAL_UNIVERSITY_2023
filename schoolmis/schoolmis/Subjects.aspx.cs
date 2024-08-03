using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class Subjects : System.Web.UI.Page
    {
        functions f = new functions();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Session["user"] == null)
                {
                    Response.Redirect("Login.aspx");
                }


                functions.getUserProfileImage(Master.imge);

            }
        }

        protected void subjectsBtn_Click(object sender, EventArgs e)
        {
            f.viewSubjects(PlaceHolder_subject, Convert.ToInt32(class_ddl.SelectedItem.Text));
        }
    }
}