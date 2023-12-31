﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace MotivatonApp.Server.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230830095522_Config")]
    partial class Config
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MotivatonApp.Shared.Models.Motivation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Motivations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Rella",
                            Quote = "Pasta"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Rella2",
                            Quote = "Pasta2"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Rella3",
                            Quote = "Pasta3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
