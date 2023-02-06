namespace TestTasks.IntelWash.Models
{
    public class SaleData
    {
        public string ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public float ProductAmount { get; set; }

        public SaleData()
        {

        }

        public SaleData(string productId, int productQuantity, float productAmount)
        {
            ProductId = productId;
            ProductQuantity = productQuantity;
            ProductAmount = productAmount;
        }
    }
}
