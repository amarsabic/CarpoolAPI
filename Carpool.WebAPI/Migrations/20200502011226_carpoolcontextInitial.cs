using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Carpool.WebAPI.Migrations
{
    public partial class carpoolcontextInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Skracenica = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "Muzika",
                columns: table => new
                {
                    MuzikaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zanr = table.Column<string>(nullable: true),
                    KratkiOpis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muzika", x => x.MuzikaID);
                });

            migrationBuilder.CreateTable(
                name: "TipObavijesti",
                columns: table => new
                {
                    TipObavijestiID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivTipa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipObavijesti", x => x.TipObavijestiID);
                });

            migrationBuilder.CreateTable(
                name: "TipOcjene",
                columns: table => new
                {
                    TipOcjeneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipOcjene", x => x.TipOcjeneID);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    GradID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    PostanskiBroj = table.Column<string>(nullable: true),
                    DrzavaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.GradID);
                    table.ForeignKey(
                        name: "FK_Gradovi_Drzave_DrzavaID",
                        column: x => x.DrzavaID,
                        principalTable: "Drzave",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Preferencije",
                columns: table => new
                {
                    PreferencijeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dozvoljeno_pusenje = table.Column<bool>(nullable: false),
                    Dozvoljene_zivotinje = table.Column<bool>(nullable: false),
                    MuzikaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferencije", x => x.PreferencijeID);
                    table.ForeignKey(
                        name: "FK_Preferencije_Muzika_MuzikaID",
                        column: x => x.MuzikaID,
                        principalTable: "Muzika",
                        principalColumn: "MuzikaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    BrojTelefona = table.Column<string>(nullable: true),
                    KratkaBiografija = table.Column<string>(nullable: true),
                    Spol = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    Adresa = table.Column<string>(nullable: true),
                    GradID = table.Column<int>(nullable: false),
                    PreferencijeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "FK_Korisnici_Gradovi_GradID",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Korisnici_Preferencije_PreferencijeID",
                        column: x => x.PreferencijeID,
                        principalTable: "Preferencije",
                        principalColumn: "PreferencijeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vozaci",
                columns: table => new
                {
                    VozacID = table.Column<int>(nullable: false),
                    BrVozackeDozvole = table.Column<string>(nullable: true),
                    DatumIstekaVozackeDozvole = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozaci", x => x.VozacID);
                    table.ForeignKey(
                        name: "FK_Vozaci_Korisnici_VozacID",
                        column: x => x.VozacID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Autmobili",
                columns: table => new
                {
                    AutomobilID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VozacID = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Godiste = table.Column<string>(nullable: true),
                    BrojRegOznaka = table.Column<string>(nullable: true),
                    DatumIstekaRegistracije = table.Column<DateTime>(nullable: false),
                    SlikaPath = table.Column<string>(nullable: true),
                    IsAktivan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autmobili", x => x.AutomobilID);
                    table.ForeignKey(
                        name: "FK_Autmobili_Vozaci_VozacID",
                        column: x => x.VozacID,
                        principalTable: "Vozaci",
                        principalColumn: "VozacID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Obavijesti",
                columns: table => new
                {
                    ObavijestiID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KratkiOpis = table.Column<string>(nullable: true),
                    Naslov = table.Column<string>(nullable: true),
                    DatumVrijemeObjave = table.Column<DateTime>(nullable: false),
                    TipObavijestiID = table.Column<int>(nullable: false),
                    Vaznost = table.Column<bool>(nullable: false),
                    VozacID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijesti", x => x.ObavijestiID);
                    table.ForeignKey(
                        name: "FK_Obavijesti_TipObavijesti_TipObavijestiID",
                        column: x => x.TipObavijestiID,
                        principalTable: "TipObavijesti",
                        principalColumn: "TipObavijestiID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Obavijesti_Vozaci_VozacID",
                        column: x => x.VozacID,
                        principalTable: "Vozaci",
                        principalColumn: "VozacID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voznje",
                columns: table => new
                {
                    VoznjaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumPolaska = table.Column<DateTime>(nullable: false),
                    VrijemePolaska = table.Column<DateTime>(nullable: false),
                    DatumObjave = table.Column<DateTime>(nullable: false),
                    SlobodnaMjesta = table.Column<int>(nullable: false),
                    PunaCijena = table.Column<decimal>(nullable: false),
                    IsAktivna = table.Column<bool>(nullable: false),
                    VozacID = table.Column<int>(nullable: false),
                    AutomobilID = table.Column<int>(nullable: false),
                    GradPolaskaID = table.Column<int>(nullable: false),
                    GradDestinacijaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voznje", x => x.VoznjaID);
                    table.ForeignKey(
                        name: "FK_Voznje_Autmobili_AutomobilID",
                        column: x => x.AutomobilID,
                        principalTable: "Autmobili",
                        principalColumn: "AutomobilID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voznje_Gradovi_GradDestinacijaID",
                        column: x => x.GradDestinacijaID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Voznje_Gradovi_GradPolaskaID",
                        column: x => x.GradPolaskaID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Voznje_Vozaci_VozacID",
                        column: x => x.VozacID,
                        principalTable: "Vozaci",
                        principalColumn: "VozacID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    OcjeneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Komentar = table.Column<string>(nullable: true),
                    TipOcjeneID = table.Column<int>(nullable: false),
                    KorisnikID = table.Column<int>(nullable: false),
                    VoznjaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjene", x => x.OcjeneID);
                    table.ForeignKey(
                        name: "FK_Ocjene_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ocjene_TipOcjene_TipOcjeneID",
                        column: x => x.TipOcjeneID,
                        principalTable: "TipOcjene",
                        principalColumn: "TipOcjeneID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ocjene_Voznje_VoznjaID",
                        column: x => x.VoznjaID,
                        principalTable: "Voznje",
                        principalColumn: "VoznjaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UsputniGradovi",
                columns: table => new
                {
                    UsputniGradoviID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CijenaUsputni = table.Column<decimal>(nullable: false),
                    VoznjaID = table.Column<int>(nullable: false),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsputniGradovi", x => x.UsputniGradoviID);
                    table.ForeignKey(
                        name: "FK_UsputniGradovi_Gradovi_GradID",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsputniGradovi_Voznje_VoznjaID",
                        column: x => x.VoznjaID,
                        principalTable: "Voznje",
                        principalColumn: "VoznjaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacije",
                columns: table => new
                {
                    RezervacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumRezervacije = table.Column<DateTime>(nullable: false),
                    VoznjaID = table.Column<int>(nullable: false),
                    KorisnikID = table.Column<int>(nullable: false),
                    UsputniGradId = table.Column<int>(nullable: true),
                    OpisPrtljaga = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacije", x => x.RezervacijaID);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervacije_UsputniGradovi_UsputniGradId",
                        column: x => x.UsputniGradId,
                        principalTable: "UsputniGradovi",
                        principalColumn: "UsputniGradoviID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Voznje_VoznjaID",
                        column: x => x.VoznjaID,
                        principalTable: "Voznje",
                        principalColumn: "VoznjaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autmobili_VozacID",
                table: "Autmobili",
                column: "VozacID");

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_DrzavaID",
                table: "Gradovi",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_GradID",
                table: "Korisnici",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_PreferencijeID",
                table: "Korisnici",
                column: "PreferencijeID");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijesti_TipObavijestiID",
                table: "Obavijesti",
                column: "TipObavijestiID");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijesti_VozacID",
                table: "Obavijesti",
                column: "VozacID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_KorisnikID",
                table: "Ocjene",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_TipOcjeneID",
                table: "Ocjene",
                column: "TipOcjeneID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_VoznjaID",
                table: "Ocjene",
                column: "VoznjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Preferencije_MuzikaID",
                table: "Preferencije",
                column: "MuzikaID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_KorisnikID",
                table: "Rezervacije",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_UsputniGradId",
                table: "Rezervacije",
                column: "UsputniGradId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_VoznjaID",
                table: "Rezervacije",
                column: "VoznjaID");

            migrationBuilder.CreateIndex(
                name: "IX_UsputniGradovi_GradID",
                table: "UsputniGradovi",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_UsputniGradovi_VoznjaID",
                table: "UsputniGradovi",
                column: "VoznjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_AutomobilID",
                table: "Voznje",
                column: "AutomobilID");

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_GradDestinacijaID",
                table: "Voznje",
                column: "GradDestinacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_GradPolaskaID",
                table: "Voznje",
                column: "GradPolaskaID");

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_VozacID",
                table: "Voznje",
                column: "VozacID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Obavijesti");

            migrationBuilder.DropTable(
                name: "Ocjene");

            migrationBuilder.DropTable(
                name: "Rezervacije");

            migrationBuilder.DropTable(
                name: "TipObavijesti");

            migrationBuilder.DropTable(
                name: "TipOcjene");

            migrationBuilder.DropTable(
                name: "UsputniGradovi");

            migrationBuilder.DropTable(
                name: "Voznje");

            migrationBuilder.DropTable(
                name: "Autmobili");

            migrationBuilder.DropTable(
                name: "Vozaci");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Preferencije");

            migrationBuilder.DropTable(
                name: "Drzave");

            migrationBuilder.DropTable(
                name: "Muzika");
        }
    }
}
