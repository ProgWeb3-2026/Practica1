using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica.Models;
using Practica.Servicios;

namespace Practica.Pages.Plantas
{
    public class EditModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas; //usado como paso uno para trabajos

        public EditModel(ServicioPlantas servicioPlantas)//se inicializa la pagina y se llama al constructor 
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
                planta.CorreoEncargado = Planta.CorreoEncargado;
                planta.Categoria = Planta.Categoria;
                planta.foto = Planta.foto;

                _servicioPlantas.Get().Add(Planta);
                return RedirectToPage();
            }
            return Page();
        }
    }
}
