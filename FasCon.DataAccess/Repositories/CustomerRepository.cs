using AutoMapper;
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
            Mapper.CreateMap<Customer, CustomerModel>();
        }
        /// <summary>
        /// Add new or update exist customer
        /// </summary>
        /// <param name="orderModel"></param>
        /// <returns></returns>
        public static Boolean UpdateCustomer(CustomerModel customerModel)
        {
            using (var db = new FasConDBEntities())
            {
                var customer = db.Customers.Where(c => c.CustomerId == customerModel.CustomerId).FirstOrDefault();
                if (customer == null)
                {
                    customer = new Customer
                    {
                        CustomerId = Guid.NewGuid(),
                        Name = customerModel.Name,
                        UpdatedDate = DateTime.Now,
                        UpdatedUserId = customerModel.UpdatedUserId,
                        CreatedDate = DateTime.Now,
                        CreatedUserId = customerModel.CreatedUserId,
                        StoreId = customerModel.StoreId
                    };
                    db.Customers.Add(customer);
                }
                else
                {
                    customer.Name = customerModel.Name;
                    customer.UpdatedDate = DateTime.Now;
                    customer.UpdatedUserId = customerModel.UpdatedUserId;
                    customerModel.Deleted = customerModel.Deleted;
                    customer.StoreId = customerModel.StoreId;
                }
                db.SaveChanges();
            }
            return true;
        }
        public static Boolean DeleteCustomer(CustomerModel customerModel)
        {
            using (var db = new FasConDBEntities())
            {
                var order = db.Orders.Where(c => c.CustomerId == customerModel.CustomerId).FirstOrDefault();
                if (order == null)
                {
                    var customer = db.Customers.Where(c => c.CustomerId == customerModel.CustomerId).FirstOrDefault();
                    if (customer != null)
                        db.Customers.Remove(customer);
                    db.SaveChanges();
                }

            }
            return true;
        }

        public static List<CustomerModel> Customers()
        {
            List<CustomerModel> rs = new List<CustomerModel>();
            using (var db = new FasConDBEntities())
            {
                rs = db.Customers.Where(c => c.Deleted == false).Select(c => new CustomerModel { CustomerId = c.CustomerId, Name = c.Name }).ToList();
            }
            return rs;
        }
         

        public static CustomerModel Customer(Guid customerId)
        {
            CustomerModel rs = new CustomerModel();
            using (var db = new FasConDBEntities())
            {
                rs = db.Customers.Where(c => c.Deleted == false && c.CustomerId == customerId).Select(c => new CustomerModel { CustomerId = c.CustomerId, Name = c.Name }).FirstOrDefault();
            }
          
            return rs;
        }
    }
}
