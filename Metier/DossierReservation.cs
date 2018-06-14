using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageEtape2.Metier
{
    public class DossierReservation
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public override string ToString()
        {
            return $"{this.Nom} ({this.Id})";
        }

    }
}
