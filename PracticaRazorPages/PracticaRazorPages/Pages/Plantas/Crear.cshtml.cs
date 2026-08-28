using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class CrearModel : PageModel
    {
        private readonly ServicioPlantas _serviciosPlantas;

        public CrearModel(ServicioPlantas servicioPlantas)
        {
            _serviciosPlantas = servicioPlantas;
        }

        [BindProperty]
        public ModeloPlanta Planta { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Planta.PlantaId = _serviciosPlantas.Obtener().Count() + 1;
                _serviciosPlantas.Obtener().Add(Planta);

                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
