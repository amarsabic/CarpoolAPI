using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Carpool.WebAPI.Migrations
{
    public partial class backToDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "VrijemePolaska",
                table: "Voznje",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "VrijemePolaska",
                table: "Voznje",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
