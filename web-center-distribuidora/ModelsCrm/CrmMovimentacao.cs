using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_center_distribuidora.ModelsCrm
{
    [Table("Movimentacao")]
    public class CrmMovimentacao
    {
        [Key]
        public int Chave { get; set; }
        public string Cfop { get; set; }
        public string Tipo { get; set; }
        public int Empresa { get; set; }
        public int Nota_Fiscal { get; set; }
        public string Serie { get; set; }
        public int Pessoa { get; set; }
        public string Nome_Pessoa { get; set; }
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
    public class CrmMovimentacaoItem
    {
        [Key]
        public int Chave { get; set; }
        public int ChaveMov { get; set; }
        public int Codigo_Produto { get; set; }
        public int Tipo_Operacao { get; set; }
        public DateTime Lancamento { get; set; }
        public int Quantidade { get; set; }
    }
}