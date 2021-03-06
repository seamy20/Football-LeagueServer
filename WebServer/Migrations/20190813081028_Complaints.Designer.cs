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
    [Migration("20190813081028_Complaints")]
    partial class Complaints
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
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

                    b.Property<string>("ComplaintType");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email");

                    b.Property<string>("EscalatedTo");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("LoggedBy");

                    b.Property<int>("MPRN");

                    b.Property<int>("PIN");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("SuspectedFraud");

                    b.HasKey("Id");

                    b.ToTable("Complaints");
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
#pragma warning restore 612, 618
        }
    }
}
