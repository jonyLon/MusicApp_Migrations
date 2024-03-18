using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicApp.Migrations
{
    public partial class AddRatingClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RatingId",
                table: "Albumls",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AlbumRating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlbumRating_Albumls_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albumls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AlbumRating",
                columns: new[] { "Id", "AlbumId", "Rating" },
                values: new object[,]
                {
                    { 1, 1, 3.8999999999999999 },
                    { 2, 2, 4.9000000000000004 },
                    { 3, 3, 4.5999999999999996 },
                    { 4, 4, 4.0999999999999996 },
                    { 5, 5, 4.7000000000000002 }
                });

            migrationBuilder.UpdateData(
                table: "Albumls",
                keyColumn: "Id",
                keyValue: 1,
                column: "RatingId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Albumls",
                keyColumn: "Id",
                keyValue: 2,
                column: "RatingId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Albumls",
                keyColumn: "Id",
                keyValue: 3,
                column: "RatingId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Albumls",
                keyColumn: "Id",
                keyValue: 4,
                column: "RatingId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Albumls",
                keyColumn: "Id",
                keyValue: 5,
                column: "RatingId",
                value: 5);

            migrationBuilder.CreateIndex(
                name: "IX_AlbumRating_AlbumId",
                table: "AlbumRating",
                column: "AlbumId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumRating");

            migrationBuilder.DropColumn(
                name: "RatingId",
                table: "Albumls");
        }
    }
}
