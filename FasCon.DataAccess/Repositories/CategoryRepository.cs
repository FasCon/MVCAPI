﻿using FasCon.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataAccess.Repositories
{
    public class CategoryRepository
    {

        public CategoryRepository()
            : base()
        {

        }
        public static Boolean UpdateCategory(CategoryModel orderItemModel)
        {

            return true;
        }
        public static Boolean DeleteCategory(CategoryModel orderItemModel)
        {

            return true;
        }

        public static List<CategoryModel> FindCategoryByCustomerId(Guid orderId)
        {
            List<CategoryModel> rs = new List<CategoryModel>();

            return rs ;
        }
    }
}
