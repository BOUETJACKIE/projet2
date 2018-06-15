namespace BoVoyageEtape2.DAL
{
    using BoVoyageEtape2.Metier;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BaseDeDonnees : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « Model1 » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « BoVoyageEtape2.Model1 » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « Model1 » dans le fichier de configuration de l'application.
        public BaseDeDonnees() : base("name=Connexion")
        {
        }

        public DbSet<Participant> Participants { get; set; }
        public DbSet<Agence> Agences { get; set; }
        public DbSet<Assurance> Assurances { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Destination> Destinations { get; set; }
       /* public DbSet<DossierReservation> DossierReservations { get; set; }
        */
        public DbSet<Voyage> Voyages { get; set; }
        

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}