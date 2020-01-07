using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.website.Model
{
    public class NewsInfo
    {
        int iD;
        string title;
        DateTime publishTime;
        string content;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public DateTime PublishTime
        {
            get { return publishTime; }
            set { publishTime = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

    }
}
