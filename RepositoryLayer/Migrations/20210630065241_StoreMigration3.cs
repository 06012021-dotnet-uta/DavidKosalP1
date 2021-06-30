using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class StoreMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Customer",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Location",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Product",
                table: "OrderDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoreOrder",
                table: "OrderDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Location",
                table: "Inventories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Product",
                table: "Inventories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Customer",
                table: "Orders",
                column: "Customer");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Location",
                table: "Orders",
                column: "Location");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Product",
                table: "OrderDetails",
                column: "Product");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_StoreOrder",
                table: "OrderDetails",
                column: "StoreOrder");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_Location",
                table: "Inventories",
                column: "Location");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_Product",
                table: "Inventories",
                column: "Product");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Locations_Location",
                table: "Inventories",
                column: "Location",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Products_Product",
                table: "Inventories",
                column: "Product",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_StoreOrder",
                table: "OrderDetails",
                column: "StoreOrder",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_Product",
                table: "OrderDetails",
                column: "Product",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_Customer",
                table: "Orders",
                column: "Customer",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Locations_Location",
                table: "Orders",
                column: "Location",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Locations_Location",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Products_Product",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_StoreOrder",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_Product",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_Customer",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Locations_Location",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Customer",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Location",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_Product",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_StoreOrder",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_Location",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_Product",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "Customer",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Product",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "StoreOrder",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "Product",
                table: "Inventories");
        }
    }
}
