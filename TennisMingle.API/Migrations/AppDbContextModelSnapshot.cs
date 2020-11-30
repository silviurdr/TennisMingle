﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TennisMingle.API.Data;

namespace TennisMingle.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TennisMingle.API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("TennisClubId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("TennisClubId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TennisMingle.API.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Confirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TennisCourtId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("TennisCourtId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("TennisMingle.API.Entities.City", b =>
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

            modelBuilder.Entity("TennisMingle.API.Entities.Facility", b =>
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

                    b.ToTable("Facility");
                });

            modelBuilder.Entity("TennisMingle.API.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("PublicId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TennisClubId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique()
                        .HasFilter("[PersonId] IS NOT NULL");

                    b.HasIndex("TennisClubId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("TennisMingle.API.Entities.Surface", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SurfaceType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Surface");
                });

            modelBuilder.Entity("TennisMingle.API.Entities.TennisClub", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
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

                    b.HasIndex("CityId");

                    b.ToTable("TennisClubs");
                });

            modelBuilder.Entity("TennisMingle.API.Entities.TennisCourt", b =>
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

            modelBuilder.Entity("TennisMingle.API.Entities.AppUser", b =>
                {
                    b.HasOne("TennisMingle.API.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TennisMingle.API.Entities.TennisClub", "TennisClub")
                        .WithMany("Persons")
                        .HasForeignKey("TennisClubId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("TennisMingle.API.Entities.Booking", b =>
                {
                    b.HasOne("TennisMingle.API.Entities.AppUser", "Person")
                        .WithMany("Bookings")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TennisMingle.API.Entities.TennisCourt", "TennisCourt")
                        .WithMany("Bookings")
                        .HasForeignKey("TennisCourtId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TennisMingle.API.Entities.Facility", b =>
                {
                    b.HasOne("TennisMingle.API.Entities.TennisClub", "TennisClub")
                        .WithMany("Facilities")
                        .HasForeignKey("TennisClubId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TennisMingle.API.Entities.Photo", b =>
                {
                    b.HasOne("TennisMingle.API.Entities.AppUser", "Person")
                        .WithOne("Photo")
                        .HasForeignKey("TennisMingle.API.Entities.Photo", "PersonId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TennisMingle.API.Entities.TennisClub", "TennisClub")
                        .WithMany("Photos")
                        .HasForeignKey("TennisClubId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("TennisMingle.API.Entities.TennisClub", b =>
                {
                    b.HasOne("TennisMingle.API.Entities.City", "City")
                        .WithMany("TennisClubs")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TennisMingle.API.Entities.TennisCourt", b =>
                {
                    b.HasOne("TennisMingle.API.Entities.Surface", "Surface")
                        .WithMany("TennisCourts")
                        .HasForeignKey("SurfaceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TennisMingle.API.Entities.TennisClub", "TennisClub")
                        .WithMany("TennisCourts")
                        .HasForeignKey("TennisClubId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
