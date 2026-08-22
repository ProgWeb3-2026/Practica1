using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages
{
    public class ContactoModel : PageModel
    {
        [BindProperty]
        public ModeloContacto Formulario { get; set; } = new ModeloContacto();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            TempData["Mensaje"] = "Formulario enviado exitosamente";
            return RedirectToPage();
        }
    }
}