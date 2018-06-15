using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageEtape2.Metier
{
    [Table("Agences")]
    public class Agence
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Adresse { get; set; }

        public string Telephone { get; set; }


        public override string ToString()
        {
            return $"{this.Nom}";
        }
    }
}
