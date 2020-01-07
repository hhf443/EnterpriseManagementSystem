using com.website.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin
{
    public partial class MemberList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.BindMembers();
            }
        }

        protected void lnkbtnDelete_Command(object sender, CommandEventArgs e)
        {
            try
            {
                int id = int.Parse(e.CommandArgument.ToString());
                MemberManager.DeleteById(id);
                this.BindMembers();
            }
            catch { }
        }

        private void BindMembers()
        {
            this.rptMembers.DataSource = MemberManager.GetMemberList();
            this.rptMembers.DataBind();
        }
    }
}