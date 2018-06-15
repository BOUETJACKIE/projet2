using BoVoyageEtape2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyageEtape2.Metier.Services
{
    class ServiceAgence
    {
        public IEnumerable<Agence> GetAgences()
        {
            using (var dal = new BaseDeDonnees())
            {
                return dal.Agences.ToList();
            }
        }
    }
}
