using FasCon.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataAccess.Repositories
{
    public class OrderItemRepository:BaseRepository
    {
        public OrderItemRepository()
            : base()
        {

        }
        public static Boolean UpdateOrderItem(OrderItemModel orderItemModel)
        {

            return true;
        }
        public static Boolean DeleteOrderItem(OrderItemModel orderItemModel)
        {

            return true;
        }

        public static List<OrderItemModel> FindOrderItemByOrderId(Guid orderId)
        {
            List<OrderItemModel> rs = new List<OrderItemModel>();

            return rs ;
        }
    }
}
