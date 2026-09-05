using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages
{
    public class ContactoModel : PageModel
    {
       
        [BindProperty]
        public ContactoModelo Contacto { get; set; } = new ContactoModelo();

        public void OnGet()
        {
          
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                
                TempData["Mensaje"] = "Formulario enviado con éxito.";
                return RedirectToPage();
            }

            return Page();
        }
    }
}
