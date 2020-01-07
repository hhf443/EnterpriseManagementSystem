using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin
{
    public partial class Top : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lnkbtnLogout_Click(object sender, EventArgs e)
        {
            Session["CurrentAdmin"] = null;
            Response.Write("<script>top.location='Default.aspx';</script>");
        }
    }
}