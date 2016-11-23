using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAstronaute
{
    class PbPhysique
    {
            public virtual string descriptionProbleme
	    {
		    get;
		    set;
	    }

	    public virtual int choixQCM
	    {
		    get;
		    set;
	    }

	    public virtual int reponseQCM
	    {
		    get;
		    set;
	    }

	    public virtual void afficherPb()
	    {
		    throw new System.NotImplementedException();
	    }

	    public PbPhysique(string descriptionProbleme, int reponseQCM, int choixQCm)
	    {
	    }
    }
}
