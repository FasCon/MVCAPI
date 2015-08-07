using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataModel.ShoppingCart
{
    public class CartItemModel
    {
        public Guid ProductID { get; set; }
        public Guid ProductPrice { get; set; }
        public Guid ProductQuantity { get; set; }
    }
}
