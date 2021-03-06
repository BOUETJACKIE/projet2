﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageEtape2.Metier
{
    [Table("Participants")]
    public class Participant
    {
        public int Id { get; set; }

        public string Civilite { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Adresse { get; set; }

        public string Telephone { get; set; }

        public DateTime DateNaissance { get; set; }

        public int Age { get { return DateTime.Today.Year - DateNaissance.Year; } }

        public double Reduction { get; set; }
    }
}
