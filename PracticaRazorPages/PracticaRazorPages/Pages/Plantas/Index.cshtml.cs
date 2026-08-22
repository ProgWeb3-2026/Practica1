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
                PlantaId = 1,
                NombreComun = "Flor",
                NombreCientifico = "planta perenne",
                Categoria = "Perennes herbáceas",
                Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcROKSgL9EDhsgCP9dkjOBoH7MEgfFm0LfofpbQyF5PSCg&s=10"
            });
            Plantas.Add(new ModeloPlanta
            {
                PlantaId = 1,
                NombreComun = "Planta de jade",
                NombreCientifico = "Crassula ovata",
                Categoria = "plantas suculentas",
                Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRu2YLc-z6ZtAy8zoDYUfztcvqwomNuOEa3saPh8GYlGg&s=10"
            });

        }
    }
}
