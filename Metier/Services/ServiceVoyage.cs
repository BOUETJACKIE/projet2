using BoVoyageEtape2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageEtape2.Metier.Services
{
    class ServiceVoyage
    {
        public IEnumerable<Voyage> GetVoyages()
        {
            using (var dal = new BaseDeDonnees())
            {
                return dal.Voyages.Include("Destination").ToList();
            }
        }
    }

}
