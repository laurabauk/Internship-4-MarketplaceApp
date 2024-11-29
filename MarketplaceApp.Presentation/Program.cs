using MarketplaceApp.Data;
using MarketplaceApp.Data.Entities.Models;
using System;

namespace Marketplace.App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var context = new Context();

            Console.WriteLine("Welcome to the Marketplace");

            foreach (var product in context.Products)
            {
                Console.WriteLine($"{product.Name} - {product.Description} - ${product.Price}");
            }
        }
    }
}