using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class EdicionModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;

        public EdicionModel(ServicioPlantas servicioPlantas)
        {
            _servicioPlantas = servicioPlantas;
        }
       

        [BindProperty]

        public ModeloPlanta Planta { get; set; }
       
        public void OnGet(int id)
        {
            var plantas = _servicioPlantas.Obtener();
            Planta = plantas.First(x => x.PlantaId == id);
        }

        public IActionResult OnPost()
        {
           if (ModelState.IsValid)
           {
                var planta = _servicioPlantas.Obtener();
                Planta = planta.First(x => x.PlantaId == Planta.PlantaId);

                planta.NombreCientifico = Planta.NombreCientifico;
                planta.NombreComun = Planta.NombreComun;
                planta.CorreoEncargado = Planta.CorreoEncargado;
                planta.Categoria = Planta.Categoria;
                planta.Foto = Planta.Foto;

                return RedirectToPage("Index");
                
               
           }

            return Page();
        }
    }
}
