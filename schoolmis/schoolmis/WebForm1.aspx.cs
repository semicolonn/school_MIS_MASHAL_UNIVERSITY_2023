using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.PostedFile.SaveAs(HttpContext.Current.Server.MapPath("/profileImages/") + fileName);
            //HttpContext.Current.Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);
            Label1.Text = "uploaded!";
        }
    }
}