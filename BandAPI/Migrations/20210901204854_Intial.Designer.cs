﻿// <auto-generated />
using System;
using BandAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BandAPI.Migrations
{
    [DbContext(typeof(BandAlbumContext))]
    [Migration("20210901204854_Intial")]
    partial class Intial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BandAPI.Entities.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("BandId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = new Guid("91888f1b-acfd-4749-aaf0-21142fbf4816"),
                            BandId = new Guid("379dfaa6-a6ec-47ca-ac35-ecd49d9dc3c4"),
                            Description = "One of the best heavy metal albums ever",
                            Title = "Master of Puppets"
                        },
                        new
                        {
                            Id = new Guid("ec8c3f22-1d68-4e98-965a-bd44b18988e5"),
                            BandId = new Guid("4323e0b5-58b4-4e9e-9eff-f35aad529f25"),
                            Description = "Amazing Afrobeat album with raw sound",
                            Title = "Zombie"
                        },
                        new
                        {
                            Id = new Guid("65fd490c-5dbd-45c9-8a44-5a8efa873024"),
                            BandId = new Guid("f17ebd4a-dd77-46fd-95dc-202727da4e64"),
                            Description = "Very groovy album with badass beat",
                            Title = "The Roots"
                        },
                        new
                        {
                            Id = new Guid("8ceda5ae-3713-4343-9db5-a4a8a52699b5"),
                            BandId = new Guid("9f7522ec-4eec-45e1-8e2e-8887c69933d1"),
                            Description = "Awesome Debut album by A-Ha",
                            Title = "Hunting Hight and Low"
                        },
                        new
                        {
                            Id = new Guid("498ee919-d3e8-4ad5-929a-fa4b7c14e18d"),
                            BandId = new Guid("a8be796f-f2fc-4e1f-a36b-08f60cddc22f"),
                            Description = "Arguably one of the best albums by Oasis",
                            Title = "Be Here Now"
                        },
                        new
                        {
                            Id = new Guid("984c767b-93f8-49c9-a0c9-33089ec7d12a"),
                            BandId = new Guid("873a1ffd-d60f-46bb-ae64-b5a642b0eae2"),
                            Description = "Great Sound",
                            Title = "Waterloo"
                        });
                });

            modelBuilder.Entity("BandAPI.Entities.Band", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Founded")
                        .HasColumnType("datetime2");

                    b.Property<string>("MainGenre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Bands");

                    b.HasData(
                        new
                        {
                            Id = new Guid("379dfaa6-a6ec-47ca-ac35-ecd49d9dc3c4"),
                            Founded = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MainGenre = "Rock",
                            Name = "Metallic"
                        },
                        new
                        {
                            Id = new Guid("4323e0b5-58b4-4e9e-9eff-f35aad529f25"),
                            Founded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1970),
                            MainGenre = "Afrobeat",
                            Name = "Fela Kuti & Africa 70"
                        },
                        new
                        {
                            Id = new Guid("f17ebd4a-dd77-46fd-95dc-202727da4e64"),
                            Founded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018),
                            MainGenre = "Highlife",
                            Name = "The Cavemen"
                        },
                        new
                        {
                            Id = new Guid("9f7522ec-4eec-45e1-8e2e-8887c69933d1"),
                            Founded = new DateTime(1981, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MainGenre = "Pop",
                            Name = "A-ha"
                        },
                        new
                        {
                            Id = new Guid("a8be796f-f2fc-4e1f-a36b-08f60cddc22f"),
                            Founded = new DateTime(1991, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MainGenre = "Alternative",
                            Name = "Oasis"
                        },
                        new
                        {
                            Id = new Guid("873a1ffd-d60f-46bb-ae64-b5a642b0eae2"),
                            Founded = new DateTime(1985, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MainGenre = "Rock",
                            Name = "Guns N Roses"
                        });
                });

            modelBuilder.Entity("BandAPI.Entities.Album", b =>
                {
                    b.HasOne("BandAPI.Entities.Band", "Band")
                        .WithMany("Albums")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");
                });

            modelBuilder.Entity("BandAPI.Entities.Band", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}