using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetAstronaute
{
    public partial class Home : Form
    {
        private int niveau;
        private int test;
        /*{
            get { return test; }
            set { 
            set
            {
                test = value;
                switch (test)
                {
                    case 1:
                        typeTest1.ForeColor = SystemColors.WindowText;
                        break;
                    case 2:
                        typeTest2.ForeColor = SystemColors.WindowText;
                        break;
                    case 3:
                        typeTest3.ForeColor = SystemColors.WindowText;
                        break;
                    case 4:
                        typeTest4.ForeColor = SystemColors.WindowText;
                        break;
                    case 5:
                        typeTest5.ForeColor = SystemColors.WindowText;
                        break;
                }
            }
        }*/

        public Home()
        {
            InitializeComponent();
            this.niveau = 0;
            this.test = 0;
        }

        private void typeTest1_Click(object sender, EventArgs e)
        {
            this.test = 1;
        }

        private void typeTest2_Click(object sender, EventArgs e)
        {
            this.test = 2;
        }

        private void typeTest3_Click(object sender, EventArgs e)
        {
            this.test = 3;
        }

        private void typeTest4_Click(object sender, EventArgs e)
        {
            this.test = 4;
        }

        private void typeTest5_Click(object sender, EventArgs e)
        {
            this.test = 5;
        }

        private void choixNiveau1_Click(object sender, EventArgs e)
        {
            this.niveau = 1;
        }

        private void choixNiveau2_Click(object sender, EventArgs e)
        {
            this.niveau = 2;
        }

        private void userInteraction_Click(object sender, EventArgs e)
        {
            if (this.niveau != 0 || this.test != 0)
                valider.Visible = true;
        }

        private void Titre_Click(object sender, EventArgs e)
        {

        }

        private void typeTest2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
