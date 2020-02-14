using Microsoft.EntityFrameworkCore.Migrations;

namespace WebServer.Migrations
{
    public partial class address_line : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "addressLine1",
                table: "Switching",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "addressLine4",
                table: "Switching",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "addressLine1",
                table: "Switching");

            migrationBuilder.DropColumn(
                name: "addressLine4",
                table: "Switching");
        }
    }
}
