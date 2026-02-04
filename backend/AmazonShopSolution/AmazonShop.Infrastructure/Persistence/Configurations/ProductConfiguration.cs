using AmazonShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmazonShop.Infrastructure.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(col => col.Name)
            .IsRequired()
            .HasMaxLength(50);
            builder.Property(col => col.Price)
            .HasPrecision(10, 2);
            builder.Property(col => col.Description)
            .HasMaxLength(255);
            builder.Property(col => col.Seller)
            .HasMaxLength(100);

            builder
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
