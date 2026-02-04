using System.Runtime.Serialization;

namespace AmazonShop.Domain.Enum
{
    public enum ProductStatus
    {
        [EnumMember(Value = "Inactive product")]
        Inactive,
        [EnumMember(Value = "Active product")]
        Active
    }
}
