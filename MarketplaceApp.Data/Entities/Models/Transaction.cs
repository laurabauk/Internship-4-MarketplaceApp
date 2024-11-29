namespace MarketplaceApp.Data.Entities.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int BuyerId { get; set; }
        public int SellerId { get; set; }
        public DateTime Date { get; set; }
        public Transaction(int productId, int buyerId, int sellerId, DateTime date)
        {
            ProductId = productId;
            BuyerId = buyerId;
            SellerId = sellerId;
            Date = date;
        }
    }
}
