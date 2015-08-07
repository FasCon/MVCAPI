using FasCon.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataAccess.Repositories
{
    public class OrderRepository:BaseRepository
    {

        public OrderRepository()
            : base()
        {

        }
        public static Boolean UpdateOrder(OrderModel orderModel)
        {

            return true;
        }
        public static Boolean DeleteOrder(OrderModel orderModel)
        {

            return true;
        }

        public static List<OrderModel> FindOrderItemByCustomerId(Guid customerId)
        {
            List<OrderModel> rs = new List<OrderModel>();

            return rs ;
        }
    }
}
