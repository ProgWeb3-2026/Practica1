using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class IndexModel : PageModel
    {
        private object _context;

        public List<ModeloPlanta> ListaPlantas { get; set; }
        public void OnGet()
        {
            ListaPlantas = new List<ModeloPlanta>();
            ListaPlantas.Add(new ModeloPlanta() { NombreComun = "Toborochi", NombreCientifico = "Toborochi el mas gordo de todos", Foto= "https://server-bucket-2022.s3.amazonaws.com/travelapp/dd195afd822c21116c2f7da61ec792c6_1687126554710.jpeg" });
            ListaPlantas.Add(new ModeloPlanta() { NombreComun = "Mango", NombreCientifico = "El mango mongolia" });

        }
    }
}
