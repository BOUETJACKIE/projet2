using BoVoyage.Framework.UI;
using BoVoyageEtape2.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyageEtape2.DAL;
using BoVoyageEtape2.Metier.Services;

namespace BoVoyageEtape2.UI
{
    class ModuleGestionVoyage

    {
        private readonly ServiceVoyage serviceVoyage = new ServiceVoyage();
       





        private static readonly List<InformationAffichage> strategieAffichageVoyage =
           new List<InformationAffichage>
           {
                InformationAffichage.Creer<Voyage>(x=>x.Id, "Id", 3),
                InformationAffichage.Creer<Voyage>(x=>x.Agence, "Nom agence", 20),
                InformationAffichage.Creer<Voyage>(x=>x.Destination,"Destination", 20),
                InformationAffichage.Creer<Voyage>(x=>x.DateAller, "Date de départ", 20),
                InformationAffichage.Creer<Voyage>(x=>x.DateRetour, "Date de retour", 20),
                InformationAffichage.Creer<Voyage>(x=>x.PlacesDispo, "Places disponibles", 20),
                InformationAffichage.Creer<Voyage>(x=>x.TarifToutCompris, "Prix total", 20),

           };
        private Menu menu;

        public ModuleGestionVoyage(Application application)
        {
            this.Application = application;
        }
        private Application Application { get; }

        private void InitialiserMenu()
        {
            this.menu = new Menu("Gestion des voyages");
            this.menu.AjouterElement(new ElementMenu("1", "Afficher les voyages")
            {
                FonctionAExecuter = this.Afficher
            });
            this.menu.AjouterElement(new ElementMenu("2", "Créer un voyage")
            {
                FonctionAExecuter = this.AjouterVoyage
            });

            this.menu.AjouterElement(new ElementMenu("3", "supprimer un voyage")
            {
                FonctionAExecuter = this.Afficher
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
            ConsoleHelper.AfficherEntete("liste des voyages");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
            var liste = serviceVoyage.GetVoyages();
            ConsoleHelper.AfficherListe(liste, strategieAffichageVoyage);


        }

        public void AjouterVoyage()
        {
            
                ConsoleHelper.AfficherEntete("Nouveau Voyage");

                var voyage = new Voyage();

           


            voyage.IdAgence = ConsoleSaisie.SaisirEntierObligatoire("entrer reférence de l'agence:");

            

            voyage.IdDestination = ConsoleSaisie.SaisirEntierObligatoire("entrer reférence de la destination:");

            while (true)
            {
                voyage.DateAller = ConsoleSaisie.SaisirDateObligatoire("Date de départ: ");
               
                try
                {
                    serviceVoyage.VerifierVoyage_DateAller(voyage);
                    
                    break;
                }
                catch (MetierException e)

                {
                    ConsoleHelper.AfficherMessageErreur(e.Message);
                }
            }
            while (true)
            {
                voyage.DateRetour = ConsoleSaisie.SaisirDateObligatoire("Date de retour: ");
               
                try
                {
                    serviceVoyage.VerifierVoyage_DateRetour(voyage);
                   
                    break;
                }
                catch (MetierException e)

                {
                    ConsoleHelper.AfficherMessageErreur(e.Message);
                }
            }



            while (true)
            {


                voyage.PlacesDispo = ConsoleSaisie.SaisirEntierObligatoire("Nombre de places disponibles: ");
                try
                {
                    serviceVoyage.VerifierVoyage_PlaceDispo(voyage);
                    break;
                }
                catch (MetierException e)

                {
                    ConsoleHelper.AfficherMessageErreur(e.Message);

                }


            }

                voyage.TarifToutCompris = ConsoleSaisie.SaisirDecimalObligatoire(" tarif du voyage tout inclus:");

                //voyage.Destination = this.ServiceDestination.GetDestination(voyage.Destination);


                serviceVoyage.AjouterVoyage(voyage);
           


                

                
            

        }
    }
}
