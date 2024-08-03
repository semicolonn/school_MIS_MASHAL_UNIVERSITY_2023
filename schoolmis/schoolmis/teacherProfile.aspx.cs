using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class teacherProfile : System.Web.UI.Page
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


                f.getTeacherUserProfileImage(Master.imge);

                nameLbl.Font.Bold = true;
                fnameLbl.Font.Bold = true;
                lastnameLbl.Font.Bold = true;
                tazkiraLbl.Font.Bold = true;
                DOBLbl.Font.Bold = true;
                ageLbl.Font.Bold = true;
                contactLbl.Font.Bold = true;
                homeaddLbl.Font.Bold = true;


            }

            f.loadTeacherDetails(nameLbl, fnameLbl, lastnameLbl, tazkiraLbl, DOBLbl,
                ageLbl, contactLbl, homeaddLbl, userImge, Session["user"].ToString());
        }
    }
}