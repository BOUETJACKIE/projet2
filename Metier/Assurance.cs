using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageEtape2.Metier
{
    [Table("Assurances")]
    public class Assurance
    {
        public int Id { get; set; }

        public string Designation { get; set; }

        public override string ToString()
        {
            return $"{this.Designation} ({this.Id})";
        }
    }
}
