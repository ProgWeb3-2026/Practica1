using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Libreria.Models; 
namespace Libreria.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Libro> Libros { get; set; } = default!;
        public DbSet<Prestamo> Prestamos { get; set; } = default!;
        public DbSet<Usuario> Usuarios { get; set; } = default!;
    }
}
