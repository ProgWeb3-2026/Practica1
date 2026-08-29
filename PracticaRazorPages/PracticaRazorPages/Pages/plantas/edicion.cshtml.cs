using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.models;
using PracticaRazorPages.models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class EdicionModel : PageModel
    {
        private readonly servicioplantas _servicioPlantas; //usado como paso uno para trabajos

        public EdicionModel(servicioplantas servicioPlantas)//se inicializa la pagina y se llama al constructor 
        {
            _servicioPlantas = servicioPlantas;
        }

        [BindProperty]
        public Modeloplanta { get; set; }

        public void OnGet(int id)
        {
            var plantas = _servicioPlantas.Obtener();
            plantas = plantas.FirstOrDefault(x => x.PlantaId == id);
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var plantas = _servicioPlantas.Obtener();
                var planta = plantas.FirstOrDefault(x => x.PlantaId == Planta.PlantaId);

                planta.NombreCientifico = planta.NombreCientifico;
                planta.NombreComun = planta.NombreComun;
                planta.CorreoEncargado = planta.CorreoEncargado;
                planta.Categoria = planta.Categoria;
                planta.foto = planta.foto;


                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
