
using PracticaRazorPages.Models;

namespace Practica1Solucion.Servicios
{
    public class ServicioPlantas
    {
        private readonly List<ModeloPlanta> _plantas;

        public ServicioPlantas()
        {
            _plantas = new List<ModeloPlanta>();

            _plantas.Add(new ModeloPlanta() { PlantaId=1, NombreComun = "Tajibo", NombreCientifico = "Tajibamnus extremus callosus", foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbp1hawrM0cyBZmA9TQ9_Pv1aSsju46OA9XHQu-V3dew&s" });

            _plantas.Add(new ModeloPlanta() { PlantaId = 2, NombreComun = "Cedro", NombreCientifico = "Cedritos", foto = "" });
        }
        public List<ModeloPlanta> Obtener()
        {
            return _plantas;
        }
    }
}
