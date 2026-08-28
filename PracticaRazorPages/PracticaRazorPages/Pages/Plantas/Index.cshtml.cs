using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class IndexModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;
        // inicializa la clase 
        public IndexModel(ServicioPlantas servicioPlantas) 
        {
            _servicioPlantas= servicioPlantas;
        }
        public List<ModeloPlanta> Plantas { get; set; }
        public void OnGet()
        {
            Plantas = _servicioPlantas.Obtener();



        }
    }
}
