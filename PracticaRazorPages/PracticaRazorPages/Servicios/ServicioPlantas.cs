using PracticaRazorPages.Models;

namespace Practica1Solucion.Servicios
{
    public class ServicioPlantas
    {
        private readonly List<ModeloPlanta> _plantas;

        public ServicioPlantas()
        {
            _plantas = new List<ModeloPlanta>();

            
            _plantas.Add(new ModeloPlanta() { PlantaId=1, NombreComun = "Tajibo", NombreCientifico = "Tajibamos extremus callosus", Foto = "https://i.pinimg.com/736x/29/bc/33/29bc33a36a69456381042150fe5f13be.jpg" });
            _plantas.Add(new ModeloPlanta() { PlantaId=2, NombreComun = "Diente de Leon", NombreCientifico = "Dienteu de Leonosis", Foto = "" });
        }

        
        public List<ModeloPlanta> Obtener()
        {
            return _plantas;
        }
    }
}
