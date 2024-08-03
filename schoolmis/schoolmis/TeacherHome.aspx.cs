using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class TeacherHome : System.Web.UI.Page
    {
        functions f = new functions();

        protected void Page_Load(object sender, EventArgs e)
        {
            f.getTeacherUserProfileImage(Master.imge);
        }
    }
}
