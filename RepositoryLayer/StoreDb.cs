using Microsoft.EntityFrameworkCore;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    class StoreDb : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        
        public DbSet<Location> Locations { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<StoreOrder> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>().HasKey(o => new { o.LocationID, o.ProductID });
            modelBuilder.Entity<OrderDetails>().HasKey(x => new { x.OrderID, x.ProductID });
        }

        public StoreDb() { }
        public StoreDb(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CodeFirstStoreDb;Trusted_Connection=True;");
            }
        }
    }
}
