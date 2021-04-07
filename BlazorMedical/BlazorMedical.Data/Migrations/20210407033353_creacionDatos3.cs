using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMedical.Data.Migrations
{
    public partial class creacionDatos3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "direccionPais",
                table: "Pacientes",
                newName: "direccionPaisId");

            migrationBuilder.RenameIndex(
                name: "IX_Pacientes_direccionPais",
                table: "Pacientes",
                newName: "IX_Pacientes_direccionPaisId");

            migrationBuilder.RenameColumn(
                name: "direccionPais",
                table: "Medicos",
                newName: "direccionPaisId");

            migrationBuilder.RenameIndex(
                name: "IX_Medicos_direccionPais",
                table: "Medicos",
                newName: "IX_Medicos_direccionPaisId");

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "paisId", "descripcion", "nombre" },
                values: new object[,]
                {
                    { "4b989327-10d9-4de7-813c-d4420d6f2b9907/04/2021 0:33:53", "", "Argentina" },
                    { "1742cf43-a5f7-4c84-8d03-7f2f90256fc607/04/2021 0:33:53", "", "Uruguay" },
                    { "af89b879-3840-477a-86ab-aff1fd05deb307/04/2021 0:33:53", "", "Brasil" },
                    { "7146e45e-3d1e-453a-8f84-e57ae847c05207/04/2021 0:33:53", "", "Paraguay" },
                    { "2a2c01aa-2fdd-4a88-90c1-d2d07eb400c307/04/2021 0:33:53", "", "Chile" },
                    { "ca0770ad-4625-4262-9a73-992cad73176e07/04/2021 0:33:53", "", "Bolivia" }
                });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "provinciaId", "descripcion", "nombre" },
                values: new object[,]
                {
                    { "59284829-9bd3-4b78-99be-6895b945152e07/04/2021 0:33:53", "", "Buenos Aires" },
                    { "fb9aafa2-2da2-449b-907a-5ddad2f2bcd907/04/2021 0:33:53", "", "C.A.B.A" },
                    { "c835bdbf-2194-46c9-af23-462bfd4c7f1707/04/2021 0:33:53", "", "Córdoba" },
                    { "ef130bc7-bdee-460d-b9b9-2d9dd6ead1cb07/04/2021 0:33:53", "", "Entre Rios" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "1742cf43-a5f7-4c84-8d03-7f2f90256fc607/04/2021 0:33:53");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "2a2c01aa-2fdd-4a88-90c1-d2d07eb400c307/04/2021 0:33:53");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "4b989327-10d9-4de7-813c-d4420d6f2b9907/04/2021 0:33:53");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "7146e45e-3d1e-453a-8f84-e57ae847c05207/04/2021 0:33:53");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "af89b879-3840-477a-86ab-aff1fd05deb307/04/2021 0:33:53");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "paisId",
                keyValue: "ca0770ad-4625-4262-9a73-992cad73176e07/04/2021 0:33:53");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "provinciaId",
                keyValue: "59284829-9bd3-4b78-99be-6895b945152e07/04/2021 0:33:53");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "provinciaId",
                keyValue: "c835bdbf-2194-46c9-af23-462bfd4c7f1707/04/2021 0:33:53");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "provinciaId",
                keyValue: "ef130bc7-bdee-460d-b9b9-2d9dd6ead1cb07/04/2021 0:33:53");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "provinciaId",
                keyValue: "fb9aafa2-2da2-449b-907a-5ddad2f2bcd907/04/2021 0:33:53");

            migrationBuilder.RenameColumn(
                name: "direccionPaisId",
                table: "Pacientes",
                newName: "direccionPais");

            migrationBuilder.RenameIndex(
                name: "IX_Pacientes_direccionPaisId",
                table: "Pacientes",
                newName: "IX_Pacientes_direccionPais");

            migrationBuilder.RenameColumn(
                name: "direccionPaisId",
                table: "Medicos",
                newName: "direccionPais");

            migrationBuilder.RenameIndex(
                name: "IX_Medicos_direccionPaisId",
                table: "Medicos",
                newName: "IX_Medicos_direccionPais");

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
        }
    }
}
