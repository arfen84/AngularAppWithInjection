using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Restaurant.Data.Migrations
{
    public partial class RestauracjeDatabaseChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "wnoszenieAlkoholu",
                table: "Restauracje");

            migrationBuilder.AddColumn<int>(
                name: "Budzet",
                table: "Restauracje",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DodatkoweUwagi",
                table: "Restauracje",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Restauracje",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxLiczbaGosci",
                table: "Restauracje",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OplaconyAbonament",
                table: "Restauracje",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Przyjecia",
                table: "Restauracje",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Termin",
                table: "Restauracje",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "dodatkoweOczekiwania",
                table: "Restauracje",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dodatkoweUslugi",
                table: "Restauracje",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Budzet",
                table: "Restauracje");

            migrationBuilder.DropColumn(
                name: "DodatkoweUwagi",
                table: "Restauracje");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Restauracje");

            migrationBuilder.DropColumn(
                name: "MaxLiczbaGosci",
                table: "Restauracje");

            migrationBuilder.DropColumn(
                name: "OplaconyAbonament",
                table: "Restauracje");

            migrationBuilder.DropColumn(
                name: "Przyjecia",
                table: "Restauracje");

            migrationBuilder.DropColumn(
                name: "Termin",
                table: "Restauracje");

            migrationBuilder.DropColumn(
                name: "dodatkoweOczekiwania",
                table: "Restauracje");

            migrationBuilder.DropColumn(
                name: "dodatkoweUslugi",
                table: "Restauracje");

            migrationBuilder.AddColumn<bool>(
                name: "wnoszenieAlkoholu",
                table: "Restauracje",
                nullable: false,
                defaultValue: false);
        }
    }
}
