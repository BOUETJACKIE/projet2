using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageEtape2.Metier
{
    public enum EtatDossierReservation : byte { EnAttente, EnCours, Refusee, Acceptee}

    public enum RaisonAnnulationDossier : byte { Client = 1, PlacesInsuffisantes }

    [Table("DossierReservations")]
    public class DossierReservation
    {
        public int Id { get; set; }

        [ForeignKey("Voyage")]
        public virtual Voyage Voyage { get; set; }
        public int IdVoyage { get; set; }

        [ForeignKey("IdAgenceDeVoyage")]
        public virtual AgenceVoyage AgenceVoyage { get; set; }
        public int IdAgenceVoyage { get; set; }
     
        [ForeignKey("IdClient")]
        public virtual Client Client { get; set; }
        public int IdClient { get; set; }

        public string NumeroCB { get; set; }

        public virtual ICollection<Participant> Participants { get; set; }

        public virtual ICollection<Assurance> Assurances { get; set; }

        public EtatDossierReservation Etat { get; set; }


        public decimal PrixTotal { get { return 0; } }

        

        public void Annuler(RaisonAnnulationDossier raison)
        {

        }

        public void ValiderSolvabilite()
        {

        }

        public void Accepter()
        {

        }

        public override string ToString()
        {
            return $"{this.NumeroCB} ({this.Id})";
        }

    }
}
