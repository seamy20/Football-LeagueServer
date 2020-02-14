using Microsoft.EntityFrameworkCore.Migrations;

namespace WebServer.Migrations
{
    public partial class Teamsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Draws",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoalsAgainst",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoalsDifference",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoalsFor",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lost",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "Teams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Wins",
                table: "Teams",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Draws",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "GoalsAgainst",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "GoalsDifference",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "GoalsFor",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Lost",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Wins",
                table: "Teams");
        }
    }
}
