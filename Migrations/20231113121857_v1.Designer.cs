﻿// <auto-generated />
using GoldNotification.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GoldNotification.Migrations
{
    [DbContext(typeof(GoldContext))]
    [Migration("20231113121857_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GoldNotification.Models.Gold", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10)");

                    b.Property<string>("Standard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Golds");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 2200m,
                            Standard = "24"
                        },
                        new
                        {
                            Id = 2,
                            Price = 1500m,
                            Standard = "21"
                        },
                        new
                        {
                            Id = 3,
                            Price = 990m,
                            Standard = "18"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}