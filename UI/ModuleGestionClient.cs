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
                FonctionAExecuter = this.CreerNouveau
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
            try
            {
                ConsoleHelper.AfficherEntete("Nouveau Client");

                var client = new Client();
                client.Adresse = "eee";
                client.Civilite = "M";
                client.DateNaissance = DateTime.Today;
                client.Email = "rrr@ppp.com";
                client.Telephone = "0612345678";
                client.Prenom = "Dédé";               

                client.Nom = ConsoleSaisie.SaisirChaineObligatoire("Nom : ");
                try
                {
                    serviceClient.VerifierClient_Nom(client);
                }
                catch (MetierException e)
                {
                    ConsoleHelper.AfficherMessageErreur(e.Message);
                }




                /*
                produit.Description = ConsoleSaisie.SaisirChaine("Description: ", true);
                produit.IdCategorie = ConsoleSaisie.SaisirEntierObligatoire("Catégorie: ");

                produit.Categorie = this.serviceCategorieProduit.GetCategorie(produit.IdCategorie);

                produit.PrixJourHT = ConsoleSaisie.SaisirDecimalObligatoire("Prix du produit HT: ");
                */

                serviceClient.AjouterClient(client);

            }
            catch (MetierException e)
            {
                ConsoleHelper.AfficherMessageErreur(e.Message);
            }
            catch (Exception e)
            {
                ConsoleHelper.AfficherMessageErreur("GROS SOUCI !!");
                throw;
            }


            /*
            try
            {
                ConsoleHelper.AfficherEntete("Nouveau produit");

                var produit = new Produit();
                produit.Nom = ConsoleSaisie.SaisirChaine("Nom du produit: ", false);
                produit.Description = ConsoleSaisie.SaisirChaine("Description: ", true);
                produit.IdCategorie = ConsoleSaisie.SaisirEntierObligatoire("Catégorie: ");

                produit.Categorie = this.serviceCategorieProduit.GetCategorie(produit.IdCategorie);

                produit.PrixJourHT = ConsoleSaisie.SaisirDecimalObligatoire("Prix du produit HT: ");
                serviceProduit.AjouterProduit(produit);
            }
            catch (MetierException e)
            {
                ConsoleHelper.AfficherMessageErreur(e.Message);
            }
            catch (Exception e)
            {
                ConsoleHelper.AfficherMessageErreur("GROS PROBLEME");
                throw;
            }
            */

        }

        private void Modifier()
        {
            ConsoleHelper.AfficherEntete("Nouveau");

            Console.WriteLine("TO DO");
        }

    }
}
