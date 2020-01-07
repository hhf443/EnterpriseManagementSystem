using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.website.Model
{
    public class OrderInfo
    {
        int iD;
        int productID;
        int memberID;
        int number;
        DateTime publishTime;
        string details;
        bool status;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public int MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public DateTime PublishTime
        {
            get { return publishTime; }
            set { publishTime = value; }
        }

        public string Details
        {
            get { return details; }
            set { details = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}
