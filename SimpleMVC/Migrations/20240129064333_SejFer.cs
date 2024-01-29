using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleMVC.Migrations
{
    /// <inheritdoc />
    public partial class SejFer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dostepy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Haslo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataLogowania = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dostepy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gotowki",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wartosc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gotowki", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jedzenie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jedzenie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KamienieMetale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wartosc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KamienieMetale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nieoczekiwane",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nieoczekiwane", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nieruchomosci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Powierzchnia = table.Column<double>(type: "float", nullable: false),
                    Wartosc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nieruchomosci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OszczednosciStale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wartosc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Aktualizacja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OszczednosciStale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OszczednosciZmienne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wartosc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OszczednosciZmienne", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PapieryWartosciowe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wartosc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PapieryWartosciowe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrzychodyStale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wartosc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Aktualizacja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrzychodyStale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrzychodyZmienne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wartosc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrzychodyZmienne", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rozrywka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rozrywka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ruchomosci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wartosc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruchomosci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ubrania",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubrania", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uzywki",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzywki", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WydatkiStale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wartosc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Aktualizacja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WydatkiStale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WydatkiZmienne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDostepu = table.Column<int>(type: "int", nullable: false),
                    IdKategoria = table.Column<int>(type: "int", nullable: false),
                    Wartosc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WydatkiZmienne", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Majatki",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdNieruchomosc = table.Column<int>(type: "int", nullable: false),
                    IdRuchomosc = table.Column<int>(type: "int", nullable: false),
                    IdKamienieMetale = table.Column<int>(type: "int", nullable: false),
                    IdPapieryWartosciowe = table.Column<int>(type: "int", nullable: false),
                    IdGotowka = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majatki", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Majatki_Gotowki_IdGotowka",
                        column: x => x.IdGotowka,
                        principalTable: "Gotowki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Majatki_KamienieMetale_IdKamienieMetale",
                        column: x => x.IdKamienieMetale,
                        principalTable: "KamienieMetale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Majatki_Nieruchomosci_IdNieruchomosc",
                        column: x => x.IdNieruchomosc,
                        principalTable: "Nieruchomosci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Majatki_PapieryWartosciowe_IdPapieryWartosciowe",
                        column: x => x.IdPapieryWartosciowe,
                        principalTable: "PapieryWartosciowe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Majatki_Ruchomosci_IdNieruchomosc",
                        column: x => x.IdNieruchomosc,
                        principalTable: "Ruchomosci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdJedzenie = table.Column<int>(type: "int", nullable: false),
                    IdUzywki = table.Column<int>(type: "int", nullable: false),
                    IdRozrywka = table.Column<int>(type: "int", nullable: false),
                    IdNieoczekiwane = table.Column<int>(type: "int", nullable: false),
                    IdUbrania = table.Column<int>(type: "int", nullable: false),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kategorie_Jedzenie_IdJedzenie",
                        column: x => x.IdJedzenie,
                        principalTable: "Jedzenie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kategorie_Nieoczekiwane_IdNieoczekiwane",
                        column: x => x.IdNieoczekiwane,
                        principalTable: "Nieoczekiwane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kategorie_Rozrywka_IdRozrywka",
                        column: x => x.IdRozrywka,
                        principalTable: "Rozrywka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kategorie_Ubrania_IdUbrania",
                        column: x => x.IdUbrania,
                        principalTable: "Ubrania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kategorie_Uzywki_IdUzywki",
                        column: x => x.IdUzywki,
                        principalTable: "Uzywki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Osoby",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDostepu = table.Column<int>(type: "int", nullable: false),
                    IdMajatek = table.Column<int>(type: "int", nullable: false),
                    IdPrzychodStaly = table.Column<int>(type: "int", nullable: false),
                    IdPrzychodZmienny = table.Column<int>(type: "int", nullable: false),
                    IdOszczednosciStale = table.Column<int>(type: "int", nullable: false),
                    IdOszczednosciZmienne = table.Column<int>(type: "int", nullable: false),
                    IdWydatekStaly = table.Column<int>(type: "int", nullable: false),
                    IdWydatekZmienny = table.Column<int>(type: "int", nullable: false),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wiek = table.Column<int>(type: "int", nullable: false),
                    DataDodaniaOsoby = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdOszczednosciStal = table.Column<int>(type: "int", nullable: false),
                    IdPrzychodZmienn = table.Column<int>(type: "int", nullable: false),
                    IdPrzychudStaly = table.Column<int>(type: "int", nullable: false),
                    IdWydatekStal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoby", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Osoby_Dostepy_IdDostepu",
                        column: x => x.IdDostepu,
                        principalTable: "Dostepy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Osoby_Majatki_IdMajatek",
                        column: x => x.IdMajatek,
                        principalTable: "Majatki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Osoby_OszczednosciStale_IdOszczednosciStale",
                        column: x => x.IdOszczednosciStale,
                        principalTable: "OszczednosciStale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Osoby_OszczednosciZmienne_IdOszczednosciZmienne",
                        column: x => x.IdOszczednosciZmienne,
                        principalTable: "OszczednosciZmienne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Osoby_PrzychodyStale_IdPrzychodStaly",
                        column: x => x.IdPrzychodStaly,
                        principalTable: "PrzychodyStale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Osoby_PrzychodyZmienne_IdPrzychodZmienny",
                        column: x => x.IdPrzychodZmienny,
                        principalTable: "PrzychodyZmienne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Osoby_WydatkiStale_IdWydatekStaly",
                        column: x => x.IdWydatekStaly,
                        principalTable: "WydatkiStale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Osoby_WydatkiZmienne_IdWydatekZmienny",
                        column: x => x.IdWydatekZmienny,
                        principalTable: "WydatkiZmienne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kategorie_IdJedzenie",
                table: "Kategorie",
                column: "IdJedzenie");

            migrationBuilder.CreateIndex(
                name: "IX_Kategorie_IdNieoczekiwane",
                table: "Kategorie",
                column: "IdNieoczekiwane");

            migrationBuilder.CreateIndex(
                name: "IX_Kategorie_IdRozrywka",
                table: "Kategorie",
                column: "IdRozrywka");

            migrationBuilder.CreateIndex(
                name: "IX_Kategorie_IdUbrania",
                table: "Kategorie",
                column: "IdUbrania");

            migrationBuilder.CreateIndex(
                name: "IX_Kategorie_IdUzywki",
                table: "Kategorie",
                column: "IdUzywki");

            migrationBuilder.CreateIndex(
                name: "IX_Majatki_IdGotowka",
                table: "Majatki",
                column: "IdGotowka");

            migrationBuilder.CreateIndex(
                name: "IX_Majatki_IdKamienieMetale",
                table: "Majatki",
                column: "IdKamienieMetale");

            migrationBuilder.CreateIndex(
                name: "IX_Majatki_IdNieruchomosc",
                table: "Majatki",
                column: "IdNieruchomosc");

            migrationBuilder.CreateIndex(
                name: "IX_Majatki_IdPapieryWartosciowe",
                table: "Majatki",
                column: "IdPapieryWartosciowe");

            migrationBuilder.CreateIndex(
                name: "IX_Osoby_IdDostepu",
                table: "Osoby",
                column: "IdDostepu");

            migrationBuilder.CreateIndex(
                name: "IX_Osoby_IdMajatek",
                table: "Osoby",
                column: "IdMajatek");

            migrationBuilder.CreateIndex(
                name: "IX_Osoby_IdOszczednosciStale",
                table: "Osoby",
                column: "IdOszczednosciStale");

            migrationBuilder.CreateIndex(
                name: "IX_Osoby_IdOszczednosciZmienne",
                table: "Osoby",
                column: "IdOszczednosciZmienne");

            migrationBuilder.CreateIndex(
                name: "IX_Osoby_IdPrzychodStaly",
                table: "Osoby",
                column: "IdPrzychodStaly");

            migrationBuilder.CreateIndex(
                name: "IX_Osoby_IdPrzychodZmienny",
                table: "Osoby",
                column: "IdPrzychodZmienny");

            migrationBuilder.CreateIndex(
                name: "IX_Osoby_IdWydatekStaly",
                table: "Osoby",
                column: "IdWydatekStaly");

            migrationBuilder.CreateIndex(
                name: "IX_Osoby_IdWydatekZmienny",
                table: "Osoby",
                column: "IdWydatekZmienny");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kategorie");

            migrationBuilder.DropTable(
                name: "Osoby");

            migrationBuilder.DropTable(
                name: "Jedzenie");

            migrationBuilder.DropTable(
                name: "Nieoczekiwane");

            migrationBuilder.DropTable(
                name: "Rozrywka");

            migrationBuilder.DropTable(
                name: "Ubrania");

            migrationBuilder.DropTable(
                name: "Uzywki");

            migrationBuilder.DropTable(
                name: "Dostepy");

            migrationBuilder.DropTable(
                name: "Majatki");

            migrationBuilder.DropTable(
                name: "OszczednosciStale");

            migrationBuilder.DropTable(
                name: "OszczednosciZmienne");

            migrationBuilder.DropTable(
                name: "PrzychodyStale");

            migrationBuilder.DropTable(
                name: "PrzychodyZmienne");

            migrationBuilder.DropTable(
                name: "WydatkiStale");

            migrationBuilder.DropTable(
                name: "WydatkiZmienne");

            migrationBuilder.DropTable(
                name: "Gotowki");

            migrationBuilder.DropTable(
                name: "KamienieMetale");

            migrationBuilder.DropTable(
                name: "Nieruchomosci");

            migrationBuilder.DropTable(
                name: "PapieryWartosciowe");

            migrationBuilder.DropTable(
                name: "Ruchomosci");
        }
    }
}
