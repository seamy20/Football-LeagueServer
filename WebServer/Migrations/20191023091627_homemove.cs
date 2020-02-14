using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebServer.Migrations
{
    public partial class homemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovingHome",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(nullable: true),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    accountNumber = table.Column<string>(nullable: true),
                    contactNumber = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    currentPostcode = table.Column<string>(nullable: true),
                    currentDoorNumber = table.Column<string>(nullable: true),
                    currentStreet = table.Column<string>(nullable: true),
                    currentCity = table.Column<string>(nullable: true),
                    newPostcode = table.Column<string>(nullable: true),
                    newDoorNumber = table.Column<string>(nullable: true),
                    newStreet = table.Column<string>(nullable: true),
                    newCity = table.Column<string>(nullable: true),
                    moveOutDate = table.Column<string>(nullable: true),
                    moveInDate = table.Column<string>(nullable: true),
                    dayMeterRead = table.Column<string>(nullable: true),
                    nightMeterRead = table.Column<string>(nullable: true),
                    contactTime = table.Column<string>(nullable: true),
                    contactError = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovingHome", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovingHome");
        }
    }
}
