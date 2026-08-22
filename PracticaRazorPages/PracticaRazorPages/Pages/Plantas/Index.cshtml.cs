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
            Plantas.Add(new ModeloPlanta() { NombreComun = "Tajibo", NombreCientifico = "Tajibus", Foto= "https://i.pinimg.com/736x/ea/f6/09/eaf6091a38ed6e394040f1248b303464.jpg" });
            Plantas.Add(new ModeloPlanta() { NombreComun = "Cedro", NombreCientifico = "Cedrus", Foto = "" });


        }
    }
}
