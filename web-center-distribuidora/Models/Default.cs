using System;
using System.Collections.Generic;
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
        public string? Nome { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataInclusao { get; set; }

        [DataType(DataType.Date)]
        public DateTime UltimoAcesso { get; set; }

        public virtual ICollection<Contato> Contato { get; set; }
    }

    public class PessoaFisica : Pessoa
    {
        [Required]
        public string Cpf { get; set; }

        public string Rg { get; set; }

        [Required]
        public string Sexo { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }
    }

    public class PessoaJuridica : Pessoa
    {
        [Required]
        public string? Cnpj { get; set; }

        public string? InscricaoEstadual { get; set; }
        public DateTime DataAbertura { get; set; }

        [Required]
        public string? RazaoSocial { get; set; }

        public string? NomeFantasia { get; set; }
    }

    public class Contato
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public long Telefone { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public string? Cep { get; set; }

        [Required]
        public string? Endereco { get; set; }

        [Required]
        public int Numero { get; set; }

        public string? Complemento { get; set; }

        [Required]
        public string? Bairro { get; set; }

        [Required]
        public string? Cidade { get; set; }

        [Required]
        public EstadosBrasileiros Estado { get; set; }

        public string? PontoReferencia { get; set; }

        public int PessoaId { get; set; }

        [ForeignKey("PessoaId")]
        public virtual Pessoa Pessoa { get; set; }
    }

    public class Produto
    {
        [Key]
        public int Id { get; set; }

        public string? Codigo { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string? Descricao { get; set; }

        public string Grupo1 { get; set; }
        public string Grupo2 { get; set; }
        public string Grupo3 { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DataInclusao { get; set; }

        public string? UnidadeDeMedida { get; set; }

        [DataType(DataType.Currency)]
        public decimal PrecoVarejo { get; set; }

        [DataType(DataType.Currency)]
        public decimal PrecoAtacado { get; set; }

        public int QuantidadeAtacado { get; set; }
        public bool Inativo { get; set; }

        public int FornecedorId { get; set; }

        [ForeignKey("FornecedorId")]
        public virtual Pessoas Pessoas { get; set; }
    }

    public class Grupo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public bool Inativo { get; set; }
    }

    public class Estoque
    {
        public int Id { get; set; }
    }

}