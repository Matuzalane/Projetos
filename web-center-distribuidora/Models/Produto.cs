using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_center_distribuidora.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string codigo { get; set; }

        [Required]
        [StringLength(150)]
        public string nome { get; set; }

        public string descricao { get; set; }

        [DataType(DataType.Date)]
        public DateTime dataInclusao { get; set; }

        [StringLength(20)]
        public string unidadeDeMedida { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal precoVarejo { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal precoAtacado { get; set; }

        public string codigoSituacaoTributaria { get; set; }
        public int quantidadeAtacado { get; set; }
        public bool inativo { get; set; }

        [Required]
        public int fornecedorId { get; set; }
        
        [ForeignKey("fornecedorId")]
        public virtual PessoaJuridica Fornecedor { get; set; }
        public virtual ICollection<Grupo> Grupos { get; set; }
        public virtual ICollection<Estoque> Estoque { get; set; }

    }

    public class Grupo
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(50)]
        public string codigo { get; set; }

        [Required]
        [StringLength(150)]
        public string nome { get; set; }

        public bool inativo { get; set; }

    }

    public class Estoque
    {
        [Key]
        public int Id { get; set; }

        [StringLength(6)]
        public string competencia { get; set; }

        [Required]
        public uint estoqueDisponivel { get; set; }
        public uint estoqueReservado { get; set; }

        [Required]
        public int produtoId { get; set; }

        [ForeignKey("produtoId")]
        public virtual Produto Produto { get; set; }

    }

}