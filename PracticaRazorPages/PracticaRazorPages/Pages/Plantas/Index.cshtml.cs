using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.Models;


namespace PracticaRazorPages.Pages.Plantas
{
    public class IndexModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;
        
        public IndexModel(ServicioPlantas servicioPlantas) 
        {
            _servicioPlantas = servicioPlantas;
        }
        public List<ModeloPlanta> Plantas { get; set; }
        public void OnGet()
        {
            Plantas = _servicioPlantas.Get();   
        }
        public IActionResult OnPostEliminar(int id)
        {
            var plantas = _servicioPlantas.Get();

            var plantaBorrar = plantas.FirstOrDefault(x => x.PlantaId == id);

            if (plantaBorrar != null)
            {
                plantas.Remove(plantaBorrar);
            }

            return RedirectToPage();
        }
    }
}
