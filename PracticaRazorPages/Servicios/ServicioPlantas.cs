using PracticaRazorPages.Models;

namespace PracticaRazorPages.Servicios
{
    public class ServiciosPlantas
    {
        private List<ModeloPlanta> _plantas;

        public ServiciosPlantas()
        {
            _plantas = new List<ModeloPlanta>();
            _plantas.Add(new ModeloPlanta() { NombreComun = "Almendrillo", NombreCientifico = "Dipteryx odorata", Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTGxUD9qKKwyoQdHFMd09isI88n-ODM9pyX9Fo151GbUJlM_IwPm8WzXUs&s=10" });
            _plantas.Add(new ModeloPlanta() { NombreComun = "Guayabo", NombreCientifico = "guayabus", Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT48kMa8lFyA3FLNHE84Gn5JDzNFiWHcvHEWGZLHTdIkg&s=10" });
        }

        public List<ModeloPlanta> Obtener()
        {
            return _plantas;
        }
    }
}