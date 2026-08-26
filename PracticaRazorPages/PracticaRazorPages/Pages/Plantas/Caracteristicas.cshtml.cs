using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class CarasteristicasModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas; //usado como paso uno para trabajos

        public CarasteristicasModel(ServicioPlantas servicioPlantas)//se inicializa la pagina y se llama al constructor 
        {
           _servicioPlantas = servicioPlantas;
        }

        public ModeloPlanta Planta { get; set; }

        public void OnGet(int id)
        {
            var plantas = _servicioPlantas.Obtener();
            Planta =plantas.FirstOrDefault(x=> x.PlantaId == id);
        }
    }
}
