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
            ListaPlantas.Add(new ModeloPlanta()
            { NombreComun = "almendrillo", NombreCientifico = "Dipteryx odorata", Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTGxUD9qKKwyoQdHFMd09isI88n-ODM9pyX9Fo151GbUJlM_IwPm8WzXUs&s=10" });
        }
    }
}
