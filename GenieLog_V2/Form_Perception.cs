using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetAstronaute;

namespace GenieLog_V2
{
    public partial class Form_Perception : Form
    {
        private Graphics g;
        private Perception data;
        private int state;

        public Form_Perception(int niveau)
        {
            this.data = new Perception(niveau);
            state = 1;
            InitializeComponent();     
        }

        public void dessinerForme(PaintEventArgs e, string forme, string couleur, int x, int y)
        {

            if (forme == "carre")
            {
                if (couleur == "Blue")
                    e.Graphics.FillRectangle(Brushes.Blue, new Rectangle(x, y, 60, 60));
                else
                    e.Graphics.FillRectangle(Brushes.Yellow, new Rectangle(x, y, 60, 60));
            }
            else
            {
                if (couleur == "Blue")
                    e.Graphics.FillEllipse(Brushes.Blue, new Rectangle(x, y, 60, 60));
                else
                    e.Graphics.FillEllipse(Brushes.Yellow, new Rectangle(x, y, 60, 60));
            }
        }

        public void dessinerLettre(PaintEventArgs e, char lettre, int x, int y)
        {
            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(x, y);

            // Draw string to screen.
            e.Graphics.DrawString(lettre.ToString().ToUpper(), drawFont, drawBrush, drawPoint);
        }

        public void dessinerChiffre(PaintEventArgs e, int chiffre, int x, int y)
        {
            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(x, y);

            // Draw string to screen.
            e.Graphics.DrawString(chiffre.ToString(), drawFont, drawBrush, drawPoint);
        }

        public void dessinerInput(PaintEventArgs e, Forme f, int x, int y)
        {
            dessinerLettre(e, f.getLettre(), x, y);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Si on en est à l'étape des formes, on les dessine
            switch (this.state) {
                case 1 :
                    int x = 80,
                        y = 160;
                    e.Graphics.DrawString(data.getRegle(), new Font("Arial", 13), new SolidBrush(Color.Black), new PointF(x-30, y-60));
                    foreach (Forme f in data.getFormes())
                    {
                        dessinerLettre(e, f.getLettre(), x+20, y-25);
                        dessinerForme(e, f.getType(), f.getCouleur(), x, y);
                        dessinerChiffre(e, f.getChiffre(), x + 20, y + 20);
                        if (x >= 250) {
                            x = 80;
                            y += 100;
                        } else {
                            x += 80;
                        }
                    }
                    break;
                case 2 :
                    x = 200;
                    y = 160;
                    foreach (Forme f in data.getFormes()) {
                        if (f.getCouleur() == data.getCouleurRef() && f.getType() == data.getFormeRef()) {
                            dessinerInput(e, f, x, y);
                        }
                        if (x >= 250){
                            x = 80;
                            y += 100;
                        } else {
                            x += 80;
                        }
                    }
                    break;
            }
            base.OnPaint(e);
        }

        private void Form_Perception_Click(object sender, EventArgs e)
        {
            data = new Perception(data.getNiveau());
            this.state = 2;
            Refresh();
        }
    }
}
