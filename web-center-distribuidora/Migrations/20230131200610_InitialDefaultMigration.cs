using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webcenterdistribuidora.Migrations
{
    /// <inheritdoc />
    public partial class InitialDefaultMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ultimoAcesso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    rg = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    sexo = table.Column<int>(type: "int", nullable: true),
                    dataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    cnpj = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    inscricaoEstadual = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    dataAbertura = table.Column<DateTime>(type: "datetime2", nullable: true),
                    razaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nomeFantasia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    informacaoContato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoContato = table.Column<int>(type: "int", nullable: false),
                    whatsApp = table.Column<bool>(type: "bit", nullable: false),
                    pessoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contatos_Pessoa_pessoaId",
                        column: x => x.pessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cep = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numero = table.Column<int>(type: "int", nullable: false),
                    complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false),
                    pessoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Pessoa_pessoaId",
                        column: x => x.pessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movimentacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoDeRastreamento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tipo = table.Column<int>(type: "int", nullable: false),
                    empresa = table.Column<int>(type: "int", nullable: false),
                    dataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pessoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movimentacoes_Pessoa_pessoaId",
                        column: x => x.pessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotaFiscais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cfop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoNota = table.Column<int>(type: "int", nullable: false),
                    ufOrigem = table.Column<int>(type: "int", nullable: false),
                    numeroNota = table.Column<int>(type: "int", nullable: false),
                    serie = table.Column<int>(type: "int", nullable: false),
                    subTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    frete = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    desconto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dadosAdicionais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    movimentacaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotaFiscais_Movimentacoes_movimentacaoId",
                        column: x => x.movimentacaoId,
                        principalTable: "Movimentacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    unidadeDeMedida = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    precoVarejo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    precoAtacado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    codigoSituacaoTributaria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantidadeAtacado = table.Column<int>(type: "int", nullable: false),
                    inativo = table.Column<bool>(type: "bit", nullable: false),
                    fornecedorId = table.Column<int>(type: "int", nullable: false),
                    NotaFiscalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_NotaFiscais_NotaFiscalId",
                        column: x => x.NotaFiscalId,
                        principalTable: "NotaFiscais",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Produtos_Pessoa_fornecedorId",
                        column: x => x.fornecedorId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estoques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    competencia = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    estoqueDisponivel = table.Column<long>(type: "bigint", nullable: false),
                    estoqueReservado = table.Column<long>(type: "bigint", nullable: false),
                    produtoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estoques_Produtos_produtoId",
                        column: x => x.produtoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    inativo = table.Column<bool>(type: "bit", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grupos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_pessoaId",
                table: "Contatos",
                column: "pessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_pessoaId",
                table: "Endereco",
                column: "pessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_produtoId",
                table: "Estoques",
                column: "produtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_ProdutoId",
                table: "Grupos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacoes_pessoaId",
                table: "Movimentacoes",
                column: "pessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscais_movimentacaoId",
                table: "NotaFiscais",
                column: "movimentacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_fornecedorId",
                table: "Produtos",
                column: "fornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_NotaFiscalId",
                table: "Produtos",
                column: "NotaFiscalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "NotaFiscais");

            migrationBuilder.DropTable(
                name: "Movimentacoes");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
