using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class Homework : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {

                if (Session["user"] == null)
                {
                    Response.Redirect("Login.aspx");
                }


                functions.getUserProfileImage(Master.imge);

                functions.loadClassGrades(classGradddl);
            }
        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            functions.loadHomework(classGradddl, homeworkPholder);
        }
    }
}