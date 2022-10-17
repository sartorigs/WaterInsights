using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Projeto_Aplicado.Migrations
{
    public partial class novasentidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PowerBis",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value1 = table.Column<int>(type: "integer", nullable: false),
                    value2 = table.Column<int>(type: "integer", nullable: false),
                    value3 = table.Column<int>(type: "integer", nullable: false),
                    value4 = table.Column<int>(type: "integer", nullable: false),
                    value5 = table.Column<int>(type: "integer", nullable: false),
                    UsuarioId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerBis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PowerBis_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Regioes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Bairro = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true),
                    Estado = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: true),
                    Cidade = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true),
                    UsuarioId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regioes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regioes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PowerBis_UsuarioId",
                table: "PowerBis",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Regioes_UsuarioId",
                table: "Regioes",
                column: "UsuarioId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PowerBis");

            migrationBuilder.DropTable(
                name: "Regioes");
        }
    }
}
