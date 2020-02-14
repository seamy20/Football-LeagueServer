using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebServer.Migrations
{
    public partial class joinform : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Join",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(nullable: true),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    doorNumber = table.Column<string>(nullable: true),
                    street = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    county = table.Column<string>(nullable: true),
                    dob = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    confirmEmail = table.Column<string>(nullable: true),
                    telephone = table.Column<string>(nullable: true),
                    mobile = table.Column<string>(nullable: true),
                    referredBy = table.Column<string>(nullable: true),
                    kpn = table.Column<string>(nullable: true),
                    switchoverDueDate = table.Column<string>(nullable: true),
                    dayMeterRead = table.Column<string>(nullable: true),
                    nightMeterRead = table.Column<string>(nullable: true),
                    billPay = table.Column<bool>(nullable: false),
                    accountFullname = table.Column<string>(nullable: true),
                    accountNumber = table.Column<string>(nullable: true),
                    accountSortCode = table.Column<string>(nullable: true),
                    paymentDate = table.Column<string>(nullable: true),
                    paymentAmount = table.Column<string>(nullable: true),
                    jointAccount = table.Column<bool>(nullable: false),
                    jointTitle = table.Column<string>(nullable: true),
                    jointFirstName = table.Column<string>(nullable: true),
                    jointLastName = table.Column<string>(nullable: true),
                    jointEmail = table.Column<string>(nullable: true),
                    jointConfirmEmail = table.Column<string>(nullable: true),
                    jointMobile = table.Column<string>(nullable: true),
                    speicalServices = table.Column<bool>(nullable: false),
                    speicalServicesOption = table.Column<string>(nullable: true),
                    medicalEquipment = table.Column<bool>(nullable: false),
                    medicalEquipmentOption = table.Column<string>(nullable: true),
                    billingAddress = table.Column<bool>(nullable: false),
                    billingFullName = table.Column<string>(nullable: true),
                    billingPostcode = table.Column<string>(nullable: true),
                    billingDoorNumber = table.Column<string>(nullable: true),
                    billingStreet = table.Column<string>(nullable: true),
                    billingCity = table.Column<string>(nullable: true),
                    billingCounty = table.Column<string>(nullable: true),
                    yourPremises = table.Column<bool>(nullable: false),
                    authorisation = table.Column<bool>(nullable: false),
                    authorisationError = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Join");
        }
    }
}
