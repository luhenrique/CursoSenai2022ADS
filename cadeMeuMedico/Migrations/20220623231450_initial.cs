using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cadeMeuMedico.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cidades",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: true),
                    estado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cidades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "especialidades",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_especialidades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    apelido = table.Column<string>(type: "TEXT", nullable: true),
                    nome = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    senha = table.Column<string>(type: "TEXT", nullable: true),
                    cidadeid = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_usuarios_cidades_cidadeid",
                        column: x => x.cidadeid,
                        principalTable: "cidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CidadesEspecialidades",
                columns: table => new
                {
                    cidadesid = table.Column<int>(type: "INTEGER", nullable: false),
                    especialidadesid = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CidadesEspecialidades", x => new { x.cidadesid, x.especialidadesid });
                    table.ForeignKey(
                        name: "FK_CidadesEspecialidades_cidades_cidadesid",
                        column: x => x.cidadesid,
                        principalTable: "cidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CidadesEspecialidades_especialidades_especialidadesid",
                        column: x => x.especialidadesid,
                        principalTable: "especialidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicos",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: true),
                    cidadeid = table.Column<int>(type: "INTEGER", nullable: false),
                    especialidadeid = table.Column<int>(type: "INTEGER", nullable: false),
                    crm = table.Column<string>(type: "TEXT", nullable: true),
                    endereco = table.Column<string>(type: "TEXT", nullable: true),
                    telefone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicos", x => x.id);
                    table.ForeignKey(
                        name: "FK_medicos_cidades_cidadeid",
                        column: x => x.cidadeid,
                        principalTable: "cidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicos_especialidades_especialidadeid",
                        column: x => x.especialidadeid,
                        principalTable: "especialidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CidadesEspecialidades_especialidadesid",
                table: "CidadesEspecialidades",
                column: "especialidadesid");

            migrationBuilder.CreateIndex(
                name: "IX_medicos_cidadeid",
                table: "medicos",
                column: "cidadeid");

            migrationBuilder.CreateIndex(
                name: "IX_medicos_especialidadeid",
                table: "medicos",
                column: "especialidadeid");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_cidadeid",
                table: "usuarios",
                column: "cidadeid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CidadesEspecialidades");

            migrationBuilder.DropTable(
                name: "medicos");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "especialidades");

            migrationBuilder.DropTable(
                name: "cidades");
        }
    }
}
