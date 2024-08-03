using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class Viewscores : System.Web.UI.Page
    {
        functions f = new functions();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                f.getAdminProfileImage(Master.img);
                functions.getSubjects(subDdl);
                functions.loadClassGradeDdl(classDdl);
            }
        }

        protected void btnShowResult_Click(object sender, EventArgs e)
        {
            int classgrade = Convert.ToInt32(classDdl.SelectedItem.Text);
            string subjectname = subDdl.SelectedItem.Text;
            f.viewExamScore(PlaceHolder_scoreview, classgrade, subjectname);
        }

    }
}