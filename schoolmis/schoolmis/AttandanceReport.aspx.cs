using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class AttandanceReport : System.Web.UI.Page
    {

        functions f = new functions();
        protected void Page_Load(object sender, EventArgs e)
        {


            //string[] months = {"January", "February", "March",
            //                    "April", "May", "June", "July", "August", "September",
            //                    "October", "November", "December" };


            if (!Page.IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                functions.getUserProfileImage(Master.imge);
                getPresentDaysRp.Visible = false;
                getAbsDays.Visible = false;
                getSickDays.Visible = false;


            }
        }

        protected void btnShowResultAttandance_Click(object sender, EventArgs e)
        {
            if (studentNameTxt.Text!=null && studentIdTxt.Text !=null)
            {
                string name = studentNameTxt.Text;
                f.loadAttandanceResult(placeholder_studentAttandce, name);
                getPresentDaysRp.Visible = true;
                getAbsDays.Visible = true;
                getSickDays.Visible = true;

                getPresentDaysRp.ForeColor = System.Drawing.Color.Green;
                getAbsDays.ForeColor = System.Drawing.Color.Green;
                getSickDays.ForeColor = System.Drawing.Color.Green;
                getPresentDaysRp.Font.Bold = true;
                getAbsDays.Font.Bold = true;
                getSickDays.Font.Bold = true;
                string stid = studentIdTxt.Text;
                f.attandanceTotaling(stid, getPresentDaysRp);
                f.TotallingAbsentee(stid, getAbsDays);
                f.TotallingSickness(stid, getSickDays);
                studentIdTxt.Text = "";

                studentNameTxt.Text = "";

                ;
            }

        }

     
    }
}