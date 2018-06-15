using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyageEtape2.DAL;

namespace BoVoyageEtape2.Metier.Services
{
    class ServiceClient
    {
        public IEnumerable<Client> GetClients()
        {
            using (var dal = new BaseDeDonnees())
            {
                return dal.Clients.ToList();
            }
        }

        public void VerifierClient_Nom(Client client)
        {
            // client.Nom


            if (String.IsNullOrEmpty(client.Nom))
            {
                throw new MetierException("Le Nom ne doit pas être vide");
            }


        }


        public void AjouterClient(Client client)
        {


            // Ecriture en base
            using (var dal = new BaseDeDonnees())
            {
                dal.Clients.Add(client);
                dal.SaveChanges();
            }


            /*
            // Validation
            if (produit.PrixJourHT <= 0)
            {
                throw new MetierException("Le prix ne doit pas être négatif ou 0. Retour au menu.");
            }

            if (produit.Categorie == null)
            {
                throw new MetierException("Catégorie invalide. Retour au menu.");
            }

            // Ecriture en base
            using (var dal = new BaseDonnees())
            {
                dal.Produits.Add(produit);
                dal.SaveChanges();
            }

    */
        }

    }
}
