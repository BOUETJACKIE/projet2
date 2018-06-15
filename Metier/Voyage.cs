using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BoVoyageEtape2.Metier
{
    //[Table("Voyages")]
    public class Voyage
    {
        public int Id { get; set; }

        //[ForeignKey("IdAgenceDeVoyage")]
        public virtual AgenceVoyage AgenceVoyage { get; set; }
        public int IdAgenceVoyage { get; set; }

        //[ForeignKey("IdDestination")]
        public virtual Destination Destination { get; set; }
        public int IdDestination { get; set; }

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

