using TrabajoRazorPagesICZ.Models;

namespace TrabajoRazorPagesICZ.Pages.Plantas.Servicios
{
    public class ServicioPlantas
    {
        public List<ModeloPlanta> _plantas;
        public ServicioPlantas() 
        {
            _plantas = new List<ModeloPlanta>();
            _plantas.Add(new ModeloPlanta() { PlantaId = 1, NombreComun = "Tajibo", NombreCientifico = "Tajibamus extremus callecius", Foto = "https://i.pinimg.com/736x/ea/f6/09/eaf6091a38ed6e394040f1248b303464.jpg" });
            _plantas.Add(new ModeloPlanta() { PlantaId = 2, NombreComun = "Farolito Chino", NombreCientifico = "Abutilon pictum", Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSn95ZzhI1raf7mxqHn6G-LSYk6DowZkOVMAe1gGolg9x1sXFHtdGdqsyc&s=10" });
        }

        public List<ModeloPlanta> Obtener()
        {
            return _plantas;
        }
    }
}
