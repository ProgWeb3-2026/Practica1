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
                // 1. Obtienes el listado completo de la base de datos/servicio
                var listaPlantas = _servicioPlantas.Obtener();

                // 2. Buscas la planta específica que coincide con el ID enviado por el formulario
                var plantaBd = listaPlantas.First(x => x.PlantaId == Planta.PlantaId);

                // 3. Le pasas los datos del formulario (Planta) al objeto de la Base de Datos (plantaBd)
                plantaBd.NombreCientifico = Planta.NombreCientifico;
                plantaBd.NombreComun = Planta.NombreComun;
                plantaBd.CorreoEncargado = Planta.CorreoEncargado;
                plantaBd.Categoria = Planta.Categoria;
                plantaBd.Foto = Planta.Foto;

                // 4. (Opcional) Recuerda guardar los cambios en tu servicio si es necesario
                // _servicioPlantas.GuardarCambios(); 

                return RedirectToPage("Index");
            }


            return Page();
        }
    }
}
