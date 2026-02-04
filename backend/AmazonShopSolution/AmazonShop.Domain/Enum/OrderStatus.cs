using System.Runtime.Serialization;

namespace AmazonShop.Domain.Enum
{
    public enum OrderStatus
    {
        [EnumMember(Value = "Payment due")]
        Pending,
        [EnumMember(Value = "Payment received")]
        Completed,
        [EnumMember(Value = "Product shipped")]
        Sent,
        [EnumMember(Value = "Payment error")]
        Error
    }
}
