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
    [Migration("20200216200111_playerPos")]
    partial class playerPos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebServer.Models.Fixtures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AwayTeam");

                    b.Property<DateTime>("FixtureDate");

                    b.Property<string>("HomeTeam");

                    b.Property<string>("Referee");

                    b.Property<string>("Sponser");

                    b.Property<string>("Venue");

                    b.HasKey("Id");

                    b.ToTable("Fixtures");
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

            modelBuilder.Entity("WebServer.Models.Players", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CleanSheets");

                    b.Property<string>("GoalsScored");

                    b.Property<string>("PlayerName");

                    b.Property<string>("Position");

                    b.Property<string>("RedCards");

                    b.Property<string>("TeamId");

                    b.Property<string>("YellowCards");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("WebServer.Models.Results", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AwayNameRedCards");

                    b.Property<string>("AwayNameYellowCards");

                    b.Property<string>("AwayTeam");

                    b.Property<string>("AwayTeamGoals");

                    b.Property<string>("HomeName");

                    b.Property<string>("HomeNameRedCards");

                    b.Property<string>("HomeNameYellowCards");

                    b.Property<string>("HomeTeamGoals");

                    b.HasKey("Id");

                    b.ToTable("Results");
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

                    b.Property<string>("TeamLogo");

                    b.Property<string>("TeamName");

                    b.Property<string>("Wins");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
