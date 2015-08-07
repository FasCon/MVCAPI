using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataModel
{
    public class AddressModel
    {
        public System.Guid AddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public Nullable<int> StateProvinceId { get; set; }
        public string Street { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public System.DateTime CreatedOnUtc { get; set; }
    }
}
