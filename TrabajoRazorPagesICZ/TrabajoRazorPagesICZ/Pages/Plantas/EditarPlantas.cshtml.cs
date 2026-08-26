using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrabajoRazorPagesICZ.Models;
using TrabajoRazorPagesICZ.Pages.Plantas.Servicios;

namespace TrabajoRazorPagesICZ.Pages.Plantas
{
    public class EditarPlantasModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;

        public EditarPlantasModel(ServicioPlantas servicioPlantas)
        {
            this._servicioPlantas = servicioPlantas;
        }

        [BindProperty]
        public ModeloPlanta Planta { get; set; }

        public int Id { get; set; }
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
                planta.NombreComun = Planta.NombreComun;
                planta.CorreoEncargado = Planta.CorreoEncargado;
                planta.Categoria = Planta.Categoria;
                planta.Foto = Planta.Foto;

                _servicioPlantas.Obtener().Add(Planta);

                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
