using Microsoft.EntityFrameworkCore.Migrations;

namespace Carpool.WebAPI.Migrations
{
    public partial class korisniciLozinkaHash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KratkaBiografija",
                table: "Korisnici");

            migrationBuilder.AddColumn<string>(
                name: "KorisnickoIme",
                table: "Korisnici",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LozinkaHash",
                table: "Korisnici",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LozinkaSalt",
                table: "Korisnici",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KorisnickoIme",
                table: "Korisnici");

            migrationBuilder.DropColumn(
                name: "LozinkaHash",
                table: "Korisnici");

            migrationBuilder.DropColumn(
                name: "LozinkaSalt",
                table: "Korisnici");

            migrationBuilder.AddColumn<string>(
                name: "KratkaBiografija",
                table: "Korisnici",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
