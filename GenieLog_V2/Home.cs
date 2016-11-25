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
        private int niveau { get; set; }
        private int test;

        public Home()
        {
            InitializeComponent();
            this.niveau = 0;
            this.test = 0;
        }

        private void typeTest1_Click(object sender, EventArgs e)
        {
            reinitialiserBoutonsTest();
            this.test = 1;
            this.typeTest1.BackColor = Color.LightGray;
            userInteraction_Click(sender, e);
        }

        private void typeTest2_Click(object sender, EventArgs e)
        {
            reinitialiserBoutonsTest();
            this.test = 2;
            this.typeTest2.BackColor = Color.LightGray;
            userInteraction_Click(sender, e);
        }

        private void typeTest3_Click(object sender, EventArgs e)
        {
            reinitialiserBoutonsTest();
            this.test = 3;
            this.typeTest3.BackColor = Color.LightGray;
            userInteraction_Click(sender, e);
        }

        private void typeTest4_Click(object sender, EventArgs e)
        {
            reinitialiserBoutonsTest();
            this.test = 4;
            this.typeTest4.BackColor = Color.LightGray;
            userInteraction_Click(sender, e);
        }

        private void typeTest5_Click(object sender, EventArgs e)
        {
            reinitialiserBoutonsTest();
            this.test = 5;
            this.typeTest5.BackColor = Color.LightGray;
            userInteraction_Click(sender, e);
        }

        private void choixNiveau1_Click(object sender, EventArgs e)
        {
            reinitialiserBoutonsNiveau();
            this.niveau = 1;
            this.choixNiveau1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            userInteraction_Click(sender, e);
        }

        private void choixNiveau2_Click(object sender, EventArgs e)
        {
            reinitialiserBoutonsNiveau();
            this.niveau = 2;
            this.choixNiveau2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            userInteraction_Click(sender, e);
        }

        private void userInteraction_Click(object sender, EventArgs e)
        {
            if (this.test != 0)
                choixNiveau.Visible = true;
            if (this.niveau != 0 && this.test != 0)
                valider.Visible = true;
        }

        private void reinitialiserBoutonsTest()
        {
            this.typeTest1.BackColor = Color.White;
            this.typeTest2.BackColor = Color.White;
            this.typeTest3.BackColor = Color.White;
            this.typeTest4.BackColor = Color.White;
            this.typeTest5.BackColor = Color.White;
        }

        private void reinitialiserBoutonsNiveau()
        {
            this.choixNiveau1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.choixNiveau2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
        }

        private void choixNiveau1_MouseHover(object sender, EventArgs e)
        {
            if  (niveau != 1)
                this.choixNiveau1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
        }

        private void choixNiveau1_MouseLeave(object sender, EventArgs e)
        {
            if (niveau != 1)
                this.choixNiveau1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
        }

        private void choixNiveau2_MouseHover(object sender, EventArgs e)
        {
            if (niveau != 2)
                this.choixNiveau2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
        }

        private void choixNiveau2_MouseLeave(object sender, EventArgs e)
        {
            if (niveau != 2)
                this.choixNiveau2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
        }

        private void valider_Click(object sender, EventArgs e)
        {
            switch (this.test)
            {
                case 1:
                    Perception page2 = new Perception(niveau);
                    Console.WriteLine(page2.ToString());
                    break;
                case 2:
                    Console.Write("test attention er concentration");
                    break;
                case 3:
                    Console.Write("test calcul mental");
                    break;
                case 4:
                    Console.Write("test problèmes mathématiques");
                    break;
                case 5:
                    Console.Write("test problèmes physiques");
                    break;
            }
        }
    }
}
