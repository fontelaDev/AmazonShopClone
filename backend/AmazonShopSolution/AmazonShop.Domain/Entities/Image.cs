using AmazonShop.Domain.Common;

namespace AmazonShop.Domain.Entities
{
    public class Image : BaseDomainModel
    {
        public string Url { get; set; } = null!;
        public string? PublicCode { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
