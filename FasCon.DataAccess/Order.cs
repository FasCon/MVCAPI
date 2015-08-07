//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FasCon.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.OrderItems = new HashSet<OrderItem>();
            this.OrderNotes = new HashSet<OrderNote>();
        }
    
        public System.Guid OrderId { get; set; }
        public string OrderNumber { get; set; }
        public System.Guid OrderGuid { get; set; }
        public System.Guid StoreId { get; set; }
        public System.Guid CustomerId { get; set; }
        public Nullable<System.Guid> ShippingAddressId { get; set; }
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
        public Nullable<System.DateTime> PaidDateUtc { get; set; }
        public string ShippingMethod { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime CreatedOnUtc { get; set; }
        public System.DateTime UpdatedOnUtc { get; set; }
        public string CustomerOrderComment { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<OrderNote> OrderNotes { get; set; }
    }
}
