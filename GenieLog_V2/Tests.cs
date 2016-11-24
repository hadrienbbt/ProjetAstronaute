using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAstronaute
{
    abstract class Tests
    {
        protected string nom{get;set;}

        protected int numero { get; set; }

        protected int iteration { get; set; }

        protected string consigne { get; set; }

        protected string regle { get; set; }

        protected string demo { get; set; }

        protected string resultat { get; set; }

        protected int tempsLimite { get; set; }

        protected int niveau { get; set; }

        protected int timer { get; set; }

        public Tests(string nom, int numero, int iteration, string consigne, string demo, int niveau, int tempsLimite, string resultat, string regle, int timer)
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
