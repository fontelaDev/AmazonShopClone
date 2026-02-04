using AmazonShop.Domain.Common;
using AmazonShop.Domain.Enum;

namespace AmazonShop.Domain.Entities
{
    public class Order : BaseDomainModel
    {
        public Order()
        {
        }

        public Order(string buyerName, string buyerEmail, OrderAddress orderAddress, decimal subTotal,
            decimal total, decimal tax, decimal shippingPrice)
        {
            BuyerName = buyerName;
            BuyerEmail = buyerEmail;
            OrderAddress = orderAddress;
            SubTotal = subTotal;
            Total = total;
            Tax = tax;
            ShippingPrice = shippingPrice;
        }

        public string BuyerName { get; set; } = null!;
        public string BuyerEmail { get; set; } = null!;
        public OrderAddress? OrderAddress { get; set; }
        public decimal SubTotal { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;
        public decimal Total { get; set; }
        public decimal Tax { get; set; }
        public decimal ShippingPrice { get; set; }
        public string PaymentIntentId { get; set; } = null!;
        public string ClientSecret { get; set; } = null!;
        public string StripeApiKey { get; set; } = null!;

        public IReadOnlyList<OrderItem>? OrderItems { get; set; }
    }
}
