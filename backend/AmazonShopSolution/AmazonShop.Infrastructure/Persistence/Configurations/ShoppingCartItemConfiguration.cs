using AmazonShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmazonShop.Infrastructure.Persistence.Configurations
{
    public class ShoppingCartItemConfiguration : IEntityTypeConfiguration<ShoppingCartItem>
    {
        public void Configure(EntityTypeBuilder<ShoppingCartItem> builder)
        {
            builder.Property(col => col.NameProduct)
            .IsRequired()
            .HasMaxLength(50);
            builder.Property(col => col.Price)
            .HasPrecision(10, 2);
            builder.Property(col => col.Image)
            .IsRequired();
            builder.Property(col => col.CategoryName)
            .IsRequired()
            .HasMaxLength(50);

            builder
            .HasOne(sci => sci.ShoppingCart)
            .WithMany(sc => sc.ShoppingCartItems)
            .HasForeignKey(sci => sci.ShoppingCartId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
