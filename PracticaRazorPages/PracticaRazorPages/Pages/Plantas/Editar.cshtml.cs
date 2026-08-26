using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class EditarModel : PageModel
    {

        private readonly ServicioPlantas _servicioPlantas;
        public EditarModel(ServicioPlantas servicioPlantas)
        {
            _servicioPlantas = servicioPlantas;
        }


        [BindProperty]
        public ModeloPlanta EditarPlanta { get; set; }


        public void OnGet(int id)
        {
            var plantas = _servicioPlantas.Obtener();
            EditarPlanta = plantas.FirstOrDefault(x => x.PlantaId == id);

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var plantas = _servicioPlantas.Obtener();
                var planta = plantas.FirstOrDefault(x => x.PlantaId == EditarPlanta.PlantaId);

                
                planta.NombreCientifico = EditarPlanta.NombreCientifico;
                planta.NombreComun = EditarPlanta.NombreComun;
                planta.CorreoEncargado = EditarPlanta.CorreoEncargado;
                planta.Categoria = EditarPlanta.Categoria;
                planta.Foto = EditarPlanta.Foto;

                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
