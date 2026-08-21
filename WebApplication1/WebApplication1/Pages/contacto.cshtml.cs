using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;
using WebApplication1.models;

namespace WebApplication1.Pages
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
                TempData["Mensaje"] = "Formulario enviado"; 
                return RedirectToPage(); 
            }
            return Page();
        }
    }
}
