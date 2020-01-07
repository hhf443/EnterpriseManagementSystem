using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.website.Model;
using com.website.DAL;

namespace com.website.BLL
{
    public static class OrderManager
    {
        static OrderService OS = new OrderService();

        public static void CreateOrder(OrderInfo order)
        {
            OS.Append(order);
        }

        public static IList<OrderInfo> GetOrderListByMemberID(int id)
        {
            return OS.GetOrdersByMemberID(id);
        }

        public static IList<OrderInfo> GetOrderList()
        {
            return OS.GetOrders();
        }

        public static void ChangeStatus(int id)
        {
            OrderInfo order = OS.GetByID(id);
            order.Status = !order.Status;
            OS.Update(order);
        }

    }
}
