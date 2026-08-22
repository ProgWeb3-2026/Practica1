using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.models;

namespace PracticaRazorPages.Pages.plantas
{
    public class indexModel : PageModel
    {
        public List<Modeloplanta> plantas { get; set; }
        public void OnGet()
        {
            plantas = new List<Modeloplanta>();
            plantas.Add(new Modeloplanta() { nombrecomun = "Tajibo", nombrecientifico = "Handroanthus", foto = "https://i.pinimg.com/736x/ea/f6/09/eaf6091a38ed6e394040f1248b303464.jpg" });
            plantas.Add(new Modeloplanta() { nombrecomun = "Cedro", nombrecientifico = "Cedrela odorata", foto = "" });
        }
    }
}
