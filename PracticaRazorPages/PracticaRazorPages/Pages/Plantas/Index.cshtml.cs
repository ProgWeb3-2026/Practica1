using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages.Plantas
{
    public class IndexModel : PageModel
    {
        public List<ModeloPlanta> Plantas {  get; set; }

        public void OnGet()
        {
            Plantas = new List<ModeloPlanta>();
            Plantas.Add(new ModeloPlanta() { NombreComun = "Tajibo", NombreCientifico = "Tajibamos extremus callosus", Foto = "https://i.pinimg.com/736x/29/bc/33/29bc33a36a69456381042150fe5f13be.jpg" });
            Plantas.Add(new ModeloPlanta() { NombreComun = "Diente de Leon", NombreCientifico = "Dienteu de Leonosis", Foto = "" });
        }
    }
}
