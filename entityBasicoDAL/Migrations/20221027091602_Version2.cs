using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entityBasicoDAL.Migrations
{
    public partial class Version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_nivel_acceso_empleados_EmpleadoId",
                table: "nivel_acceso");

            migrationBuilder.DropIndex(
                name: "IX_nivel_acceso_EmpleadoId",
                table: "nivel_acceso");

            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "nivel_acceso");

            migrationBuilder.AddColumn<int>(
                name: "nivel_accId",
                table: "empleados",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_empleados_nivel_accId",
                table: "empleados",
                column: "nivel_accId");

            migrationBuilder.AddForeignKey(
                name: "FK_empleados_nivel_acceso_nivel_accId",
                table: "empleados",
                column: "nivel_accId",
                principalTable: "nivel_acceso",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_empleados_nivel_acceso_nivel_accId",
                table: "empleados");

            migrationBuilder.DropIndex(
                name: "IX_empleados_nivel_accId",
                table: "empleados");

            migrationBuilder.DropColumn(
                name: "nivel_accId",
                table: "empleados");

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "nivel_acceso",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_nivel_acceso_EmpleadoId",
                table: "nivel_acceso",
                column: "EmpleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_nivel_acceso_empleados_EmpleadoId",
                table: "nivel_acceso",
                column: "EmpleadoId",
                principalTable: "empleados",
                principalColumn: "Id");
        }
    }
}
