using com.website.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Default : System.Web.UI.Page
    {
        private static int NEWS_LIST_SIZE = 5; //新闻列表大小
        private static int PRODUCT_LIST_SIZE = 6;   //产品列表大小

        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindNews();
            this.BindProduct();
        }

        /// <summary>
        /// 新闻列表绑定
        /// </summary>
        private void BindNews()
        {
            this.rptNews.DataSource = NewsManager.GetNewsList(NEWS_LIST_SIZE);
            this.rptNews.DataBind();
        }

        /// <summary>
        /// 产品列表绑定
        /// </summary>
        private void BindProduct()
        {
            this.dlProduct.DataSource = ProductManager.GetProductList(PRODUCT_LIST_SIZE);
            this.dlProduct.DataBind();
        }
    }
}