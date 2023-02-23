using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_center_distribuidora.ModelsCrm
{
    [Table("Produtos")]
    public class CrmProduto
    {
        [Key]
        public int Chave { get; set; }
        public string Codigo { get; set; }
        public string Auxiliar1 { get; set; }
        public string Descricao { get; set; }
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
        [Key]
        public int Chave { get; set; }
        public int Chave_Produto { get; set; }
        public int Competencia { get; set; }
        public int Disp_It { get; set; }
    }

    [Table("Grupos")]
    public class CrmGrupo
    {
        [Key]
        public int Chave { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Descricao_Web { get; set; }
        public int Nivel { get; set; }
        public Boolean Grupo_Web { get; set; }
        
    }

}