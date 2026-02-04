using AmazonShop.Domain.Common;

namespace AmazonShop.Domain.Entities
{
    public class ShoppingCartItem : BaseDomainModel
    {
        public string NameProduct { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public Guid ShoppingCartMasterId { get; set; }
        public int ProductId { get; set; }
        public int Stock { get; set; }

        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; } = null!;
    }
}