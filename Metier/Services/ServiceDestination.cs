using BoVoyage.Framework.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyageEtape2.Metier;
using BoVoyageEtape2.Metier.Services;
using BoVoyageEtape2.DAL;

namespace BoVoyageEtape2.Metier.Services
{
    class ServiceDestination
    {
        public IEnumerable<Destination> GetDestinations()
        {
            using (var dal = new BaseDeDonnees())
            {
                return dal.Destinations.ToList();
            }
        }

    }
}
