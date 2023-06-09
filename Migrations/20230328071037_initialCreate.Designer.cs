﻿// <auto-generated />
using System;
using ConsoleAppEFTutorial.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleAppEFTutorial.Migrations
{
    [DbContext(typeof(BoekContext))]
    [Migration("20230328071037_initialCreate")]
    partial class initialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsoleAppEFTutorial.Model.Auteur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BoekId")
                        .HasColumnType("int");

                    b.Property<string>("EmailContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BoekId");

                    b.ToTable("Auteurs");
                });

            modelBuilder.Entity("ConsoleAppEFTutorial.Model.Boek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UitgeverijId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UitgeverijId");

                    b.ToTable("Boeken");
                });

            modelBuilder.Entity("ConsoleAppEFTutorial.Model.Uitgeverij", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Uitgeverijen");
                });

            modelBuilder.Entity("ConsoleAppEFTutorial.Model.Auteur", b =>
                {
                    b.HasOne("ConsoleAppEFTutorial.Model.Boek", null)
                        .WithMany("Auteurs")
                        .HasForeignKey("BoekId");
                });

            modelBuilder.Entity("ConsoleAppEFTutorial.Model.Boek", b =>
                {
                    b.HasOne("ConsoleAppEFTutorial.Model.Uitgeverij", "Uitgeverij")
                        .WithMany()
                        .HasForeignKey("UitgeverijId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Uitgeverij");
                });

            modelBuilder.Entity("ConsoleAppEFTutorial.Model.Boek", b =>
                {
                    b.Navigation("Auteurs");
                });
#pragma warning restore 612, 618
        }
    }
}
