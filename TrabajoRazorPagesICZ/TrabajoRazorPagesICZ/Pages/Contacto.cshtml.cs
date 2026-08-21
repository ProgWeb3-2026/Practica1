using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrabajoRazorPagesICZ.Models;

namespace TrabajoRazorPagesICZ.Pages
{
    public class ContactoModel : PageModel
    {
        [BindProperty]
        public ModelContact Formulario { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid)
            {
                TempData["Mensaje"] = "Formulario enviado con exito!";
                return RedirectToPage();
            }
            return Page();
        }


    }
}
