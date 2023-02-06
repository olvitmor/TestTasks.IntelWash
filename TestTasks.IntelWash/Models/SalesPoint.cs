using System.Collections.Generic;
using TestTasks.IntelWash.Managers;

namespace TestTasks.IntelWash.Models
{
    public class SalesPoint
    {
        public string Id { get; set; } = IdManager.NewId();
        public string Name { get; set; }
        public List<ProvidedProduct> ProvidedProducts { get; set; } = new List<ProvidedProduct>();

        public SalesPoint() { }
        public SalesPoint(string name, List<ProvidedProduct> providedProducts)
        {
            Name = name;
            ProvidedProducts = providedProducts;
        }
    }
}
