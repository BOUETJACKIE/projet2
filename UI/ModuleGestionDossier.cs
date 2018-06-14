using BoVoyage.Framework.UI;
using BoVoyageEtape2.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageEtape2.UI
{
    public class ModuleGestionDossier


    {
        private static readonly List<InformationAffichage> strategieAffichageEntitesMetier =
           new List<InformationAffichage>
           {
                InformationAffichage.Creer<EntiteMetier>(x=>x.Id, "Id", 3),
                InformationAffichage.Creer<EntiteMetier>(x=>x.Nom, "Nom", 20),
           };
        private Menu menu;

        public ModuleGestionDossier(Application application)
        {
            this.Application = application;
        }
        private Application Application { get; }

        private void InitialiserMenu()
        {
            this.menu = new Menu("Gestion des dossiers");
            this.menu.AjouterElement(new ElementMenu("1", "Afficher les dossiers")
            {
                FonctionAExecuter = this.Afficher
            });
            
            this.menu.AjouterElement(new ElementMenu("2", "Créer un dossier")
            {
                FonctionAExecuter = this.Nouveau
            });

            this.menu.AjouterElement(new ElementMenu("3", "Modifier un dossier")
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
