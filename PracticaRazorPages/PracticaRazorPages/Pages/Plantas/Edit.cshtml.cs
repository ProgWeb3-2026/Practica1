using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Models;
using PracticaRazorPages.Servicios;

namespace PracticaRazorPages.Pages.Plantas
{
    public class EditModel : PageModel
    {
        private readonly ServiciosPlantas _servicioPlantas;

        public EditModel(ServiciosPlantas serviciosPlantas)
        {
            _servicioPlantas = serviciosPlantas;
        }

        [BindProperty]
        public ModeloPlanta Planta { get; set; } = new ModeloPlanta();

        public void OnGet(int id)
        {
            var plantas = _servicioPlantas.Obtener();
            Planta = plantas.FirstOrDefault(x => x.PlantaID == id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var plantas = _servicioPlantas.Obtener();
                var planta = plantas.FirstOrDefault(x => x.PlantaID == Planta.PlantaID);

                if (planta == null)
                {
                    return NotFound();
                }

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
