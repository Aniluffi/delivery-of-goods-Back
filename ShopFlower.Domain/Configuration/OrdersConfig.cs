using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopFlower.Data.Models;

namespace ShopFlower.Data.Configuration
{
    public class OrdersConfig : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.ToTable("Orders").HasKey(c => c.Id);

            builder.HasMany(c => c.Products)
                .WithMany(c => c.Orders);

            builder.HasMany(c => c.Users)
                .WithOne(c => c.Orders)
                .HasForeignKey(c => c.OrderId);
        }
    }
}
