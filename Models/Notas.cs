using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Notas")]
    public class Notas
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [ForeignKey("MateriasId")]
        [Display(Name = "Materias do Id")]
        public string MateriasId { get; set; } = string.Empty;

        [ForeignKey("AlunosId")]
        [Display(Name = "Id dos alunos")]
        public string AlunosId { get; set; } = string.Empty;

        [ForeignKey("EtapasId")]
        [Display(Name = "Etapas")]
        public string Etapas { get; set; } = string.Empty;


    }
}