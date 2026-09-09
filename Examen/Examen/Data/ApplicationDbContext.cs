using Examen.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Examen.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<Curso> Curso { get; set; } = default!;
        public DbSet<Tarea> Tarea{ get; set; } = default!;
    }
}
