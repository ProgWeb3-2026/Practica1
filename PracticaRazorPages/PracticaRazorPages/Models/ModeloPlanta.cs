using System.ComponentModel.DataAnnotations;

namespace PracticaRazorPages.Models
{
    public class ModeloPlanta
    {
        public int? PlantaId { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(200,ErrorMessage = "El campo tiene un limite de 200 caracteres")]
        public string NombreComun {  get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(300, ErrorMessage = "El campo tiene un limite de 300 caracteres")]
        public string NombreCientifico { get; set; }

        public string? Categoria { get; set; }

        [Required(ErrorMessage = "El correo electronico es obligatorio")]
        [EmailAddress]
        public string CorreoEncargado { get; set; }

        public string? Foto { get; set; }
    }
}
