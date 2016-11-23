using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAstronaute
{
    abstract class Tests
    {
        private string nom{get;set;}

	    private int numero{get;set;}

	    private int iteration{get;set;}

	    private string consigne{get;set;}

	    private string regle{get;set;}

	    private string demo{get;set;}

	    private string resultat{get;set;}

	    private int tempsLimite{get;set;}

	    private int niveau{get;set;}

	    private int timer{get;set;}

        public virtual void tests(string nom, int numero, int iteration, string consigne, string demo, int niveau, int tempsLimite, string resultat, string regle, int timer)
        {
            this.nom = nom;
            this.numero = numero;
            this.iteration = iteration;
            this.consigne = consigne;
            this.regle = regle;
            this.demo = demo;
            this.resultat = resultat;
            this.tempsLimite = tempsLimite;
            this.niveau = niveau;
            this.timer = timer;
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
