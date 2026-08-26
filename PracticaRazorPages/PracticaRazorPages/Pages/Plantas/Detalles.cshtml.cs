using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Models;
using PracticaRazorPages.Servicios;
using System.Security.Cryptography.X509Certificates;

namespace PracticaRazorPages.Pages.Plantas
{
    public class DetallesModel : PageModel
    {
        private readonly ServiciosPlantas _servicioPlantas;

        public DetallesModel(ServiciosPlantas serviciosPlantas) 
        {
            _servicioPlantas = serviciosPlantas;   
        }

        public ModeloPlanta Planta { get; set; }
        public void OnGet(int id)
        {
            var plantas = _servicioPlantas.Obtener();
            Planta = plantas.FirstOrDefault(x => x.PlantaID == id);
            
        }
    }
}
