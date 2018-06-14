using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageEtape2.Metier
{
    public class Voyage
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public DateTime DateAller { get; set; }

        public DateTime DateRetour { get; set; }

        public int PlaceDisponibles { get; set; }

        public Decimal TarifToutCompris { get; set; }


        public void Reserver(int places)
        {
            
        }

        public override string ToString()
        {
            return $"{this.Nom} ({this.Id})";
        }
    }
}

