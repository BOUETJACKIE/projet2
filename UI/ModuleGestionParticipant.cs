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
    class ModuleGestionParticipant
    {
        private readonly ServiceParticipant serviceParticipant = new ServiceParticipant();


        private static readonly List<InformationAffichage> strategieAffichageParticipant =
        new List<InformationAffichage>
        {
            InformationAffichage.Creer<Participant>(x=>x.Id, "Id", 3),
            InformationAffichage.Creer<Participant>(x=>x.Civilite, "Civ.", 4),
            InformationAffichage.Creer<Participant>(x=>x.Nom, "Nom", 16),
            InformationAffichage.Creer<Participant>(x=>x.Prenom, "Prénom", 16),
            InformationAffichage.Creer<Participant>(x=>x.Adresse, "Adresse", 20),
            InformationAffichage.Creer<Participant>(x=>x.Telephone, "Téléphone", 16),
            InformationAffichage.Creer<Participant>(x=>x.DateNaissance, "Date naissance", 14),
            InformationAffichage.Creer<Participant>(x=>x.Age, "Age", 3),
            InformationAffichage.Creer<Participant>(x=>x.Reduction, "Réduc", 5)
        };
        private Menu menu;

        public ModuleGestionParticipant(Application application)
        {
            this.Application = application;
        }
        private Application Application { get; }

        private void InitialiserMenu()
        {
            this.menu = new Menu("Gestion des participants");
            this.menu.AjouterElement(new ElementMenu("1", "Afficher les participants")
            {
                FonctionAExecuter = this.Afficher
            });

            this.menu.AjouterElement(new ElementMenu("2", "Créer un participants")
            {
                FonctionAExecuter = this.Nouveau
            });

            this.menu.AjouterElement(new ElementMenu("3", "Modifier un participant")
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
            ConsoleHelper.AfficherEntete("Liste des participants");

            var liste = serviceParticipant.GetParticipants();
            ConsoleHelper.AfficherListe(liste, strategieAffichageParticipant);
        }

        private void Nouveau()
        {
            ConsoleHelper.AfficherEntete("Nouveau");

            Console.WriteLine("TO DO");
        }

    }
}
