using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todoist2.Migrations
{
    /// <inheritdoc />
    public partial class CorrijindoFk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tarefas_usuarios_UsuarioId",
                table: "tarefas");

            migrationBuilder.DropIndex(
                name: "IX_tarefas_UsuarioId",
                table: "tarefas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "tarefas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "tarefas",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_tarefas_UsuarioId",
                table: "tarefas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_tarefas_usuarios_UsuarioId",
                table: "tarefas",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
