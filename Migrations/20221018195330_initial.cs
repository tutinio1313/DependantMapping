using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Patron.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "albums",
                columns: table => new
                {
                    id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Artist = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_albums", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    TrackID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    length = table.Column<string>(type: "TEXT", nullable: false),
                    Albumid = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.TrackID);
                    table.ForeignKey(
                        name: "FK_Track_albums_Albumid",
                        column: x => x.Albumid,
                        principalTable: "albums",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Track_Albumid",
                table: "Track",
                column: "Albumid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Track");

            migrationBuilder.DropTable(
                name: "albums");
        }
    }
}
