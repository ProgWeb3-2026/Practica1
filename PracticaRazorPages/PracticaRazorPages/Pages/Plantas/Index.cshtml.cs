using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Models;
namespace PracticaRazorPages.Pages.Plantas
{
    public class IndexModel : PageModel
    {
        public List<ModeloPlanta> Plantas { get; set; }
        public void OnGet()
        {
            Plantas = new List<ModeloPlanta>();
            Plantas.Add(new ModeloPlanta() { NombreComun = "planta2", Foto = "" });
            Plantas.Add(new ModeloPlanta() { NombreComun = "planta", Foto = "https://img.magnific.com/psd-gratis/arreglo-follaje-tropical-verde-exuberante-sobre-fondo-transparente_84443-76599.jpg?semt=ais_hybrid&w=740&q=80" });
        }
    }
}
