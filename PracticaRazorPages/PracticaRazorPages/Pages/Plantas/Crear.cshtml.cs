using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class CrearModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas; //usado como paso uno para trabajos

        public CrearModel(ServicioPlantas servicioPlantas)//se inicializa la pagina y se llama al constructor 
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
                Planta.PlantaId= _servicioPlantas.Obtener().Count()+1;
               _servicioPlantas.Obtener().Add(Planta);
                
                return RedirectToPage("Index");
            }
            return Page();
        }
        
    }
}
