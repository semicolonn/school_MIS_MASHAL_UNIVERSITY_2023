using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class TeacherRegisteration : System.Web.UI.Page
    {

        functions f = new functions();
        protected void Page_Load(object sender, EventArgs e)
        {
            msg.Visible = false;
            if (!Page.IsPostBack)
            {

                f.getAdminProfileImage(Master.img);

                functions.loadClassGradeDdl(classGradddl);

            }
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            if (firstnametxt.Text == "" || fnametxt.Text == "" || lastNametxt.Text == "" || passwordtxt.Text == "" || tazkiratxt.Text == "" ||
                dobtxt.Text == "" || contactnrtxt.Text == "" || addresstxt.Text == "")
            {
                msg.Visible = true;
                msg.ForeColor = System.Drawing.Color.Red;
                msg.Text = "Please fill the required fields!";
            }
            else {
                string getName = firstnametxt.Text;
                string getFName = fnametxt.Text;
                string getLastName = lastNametxt.Text;
                string getPwd = passwordtxt.Text;
                string getTazkira = tazkiratxt.Text;
                string getDob = dobtxt.Text;
                int getAge = Convert.ToInt32(agetxt.Text);
                string getContact = contactnrtxt.Text;
                string getAddress = addresstxt.Text;
                int getCLassGradeVal = Convert.ToInt32(classGradddl.SelectedValue);
                string getDegree = degreeddl.SelectedValue;
                string getPhotoTxt = fucontrl.FileName;

                int getDegreeValue = 0;
                switch (getDegree)
                {
                    case "Bachelor":
                        getDegreeValue = 1;
                        break;
                    case "Master":
                        break;
                    case "Phd":
                        break;
                    case "Baculuria":
                        break;
                    default:
                        break;
                }

                f.registerTeacher(getName, getFName, getLastName, getPwd, getTazkira, getDob, getAge, getContact, 
                    getAddress, getCLassGradeVal, getDegreeValue, getPhotoTxt,fucontrl);
                functions.connect.Close();
                msg.Visible = true;
                msg.Text = "Record Added Successfully!";

                firstnametxt.Text="";
                fnametxt.Text = "";
                lastNametxt.Text = "";
                passwordtxt.Text = "";
                tazkiratxt.Text = "";
                dobtxt.Text = "";
                agetxt.Text = "";
                contactnrtxt.Text = "";
                addresstxt.Text = "";
            }
        }
    }
}