using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class CrearPlantaModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;
        public CrearPlantaModel(ServicioPlantas servicioPlantas)
        {
            _servicioPlantas = servicioPlantas;
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
                Planta.PlantaId = _servicioPlantas.Get().Count() + 1;
                _servicioPlantas.Get().Add(Planta);

                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
