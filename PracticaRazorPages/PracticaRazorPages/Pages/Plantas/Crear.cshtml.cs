using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Models;
using PracticaRazorPages.Servicios;

namespace PracticaRazorPages.Pages.Plantas
{
    public class CrearModel : PageModel
    {
        private readonly ServiciosPlantas _servicioPlantas;

        public CrearModel(ServiciosPlantas serviciosPlantas)
        {
            _servicioPlantas = serviciosPlantas;
        }

        [BindProperty]
        public ModeloPlanta Planta { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // 2. Si llegamos aquí, significa que TODO ESTÁ BIEN. Procedemos a guardar:
            Planta.PlantaID = _servicioPlantas.Obtener().Count() + 1;
            _servicioPlantas.Obtener().Add(Planta);

            return RedirectToPage("Index");
        }
    }
}
