using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaRazorPages.Models;

namespace PracticaRazorPages.Pages;

public class ContactoModel : PageModel
{
    [BindProperty]
    public ModeloCotacto Formulario { get; set; }


    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            TempData["Mensaje"] = "Formulario Enviado";
            return Page();
        }
        return Page();
    }
}
