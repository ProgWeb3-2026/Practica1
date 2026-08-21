using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages
{
    public class ContactoModel : PageModel
    {
        [BindProperty]
        public ContactoModelo Contacto { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            TempData["Mensaje"] = "Formulario enviado";

            return Page();
        }
    }
}
