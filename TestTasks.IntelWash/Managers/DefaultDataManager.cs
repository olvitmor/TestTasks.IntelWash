using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TestTasks.IntelWash.Models;
using TestTasks.IntelWash.Models.Product;

namespace TestTasks.IntelWash.Managers
{
    public class DefaultDataManager
    {
        public static List<Product> Products = new List<Product>();
        public static List<Buyer> Buyers = new List<Buyer>();
        public static List<SalesPoint> SalesPoints = new List<SalesPoint>();
        public static List<Sale> Sales = new List<Sale>();

        public static void MakeDefaultData()
        {
            MakeProducts();
            MakeSalesPoints();
            MakeBuyersAndSales();
        }

        private static void MakeBuyersAndSales()
        {
            var buyer = new Buyer()
            {
                Id = null,
                Name = "olvitmor"
            };
            var sale = new Sale()
            {
                Timestamp = DateTime.ParseExact("2022-03-21 13:26" , "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                SalesPointId = SalesPoints.First().Id,
                BuyerId = buyer.Id
            };
            var saleData = new SaleData()
            {
                ProductId = Products.First().Id,
                ProductQuantity = 5,
                ProductAmount = Products.First().Price * 5
            };
            sale.SalesData.Add(saleData);
            sale.CalcAmount();
            
            buyer.SalesIds.Add(sale.Id);

            Buyers.Add(buyer);
            Sales.Add(sale);

            buyer = new Buyer()
            {
                Name = "another buyer"
            };

            sale = new Sale()
            {
                Timestamp = DateTime.ParseExact("2022-03-12 13:26", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                SalesPointId = SalesPoints.Last().Id,
                BuyerId = buyer.Id
            };
            saleData = new SaleData()
            {
                ProductId = Products.Last().Id,
                ProductQuantity = 5,
                ProductAmount = Products.Last().Price * 5
            };
            sale.SalesData.Add(saleData);
            sale.CalcAmount();

            buyer.SalesIds.Add(sale.Id);

            Buyers.Add(buyer);
            Sales.Add(sale);
        }

        private static void MakeProducts()
        {
            Products = new List<Product>()
            {
                new Product("Мойка эконом", 535, true),
                new Product("Мойка стандарт", 678, true),
                new Product("Мойка люкс", 969, true),
                new Product("Очиститель стёкол", 369),
                new Product("Очиститель фар", 369),
                new Product("Техническая мойка (ополаскивание водой колёсных арок, порогов, бамперов)", 150, true),
                new Product("Ополаскивание кузова водой", 200, true),
                new Product("Покрытие кузова твёрдым воском", 1100, true)
            };
        }

        private static void MakeSalesPoints()
        {
            SalesPoints = new List<SalesPoint>()
            {
                new SalesPoint("Умная мойка в Царицыно", GetProvidedProducts()),
                new SalesPoint("Умная мойка в Бирюлево", GetProvidedProducts()),
                new SalesPoint("Умная мойка в Митино", GetProvidedProducts()),
                new SalesPoint("Умная мойка на Проспекте Мира", GetProvidedProducts()),
                new SalesPoint("Умная мойка в Серпухове", GetProvidedProducts())
            };
        }

        private static List<ProvidedProduct> GetProvidedProducts()
        {
            var res = new List<ProvidedProduct>();
            foreach(var p in Products)
            {
                res.Add(new ProvidedProduct(p.Id, 10));
            }
            return res;
        }
    }
}
