using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_center_distribuidora.Models
{
    [Table("Pessoas")]
    public class CrmPessoa
    {
        public int Chave { get; set; }
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Nome_Fantasia { get; set; }
        public string? Cnpj_Cpf { get; set; }
        public string? Rg_Ie { get; set; }
        public string? Sexo { get; set; }
        public DateTime Inclusao { get; set; }
        public string? Categoria { get; set; }
        public DateOnly Nascimento_Abertura { get; set; }
        public string? Fone { get; set; }
        public DateOnly Ultima_Atualizacao { get; set; }
        public Boolean Inativo { get; set; }
    }

    [Table("Pessoas_Enderecos")]
    public class CrmPessoaEndereco
    {
        public int Chave { get; set; }
        public int Chave_Pessoa { get; set; }
        public string? Endereco { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public int Cidade { get; set; }
        public string? Cep { get; set; }
        public string? Uf { get; set; }
        public string? Bairro { get; set; }
        public Boolean Padrao { get; set; }
        public string? Cidade_Descricao { get; set; }
        

    }

    [Table("Pessoas_Contatos")]
    public class CrmPessoasContatos
    {
        public int Chave { get; set; }
        public int Chave_Pessoa { get; set; }
        public string? Tipo { get; set; }
        public string? Campo1 { get; set; }
    }

    [Table("Produtos")]
    public class CrmProduto
    {
        public int Chave { get; set; }
        public string? Codigo { get; set; }
        public string? Auxiliar1 { get; set; }
        public string? Descricao { get; set; }
        public int Grupo1 { get; set; }
        public int Grupo2 { get; set; }
        public int Grupo3 { get; set; }
        public DateTime Inclusao { get; set; }
        public DateTime Ult_Ven { get; set; }
        public int Unid_Med { get; set; }
        public decimal Preco_Venda { get; set; }
        public decimal Preco_Atacado { get; set; }
        public int Quant_Preco_Atacado { get; set; }
        public int Fornecedor { get; set; }
        public Boolean Inativo { get; set; }
        public Boolean Produto_Web { get; set; }
    }

    [Table("Estoques")]
    public class CrmEstoque
    {
        public int Chave { get; set; }
        public int Chave_Produto { get; set; }
        public int Competencia { get; set; }
        public int Disp_It { get; set; }
    }

    [Table("Grupos")]
    public class CrmGrupos
    {
        public int Chave { get; set; }
        public string? Codigo { get; set; }
        public string? Descricao { get; set; }
        public string? Descricao_Web { get; set; }
        public int Nivel { get; set; }
        public Boolean Grupo_Web { get; set; }
        
    }

    [Table("Movimentacao")]
    public class CrmMovimentacao
    {
        public int Chave { get; set; }
        public string? Cfop { get; set; }
        public string? Tipo { get; set; }
        public int Empresa { get; set; }
        public int Nota_Fiscal { get; set; }
        public string? Serie { get; set; }
        public int Pessoa { get; set; }
        public string? Nome_Pessoa { get; set; }
        public DateTime Lancamento { get; set; }
        public int Usuario { get; set; }
        public decimal ValorProdutos { get; set; }
        public decimal ValorFrete { get; set; }
        public decimal Sub_Total { get; set; }
        public decimal Desconto { get; set; }
        public decimal Total { get; set; }
        public int CondPag { get; set; }
        public int Vendedor { get; set; }
        public int Modelo { get; set; }
    }

    [Table("MovItens")]
    public class CrmMovimentacaoItens
    {
        public int Chave { get; set; }
        public int ChaveMov { get; set; }
        public int Codigo_Produto { get; set; }
        public int Tipo_Operacao { get; set; }
        public DateTime Lancamento { get; set; }
        public int Quantidade { get; set; }
    }
}