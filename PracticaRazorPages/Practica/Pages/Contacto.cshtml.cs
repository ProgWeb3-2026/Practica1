using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica.Models;

namespace Practica.Pages
{
    public class ContactoModel : PageModel
    {
        [BindProperty]
        public ModeloContacto Formulario { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                TempData["Mensaje"] = "Formulario enviado";
                return RedirectToPage();
            }
            return Page();
        }
    }
}
