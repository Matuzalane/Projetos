using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_center_distribuidora.ModelsCrm
{
    [Table("Pessoas")]
    public class CrmPessoa
    {
        [Key]
        public int Chave { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Nome_Fantasia { get; set; }
        public string Cnpj_Cpf { get; set; }
        public string Rg_Ie { get; set; }
        public string Sexo { get; set; }
        public DateTime Inclusao { get; set; }
        public string Categoria { get; set; }
        public DateOnly Nascimento_Abertura { get; set; }
        public string Fone { get; set; }
        public DateOnly Ultima_Atualizacao { get; set; }
        public Boolean Inativo { get; set; }
    }

    [Table("Pessoas_Enderecos")]
    public class CrmPessoaEndereco
    {
        [Key]
        public int Chave { get; set; }
        public int Chave_Pessoa { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public int Cidade { get; set; }
        public string Cep { get; set; }
        public string Uf { get; set; }
        public string Bairro { get; set; }
        public Boolean Padrao { get; set; }
        public string Cidade_Descricao { get; set; }
        

    }

    [Table("Pessoas_Contatos")]
    public class CrmPessoaContato
    {
        [Key]
        public int Chave { get; set; }
        public int Chave_Pessoa { get; set; }
        public string Tipo { get; set; }
        public string Campo1 { get; set; }
    }
}