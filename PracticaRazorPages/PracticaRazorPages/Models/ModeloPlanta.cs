using System.ComponentModel.DataAnnotations;

namespace PracticaRazorPages.Models
{
    public class ModeloPlanta
    {
        public int? PlantaId { get; set; }

        [Required(ErrorMessage = "El nombre comun es un campo requerido")]
        [StringLength(200,ErrorMessage = "Maximo de 200")]
        public string NombreComun {  get; set; }

        [Required(ErrorMessage = "El nombre Cientifico es un campo requerido")]
        [StringLength(300, ErrorMessage = "Maximo de 300")]
        public string NombreCientifico { get; set; }

        public string? Categoria { get; set; }

        [Required(ErrorMessage ="Se requiere un correo ekectronico")]
        [EmailAddress]
        public string CorreoEncargado { get; set; }

        public string? Foto { get; set; }
    }
}
