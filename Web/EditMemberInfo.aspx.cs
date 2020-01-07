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
    public partial class EditMemberInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.divResult.InnerHtml = "";
            this.ValidateUserPower();
            if (!IsPostBack)
            {
                this.FullPage();
            }
        }

        /// <summary>
        /// 验证用户权限
        /// </summary>
        private void ValidateUserPower()
        {
            if (Session["CurrentUser"] as MemberInfo == null) this.Response.Redirect("Login.aspx");
        }

        private void FullPage()
        {
            /*
             * 取出当前用户信息，填充至页面控件
             */
            MemberInfo member = Session["CurrentUser"] as MemberInfo;
            this.lblLoginName.Text = member.LoginName;
            this.txtPhone.Text = member.Phone;
            this.txtEmail.Text = member.Email;
            this.txtAge.Text = member.Age.ToString();
            this.txtAddress.Text = member.Address;
            //页面控件里的值是true或false，所以这里要转换成小写
            this.rblIsMale.SelectedValue = member.IsMale.ToString().Trim().ToLower();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            MemberInfo member = this.GetMemberForPage();
            switch (this.ValidateOldPassword())
            {
                case 0:
                    //这里和业务逻辑层约定，如果密码为null，就不修改密码
                    member.Password = null;
                    break;
                case 1:
                    this.divResult.InnerHtml = "<script>alert('旧密码输入错误。');</script>";
                    return;
                case 2:
                    if (this.txtPassword.Text == string.Empty)  //判断输入的新密码是否为空
                    {
                        this.divResult.InnerHtml = "<script>alert('新密码不能为空。');</script>";
                        return;
                    }
                    else if (this.txtRePassword.Text != this.txtPassword.Text)  //两次新密码是否一致
                    {
                        this.divResult.InnerHtml = "<script>alert('两次密码必需一致。');</script>";
                        return;
                    }
                    else
                    {
                        member.Password = this.txtPassword.Text;
                    }
                    break;
            }
            MemberManager.ModifyMemberInfo(member);
            Session["CurrentUser"] = MemberManager.GetMemberByLoginName(member.LoginName);
            this.divResult.InnerHtml = "<script>alert('保存成功。');</script>";
        }

        /// <summary>
        /// 从页面获取会员信息
        /// </summary>
        /// <returns></returns>
        private MemberInfo GetMemberForPage()
        {
            MemberInfo member = new MemberInfo();
            member.LoginName = this.lblLoginName.Text;
            member.Phone = this.txtPhone.Text;
            member.IsMale = bool.Parse(this.rblIsMale.SelectedValue);
            try { member.Age = int.Parse(this.txtAge.Text); }
            catch { }
            member.Address = this.txtAddress.Text;
            member.Email = this.txtEmail.Text;
            return member;
        }

        /// <summary>
        /// 验证旧密码
        /// </summary>
        /// <returns>0旧密码为空，不修改密码，1密码不正确，2验证通过</returns>
        private int ValidateOldPassword()
        {
            string oldPass = this.txtOldPassword.Text;
            string loginName = this.lblLoginName.Text;

            if (oldPass.Length <= 0)    //如果旧密码为空
            {
                return 0;
            }
            else
            {
                //从数据库取出当前用户信息
                MemberInfo member = MemberManager.GetMemberByLoginName(loginName);
                if (oldPass != member.Password) //如果密码输入不正确
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}