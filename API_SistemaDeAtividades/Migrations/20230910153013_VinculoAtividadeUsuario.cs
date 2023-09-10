using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_SistemaDeAtividades.Migrations
{
    public partial class VinculoAtividadeUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Atividades",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Atividades_UsuarioId",
                table: "Atividades",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atividades_Usuarios_UsuarioId",
                table: "Atividades",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atividades_Usuarios_UsuarioId",
                table: "Atividades");

            migrationBuilder.DropIndex(
                name: "IX_Atividades_UsuarioId",
                table: "Atividades");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Atividades");
        }
    }
}
