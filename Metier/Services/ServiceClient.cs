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
            client.Nom = client.Nom.Trim();

            if (String.IsNullOrEmpty(client.Nom))
            {
                throw new MetierException("Le nom ne doit pas être vide");
            }
        }

        public void VerifierClient_Prenom(Client client)
        {
            client.Prenom = client.Prenom.Trim();

            if (String.IsNullOrEmpty(client.Prenom))
            {
                throw new MetierException("Le prénom ne doit pas être vide");
            }
        }

        public void VerifierClient_Adresse(Client client)
        {
            client.Adresse = client.Adresse.Trim();

            if (String.IsNullOrEmpty(client.Adresse))
            {
                throw new MetierException("L'adresse ne doit pas être vide");
            }
        }

        public void VerifierClient_Telephone(Client client)
        {
            client.Telephone = client.Telephone.Trim();

            if (String.IsNullOrEmpty(client.Telephone))
            {
                throw new MetierException("Le téléphone ne doit pas être vide");
            }
        }

        public void VerifierClient_DateNaissance(Client client)
        {           
            if (client.DateNaissance > DateTime.Today)
            {
                throw new MetierException("Souci de Date de naissance postérieure à aujourd'hui ! ");
            }
        }

        public void VerifierClient_Email(Client client)
        {
            client.Email = client.Telephone.Trim();

            if (String.IsNullOrEmpty(client.Email))
            {
                throw new MetierException("Le Email ne doit pas être vide");
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
        }

    }
}
