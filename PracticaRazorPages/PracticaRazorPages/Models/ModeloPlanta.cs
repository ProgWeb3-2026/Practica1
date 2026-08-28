using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace PracticaRazorPages.Models
{
    public class ModeloPlanta
    {
        public int PlantaID { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(200, ErrorMessage = "El campo debe ser entre 0 o 200")]
        public string NombreComun {  get; set; }

        [Required(ErrorMessage = "El nombre cientifico es un campo requerido")]
        [StringLength(200, ErrorMessage = "El campo debe ser entre 0 o 200")]
        public string NombreCientifico { get; set; }

        public string Categoria { get; set; }

        [Required (ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Se requiere un correo electrónico válido")]
        public string CorreoEncargado { get; set; }

        public string Foto { get; set; }

    }
}
