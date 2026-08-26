using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class EditModelModel : PageModel
    {   
        private readonly ServicioPlantas _servicioPlantas;
        public EditModelModel(ServicioPlantas servicioPlantas)
        {
            _servicioPlantas = servicioPlantas;
        }

        [BindProperty]
        public ModeloPlanta Planta { get; set; }

        public void OnGet(int id)
        {
            var plantas = _servicioPlantas.Get();
            Planta = plantas.FirstOrDefault(x => x.PlantaId == id);
        }
        public IActionResult OnPost() 
        {
            if (ModelState.IsValid) 
            {
                var plantas = _servicioPlantas.Get();
                var planta = plantas.FirstOrDefault(x => x.PlantaId == Planta.PlantaId);

                planta.NombreCientifico = Planta.NombreCientifico;
                planta.NombreComun = Planta.NombreComun;
                planta.Categoria = Planta.Categoria;
                planta.CorreoEncargado= Planta.CorreoEncargado;
                planta.Foto = Planta.Foto;

                _servicioPlantas.Get().Add(planta);
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
