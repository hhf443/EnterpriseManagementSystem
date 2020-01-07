using com.website.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindProduct();
        }

        /// <summary>
        /// 产品列表绑定
        /// </summary>
        private void BindProduct()
        {
            this.dlProduct.DataSource = ProductManager.GetProductList();
            this.dlProduct.DataBind();
        }

        protected void dlProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}