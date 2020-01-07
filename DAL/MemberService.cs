using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using com.website.Model;

namespace com.website.DAL
{
    public class MemberService
    {
        public IList<MemberInfo> GetMembers()
        {
            string sql = "select * from tbl_member";
            return this.GetProductsBySql(sql);
        }

        public MemberInfo GetMemberById(int id)
        {
            string sql = "select * from tbl_member where id = " + id;
            IList<MemberInfo> memberList = this.GetProductsBySql(sql);
            if (memberList.Count > 0)
            {
                return memberList[0];
            }
            else
            {
                return null;
            }
        }

        public MemberInfo GetMemberByLoginName(string loginName)
        {
            string sql = "select * from tbl_member where m_login_name = @LoginName";
            Dictionary<string, object> prams = new Dictionary<string, object>();
            prams.Add("@LoginName", loginName);
            MemberInfo member = null;
            using (DbDataReader reader = DBHelper.ExecuteReader(sql,prams))
            {
                while (reader.Read())
                {
                    member=this.GetProductByReader(reader);
                }
            }
            return member;
        }

        public void Append(MemberInfo member)
        {
            string sql = "insert into tbl_member values(@LoginName, @Password, @IsMale, @Age, @Phone, @Email, @Address)";
            Dictionary<string, object> prams = new Dictionary<string, object>();
            prams.Add("@LoginName", member.LoginName);
            prams.Add("@Password", member.Password);
            prams.Add("@IsMale", member.IsMale);
            prams.Add("@Age", member.Age);
            prams.Add("@Phone", member.Phone);
            prams.Add("@Email", member.Email);
            prams.Add("@Address", member.Address);

            DBHelper.ExecuteNonQuery(sql, prams);
        }

        public void Update(MemberInfo member)
        {
            string sql = "update tbl_member set m_login_name = @LoginName, m_password = @Password, m_is_male = @IsMale,"+
                " m_age = @Age, m_phone = @Phone, m_email = @Email, m_address = @Address where id = @ID";
            Dictionary<string, object> prams = new Dictionary<string, object>();
            prams.Add("@LoginName", member.LoginName);
            prams.Add("@Password", member.Password);
            prams.Add("@IsMale", member.IsMale);
            prams.Add("@Age", member.Age);
            prams.Add("@Phone", member.Phone);
            prams.Add("@Email", member.Email);
            prams.Add("@Address", member.Address);
            prams.Add("@ID", member.ID);

            DBHelper.ExecuteNonQuery(sql, prams);
        }

        public void DeleteById(int id)
        {
            string sql = "delete tbl_member where id = " + id;
            DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 执行SQL语句，并封装List
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private IList<MemberInfo> GetProductsBySql(string sql)
        {
            IList<MemberInfo> memberList = new List<MemberInfo>();
            using (DbDataReader reader = DBHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    memberList.Add(this.GetProductByReader(reader));
                }
            }
            return memberList;
        }

        /// <summary>
        /// 从Reader里取出值并封装对象
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private MemberInfo GetProductByReader(DbDataReader reader)
        {
            MemberInfo newMember = new MemberInfo();
            newMember.ID = reader.GetInt32(0);
            newMember.LoginName = reader.GetString(1);
            newMember.Password = reader.GetString(2);
            newMember.IsMale = reader.GetBoolean(3);
            newMember.Age = reader.GetInt32(4);
            newMember.Phone = reader.GetString(5);
            newMember.Email = reader.GetString(6);
            newMember.Address = reader.GetString(7);
            return newMember;
        }
    }
}

/*
 
 create table tbl_member(
	id int identity(1,1) primary key,
	m_login_name varchar(20) not null,
	m_password varchar(20) not null,
	m_is_male bit not null,
	m_age int not null,
	m_phone varchar(20) not null,
	m_email varchar(50) not null,
	m_address varchar(255) not null

 */