using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageEtape2.Metier
{
    [Table("Participants")]
    public class Participant : Personne
    {
        float Reduction { get; set; }
    }
}
