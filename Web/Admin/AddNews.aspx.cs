using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.website.BLL;
using com.website.Model;



namespace Web.Admin
{
    public partial class AddNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            NewsInfo news = this.PackagingNewsForPage();
            NewsManager.PublishNews(news);  //发布新闻
            Response.Write("<script>alert('发布成功。点确定返回新闻列表。');location='NewsList.aspx';</script>");
        }

        /// <summary>
        /// 封装新闻信息
        /// </summary>
        /// <returns></returns>
        private NewsInfo PackagingNewsForPage()
        {
            NewsInfo news = new NewsInfo();
            news.PublishTime = DateTime.Now;
            news.Title = this.txtTitle.Text;
            news.Content = this.txtContent.Text;
            return news;
        }
    }
}