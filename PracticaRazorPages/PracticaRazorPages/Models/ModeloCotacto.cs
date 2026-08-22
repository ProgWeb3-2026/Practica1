using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PracticaRazorPages.Models
{
    public class ModeloCotacto
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Mensaje { get; set; }
    }
}
