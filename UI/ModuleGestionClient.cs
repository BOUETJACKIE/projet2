using BoVoyage.Framework.UI;
using BoVoyageEtape2.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoVoyageEtape2.UI
{
    class ModuleGestionClient
    {
        private static readonly List<InformationAffichage> strategieAffichageEntitesMetier =
          new List<InformationAffichage>
          {
                InformationAffichage.Creer<EntiteMetier>(x=>x.Id, "Id", 3),
                InformationAffichage.Creer<EntiteMetier>(x=>x.Nom, "Nom", 20),
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
                FonctionAExecuter = this.Afficher
            });

            this.menu.AjouterElement(new ElementMenu("3", "supprimer un client")
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
            ConsoleHelper.AfficherEntete("Afficher");

            Console.WriteLine("TO DO");
        }

        private void Nouveau()
        {
            ConsoleHelper.AfficherEntete("Nouveau");

            Console.WriteLine("TO DO");
        }
    }
}
