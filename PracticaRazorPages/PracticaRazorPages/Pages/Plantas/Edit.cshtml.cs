using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1Solucion.Servicios;
using PracticaRazorPages.Models;
using System.ComponentModel;

namespace PracticaRazorPages.Pages.Plantas
{
    public class EditModel : PageModel
    {
        private readonly ServicioPlantas _serviciosPlantas;

        public EditModel(ServicioPlantas servicioPlantas)
        {
            _serviciosPlantas = servicioPlantas;
        }

        [BindProperty]
        public ModeloPlanta Planta { get; set; }
        public void OnGet(int id)
        {
            var plantas = _serviciosPlantas.Obtener();
            Planta = plantas.FirstOrDefault(x => x.PlantaId == id);
        }
        public IActionResult OnPost() 
        {
            if (ModelState.IsValid) 
            {
                var plantas = _serviciosPlantas.Obtener();
                var planta = plantas.FirstOrDefault(x => x.PlantaId == Planta.PlantaId);

                planta.NombreCientifico = Planta.NombreCientifico;
                planta.NombreComun = Planta.NombreComun;
                planta.CorrreoEncargado = Planta.CorrreoEncargado;
                planta.Categoria = Planta.Categoria;
                planta.Foto = Planta.Foto;

                _serviciosPlantas.Obtener().Add(Planta);

                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}

