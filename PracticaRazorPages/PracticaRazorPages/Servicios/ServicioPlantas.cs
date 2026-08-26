using PracticaRazorPages.Models;

namespace PracticaRazorPages.Servicios
{
    public class ServicioPlantas
    {
        List<ModeloPlanta> _plantas;

        public ServicioPlantas()
        {
            _plantas = new List<ModeloPlanta>();
            _plantas.Add(new ModeloPlanta() { PlantaId=1, NombreComun = "Tajibo", NombreCientifico = "Tabebuia impetiginosa", Foto = "https://tse1.mm.bing.net/th/id/OIP.Zrbr4TSZ5BJJiispnYHS_AHaEO?r=0&rs=1&pid=ImgDetMain&o=7&rm=3" });
            _plantas.Add(new ModeloPlanta() { PlantaId=2, NombreComun = "Orquidea", NombreCientifico = "Orchidaceae", Foto = "" });
        }

        public List<ModeloPlanta> Obtener()
        {
            return _plantas;
        }
    }
}
