using Microsoft.EntityFrameworkCore;
using SimpleMVC.Models;

namespace SimpleMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Osoba> Osoby { get; set; }
        public DbSet<Dostep> Dostepy { get; set; }
        public DbSet<Majatek> Majatki { get; set; }
        public DbSet<Nieruchomosc> Nieruchomosci { get; set; }
        public DbSet<Ruchomosc> Ruchomosci { get; set; }
        public DbSet<KamienieMetale> KamienieMetale { get; set; }
        public DbSet<PapieryWartosciowe> PapieryWartosciowe { get; set; }
        public DbSet<Gotowka> Gotowki { get; set; }
        public DbSet<PrzychodStaly> PrzychodyStale { get; set; }
        public DbSet<PrzychodZmienny> PrzychodyZmienne { get; set; }
        public DbSet<OszczednosciStale> OszczednosciStale { get; set; }
        public DbSet<OszczednosciZmienne> OszczednosciZmienne { get; set; }
        public DbSet<WydatekStaly> WydatkiStale { get; set; }
        public DbSet<WydatekZmienny> WydatkiZmienne { get; set; }
        public DbSet<Kategorie> Kategorie { get; set; }
        public DbSet<Jedzenie> Jedzenie { get; set; }
        public DbSet<Uzywki> Uzywki { get; set; }
        public DbSet<Rozrywka> Rozrywka { get; set; }
        public DbSet<Nieoczekiwane> Nieoczekiwane { get; set; }
        public DbSet<Ubrania> Ubrania { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osoba>()
                .HasOne(o => o.Dostep)
                .WithMany()
                .HasForeignKey(o => o.IdDostepu)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Osoba>()
                .HasOne(o => o.Majatek)
                .WithMany()
                .HasForeignKey(o => o.IdMajatek)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Osoba>()
                .HasOne(o => o.PrzychodStaly)
                .WithMany()
                .HasForeignKey(o => o.IdPrzychodStaly)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Osoba>()
                .HasOne(o => o.PrzychodZmienny)
                .WithMany()
                .HasForeignKey(o => o.IdPrzychodZmienny)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Osoba>()
                .HasOne(o => o.OszczednosciStale)
                .WithMany()
                .HasForeignKey(o => o.IdOszczednosciStale)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Osoba>()
                .HasOne(o => o.OszczednosciZmienne)
                .WithMany()
                .HasForeignKey(o => o.IdOszczednosciZmienne)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Osoba>()
                .HasOne(o => o.WydatekStaly)
                .WithMany()
                .HasForeignKey(o => o.IdWydatekStaly)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Osoba>()
                .HasOne(o => o.WydatekZienny)
                .WithMany()
                .HasForeignKey(o => o.IdWydatekZmienny)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
