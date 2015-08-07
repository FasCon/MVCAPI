using FasCon.DataAccess.Repositories;
using FasCon.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.BusinessLogic
{
    public class ProductsBL
    {
        public static List<ProductModel> Products()
        {
            return ProductRepository.Products();
        }
        public static ProductModel FindProductById(Guid ProductId)
        {
            return ProductRepository.FindProductById(ProductId);
        }
        public static ProductModel FindProductBySEOURL(string SEOURL)
        {
            return ProductRepository.FindProductBySEOURL(SEOURL);
        }

        public static ProductModel FindProductByCategoryId(Guid CategoryId)
        {
            return ProductRepository.FindProductByCategoryId(CategoryId);
        }
        public static ProductModel FindProductByCategorySEOURL(string SEOURL)
        {
            return ProductRepository.FindProductByCategorySEOURL(SEOURL);
        }
    }
}
