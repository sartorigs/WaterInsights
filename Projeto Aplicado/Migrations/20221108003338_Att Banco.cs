using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Projeto_Aplicado.Migrations
{
    public partial class AttBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioProjeto");

            migrationBuilder.AddColumn<long>(
                name: "ProjetoId",
                table: "Usuarios",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UsuarioId",
                table: "Projetos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_UsuarioId",
                table: "Projetos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Usuarios_UsuarioId",
                table: "Projetos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Usuarios_UsuarioId",
                table: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Projetos_UsuarioId",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "ProjetoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Projetos");

            migrationBuilder.CreateTable(
                name: "UsuarioProjeto",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Deslikes = table.Column<int>(type: "integer", nullable: false),
                    Likes = table.Column<int>(type: "integer", nullable: false),
                    ProjetoId = table.Column<long>(type: "bigint", nullable: false),
                    UsuarioId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioProjeto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioProjeto_Projetos_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioProjeto_Usuarios_ProjetoId",
                        column: x => x.ProjetoId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioProjeto_ProjetoId",
                table: "UsuarioProjeto",
                column: "ProjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioProjeto_UsuarioId",
                table: "UsuarioProjeto",
                column: "UsuarioId");
        }
    }
}
