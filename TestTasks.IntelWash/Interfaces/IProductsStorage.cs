using System.Collections.Generic;
using TestTasks.IntelWash.Models.Product;

namespace TestTasks.IntelWash.Interfaces
{
    public interface IProductsStorage
    {
        public List<Product> GetList();
    }
}
