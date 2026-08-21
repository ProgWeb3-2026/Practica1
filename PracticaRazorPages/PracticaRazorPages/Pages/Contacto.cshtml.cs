using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages
{
 
    public class ContactoModel : PageModel
    {
        [BindProperty]
        public ModeloContacto Formualario { get; set; } = new();
        public void OnGet()
        {
            
        }
        public IActionResult OnPost() 
        {
            if (ModelState.IsValid)
            {
                TempData["Mensaje"] = "FormularioEnviado";
                return RedirectToPage();
            }
            return Page();
        }
    }
}
