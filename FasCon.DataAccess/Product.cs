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
    
    public partial class Product
    {
        public Product()
        {
            this.OrderItems = new HashSet<OrderItem>();
            this.Product_Picture_Mapping = new HashSet<Product_Picture_Mapping>();
            this.ProductReviews = new HashSet<ProductReview>();
        }
    
        public System.Guid ProductID { get; set; }
        public string ProductSKU { get; set; }
        public string SEOURL { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string AdminComment { get; set; }
        public Nullable<bool> ShowOnHomePage { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public Nullable<bool> AllowCustomerReviews { get; set; }
        public Nullable<int> ApprovedRatingSum { get; set; }
        public Nullable<int> NotApprovedRatingSum { get; set; }
        public Nullable<int> ApprovedTotalReviews { get; set; }
        public Nullable<int> NotApprovedTotalReviews { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public Nullable<bool> IsShipEnabled { get; set; }
        public Nullable<bool> IsFreeShipping { get; set; }
        public Nullable<int> StockQuantity { get; set; }
        public Nullable<bool> DisplayStockAvailability { get; set; }
        public Nullable<bool> DisplayStockQuantity { get; set; }
        public Nullable<int> MinStockQuantity { get; set; }
        public Nullable<int> LowStockActivityId { get; set; }
        public Nullable<int> NotifyAdminForQuantityBelow { get; set; }
        public Nullable<int> OrderMinimumQuantity { get; set; }
        public Nullable<int> OrderMaximumQuantity { get; set; }
        public string AllowedQuantities { get; set; }
        public Nullable<bool> DisableBuyButton { get; set; }
        public Nullable<bool> DisableWishlistButton { get; set; }
        public Nullable<bool> CallForPrice { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> OldPrice { get; set; }
        public Nullable<decimal> ProductCost { get; set; }
        public Nullable<decimal> SpecialPrice { get; set; }
        public Nullable<System.DateTime> SpecialPriceStartDateTimeUtc { get; set; }
        public Nullable<System.DateTime> SpecialPriceEndDateTimeUtc { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> Length { get; set; }
        public Nullable<decimal> Width { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<System.DateTime> AvailableStartDateTimeUtc { get; set; }
        public Nullable<System.DateTime> AvailableEndDateTimeUtc { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public Nullable<bool> Published { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<System.DateTime> CreatedOnUtc { get; set; }
        public Nullable<System.DateTime> UpdatedOnUtc { get; set; }
        public string ProductThumb { get; set; }
        public string ProductImage { get; set; }
        public Nullable<System.Guid> CategoryID { get; set; }
        public Nullable<System.Guid> StoreId { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Product_Picture_Mapping> Product_Picture_Mapping { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual Store Store { get; set; }
    }
}