﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleMVC.Data;

#nullable disable

namespace SimpleMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SimpleMVC.Models.Dostep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataLogowania")
                        .HasColumnType("datetime2");

                    b.Property<string>("Haslo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dostepy");
                });

            modelBuilder.Entity("SimpleMVC.Models.Gotowka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Wartosc")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Gotowki");
                });

            modelBuilder.Entity("SimpleMVC.Models.Jedzenie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Jedzenie");
                });

            modelBuilder.Entity("SimpleMVC.Models.KamienieMetale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Wartosc")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("KamienieMetale");
                });

            modelBuilder.Entity("SimpleMVC.Models.Kategorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdJedzenie")
                        .HasColumnType("int");

                    b.Property<int>("IdNieoczekiwane")
                        .HasColumnType("int");

                    b.Property<int>("IdRozrywka")
                        .HasColumnType("int");

                    b.Property<int>("IdUbrania")
                        .HasColumnType("int");

                    b.Property<int>("IdUzywki")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdJedzenie");

                    b.HasIndex("IdNieoczekiwane");

                    b.HasIndex("IdRozrywka");

                    b.HasIndex("IdUbrania");

                    b.HasIndex("IdUzywki");

                    b.ToTable("Kategorie");
                });

            modelBuilder.Entity("SimpleMVC.Models.Majatek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGotowka")
                        .HasColumnType("int");

                    b.Property<int>("IdKamienieMetale")
                        .HasColumnType("int");

                    b.Property<int>("IdNieruchomosc")
                        .HasColumnType("int");

                    b.Property<int>("IdPapieryWartosciowe")
                        .HasColumnType("int");

                    b.Property<int>("IdRuchomosc")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdGotowka");

                    b.HasIndex("IdKamienieMetale");

                    b.HasIndex("IdNieruchomosc");

                    b.HasIndex("IdPapieryWartosciowe");

                    b.ToTable("Majatki");
                });

            modelBuilder.Entity("SimpleMVC.Models.Nieoczekiwane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nieoczekiwane");
                });

            modelBuilder.Entity("SimpleMVC.Models.Nieruchomosc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Powierzchnia")
                        .HasColumnType("float");

                    b.Property<decimal>("Wartosc")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Nieruchomosci");
                });

            modelBuilder.Entity("SimpleMVC.Models.Osoba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDodaniaOsoby")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDostepu")
                        .HasColumnType("int");

                    b.Property<int>("IdMajatek")
                        .HasColumnType("int");

                    b.Property<int>("IdOszczednosciStal")
                        .HasColumnType("int");

                    b.Property<int>("IdOszczednosciStale")
                        .HasColumnType("int");

                    b.Property<int>("IdOszczednosciZmienne")
                        .HasColumnType("int");

                    b.Property<int>("IdPrzychodStaly")
                        .HasColumnType("int");

                    b.Property<int>("IdPrzychodZmienn")
                        .HasColumnType("int");

                    b.Property<int>("IdPrzychodZmienny")
                        .HasColumnType("int");

                    b.Property<int>("IdPrzychudStaly")
                        .HasColumnType("int");

                    b.Property<int>("IdWydatekStal")
                        .HasColumnType("int");

                    b.Property<int>("IdWydatekStaly")
                        .HasColumnType("int");

                    b.Property<int>("IdWydatekZmienny")
                        .HasColumnType("int");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wiek")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdDostepu");

                    b.HasIndex("IdMajatek");

                    b.HasIndex("IdOszczednosciStale");

                    b.HasIndex("IdOszczednosciZmienne");

                    b.HasIndex("IdPrzychodStaly");

                    b.HasIndex("IdPrzychodZmienny");

                    b.HasIndex("IdWydatekStaly");

                    b.HasIndex("IdWydatekZmienny");

                    b.ToTable("Osoby");
                });

            modelBuilder.Entity("SimpleMVC.Models.OszczednosciStale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aktualizacja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Wartosc")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("OszczednosciStale");
                });

            modelBuilder.Entity("SimpleMVC.Models.OszczednosciZmienne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Wartosc")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("OszczednosciZmienne");
                });

            modelBuilder.Entity("SimpleMVC.Models.PapieryWartosciowe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Wartosc")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("PapieryWartosciowe");
                });

            modelBuilder.Entity("SimpleMVC.Models.PrzychodStaly", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aktualizacja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Wartosc")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("PrzychodyStale");
                });

            modelBuilder.Entity("SimpleMVC.Models.PrzychodZmienny", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Wartosc")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("PrzychodyZmienne");
                });

            modelBuilder.Entity("SimpleMVC.Models.Rozrywka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rozrywka");
                });

            modelBuilder.Entity("SimpleMVC.Models.Ruchomosc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Wartosc")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Ruchomosci");
                });

            modelBuilder.Entity("SimpleMVC.Models.Ubrania", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ubrania");
                });

            modelBuilder.Entity("SimpleMVC.Models.Uzywki", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Uzywki");
                });

            modelBuilder.Entity("SimpleMVC.Models.WydatekStaly", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aktualizacja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Wartosc")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("WydatkiStale");
                });

            modelBuilder.Entity("SimpleMVC.Models.WydatekZmienny", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDostepu")
                        .HasColumnType("int");

                    b.Property<int>("IdKategoria")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Wartosc")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("WydatkiZmienne");
                });

            modelBuilder.Entity("SimpleMVC.Models.Kategorie", b =>
                {
                    b.HasOne("SimpleMVC.Models.Jedzenie", "Jedzenie")
                        .WithMany()
                        .HasForeignKey("IdJedzenie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleMVC.Models.Nieoczekiwane", "Nieoczekiwane")
                        .WithMany()
                        .HasForeignKey("IdNieoczekiwane")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleMVC.Models.Rozrywka", "Rozrywka")
                        .WithMany()
                        .HasForeignKey("IdRozrywka")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleMVC.Models.Ubrania", "Ubrania")
                        .WithMany()
                        .HasForeignKey("IdUbrania")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleMVC.Models.Uzywki", "Uzywki")
                        .WithMany()
                        .HasForeignKey("IdUzywki")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jedzenie");

                    b.Navigation("Nieoczekiwane");

                    b.Navigation("Rozrywka");

                    b.Navigation("Ubrania");

                    b.Navigation("Uzywki");
                });

            modelBuilder.Entity("SimpleMVC.Models.Majatek", b =>
                {
                    b.HasOne("SimpleMVC.Models.Gotowka", "Gotowka")
                        .WithMany()
                        .HasForeignKey("IdGotowka")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleMVC.Models.KamienieMetale", "KamienieMetale")
                        .WithMany()
                        .HasForeignKey("IdKamienieMetale")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleMVC.Models.Nieruchomosc", "Nieruchomosc")
                        .WithMany()
                        .HasForeignKey("IdNieruchomosc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleMVC.Models.Ruchomosc", "Ruchomosc")
                        .WithMany()
                        .HasForeignKey("IdNieruchomosc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleMVC.Models.PapieryWartosciowe", "PapieryWartosciowe")
                        .WithMany()
                        .HasForeignKey("IdPapieryWartosciowe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gotowka");

                    b.Navigation("KamienieMetale");

                    b.Navigation("Nieruchomosc");

                    b.Navigation("PapieryWartosciowe");

                    b.Navigation("Ruchomosc");
                });

            modelBuilder.Entity("SimpleMVC.Models.Osoba", b =>
                {
                    b.HasOne("SimpleMVC.Models.Dostep", "Dostep")
                        .WithMany()
                        .HasForeignKey("IdDostepu")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SimpleMVC.Models.Majatek", "Majatek")
                        .WithMany()
                        .HasForeignKey("IdMajatek")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SimpleMVC.Models.OszczednosciStale", "OszczednosciStale")
                        .WithMany()
                        .HasForeignKey("IdOszczednosciStale")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SimpleMVC.Models.OszczednosciZmienne", "OszczednosciZmienne")
                        .WithMany()
                        .HasForeignKey("IdOszczednosciZmienne")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SimpleMVC.Models.PrzychodStaly", "PrzychodStaly")
                        .WithMany()
                        .HasForeignKey("IdPrzychodStaly")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SimpleMVC.Models.PrzychodZmienny", "PrzychodZmienny")
                        .WithMany()
                        .HasForeignKey("IdPrzychodZmienny")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SimpleMVC.Models.WydatekStaly", "WydatekStaly")
                        .WithMany()
                        .HasForeignKey("IdWydatekStaly")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SimpleMVC.Models.WydatekZmienny", "WydatekZienny")
                        .WithMany()
                        .HasForeignKey("IdWydatekZmienny")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Dostep");

                    b.Navigation("Majatek");

                    b.Navigation("OszczednosciStale");

                    b.Navigation("OszczednosciZmienne");

                    b.Navigation("PrzychodStaly");

                    b.Navigation("PrzychodZmienny");

                    b.Navigation("WydatekStaly");

                    b.Navigation("WydatekZienny");
                });
#pragma warning restore 612, 618
        }
    }
}
