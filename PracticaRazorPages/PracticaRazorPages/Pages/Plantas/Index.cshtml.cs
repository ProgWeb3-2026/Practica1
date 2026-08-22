using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class IndexModel : PageModel
    {
        public List<ModeloPlanta> ListaPlantas { get; set; }

        public void OnGet()
        {
            ListaPlantas = new List<ModeloPlanta>();
            ListaPlantas.Add(new ModeloPlanta() { NombreComun = "Tajibo", NombreCientifico = "Tabebuia impetiginosa", Foto = "https://tse1.mm.bing.net/th/id/OIP.Zrbr4TSZ5BJJiispnYHS_AHaEO?r=0&rs=1&pid=ImgDetMain&o=7&rm=3" });
            ListaPlantas.Add(new ModeloPlanta() { NombreComun = "Orquidea", NombreCientifico = "Orchidaceae", Foto = "" });
        }
    }
}
