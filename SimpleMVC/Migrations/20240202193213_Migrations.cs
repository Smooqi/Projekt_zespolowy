using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleMVC.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Majatki_Ruchomosci_IdNieruchomosc",
                table: "Majatki");

            migrationBuilder.DropColumn(
                name: "IdOszczednosciStal",
                table: "Osoby");

            migrationBuilder.DropColumn(
                name: "IdPrzychodZmienn",
                table: "Osoby");

            migrationBuilder.DropColumn(
                name: "IdWydatekStal",
                table: "Osoby");

            migrationBuilder.CreateIndex(
                name: "IX_Majatki_IdRuchomosc",
                table: "Majatki",
                column: "IdRuchomosc");

            migrationBuilder.AddForeignKey(
                name: "FK_Majatki_Ruchomosci_IdRuchomosc",
                table: "Majatki",
                column: "IdRuchomosc",
                principalTable: "Ruchomosci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Majatki_Ruchomosci_IdRuchomosc",
                table: "Majatki");

            migrationBuilder.DropIndex(
                name: "IX_Majatki_IdRuchomosc",
                table: "Majatki");

            migrationBuilder.AddColumn<int>(
                name: "IdOszczednosciStal",
                table: "Osoby",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPrzychodZmienn",
                table: "Osoby",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdWydatekStal",
                table: "Osoby",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Majatki_Ruchomosci_IdNieruchomosc",
                table: "Majatki",
                column: "IdNieruchomosc",
                principalTable: "Ruchomosci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
