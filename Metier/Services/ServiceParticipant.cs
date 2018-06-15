using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyageEtape2.DAL;

namespace BoVoyageEtape2.Metier.Services
{
    class ServiceParticipant
    {
        public IEnumerable<Participant> GetParticipants()
        {
            using (var dal = new BaseDeDonnees())
            {
                return dal.Participants.ToList();
            }
        }


    }
}
