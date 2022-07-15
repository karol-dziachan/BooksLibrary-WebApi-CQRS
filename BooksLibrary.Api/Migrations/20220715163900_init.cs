using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksLibrary.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsAvailAble = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    PublicationCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    BorrowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BorrowHistories_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthPlace", "Created", "CreatedBy", "DoB", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Poland", new DateTime(2022, 7, 15, 18, 39, 0, 145, DateTimeKind.Local).AddTicks(316), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1, "Andrzej", "Sapkowski" },
                    { 2, "Poland", new DateTime(2022, 7, 15, 18, 39, 0, 145, DateTimeKind.Local).AddTicks(1036), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1, "Stanisław", "Lem" },
                    { 3, "Poland", new DateTime(2022, 7, 15, 18, 39, 0, 145, DateTimeKind.Local).AddTicks(1222), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1, "Joanna", "Chmielewska" },
                    { 4, "Poland", new DateTime(2022, 7, 15, 18, 39, 0, 145, DateTimeKind.Local).AddTicks(1307), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1, "Andrzej", "Stojowski" },
                    { 5, "USA", new DateTime(2022, 7, 15, 18, 39, 0, 145, DateTimeKind.Local).AddTicks(1382), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1, "Ernest", "Haycox" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, null, null, "Fantasy", 0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, null, null, "Science fiction", 0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, null, null, "Thriller", 0 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, null, null, "Romance", 0 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, null, null, "Western", 0 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Created", "CreatedBy", "GenreId", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PublicationCountry", "StatusId", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1, null, null, null, null, "Poland", 1, "Wiedźmin" },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1, null, null, null, null, "Poland", 1, "Krew elfów" },
                    { 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1, null, null, null, null, "Poland", 1, "Ostatnie życzenie" },
                    { 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1, null, null, null, null, "Poland", 1, "Sezon burz" },
                    { 5, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1, null, null, null, null, "Poland", 1, "Pani Jeziora" },
                    { 6, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1, null, null, null, null, "Poland", 1, "Czas pogardy" },
                    { 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 2, null, null, null, null, "Poland", 1, "Solaris" },
                    { 8, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 2, null, null, null, null, "Poland", 1, "Eden" },
                    { 9, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 2, null, null, null, null, "Poland", 1, "Fiasko" },
                    { 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 2, null, null, null, null, "Poland", 1, "Dzienniki gwiazdowe" },
                    { 11, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 2, null, null, null, null, "Poland", 1, "Cyberiada" },
                    { 12, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 2, null, null, null, null, "Poland", 1, "Bajki robotów" },
                    { 13, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, null, null, null, null, "Poland", 1, "Klin" },
                    { 14, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, null, null, null, null, "Poland", 1, "Lesio" },
                    { 15, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, null, null, null, null, "Poland", 1, "Dzikie białko" },
                    { 16, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, null, null, null, null, "Poland", 1, "Nawiedzony dom" },
                    { 17, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, null, null, null, null, "Poland", 1, "Wszystko czerwone" },
                    { 18, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, null, null, null, null, "Poland", 1, "Zwyczajne życie" },
                    { 19, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 4, null, null, null, null, "Poland", 1, "Kareta" },
                    { 20, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 4, null, null, null, null, "Poland", 1, "W ręku Boga" },
                    { 21, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 4, null, null, null, null, "Poland", 1, "Zamek w Karpatach" },
                    { 22, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 4, null, null, null, null, "Poland", 1, "Chłopiec na kucu" },
                    { 23, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 4, null, null, null, null, "Poland", 1, "Carskie wrota" },
                    { 24, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 4, null, null, null, null, "Poland", 1, "Kanonierka" },
                    { 25, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, null, null, null, null, "USA", 1, "Les Pionniers" },
                    { 26, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, null, null, null, null, "USA", 1, "Bugles in the Afternoon" },
                    { 27, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, null, null, null, null, "USA", 1, "Alder Gulch" },
                    { 28, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, null, null, null, null, "USA", 1, "Free Grass" },
                    { 29, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, null, null, null, null, "USA", 1, "Trail Town" },
                    { 30, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, null, null, null, null, "USA", 1, "Trouble Shooter" },
                    { 31, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, null, null, null, null, "USA", 1, "The Adventures" },
                    { 32, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, null, null, null, null, "USA", 1, "The wild bunch" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowHistories_BookId",
                table: "BorrowHistories",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowHistories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
