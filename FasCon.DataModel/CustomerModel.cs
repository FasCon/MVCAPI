using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataModel
{
    public class CustomerModel
    {
        public System.Guid CustomerId { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<System.Guid> CreatedUserId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> UpdatedUserId { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.Guid> StoreId { get; set; }
    }
}
