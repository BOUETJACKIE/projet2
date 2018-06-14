using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageEtape2.Metier
{
    public enum EtatDossierReservation : byte { EnAttente = 1, EnCours, Refusee, Acceptee}

    public enum RaisonAnnulationDossier : byte { Client = 1, PlacesInsuffisantes }


    public class DossierReservation
    {
        public int Id { get; set; }

        public string NumeroCB { get; set; }


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
