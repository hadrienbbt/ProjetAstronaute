using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAstronaute
{
    class MenuPrincipal
    {
            public virtual int choixTest
	    {
		    get;
		    set;
	    }

	    public virtual int choixNiveau
	    {
		    get;
		    set;
	    }

	    public virtual Utilisateur Utilisateur
	    {
		    get;
		    set;
	    }

	    public virtual Tests Tests
	    {
		    get;
		    set;
	    }

	    public virtual void afficherQuestionnaireTest()
	    {
		    throw new System.NotImplementedException();
	    }

	    public virtual void afficherQuestionnaireNiveau()
	    {
		    throw new System.NotImplementedException();
	    }

	    public virtual void menuPrincipal(int choixNiveau, int choixTest)
	    {
		    throw new System.NotImplementedException();
	    }
    }
}
