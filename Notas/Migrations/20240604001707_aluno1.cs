using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Notas.Migrations
{
    /// <inheritdoc />
    public partial class aluno1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    AlunoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlunoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prova = table.Column<double>(type: "float", nullable: false),
                    Trabalho = table.Column<double>(type: "float", nullable: false),
                    Teste = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.AlunoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");
        }
    }
}
