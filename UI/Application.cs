using System;
using BoVoyage.Framework.UI;

namespace BoVoyageEtape2.UI
{
    public class Application
    {
        private Menu menuPrincipal;
        private ModuleGestionClient moduleGestionClient;
        private ModuleGestionParticipant moduleGestionParticipant;
        private ModuleGestionDossier moduleGestionDossier;
        private ModuleGestionVoyage moduleGestionVoyage;

        private void InitialiserModules()
        {
            this.moduleGestionClient = new ModuleGestionClient(this);
            this.moduleGestionDossier = new ModuleGestionDossier(this);
            this.moduleGestionVoyage = new ModuleGestionVoyage(this);
            this.moduleGestionParticipant = new ModuleGestionParticipant(this);
        }

        private void InitialiserMenuPrincipal()
        {
            this.menuPrincipal = new Menu("Menu principal");
            this.menuPrincipal.AjouterElement(new ElementMenu("1", "Gestion des clients")
            {
                AfficherLigneRetourMenuApresExecution = false,
                FonctionAExecuter = this.moduleGestionClient.Demarrer
            });
            this.menuPrincipal.AjouterElement(new ElementMenu("2", "Gestion des Participants")
            {
                AfficherLigneRetourMenuApresExecution = false,
                FonctionAExecuter = this.moduleGestionParticipant.Demarrer
            });
            this.menuPrincipal.AjouterElement(new ElementMenu("3", "Gestion des voyages")
            {
                AfficherLigneRetourMenuApresExecution = false,
                FonctionAExecuter = this.moduleGestionVoyage.Demarrer
            });
            this.menuPrincipal.AjouterElement(new ElementMenu("4", "Gestion des dossiers")
            {
                AfficherLigneRetourMenuApresExecution = false,
                FonctionAExecuter = this.moduleGestionDossier.Demarrer
            });
            this.menuPrincipal.AjouterElement(new ElementMenuQuitterMenu("Q", "Quitter")
            {
                FonctionAExecuter = () => Environment.Exit(1)
            });
        }

        public void Demarrer()
        {
            this.InitialiserModules();
            this.InitialiserMenuPrincipal();

            this.menuPrincipal.Afficher();
        }
    }
}
