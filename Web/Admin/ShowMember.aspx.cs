using com.website.BLL;
using com.website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin
{
    public partial class ShowMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.BindMember();
            }
        }

        private void BindMember()
        {
            try
            {
                int id = int.Parse(Request["id"]);
                MemberInfo member = MemberManager.GetMemberById(id);
                this.lblAddress.Text = member.Address;
                this.lblAge.Text = member.Age.ToString();
                this.lblEmail.Text = member.Email;
                this.lblLoginName.Text = member.LoginName;
                this.lblPassword.Text = member.Password;
                this.lblPhone.Text = member.Phone;
                this.lblSex.Text = member.IsMale ? "男" : "女";
            }
            catch { }
        }
    }
}