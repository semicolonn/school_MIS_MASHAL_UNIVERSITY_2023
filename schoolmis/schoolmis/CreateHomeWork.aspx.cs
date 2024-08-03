using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class CreateHomeWork : System.Web.UI.Page
    {

        functions f = new functions();
        protected void Page_Load(object sender, EventArgs e)
        {
            showMsg.Visible = false;

            if (!Page.IsPostBack)
            {
                functions.getTeachersName(teachernameddl);
                functions.getSubjects(subjectddl);
                functions.loadClassGradeDdl(classgradeddl);
                f.getTeacherUserProfileImage(Master.imge);

            }

        }

        protected void btnHmework_Click(object sender, EventArgs e)
        {


            if (titletxt.Text != null && contentTxt.Text != null && dateTxt.Text != null && deadLinetxt.Text != null)
            {
                //get the values for insertion purpose to database
                string titlefield = titletxt.Text;
                string contentfield = contentTxt.Text;
                string date = dateTxt.Text;
                string deadlinefield = deadLinetxt.Text;


                string subName = subjectddl.SelectedItem.Text;
                string teacherName = teachernameddl.SelectedItem.Text;
                int classddl = Convert.ToInt32(classgradeddl.SelectedItem.Text);



                //switch to get the subject id and insert in the table
                int subId = 0;
                switch (subName)
                {
                    case "dari":
                        subId = 1;
                        break;
                    case "pashto":
                        subId = 2;
                        break;
                    case "english":
                        subId = 3;
                        break;
                    case "chemistry":
                        subId = 4;
                        break;
                    case "biology":
                        subId = 5;
                        break;
                    case "math":
                        subId = 6;
                        break;

                    case "algebra":
                        subId = 7;
                        break;

                    case "art":
                        subId = 8;
                        break;
                    case "geometery":
                        subId = 9;
                        break;
                    case "physics":
                        subId = 10;
                        break;
                    case "quran":
                        subId = 11;
                        break;
                    case "hadees":
                        subId = 12;
                        break;
                    case "tradition":
                        subId = 13;
                        break;
                    case "sport":
                        subId = 14;
                        break;

                    default:
                        break;
                }

                //switch to get the teachername and insert in the table
                int tId = 0;
                switch (teacherName)
                {
                    case "abc":
                        tId = 5;
                        break;

                    case "tamana":
                        tId = 6;
                        break;
                    case "dummy":
                        tId = 8;
                        break;

                    default:
                        break;
                }


                f.createHomeWork(subId, titlefield, contentfield, date, deadlinefield, tId, classddl);
                showMsg.Visible = true;
                showMsg.ForeColor = System.Drawing.Color.Green;
                showMsg.Text = "Record created successfully!";
                titletxt.Text = "";
                contentTxt.Text = "";
                dateTxt.Text = "";
                deadLinetxt.Text = "";


            }
            else
            {
                return;
            }

        }
    }
}