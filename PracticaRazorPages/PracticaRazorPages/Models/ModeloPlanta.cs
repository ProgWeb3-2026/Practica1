using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace PracticaRazorPages.Models
{
    public class ModeloPlanta
    {

        public int PlantaId { get; set; }

        [Required(ErrorMessage = "El nombre común es un campo requerido")]
        [StringLength(200, ErrorMessage = "Maximo 200")]
        public string NombreComun { get; set; }
        [Required(ErrorMessage = "El nombre cientifico es un campo requerido")]
        [StringLength(300, ErrorMessage = "Maximo 300")]
        public string NombreCientifico { get; set; }

        public string Categoria { get; set; }
        [Required]
        [EmailAddress]
        public string CorreoEncargado { get; set; }

        public string Foto { get; set; }
    }
}
