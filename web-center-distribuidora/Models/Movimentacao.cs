using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_center_distribuidora.Models
{
    public class Movimentacao
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string codigoDeRastreamento { get; set; }
        
        [Required]
        [EnumDataType(typeof(TipoMovimentacao))]
        public TipoMovimentacao tipo { get; set; }

        public int empresa { get; set; }

        [DataType(DataType.Date)]
        public DateTime dataInclusao { get; set; }

        [Required]
        [Display(Name = "Id do Cliente")]
        public int pessoaId { get; set; }
        
        [ForeignKey("pessoaId")]
        public virtual Pessoa Pessoa { get; set; }
        public ICollection<NotaFiscal> notasFiscais { get; set; }       
    }

    public class NotaFiscal 
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string cfop { get; set; }

        [Required]
        [EnumDataType(typeof(TipoNota))]
        public TipoNota tipoNota { get; set; }

        [Required]
        [EnumDataType(typeof(EstadoBrasileiro))]
        public EstadoBrasileiro ufOrigem { get; set; }

        [Required]
        public int numeroNota { get; set; }

        public int serie { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal subTotal { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal frete { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal desconto { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal total { get; set; }

        public string dadosAdicionais { get; set; }

        [Required]
        public int movimentacaoId { get; set; }

        [ForeignKey("movimentacaoId")]
        public virtual Movimentacao Movimentacao { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; } 
    }
}