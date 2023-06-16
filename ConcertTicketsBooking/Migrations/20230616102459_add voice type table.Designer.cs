﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace ConcertTicketsBooking.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230616102459_add voice type table")]
    partial class addvoicetypetable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.Booking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BookingTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ConcertId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ConcertId");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Entities.Models.Concert", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlaceId")
                        .HasColumnType("int");

                    b.Property<int>("TicketsNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.ToTable("Concerts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Concert");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Entities.Models.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Models.VoiceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VoiceTypes");
                });

            modelBuilder.Entity("Entities.Models.ClassicConcert", b =>
                {
                    b.HasBaseType("Entities.Models.Concert");

                    b.Property<string>("Composer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompositionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VoiceTypeId")
                        .HasColumnType("int");

                    b.HasIndex("VoiceTypeId");

                    b.HasDiscriminator().HasValue("ClassicConcert");
                });

            modelBuilder.Entity("Entities.Models.OpenAirConcert", b =>
                {
                    b.HasBaseType("Entities.Models.Concert");

                    b.Property<string>("DrivingDirections")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeadLiner")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("OpenAirConcert");
                });

            modelBuilder.Entity("Entities.Models.PartyConcert", b =>
                {
                    b.HasBaseType("Entities.Models.Concert");

                    b.Property<int>("MinAge")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("PartyConcert");
                });

            modelBuilder.Entity("Entities.Models.Booking", b =>
                {
                    b.HasOne("Entities.Models.Concert", "Concert")
                        .WithMany()
                        .HasForeignKey("ConcertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Concert");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Models.Concert", b =>
                {
                    b.HasOne("Entities.Models.Place", "Place")
                        .WithMany("Concerts")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");
                });

            modelBuilder.Entity("Entities.Models.ClassicConcert", b =>
                {
                    b.HasOne("Entities.Models.VoiceType", "VoiceType")
                        .WithMany()
                        .HasForeignKey("VoiceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VoiceType");
                });

            modelBuilder.Entity("Entities.Models.Place", b =>
                {
                    b.Navigation("Concerts");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
