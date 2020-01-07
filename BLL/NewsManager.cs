using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.website.Model;
using com.website.DAL;

namespace com.website.BLL
{
    public static class NewsManager
    {
        static NewsService NS = new NewsService();

        public static IList<NewsInfo> GetNewsList()
        {
            return NS.GetNews();
        }

        public static IList<NewsInfo> GetNewsList(int topNumber)
        {
            return NS.GetNews(0, topNumber);
        }

        public static NewsInfo GetNewsById(int id)
        {
            return NS.GetNewsById(id) ;
        }

        public static void PublishNews(NewsInfo news)
        {
            NS.Append(news);
        }

        public static void DeleteNewsById(int id)
        {
            NS.DeleteById(id);
        }
    }
}
