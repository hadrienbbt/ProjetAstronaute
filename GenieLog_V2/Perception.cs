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
            ConsoleColor couleur;
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
                    if (random.Next(0, 2) == 1) couleur = System.ConsoleColor.Blue;
                    else couleur = System.ConsoleColor.Yellow;
                    if (random.Next(0, 2) == 1) forme = "carre";
                    else forme = "rond";
                    formes.Add(new Forme(c, random.Next(0, 11), couleur, forme));
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
    }

    internal class Forme   
    {  
        protected char lettre;
        protected int chiffre;
        protected ConsoleColor couleur;
        protected string type;

        public Forme (char uneLettre, int unChiffre, ConsoleColor uneCouleur, string unType) {
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
        public System.ConsoleColor getCouleur() { return this.couleur; }
    }
}
