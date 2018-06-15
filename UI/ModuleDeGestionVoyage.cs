using BoVoyage.Framework.UI;
using BoVoyageEtape2.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyageEtape2.DAL;

namespace BoVoyageEtape2.UI
{
    class ModuleGestionVoyage
    {
        private static readonly List<InformationAffichage> strategieAffichageVoyage =
           new List<InformationAffichage>
           {
                InformationAffichage.Creer<Voyage>(x=>x.Id, "Id", 3),
                InformationAffichage.Creer<Voyage>(x=>x.IdAgenceVoyage, "référence agence", 3),
                InformationAffichage.Creer<Voyage>(x=>x.IdDestination, "eéférence Destination", 20),
                InformationAffichage.Creer<Voyage>(x=>x.DateAller, "Date de départ", 20),
                InformationAffichage.Creer<Voyage>(x=>x.DateRetour, "Date de retour", 20),
                InformationAffichage.Creer<Voyage>(x=>x.PlaceDisponibles, "Places disponibles", 20),
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
                FonctionAExecuter = this.Afficher
            });

            this.menu.AjouterElement(new ElementMenu("3", "supprimer un voyage")
            {
                FonctionAExecuter = this.Nouveau
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

       
        }

        private void Nouveau()
        {
            ConsoleHelper.AfficherEntete("Nouveau");

            Console.WriteLine("TO DO");
        }

    }
}
