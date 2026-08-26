using Practica.Models;

namespace Practica.Servicios
{
    public class ServicioPlantas
    {
        private readonly List<ModeloPlanta> _plantas;

        public ServicioPlantas()
        {
            _plantas = new List<ModeloPlanta>();

            _plantas.Add(new ModeloPlanta() { NombreComun = "Tajibo", NombreCientifico = "Tajibamnus extremus callosus", foto = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.lostiempos.com%2Fsites%2Fdefault%2Ffiles%2Fmedia_imagen%2F2025%2F7%2F27%2F1_me_2_lopezzzzzzzzzzz.jpg&f=1&nofb=1&ipt=3ce21a094ad61015c2284bbecc21c70b4f94e04ff1cd99f9a60dff12a13db609" });

            _plantas.Add(new ModeloPlanta() { NombreComun = "Patuju", NombreCientifico = "Heliconia rostrata", foto = "" });
        }
        public List<ModeloPlanta> Get()
        {
            return _plantas;
        }
    }
}
