using System.Collections.Generic;
using System.Linq;
using TestTasks.IntelWash.Database;
using TestTasks.IntelWash.Interfaces;
using TestTasks.IntelWash.Models;
using TestTasks.IntelWash.Models.Product;

namespace TestTasks.IntelWash.Storage
{
    public class ProductStorage : IProductsStorage
    {
        public ProductStorage()
        {
            using (var context = new DatabaseContext())
            {
                //var products = new List<Product>()
                //{

                //};
                //context.Products.AddRange(products);
            }
        }

        public List<Product> GetList()
        {
            var list = new List<Product>();
            using (var context = new DatabaseContext())
            {
                list = context.Products.ToList();
            }
            return list;
        }
    }
}
