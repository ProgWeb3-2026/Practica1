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
            Plantas.Add(new ModeloPlanta() { NombreComun = "Tamarindo", NombreCientifico = "Tamarindosis Mortiferus", Foto = "https://th.bing.com/th/id/R.0487f9b8bb34ad92f7240330ff13a375?rik=FYCHmEmeb64btA&pid=ImgRaw&r=0" });
            Plantas.Add(new ModeloPlanta() { NombreComun = "Tajibo", NombreCientifico = "Tajibosis Antiporiusus", Foto = ""});

        }
    }
}
