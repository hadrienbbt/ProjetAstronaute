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
            if (randomNumber == 1) couleurRef = "bleu";
            else couleurRef = "jaune";
            return "Mémorisez les valeurs de tous les " + formeRef + "s " + couleurRef + "s";
        }

        public List<Forme> genererFormes()
        {
            ConsoleColor couleur;
            Random random = new Random();
            List<Forme> formes = new List<Forme>();

            foreach (char c in alphabet)
            {
                if (random.Next(0, 2) == 1) couleur = System.ConsoleColor.Blue;
                else couleur = System.ConsoleColor.Yellow;
                formes.Add(new Forme(c, random.Next(0, 11), couleur));
            }
            // Vérifier que la contrainte est vérifiée
            

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

        public Forme (char uneLettre, int unChiffre, ConsoleColor uneCouleur) {
            lettre = uneLettre;
            chiffre = unChiffre;
            couleur = uneCouleur;
        }

        public override string ToString()
        {
            return "Je suis la forme " + lettre + " de couleur " + couleur + " et je porte le chiffre " + chiffre;
        }
    }
}
