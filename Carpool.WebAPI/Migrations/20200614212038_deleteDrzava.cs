using Microsoft.EntityFrameworkCore.Migrations;

namespace Carpool.WebAPI.Migrations
{
    public partial class deleteDrzava : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gradovi_Drzave_DrzavaID",
                table: "Gradovi");

            migrationBuilder.DropTable(
                name: "Drzave");

            migrationBuilder.DropIndex(
                name: "IX_Gradovi_DrzavaID",
                table: "Gradovi");

            migrationBuilder.DropColumn(
                name: "DrzavaID",
                table: "Gradovi");

            migrationBuilder.DropColumn(
                name: "PostanskiBroj",
                table: "Gradovi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DrzavaID",
                table: "Gradovi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PostanskiBroj",
                table: "Gradovi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skracenica = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.DrzavaID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_DrzavaID",
                table: "Gradovi",
                column: "DrzavaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Gradovi_Drzave_DrzavaID",
                table: "Gradovi",
                column: "DrzavaID",
                principalTable: "Drzave",
                principalColumn: "DrzavaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
