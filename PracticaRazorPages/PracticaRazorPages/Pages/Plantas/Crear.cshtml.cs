using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class CrearModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;
        public CrearModel(ServicioPlantas servicioPlantas)
        {
            _servicioPlantas = servicioPlantas;
        }

        [BindProperty]
        public ModeloPlanta CrearPlanta { get; set; }
        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                CrearPlanta.PlantaId = _servicioPlantas.Obtener().Count() + 1;
                _servicioPlantas.Obtener().Add(CrearPlanta);

                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
