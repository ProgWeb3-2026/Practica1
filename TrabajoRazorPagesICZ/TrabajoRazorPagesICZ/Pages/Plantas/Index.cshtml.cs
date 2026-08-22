using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrabajoRazorPagesICZ.Models;

namespace TrabajoRazorPagesICZ.Pages.Plantas
{
    public class IndexModel : PageModel
    {
        public List<ModeloPlanta> ListaPlantas { get; set; }
        public void OnGet()
        {
            ListaPlantas = new List<ModeloPlanta>();
            ListaPlantas.Add(new ModeloPlanta() { NombreComun = "Tajibo", NombreCientifico = "Tajibamus extremus callecius", Foto = "https://i.pinimg.com/736x/ea/f6/09/eaf6091a38ed6e394040f1248b303464.jpg" });
            ListaPlantas.Add(new ModeloPlanta() { NombreComun = "Farolito Chino", NombreCientifico = "Abutilon pictum", Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSn95ZzhI1raf7mxqHn6G-LSYk6DowZkOVMAe1gGolg9x1sXFHtdGdqsyc&s=10" });
        }
    }
}
