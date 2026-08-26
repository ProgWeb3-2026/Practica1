using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class EditModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;
        public EditModel(ServicioPlantas servicioPlantas)
        {
            _servicioPlantas = servicioPlantas;
        }

        [BindProperty]
        public ModeloPlanta Planta { get; set; }
        public void OnGet(int id)
        {
            var plantas = _servicioPlantas.Obtener();
            Planta = plantas.FirstOrDefault(x => x.PlantaId == id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var plantas = _servicioPlantas.Obtener();
                var planta = plantas.FirstOrDefault(x => x.PlantaId == Planta.PlantaId);

                planta.NombreCientifico = Planta.NombreCientifico;
                planta.NombreComun= Planta.NombreComun;
                planta.CorreoEncargado= Planta.CorreoEncargado;
                planta.Categoria= Planta.Categoria;
                planta.Foto= Planta.Foto;

                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
