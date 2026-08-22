using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.models;

namespace PracticaRazorPages.Pages
{
    public class contactoModel : PageModel
    {
        [BindProperty] 
        public ModeloContacto formulario {  get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                TempData["mensaje"] ="formulario enviado";
                return RedirectToPage();
            }
            return Page();
        }
    }
}
