using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class Exam : System.Web.UI.Page
    {

        functions f = new functions();

        protected void Page_Load(object sender, EventArgs e)
        {
            showMsg.Visible = false;

            if (!Page.IsPostBack) { }
            {
                functions.getTeachersName(teachernameddl);
                functions.getSubjects(subjectddl);
                functions.loadClassGrades(classgradeddl);
                f.getTeacherUserProfileImage(Master.imge);

            }
        }

        protected void btnCreateScore_Click(object sender, EventArgs e)
        {

            if (marktxt.Text != "" || studentidTxt.Text != "")
            {
                //get the values for insertion purpose to database
                int mrk = Convert.ToInt32(marktxt.Text);
                int si = Convert.ToInt32(studentidTxt.Text);
                string SubName = subjectddl.SelectedItem.Text;
                string teacherName = teachernameddl.SelectedItem.Text;
                int cls = Convert.ToInt32(classgradeddl.SelectedItem.Text);
                string et = examtypeddl.SelectedItem.Text;



                //switch to get the subject id and insert in the table
                int subId = 0;
                switch (SubName)
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
                        subId = 6;
                        break;

                    default:
                        break;
                }



                //switch to get the exam type and insert in the table
                int examId = 0;
                switch (et)
                {
                    case "Mid Term":
                        examId = 1;
                        break;
                    case "Final":
                        examId = 2;
                        break;
                    case "Quiz":
                        examId = 4;
                        break;
                    default:
                        break;
                }


                f.createMarkSheet(mrk, si, subId, tId, cls, examId);
                showMsg.Visible = true;
                showMsg.ForeColor = System.Drawing.Color.Green;
                showMsg.Text = "Record for created successfully!";
                marktxt.Text = "";
                studentidTxt.Text = "";
            }
            else
            {
                return;
            }

        }
    }
}