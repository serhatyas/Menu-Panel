using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFeatures_Product_ProductId",
                table: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateTime", "Name", "Price", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 3, 3, 48, 39, 394, DateTimeKind.Local).AddTicks(3975), "Kalem 1", 100m, 20, null },
                    { 2, 1, new DateTime(2024, 6, 3, 3, 48, 39, 394, DateTimeKind.Local).AddTicks(3983), "Kalem 2", 120m, 200, null },
                    { 3, 1, new DateTime(2024, 6, 3, 3, 48, 39, 394, DateTimeKind.Local).AddTicks(3984), "Kalem 3", 150m, 25, null },
                    { 4, 2, new DateTime(2024, 6, 3, 3, 48, 39, 394, DateTimeKind.Local).AddTicks(3985), "Kitap 1", 400m, 30, null },
                    { 5, 2, new DateTime(2024, 6, 3, 3, 48, 39, 394, DateTimeKind.Local).AddTicks(3986), "Kitap 2", 200m, 10, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFeatures_Products_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFeatures_Products_ProductId",
                table: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "DateTime", "Name", "Price", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 1, 2, 59, 54, 910, DateTimeKind.Local).AddTicks(6040), "Kalem 1", 100m, 20, null },
                    { 2, 1, new DateTime(2024, 6, 1, 2, 59, 54, 910, DateTimeKind.Local).AddTicks(6051), "Kalem 2", 120m, 200, null },
                    { 3, 1, new DateTime(2024, 6, 1, 2, 59, 54, 910, DateTimeKind.Local).AddTicks(6052), "Kalem 3", 150m, 25, null },
                    { 4, 2, new DateTime(2024, 6, 1, 2, 59, 54, 910, DateTimeKind.Local).AddTicks(6053), "Kitap 1", 400m, 30, null },
                    { 5, 2, new DateTime(2024, 6, 1, 2, 59, 54, 910, DateTimeKind.Local).AddTicks(6054), "Kitap 2", 200m, 10, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFeatures_Product_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
