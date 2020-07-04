using Microsoft.EntityFrameworkCore.Migrations;

namespace Carpool.WebAPI.Migrations
{
    public partial class izmjenaKorisnikVozacObavijest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obavijesti_Vozaci_VozacID",
                table: "Obavijesti");

            migrationBuilder.DropIndex(
                name: "IX_Obavijesti_VozacID",
                table: "Obavijesti");

            migrationBuilder.DropColumn(
                name: "VozacID",
                table: "Obavijesti");

            migrationBuilder.AddColumn<int>(
                name: "KorisnikID",
                table: "Obavijesti",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Obavijesti_KorisnikID",
                table: "Obavijesti",
                column: "KorisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Obavijesti_Korisnici_KorisnikID",
                table: "Obavijesti",
                column: "KorisnikID",
                principalTable: "Korisnici",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obavijesti_Korisnici_KorisnikID",
                table: "Obavijesti");

            migrationBuilder.DropIndex(
                name: "IX_Obavijesti_KorisnikID",
                table: "Obavijesti");

            migrationBuilder.DropColumn(
                name: "KorisnikID",
                table: "Obavijesti");

            migrationBuilder.AddColumn<int>(
                name: "VozacID",
                table: "Obavijesti",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Obavijesti_VozacID",
                table: "Obavijesti",
                column: "VozacID");

            migrationBuilder.AddForeignKey(
                name: "FK_Obavijesti_Vozaci_VozacID",
                table: "Obavijesti",
                column: "VozacID",
                principalTable: "Vozaci",
                principalColumn: "VozacID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
