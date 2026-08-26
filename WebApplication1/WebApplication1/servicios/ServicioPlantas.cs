using WebApplication1.models;
namespace WebApplication1.servicios
{
    public class ServicioPlantas
    {
        public List<ModeloPlanta> _plantas;

        public ServicioPlantas()
        {
            _plantas = new List<ModeloPlanta>();

            _plantas.Add(new ModeloPlanta() {plantaId=1, nombrecomun = "tajibo", nombrecientifico = "tajibamus extremus ", foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBeQK6ft4o1DDAF8j0CInvPTfXqUG3TYfQQ2hfKTY0BA&s=10" });

            _plantas.Add(new ModeloPlanta() { plantaId=2, nombrecomun = "tajibo", nombrecientifico = "tajibamus extremus ", foto = "" });
        }

        public List<ModeloPlanta> Obtener()
        {
            return _plantas;
        }
    }
}
