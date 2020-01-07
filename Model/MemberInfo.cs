using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.website.Model
{
    public class MemberInfo
    {
        int iD;
        string loginName;
        string password;
        bool isMale;
        int age;
        string phone;
        string email;
        string address;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool IsMale
        {
            get { return isMale; }
            set { isMale = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
