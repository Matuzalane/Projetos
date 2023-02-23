using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace webcenterdistribuidora.Migrations
{
    /// <inheritdoc />
    public partial class InitialCrmMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Estoques",
                columns: table => new
                {
                    Chave = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ChaveProduto = table.Column<int>(name: "Chave_Produto", type: "int", nullable: false),
                    Competencia = table.Column<int>(type: "int", nullable: false),
                    DispIt = table.Column<int>(name: "Disp_It", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoques", x => x.Chave);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Chave = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(type: "longtext", nullable: true),
                    Descricao = table.Column<string>(type: "longtext", nullable: true),
                    DescricaoWeb = table.Column<string>(name: "Descricao_Web", type: "longtext", nullable: true),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    GrupoWeb = table.Column<bool>(name: "Grupo_Web", type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Chave);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Movimentacao",
                columns: table => new
                {
                    Chave = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Cfop = table.Column<string>(type: "longtext", nullable: true),
                    Tipo = table.Column<string>(type: "longtext", nullable: true),
                    Empresa = table.Column<int>(type: "int", nullable: false),
                    NotaFiscal = table.Column<int>(name: "Nota_Fiscal", type: "int", nullable: false),
                    Serie = table.Column<string>(type: "longtext", nullable: true),
                    Pessoa = table.Column<int>(type: "int", nullable: false),
                    NomePessoa = table.Column<string>(name: "Nome_Pessoa", type: "longtext", nullable: true),
                    Lancamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Usuario = table.Column<int>(type: "int", nullable: false),
                    ValorProdutos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorFrete = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotal = table.Column<decimal>(name: "Sub_Total", type: "decimal(18,2)", nullable: false),
                    Desconto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CondPag = table.Column<int>(type: "int", nullable: false),
                    Vendedor = table.Column<int>(type: "int", nullable: false),
                    Modelo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentacao", x => x.Chave);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MovItens",
                columns: table => new
                {
                    Chave = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ChaveMov = table.Column<int>(type: "int", nullable: false),
                    CodigoProduto = table.Column<int>(name: "Codigo_Produto", type: "int", nullable: false),
                    TipoOperacao = table.Column<int>(name: "Tipo_Operacao", type: "int", nullable: false),
                    Lancamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovItens", x => x.Chave);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Chave = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(type: "longtext", nullable: true),
                    Nome = table.Column<string>(type: "longtext", nullable: true),
                    NomeFantasia = table.Column<string>(name: "Nome_Fantasia", type: "longtext", nullable: true),
                    CnpjCpf = table.Column<string>(name: "Cnpj_Cpf", type: "longtext", nullable: true),
                    RgIe = table.Column<string>(name: "Rg_Ie", type: "longtext", nullable: true),
                    Sexo = table.Column<string>(type: "longtext", nullable: true),
                    Inclusao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Categoria = table.Column<string>(type: "longtext", nullable: true),
                    NascimentoAbertura = table.Column<DateOnly>(name: "Nascimento_Abertura", type: "date", nullable: false),
                    Fone = table.Column<string>(type: "longtext", nullable: true),
                    UltimaAtualizacao = table.Column<DateOnly>(name: "Ultima_Atualizacao", type: "date", nullable: false),
                    Inativo = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Chave);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pessoas_Contatos",
                columns: table => new
                {
                    Chave = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ChavePessoa = table.Column<int>(name: "Chave_Pessoa", type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "longtext", nullable: true),
                    Campo1 = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas_Contatos", x => x.Chave);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pessoas_Enderecos",
                columns: table => new
                {
                    Chave = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ChavePessoa = table.Column<int>(name: "Chave_Pessoa", type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "longtext", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "longtext", nullable: true),
                    Cidade = table.Column<int>(type: "int", nullable: false),
                    Cep = table.Column<string>(type: "longtext", nullable: true),
                    Uf = table.Column<string>(type: "longtext", nullable: true),
                    Bairro = table.Column<string>(type: "longtext", nullable: true),
                    Padrao = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CidadeDescricao = table.Column<string>(name: "Cidade_Descricao", type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas_Enderecos", x => x.Chave);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Chave = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(type: "longtext", nullable: true),
                    Auxiliar1 = table.Column<string>(type: "longtext", nullable: true),
                    Descricao = table.Column<string>(type: "longtext", nullable: true),
                    Grupo1 = table.Column<int>(type: "int", nullable: false),
                    Grupo2 = table.Column<int>(type: "int", nullable: false),
                    Grupo3 = table.Column<int>(type: "int", nullable: false),
                    Inclusao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UltVen = table.Column<DateTime>(name: "Ult_Ven", type: "datetime(6)", nullable: false),
                    UnidMed = table.Column<int>(name: "Unid_Med", type: "int", nullable: false),
                    PrecoVenda = table.Column<decimal>(name: "Preco_Venda", type: "decimal(18,2)", nullable: false),
                    PrecoAtacado = table.Column<decimal>(name: "Preco_Atacado", type: "decimal(18,2)", nullable: false),
                    QuantPrecoAtacado = table.Column<int>(name: "Quant_Preco_Atacado", type: "int", nullable: false),
                    Fornecedor = table.Column<int>(type: "int", nullable: false),
                    Inativo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ProdutoWeb = table.Column<bool>(name: "Produto_Web", type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Chave);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Movimentacao");

            migrationBuilder.DropTable(
                name: "MovItens");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Pessoas_Contatos");

            migrationBuilder.DropTable(
                name: "Pessoas_Enderecos");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
