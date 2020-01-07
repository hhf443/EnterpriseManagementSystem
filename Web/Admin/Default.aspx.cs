using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void imgbtnLogin_Click(object sender, ImageClickEventArgs e)
        {
            string username = this.txtLoginName.Text.Trim();
            string password = this.txtPassword.Text;

            if (username == "admin" && password == "admin")
            {
                Session["CurrentAdmin"] = "admin";	//记录用户验证状态
                Response.Redirect("Main.aspx");	//跳转到管理主页面
                return;
            }
            Response.Write("<script>alert('请使用管理员账号登陆！\\n请重新登录。');location='Default.aspx';</script>");
            Response.End();
        }
    }
}