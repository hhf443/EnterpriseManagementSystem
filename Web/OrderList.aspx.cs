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
    public partial class OrderList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindOrder();
            this.ValidateUserPower();
        }

        /// <summary>
        /// 验证用户权限
        /// </summary>
        private void ValidateUserPower()
        {
            if (Session["CurrentUser"] as MemberInfo == null) this.Response.Redirect("Login.aspx");
        }

        protected string GetProductNameById(object oid)
        {
            ProductInfo product = ProductManager.GetProductById(int.Parse(oid.ToString()));
            return product.Name;
        }

        /// <summary>
        /// 绑定订单列表
        /// </summary>
        private void BindOrder()
        {
            MemberInfo member = Session["CurrentUser"] as MemberInfo;
            if (member != null)
            {
                //根据当前登录用户ID取出当前用户的订单信息
                this.rptOrders.DataSource = OrderManager.GetOrderListByMemberID(member.ID);
                this.rptOrders.DataBind();
            }
        }
    }
}