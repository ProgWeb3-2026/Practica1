using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.models;
using WebApplication1.servicios;

namespace WebApplication1.Pages.plantas
{
    public class edicionModel : PageModel
    {

        public void OnGet()
        { }


                 private readonly ServicioPlantas _servicioPlantas;

                public edicionModel(ServicioPlantas servicioPlantas)
                {
                  _servicioPlantas = servicioPlantas;
                }
                [BindProperty]
                 public ModeloPlanta Planta { get; set; }
                  public void OnGet(int id)
                  {
                    var plantas = _servicioPlantas.Obtener();
                     Planta = plantas.FirstOrDefault(x => x.plantaId == id);
                  }
                public IActionResult OnPost()
                {
                         if (ModelState.IsValid)
                         {
                             var plantas = _servicioPlantas.Obtener();
                             var planta = plantas.FirstOrDefault(x => x.plantaId == Planta.plantaId);

                             planta.nombrecientifico = planta.nombrecientifico;
                             planta.nombrecomun = planta.nombrecomun;
                             planta.correoEncargado = planta.correoEncargado;
                             planta.categoria = planta.categoria;
                             planta.foto = planta.foto;


                             return RedirectToPage("index");
                         }
                          return Page();


                }
        

}   }
