using Microsoft.EntityFrameworkCore.Migrations;

namespace WebServer.Migrations
{
    public partial class salesRep3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "SalesReps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "accessNI",
                table: "SalesReps",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dateOfIssue",
                table: "SalesReps",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "salesManager",
                table: "SalesReps",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tabletSerialNO",
                table: "SalesReps",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "SalesReps");

            migrationBuilder.DropColumn(
                name: "accessNI",
                table: "SalesReps");

            migrationBuilder.DropColumn(
                name: "dateOfIssue",
                table: "SalesReps");

            migrationBuilder.DropColumn(
                name: "salesManager",
                table: "SalesReps");

            migrationBuilder.DropColumn(
                name: "tabletSerialNO",
                table: "SalesReps");
        }
    }
}
