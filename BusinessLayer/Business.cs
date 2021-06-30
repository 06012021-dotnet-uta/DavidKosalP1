using Microsoft.EntityFrameworkCore;
using ModelLibrary;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Business
    {
        StoreDb context = new StoreDb();

        public void addCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public List<Location> GetLocations()
        {
            var stores = context.Locations.ToList();
            /*List<Location> StoreLocations = new();
            foreach (var item in stores)
            {
                StoreLocations.Add(item);
            }*/
            return stores;
        }

        public List<Product> GetProducts(String location)
        {
            var products = context.Products.ToList();
            return products;
        }

    }
}
