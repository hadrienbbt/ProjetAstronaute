using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAstronaute
{
    abstract class Tests
    {
            private string nom
	    {
		    get;
		    set;
	    }

	    private int numéro
	    {
		    get;
		    set;
	    }

	    private int itération
	    {
		    get;
		    set;
	    }

	    private string consigne
	    {
		    get;
		    set;
	    }

	    private string regle
	    {
		    get;
		    set;
	    }

	    private string demo
	    {
		    get;
		    set;
	    }

	    private string resultat
	    {
		    get;
		    set;
	    }

	    private int tempsLimite
	    {
		    get;
		    set;
	    }

	    private int niveau
	    {
		    get;
		    set;
	    }

	    private object timer
	    {
		    get;
		    set;
	    }

	    public virtual void tests(string consigne, string demo, int niveau, int tempsLimite, string resultat, string regle, int numero, string nom, int iteration)
	    {
		    throw new System.NotImplementedException();
	    }

	    public virtual void lancerTest()
	    {
		    throw new System.NotImplementedException();
	    }

	    public virtual void afficherResultat()
	    {
		    throw new System.NotImplementedException();
	    }
    }
}
