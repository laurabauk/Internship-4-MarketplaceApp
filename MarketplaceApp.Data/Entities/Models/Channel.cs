using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceApp.Data.Entities.Models
{
    public class Channel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public Channel(string name, string message)
        {
            Name = name;
            Message = message;
            CreatedAt = DateTime.Now;
        }
    }
}
