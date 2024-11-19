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
                .HasForeignKey(s => s.Id);

            builder.HasOne(c => c.WishList)
                .WithMany(c => c.Users)
                .HasForeignKey(c => c.Id);

            builder.HasMany(s => s.Roles)
                .WithOne(s => s.User)
                .HasForeignKey(s => s.UserId);

        }
    }
}
