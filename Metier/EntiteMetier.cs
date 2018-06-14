namespace ExempleUtilisationBoVoyageFramework.Metier
{
    public class EntiteMetier
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public override string ToString()
        {
            return $"{this.Nom} ({this.Id})";
        }
    }
}
