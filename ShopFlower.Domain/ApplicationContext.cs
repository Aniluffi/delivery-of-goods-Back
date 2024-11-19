using Microsoft.EntityFrameworkCore;
using ShopFlower.Data.Configuration;
using ShopFlower.Data.Models;

namespace ShopFlower.Data
{
    public class ApplicationContext : DbContext
    {
        DbSet<Cart> Carts { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Roles> Roles { get; set; }
        DbSet<RolesUser> RolesUsers { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<WishList> WishLists { get; set; }

        public ApplicationContext() { }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=admin");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RolesUserConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new CartConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new WishListConfig());
        }
    }
}
