using System.ComponentModel.DataAnnotations;

namespace Practica.Models
{
    public class ModeloPlanta
    {
        public int PlantaId { get; set; }

        [Required(ErrorMessage = "El nombre comun es un campo requerido")] /*convierte el campo en obligaroio*/
        [StringLength(200, ErrorMessage = "Maximo 200")]
        public string NombreComun { get; set; }


        [Required(ErrorMessage = "El nombre cientifico es un campo requerido")]
        [StringLength(300, ErrorMessage = "Maximo 300")]
        public string NombreCientifico { get; set; }
        public string Categoria { get; set; }


        [Required]
        [EmailAddress]
        public string CorreoEncargado { get; set; }

        public string foto { get; set; }
    }
}
