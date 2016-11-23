using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAstronaute
{
    class Perception
    {
        public virtual int compteur
        {
            get;
            set;
        }

        public virtual int nbCarres
        {
            get;
            set;
        }

        public virtual int nbRonds
        {
            get;
            set;
        }

        public virtual void afficherFormes()
        {
            throw new System.NotImplementedException();
        }

        public virtual void reponseUtilisateur()
        {
            throw new System.NotImplementedException();
        }
    }
}
