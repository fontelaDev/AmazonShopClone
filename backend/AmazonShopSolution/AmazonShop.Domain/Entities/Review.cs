using AmazonShop.Domain.Common;

namespace AmazonShop.Domain.Entities
{
    public class Review : BaseDomainModel
    {
        public string NameUser { get; set; } = null!;
        public int Rating { get; set; }
        public string? Comment { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
