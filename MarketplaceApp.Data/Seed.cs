using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketplaceApp.Data.Entities.Models;

namespace MarketplaceApp.Data
{
    public static class Seed
    {
        public static readonly List<User> Users = new List<User>()
        {
            new User("Laura", "lbauk00@fesb.hr", 100),
            new User("Lana", "leli@fesb.hr")
        };

        public static readonly List<Product> Products = new List<Product>()
        {
            new Product { Id = 1, Name = "Shirt", Description = "White T-shirt", Price = 50, Status = "For Sale", SellerId = 2 }
        };
    }
}

