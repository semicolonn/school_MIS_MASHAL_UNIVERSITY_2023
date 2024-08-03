using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Configuration;
namespace schoolmis
{
    public partial class Login : System.Web.UI.Page
    {
        string userType = "";

        functions f = new functions();

        protected void Page_Load(object sender, EventArgs e)
        {
            errorMsgLbl.Visible = false;
            userType = usertypeddl.SelectedItem.Text;
        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {

            if (StudentName.Text == "" && password.Text == "")
            {
                errorMsgLbl.Visible = true;
                errorMsgLbl.ForeColor = System.Drawing.Color.Red;
                errorMsgLbl.Text = "Please type username, password & select user type!";

            }
            else
            {
                if (userType == "Student")
                {

                    functions.loginStudent(StudentName.Text, password.Text, errorMsgLbl);
                  //  functions.connect.Close();
                }
                else if (userType == "Teacher")
                {
                    functions.loginTeacher(StudentName.Text, password.Text, errorMsgLbl);
                    //functions.connect.Close();
                }
                else if (userType == "Admin")
                {
                    f.loginAdmin(StudentName.Text, password.Text, errorMsgLbl);
                }

                if (functions.flag == true)
                {
                    functions.connect.Close();
                    StudentName.Text = "";
                    password.Text = "";

                }

            }


        }
    }
}