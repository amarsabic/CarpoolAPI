using Microsoft.EntityFrameworkCore.Migrations;

namespace Carpool.WebAPI.Migrations
{
    public partial class ocjenaInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "TipOcjene");

            migrationBuilder.AddColumn<int>(
                name: "Ocjena",
                table: "TipOcjene",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ocjena",
                table: "TipOcjene");

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "TipOcjene",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
