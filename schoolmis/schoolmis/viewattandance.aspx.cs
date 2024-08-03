using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class viewattandance : System.Web.UI.Page
    {

        functions f = new functions();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                f.getAdminProfileImage(Master.img);
                functions.loadClassGrades(classDdl);
                f.loadMonths(monthDdl);
                f.loadYears(yearDdl);
            }

        }

        protected void btnShowResult_Click(object sender, EventArgs e)
        {
            int class_grad = Convert.ToInt32(classDdl.SelectedItem.Text);
            string month = monthDdl.SelectedItem.Text;
            int yr = Convert.ToInt32(yearDdl.SelectedItem.Text);
            f.viewStudentAttandance(PlaceHolder_attandview, month, yr, class_grad);

        }
    }
}