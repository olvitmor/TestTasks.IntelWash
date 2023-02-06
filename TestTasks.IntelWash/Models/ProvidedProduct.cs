using TestTasks.IntelWash.Managers;

namespace TestTasks.IntelWash.Models
{
    public class ProvidedProduct
    {
        public string ProductId { get; set; } = IdManager.NewId();
        public int ProductQuantity { get; set; }

        public ProvidedProduct()
        {

        }

        public ProvidedProduct(string productId, int productQuantity)
        {
            ProductId = productId;
            ProductQuantity = productQuantity;
        }
    }
}
