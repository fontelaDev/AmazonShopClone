using AmazonShop.Domain.Common;

namespace AmazonShop.Domain.Entities
{
    public class OrderItem : BaseDomainModel
    {
        public int Quantity { get; set; }
        public int ProductItemId { get; set; }
        public string ProductName { get; set; } = null!;
        public string UrlImage { get; set; } = null!;
        public decimal Price { get; set; }
        
        public int ProductId { get; set; }
        public Product? Product { get; set; }
 
        public int OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
