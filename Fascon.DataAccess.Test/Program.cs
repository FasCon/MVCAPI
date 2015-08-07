using FasCon.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fascon.DataAccess.Test
{
    class Program
    {
        static void Main(string[] args)
        {
              
             //GenerateData.GenerateCustomer();
            var rs=ProductRepository.Products();
            Console.Write(rs);
        }
    }
}
