using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libreria.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio.")]
        [StringLength(150, ErrorMessage = "El título no puede superar los 150 caracteres.")]
        [Display(Name = "Título")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El autor es obligatorio.")]
        [StringLength(100, ErrorMessage = "El autor no puede superar los 100 caracteres.")]
        public string Autor { get; set; } = string.Empty;

        [Required(ErrorMessage = "El ISBN es obligatorio.")]
        [StringLength(20, ErrorMessage = "El ISBN no puede superar los 20 caracteres.")]
        public string ISBN { get; set; } = string.Empty;

        [Required(ErrorMessage = "El año de publicación es obligatorio.")]
        [Range(1000, 2100, ErrorMessage = "Ingrese un año válido.")]
        [Display(Name = "Año de Publicación")]
        public int AnioPublicacion { get; set; }

        [Required(ErrorMessage = "El precio de alquiler es obligatorio.")]
        [Range(0.01, 10000.00, ErrorMessage = "El precio debe ser mayor a 0.")]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Precio de Alquiler")]
        public decimal PrecioAlquiler { get; set; }
    }
}