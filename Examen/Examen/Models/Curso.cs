using System.ComponentModel.DataAnnotations;

namespace Examen.Models
{
    public class Curso
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage ="El maximo es de 50 caracteres")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(150, ErrorMessage = "El maximo es de 150 caracteres")]
        public string? Descripcion { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El maximo es de 50 caracteres")]
        public string Instructor { get; set; }
        public int DuracionHoras { get; set; }
        public decimal Precio { get; set; }
        [Display(Name = "Basico")]
        public string Nivel { get; set; } = string.Empty;
    }
}
