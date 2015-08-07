using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataModel.ShoppingCart
{
   public class ShippingAddressModel
    {
       public string ShippingName { get; set; }
       public string Phone { get; set; }
       public string Address { get; set; }
       public Guid StateId { get; set; }
       public Guid DistrictId { get; set; }

    }
}
