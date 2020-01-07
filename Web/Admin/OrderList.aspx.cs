using com.website.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin
{
    public partial class OrderList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.BindList();
            }
        }

        protected void lnkbtnChangeStatus_Command(object sender, CommandEventArgs e)
        {
            try
            {
                int id = int.Parse(e.CommandArgument.ToString());
                OrderManager.ChangeStatus(id);
            }
            catch { }
            this.BindList();
        }

        protected string ConvertProduct(object oid)
        {
            try
            {
                int id = int.Parse(oid.ToString());
                return ProductManager.GetProductById(id).Name;
            }
            catch { return ""; }
        }

        protected string ConvertMember(object oid)
        {
            try
            {
                int id = int.Parse(oid.ToString());
                return MemberManager.GetMemberById(id).LoginName;
            }
            catch { return ""; }
        }

        private void BindList()
        {
            this.rptOrders.DataSource = OrderManager.GetOrderList();
            this.rptOrders.DataBind();
        }
    }
}