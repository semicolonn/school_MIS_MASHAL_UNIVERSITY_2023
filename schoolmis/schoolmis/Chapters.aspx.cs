using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class Chapters : System.Web.UI.Page
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


                functions.getUserProfileImage(Master.imge);

                bookChapterGrdVw.Visible = false;

                functions.loadClassGrades(classGrdddl);
            }
        }

        protected void loadBooksChapters_Click(object sender, EventArgs e)
        {
            bookChapterGrdVw.Visible = true;
            f.loadBooksChapterTable(bookChapterGrdVw, classGrdddl);
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {

            Button linkDownload = sender as Button;
            GridViewRow r = linkDownload.NamingContainer as GridViewRow;
            string downLoadFile = bookChapterGrdVw.DataKeys[r.RowIndex].Value.ToString();
            ContentType = "file/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=\"" + downLoadFile + "\"");
            Response.TransmitFile(Server.MapPath(downLoadFile));
            Response.End();

        }
    }
}