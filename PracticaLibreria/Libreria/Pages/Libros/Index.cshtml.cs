using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Libreria.Data;
using Libreria.Models;

namespace Libreria.Pages.Libros
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Libro> Libro { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Libro = await _context.Libros.ToListAsync();
        }
    }
}