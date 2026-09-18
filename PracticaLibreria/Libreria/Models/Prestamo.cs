using System.ComponentModel.DataAnnotations;

namespace Libreria.Models
{
    public class Prestamo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha de préstamo es obligatoria.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Préstamo")]
        public DateTime FechaPrestamo { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "La fecha de devolución es obligatoria.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Devolución")]
        public DateTime FechaDevolucion { get; set; } = DateTime.Now.AddDays(7);

        [Required(ErrorMessage = "El código de préstamo es obligatorio.")]
        [StringLength(20, ErrorMessage = "El código no puede superar los 20 caracteres.")]
        [Display(Name = "Código de Préstamo")]
        public string CodigoPrestamo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El estado es obligatorio.")]
        [StringLength(30, ErrorMessage = "El estado no puede superar los 30 caracteres.")]
        public string Estado { get; set; } = "Pendiente";

        [StringLength(250, ErrorMessage = "Las observaciones no pueden superar los 250 caracteres.")]
        public string? Observaciones { get; set; }
    }
}