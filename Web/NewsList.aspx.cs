using com.website.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class NewsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindNews();
        }

        /// <summary>
        /// 新闻列表绑定
        /// </summary>
        private void BindNews()
        {
            this.rptNews.DataSource = NewsManager.GetNewsList();
            this.rptNews.DataBind();
        }
    }
}