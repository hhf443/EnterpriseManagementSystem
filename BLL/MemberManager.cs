using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.website.DAL;
using com.website.Model;

namespace com.website.BLL
{
    public static class MemberManager
    {
        static MemberService MS = new MemberService();
        static OrderService OS = new OrderService();

        public static IList<MemberInfo> GetMemberList()
        {
            return MS.GetMembers();
        }

        public static MemberInfo GetMemberById(int id)
        {
            return MS.GetMemberById(id) ;
        }

        public static MemberInfo GetMemberByLoginName(string loginName)
        {
            return MS.GetMemberByLoginName(loginName);
        }

        public static void CreateMember(MemberInfo newMember)
        {
            MS.Append(newMember);
        }

        public static void ModifyMemberInfo(MemberInfo member)
        {
            MemberInfo oldMember = MS.GetMemberByLoginName(member.LoginName);
            member.ID = oldMember.ID;
            //如果密码为null，表示不修改密码把旧密码赋给新对象
            if (member.Password == null) member.Password = oldMember.Password;
            MS.Update(member);  //用新对象更新数据库
        }

        public static void DeleteById(int id)
        {
            OS.DeleteByMemberID(id);
            MS.DeleteById(id);
        }
    }
}
