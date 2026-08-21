using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages
{
    public class ContactoModel : PageModel
    {
        [BindProperty]
        public  ModeloContacto Formulario { get; set; }
        public string Nombre { get; set; }
         
        public string Email { get; set; }

        public string Mensaje { get; set; }
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
