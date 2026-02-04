using AmazonShop.Domain.Common;

namespace AmazonShop.Domain.Entities
{
    public class Country : BaseDomainModel
    {
        public string Name { get; set; } = null!;
        public string? Iso2 { get; set; }
        public string? Iso3 { get; set; }
    }
}
