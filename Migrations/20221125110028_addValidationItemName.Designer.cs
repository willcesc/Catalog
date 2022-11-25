﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Catalog.Repositories;

namespace Catalog.Migrations
{
    [DbContext(typeof(MySQLDbContext))]
    [Migration("20221125110028_addValidationItemName")]
    partial class addValidationItemName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Catalog.Entities.Item", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("createdDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("id");

                    b.ToTable("items");
                });
#pragma warning restore 612, 618
        }
    }
}