using com.website.BLL;
using com.website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            MemberInfo member = this.GetMemberByPage();
            //如果按会员名称查询能取得会员信息，说明该用户名己存在，不能再次注册
            if (MemberManager.GetMemberByLoginName(member.LoginName) != null)
            {
                Response.Write("<script>alert('用户名己存在，请换个用户名注册。');location='Register.aspx';</script>");
                return;
            }
            MemberManager.CreateMember(member); //创建用户
            Response.Write("<script>alert('注册成功，请登录。');location='Login.aspx';</script>");
        }

        /// <summary>
        /// 封装页面上的值到对象
        /// </summary>
        /// <returns></returns>
        private MemberInfo GetMemberByPage()
        {
            MemberInfo member = new MemberInfo();
            member.LoginName = this.txtLoginName.Text;
            member.Password = this.txtPassword.Text;
            member.IsMale = bool.Parse(this.rblIsMale.Text);
            try { int.Parse(this.txtAge.Text); }
            catch { }
            member.Email = this.txtEmail.Text;
            member.Phone = this.txtPhone.Text;
            member.Address = this.txtAddress.Text;
            return member;
        }
    }
}