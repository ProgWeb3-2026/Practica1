using PracticaRazorPages.Models;

namespace PracticaRazorPages.Servicios
{
    public class ServiciosPlantas
    {
        public List<ModeloPlanta> _plantas;
        public ServiciosPlantas() 
        {
            _plantas = new List<ModeloPlanta>();
            _plantas.Add(new ModeloPlanta() {PlantaID=1, NombreComun = "Toborochi", NombreCientifico = "Toborochi el mas gordo de todos", Foto = "https://server-bucket-2022.s3.amazonaws.com/travelapp/dd195afd822c21116c2f7da61ec792c6_1687126554710.jpeg" });
            _plantas.Add(new ModeloPlanta() {PlantaID=2, NombreComun = "Mango", NombreCientifico = "El mango mongolia", Foto= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRYfGFslRrQMJ67YRFrPqzy_VpbUXbzNi0kK1dS37Me-dMh319QEmv-I1jJ&s=10" });
        }

        public List<ModeloPlanta> Obtener()
        {
            return _plantas;
        }
        
    }
}
