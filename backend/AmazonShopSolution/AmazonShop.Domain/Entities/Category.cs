using AmazonShop.Domain.Common;

namespace AmazonShop.Domain.Entities
{
    public class Category : BaseDomainModel
    {
        public string Name { get; set; } = null!;

        public ICollection<Product> Products { get; set; } = [];
    }
}
