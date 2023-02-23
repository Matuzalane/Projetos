using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_center_distribuidora.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string nome { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [DataType(DataType.Date)]
        public DateTime dataInclusao { get; set; }

        [DataType(DataType.Date)]
        public DateTime ultimoAcesso { get; set; }

        public virtual ICollection<Contato> Contatos { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }

    public class PessoaFisica : Pessoa
    {
        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 caracteres")]
        public string cpf { get; set; }

        [StringLength(9, MinimumLength = 9, ErrorMessage = "RG deve ter 9 caracteres")]
        public string rg { get; set; }

        [Required]
        [EnumDataType(typeof(Sexo))]
        public Sexo sexo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime dataNascimento { get; set; }
    }

    public class PessoaJuridica : Pessoa
    {
        [Required]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "CNPJ deve ter 14 caracteres")]
        public string cnpj { get; set; }

        [StringLength(15, MinimumLength = 15, ErrorMessage = "Inscrição estadual deve ter 15 caracteres")]
        public string inscricaoEstadual { get; set; }

        [DataType(DataType.Date)]
        public DateTime dataAbertura { get; set; }

        [Required]
        public string razaoSocial { get; set; }

        public string nomeFantasia { get; set; }
    }

    public class Contato
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string informacaoContato { get; set; }

        public TipoContato tipoContato { get; set; }
        public bool whatsApp { get; set; }

        [Required]
        public int pessoaId { get; set; }

        [ForeignKey("pessoaId")]
        public virtual Pessoa Pessoa { get; set; }
    }

    public class Endereco
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP deve ter 8 caracteres")]
        public string cep { get; set; }

        [Required]
        public string logradouro { get; set; }

        [Required]
        public int numero { get; set; }

        public string complemento { get; set; }

        [Required]
        public string bairro { get; set; }

        [Required]
        public string cidade { get; set; }

        [Required]
        [EnumDataType(typeof(EstadoBrasileiro))]
        public EstadoBrasileiro estado { get; set; }

        [Required]
        public int pessoaId { get; set; }
        
        [ForeignKey("pessoaId")]
        public virtual Pessoa Pessoa { get; set; }
    }
}