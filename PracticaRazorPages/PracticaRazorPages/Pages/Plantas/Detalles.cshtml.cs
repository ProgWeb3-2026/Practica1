using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class DetallesModel : PageModel
    {
        private readonly ServicioPlantas _serviciosPlantas;

        public DetallesModel(ServicioPlantas servicioPlantas)
        {
            _serviciosPlantas = servicioPlantas;
        }

        public ModeloPlanta Planta { get; set; }
        public void OnGet(int id)
        {
            var  plantas = _serviciosPlantas.Obtener();
            Planta = plantas.FirstOrDefault(x => x.PlantaId == id);
        }
    }
}
