using Microsoft.EntityFrameworkCore.Migrations;

namespace WebServer.Migrations
{
    public partial class salesRep4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tabletSerialNO",
                table: "SalesReps",
                newName: "TrainingStatus");

            migrationBuilder.AddColumn<string>(
                name: "Agency",
                table: "SalesReps",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assessment",
                table: "SalesReps",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompletionDate",
                table: "SalesReps",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Expiry",
                table: "SalesReps",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Agency",
                table: "SalesReps");

            migrationBuilder.DropColumn(
                name: "Assessment",
                table: "SalesReps");

            migrationBuilder.DropColumn(
                name: "CompletionDate",
                table: "SalesReps");

            migrationBuilder.DropColumn(
                name: "Expiry",
                table: "SalesReps");

            migrationBuilder.RenameColumn(
                name: "TrainingStatus",
                table: "SalesReps",
                newName: "tabletSerialNO");
        }
    }
}
