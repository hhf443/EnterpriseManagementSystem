using com.website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindMemberInfo();
        }

        private void BindMemberInfo()
        {
            MemberInfo currentUser = Session["CurrentUser"] as MemberInfo;
            if (currentUser == null)
            {
                this.InitMemberInfo();
            }
            else
            {
                this.InitMemberInfo(currentUser.LoginName);
            }
        }

        private void InitMemberInfo()
        {
            this.hlMemberInfo.Text = "登录";
            this.hlMemberInfo.NavigateUrl = "Login.aspx";
        }

        private void InitMemberInfo(string loginName)
        {
            this.hlMemberInfo.Text = loginName;
            this.hlMemberInfo.NavigateUrl = "EditMemberInfo.aspx";
        }
    }
}