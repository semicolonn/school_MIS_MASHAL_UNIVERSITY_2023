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
using System.IO;

namespace schoolmis
{
    // A PROJECT BY TAMANA SHAH - MASHAL UNIVERSITY - BCS FACULTY YEAR 2021 

    public class functions
    {
        public static bool flag = false;
        public static string getNameForSession = "";
        public static string userType = "";

        //connection string to database (Sql Server 2008)
        public static string connectionString = "Data Source=DESKTOP-IASA95P;Initial Catalog=schoolmis;Integrated Security=True";
        public static SqlConnection connect = new SqlConnection(functions.connectionString);




        //---------------------------------------------STUDENT PORTAL----------------------------------------//





        //load data to Class Grade DropDownlist

        public static void loadClassGradeDdl(DropDownList ddlName)
        {
            connect.Open();
            string cmd = "SELECT * FROM classgrade";
            SqlDataAdapter sda = new SqlDataAdapter(cmd, connect);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);
            ddlName.DataSource = datatable;
            ddlName.DataBind();
            ddlName.DataTextField = "grade";
            ddlName.DataBind();
            connect.Close();

        }


        //load data to Entry Status DropDownlist

        public static void loadEntryStateDdl(DropDownList ddlName)
        {
            connect.Open();
            string cmd = "SELECT * FROM registerstatus";
            SqlDataAdapter sda = new SqlDataAdapter(cmd, connect);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);
            ddlName.DataSource = datatable;
            ddlName.DataBind();
            ddlName.DataTextField = "regstatus";
            ddlName.DataBind();
            connect.Close();

        }

        //insert into database Register Students

        public void registerStudent(string name, string fname, string lastname,
            string password, string tazkiraid, string dob, int age, string contactnr,
            string homeaddress, int classgrade, int regstatus, string photo, FileUpload fup)
        {
            connect.Open();
            string sql = "INSERT INTO student(name, fname, lastname, password, tazkira, dob, age, contactnr, homeaddress," +
                "classgradeId_fk, registerStatusId_fk, photo) VALUES('" + name + "', '" + fname + "', '" + lastname + "'," +
             "'" + password + "', '" + tazkiraid + "', '" + dob + "', '" + age + "', '" + contactnr + "'," + "'" + homeaddress + "',"+
             "'" + classgrade + "', '" + regstatus + "', '" + photo + "')";

            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
            connect.Close();

            //code to upload the user profile image in the project profileImage Directory
            string fileName = Path.GetFileName(fup.PostedFile.FileName);
            fup.PostedFile.SaveAs(HttpContext.Current.Server.MapPath("~/profileImages/") + fileName);

        }

        //user login form function processing

        public static void loginStudent(string username, string userPassword, Label errorLable)
        {
            connect.Open();
            string sql = "SELECT * FROM student where name='" + username + "' AND password='" + userPassword + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);

            //below code is for reading data of the single cell Name from database for dashboard.aspx page.
            SqlCommand cmd = new SqlCommand(sql, connect);
            //var reader = cmd.ExecuteReader();
            //reader.Read();

            if (datatable.Rows.Count > 0)
            {

                getNameForSession = username;
                //getNameForSession = reader.GetString(1);
                HttpContext.Current.Session["user"] = getNameForSession;
                userType = "student";
                HttpContext.Current.Session["userType"] = userType;

                connect.Close();
                HttpContext.Current.Response.Redirect("Home.aspx");
            }

            else
            {
                connect.Close();
                flag = true;
                errorLable.Visible = true;
                errorLable.ForeColor = System.Drawing.Color.Red;
                errorLable.Text = "Wrong username, password or user type selection!";
            }


        }



        //Load the student score information data in the HTML table
        public static void loadScoreTable(PlaceHolder p)
        {
            connect.Open();
            //Populating a DataTable from database.

            string sql = "SELECT * FROM checkScore";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Building an HTML string.
            System.Text.StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table class='table'>");

            //Building the Header row.
            html.Append("<thead>");
            html.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                html.Append("<th scope='col'>");
                html.Append(column.ColumnName);
                html.Append("</th>");
            }
            html.Append("</tr>");
            html.Append("</thead>");


            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }

            //Table end.
            html.Append("</table>");

            //Append the HTML string to Placeholder.
            p.Controls.Add(new Literal { Text = html.ToString() });
            connect.Close();
        }


        //Load the student attandance Report information data in the HTML table
        public static void loadAttandanceTable(PlaceHolder p, DropDownList ddl)
        {
            connect.Open();
            //Populating a DataTable from database.

            string sql = "SELECT * FROM attandanceReport WHERE Month='" + ddl.SelectedItem + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Building an HTML string.
            System.Text.StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table class='table'>");

            //Building the Header row.
            html.Append("<thead>");
            html.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                html.Append("<th scope='col'>");
                html.Append(column.ColumnName);
                html.Append("</th>");
            }
            html.Append("</tr>");
            html.Append("</thead>");


            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }

            //Table end.
            html.Append("</table>");

            //Append the HTML string to Placeholder.
            p.Controls.Add(new Literal { Text = html.ToString() });
            connect.Close();
        }




        //Load the teacher schedule  data in the HTML table
        public static void loadSchedule(PlaceHolder p)
        {
            connect.Open();
            //Populating a DataTable from database.

            string sql = "SELECT * FROM teacherSchedule";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Building an HTML string.
            System.Text.StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table class='table'>");

            //Building the Header row.
            html.Append("<thead>");
            html.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                html.Append("<th scope='col'>");
                html.Append(column.ColumnName);
                html.Append("</th>");
            }
            html.Append("</tr>");
            html.Append("</thead>");


            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }

            //Table end.
            html.Append("</table>");

            //Append the HTML string to Placeholder.
            p.Controls.Add(new Literal { Text = html.ToString() });
            connect.Close();
        }


        //get profile Image from the database
        public static void getUserProfileImage(Image im)
        {

            connect.Open();
            string sql = "SELECT photo FROM student where name='" + HttpContext.Current.Session["user"] + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);

            //below code is for reading data of the single cell Name from database for dashboard.aspx page.
            SqlCommand cmd = new SqlCommand(sql, connect);
            var reader = cmd.ExecuteReader();
            reader.Read();

            if (datatable.Rows.Count > 0)
            {
                string getImagePath = reader["photo"].ToString();
                im.ImageUrl = "~/profileImages/" + getImagePath;

                connect.Close();
            }
        }



        //load classes into dropdownlist
        public static void loadClassGrades(DropDownList ddl)
        {
            for (int i = 1; i <= 12; i++)
            {
                ddl.Items.Add(i.ToString());
            }
        }


        //view homework and assignments

        public static void loadHomework(DropDownList ddl, PlaceHolder p)
        {
            connect.Open();
            //Populating a DataTable from database.

            string sql = "SELECT * FROM homeworkView WHERE Class='" + ddl.SelectedItem + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Building an HTML string.
            System.Text.StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table class='table'>");

            //Building the Header row.
            html.Append("<thead>");
            html.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                html.Append("<th scope='col'>");
                html.Append(column.ColumnName);
                html.Append("</th>");
            }
            html.Append("</tr>");
            html.Append("</thead>");


            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }

            //Table end.
            html.Append("</table>");

            //Append the HTML string to Placeholder.
            p.Controls.Add(new Literal { Text = html.ToString() });
            connect.Close();
        }




        //user teacher login form function processing

        public static void loginTeacher(string username, string userPassword, Label errorLable)
        {
            connect.Open();

            string sql = "SELECT * FROM teacher where name='" + username + "' AND password='" + userPassword + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);

            //below code is for reading data of the single cell Name from database for dashboard.aspx page.
            SqlCommand cmd = new SqlCommand(sql, connect);
            //var reader = cmd.ExecuteReader();
            //reader.Read();

            if (datatable.Rows.Count > 0)
            {

                getNameForSession = username;
                //getNameForSession = reader.GetString(1);
                HttpContext.Current.Session["user"] = getNameForSession;

                connect.Close();
                HttpContext.Current.Response.Redirect("TeacherHome.aspx");
            }

            else
            {
                connect.Close();
                flag = true;
                errorLable.Visible = true;
                errorLable.ForeColor = System.Drawing.Color.Red;
                errorLable.Text = "Wrong username, password or user type selection!";
            }


        }




        //create exam scoring for students


        //get teacher name to dropdownlist
        public static void getTeachersName(DropDownList ddlName)
        {
            connect.Open();
            string cmd = "SELECT * FROM teacher";
            SqlDataAdapter sda = new SqlDataAdapter(cmd, connect);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);
            ddlName.DataSource = datatable;
            ddlName.DataBind();
            ddlName.DataTextField = "name";
            ddlName.DataBind();
            connect.Close();
        }
        //get subjects name to dropdownlist

        public static void getSubjects(DropDownList ddlName)
        {
            connect.Open();
            string cmd = "SELECT * FROM subject";
            SqlDataAdapter sda = new SqlDataAdapter(cmd, connect);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);
            ddlName.DataSource = datatable;
            ddlName.DataBind();
            ddlName.DataTextField = "subjectname";
            ddlName.DataBind();
            connect.Close();
        }





        //Load the books and chapters in the student panel
        public void loadBooksChapterTable(GridView gv, DropDownList ddl)
        {
            connect.Open();
            //Populating a DataTable from database.

            string sql = "SELECT * FROM bookchapters WHERE class_id_fk='" + ddl.SelectedItem + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            gv.DataSource = dt;
            gv.DataBind();
            connect.Close();
        }



        //show student attandance result by name search event:
        public void loadAttandanceResult(PlaceHolder p, string studentName)
        {
            connect.Open();
            //Populating a DataTable from database.

            string sql = "SELECT * FROM attandanceReportSheet WHERE Name='" + studentName + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Building an HTML string.
            System.Text.StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table class='table'>");

            //Building the Header row.
            html.Append("<thead>");
            html.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                html.Append("<th scope='col'>");
                html.Append(column.ColumnName);
                html.Append("</th>");
            }
            html.Append("</tr>");
            html.Append("</thead>");


            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }

            //Table end.
            html.Append("</table>");

            //Append the HTML string to Placeholder.
            p.Controls.Add(new Literal { Text = html.ToString() });
            connect.Close();
        }



        //load score results for the students in student panel
        public void loadStudentScoreResult(PlaceHolder p, string exam, string userSession)
        {
            connect.Open();
            //Populating a DataTable from database.

            string sql = "SELECT * FROM checkScore WHERE [Exam Term]='" + exam + "' AND Name='"+userSession+"'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Building an HTML string.
            System.Text.StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table class='table'>");

            //Building the Header row.
            html.Append("<thead>");
            html.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                html.Append("<th scope='col'>");
                html.Append(column.ColumnName);
                html.Append("</th>");
            }
            html.Append("</tr>");
            html.Append("</thead>");


            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }

            //Table end.
            html.Append("</table>");

            //Append the HTML string to Placeholder.
            p.Controls.Add(new Literal { Text = html.ToString() });
            connect.Close();
        }




        //student attandance report totalling


        public void attandanceTotaling(string studentId, Label l) {

            connect.Open();
            //check the present status
            string sqlpr = "SELECT COUNT([Attandance Status]) FROM attandanceReportSheet WHERE[Student ID]='" + studentId + "' AND [Attandance Status] ='p'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlpr, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            l.Text = "Total Present Days:" +" "+ dt.Rows[0][0].ToString();
            connect.Close();

        }


        //student attandance report totalling absentees


        public void TotallingAbsentee(string studentId, Label l)
        {

            connect.Open();

            //check the absent status
            string sql = "SELECT COUNT([Attandance Status]) FROM attandanceReportSheet WHERE[Student ID]='" + studentId + "' AND [Attandance Status] ='a'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            l.Text = "Total Absent Days:" + " " + dt.Rows[0][0].ToString();
            connect.Close();

        }



        //student attandance report totalling absentees


        public void TotallingSickness(string studentId, Label l)
        {

            connect.Open();
            //check the sickness status
            string sqlsk = "SELECT COUNT([Attandance Status]) FROM attandanceReportSheet WHERE[Student ID]='" + studentId + "' AND [Attandance Status] ='s'";
            SqlDataAdapter sdsk = new SqlDataAdapter(sqlsk, connect);
            DataTable dtsk = new DataTable();
            sdsk.Fill(dtsk);
            l.Text = "Total Sikness Leave Days:" + " " + dtsk.Rows[0][0].ToString();
            connect.Close();

        }




        //get profile details for student
        public void loadStudentDetails(Label id, Label name, Label fname, Label lastname,
            Label tazkira, Label dob, Label age, Label contactnr, Label homeaddress, Image img, string sessionUserName)
        {
            connect.Open();

            //string sql = "SELECT id, name, fname, lastname, tazkira, dob, age, contactnr," 
            //    +"homeaddress, photo FROM student WHERE name='" + sessionUserName + "'";
            string sql = "SELECT * FROM student WHERE name='" + sessionUserName + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);

            //below code is for reading data of the single cell Name from database for dashboard.aspx page.
            SqlCommand cmd = new SqlCommand(sql, connect);
            //var reader = cmd.ExecuteReader();
            //reader.Read();

            if (datatable.Rows.Count > 0)
            {
                id.Text = datatable.Rows[0][0].ToString();
                name.Text = datatable.Rows[0][1].ToString();
                fname.Text = datatable.Rows[0][2].ToString();
                lastname.Text = datatable.Rows[0][3].ToString();
                tazkira.Text = datatable.Rows[0][4].ToString();
                dob.Text = datatable.Rows[0][5].ToString();
                age.Text = datatable.Rows[0][6].ToString();
                contactnr.Text = datatable.Rows[0][7].ToString();
                homeaddress.Text = datatable.Rows[0][8].ToString();
                img.ImageUrl= "profileImages/" + datatable.Rows[0][12].ToString();
                connect.Close();


            }
        }


        //view subjects in student panel:


        public void viewSubjects(PlaceHolder p, int class_grade)
        {
            connect.Open();
            //Populating a DataTable from database.

            string sql = "SELECT *FROM subject_class_vw WHERE Grade='" + class_grade + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Building an HTML string.
            System.Text.StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table class='table'>");

            //Building the Header row.
            html.Append("<thead>");
            html.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                html.Append("<th scope='col'>");
                html.Append(column.ColumnName);
                html.Append("</th>");
            }
            html.Append("</tr>");
            html.Append("</thead>");


            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }

            //Table end.
            html.Append("</table>");

            //Append the HTML string to Placeholder.
            p.Controls.Add(new Literal { Text = html.ToString() });
            connect.Close();
        }



        //---------------------------------------------TEACHER PORTAL----------------------------------------//

        //insert data to database to create exam result scores in the teacher panel

        public void createMarkSheet(int mark, int studentId, int subjectId, int teacherId, int classId, int examId)
        {
            connect.Open();
            string sql = "INSERT INTO score(marks, std_id_fk, sub_id_fk, t_id_fk, cls_id_fk, exm_id_fk) VALUES('" + mark + "'," +
             "'" + studentId + "', '" + subjectId + "', '" + teacherId + "', '" + classId + "', '" + examId + "')";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
        }



        //insert data to database to create homework  in the teacher panel

        public void createHomeWork(int subjectId, string title, string content, string date, 
            string deadlinedate, int teacherId, int classId)
        {
            connect.Open();
            string sql = "INSERT INTO homework(subject_id_fk, title, hw_content, hw_date, hw_deadlinedate, teacher_id_dk,class_id_fk)" +
                "VALUES('" + subjectId + "','" + title + "', '" + content + "', '" + date + "', '" + deadlinedate + "', '" + teacherId + "','" + classId + "')";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
        }



        //insert data to database to create outline notations  in the teacher panel

        public void createOutlineNotes(int subjectId, string title, string content, 
            string date, int class_id, int teacherId, int studentNum)
        {
            connect.Open();
            string sql = "INSERT INTO outline_progress(subject_id_fk, title, lessonContent, date, class_id_fk, teacher_id_fk,student_number)" +
                "VALUES('" + subjectId + "','" + title + "', '" + content + "', '" + date + "', '" + class_id + "', '" + teacherId + "','" + studentNum + "')";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
        }





        //populate the student data in the GridView as attandance format in the teacher panel

        public void populateAttandanceDetails(int classGradeId, GridView grdView, Button b)
        {
            connect.Open();
            string sql = "SELECT id AS [ID], name AS [Name], fname AS [FName], classgradeId_fk AS [Class Grade ID] FROM student WHERE classgradeId_fk='" + classGradeId + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);
            if (datatable.Rows.Count > 0)
            {
                flag = true;


                grdView.DataSource = datatable;
                grdView.DataBind();

                SqlCommand cmd = new SqlCommand(sql, connect);
                b.Visible = true;

            }
            else
            {
                grdView.Visible = false;
                return;
            }
    
            connect.Close();
        }


        //load days in the dropdownlist in teacher panel

        public void loadDays(DropDownList DropDownList_day)
        {
            for (int i = 1; i <= 31; i++)
            {
                DropDownList_day.Items.Add(i.ToString());
            }
        }




        //load months in the dropdownlist in teacher panel

        public void loadMonths(DropDownList DropDownList_month)
        {
            string[] m =
            {
                "Jan",
                "Feb",
                "Mar",
                "Apr",
                "May",
                "Jun",
                "Jul",
                "Aug",
                "Sep",
                "Oct",
                "Nov",
                "Dec"
            };
            DropDownList_month.DataSource = m;
            DropDownList_month.DataBind();

        }
        //load months in the dropdownlist in teacher panel

        public void loadYears(DropDownList DropDownList_year)
        {
            for (int i = 2000; i <= 2050; i++)
            {
                DropDownList_year.Items.Add(i.ToString());
            }

        }


        //save student attandance status in the teacher panel
        public void saveAttandanceStatus(GridView gv, DropDownList day, 
            DropDownList month, DropDownList year, DropDownList classgrad)
        {
            for (int i = 0; i < gv.Rows.Count; i++)
            {
                int studentId = Convert.ToInt32(gv.Rows[i].Cells[1].Text);
                int var_day = Convert.ToInt32(day.SelectedItem.Text);
                string var_month = month.SelectedItem.Text;
                int var_year = Convert.ToInt32(year.SelectedItem.Text);
                int classId = Convert.ToInt32(classgrad.SelectedItem.Text);

                CheckBox getAttandanceStat = (gv.Rows[i].Cells[0].FindControl("attandanceStatChk") as CheckBox);

                int checkAttandanceState = 0;
                if (getAttandanceStat.Checked == true)
                {
                    checkAttandanceState = 1;
                }
                else if (getAttandanceStat.Checked == false)
                {
                    checkAttandanceState = 2;
                }

                int numOfMonth = 0;
                switch (var_month)
                {
                    case "Jan":
                        numOfMonth = 1;
                        break;
                    case "Feb":
                        numOfMonth = 2;
                        break;
                    case "Mar":
                        numOfMonth = 3;
                        break;

                    case "Apr":
                        numOfMonth = 4;
                        break;

                    case "May":
                        numOfMonth = 5;
                        break;

                    case "Jun":
                        numOfMonth = 6;
                        break;

                    case "Jul":
                        numOfMonth = 7;
                        break;

                    case "Aug":
                        numOfMonth = 8;
                        break;

                    case "Sep":
                        numOfMonth = 9;
                        break;

                    case "Oct":
                        numOfMonth = 10;
                        break;

                    case "Nov":
                        numOfMonth = 11;
                        break;

                    case "Dec":
                        numOfMonth = 12;
                        break;

                    default:
                        break;
                }


                int getYearId = 0;
                switch (var_year)
                {

                    case 2000:
                        getYearId = 1;
                        break;
                    case 2001:
                        getYearId = 3;
                        break;
                    case 2002:
                        getYearId = 4;
                        break;
                    case 2003:
                        getYearId = 5;
                        break;
                    case 2004:
                        getYearId = 6;
                        break;
                    case 2005:
                        getYearId = 7;
                        break;
                    case 2006:
                        getYearId = 8;
                        break;
                    case 2007:
                        getYearId = 9;
                        break;
                    case 2008:
                        getYearId = 10;
                        break;
                    case 2009:
                        getYearId = 11;
                        break;
                    case 2010:
                        getYearId = 12;
                        break;
                    case 2011:
                        getYearId = 13;
                        break;
                    case 2012:
                        getYearId = 14;
                        break;
                    case 2013:
                        getYearId = 15;
                        break;
                    case 2014:
                        getYearId = 16;
                        break;
                    case 2015:
                        getYearId = 17;
                        break;
                    case 2016:
                        getYearId = 18;
                        break;
                    case 2017:
                        getYearId = 19;
                        break;
                    case 2018:
                        getYearId = 20;
                        break;
                    case 2019:
                        getYearId = 21;
                        break;
                    case 2020:
                        getYearId = 22;
                        break;
                    case 2021:
                        getYearId = 23;
                        break;
                    case 2022:
                        getYearId = 24;
                        break;
                    case 2023:
                        getYearId = 25;
                        break;
                    case 2024:
                        getYearId = 26;
                        break;
                    case 2025:
                        getYearId = 27;
                        break;
                    case 2026:
                        getYearId = 28;
                        break;
                    case 2027:
                        getYearId = 29;
                        break;
                    case 2028:
                        getYearId = 30;
                        break;
                    case 2029:
                        getYearId = 31;
                        break;
                    case 2030:
                        getYearId = 32;
                        break;
                    default:
                        break;
                }

                connect.Open();

                string sql = "INSERT INTO attandance_sheet VALUES('" + studentId + "','" + var_day + "'," +
                    "'" + numOfMonth + "','" + getYearId + "','" + classId + "','" + checkAttandanceState + "')";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.ExecuteNonQuery();
                connect.Close();

            }
        }






        //view scores in the teacher & admin panel:


        public void viewExamScore(PlaceHolder p, int class_grade, string subject)
        {
            connect.Open();
            //Populating a DataTable from database.

            string sql = "SELECT * FROM checkScore WHERE [Class Grade]='" + class_grade + "' AND Subject='" + subject + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Building an HTML string.
            System.Text.StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table class='table'>");

            //Building the Header row.
            html.Append("<thead>");
            html.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                html.Append("<th scope='col'>");
                html.Append(column.ColumnName);
                html.Append("</th>");
            }
            html.Append("</tr>");
            html.Append("</thead>");


            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }

            //Table end.
            html.Append("</table>");

            //Append the HTML string to Placeholder.
            p.Controls.Add(new Literal { Text = html.ToString() });
            connect.Close();
        }


        //get profile Image from the database
        public void getTeacherUserProfileImage(Image im)
        {

            connect.Open();
            string sql = "SELECT photo FROM teacher where name='" + HttpContext.Current.Session["user"] + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);

            //below code is for reading data of the single cell Name from database for dashboard.aspx page.
            SqlCommand cmd = new SqlCommand(sql, connect);
            var reader = cmd.ExecuteReader();
            reader.Read();

            if (datatable.Rows.Count > 0)
            {
                string getImagePath = reader["photo"].ToString();
                im.ImageUrl = "~/profileImages/" + getImagePath;

                connect.Close();
            }
        }



        //get profile details for teacher
        public void loadTeacherDetails(Label name, Label fname, Label lastname,
            Label tazkira, Label dob, Label age, Label contactnr, Label homeaddress, Image img, string sessionUserName)
        {
            connect.Close();
            connect.Open();

            string sql = "SELECT name, fname, lastname, tazkira, dob, age, contactnr,"
                + "homeaddress, photo FROM teacher WHERE name='" + sessionUserName + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);

            //below code is for reading data of the single cell Name from database for dashboard.aspx page.
            SqlCommand cmd = new SqlCommand(sql, connect);
            //var reader = cmd.ExecuteReader();
            //reader.Read();

            if (datatable.Rows.Count > 0)
            {

                name.Text = datatable.Rows[0][0].ToString();
                fname.Text = datatable.Rows[0][1].ToString();
                lastname.Text = datatable.Rows[0][2].ToString();
                tazkira.Text = datatable.Rows[0][3].ToString();
                dob.Text = datatable.Rows[0][4].ToString();
                age.Text = datatable.Rows[0][5].ToString();
                contactnr.Text = datatable.Rows[0][6].ToString();
                homeaddress.Text = datatable.Rows[0][7].ToString();
                img.ImageUrl = "profileImages/" + datatable.Rows[0][8].ToString();
                connect.Close();


            }
        }





   


        //---------------------------------------------ADMIN PORTAL----------------------------------------//




        //user login form function processing ADMIN

        public void loginAdmin(string username, string userPassword, Label errorLable)
        {
            connect.Open();
            string sql = "SELECT * FROM admin where name='" + username + "' AND password='" + userPassword + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);

            //below code is for reading data of the single cell Name from database for dashboard.aspx page.
            SqlCommand cmd = new SqlCommand(sql, connect);
            //var reader = cmd.ExecuteReader();
            //reader.Read();

            if (datatable.Rows.Count > 0)
            {

                getNameForSession = username;
                //getNameForSession = reader.GetString(1);
                HttpContext.Current.Session["user"] = getNameForSession;
                userType = "admin";
                HttpContext.Current.Session["userType"] = userType;

                connect.Close();
                HttpContext.Current.Response.Redirect("adminHome.aspx");
            }

            else
            {
                connect.Close();
                flag = true;
                errorLable.Visible = true;
                errorLable.ForeColor = System.Drawing.Color.Red;
                errorLable.Text = "Wrong username, password or user type selection!";
            }


        }


        //register new teacher in the database

        public void registerTeacher(string name, string fname, string lastname, string password, string tazkiraid,
            string dob, int age, string contactnr, string homeaddress, 
            int classgradeId, int degreeId, string photo, FileUpload fup)
        {
            connect.Open();
            string sql = "INSERT INTO teacher(name, fname, lastname, password, tazkira, dob, age, contactnr, homeaddress," +
                "class_id_fk, degreeId_fk, photo) VALUES('" + name + "', '" + fname + "', '" + lastname + "'," +
             "'" + password + "', '" + tazkiraid + "', '" + dob + "', '" + age + "', '" + contactnr + "'," + "'" + homeaddress + "', " 
             +"'" + classgradeId + "', '" + degreeId + "', '" + photo + "')";

            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
            connect.Close();

            //code to upload the user profile image in the project profileImage Directory
            string fileName = Path.GetFileName(fup.PostedFile.FileName);
            fup.PostedFile.SaveAs(HttpContext.Current.Server.MapPath("~/profileImages/") + fileName);
        }




        //view student attandance by ADMIN PORTAL


        public void viewStudentAttandance(PlaceHolder p, string month, int year, int class_grade)
        {
            connect.Open();
            //Populating a DataTable from database.

            string sql = "SELECT * FROM attandanceVwAdmin WHERE Month='"+month+"' AND Year='"+year+"' AND [Class Grade]='"+class_grade+"'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Building an HTML string.
            System.Text.StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table class='table'>");

            //Building the Header row.
            html.Append("<thead>");
            html.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                html.Append("<th scope='col'>");
                html.Append(column.ColumnName);
                html.Append("</th>");
            }
            html.Append("</tr>");
            html.Append("</thead>");


            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }

            //Table end.
            html.Append("</table>");

            //Append the HTML string to Placeholder.
            p.Controls.Add(new Literal { Text = html.ToString() });
            connect.Close();
        }



        //get profile details for admin
        public void loadAdminDetails(Label name, Label tazkira, Label email, Label contactnr, Image img, string sessionUserName)
        {
            connect.Close();
            connect.Open();

            string sql = "SELECT name, tazkiraid, email, contactnr,"
                + "photo FROM admin WHERE name='" + sessionUserName + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);

            //below code is for reading data of the single cell Name from database for dashboard.aspx page.
            SqlCommand cmd = new SqlCommand(sql, connect);
            //var reader = cmd.ExecuteReader();
            //reader.Read();

            if (datatable.Rows.Count > 0)
            {

                name.Text = datatable.Rows[0][0].ToString();
                tazkira.Text = datatable.Rows[0][1].ToString();
                email.Text = datatable.Rows[0][2].ToString();
                contactnr.Text = datatable.Rows[0][3].ToString();
                img.ImageUrl = "profileImages/" + datatable.Rows[0][4].ToString();
                connect.Close();


            }
        }





        //get profile Image from the database
        public void getAdminProfileImage(Image im)
        {

            connect.Open();
            //string sql = "SELECT photo FROM admin where name='" + HttpContext.Current.Session["user"] + "'";
            string sql = "SELECT photo FROM admin where name='admin'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);

            //below code is for reading data of the single cell Name from database for dashboard.aspx page.
            SqlCommand cmd = new SqlCommand(sql, connect);
            var reader = cmd.ExecuteReader();
            reader.Read();

            if (datatable.Rows.Count > 0)
            {
                string getImagePath = reader["photo"].ToString();
                im.ImageUrl = "~/profileImages/" + getImagePath;

                connect.Close();
            }
        }








        //end of the function class



        //===============================test part==============================//



    }

}
