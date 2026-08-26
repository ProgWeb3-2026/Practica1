using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrabajoRazorPagesICZ.Models;
using TrabajoRazorPagesICZ.Pages.Plantas.Servicios;

namespace TrabajoRazorPagesICZ.Pages.Plantas
{
    public class ModeloDetalladoPlantasModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;
        public ModeloDetalladoPlantasModel(ServicioPlantas servicioPlantas)
        {
            this._servicioPlantas = servicioPlantas;
        }
        public ModeloPlanta Planta { get; set; }

        public int Id { get; set; }
        public void OnGet(int id)
        {
            var plantas = _servicioPlantas.Obtener();
            Planta = plantas.FirstOrDefault(x=> x.PlantaId == id);
        }
    }
}
