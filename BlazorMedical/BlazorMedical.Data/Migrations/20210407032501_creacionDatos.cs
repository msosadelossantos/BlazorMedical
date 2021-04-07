using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMedical.Data.Migrations
{
    public partial class creacionDatos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "paisNacimiento",
                table: "Medicos",
                newName: "paisNacimientoId");

            migrationBuilder.RenameColumn(
                name: "direccionProvincia",
                table: "Medicos",
                newName: "direccionProvinciaId");

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "Especialidades",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    paisId = table.Column<string>(type: "text", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.paisId);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    provinciaId = table.Column<string>(type: "text", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.provinciaId);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    pacienteId = table.Column<string>(type: "text", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    nombre2 = table.Column<string>(type: "text", nullable: true),
                    apellido = table.Column<string>(type: "text", nullable: false),
                    apellido2 = table.Column<string>(type: "text", nullable: true),
                    dni = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    cuit = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    FechaDeNacimiento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    direccionCalle = table.Column<string>(type: "text", nullable: false),
                    direccionNumero = table.Column<string>(type: "text", nullable: false),
                    direccionProvinciaId = table.Column<string>(type: "text", nullable: false),
                    direccionLocalidad = table.Column<string>(type: "text", nullable: false),
                    direccionCp = table.Column<string>(type: "text", nullable: true),
                    direccionPais = table.Column<string>(type: "text", nullable: false),
                    paisNacimientoId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.pacienteId);
                    table.ForeignKey(
                        name: "FK_Pacientes_Paises",
                        column: x => x.paisNacimientoId,
                        principalTable: "Paises",
                        principalColumn: "paisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pacientes_Provincias",
                        column: x => x.direccionProvinciaId,
                        principalTable: "Provincias",
                        principalColumn: "provinciaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "paisId", "descripcion", "nombre" },
                values: new object[,]
                {
                    { "0784a240-0207-4197-844f-b27bad955ca007/04/2021 0:25:01", "", "Argentina" },
                    { "b9136ed7-32f6-46c3-8d8a-771084733e6207/04/2021 0:25:01", "", "Uruguay" },
                    { "2b3a9bf3-5d2a-4c05-b1e1-645c3b47ba7c07/04/2021 0:25:01", "", "Brasil" },
                    { "ba4abba2-ff03-4c6e-b796-fea6b1d4d13307/04/2021 0:25:01", "", "Paraguay" },
                    { "a9ea628b-a86c-4fc0-8100-69fd61c9194507/04/2021 0:25:01", "", "Chile" },
                    { "688fd2b4-0817-4f6f-b00a-1a37703710ca07/04/2021 0:25:01", "", "Bolivia" }
                });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "provinciaId", "descripcion", "nombre" },
                values: new object[,]
                {
                    { "fa86f43c-114c-4c9e-b0d8-3a881d66c5f907/04/2021 0:25:01", "", "Buenos Aires" },
                    { "2cf0e11b-b13d-4f4a-9401-6e025970f8b307/04/2021 0:25:01", "", "C.A.B.A" },
                    { "3ded5533-0800-47bb-b6b2-7261af3c5dbb07/04/2021 0:25:01", "", "Córdoba" },
                    { "b5ab28ef-6828-4a67-93df-e9fe6605d68d07/04/2021 0:25:01", "", "Entre Rios" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_direccionProvinciaId",
                table: "Medicos",
                column: "direccionProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_paisNacimientoId",
                table: "Medicos",
                column: "paisNacimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_direccionProvinciaId",
                table: "Pacientes",
                column: "direccionProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_paisNacimientoId",
                table: "Pacientes",
                column: "paisNacimientoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Paises",
                table: "Medicos",
                column: "paisNacimientoId",
                principalTable: "Paises",
                principalColumn: "paisId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Provincias",
                table: "Medicos",
                column: "direccionProvinciaId",
                principalTable: "Provincias",
                principalColumn: "provinciaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Paises",
                table: "Medicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Provincias",
                table: "Medicos");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_direccionProvinciaId",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_paisNacimientoId",
                table: "Medicos");

            migrationBuilder.RenameColumn(
                name: "paisNacimientoId",
                table: "Medicos",
                newName: "paisNacimiento");

            migrationBuilder.RenameColumn(
                name: "direccionProvinciaId",
                table: "Medicos",
                newName: "direccionProvincia");

            migrationBuilder.AlterColumn<int>(
                name: "descripcion",
                table: "Especialidades",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
