﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebServer;

namespace WebServer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200207202217_Teamsupdate2")]
    partial class Teamsupdate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebServer.Models.BusinessCallback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusinessName");

                    b.Property<string>("ContactTime");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("BusinessCallback");
                });

            modelBuilder.Entity("WebServer.Models.Complaints", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClosedOnInitialContact");

                    b.Property<DateTime>("ComplaintDateTime");

                    b.Property<string>("ComplaintDetails");

                    b.Property<string>("ComplaintID");

                    b.Property<string>("ComplaintType");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email");

                    b.Property<string>("EscalatedTo");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("LoggedBy");

                    b.Property<int>("MPRN");

                    b.Property<string>("PIN");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("SuspectedFraud");

                    b.HasKey("Id");

                    b.ToTable("Complaints");
                });

            modelBuilder.Entity("WebServer.Models.LeagueModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Division");

                    b.Property<string>("LeagueName");

                    b.Property<string>("Region");

                    b.HasKey("Id");

                    b.ToTable("LeagueModel");
                });

            modelBuilder.Entity("WebServer.Models.MovingHomeBillPay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("accountNumber");

                    b.Property<string>("contactError");

                    b.Property<string>("contactNumber");

                    b.Property<string>("contactTime");

                    b.Property<string>("currentCity");

                    b.Property<string>("currentDoorNumber");

                    b.Property<string>("currentPostcode");

                    b.Property<string>("currentStreet");

                    b.Property<string>("dayMeterRead");

                    b.Property<string>("email");

                    b.Property<string>("firstName");

                    b.Property<string>("lastName");

                    b.Property<string>("moveInDate");

                    b.Property<string>("moveOutDate");

                    b.Property<string>("newCity");

                    b.Property<string>("newDoorNumber");

                    b.Property<string>("newPostcode");

                    b.Property<string>("newStreet");

                    b.Property<string>("nightMeterRead");

                    b.Property<string>("title");

                    b.HasKey("Id");

                    b.ToTable("MovingHomeBillPay");
                });

            modelBuilder.Entity("WebServer.Models.MovingHomeKeypad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("accountNumber");

                    b.Property<string>("contactError");

                    b.Property<string>("contactNumber");

                    b.Property<string>("contactTime");

                    b.Property<string>("currentCity");

                    b.Property<string>("currentDoorNumber");

                    b.Property<string>("currentPostcode");

                    b.Property<string>("currentStreet");

                    b.Property<string>("email");

                    b.Property<string>("firstName");

                    b.Property<string>("lastName");

                    b.Property<string>("lastVendAmount");

                    b.Property<string>("lastVendDate");

                    b.Property<string>("moveInDate");

                    b.Property<string>("moveOutDate");

                    b.Property<string>("newCity");

                    b.Property<string>("newDoorNumber");

                    b.Property<string>("newPostcode");

                    b.Property<string>("newStreet");

                    b.Property<string>("title");

                    b.HasKey("Id");

                    b.ToTable("MovingHomeKeypad");
                });

            modelBuilder.Entity("WebServer.Models.PageContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName");

                    b.Property<string>("Jurisdiction");

                    b.Property<string>("Page");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("PageContents");
                });

            modelBuilder.Entity("WebServer.Models.SalesReps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Agency");

                    b.Property<string>("Assessment");

                    b.Property<string>("CompletionDate");

                    b.Property<string>("Expiry");

                    b.Property<string>("TrainingStatus");

                    b.Property<string>("accessNI");

                    b.Property<string>("budgetID");

                    b.Property<string>("dateOfIssue");

                    b.Property<string>("firstName");

                    b.Property<string>("jurisdiction");

                    b.Property<string>("lastName");

                    b.Property<string>("password");

                    b.Property<string>("salesManager");

                    b.Property<string>("tabletSerialNO");

                    b.Property<string>("telephone");

                    b.Property<string>("title");

                    b.HasKey("Id");

                    b.ToTable("SalesReps");
                });

            modelBuilder.Entity("WebServer.Models.Switching", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MPRN");

                    b.Property<string>("accountFullname");

                    b.Property<string>("accountNumber");

                    b.Property<string>("accountSortCode");

                    b.Property<string>("addressLine1");

                    b.Property<string>("addressLine4");

                    b.Property<bool>("authorisation");

                    b.Property<bool>("authorisationError");

                    b.Property<bool>("billPay");

                    b.Property<bool>("billingAddress");

                    b.Property<string>("billingCity");

                    b.Property<string>("billingCounty");

                    b.Property<string>("billingDoorNumber");

                    b.Property<string>("billingFullName");

                    b.Property<string>("billingPostcode");

                    b.Property<string>("billingStreet");

                    b.Property<string>("city");

                    b.Property<string>("confirmEmail");

                    b.Property<string>("county");

                    b.Property<string>("dayMeterRead");

                    b.Property<string>("dob");

                    b.Property<string>("doorNumber");

                    b.Property<string>("email");

                    b.Property<string>("firstName");

                    b.Property<bool>("jointAccount");

                    b.Property<string>("jointConfirmEmail");

                    b.Property<string>("jointEmail");

                    b.Property<string>("jointFirstName");

                    b.Property<string>("jointLastName");

                    b.Property<string>("jointMobile");

                    b.Property<string>("jointTitle");

                    b.Property<string>("kpn");

                    b.Property<string>("lastName");

                    b.Property<bool>("medicalEquipment");

                    b.Property<string>("medicalEquipmentOption");

                    b.Property<string>("meterType");

                    b.Property<string>("mobile");

                    b.Property<string>("nightMeterRead");

                    b.Property<string>("paymentAmount");

                    b.Property<string>("paymentDate");

                    b.Property<string>("paymentType");

                    b.Property<string>("postCode");

                    b.Property<string>("referredBy");

                    b.Property<string>("salesRepID");

                    b.Property<bool>("speicalServices");

                    b.Property<string>("speicalServicesOption");

                    b.Property<string>("street");

                    b.Property<string>("switchoverDueDate");

                    b.Property<string>("telephone");

                    b.Property<string>("title");

                    b.Property<bool>("yourPremises");

                    b.HasKey("Id");

                    b.ToTable("Switching");
                });

            modelBuilder.Entity("WebServer.Models.TariffContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName");

                    b.Property<string>("Jurisdiction");

                    b.Property<string>("MeterType");

                    b.Property<string>("PaymentType");

                    b.Property<string>("Tariff");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("TariffContents");
                });

            modelBuilder.Entity("WebServer.Models.Teams", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AwayDefeats");

                    b.Property<string>("AwayDraws");

                    b.Property<string>("AwayGoalsAgainst");

                    b.Property<string>("AwayGoalsFor");

                    b.Property<string>("AwayWins");

                    b.Property<string>("Draws");

                    b.Property<string>("GoalsAgainst");

                    b.Property<string>("GoalsDifference");

                    b.Property<string>("GoalsFor");

                    b.Property<string>("HomeDefeats");

                    b.Property<string>("HomeDraws");

                    b.Property<string>("HomeGoalsAgainst");

                    b.Property<string>("HomeGoalsFor");

                    b.Property<string>("HomeWins");

                    b.Property<string>("LeagueID");

                    b.Property<string>("Lost");

                    b.Property<string>("MatchesPlayed");

                    b.Property<int>("Points");

                    b.Property<string>("TeamName");

                    b.Property<string>("Wins");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
