using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Framework.UI;
using BoVoyageEtape2.Metier;
using BoVoyageEtape2.Metier.Services;


namespace BoVoyageEtape2.UI
{
    class ModuleGestionClient
    {
        private readonly ServiceClient serviceClient = new ServiceClient();

        private static readonly List<InformationAffichage> strategieAffichageClient =
          new List<InformationAffichage>
          {
                InformationAffichage.Creer<Client>(x=>x.Id, "Id", 3),
                InformationAffichage.Creer<Client>(x=>x.Civilite, "Civ.", 4),
                InformationAffichage.Creer<Client>(x=>x.Nom, "Nom", 16),
                InformationAffichage.Creer<Client>(x=>x.Prenom, "Prénom", 16),
                InformationAffichage.Creer<Client>(x=>x.Adresse, "Adresse", 20),
                InformationAffichage.Creer<Client>(x=>x.Telephone, "Téléphone", 16),
                InformationAffichage.Creer<Client>(x=>x.DateNaissance, "Date naissance", 14),
                InformationAffichage.Creer<Client>(x=>x.Age, "Age", 3),
                InformationAffichage.Creer<Client>(x=>x.Email, "Email", 16)
          };
        private Menu menu;

        public ModuleGestionClient(Application application)
        {
            this.Application = application;
        }
        private Application Application { get; }

        private void InitialiserMenu()
        {
            this.menu = new Menu("Gestion des Clients");
            this.menu.AjouterElement(new ElementMenu("1", "Afficher les clients")
            {
                FonctionAExecuter = this.Afficher
            });
            this.menu.AjouterElement(new ElementMenu("2", "Créer un client")
            {
                FonctionAExecuter = this.CreerNouveau
            });

            this.menu.AjouterElement(new ElementMenu("3", "Modifier un client")
            {
                FonctionAExecuter = this.Modifier
            });


            this.menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu principal..."));
        }
        public void Demarrer()
        {
            if (this.menu == null)
            {
                this.InitialiserMenu();
            }

            this.menu.Afficher();
        }

        private void Afficher()
        {
            ConsoleHelper.AfficherEntete("Afficher");

            var liste = serviceClient.GetClients();
            ConsoleHelper.AfficherListe(liste, strategieAffichageClient);
        }

        private void CreerNouveau()
        {
            ConsoleHelper.AfficherEntete("Nouveau Client");

            var client = new Client();
 
            // On s'aide un peu de l'interface pour celui la...
            int civilite = 0;
            while (civilite == 0)
            {
                civilite = ConsoleSaisie.SaisirEntierObligatoire("Civilité (1:Madame 2:Monsieur) : ");
                if (civilite == 1) { client.Civilite = "Mme"; break; }
                if (civilite == 2) { client.Civilite = "M"; break; }
                civilite = 0;
                ConsoleHelper.AfficherMessageErreur("Réponse invalide ! ");
            }

            // !!! ConsoleSaisie.SaisirChaineObligatoire peut renvoyer des blancs !!!
            // Validation Nom
            while (true)
            {
                client.Nom = ConsoleSaisie.SaisirChaineObligatoire("Nom : ");
                try
                {
                    serviceClient.VerifierClient_Nom(client);
                    break;
                }
                catch (MetierException e)
                {
                    ConsoleHelper.AfficherMessageErreur(e.Message);
                }
            }

            // Validation Prénom
            while (true)
            {
                client.Prenom = ConsoleSaisie.SaisirChaineObligatoire("Prénom : ");
                try
                {
                    serviceClient.VerifierClient_Prenom(client);
                    break;
                }
                catch (MetierException e)
                {
                    ConsoleHelper.AfficherMessageErreur(e.Message);
                }
            }

            // Validation Date de naissance
            while (true)
            {
                client.DateNaissance = ConsoleSaisie.SaisirDateObligatoire("Date de naissance : ");
                try
                {
                    serviceClient.VerifierClient_DateNaissance(client);
                    break;
                }
                catch (MetierException e)
                {
                    ConsoleHelper.AfficherMessageErreur(e.Message);
                }
            }

            // Validation Adresse
            while (true)
            {
                client.Adresse = ConsoleSaisie.SaisirChaineObligatoire("Adresse : ");
                try
                {
                    serviceClient.VerifierClient_Adresse(client);
                    break;
                }
                catch (MetierException e)
                {
                    ConsoleHelper.AfficherMessageErreur(e.Message);
                }
            }

            // Validation Telephone
            while (true)
            {
                client.Telephone = ConsoleSaisie.SaisirChaineObligatoire("Telephone : ");
                try
                {
                    serviceClient.VerifierClient_Telephone(client);
                    break;
                }
                catch (MetierException e)
                {
                    ConsoleHelper.AfficherMessageErreur(e.Message);
                }
            }

            // Validation Email
            while (true)
            {
                client.Email = ConsoleSaisie.SaisirChaineObligatoire("Email : ");
                try
                {
                    serviceClient.VerifierClient_Email(client);
                    break;
                }
                catch (MetierException e)
                {
                    ConsoleHelper.AfficherMessageErreur(e.Message);
                }
            }

            string confirme = ConsoleSaisie.SaisirChaineObligatoire("CONFIRMER CREATION CLIENT (Entrer 'O') ?").ToUpper();
            if (confirme == "O")
            {
                serviceClient.AjouterClient(client);
                Console.WriteLine("Client Crée !");
            }
            else
            {
                Console.WriteLine("Opération abandonnée !");
            }
        }

        private void Modifier()
        {
            ConsoleHelper.AfficherEntete("Modifier un Client");

            var liste = serviceClient.GetClients();
            ConsoleHelper.AfficherListe(liste, strategieAffichageClient);


            int idClient = ConsoleSaisie.SaisirEntierObligatoire("Saisir le numéro de client");


            Client client = serviceClient.GetClient(idClient);
            if (client == null)
            {
                Console.WriteLine("Client invalide !");
                return;
            }


            string confirme = ConsoleSaisie.SaisirChaineObligatoire($"Modifier Adresse ? (Entrer O) Acturelle( {client.Adresse} )").ToUpper();
            if (confirme == "O")
            {
                // Validation Adresse
                while (true)
                {
                    client.Adresse = ConsoleSaisie.SaisirChaineObligatoire("Adresse : ");
                    try
                    {
                        serviceClient.VerifierClient_Adresse(client);
                        break;
                    }
                    catch (MetierException e)
                    {
                        ConsoleHelper.AfficherMessageErreur(e.Message);
                    }
                }

                serviceClient.ModifierClient(client);
            }

            confirme = ConsoleSaisie.SaisirChaineObligatoire($"Modifier Telephone ? (Entrer O) Acturelle( {client.Telephone} )").ToUpper();
            if (confirme == "O")
            {
                // Validation Adresse
                while (true)
                {
                    client.Telephone = ConsoleSaisie.SaisirChaineObligatoire("Téléphone : ");
                    try
                    {
                        serviceClient.VerifierClient_Telephone(client);
                        break;
                    }
                    catch (MetierException e)
                    {
                        ConsoleHelper.AfficherMessageErreur(e.Message);
                    }
                }

                serviceClient.ModifierClient(client);
            }

            confirme = ConsoleSaisie.SaisirChaineObligatoire($"Modifier Email ? (Entrer O) Acturelle( {client.Email} )").ToUpper();
            if (confirme == "O")
            {
                // Validation Adresse
                while (true)
                {
                    client.Email = ConsoleSaisie.SaisirChaineObligatoire("Email : ");
                    try
                    {
                        serviceClient.VerifierClient_Email(client);
                        break;
                    }
                    catch (MetierException e)
                    {
                        ConsoleHelper.AfficherMessageErreur(e.Message);
                    }
                }

                serviceClient.ModifierClient(client);
            }


        }




    }
}
