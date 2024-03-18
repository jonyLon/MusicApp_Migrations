using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicApp.Migrations
{
    public partial class AddColPublicationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albumls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albumls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albumls_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    PlaylistId = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracks_Albumls_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albumls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tracks_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Country", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "UK", "David", "Bowie" },
                    { 2, "UK", "Freddie", "Mercury" },
                    { 3, "USA", "Jimi", "Hendrix" },
                    { 4, "USA", "Elvis", "Presley" },
                    { 5, "UK", "John", "Lennon" },
                    { 6, "UK", "Paul", "McCartney" },
                    { 7, "UK", "Mick", "Jagger" },
                    { 8, "USA", "Kurt", "Cobain" },
                    { 9, "USA", "Bob", "Dylan" },
                    { 10, "UK", "Elton", "John" }
                });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { 1, "Rock", "Classic Rock Hits" },
                    { 2, "Rock", "70s Rock Anthems" },
                    { 3, "Rock", "Guitar Legends" },
                    { 4, "Rock and Roll", "Rock 'n Roll Classics" },
                    { 5, "Singer-Songwriter", "Songwriter Essentials" }
                });

            migrationBuilder.InsertData(
                table: "Albumls",
                columns: new[] { "Id", "ArtistId", "Genre", "Name", "PublicationDate", "Year" },
                values: new object[,]
                {
                    { 1, 1, "Rock", "The Rise and Fall of Ziggy Stardust and the Spiders from Mars", null, 1972 },
                    { 2, 2, "Rock", "Bohemian Rhapsody", null, 1975 },
                    { 3, 3, "Rock", "Are You Experienced", null, 1967 },
                    { 4, 4, "Rock and Roll", "Elvis Presley", null, 1956 },
                    { 5, 5, "Rock", "Imagine", null, 1971 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "Duration", "Name", "PlaylistId" },
                values: new object[,]
                {
                    { 1, 1, new TimeSpan(0, 0, 4, 10, 0), "Starman", 1 },
                    { 2, 1, new TimeSpan(0, 0, 3, 13, 0), "Ziggy Stardust", 1 },
                    { 3, 2, new TimeSpan(0, 0, 5, 55, 0), "Bohemian Rhapsody", 2 },
                    { 4, 2, new TimeSpan(0, 0, 4, 56, 0), "Somebody to Love", 2 },
                    { 5, 3, new TimeSpan(0, 0, 2, 50, 0), "Purple Haze", 3 },
                    { 6, 3, new TimeSpan(0, 0, 3, 18, 0), "Foxey Lady", 3 },
                    { 7, 4, new TimeSpan(0, 0, 2, 16, 0), "Hound Dog", 4 },
                    { 8, 4, new TimeSpan(0, 0, 2, 37, 0), "Jailhouse Rock", 4 },
                    { 9, 5, new TimeSpan(0, 0, 3, 3, 0), "Imagine", 5 },
                    { 10, 5, new TimeSpan(0, 0, 4, 14, 0), "Jealous Guy", 5 },
                    { 11, 1, new TimeSpan(0, 0, 7, 11, 0), "Hey Jude", 1 },
                    { 12, 2, new TimeSpan(0, 0, 4, 3, 0), "Let It Be", 2 },
                    { 13, 3, new TimeSpan(0, 0, 3, 44, 0), "Satisfaction", 3 },
                    { 14, 4, new TimeSpan(0, 0, 5, 1, 0), "Smells Like Teen Spirit", 4 },
                    { 15, 5, new TimeSpan(0, 0, 6, 9, 0), "Like a Rolling Stone", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albumls_ArtistId",
                table: "Albumls",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_AlbumId",
                table: "Tracks",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_PlaylistId",
                table: "Tracks",
                column: "PlaylistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Albumls");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
