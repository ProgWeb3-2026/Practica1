using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class EliminarModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;

        public EliminarModel(ServicioPlantas servicioPlantas)
        {
            _servicioPlantas = servicioPlantas;
        }

        [BindProperty]
        public ModeloPlanta EliminarPlanta { get; set; }

        public IActionResult OnGet(int id)
        {
            var plantas = _servicioPlantas.Obtener();

            EliminarPlanta = plantas.FirstOrDefault(x => x.PlantaId == id);

            if (EliminarPlanta == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            var plantas = _servicioPlantas.Obtener();

            var planta = plantas.FirstOrDefault(
                x => x.PlantaId == EliminarPlanta.PlantaId
            );

            if (planta == null)
            {
                return NotFound();
            }

            plantas.Remove(planta);

            return RedirectToPage("Index");
        }
    }
}
