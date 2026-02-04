using AmazonShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmazonShop.Infrastructure.Persistence.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(col => col.Name)
            .IsRequired()
            .HasMaxLength(50);
            builder.Property(col => col.Iso2)
            .HasMaxLength(50);
            builder.Property(col => col.Iso3)
            .HasMaxLength(50);
        }
    }
}
