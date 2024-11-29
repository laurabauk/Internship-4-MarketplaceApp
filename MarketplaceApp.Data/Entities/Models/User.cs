namespace MarketplaceApp.Data.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }
        public bool IsSeller { get; set; }

        public User(string name, string email, decimal balance)
        {
            Name = name;
            Email = email;
            Balance = balance;
            IsSeller = false;
        }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
            IsSeller = true;
            Balance = 0;
        }
    }
}

