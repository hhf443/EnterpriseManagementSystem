using com.website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class MemberCenter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ValidateUserPower();
            Response.Redirect("OrderList.aspx");
        }

        /// <summary>
        /// 验证用户权限
        /// </summary>
        private void ValidateUserPower()
        {
            if (Session["CurrentUser"] as MemberInfo == null) this.Response.Redirect("Login.aspx");
        }
    }
}