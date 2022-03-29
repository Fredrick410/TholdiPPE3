using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THOLDI.Modele
{
    internal class Travaux
    {

        private string codeTravaux;
        private string libelleTravaux;
        private long dureeImobilisation;

        public string CodeTravaux { get { return codeTravaux; } set { codeTravaux = value; } }
        public string LibelleTravaux { get { return libelleTravaux; } set { libelleTravaux = value; } }
        public long DureeImobilisation { get { return dureeImobilisation; } set { dureeImobilisation = value; } }
    
}
}
