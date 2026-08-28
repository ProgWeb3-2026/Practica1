using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Servicios;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class CreatePlantaModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;

        public CreatePlantaModel(ServicioPlantas servicioPlantas)
        {
            this._servicioPlantas = servicioPlantas;
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
                Planta.PlantaId = _servicioPlantas.Obtener().Count() + 1;
                _servicioPlantas.Obtener().Add(Planta);

                return RedirectToPage("Index");
            }
            return Page();
        }

    }
}
