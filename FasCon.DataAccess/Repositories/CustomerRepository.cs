using FasCon.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataAccess.Repositories
{
    public class CustomerRepository
    {
        public CustomerRepository()
            : base()
        {

        }
        public static Boolean UpdateOrder(CustomerModel orderModel)
        {

            return true;
        }
        public static Boolean DeleteOrder(CustomerModel orderModel)
        {

            return true;
        }

        public static List<CustomerModel> FindOrderItemByCustomerId(Guid customerId)
        {
            List<CustomerModel> rs = new List<CustomerModel>();

            return rs ;
        }
    }
}
