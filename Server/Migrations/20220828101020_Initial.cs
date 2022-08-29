using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieJournal.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: true),
                    Genre = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    Stars = table.Column<int>(type: "INTEGER", nullable: true),
                    Review = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Review", "Stars", "Status", "Title", "Year" },
                values: new object[] { 1, "Crime", "Yep", 55, "Not Seen", "Street Kings", 2008 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Review", "Stars", "Status", "Title", "Year" },
                values: new object[] { 2, "Animation", "Yep", 96, "Seen", "Spirited Away", 2001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
