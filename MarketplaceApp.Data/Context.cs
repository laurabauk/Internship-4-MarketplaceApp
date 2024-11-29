using MarketplaceApp.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceApp.Data
{
    public class Context
    {
        public List<User> Users { get; set; } = Seed.Users;
        public List<Channel> Channels { get; set; } = new List<Channel>();
        public Context()
        {

        }
    }
}
