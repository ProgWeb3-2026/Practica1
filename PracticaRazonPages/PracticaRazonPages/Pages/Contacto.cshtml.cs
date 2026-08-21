using PracticaRazonPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PracticaRazonPages.Pages;

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
            TempData["Mensaje"] = "Formulario Enviado";
            return RedirectToPage();

        }
        return Page();
    }
}