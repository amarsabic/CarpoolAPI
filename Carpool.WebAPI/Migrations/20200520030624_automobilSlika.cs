using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Carpool.WebAPI.Migrations
{
    public partial class automobilSlika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SlikaPath",
                table: "Autmobili");

            migrationBuilder.AddColumn<byte[]>(
                name: "Slika",
                table: "Autmobili",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "SlikaThumb",
                table: "Autmobili",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Autmobili");

            migrationBuilder.DropColumn(
                name: "SlikaThumb",
                table: "Autmobili");

            migrationBuilder.AddColumn<string>(
                name: "SlikaPath",
                table: "Autmobili",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
