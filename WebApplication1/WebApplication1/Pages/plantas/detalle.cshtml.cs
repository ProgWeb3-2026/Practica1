using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.models;
using WebApplication1.servicios;

namespace WebApplication1.Pages.plantas
{
    public class detalleModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas;

        public detalleModel(ServicioPlantas servicioPlantas)
        {
            _servicioPlantas = servicioPlantas;
        }
        public ModeloPlanta planta {  get; set; }


        public void OnGet(int id)
        {
            var plantas = _servicioPlantas.Obtener();
            planta = plantas.FirstOrDefault(x => x.plantaId == id);
        }
    }
}
