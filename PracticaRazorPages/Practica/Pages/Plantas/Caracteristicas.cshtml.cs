using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica.Models;
using Practica.Servicios;

namespace Practica.Pages.Plantas
{
    public class CaracteristicasModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas; //usado como paso uno para trabajos

        public CaracteristicasModel(ServicioPlantas servicioPlantas)//se inicializa la pagina y se llama al constructor 
        {
            _servicioPlantas = servicioPlantas;
        }

        public ModeloPlanta Planta { get; set; }

        public void OnGet(int id)
        {
            var plantas = _servicioPlantas.Get();
            Planta = plantas.FirstOrDefault(x => x.PlantaId == id);
        }
    }
}
