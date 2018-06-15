using BoVoyageEtape2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageEtape2.Metier.Services
{
    class ServiceVoyage
    {
        public IEnumerable<Voyage> GetVoyages()
        {
            using (var dal = new BaseDeDonnees())
            {
                return dal.Voyages.Include("Destination").Include("Agence").ToList();
            }
        }
        public void VerifierVoyage_DateAller(Voyage voyage)
            {
            
             if (voyage.DateRetour < voyage.DateAller)
                {
                    throw new MetierException("ATTENTION!! La date de retour ne doit pas être antérieure à la date de départ ");
                }
             }
         public void VerifierVoyage_DateAller1 (Voyage voyage)
        {           
            if (voyage.DateAller > DateTime.Today)
            {
                throw new MetierException("Date invalide! ");
            }
        }    
         public void VerifierVoyage_DateRetour (Voyage voyage)
        {           
            if (voyage.DateRetour > DateTime.Today)
            {
                throw new MetierException("Date invalide! ");
            }
        }    
         public void VerifierVoyage_PlaceDispo (Voyage voyage)
          {
             if (voyage.PlacesDispo == 0)
                {
                    throw new MetierException("Voyage complet!!");
                }
          }

        public void AjouterVoyage(Voyage voyage)
        {


            
            using (var dal = new BaseDeDonnees())
            {
                dal.Voyages.Add(voyage);
                dal.SaveChanges();
            }
}

    }

}
