using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Numerics;
using TrabajoRazorPagesICZ.Models;
using TrabajoRazorPagesICZ.Pages.Plantas.Servicios;

namespace TrabajoRazorPagesICZ.Pages.Plantas
{
    public class CrearPlantaModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;

        public CrearPlantaModel(ServicioPlantas servicioPlantas)
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
