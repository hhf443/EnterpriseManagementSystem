using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ValidateCurrentAdmin();
        }

        private void ValidateCurrentAdmin()
        {
            string uname = Session["CurrentAdmin"] as string;
            if (uname == null || uname.Trim() == string.Empty)
            {
                Response.Write("<script>alert('尚未登录或己经超时，请重新登录。');top.location='Default.aspx';</script>");
            }
        }
    }
}