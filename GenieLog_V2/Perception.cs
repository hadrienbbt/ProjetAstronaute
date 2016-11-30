using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAstronaute
{
    class Perception : Tests
    {

        string alphabet = "abcdefghijkl";

        // On va générer une règle lorsqu'on crée la classe Percpetion
        private string formeRef;
        private string couleurRef;

        private List<Forme> lesFormes;

        public Perception(int unNiveau)
            : base("Perception et mémoire associative", 1, 10, "Suivez la consigne", "Suivez la démo", unNiveau, 0, "", "Suivez la règle", 0)
        {
           this.regle = genererRegle();
           this.lesFormes = genererFormes();
        }

        public virtual void afficherFormes()
        {
            throw new System.NotImplementedException();
        }

        public virtual void reponseUtilisateur()
        {
            throw new System.NotImplementedException();
        }

        // Permet de définir
        public string genererRegle()
        {
            Random random = new Random();
            int randomNumber;
            randomNumber = random.Next(0, 2);
            if (randomNumber == 1) formeRef = "carre";
            else formeRef = "rond";
            randomNumber = random.Next(0, 2);
            if (randomNumber == 1)
            {
                couleurRef = "Blue";
                return "Mémorisez les valeurs de tous les " + formeRef + "s bleus";
            }
            else
            {
                couleurRef = "Yellow";
                return "Mémorisez les valeurs de tous les " + formeRef + "s jaunes";
            }

            
        }

        public List<Forme> genererFormes()
        {
            string couleur;
            string forme;
            Random random = new Random();
            List<Forme> formes = new List<Forme>();
            int compteurForme = 0;

            while (compteurForme != 3 && compteurForme != 4)
            {
                formes.Clear();
                compteurForme = 0;

                foreach (char c in alphabet)
                {
                    if (random.Next(0, 2) == 1) couleur = "Blue";
                    else couleur = "Yellow";
                    if (random.Next(0, 2) == 1) forme = "carre";
                    else forme = "rond";
                    formes.Add(new Forme(c, random.Next(0, 10), couleur, forme));
                }

                // Vérifier que la contrainte est vérifiée

                foreach (Forme f in formes) if (f.getType() == formeRef && f.getCouleur().ToString() == couleurRef) compteurForme++;
            }
            return formes;
        }

        public override string ToString()
        {
            string s = this.regle;
            foreach (Forme f in lesFormes)
                s += "\n" + f.ToString();
            return s;
        }

        public string getCouleurRef()   { return this.couleurRef;}
        public string getFormeRef()     { return this.formeRef; }
        public List<Forme> getFormes()  { return this.lesFormes; }
        public string getRegle()        { return this.regle; }

    }

    internal class Forme   
    {  
        protected char lettre;
        protected int chiffre;
        protected string couleur;
        protected string type;

        public Forme (char uneLettre, int unChiffre, string uneCouleur, string unType) {
            lettre = uneLettre;
            chiffre = unChiffre;
            couleur = uneCouleur;
            type = unType;
        }

        public override string ToString()
        {
            return "Je suis la forme "+ type + " " + lettre + " de couleur " + couleur + " et je porte le chiffre " + chiffre;
        }

        public string getType() {return this.type;}
        public string getCouleur() { return this.couleur; }
        public char getLettre() { return this.lettre; }
        public int getChiffre() { return this.chiffre; }
    }
}
