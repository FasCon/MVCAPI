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
            using (var db = new FasConDBEntities())
            {
                var orderItem = db.OrderItems.Where(c => c.OrderId == orderItemModel.OrderId).FirstOrDefault();
                if (orderItem == null)
                {
                    orderItem = new OrderItem
                    {
                        Id=Guid.NewGuid(),
                        OrderId = orderItemModel.OrderId,
                        ProductId = orderItemModel.ProductId,
                        Quantity = orderItemModel.Quantity,
                        Price = orderItemModel.Price,
                        DiscountAmount = orderItemModel.DiscountAmount,
                        ProductCost = orderItemModel.ProductCost,
                        CreatedDate=orderItem.CreatedDate,
                        CreatedUserId=orderItem.CreatedUserId
                    };
                    db.OrderItems.Add(orderItem);
                }
                else
                {
                    orderItem.OrderId = orderItemModel.OrderId;
                    orderItem.Id = orderItemModel.Id;
                    orderItem.Quantity = orderItemModel.Quantity;
                    orderItem.Price = orderItemModel.Price;
                    orderItem.DiscountAmount = orderItemModel.DiscountAmount;
                    orderItem.ProductCost = orderItemModel.ProductCost;
                    orderItem.UpdateDate = orderItemModel.UpdateDate;
                    orderItem.UpdateUserId = orderItemModel.UpdateUserId;
                }
                db.SaveChanges();
            }
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
