using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.website.Model;
using System.Data.Common;

namespace com.website.DAL
{
    public class NewsService
    {

        public IList<NewsInfo> GetNews(int startNumber, int length)
        {
            string sql = "select top " + length + " * from tbl_news where id not in (select top "
                + startNumber + " id from tbl_news order by id desc) order by id desc";
            return this.GetNewsBySql(sql);
        }

        public NewsInfo GetNewsById(int id)
        {
            string sql = "select * from tbl_news where id = " + id;
            IList<NewsInfo> newsList = this.GetNewsBySql(sql);
            if (newsList.Count > 0)
            {
                return newsList[0];
            }
            else
            {
                return null;
            }
        }

        public void Append(NewsInfo news)
        {
            //创建SQL语句
            string sql = "insert into tbl_news values(@Title, @PublishTime, @Content)";
            //创建字典对象封装参数
            Dictionary<string, object> prams = new Dictionary<string, object>();
            prams.Add("@Title", news.Title);
            prams.Add("@PublishTime", news.PublishTime);
            prams.Add("@Content", news.Content);
            DBHelper.ExecuteNonQuery(sql, prams);   //执行带参数的SQL语句
        }

        public void DeleteById(int id)
        {
            string sql = "delete tbl_news where id = " + id;
            DBHelper.ExecuteNonQuery(sql);
        }

        public IList<NewsInfo> GetNews()
        {
            string sql = "select * from tbl_news order by id desc"; //创建SQL语句
            return this.GetNewsBySql(sql);
        }

        /// <summary>
        /// 执行SQL语句，并封装List
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private IList<NewsInfo> GetNewsBySql(string sql)
        {
            IList<NewsInfo> newsList = new List<NewsInfo>();
            //用using语句管理reader，使用完自动释放资源
            using (DbDataReader reader = DBHelper.ExecuteReader(sql))
            {
                //循环遍历reader，取出值并封装到集合中
                while (reader.Read())
                {
                    newsList.Add(this.GetNewsByReader(reader));
                }
            }
            return newsList;
        }

        /// <summary>
        /// 从Reader里取出值并封装对象
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private NewsInfo GetNewsByReader(DbDataReader reader)
        {
            /*
             * 从reader中取值并封装News对象             
             */
            NewsInfo newNews = new NewsInfo();
            newNews.ID = reader.GetInt32(0);
            newNews.Title = reader.GetString(1);
            newNews.PublishTime=reader.GetDateTime(2);
            newNews.Content = reader.GetString(3);
            return newNews;
        }
    }
}

/*
  
create table tbl_news(
	id int identity(1,1) primary key,
	n_title nvarchar(100) not null,
	n_publish_time datetime not null,
	n_content text not null
  
 */