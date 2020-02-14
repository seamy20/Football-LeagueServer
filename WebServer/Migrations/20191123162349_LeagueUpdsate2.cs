using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebServer.Migrations
{
    public partial class LeagueUpdsate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamName = table.Column<string>(nullable: true),
                    LeagueID = table.Column<string>(nullable: true),
                    HomeWins = table.Column<string>(nullable: true),
                    HomeDraws = table.Column<string>(nullable: true),
                    HomeDefeats = table.Column<string>(nullable: true),
                    HomeGoalsFor = table.Column<string>(nullable: true),
                    HomeGoalsAgainst = table.Column<string>(nullable: true),
                    AwayWins = table.Column<string>(nullable: true),
                    AwayDraws = table.Column<string>(nullable: true),
                    AwayDefeats = table.Column<string>(nullable: true),
                    AwayGoalsFor = table.Column<string>(nullable: true),
                    AwayGoalsAgainst = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
