using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetAstronaute;
using GenieLog_V2;

namespace GenieLog_V2
{
    public partial class Form_calcul_mental : Form
    {
        Calcul_mental data = new Calcul_mental();
        private int compteur_operation = 1;

        public Form_calcul_mental()
        {
            InitializeComponent();
        }

        private void titre_Click(object sender, EventArgs e)
        {

        }

        private void sous_titre_Click(object sender, EventArgs e)
        {
            /*if (Home.niveau==1){
                sous_titre.Text="Niveau 1";
            }
            else
                sous_titre.Text="Niveau 1";*/
        }

        private void retour_accueil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bouton_addition_Click(object sender, EventArgs e)
        {
            bouton_addition.Visible = false;
            bouton_soustraction.Visible = false;
            bouton_multiplication.Visible = false;
            bouton_division.Visible = false;
            operation.Visible = true;
            reponse.Visible = true;
            bouton_ok.Visible = true;
            string affichage_operation = data.GenererOperation("addition");
            operation.Text = affichage_operation;
        }

        private void bouton_soustraction_Click(object sender, EventArgs e)
        {
            bouton_addition.Visible = false;
            bouton_soustraction.Visible = false;
            bouton_multiplication.Visible = false;
            bouton_division.Visible = false;
            operation.Visible = true;
            reponse.Visible = true;
            bouton_ok.Visible = true;
            string affichage_operation = data.GenererOperation("soustraction");
            operation.Text = affichage_operation;
        }

        private void bouton_multiplication_Click(object sender, EventArgs e)
        {
            bouton_addition.Visible = false;
            bouton_soustraction.Visible = false;
            bouton_multiplication.Visible = false;
            bouton_division.Visible = false;
            operation.Visible = true;
            reponse.Visible = true;
            bouton_ok.Visible = true;
            string affichage_operation = data.GenererOperation("multiplication");
            operation.Text = affichage_operation;
        }

        private void bouton_division_Click(object sender, EventArgs e)
        {
            bouton_addition.Visible = false;
            bouton_soustraction.Visible = false;
            bouton_multiplication.Visible = false;
            bouton_division.Visible = false;
            operation.Visible = true;
            reponse.Visible = true;
            bouton_ok.Visible = true;
            string affichage_operation = data.GenererOperation("division");
            operation.Text = affichage_operation;

        }

        private void addition_Click(object sender, EventArgs e)
        {

        }

        private void soustraction_Click(object sender, EventArgs e)
        {

        }

        private void multiplication_Click(object sender, EventArgs e)
        {

        }

        private void division_Click(object sender, EventArgs e)
        {

        }

        private void reponse_TextChanged(object sender, EventArgs e)
        {
            int res = int.Parse(reponse.Text);
            int resultat = data.GetRes();
            bool reponse_utilisateur = res == resultat ? true : false;
        }

        private void bouton_ok_Click(object sender, EventArgs e)
        {
            /*if ((data.GetCompteur_operation()) == 10)
                data.afficherResultat();
            else{*/
            string operateur = data.GetType_operation();
            Console.WriteLine(operateur);
            data = new Calcul_mental();
            string affichage_operation = data.GenererOperation(operateur);
            Console.WriteLine(affichage_operation);
            operation.Text = affichage_operation;
            compteur_operation++;
            Refresh();
            //}
        }








    }
}
