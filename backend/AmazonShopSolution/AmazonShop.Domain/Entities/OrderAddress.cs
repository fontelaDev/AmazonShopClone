using AmazonShop.Domain.Common;

namespace AmazonShop.Domain.Entities
{
    public class OrderAddress
    {
        public string StreetAddress { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Country { get; set; } = null!;
    }
}
