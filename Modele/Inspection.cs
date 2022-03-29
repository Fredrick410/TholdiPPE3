using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THOLDI.Modele
{
    internal class Inspection
    {
        private int numInspection;
        private string numContainer;
        private DateTime dateInspection;
        private string commentairePostInspection;
        private string avis;
        private string libelleEtat;
        private string libelleMotif;

        public int NumInspection { get { return numInspection; } set { numInspection = value; } }
        public string NumContainer { get { return numContainer; } set { numContainer = value; } }
        public DateTime DateInspection { get { return dateInspection; } set { dateInspection = value; } }
        public string CommentairePostInspection { get { return commentairePostInspection; } set { commentairePostInspection = value; } }
        public string Avis { get { return avis; } set { avis = value; } }
        public string LibelleEtat { get { return libelleEtat; } set { libelleEtat = value; } }
        public string LibelleMotif { get { return libelleMotif; } set { libelleMotif = value; } }
    
}
}
