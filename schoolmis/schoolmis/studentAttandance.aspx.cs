using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class studentAttandance : System.Web.UI.Page
    {


        //create function class object to access its methods and properties
        functions f = new functions();

        protected void Page_Load(object sender, EventArgs e)
        {
            dataGrdVw.Visible = false;
            msgLabl.Visible = false;
            updateAttandanceBtn.Visible = false;

            if (!Page.IsPostBack)
            {
                f.getTeacherUserProfileImage(Master.imge);

                functions.loadClassGradeDdl(classgradeddl);
                f.loadDays(DropDownListDay);
                f.loadMonths(DropDownListMonth);
                f.loadYears(DropDownListYear);

            }

        }


        protected void updateAttandanceBtn_Click(object sender, EventArgs e)
        {
            f.saveAttandanceStatus(dataGrdVw, DropDownListDay, DropDownListMonth, DropDownListYear, classgradeddl);
            msgLabl.Visible = true;
            msgLabl.ForeColor = System.Drawing.Color.Green;
            msgLabl.Text = "Submitted Successfully!";
        }

        protected void showDetails_Click(object sender, EventArgs e)
        {

            int classid = Convert.ToInt32(classgradeddl.SelectedItem.Text);

            f.populateAttandanceDetails(classid, dataGrdVw, updateAttandanceBtn);

            dataGrdVw.Visible = true;

            


        }
    }
}