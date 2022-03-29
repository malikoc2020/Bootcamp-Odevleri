﻿// <auto-generated />
using System;
using First.App.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Homework04_First.App.DataAccess.EntityFramework.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220326102822_SeedAddedToCompanyTable")]
    partial class SeedAddedToCompanyTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("First.App.Domain.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Kocaeli/İzmit",
                            City = "Kocaeli",
                            Country = "Türkiye",
                            CreatedAt = new DateTime(2022, 3, 26, 13, 28, 21, 531, DateTimeKind.Local).AddTicks(639),
                            CreatedBy = "System",
                            Description = "Location bilgisi Güldür güldür Adana adliyesi skeçinden alınmıştır.",
                            IsDeleted = false,
                            Location = "Çarşı caddesi no:36, Camiyi geçince; dükkanın altıııı :)",
                            Name = "Tercanlar",
                            Phone = "0555 555 55 55"
                        },
                        new
                        {
                            Id = 2,
                            Address = "İstanbul/Beşiktaş",
                            City = "Kocaeli",
                            Country = "Türkiye",
                            CreatedAt = new DateTime(2022, 3, 26, 13, 28, 21, 532, DateTimeKind.Local).AddTicks(5773),
                            CreatedBy = "System",
                            Description = "Location bilgisi Güldür güldür Adana adliyesi skeçinden alınmıştır.",
                            IsDeleted = false,
                            Location = "Çarşı caddesi no:36, Camiyi geçince; dükkanın altıııı :) 2",
                            Name = "Tercanlar 2",
                            Phone = "0553 333 33 33"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}