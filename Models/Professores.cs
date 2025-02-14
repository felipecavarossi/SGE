using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Professores")]
    public class Professores
    {
        [Column("Id")]
        [Display(Name = "Id do Professor")]
        public int Id { get; set; }

        [Column("NomeProfessor")]
        [Display(Name = "Nome do Professor")]
        public string Nome { get; set; } = string.Empty;

        [Column("Cpf")]
        [Display(Name = "Cpf do Professor")]
        public string Cpf { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "Email do Professor")]
        public string Email { get; set; } = string.Empty;

        [Column("Telefone")]
        [Display(Name = "Telefone do Professor")]
        public string Telefone { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Data de Nascimento")]
        public string DataNascimento { get; set; } = string.Empty;

    }
}