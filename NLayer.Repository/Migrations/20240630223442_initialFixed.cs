using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class initialFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "NameEN",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameEN",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 1, 34, 42, 427, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 1, 34, 42, 427, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 1, 34, 42, 427, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 1, 34, 42, 427, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 1, 34, 42, 427, DateTimeKind.Local).AddTicks(3919));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameEN",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "NameEN",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Stock" },
                values: new object[] { new DateTime(2024, 6, 30, 18, 17, 12, 548, DateTimeKind.Local).AddTicks(737), 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Stock" },
                values: new object[] { new DateTime(2024, 6, 30, 18, 17, 12, 548, DateTimeKind.Local).AddTicks(745), 200 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Stock" },
                values: new object[] { new DateTime(2024, 6, 30, 18, 17, 12, 548, DateTimeKind.Local).AddTicks(746), 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Stock" },
                values: new object[] { new DateTime(2024, 6, 30, 18, 17, 12, 548, DateTimeKind.Local).AddTicks(747), 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Stock" },
                values: new object[] { new DateTime(2024, 6, 30, 18, 17, 12, 548, DateTimeKind.Local).AddTicks(748), 10 });
        }
    }
}
