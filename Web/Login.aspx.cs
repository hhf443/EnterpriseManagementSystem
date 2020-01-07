using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.website.Model;
using com.website.BLL;




namespace Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            MemberInfo member = this.ValidateUser(this.txtLoginName.Text, this.txtPassword.Text);
            if (member != null) //如果验证成功，保存当前会员信息以记录登录状态
            {
                Session["CurrentUser"] = member;
                Response.Redirect("MemberCenter.aspx"); //跳转到用户中心页面
            }
            Response.Write("<script>alert('用户名或密码错误！！！');location='Login.aspx';</script>");
        }

        /// <summary>
        /// 验证用户名和密码
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private MemberInfo ValidateUser(string loginName, string password)
        {
            /*
             * 验证用户名和密码，如果验证成功，返回该会员信息，否则返回null         
             */
            MemberInfo currentMember = MemberManager.GetMemberByLoginName(loginName);
            if (currentMember != null && password == currentMember.Password)
            {
                return currentMember;
            }
            return null;
        }
    }
}