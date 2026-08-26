
using PracticaRazorPages.Models;

namespace Practica1Solucion.Servicios
{
    public class ServicioPlantas
    {
        private readonly List<ModeloPlanta> _plantas;

        public ServicioPlantas()
        {
            _plantas = new List<ModeloPlanta>();

            _plantas.Add(new ModeloPlanta() { PlantaId = 1 ,NombreComun = "Tajibo", NombreCientifico = "Tajibamnus extremus callosus", Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbp1hawrM0cyBZmA9TQ9_Pv1aSsju46OA9XHQu-V3dew&s" });

            _plantas.Add(new ModeloPlanta() {
                PlantaId =2 ,
                NombreComun = "Planta",
                NombreCientifico = "Plantous",
                Categoria = "Lanza Manga",
                CorreoEncargado = "Juan Perez",
                Foto = "https://images.pexels.com/photos/32331043/pexels-photo-32331043.jpeg?_gl=1*13nszie*_ga*Mzk0NDAwODg1LjE3ODczNjA1MDQ.*_ga_8JE65Q40S6*czE3ODczNjA1MDQkbzEkZzEkdDE3ODczNjE3MDIkajU1JGwwJGgw",
            });
        }
        public List<ModeloPlanta> Get()
        {
            return _plantas;
        }
    }
}
