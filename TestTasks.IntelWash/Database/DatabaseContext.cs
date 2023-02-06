using Microsoft.EntityFrameworkCore;
using TestTasks.IntelWash.Models;
using TestTasks.IntelWash.Models.Product;

namespace TestTasks.IntelWash.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "SalesDb");
        }

        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<SalesPoint> SalesPoints { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
