using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Materias")]
    public class Materias
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [ForeignKey("Titulo")]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; } = string.Empty;

        [ForeignKey("ProfessoresId")]
        [Display(Name = "Professores")]
        public string ProfessoresId { get; set; } = string.Empty;


    }
}