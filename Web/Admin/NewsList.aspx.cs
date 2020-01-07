using com.website.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin
{
    public partial class NewsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.BindList();
            }
        }

        protected void BindList()
        {
            this.rptNews.DataSource = NewsManager.GetNewsList();
            this.rptNews.DataBind();
        }

        protected void lnkbtnDelete_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            NewsManager.DeleteNewsById(id); //根扭ID删除新闻
            this.BindList();	//删除后重新绑定列表，使页面与数据库同步
        }
    }
}