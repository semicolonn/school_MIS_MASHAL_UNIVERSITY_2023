using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class Score : System.Web.UI.Page
    {
        functions f = new functions();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                functions.getUserProfileImage(Master.imge);
                if (Session["user"] == null)
                {
                    Response.Redirect("Login.aspx");
                }


               // functions.getUserProfileImage(Master.imge);
            }

        }

        protected void btnShowExamResult_Click(object sender, EventArgs e)
        {
            string getUserName = Session["user"].ToString();
            string examtype = examDdl.SelectedItem.Text;
            f.loadStudentScoreResult(htmlTablePlaceHolder, examtype, getUserName);
        }
    }
}