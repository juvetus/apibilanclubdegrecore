﻿// <auto-generated />
using ApiBilanClubDegre.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiBilanClubDegre.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221230151809_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiBilanClubDegre.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question10")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question11")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question12")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question13")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question14")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question15")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question16")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question17")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question18")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question19")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question20")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question21")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question22")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question23")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question24")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question25")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question26")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question27")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question28")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question29")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question30")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question7")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question8")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question9")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
