using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageEtape2.Metier
{
    public enum CivilitePersonne : byte { Madame = 1, Monsieur, Mademoiselle}

    public class Personne
    {
        public int Id { get; set; }

        public CivilitePersonne Civilite { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Adresse { get; set; }

        public string Telephone { get; set; }

        public DateTime DateNaissance { get; set; }

        public int Age { get { return DateTime.Today.Year - DateNaissance.Year; } }


        public override string ToString()
        {
            return $"{this.Nom} ({this.Id})";
        }
    }
}
