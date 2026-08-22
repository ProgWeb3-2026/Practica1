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
            Plantas.Add(new ModeloPlanta
            {
                NombreComun = "Cactus",
                NombreCientifico = "Cactaceae",
                Categoria = "Taxonómica de los Cactus",
                CorreoEncargado = "Juan Perez",
            });
            Plantas.Add(new ModeloPlanta
            {
                NombreComun = "Planta",
                NombreCientifico = "Plantous",
                Categoria = "Lanza Manga",
                CorreoEncargado = "Juan Perez",
                Foto = "https://images.pexels.com/photos/32331043/pexels-photo-32331043.jpeg?_gl=1*13nszie*_ga*Mzk0NDAwODg1LjE3ODczNjA1MDQ.*_ga_8JE65Q40S6*czE3ODczNjA1MDQkbzEkZzEkdDE3ODczNjE3MDIkajU1JGwwJGgw",
            });
            Plantas.Add(new ModeloPlanta
            {
                NombreComun = "Planta",
                NombreCientifico = "Plantous",
                Categoria = "Lanza Manga",
                CorreoEncargado = "Juan Perez",
                Foto = "https://images.pexels.com/photos/32331043/pexels-photo-32331043.jpeg?_gl=1*13nszie*_ga*Mzk0NDAwODg1LjE3ODczNjA1MDQ.*_ga_8JE65Q40S6*czE3ODczNjA1MDQkbzEkZzEkdDE3ODczNjE3MDIkajU1JGwwJGgw",
            });
            Plantas.Add(new ModeloPlanta
            {
                NombreComun = "Planta",
                NombreCientifico = "Plantous",
                Categoria = "Lanza Manga",
                CorreoEncargado = "Juan Perez",
                Foto = "https://images.pexels.com/photos/32331043/pexels-photo-32331043.jpeg?_gl=1*13nszie*_ga*Mzk0NDAwODg1LjE3ODczNjA1MDQ.*_ga_8JE65Q40S6*czE3ODczNjA1MDQkbzEkZzEkdDE3ODczNjE3MDIkajU1JGwwJGgw",
            });
        }
    }
}
