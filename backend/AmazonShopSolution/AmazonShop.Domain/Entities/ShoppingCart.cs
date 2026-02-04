using AmazonShop.Domain.Common;

namespace AmazonShop.Domain.Entities
{
    public class ShoppingCart : BaseDomainModel
    {
        public Guid ShoppingCartMasterId { get; set; }

        public ICollection<ShoppingCartItem>? ShoppingCartItems { get; set; }
    }
}