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
    [Migration("20191024101147_spelling_mistake")]
    partial class spelling_mistake
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("WebServer.Models.Switching", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("accountFullname");

                    b.Property<string>("accountNumber");

                    b.Property<string>("accountSortCode");

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

                    b.Property<string>("postCode");

                    b.Property<string>("referredBy");

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

            modelBuilder.Entity("WebServer.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("firstName");

                    b.Property<string>("lastName");

                    b.Property<string>("telephone");

                    b.Property<string>("title");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
