using AmazonShop.Domain.Entities;
using AmazonShop.Infrastructure.Persistence.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AmazonShop.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(AddressConfiguration).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(CategoryConfiguration).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(CountryConfiguration).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(ImageConfiguration).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(OrderConfiguration).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(OrderAddressConfiguration).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(OrderItemConfiguration).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(ReviewConfiguration).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(ShoppingCartItemConfiguration).Assembly);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderAddress> OrderAddresses { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
