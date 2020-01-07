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
    public partial class News : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindNews();
        }

        /// <summary>
        /// 绑定新闻内容
        /// </summary>
        private void BindNews()
        {
            int id = 0;
            try { id = int.Parse(Request["id"]); }
            catch { }
            NewsInfo news = NewsManager.GetNewsById(id);//根据ID获得新闻
            //如果该新闻不存在，跳回新闻列表页面
            if (news == null) Response.Redirect("NewsList.aspx");

            this.lblContent.Text = news.Content;
            this.lblPublishTime.Text = news.PublishTime + "";
            this.lblTitle.Text = news.Title;
        }
    }
}