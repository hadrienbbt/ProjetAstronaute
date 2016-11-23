namespace ProjetAstronaute
{
    partial class CalculMental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titre = new System.Windows.Forms.Label();
            this.sous_titre = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.retour_accueil1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.retour_accueil2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.boutton_addition = new System.Windows.Forms.Button();
            this.bouton_soustraction = new System.Windows.Forms.Button();
            this.bouton_multiplication = new System.Windows.Forms.Button();
            this.bouton_division = new System.Windows.Forms.Button();
            this.boutton_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(67, 43);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(315, 42);
            this.titre.TabIndex = 0;
            this.titre.Text = "Test Calcul Mental";
            this.titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titre.Click += new System.EventHandler(this.titre_Click);
            // 
            // sous_titre
            // 
            this.sous_titre.AutoSize = true;
            this.sous_titre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sous_titre.Location = new System.Drawing.Point(175, 92);
            this.sous_titre.Name = "sous_titre";
            this.sous_titre.Size = new System.Drawing.Size(103, 27);
            this.sous_titre.TabIndex = 1;
            this.sous_titre.Text = "Niveau x";
            this.sous_titre.Click += new System.EventHandler(this.sous_titre_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.retour_accueil1,
            this.retour_accueil2});
            this.shapeContainer1.Size = new System.Drawing.Size(414, 832);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // retour_accueil1
            // 
            this.retour_accueil1.AccessibleName = "retour_accueil";
            this.retour_accueil1.BorderWidth = 3;
            this.retour_accueil1.Name = "retour_accueil1";
            this.retour_accueil1.X1 = 44;
            this.retour_accueil1.X2 = 24;
            this.retour_accueil1.Y1 = 57;
            this.retour_accueil1.Y2 = 81;
            this.retour_accueil1.Click += new System.EventHandler(this.retour_accueil1_Click);
            // 
            // retour_accueil2
            // 
            this.retour_accueil2.AccessibleName = "retour_accueil";
            this.retour_accueil2.BorderWidth = 3;
            this.retour_accueil2.Name = "retour_accueil2";
            this.retour_accueil2.X1 = 24;
            this.retour_accueil2.X2 = 46;
            this.retour_accueil2.Y1 = 80;
            this.retour_accueil2.Y2 = 100;
            this.retour_accueil2.Click += new System.EventHandler(this.retour_accueil2_Click);
            // 
            // boutton_addition
            // 
            this.boutton_addition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boutton_addition.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutton_addition.Location = new System.Drawing.Point(107, 187);
            this.boutton_addition.Name = "boutton_addition";
            this.boutton_addition.Size = new System.Drawing.Size(205, 83);
            this.boutton_addition.TabIndex = 4;
            this.boutton_addition.Text = "+";
            this.boutton_addition.UseVisualStyleBackColor = true;
            this.boutton_addition.Click += new System.EventHandler(this.boutton_addition_Click);
            // 
            // bouton_soustraction
            // 
            this.bouton_soustraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bouton_soustraction.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bouton_soustraction.Location = new System.Drawing.Point(107, 307);
            this.bouton_soustraction.Name = "bouton_soustraction";
            this.bouton_soustraction.Size = new System.Drawing.Size(205, 83);
            this.bouton_soustraction.TabIndex = 5;
            this.bouton_soustraction.Text = "-";
            this.bouton_soustraction.UseVisualStyleBackColor = true;
            this.bouton_soustraction.Click += new System.EventHandler(this.bouton_soustraction_Click);
            // 
            // bouton_multiplication
            // 
            this.bouton_multiplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bouton_multiplication.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bouton_multiplication.Location = new System.Drawing.Point(107, 430);
            this.bouton_multiplication.Name = "bouton_multiplication";
            this.bouton_multiplication.Size = new System.Drawing.Size(205, 83);
            this.bouton_multiplication.TabIndex = 6;
            this.bouton_multiplication.Text = "x";
            this.bouton_multiplication.UseVisualStyleBackColor = true;
            this.bouton_multiplication.Click += new System.EventHandler(this.bouton_multiplication_Click);
            // 
            // bouton_division
            // 
            this.bouton_division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bouton_division.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bouton_division.Location = new System.Drawing.Point(107, 558);
            this.bouton_division.Name = "bouton_division";
            this.bouton_division.Size = new System.Drawing.Size(205, 83);
            this.bouton_division.TabIndex = 7;
            this.bouton_division.Text = "÷";
            this.bouton_division.UseVisualStyleBackColor = true;
            this.bouton_division.Click += new System.EventHandler(this.bouton_division_Click);
            // 
            // boutton_ok
            // 
            this.boutton_ok.BackColor = System.Drawing.Color.LightGray;
            this.boutton_ok.Enabled = false;
            this.boutton_ok.Location = new System.Drawing.Point(167, 687);
            this.boutton_ok.Name = "boutton_ok";
            this.boutton_ok.Size = new System.Drawing.Size(81, 40);
            this.boutton_ok.TabIndex = 8;
            this.boutton_ok.Text = "OK !";
            this.boutton_ok.UseVisualStyleBackColor = false;
            this.boutton_ok.Visible = false;
            this.boutton_ok.Click += new System.EventHandler(this.boutton_ok_Click);
            // 
            // CalculMental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 832);
            this.Controls.Add(this.boutton_ok);
            this.Controls.Add(this.bouton_division);
            this.Controls.Add(this.bouton_multiplication);
            this.Controls.Add(this.bouton_soustraction);
            this.Controls.Add(this.boutton_addition);
            this.Controls.Add(this.sous_titre);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "CalculMental";
            this.Text = "CalculMental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label sous_titre;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape retour_accueil1;
        private Microsoft.VisualBasic.PowerPacks.LineShape retour_accueil2;
        private System.Windows.Forms.Button boutton_addition;
        private System.Windows.Forms.Button bouton_soustraction;
        private System.Windows.Forms.Button bouton_multiplication;
        private System.Windows.Forms.Button bouton_division;
        private System.Windows.Forms.Button boutton_ok;
    }
}