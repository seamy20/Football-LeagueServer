using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebServer.Migrations
{
    public partial class fixtures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fixtures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HomeTeam = table.Column<string>(nullable: true),
                    AwayTeam = table.Column<string>(nullable: true),
                    FixtureDate = table.Column<DateTime>(nullable: false),
                    Referee = table.Column<string>(nullable: true),
                    Venue = table.Column<string>(nullable: true),
                    Sponser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fixtures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HomeName = table.Column<string>(nullable: true),
                    AwayTeam = table.Column<string>(nullable: true),
                    HomeTeamGoals = table.Column<string>(nullable: true),
                    AwayTeamGoals = table.Column<string>(nullable: true),
                    HomeNameRedCards = table.Column<string>(nullable: true),
                    AwayNameRedCards = table.Column<string>(nullable: true),
                    HomeNameYellowCards = table.Column<string>(nullable: true),
                    AwayNameYellowCards = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fixtures");

            migrationBuilder.DropTable(
                name: "Results");
        }
    }
}
