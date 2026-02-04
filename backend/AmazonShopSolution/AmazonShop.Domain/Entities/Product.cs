using AmazonShop.Domain.Common;
using AmazonShop.Domain.Enum;

namespace AmazonShop.Domain.Entities
{
    public class Product : BaseDomainModel
    {
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int Rating { get; set; }
        public string? Seller { get; set; }
        public int Stock { get; set; }
        public ProductStatus ProductStatus { get; set; } = ProductStatus.Active;
        
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public ICollection<Image> Images { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
    }
}
