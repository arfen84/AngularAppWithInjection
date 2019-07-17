using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Restaurant.Data.Migrations
{
    public partial class AllTablessAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agroturystyczne",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agroturystyczne", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Apartamenty",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    klimatLokalu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartamenty", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CentraEventowe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dodatkoweOczekiwania = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dodatkoweUslugi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iloscStolikow = table.Column<int>(type: "int", nullable: false),
                    klimatLokalu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rodzajKuchni = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentraEventowe", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CentraRekreacji",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentraRekreacji", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DomkiLetniskowe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomkiLetniskowe", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DomyWeselne",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dodatkoweOczekiwania = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dodatkoweUslugi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iloscStolikow = table.Column<int>(type: "int", nullable: false),
                    klimatLokalu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rodzajKuchni = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomyWeselne", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EscapeRoomy",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    klimatLokalu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EscapeRoomy", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hotele",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dodatkoweOczekiwania = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dodatkoweUslugi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iloscStolikow = table.Column<int>(type: "int", nullable: false),
                    klimatLokalu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rodzajKuchni = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotele", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Karczmy",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dodatkoweOczekiwania = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dodatkoweUslugi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iloscStolikow = table.Column<int>(type: "int", nullable: false),
                    klimatLokalu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rodzajKuchni = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karczmy", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kawiarnie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    iloscStolikow = table.Column<int>(type: "int", nullable: false),
                    klimatLokalu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rodzajKawy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kawiarnie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kluby",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dodatkoweOczekiwania = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    klimatLokalu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kluby", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mieszkania",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    klimatLokalu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mieszkania", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Puby",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dodatkoweOczekiwania = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dodatkoweUslugi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iloscStolikow = table.Column<int>(type: "int", nullable: false),
                    klimatLokalu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rodzajKuchni = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puby", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SaleBankietowe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dodatkoweOczekiwania = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dodatkoweUslugi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iloscStolikow = table.Column<int>(type: "int", nullable: false),
                    klimatLokalu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rodzajKuchni = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleBankietowe", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SaleZabaw",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleZabaw", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SciankiWspinaczkowe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SciankiWspinaczkowe", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SPA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budzet = table.Column<int>(type: "int", nullable: false),
                    DodatkoweUwagi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxLiczbaGosci = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OplaconyAbonament = table.Column<bool>(type: "bit", nullable: false),
                    Przyjecia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dodatkoweOczekiwania = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dodatkoweUslugi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    klimatLokalu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rodzajZabiegow = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPA", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agroturystyczne");

            migrationBuilder.DropTable(
                name: "Apartamenty");

            migrationBuilder.DropTable(
                name: "CentraEventowe");

            migrationBuilder.DropTable(
                name: "CentraRekreacji");

            migrationBuilder.DropTable(
                name: "DomkiLetniskowe");

            migrationBuilder.DropTable(
                name: "DomyWeselne");

            migrationBuilder.DropTable(
                name: "EscapeRoomy");

            migrationBuilder.DropTable(
                name: "Hotele");

            migrationBuilder.DropTable(
                name: "Karczmy");

            migrationBuilder.DropTable(
                name: "Kawiarnie");

            migrationBuilder.DropTable(
                name: "Kluby");

            migrationBuilder.DropTable(
                name: "Mieszkania");

            migrationBuilder.DropTable(
                name: "Puby");

            migrationBuilder.DropTable(
                name: "SaleBankietowe");

            migrationBuilder.DropTable(
                name: "SaleZabaw");

            migrationBuilder.DropTable(
                name: "SciankiWspinaczkowe");

            migrationBuilder.DropTable(
                name: "SPA");
        }
    }
}
