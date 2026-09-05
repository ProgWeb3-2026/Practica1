using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.models;
using WebApplication1.servicios;

namespace WebApplication1.Pages.plantas
{
    public class crearModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;
        public crearModel(ServicioPlantas servicioPlantas)
        {
            _servicioPlantas = servicioPlantas;
        }
        [BindProperty]
        public ModeloPlanta Planta { get; set; }
        public void OnGet(int id)
        {}
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Planta.plantaId = _servicioPlantas.Obtener().Count() + 1;
                _servicioPlantas.Obtener().Add(Planta);
                return RedirectToPage("index");
            }
            return Page();
        }
    }
}
