using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageEtape2.Metier
{
    [Table("Destinations")]
    public class Destination
    {
        public int Id { get; set; }

        public string Continent { get; set; }

        public string Pays { get; set; }

        public string Region { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"{this.Description} ({this.Id})";
        }
    }
}
