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
    public partial class NewOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ValidateUserPower();
            this.BindProduct();
        }

        /// <summary>
        /// 验证用户权限
        /// </summary>
        private void ValidateUserPower()
        {
            if (Session["CurrentUser"] as MemberInfo == null) this.Response.Redirect("Login.aspx");
        }

        /// <summary>
        /// 绑定产品
        /// </summary>
        private void BindProduct()
        {
            int id = this.GetProductId();
            ProductInfo product = ProductManager.GetProductById(id);
            if (product == null) Response.Redirect("ProductList.aspx");

            this.lblPrice.Text = product.Price.ToString();
            this.lblProductName.Text = product.Name;
        }

        /// <summary>
        /// 获取产品ID
        /// </summary>
        /// <returns></returns>
        private int GetProductId()
        {
            int id = 0;
            try { id = int.Parse(Request["id"]); }
            catch { }
            return id;
        }

        /// <summary>
        /// 获取当前用户ID
        /// </summary>
        /// <returns></returns>
        private int GetCurrentUserId()
        {
            MemberInfo currentMember = Session["CurrentUser"] as MemberInfo;
            return currentMember.ID;
        }

        /// <summary>
        /// 封装页面数据至对象
        /// </summary>
        /// <returns></returns>
        private OrderInfo GetOrderByPage()
        {
            OrderInfo newOrder = new OrderInfo();
            newOrder.ProductID = this.GetProductId();   //产品ID为提交过来的ID
            newOrder.MemberID = this.GetCurrentUserId();    //会员ID为当前登录账号ID
            try { newOrder.Number = int.Parse(this.txtNumber.Text); }
            catch { }
            newOrder.Details = this.txtDetails.Text;
            newOrder.PublishTime = DateTime.Now;
            return newOrder;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            OrderManager.CreateOrder(this.GetOrderByPage());
            Response.Write("<script>alert('提交成功，点击确定回到产品列表。');location='ProductList.aspx';</script>");
        }
    }
}