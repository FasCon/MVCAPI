using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataModel
{
   public class OrderItemModel
    {
        public System.Guid Id { get; set; }
        public System.Guid OrderItemGuid { get; set; }
        public System.Guid OrderId { get; set; }
        public System.Guid ProductId { get; set; }
        public System.Guid Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal ProductCost { get; set; }
    }
}
