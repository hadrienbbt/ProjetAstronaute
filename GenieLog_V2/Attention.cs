using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAstronaute
{
    class Attention
    {
        public virtual int compteur
	    {
		    get;
		    set;
	    }

	    public virtual int nbFormes
	    {
		    get;
		    set;
	    }

	    public Attention(int compteur, int nbFormes)
	    {
	    }

	    public virtual void afficherObjet()
	    {
		    throw new System.NotImplementedException();
	    }
    }
}
