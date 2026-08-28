using System.ComponentModel.DataAnnotations;

namespace PracticaRazorPages.Models
{
    public class ModeloPlanta
    {
        public int PlantaId { get; set; }

        public string NombreComun {  get; set; }
        [Required(ErrorMessage = "EL nombre comun es un campo requerido")]
        [StringLength(200, ErrorMessage = "Maximo 200")]

        public string NombreCientifico { get; set; }
        [Required(ErrorMessage = "EL Nombre Cientifico es un campo requerido")]
        [StringLength(300, ErrorMessage = "Maximo 300")]

        public string Categoria { get; set; }
        [Required(ErrorMessage = "Se requiere un correo electronico")]
        [EmailAddress]
        public string CorreoEncargado { get; set; }
        public string Foto { get; set; }
    }
}
