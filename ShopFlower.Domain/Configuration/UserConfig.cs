using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopFlower.Data.Models;

namespace ShopFlower.Data.Configuration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User").HasKey(t => t.Id);


            builder
                .HasOne(s => s.Cart)
                .WithMany(s => s.Users)
                .OnDelete(DeleteBehavior.SetNull)
                .HasForeignKey(s => s.CartId);

            builder.HasOne(c => c.WishList)
                .WithMany(c => c.Users)
                .OnDelete(DeleteBehavior.SetNull)
                .HasForeignKey(c => c.WishListId);

            builder.HasMany(s => s.Roles)
                .WithOne(s => s.User)
                .OnDelete(DeleteBehavior.SetNull)
                .HasForeignKey(s => s.UserId);

            builder.HasOne(c => c.Addresses)
                .WithMany(c => c.Users)
                .OnDelete(DeleteBehavior.SetNull)
                .HasForeignKey(c => c.AddressesId);

            builder.HasOne(j => j.Orders)
                .WithMany(c => c.Users)
                .OnDelete(DeleteBehavior.SetNull)
                .HasForeignKey(c => c.OrderId);
        }
    }
}
