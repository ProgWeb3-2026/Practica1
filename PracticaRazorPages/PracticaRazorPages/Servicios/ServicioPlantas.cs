using PracticaRazorPages.Models;

namespace Practica1Solucion.Servicios
{
    public class ServicioPlantas
    {
        private readonly List<ModeloPlanta> _plantas;

        public ServicioPlantas()
        {
            _plantas = new List<ModeloPlanta>();

            _plantas.Add(new ModeloPlanta() { NombreComun = "Tajibo", NombreCientifico = "Tajibamnus extremus callosus", Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbp1hawrM0cyBZmA9TQ9_Pv1aSsju46OA9XHQu-V3dew&s" });

            _plantas.Add(new ModeloPlanta() { NombreComun = "Cedro", NombreCientifico = "Cedritos", Foto = "" });
        }
        public List<ModeloPlanta> Obtener()
        {
            return _plantas;
        }
    }
}
