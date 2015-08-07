using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;

namespace FasCon.DataAccess.Repositories
{
    public class GenerateData : BaseRepository
    {
        public static void GenerateSampleData()
        {
            using (var db = new FasConDBEntities())
            {
                for (int i = 0; i < 10; i++)
                {
                    var cat = new Category
                    {
                        CategoryId = Guid.NewGuid(),
                        Name= "Danh mục " + i.ToString() ,
                        FullName = "Danh mục " + i.ToString(),
                        Alias="danh-muc-"+i.ToString()
                       
                    };
                    try
                    {
                        db.Categories.Add(cat);
                        db.SaveChanges();
                        for (int j = 10; j < 100; j++)
                        {
                            db.Products.Add(new Product
                            {
                                ProductID = Guid.NewGuid(),
                                ProductName = "Sản phẩm " + i + j,
                                Alias="san-pham-"+i+j,
                                ProductThumb="http://sandichvu.com.vn/storage/app/uploads/public/556/889/db6/thumb_74_250x250_0_0_crop.jpg",
                                Category = cat,
                                ProductSKU="SKU "+i+j,
                                ShortDescription = "ShortDescription" +i+j,
                                Price=100000
                                
                            });
                        }
                        db.SaveChanges();
                    }

                    catch (DbEntityValidationException e)
                    {
                        foreach (var eve in e.EntityValidationErrors)
                        {
                            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                        throw;
                    }
                }

            }
        }
        public static void GenerateCustomer()
        {
            using (var db = new FasConDBEntities())
            {
                db.Customers.Add(new Customer
                {
                    CustomerId = Guid.NewGuid(),
                    Name = "huu loi"

                });
                db.SaveChanges();
            }
        }
    }
}
