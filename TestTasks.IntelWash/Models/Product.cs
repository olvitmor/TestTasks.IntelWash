using TestTasks.IntelWash.Managers;

namespace TestTasks.IntelWash.Models.Product
{
    public class Product
    {
        public string Id { get; set; } = IdManager.NewId();
        public string Name { get; set; }
        public float Price { get; set; }
        public bool IsService { get; set; }

        public Product()
        {

        }
        public Product(string name,float price, bool isService = false)
        {
            Name = name;
            Price = price;
            IsService = isService;
        }
    }
}
