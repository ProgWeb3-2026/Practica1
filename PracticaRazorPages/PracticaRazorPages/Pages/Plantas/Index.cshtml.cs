using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Models;
using PracticaRazorPages.Servicios;

namespace PracticaRazorPages.Pages.Plantas
{
    public class IndexModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;
        public IndexModel(ServicioPlantas servicioPlantas)
        {
            this._servicioPlantas = servicioPlantas;
        }
        public List<ModeloPlanta> Plantas { get; set; }

        public void OnGet()
        {
            Plantas = _servicioPlantas.Obtener();
        }
    }
}
