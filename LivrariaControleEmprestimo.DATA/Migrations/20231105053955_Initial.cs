using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LivrariaControleEmprestimo.DATA.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliCPF = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    cliNome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    cliEndereco = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    cliCidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    cliBairro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    cliNumero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cliTeleoneCelular = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    cliTelefoneFixo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    livroNome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    livroAutor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    livroEditora = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    livroAnoPublicacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    livroEdicao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LivroClienteEmprestimo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LceIdCliente = table.Column<int>(type: "int", nullable: false),
                    LceIdLivro = table.Column<int>(type: "int", nullable: false),
                    LceDataEmprestimo = table.Column<DateTime>(type: "datetime", nullable: false),
                    LceDataEntrega = table.Column<DateTime>(type: "datetime", nullable: false),
                    LceEntregue = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivroClienteEmprestimo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivroClienteEmprestimo_Cliente",
                        column: x => x.LceIdCliente,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LivroClienteEmprestimo_Livro",
                        column: x => x.LceIdLivro,
                        principalTable: "Livro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LivroClienteEmprestimo_LceIdCliente",
                table: "LivroClienteEmprestimo",
                column: "LceIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_LivroClienteEmprestimo_LceIdLivro",
                table: "LivroClienteEmprestimo",
                column: "LceIdLivro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LivroClienteEmprestimo");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Livro");
        }
    }
}
