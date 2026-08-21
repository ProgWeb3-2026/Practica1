using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PracticaRazorPages.Pages
{
    public class ContactoModel : PageModel
    {
        [BindProperty] 
        public string Nombre { get; set; }
        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Mensaje { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                TempData["Mensaje"] = "Formulario Enviado";
                return RedirectToPage();
            }
            return Page();
        }
    }
}