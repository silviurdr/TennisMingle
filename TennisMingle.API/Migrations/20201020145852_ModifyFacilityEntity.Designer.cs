﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TennisMingle.API.Models;

namespace TennisMingle.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201020145852_ModifyFacilityEntity")]
    partial class ModifyFacilityEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TennisMingle.API.Models.AddressDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("TennisMingle.API.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("TennisCourtId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_end")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("TennisCourtId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("TennisMingle.API.Models.CityDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("TennisMingle.API.Models.Facility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacilityType")
                        .HasColumnType("int");

                    b.Property<int>("TennisClubId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TennisClubId");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("TennisMingle.API.Models.PersonDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TennisClubId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TennisClubId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("TennisMingle.API.Models.Surface", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SurfaceType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Surfaces");
                });

            modelBuilder.Entity("TennisMingle.API.Models.TennisClubDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Schedule")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("TennisClubs");
                });

            modelBuilder.Entity("TennisMingle.API.Models.TennisCourtDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("SurfaceId")
                        .HasColumnType("int");

                    b.Property<int>("TennisClubId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SurfaceId");

                    b.HasIndex("TennisClubId");

                    b.ToTable("TennisCourts");
                });

            modelBuilder.Entity("TennisMingle.API.Models.AddressDTO", b =>
                {
                    b.HasOne("TennisMingle.API.Models.CityDTO", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TennisMingle.API.Models.Booking", b =>
                {
                    b.HasOne("TennisMingle.API.Models.PersonDTO", "User")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TennisMingle.API.Models.TennisCourtDTO", "TennisCourt")
                        .WithMany()
                        .HasForeignKey("TennisCourtId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TennisMingle.API.Models.Facility", b =>
                {
                    b.HasOne("TennisMingle.API.Models.TennisClubDTO", "TennisClub")
                        .WithMany()
                        .HasForeignKey("TennisClubId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TennisMingle.API.Models.PersonDTO", b =>
                {
                    b.HasOne("TennisMingle.API.Models.TennisClubDTO", "TennisClub")
                        .WithMany()
                        .HasForeignKey("TennisClubId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("TennisMingle.API.Models.TennisClubDTO", b =>
                {
                    b.HasOne("TennisMingle.API.Models.AddressDTO", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TennisMingle.API.Models.TennisCourtDTO", b =>
                {
                    b.HasOne("TennisMingle.API.Models.Surface", "Surface")
                        .WithMany()
                        .HasForeignKey("SurfaceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TennisMingle.API.Models.TennisClubDTO", "TennisClub")
                        .WithMany()
                        .HasForeignKey("TennisClubId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
