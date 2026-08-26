using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using PracticaRazorPages.Models;
using PracticaRazorPages.Servicios;

namespace PracticaRazorPages.Pages.Plantas
{
    public class DetallesPlantasModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;
        public DetallesPlantasModel(ServicioPlantas servicioPlantas)
        {
            this._servicioPlantas = servicioPlantas;
        }
        public ModeloPlanta Planta{ get; set; }


        public void OnGet(int Id)
        {
            var plantas = _servicioPlantas.Obtener();
            Planta = plantas.FirstOrDefault(p => p.PlantaId == Id);
        }
    }
}
