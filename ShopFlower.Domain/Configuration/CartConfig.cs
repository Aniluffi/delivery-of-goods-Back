using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopFlower.Data.Models;

namespace ShopFlower.Data.Configuration
{
    public class CartConfig : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Cart").HasKey(s => s.Id);

            builder.HasMany(s => s.Users)
                .WithOne(s => s.Cart)
                .HasForeignKey(s => s.CartId);

            builder.HasMany(s => s.Products)
                .WithMany(s => s.Carts);

        }
    }
}
