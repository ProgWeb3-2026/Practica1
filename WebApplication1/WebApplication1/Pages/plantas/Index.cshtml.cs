using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.models;
using WebApplication1.servicios;

namespace WebApplication1.Pages.plantas
{
    public class IndexModel : PageModel
    {

        private readonly ServicioPlantas _servicioPlantas;

        public IndexModel(ServicioPlantas servicioPlantas)
        {
            _servicioPlantas = servicioPlantas;
        }
        public List<ModeloPlanta> plantas {  get; set; }


        public void OnGet() => plantas = _servicioPlantas.Obtener();
    }
}
