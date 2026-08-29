using System.ComponentModel.DataAnnotations;
namespace PracticaBase.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [Display(Name = "Nombre del evento")]
        public string Nombre { get; set; } = "";

        [Required(ErrorMessage = "La fecha es obligatoria")]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "El lugar es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [Display(Name = "Lugar")]
        public string Lugar { get; set; } = "";

        [Range(1, 100000, ErrorMessage = "La capacidad debe ser mayor a 0")]
        [Display(Name = "Capacidad")]
        public int Capacidad { get; set; }
        [Required(ErrorMessage = "El tipo de evento es obligatorio")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Tipo de evento")]
        public string TipoEvento { get; set; } = "";
    }
}