using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMedical.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    especialidadId = table.Column<string>(type: "text", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.especialidadId);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    medicoId = table.Column<string>(type: "text", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "MedicoEspecialidades",
                columns: table => new
                {
                    medicoEspecialidadId = table.Column<string>(type: "text", nullable: false),
                    EspecialidadId = table.Column<string>(type: "text", nullable: false),
                    medicoId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoEspecialidades", x => x.medicoEspecialidadId);
                    table.ForeignKey(
                        name: "FK_MedicoEspecialidades_Especialidades",
                        column: x => x.EspecialidadId,
                        principalTable: "Especialidades",
                        principalColumn: "especialidadId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicoEspecialidades_Medico",
                        column: x => x.medicoId,
                        principalTable: "Medicos",
                        principalColumn: "medicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicoEspecialidades_EspecialidadId",
                table: "MedicoEspecialidades",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoEspecialidades_medicoId",
                table: "MedicoEspecialidades",
                column: "medicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicoEspecialidades");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "Medicos");
        }
    }
}
