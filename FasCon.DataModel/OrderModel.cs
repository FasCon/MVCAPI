using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataModel
{
    public class OrderModel
    {
        public System.Guid OrderId { get; set; }
        public string OrderNumber { get; set; }
        public System.Guid OrderGuid { get; set; }
        public System.Guid StoreId { get; set; }
        public System.Guid CustomerId { get; set; }
        public Guid? ShippingAddressId { get; set; }
        public int OrderStatusId { get; set; }
        public int ShippingStatusId { get; set; }
        public int PaymentStatusId { get; set; }
        public string VatNumber { get; set; }
        public decimal OrderSubtotal { get; set; }
        public decimal OrderTax { get; set; }
        public decimal OrderDiscount { get; set; }
        public decimal OrderTotal { get; set; }
        public string CustomerIp { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public DateTime? PaidDateUtc { get; set; }
        public string ShippingMethod { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime CreatedOnUtc { get; set; }
        public System.DateTime UpdatedOnUtc { get; set; }
        public string CustomerOrderComment { get; set; }
    }
}
