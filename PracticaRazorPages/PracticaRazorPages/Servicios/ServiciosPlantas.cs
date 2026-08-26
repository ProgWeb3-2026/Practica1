using PracticaRazorPages.Models;

namespace Practica1Solucion.Servicios
{
    public class ServicioPlantas
    {
        private readonly List<ModeloPlanta> _plantas;

        public ServicioPlantas()
        {
            _plantas = new List<ModeloPlanta>();
            _plantas.Add(new ModeloPlanta() {PlantaId=1, NombreComun = "Tamarindo", NombreCientifico = "Tamarindosis Mortiferus", Foto = "https://th.bing.com/th/id/R.0487f9b8bb34ad92f7240330ff13a375?rik=FYCHmEmeb64btA&pid=ImgRaw&r=0" });
            _plantas.Add(new ModeloPlanta() {PlantaId=2, NombreComun = "Tajibo", NombreCientifico = "Tajibosis Antiporiusus", Foto = "" });
        }


        public List<ModeloPlanta> Obtener()
        {
            return _plantas;
        }
    }
}
