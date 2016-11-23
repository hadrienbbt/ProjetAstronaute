using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAstronaute
{
    class Operation
        {
            public virtual int compteur
	    {
		    get;
		    set;
	    }

	    public virtual object resultatIntermediaire
	    {
		    get;
		    set;
	    }

	    public virtual void afficherCalcul()
	    {
		    throw new System.NotImplementedException();
	    }

	    public virtual void soustraction()
	    {
		    throw new System.NotImplementedException();
	    }

	    public virtual void addition()
	    {
		    throw new System.NotImplementedException();
	    }

	    public virtual void division()
	    {
		    throw new System.NotImplementedException();
	    }

	    public virtual void multiplication()
	    {
		    throw new System.NotImplementedException();
	    }

	    public Operation(int compteur, string resultatIntermediaire)
	    {
	    }
    }
}
