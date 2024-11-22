﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ShopFlower.Data;

#nullable disable

namespace ShopFlower.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20241120091048_ShopFlower3")]
    partial class ShopFlower3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CartProduct", b =>
                {
                    b.Property<int>("CartsId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductsId")
                        .HasColumnType("integer");

                    b.HasKey("CartsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CartProduct");
                });

            modelBuilder.Entity("OrdersProduct", b =>
                {
                    b.Property<int>("OrdersId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductsId")
                        .HasColumnType("integer");

                    b.HasKey("OrdersId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("OrdersProduct");
                });

            modelBuilder.Entity("ProductWishList", b =>
                {
                    b.Property<int>("ProductsId")
                        .HasColumnType("integer");

                    b.Property<int>("WishListId")
                        .HasColumnType("integer");

                    b.HasKey("ProductsId", "WishListId");

                    b.HasIndex("WishListId");

                    b.ToTable("ProductWishList");
                });

            modelBuilder.Entity("ShopFlower.Data.Models.Addresses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ZIP")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Addresss");
                });

            modelBuilder.Entity("ShopFlower.Data.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("TotalSum")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Cart", (string)null);
                });

            modelBuilder.Entity("ShopFlower.Data.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("TotalSum")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ShopFlower.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionShort")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("ShopFlower.Data.Models.Roles", b =>
                {
                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Role");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("ShopFlower.Data.Models.RolesUser", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("RoleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("RolesUsers");
                });

            modelBuilder.Entity("ShopFlower.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressesId")
                        .HasColumnType("integer");

                    b.Property<int>("CartId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("WishListId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AddressesId");

                    b.HasIndex("CartId");

                    b.HasIndex("OrderId");

                    b.HasIndex("WishListId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("ShopFlower.Data.Models.WishList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("WishList", (string)null);
                });

            modelBuilder.Entity("CartProduct", b =>
                {
                    b.HasOne("ShopFlower.Data.Models.Cart", null)
                        .WithMany()
                        .HasForeignKey("CartsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopFlower.Data.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrdersProduct", b =>
                {
                    b.HasOne("ShopFlower.Data.Models.Orders", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopFlower.Data.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductWishList", b =>
                {
                    b.HasOne("ShopFlower.Data.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopFlower.Data.Models.WishList", null)
                        .WithMany()
                        .HasForeignKey("WishListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShopFlower.Data.Models.RolesUser", b =>
                {
                    b.HasOne("ShopFlower.Data.Models.Roles", "Role")
                        .WithMany("RolseUsers")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopFlower.Data.Models.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShopFlower.Data.Models.User", b =>
                {
                    b.HasOne("ShopFlower.Data.Models.Addresses", "Addresses")
                        .WithMany("Users")
                        .HasForeignKey("AddressesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopFlower.Data.Models.Cart", "Cart")
                        .WithMany("Users")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopFlower.Data.Models.Orders", "Orders")
                        .WithMany("Users")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopFlower.Data.Models.WishList", "WishList")
                        .WithMany("Users")
                        .HasForeignKey("WishListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Addresses");

                    b.Navigation("Cart");

                    b.Navigation("Orders");

                    b.Navigation("WishList");
                });

            modelBuilder.Entity("ShopFlower.Data.Models.Addresses", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ShopFlower.Data.Models.Cart", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ShopFlower.Data.Models.Orders", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ShopFlower.Data.Models.Roles", b =>
                {
                    b.Navigation("RolseUsers");
                });

            modelBuilder.Entity("ShopFlower.Data.Models.User", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("ShopFlower.Data.Models.WishList", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}