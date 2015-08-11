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
                var address = db.Addresses.Where(p => p.AddressId == addressModel.AddressId).FirstOrDefault();
                bool isNew = false;
                if (address == null)
                {
                    isNew = true;
                    address = new Address();
                    address.AddressId = Guid.NewGuid();
                }
                address.FullName = addressModel.FullName;
                address.Email = addressModel.Email;
                address.Company = addressModel.Company;
                address.DistrictId = addressModel.DistrictId;
                address.StateProvinceId = addressModel.StateProvinceId;
                address.Street = addressModel.Street;
                address.PhoneNumber = addressModel.PhoneNumber;
                address.FaxNumber = addressModel.FaxNumber;
                address.CreatedOnUtc = addressModel.CreatedOnUtc;
                if(isNew)
                db.Addresses.Add(address);

                db.SaveChanges();

                 
                
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
