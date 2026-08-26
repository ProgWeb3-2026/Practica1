
using PracticaRazorPages.Models;

namespace Practica1Solucion.Servicios
{
    public class ServicioPlantas
    {
        private readonly List<ModeloPlanta> _plantas;

        public ServicioPlantas()
        {
            _plantas = new List<ModeloPlanta>();

            _plantas.Add(new ModeloPlanta
            {
                PlantaId = 1,NombreComun = "Flor",NombreCientifico = "planta perenne",Categoria = "Perennes herbáceas",Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcROKSgL9EDhsgCP9dkjOBoH7MEgfFm0LfofpbQyF5PSCg&s=10"
            });
            _plantas.Add(new ModeloPlanta
            {
                PlantaId = 1,NombreComun = "Planta de jade",NombreCientifico = "Crassula ovata",Categoria = "plantas suculentas",Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRu2YLc-z6ZtAy8zoDYUfztcvqwomNuOEa3saPh8GYlGg&s=10"
            });

        }
        public List<ModeloPlanta> Obtener()
        {
            return _plantas;
        }
    }
}
