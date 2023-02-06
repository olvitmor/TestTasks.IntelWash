using System;
using System.Collections.Generic;
using TestTasks.IntelWash.Managers;

namespace TestTasks.IntelWash.Models
{
    public class Sale
    {
        public string Id { get; set; } = IdManager.NewId();
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public string SalesPointId { get; set; }
        public string BuyerId { get; set; }
        public List<SaleData> SalesData { get; set; } = new List<SaleData>();
        public float TotalAmount { get; set; }

        public void CalcAmount()
        {
            TotalAmount = 0;
            SalesData.ForEach(x => TotalAmount += x.ProductAmount);
        }
    }
}
