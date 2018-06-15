using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoVoyageEtape2.Metier
{
    public class MetierException : Exception
    {
        public MetierException(string message) : base(message)
        {
        }
    }
}