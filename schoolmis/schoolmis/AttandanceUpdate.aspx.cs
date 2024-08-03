using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolmis
{
    public partial class AttandanceUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                functions.loadClassGradeDdl(classgradeddl);
            }
        }

        protected void updateAttandanceBtn_Click(object sender, EventArgs e)
        {

        }
    }
}