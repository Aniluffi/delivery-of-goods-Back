using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ShopFlower.Data.Models;

namespace ShopFlower.Data.Configuration
{
    public class WishListConfig : IEntityTypeConfiguration<WishList>
    {
        public void Configure(EntityTypeBuilder<WishList> builder)
        {
            builder.ToTable("WishList").HasKey(s => s.Id);

            builder.HasMany(s => s.Users)
                .WithOne(s => s.WishList)
                .HasForeignKey(s => s.WishListId);

            builder.HasMany(s => s.Products)
                .WithMany(s => s.WishList);

        }
    }
}
