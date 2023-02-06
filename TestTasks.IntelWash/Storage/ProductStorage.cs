using System.Collections.Generic;
using System.Linq;
using TestTasks.IntelWash.Database;
using TestTasks.IntelWash.Interfaces;
using TestTasks.IntelWash.Managers;
using TestTasks.IntelWash.Models;
using TestTasks.IntelWash.Models.Product;

namespace TestTasks.IntelWash.Storage
{
    public class ProductStorage : IProductStorage
    {
        public ProductStorage()
        {

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
