using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Users",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Products",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Categories",
                newName: "CreatedDate");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 30, 18, 17, 12, 548, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 30, 18, 17, 12, 548, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 30, 18, 17, 12, 548, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 30, 18, 17, 12, 548, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 30, 18, 17, 12, 548, DateTimeKind.Local).AddTicks(748));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Users",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Products",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Categories",
                newName: "DateTime");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 6, 30, 18, 13, 47, 806, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 6, 30, 18, 13, 47, 806, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 6, 30, 18, 13, 47, 806, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 6, 30, 18, 13, 47, 806, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 6, 30, 18, 13, 47, 806, DateTimeKind.Local).AddTicks(2973));
        }
    }
}
