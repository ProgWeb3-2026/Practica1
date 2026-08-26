using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica.Models;
using Practica.Servicios;

namespace Practica.Pages.Plantas
{
    public class IndexModel : PageModel
    {
        private readonly ServicioPlantas _servicioPlantas; //usado como paso uno para trabajos

        public IndexModel(ServicioPlantas servicioPlantas)//se inicializa la pagina y se llama al constructor 
        {
            this._servicioPlantas = servicioPlantas;
        }
        public List<ModeloPlanta> Plantas { get; set; }

        public void OnGet()
        {
            Plantas = _servicioPlantas.Get();
        }
    }
}
