using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Examen.Models
{
    public class Tarea
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="El maixmo es de 50 caracteres")]
        public string Titulo { get; set; }
        public string? Descripcion { get; set; }
        
        public DateTime FechaVencimiento { get; set; }

        [Required]
        [Display(Name = "Prioridad")]
        public string Prioridad { get; set; }
        [Required]
        public bool Completada { get; set; }
    }
}
