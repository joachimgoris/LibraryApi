using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "db_Authors",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    First_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(maxLength: 15, nullable: true),
                    Date_Of_Birth = table.Column<DateTime>(type: "datetime", nullable: false),
                    Date_Of_Death = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_db_Authors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dc_Genres",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dc_Genres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dc_Languages",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Language = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dc_Languages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dc_Series",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Books_In_Series = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dc_Series", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dc_Books",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    ISBN = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    Title = table.Column<string>(nullable: false),
                    LanguageId = table.Column<string>(nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    SeriesId = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Page_Count = table.Column<int>(nullable: false),
                    GenreId = table.Column<string>(nullable: true),
                    Loaned = table.Column<bool>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    EBook = table.Column<bool>(nullable: false),
                    Fiction = table.Column<bool>(nullable: false),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dc_Books", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dc_Books_db_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "db_Authors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dc_Books_dc_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "dc_Genres",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dc_Books_dc_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "dc_Languages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dc_Books_dc_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "dc_Series",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "dc_Languages",
                columns: new[] { "ID", "Language" },
                values: new object[,]
                {
                    { "68e61149-c64e-4a81-ac63-c4c6cb6cbed6", "DUTCH" },
                    { "eadfbeae-faec-415b-bc0c-f5d77f0bad9c", "ENGLISH" },
                    { "074bc86e-78a5-4ae4-935f-fe6a7046be94", "FRENCH" },
                    { "5d1b3d03-2850-4e23-9969-8aa51ea32bf6", "GERMAN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_dc_Books_AuthorId",
                table: "dc_Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_dc_Books_GenreId",
                table: "dc_Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_dc_Books_LanguageId",
                table: "dc_Books",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_dc_Books_SeriesId",
                table: "dc_Books",
                column: "SeriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dc_Books");

            migrationBuilder.DropTable(
                name: "db_Authors");

            migrationBuilder.DropTable(
                name: "dc_Genres");

            migrationBuilder.DropTable(
                name: "dc_Languages");

            migrationBuilder.DropTable(
                name: "dc_Series");
        }
    }
}
