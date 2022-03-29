using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THOLDI.Modele
{
    internal class Decision
    {
        private int numInspection;
        private int numContainer;
        private string codeTravaux;
        private DateTime dateEnvoi;
        private DateTime dateRetour;
        private string commentaireDecision;


        public int NumInspection { get { return numInspection; } set { numInspection = value; } }
        public int NumContainer { get { return numContainer; } set { numContainer = value; } }
        public string CodeTravaux { get { return codeTravaux; } set { codeTravaux = value; } }
        public DateTime DateEnvoi { get { return dateEnvoi; } set { dateEnvoi = value; } }
        public DateTime DateRetour { get { return dateRetour; } set { dateRetour = value; } }
        public string CommentaireDecision { get { return commentaireDecision; } set { commentaireDecision = value; } }
    }
}
