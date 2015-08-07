using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataModel
{
    public class CategoryModel
    {
        public System.Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Alias { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public Nullable<System.Guid> ParentCategoryId { get; set; }
        public Nullable<System.Guid> PictureId { get; set; }
        public Nullable<bool> ShowOnHomePage { get; set; }
        public Nullable<bool> Published { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public Nullable<System.DateTime> CreatedOnUtc { get; set; }
        public Nullable<System.DateTime> UpdatedOnUtc { get; set; }
        public string FullName { get; set; }
        public string BottomDescription { get; set; }
        public Nullable<int> Hits { get; set; }
        public Guid? StoreId { get; set; }
    }
}
