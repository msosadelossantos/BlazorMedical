using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMedical.Data.Migrations
{
    public partial class creacionDatos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "0784a240-0207-4197-844f-b27bad955ca007/04/2021 0:25:01");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "2b3a9bf3-5d2a-4c05-b1e1-645c3b47ba7c07/04/2021 0:25:01");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "688fd2b4-0817-4f6f-b00a-1a37703710ca07/04/2021 0:25:01");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "a9ea628b-a86c-4fc0-8100-69fd61c9194507/04/2021 0:25:01");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "b9136ed7-32f6-46c3-8d8a-771084733e6207/04/2021 0:25:01");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "ba4abba2-ff03-4c6e-b796-fea6b1d4d13307/04/2021 0:25:01");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "provinciaId",
                keyValue: "2cf0e11b-b13d-4f4a-9401-6e025970f8b307/04/2021 0:25:01");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "provinciaId",
                keyValue: "3ded5533-0800-47bb-b6b2-7261af3c5dbb07/04/2021 0:25:01");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "provinciaId",
                keyValue: "b5ab28ef-6828-4a67-93df-e9fe6605d68d07/04/2021 0:25:01");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "provinciaId",
                keyValue: "fa86f43c-114c-4c9e-b0d8-3a881d66c5f907/04/2021 0:25:01");

            migrationBuilder.AddColumn<string>(
                name: "ProvinciaId",
                table: "Pacientes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProvinciaId",
                table: "Medicos",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "paisId", "descripcion", "nombre" },
                values: new object[,]
                {
                    { "9326889f-0603-4ff5-b802-460a6325ca2207/04/2021 0:31:37", "", "Argentina" },
                    { "a361c1b8-3e0c-4fe4-b564-53acb177f20907/04/2021 0:31:37", "", "Uruguay" },
                    { "4d669013-bced-4e95-93fd-31689535cd6c07/04/2021 0:31:37", "", "Brasil" },
                    { "ed46db37-d75b-407e-964d-a58809d1d42707/04/2021 0:31:37", "", "Paraguay" },
                    { "d4970b56-d627-48c1-b9b5-3b353564ed6807/04/2021 0:31:37", "", "Chile" },
                    { "e948e59e-cee1-4029-9c69-4aaf2fc6488c07/04/2021 0:31:37", "", "Bolivia" }
                });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "provinciaId", "descripcion", "nombre" },
                values: new object[,]
                {
                    { "029b45d4-a980-4aae-a149-d05e39ae36b607/04/2021 0:31:37", "", "Buenos Aires" },
                    { "8bf614d9-5d37-44e0-9751-24aa489387f107/04/2021 0:31:37", "", "C.A.B.A" },
                    { "6caffa46-e944-4ed7-b6d9-2bbfd8936a9507/04/2021 0:31:37", "", "Córdoba" },
                    { "420f2ebb-2193-4418-995b-3026e402707a07/04/2021 0:31:37", "", "Entre Rios" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_direccionPais",
                table: "Pacientes",
                column: "direccionPais");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_ProvinciaId",
                table: "Pacientes",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_direccionPais",
                table: "Medicos",
                column: "direccionPais");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_ProvinciaId",
                table: "Medicos",
                column: "ProvinciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_PaisesRecidencia",
                table: "Medicos",
                column: "direccionPais",
                principalTable: "Paises",
                principalColumn: "paisId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Provincias_ProvinciaId",
                table: "Medicos",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "provinciaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_PaisesRecidencia",
                table: "Pacientes",
                column: "direccionPais",
                principalTable: "Paises",
                principalColumn: "paisId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Provincias_ProvinciaId",
                table: "Pacientes",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "provinciaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_PaisesRecidencia",
                table: "Medicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Provincias_ProvinciaId",
                table: "Medicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_PaisesRecidencia",
                table: "Pacientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Provincias_ProvinciaId",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_direccionPais",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_ProvinciaId",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_direccionPais",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_ProvinciaId",
                table: "Medicos");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "4d669013-bced-4e95-93fd-31689535cd6c07/04/2021 0:31:37");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "9326889f-0603-4ff5-b802-460a6325ca2207/04/2021 0:31:37");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "a361c1b8-3e0c-4fe4-b564-53acb177f20907/04/2021 0:31:37");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "d4970b56-d627-48c1-b9b5-3b353564ed6807/04/2021 0:31:37");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "e948e59e-cee1-4029-9c69-4aaf2fc6488c07/04/2021 0:31:37");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "ed46db37-d75b-407e-964d-a58809d1d42707/04/2021 0:31:37");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "provinciaId",
                keyValue: "029b45d4-a980-4aae-a149-d05e39ae36b607/04/2021 0:31:37");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "provinciaId",
                keyValue: "420f2ebb-2193-4418-995b-3026e402707a07/04/2021 0:31:37");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "provinciaId",
                keyValue: "6caffa46-e944-4ed7-b6d9-2bbfd8936a9507/04/2021 0:31:37");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "provinciaId",
                keyValue: "8bf614d9-5d37-44e0-9751-24aa489387f107/04/2021 0:31:37");

            migrationBuilder.DropColumn(
                name: "ProvinciaId",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "ProvinciaId",
                table: "Medicos");

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
        }
    }
}
