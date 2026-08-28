using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Models;
using PracticaRazorPages.Servicios;

namespace PracticaRazorPages.Pages.Plantas
{
    public class IndexModel : PageModel
    {
        private readonly ServiciosPlantas _serviciosPlantas;
        public IndexModel(ServiciosPlantas serviciosPlantas)
        {
            _serviciosPlantas = serviciosPlantas;
        }
        public List<ModeloPlanta> Plantas { get; set; }
        public void OnGet()
        {
            Plantas = _serviciosPlantas.Obtener();
        }

        public IActionResult OnPostEliminar(int id)
        {
            var plantas = _serviciosPlantas.Obtener();

            var plantaBorrar = plantas.FirstOrDefault(x => x.PlantaID == id);

            if (plantaBorrar != null)
            {
                plantas.Remove(plantaBorrar);
            }

            return RedirectToPage();
        }

    }
}
