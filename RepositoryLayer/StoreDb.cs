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
