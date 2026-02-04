using AmazonShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmazonShop.Infrastructure.Persistence.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(col => col.StreetAddress)
            .IsRequired()
            .HasMaxLength(100);
            builder.Property(col => col.City)
            .IsRequired()
            .HasMaxLength(100);
            builder.Property(col => col.Department)
            .IsRequired()
            .HasMaxLength(100);
            builder.Property(col => col.ZipCode)
            .IsRequired()
            .HasMaxLength(100);
            builder.Property(col => col.UserName)
            .IsRequired()
            .HasMaxLength(100);
            builder.Property(col => col.Country)
            .IsRequired()
            .HasMaxLength(100);
        }
    }
}
