using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksLibrary.Migrations
{
    public partial class BugFixing1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAvailAble",
                table: "Books",
                newName: "IsAvailable");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnDate",
                table: "BorrowHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 16, 15, 39, 9, 211, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 16, 15, 39, 9, 211, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 16, 15, 39, 9, 211, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 7, 16, 15, 39, 9, 211, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 7, 16, 15, 39, 9, 211, DateTimeKind.Local).AddTicks(7512));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "BorrowHistories");

            migrationBuilder.RenameColumn(
                name: "IsAvailable",
                table: "Books",
                newName: "IsAvailAble");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 16, 13, 22, 24, 69, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 16, 13, 22, 24, 69, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 16, 13, 22, 24, 69, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 7, 16, 13, 22, 24, 69, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 7, 16, 13, 22, 24, 69, DateTimeKind.Local).AddTicks(7991));
        }
    }
}
