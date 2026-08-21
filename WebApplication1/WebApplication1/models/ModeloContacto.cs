using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.models
{
    public class ModeloContacto
    {
        [BindProperty]
        public string nombre {  get; set; }
        public string email { get; set; }
        public string mensaje { get; set; }
    }
}
