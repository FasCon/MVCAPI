using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataModel
{
    public class StoreModel
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Nullable<System.Guid> LogoPictureId { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Nullable<System.Guid> CreatedUserId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateUserId { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<bool> Actived { get; set; }
        public Nullable<System.Guid> OwnerId { get; set; }
        public string Comment { get; set; }
    
    }
}
