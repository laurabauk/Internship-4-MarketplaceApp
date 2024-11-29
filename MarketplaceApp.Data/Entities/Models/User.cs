using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceApp.Data.Entities.Models
{
    public class User
    {
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public User(string email, string password, bool isAdmin) 
        {
            Email = email;
            Password = password;
            IsAdmin = isAdmin;

        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }  
        public bool IsAdmin { get; set; }


    }
}
