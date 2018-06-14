using BoVoyageEtape2.UI;

namespace BoVoyageEtape2
{
    class Program
    {
        static void Main(string[] args)
        {
            var application = new Application();
            application.Demarrer();
        }
        public static BaseDonnees GetBaseDonnees()
        {
            return new BaseDonnees();
        }
    }
}
