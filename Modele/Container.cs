using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THOLDI.Modele
{
    internal class Container
    {
        private int numContainer;
        private DateTime dateAchat;
        private string typeContainer;
        private DateTime dateDerniereInsp;


        public int NumContainer
        {
            get { return numContainer; }
            set { numContainer = value; }
        }

        public DateTime DateAchat
        {
            get { return dateAchat; }
            set { dateAchat = value; }
        }

        public string TypeContainer
        {
            get { return typeContainer; }
            set { typeContainer = value; }
        }

        public DateTime DateDerniereInsp
        {
            get { return dateDerniereInsp; }
            set { dateDerniereInsp = value; }


        }
    }
}
