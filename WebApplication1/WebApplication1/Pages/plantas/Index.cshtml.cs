using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.models;

namespace WebApplication1.Pages.plantas
{
    public class IndexModel : PageModel
    {
        public List<ModeloPlanta> plantas {  get; set; }


        public void OnGet()
        {
            plantas = new List<ModeloPlanta>();

            plantas.Add(new ModeloPlanta() { nombrecomun = "tajibo", nombrecientifico = "tajibamus extremus ", foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBeQK6ft4o1DDAF8j0CInvPTfXqUG3TYfQQ2hfKTY0BA&s=10" });

            plantas.Add(new ModeloPlanta() { nombrecomun = "tajibo", nombrecientifico = "tajibamus extremus ", foto = "" });
        }
    }
}
