using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_eg439.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Notes", "Rating", "Title", "Year", "lentTo" },
                values: new object[] { 1, "Action", "Your Mom", true, null, "PG-13", "Fast and Furious", "1999", null });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Notes", "Rating", "Title", "Year", "lentTo" },
                values: new object[] { 2, "Action", "Your Dad", false, "This is possibly the best movie ever created", "PG-13", "Avatar", "2011", null });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Notes", "Rating", "Title", "Year", "lentTo" },
                values: new object[] { 3, "Romance/Coming of Age", "Your Dad", false, "This is another one of the greatest films every made", "PG", "Cinderlla Story: Hillary Duff", "2011", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
