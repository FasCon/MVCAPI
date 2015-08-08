using FasCon.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataAccess.Repositories
{
    public class OrderRepository : BaseRepository
    {

        public OrderRepository()
            : base()
        {

        }
        public static Boolean UpdateOrder(OrderModel orderModel)
        {
            using (var db = new FasConDBEntities())
            {
                var order = db.Orders.Where(c => c.OrderId == orderModel.OrderId).FirstOrDefault();
                if (order == null)
                {
                    order = new Order
                    {
                        OrderId = orderModel.OrderId,
                        OrderNumber = orderModel.OrderNumber,
                        StoreId = orderModel.StoreId,
                        CustomerId = orderModel.CustomerId,
                        ShippingAddressId = orderModel.ShippingAddressId,
                        OrderStatusId = orderModel.OrderStatusId,
                        PaymentStatusId = orderModel.PaymentStatusId,
                        VatNumber = orderModel.VatNumber,
                        OrderSubtotal = orderModel.OrderSubtotal,
                        OrderTax = orderModel.OrderTax,
                        OrderTotal = orderModel.OrderTotal,
                        CustomerIp = orderModel.CustomerIp,
                        PaidDateUtc = orderModel.PaidDateUtc,
                        ShippingMethod = orderModel.ShippingMethod,
                        Deleted = orderModel.Deleted,
                        CreatedOnUtc = orderModel.CreatedOnUtc,
                        UpdatedOnUtc = orderModel.UpdatedOnUtc,
                        CustomerOrderComment = orderModel.CustomerOrderComment
                    };
                    db.Orders.Add(order);
                }
                else
                {
                    order.OrderId = orderModel.OrderId;
                    order.OrderNumber = orderModel.OrderNumber;
                    order.StoreId = orderModel.StoreId;
                    order.CustomerId = orderModel.CustomerId;
                    order.ShippingAddressId = orderModel.ShippingAddressId;
                    order.OrderStatusId = orderModel.OrderStatusId;
                    order.PaymentStatusId = orderModel.PaymentStatusId;
                    order.VatNumber = orderModel.VatNumber;
                    order.OrderSubtotal = orderModel.OrderSubtotal;
                    order.OrderTax = orderModel.OrderTax;
                    order.OrderTotal = orderModel.OrderTotal;
                    order.CustomerIp = orderModel.CustomerIp;
                    order.PaidDateUtc = orderModel.PaidDateUtc;
                    order.ShippingMethod = orderModel.ShippingMethod;
                    order.Deleted = orderModel.Deleted;
                    order.CreatedOnUtc = orderModel.CreatedOnUtc;
                    order.UpdatedOnUtc = orderModel.UpdatedOnUtc;
                    order.CustomerOrderComment = orderModel.CustomerOrderComment;

                }
                db.SaveChanges();
            }

            return true;
        }
        public static Boolean DeleteOrder(OrderModel orderModel)
        {

            return true;
        }

        public static List<OrderModel> FindOrderItemByCustomerId(Guid customerId)
        {
            List<OrderModel> rs = new List<OrderModel>();

            return rs;
        }
    }
}
