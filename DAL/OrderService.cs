using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using com.website.Model;

namespace com.website.DAL
{
    public class OrderService
    {
        public void Append(OrderInfo order)
        {
            string sql = "insert into tbl_order values(@ProductID, @MemberID, @Number, @PublishTime, @Details, @Status)";
            Dictionary<string, object> prams = new Dictionary<string, object>();
            prams.Add("@ProductID", order.ProductID);
            prams.Add("@MemberID", order.MemberID);
            prams.Add("@Number", order.Number);
            prams.Add("@PublishTime", order.PublishTime);
            prams.Add("@Details", order.Details);
            prams.Add("@Status", order.Status);

            DBHelper.ExecuteNonQuery(sql, prams);
        }

        public OrderInfo GetByID(int id)
        {
            string sql = "select * from tbl_order where id = " + id;
            IList<OrderInfo> orders = this.GetOrdersBySql(sql);
            if (orders != null && orders.Count > 0)
            {
                return orders[0];
            }
            else
            {
                return null;
            }
        }

        public IList<OrderInfo> GetOrdersByMemberID(int id)
        {
            string sql = "select * from tbl_order where o_member_id = " + id + " order by id desc";
            return this.GetOrdersBySql(sql);
        }

        public IList<OrderInfo> GetOrders()
        {
            string sql = "select * from tbl_order order by id desc";
            return this.GetOrdersBySql(sql);
        }

        public void DeleteByProductID(int id)
        {
            string sql = "delete tbl_order where o_product_id = " + id;
            DBHelper.ExecuteNonQuery(sql);
        }

        public void DeleteByMemberID(int id)
        {
            string sql = "delete tbl_order where o_member_id = " + id;
            DBHelper.ExecuteNonQuery(sql);
        }

        public void DeleteByID(int id)
        {
            string sql = "delete tbl_order where id = " + id;
            DBHelper.ExecuteNonQuery(sql);
        }

        public void Update(OrderInfo order)
        {
            string sql = "update tbl_order set o_product_id = @ProductID, o_member_id = @MemberID," +
                " o_number = @Number, o_publish_time = @PublishTime, o_details = @Details, o_status = @Status where id = @ID";
            Dictionary<string, object> prams = new Dictionary<string, object>();
            prams.Add("@ProductID", order.ProductID);
            prams.Add("@MemberID", order.MemberID);
            prams.Add("@Number", order.Number);
            prams.Add("@PublishTime", order.PublishTime);
            prams.Add("@Details", order.Details);
            prams.Add("@Status", order.Status);
            prams.Add("@ID", order.ID);

            DBHelper.ExecuteNonQuery(sql, prams);
        }

        private IList<OrderInfo> GetOrdersBySql(string sql)
        {
            IList<OrderInfo> orders = new List<OrderInfo>();
            using (DbDataReader reader = DBHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    orders.Add(this.GetOrderByReader(reader));
                }
            }
            return orders;
        }

        private OrderInfo GetOrderByReader(DbDataReader reader)
        {
            OrderInfo order = new OrderInfo();
            order.ID = reader.GetInt32(0);
            order.ProductID = reader.GetInt32(1);
            order.MemberID = reader.GetInt32(2);
            order.Number = reader.GetInt32(3);
            order.PublishTime = reader.GetDateTime(4);
            order.Details = reader.GetString(5);
            order.Status = reader.GetBoolean(6);
            return order;
        }

    }
}

/*

create table tbl_order(
	id int identity(1,1) primary key,
	o_product_id int foreign key references tbl_product(id) not null,
	o_member_id int foreign key references tbl_member(id) not null,
	o_number int not null,
	o_publish_time datetime not null,
	o_details text,
	o_status bit
)
 
 */