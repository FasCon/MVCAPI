using AutoMapper;
using FasCon.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataAccess.Repositories
{
   public class ProductRepository :BaseRepository
    {
       public ProductRepository()
           : base()
       {
           Mapper.CreateMap<Product, ProductModel>();
       }
       public static List<ProductModel> Products()
       {
           using (var db = new FasConDBEntities())
           {
               var products = db.Products.ToList().OrderBy(p=>p.ProductName);
               return products.Select(p => new ProductModel {ProductID=p.ProductID,ProductName = p.ProductName,ShortDescription=p.ShortDescription,ProductThumb=p.ProductThumb,Price=p.Price }).ToList();
           }
       }
       public static  ProductModel  FindProductById(Guid ProductId)
       {
           using (var db = new FasConDBEntities())
           {
               var p = db.Products.Where(pr => pr.ProductID == ProductId).FirstOrDefault();
               if (p == null) return null;
               //return Mapper.Map<ProductModel>(product);
               return  ( new ProductModel { CategoryID=p.CategoryID, ProductID = p.ProductID, ProductName = p.ProductName, ShortDescription = p.ShortDescription, ProductThumb = p.ProductThumb, Price = p.Price,FullDescription=p.FullDescription });
           }
       }
       public static ProductModel FindProductByAlias(string Alias)
       {
           using (var db = new FasConDBEntities())
           {
               var p = db.Products.Where(pr => pr.Alias == Alias).FirstOrDefault();
               if (p == null) return null;
               //return Mapper.Map<ProductModel>(product);
               return (new ProductModel { CategoryID = p.CategoryID, ProductID = p.ProductID, ProductName = p.ProductName, ShortDescription = p.ShortDescription, ProductThumb = p.ProductThumb, Price = p.Price, FullDescription = p.FullDescription });
           }
       }
       public static ProductModel FindProductByCategoryId(Guid CategoryId)
       {
           using (var db = new FasConDBEntities())
           {
               var p = db.Products.Where(pr => pr.CategoryID == CategoryId).FirstOrDefault();
               if (p == null) return null;
               //return Mapper.Map<ProductModel>(product);
               return (new ProductModel { CategoryID = p.CategoryID, ProductID = p.ProductID, ProductName = p.ProductName, ShortDescription = p.ShortDescription, ProductThumb = p.ProductThumb, Price = p.Price, FullDescription = p.FullDescription });
           }
       }

       public static ProductModel FindProductByCategoryAlias(string Alias)
       {
           using (var db = new FasConDBEntities())
           {
               var p = db.Products.Where(pr => pr.Alias == Alias).FirstOrDefault();
               if (p == null) return null;
               //return Mapper.Map<ProductModel>(product);
               return (new ProductModel { CategoryID = p.CategoryID, ProductID = p.ProductID, ProductName = p.ProductName, ShortDescription = p.ShortDescription, ProductThumb = p.ProductThumb, Price = p.Price, FullDescription = p.FullDescription });
           }
       }
    }
}
