using FasCon.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataAccess.Repositories
{
    public class AddressRepository
    {

        public AddressRepository()
            : base()
        {

        }
        public static Boolean UpdateAddress(AddressModel addressModel)
        {
            using (var db = new FasConDBEntities())
            {
                 
                
            }

            return true;
        }
        public static Boolean DeleteAddress(AddressModel orderItemModel)
        {

            return true;
        }

        public static List<AddressModel> FindAddressByCustomerId(Guid customerId)
        {
            List<AddressModel> rs = new List<AddressModel>();

            return rs ;
        }
    }
}
