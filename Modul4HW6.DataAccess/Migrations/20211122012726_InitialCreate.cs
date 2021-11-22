using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul4HW6.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsExist = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<double>(type: "float", nullable: false),
                    ReleasedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Song_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistSong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistSong_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistSong_Song_SongId",
                        column: x => x.SongId,
                        principalTable: "Song",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "Id", "DateOfBirth", "Email", "InstagramUrl", "IsExist", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1947, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.bowie@gmail.com", "https://www.instagram.com/someUrl1", false, "David", "+447458148918" },
                    { 2, new DateTime(1947, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "brian.may@gmail.com", "https://www.instagram.com/someUrl2", false, "Brian", "+445550178788" },
                    { 3, new DateTime(1951, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.deacon@gmail.com", "https://www.instagram.com/someUrl3", false, "John", "+443421172121" },
                    { 4, new DateTime(1949, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "roger.taylor@gmail.com", "https://www.instagram.com/someUrl4", false, "Roger", "+444317343411" },
                    { 5, new DateTime(1946, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "freddie.mercury@gmail.com", "https://www.instagram.com/someUrl5", false, "Freddie", "+447468168966" },
                    { 6, new DateTime(1991, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "jesse.rutherford@gmail.com", "https://www.instagram.com/someUrl6", true, "Jesse", "+447356168793" },
                    { 7, new DateTime(1975, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sufjan.stevens@gmail.com", "https://www.instagram.com/someUrl7", true, "Sufjan", "+447888834347" },
                    { 8, new DateTime(1974, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "jaleel.bunton@gmail.com", "https://www.instagram.com/someUrl8", true, "Jaleel", "+447212134179" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Genre1" },
                    { 2, "Genre2" },
                    { 3, "Genre3" },
                    { 4, "Genre4" },
                    { 5, "Genre5" }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "Id", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[,]
                {
                    { 3, 1.8799999999999999, 1, new DateTime(1975, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song3" },
                    { 7, 2.3399999999999999, 1, new DateTime(1999, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song7" },
                    { 1, 1.21, 2, new DateTime(1973, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song1" },
                    { 2, 2.0499999999999998, 3, new DateTime(1971, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song2" },
                    { 6, 2.21, 3, new DateTime(1997, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song6" },
                    { 8, 2.1699999999999999, 3, new DateTime(1986, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song8" },
                    { 5, 3.0499999999999998, 4, new DateTime(2010, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song5" },
                    { 4, 1.3500000000000001, 5, new DateTime(1973, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Song4" }
                });

            migrationBuilder.InsertData(
                table: "ArtistSong",
                columns: new[] { "Id", "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 3, 3, 3 },
                    { 1, 1, 1 },
                    { 2, 4, 2 },
                    { 5, 8, 5 },
                    { 6, 1, 5 },
                    { 4, 7, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSong_ArtistId",
                table: "ArtistSong",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSong_SongId",
                table: "ArtistSong",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_GenreId",
                table: "Song",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistSong");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
