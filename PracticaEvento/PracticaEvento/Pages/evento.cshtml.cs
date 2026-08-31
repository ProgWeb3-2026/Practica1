using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaBase.Models;
using PracticaBase.Services;
using System.Diagnostics;
namespace PracticaBase.Pages.PracticaEvento
{
    public class IndexModel : PageModel
    {
        private readonly EventoService _eventoService;
        public List<Evento> Eventos { get; set; } = new List<Evento>();
        public IndexModel(EventoService eventoService)
        {
            _eventoService = eventoService;
        }
        public void OnGet()
        {
            Eventos = _eventoService.GetAll();
        }
    }
}