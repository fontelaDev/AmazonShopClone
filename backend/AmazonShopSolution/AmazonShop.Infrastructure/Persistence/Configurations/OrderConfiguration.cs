using AmazonShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmazonShop.Infrastructure.Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(col => col.BuyerName)
            .IsRequired();
            builder.Property(col => col.BuyerEmail)
            .IsRequired();
            builder.Property(col => col.SubTotal)
            .HasPrecision(10, 2);
            builder.Property(col => col.OrderStatus)
            .HasConversion<string>();
            builder.Property(col => col.Total)
            .HasPrecision(10, 2);
            builder.Property(col => col.Tax)
            .HasPrecision(10, 2);
            builder.Property(col => col.ShippingPrice)
            .HasPrecision(10, 2);
            builder.Property(col => col.PaymentIntentId)
            .IsRequired();
            builder.Property(col => col.ClientSecret)
            .IsRequired();
            builder.Property(col => col.StripeApiKey)
            .IsRequired();

            builder.OwnsOne(o => o.OrderAddress, a =>
            {
                a.WithOwner();
            });
        }
    }
}
