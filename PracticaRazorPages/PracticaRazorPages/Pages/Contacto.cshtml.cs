using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages
{
    public class ContactoModel : PageModel
    {
        [BindProperty]
        public ModeloContacto Formulario { get; set; } = new();

        public void OnGet()
        {

        }

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid)
            {
                TempData["Mensajes"] = "Formulario enviado";
                return RedirectToPage();

            }
            
            return Page();

        }
    }
}
