using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPageMovies.Migrations
{
    public partial class MovieIdInActor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Movie",
                table: "Actor",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Movie",
                table: "Actor");
        }
    }
}
