using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Examen.Models;
using Examen.Data;

namespace Examen.Pages.CursoPages;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<Curso> Curso { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Curso = await _context.Curso.ToListAsync();
    }
}
