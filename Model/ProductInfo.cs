using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.website.Model
{
    public class ProductInfo
    {
        int iD;
        string name;
        string picture;
        int price;
        string details;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Details
        {
            get { return details; }
            set { details = value; }
        }
    }
}
