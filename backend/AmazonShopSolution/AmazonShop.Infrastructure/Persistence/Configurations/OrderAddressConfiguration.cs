using AmazonShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmazonShop.Infrastructure.Persistence.Configurations
{
    public class OrderAddressConfiguration : IEntityTypeConfiguration<OrderAddress>
    {
        public void Configure(EntityTypeBuilder<OrderAddress> builder)
        {
            builder.Property(col => col.StreetAddress)
            .IsRequired()
            .HasMaxLength(100);
            builder.Property(col => col.City)
            .IsRequired()
            .HasMaxLength(50);
            builder.Property(col => col.Department)
            .IsRequired()
            .HasMaxLength(100);
            builder.Property(col => col.ZipCode)
            .IsRequired()
            .HasMaxLength(10);
            builder.Property(col => col.UserName)
            .IsRequired();
            builder.Property(col => col.Country)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}
