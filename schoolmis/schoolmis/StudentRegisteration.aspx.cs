using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace schoolmis
{
    public partial class StudentRegisteration : System.Web.UI.Page
    {
        functions f = new functions();
        protected void Page_Load(object sender, EventArgs e)
        {
            msg.Visible = false;

            if (!IsPostBack)
            {
                functions.loadClassGradeDdl(classGradddl);
                functions.loadEntryStateDdl(entrystatusddl);
                f.getAdminProfileImage(Master.img);

            }

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            string getName = firstnametxt.Text;
            string getFName = fnametxt.Text;
            string getLastName= lastNametxt.Text;
            string getPwd= passwordtxt.Text;
            string getTazkira=tazkiratxt.Text;
            string getDob= dobtxt.Text;
            int getAge= Convert.ToInt32 (agetxt.Text);
            string getContact= contactnrtxt.Text;
            string getAddress= addresstxt.Text;
            int getCLassGradeVal= Convert.ToInt32(classGradddl.SelectedValue);
            string getEntryStt= entrystatusddl.SelectedValue;
            string getPhotoTxt= fucontrl.FileName;

            int getEntrySttDdlVal = 0;

            if (getEntryStt == "new")
            {
                 getEntrySttDdlVal = 1;
            }
            else if(getEntryStt== "transfer")
            {
                 getEntrySttDdlVal = 2;

            }

            // ADD VALIDATION TO THE REGISTERATION FORM !!!
            f.registerStudent(getName, getFName, getLastName, getPwd, getTazkira, getDob, getAge, getContact, 
                getAddress, getCLassGradeVal, getEntrySttDdlVal, getPhotoTxt,fucontrl);
            functions.connect.Close();
            msg.Visible = true;
            msg.Text = "Record Added Successfully!";


            firstnametxt.Text="";
            fnametxt.Text="";
            lastNametxt.Text="";
            passwordtxt.Text="";
            tazkiratxt.Text="";
            dobtxt.Text="";
            agetxt.Text="";
            contactnrtxt.Text="";
            addresstxt.Text="";
        }
    }
}