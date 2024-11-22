using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopFlower.Data.Migrations
{
    /// <inheritdoc />
    public partial class ShopFlower5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolesUsers_User_UserId",
                table: "RolesUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Addresss_AddressesId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Cart_CartId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Orders_OrderId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_WishList_WishListId",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "User",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_RolesUsers_User_UserId",
                table: "RolesUsers",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Addresss_AddressesId",
                table: "User",
                column: "AddressesId",
                principalTable: "Addresss",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Cart_CartId",
                table: "User",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Orders_OrderId",
                table: "User",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_User_WishList_WishListId",
                table: "User",
                column: "WishListId",
                principalTable: "WishList",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolesUsers_User_UserId",
                table: "RolesUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Addresss_AddressesId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Cart_CartId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Orders_OrderId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_WishList_WishListId",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RolesUsers_User_UserId",
                table: "RolesUsers",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Addresss_AddressesId",
                table: "User",
                column: "AddressesId",
                principalTable: "Addresss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Cart_CartId",
                table: "User",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Orders_OrderId",
                table: "User",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_WishList_WishListId",
                table: "User",
                column: "WishListId",
                principalTable: "WishList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
