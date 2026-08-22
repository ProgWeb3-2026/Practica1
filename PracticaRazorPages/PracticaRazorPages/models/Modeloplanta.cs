using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace PracticaRazorPages.models
{
    public class Modeloplanta
    {
       
        public int plantaid { get; set; }

        [Required(ErrorMessage ="el nombre comun es un campo requerido")]//convierte el campo en obligatorio*/
        [StringLength(200,ErrorMessage ="maximo de 200")]
        public string nombrecomun {  get; set; }
        [Required(ErrorMessage = "el nombre cientifico es un campo requerido")]
        [StringLength(300, ErrorMessage = "maximo de 300")]
        public string nombrecientifico { get; set; }
        public string categoria {  get; set; }
        [Required]
        [EmailAddress]
        public string correoencargado {  get; set; }

        public string foto {  get; set; }
    }
}
