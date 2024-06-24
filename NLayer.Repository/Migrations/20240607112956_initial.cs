using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
<<<<<<<< HEAD:NLayer.Repository/Migrations/20240613204703_initial.cs
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
========
>>>>>>>> AspNetAPI:NLayer.Repository/Migrations/20240607112956_initial.cs
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

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateTime", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kalemler", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kitaplar", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Defterler", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateTime", "Name", "Password", "UpdateDate" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nesil", "nesilpaspatur1*.", null });

            migrationBuilder.InsertData(
<<<<<<<< HEAD:NLayer.Repository/Migrations/20240613204703_initial.cs
========
                table: "Categories",
                columns: new[] { "Id", "DateTime", "Name", "UpdateDate" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Defterler", null });

            migrationBuilder.InsertData(
>>>>>>>> AspNetAPI:NLayer.Repository/Migrations/20240607112956_initial.cs
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateTime", "Name", "Price", "Stock", "UpdateDate" },
                values: new object[,]
                {
<<<<<<<< HEAD:NLayer.Repository/Migrations/20240613204703_initial.cs
                    { 1, 1, new DateTime(2024, 6, 13, 23, 47, 3, 345, DateTimeKind.Local).AddTicks(5432), "Kalem 1", 100m, 20, null },
                    { 2, 1, new DateTime(2024, 6, 13, 23, 47, 3, 345, DateTimeKind.Local).AddTicks(5450), "Kalem 2", 120m, 200, null },
                    { 3, 1, new DateTime(2024, 6, 13, 23, 47, 3, 345, DateTimeKind.Local).AddTicks(5452), "Kalem 3", 150m, 25, null },
                    { 4, 2, new DateTime(2024, 6, 13, 23, 47, 3, 345, DateTimeKind.Local).AddTicks(5454), "Kitap 1", 400m, 30, null },
                    { 5, 2, new DateTime(2024, 6, 13, 23, 47, 3, 345, DateTimeKind.Local).AddTicks(5456), "Kitap 2", 200m, 10, null }
========
                    { 1, 1, new DateTime(2024, 6, 7, 14, 29, 55, 918, DateTimeKind.Local).AddTicks(3430), "Kalem 1", 100m, 20, null },
                    { 2, 1, new DateTime(2024, 6, 7, 14, 29, 55, 918, DateTimeKind.Local).AddTicks(3440), "Kalem 2", 120m, 200, null },
                    { 3, 1, new DateTime(2024, 6, 7, 14, 29, 55, 918, DateTimeKind.Local).AddTicks(3441), "Kalem 3", 150m, 25, null },
                    { 4, 2, new DateTime(2024, 6, 7, 14, 29, 55, 918, DateTimeKind.Local).AddTicks(3442), "Kitap 1", 400m, 30, null },
                    { 5, 2, new DateTime(2024, 6, 7, 14, 29, 55, 918, DateTimeKind.Local).AddTicks(3443), "Kitap 2", 200m, 10, null }
>>>>>>>> AspNetAPI:NLayer.Repository/Migrations/20240607112956_initial.cs
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "Color", "Height", "ProductId", "Width" },
                values: new object[] { 1, "Kırmızı", 100, 1, 200 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
<<<<<<<< HEAD:NLayer.Repository/Migrations/20240613204703_initial.cs
                name: "Users");

            migrationBuilder.DropTable(
========
>>>>>>>> AspNetAPI:NLayer.Repository/Migrations/20240607112956_initial.cs
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
