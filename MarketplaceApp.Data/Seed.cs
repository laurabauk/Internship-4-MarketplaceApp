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
        new User("lbauk00@fesb.hr", "password123", isAdmin: true)
            {
                Id = 1
            }
        };
    }
}
