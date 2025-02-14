using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Alunos")]
    public class Alunos
    {
        [Column("Id")]
        [Display(Name = "Id do Aluno")]
        public int Id { get; set; }

        [Column("NomeAluno")]
        [Display(Name = "Nome do Aluno")]
        public string Nome { get; set; } = string.Empty;

        [Column("Cpf")]
        [Display(Name = "Cpf do Aluno")]
        public string Cpf { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "Email do Aluno")]
        public string Email { get; set; } = string.Empty;

        [Column("Telefone")]
        [Display(Name = "Telefone do Aluno")]
        public string Telefone { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Data de Nascimento")]
        public string DataNascimento { get; set; } = string.Empty;

    }
}