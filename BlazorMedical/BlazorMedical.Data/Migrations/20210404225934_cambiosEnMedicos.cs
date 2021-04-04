using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BlazorMedical.Data.Migrations
{
    public partial class cambiosEnMedicos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    medicoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    nombre2 = table.Column<string>(type: "text", nullable: true),
                    apellido = table.Column<string>(type: "text", nullable: false),
                    apellido2 = table.Column<string>(type: "text", nullable: true),
                    dni = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    cuit = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    FechaDeNacimiento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    direccionCalle = table.Column<string>(type: "text", nullable: false),
                    direccionNumero = table.Column<string>(type: "text", nullable: false),
                    direccionProvincia = table.Column<string>(type: "text", nullable: false),
                    direccionLocalidad = table.Column<string>(type: "text", nullable: false),
                    direccionCp = table.Column<string>(type: "text", nullable: true),
                    direccionPais = table.Column<string>(type: "text", nullable: false),
                    paisNacimiento = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.medicoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicos");
        }
    }
}
