using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class DetallePlantaModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;

        public DetallePlantaModel(ServicioPlantas servicioPlantas)
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
