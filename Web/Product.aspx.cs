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
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindProduct();
        }

        /// <summary>
        /// 绑定产品
        /// </summary>
        private void BindProduct()
        {
            int id = 0;
            try { id = int.Parse(Request["id"]); }
            catch { }
            ProductInfo product = ProductManager.GetProductById(id);
            if (product == null) Response.Redirect("ProductList.aspx");

            this.lblDetails.Text = product.Details;
            this.lblName.Text = product.Name;
            this.imgPicture.ImageUrl = product.Picture;
            this.lblPrice.Text = product.Price.ToString();
            this.hlProduct.NavigateUrl = "NewOrder.aspx?id=" + product.ID;
        }
    }
}