using System.ComponentModel.DataAnnotations;
namespace WebApplication1.models

{
    public class ModeloPlanta
    {
        public int plantaId { get; set; }

        [Required(ErrorMessage ="el nombre comun es un campo requerido")]
        [StringLength(200,ErrorMessage ="maximo de  200")]
        
        public string nombrecomun { get; set; }

        [Required(ErrorMessage = "el nombre cientifoco es un campo requerido ")]
        [StringLength(300,ErrorMessage = "maximo de 300")]
        public string nombrecientifico { get; set; }

        public string categoria { get; set; }

        [Required]

        public string correoEncargado { get; set; }

        public string foto { get; set; }


    }
}
