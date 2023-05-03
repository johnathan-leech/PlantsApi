﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlantsApi.Data;

#nullable disable

namespace PlantsApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230503004813_AddZoneTable")]
    partial class AddZoneTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlantsApi.Models.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AltName1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AltName2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AltName3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BinomialNomenclature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Variant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("PlantsApi.Models.Zone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlantId")
                        .HasColumnType("int");

                    b.Property<int>("ZoneMax")
                        .HasColumnType("int");

                    b.Property<int>("ZoneMin")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlantId");

                    b.ToTable("Zones");
                });

            modelBuilder.Entity("PlantsApi.Models.Zone", b =>
                {
                    b.HasOne("PlantsApi.Models.Plant", null)
                        .WithMany("Zones")
                        .HasForeignKey("PlantId");
                });

            modelBuilder.Entity("PlantsApi.Models.Plant", b =>
                {
                    b.Navigation("Zones");
                });
#pragma warning restore 612, 618
        }
    }
}
