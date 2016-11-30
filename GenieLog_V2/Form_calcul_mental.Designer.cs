namespace GenieLog_V2
{
    partial class Form_calcul_mental
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.titre = new System.Windows.Forms.Label();
            this.sous_titre = new System.Windows.Forms.Label();
            this.retour_accueil = new System.Windows.Forms.Label();
            this.bouton_addition = new System.Windows.Forms.Button();
            this.bouton_soustraction = new System.Windows.Forms.Button();
            this.bouton_multiplication = new System.Windows.Forms.Button();
            this.bouton_division = new System.Windows.Forms.Button();
            this.reponse = new System.Windows.Forms.TextBox();
            this.bouton_ok = new System.Windows.Forms.Button();
            this.operation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(75, 50);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(314, 55);
            this.titre.TabIndex = 0;
            this.titre.Text = "Calcul mental";
            this.titre.Click += new System.EventHandler(this.titre_Click);
            // 
            // sous_titre
            // 
            this.sous_titre.AutoSize = true;
            this.sous_titre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sous_titre.Location = new System.Drawing.Point(172, 118);
            this.sous_titre.Name = "sous_titre";
            this.sous_titre.Size = new System.Drawing.Size(103, 27);
            this.sous_titre.TabIndex = 1;
            this.sous_titre.Text = "Niveau x";
            this.sous_titre.Click += new System.EventHandler(this.sous_titre_Click);
            // 
            // retour_accueil
            // 
            this.retour_accueil.AutoSize = true;
            this.retour_accueil.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour_accueil.Location = new System.Drawing.Point(21, 56);
            this.retour_accueil.Name = "retour_accueil";
            this.retour_accueil.Size = new System.Drawing.Size(48, 57);
            this.retour_accueil.TabIndex = 2;
            this.retour_accueil.Text = "<";
            this.retour_accueil.Click += new System.EventHandler(this.retour_accueil_Click);
            // 
            // bouton_addition
            // 
            this.bouton_addition.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bouton_addition.Location = new System.Drawing.Point(109, 198);
            this.bouton_addition.Name = "bouton_addition";
            this.bouton_addition.Size = new System.Drawing.Size(205, 83);
            this.bouton_addition.TabIndex = 3;
            this.bouton_addition.Text = "+";
            this.bouton_addition.UseVisualStyleBackColor = true;
            this.bouton_addition.Click += new System.EventHandler(this.bouton_addition_Click);
            // 
            // bouton_soustraction
            // 
            this.bouton_soustraction.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bouton_soustraction.Location = new System.Drawing.Point(109, 326);
            this.bouton_soustraction.Name = "bouton_soustraction";
            this.bouton_soustraction.Size = new System.Drawing.Size(205, 83);
            this.bouton_soustraction.TabIndex = 4;
            this.bouton_soustraction.Text = "-";
            this.bouton_soustraction.UseVisualStyleBackColor = true;
            this.bouton_soustraction.Click += new System.EventHandler(this.bouton_soustraction_Click);
            // 
            // bouton_multiplication
            // 
            this.bouton_multiplication.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bouton_multiplication.Location = new System.Drawing.Point(109, 456);
            this.bouton_multiplication.Name = "bouton_multiplication";
            this.bouton_multiplication.Size = new System.Drawing.Size(205, 83);
            this.bouton_multiplication.TabIndex = 5;
            this.bouton_multiplication.Text = "×";
            this.bouton_multiplication.UseVisualStyleBackColor = true;
            this.bouton_multiplication.Click += new System.EventHandler(this.bouton_multiplication_Click);
            // 
            // bouton_division
            // 
            this.bouton_division.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bouton_division.Location = new System.Drawing.Point(109, 589);
            this.bouton_division.Name = "bouton_division";
            this.bouton_division.Size = new System.Drawing.Size(205, 83);
            this.bouton_division.TabIndex = 6;
            this.bouton_division.Text = "÷";
            this.bouton_division.UseVisualStyleBackColor = true;
            this.bouton_division.Click += new System.EventHandler(this.bouton_division_Click);
            // 
            // reponse
            // 
            this.reponse.Location = new System.Drawing.Point(150, 406);
            this.reponse.Name = "reponse";
            this.reponse.Size = new System.Drawing.Size(116, 20);
            this.reponse.TabIndex = 16;
            this.reponse.Visible = false;
            this.reponse.TextChanged += new System.EventHandler(this.reponse_TextChanged);
            // 
            // bouton_ok
            // 
            this.bouton_ok.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bouton_ok.Location = new System.Drawing.Point(150, 491);
            this.bouton_ok.Name = "bouton_ok";
            this.bouton_ok.Size = new System.Drawing.Size(120, 40);
            this.bouton_ok.TabIndex = 15;
            this.bouton_ok.Text = "OK !";
            this.bouton_ok.UseVisualStyleBackColor = true;
            this.bouton_ok.Visible = false;
            this.bouton_ok.Click += new System.EventHandler(this.bouton_ok_Click);
            // 
            // operation
            // 
            this.operation.AutoSize = true;
            this.operation.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operation.Location = new System.Drawing.Point(157, 291);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(70, 32);
            this.operation.TabIndex = 14;
            this.operation.Text = "a - b";
            this.operation.Visible = false;
            // 
            // Form_calcul_mental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 750);
            this.Controls.Add(this.reponse);
            this.Controls.Add(this.bouton_ok);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.bouton_division);
            this.Controls.Add(this.bouton_multiplication);
            this.Controls.Add(this.bouton_soustraction);
            this.Controls.Add(this.bouton_addition);
            this.Controls.Add(this.retour_accueil);
            this.Controls.Add(this.sous_titre);
            this.Controls.Add(this.titre);
            this.Name = "Form_calcul_mental";
            this.Text = "Calcul_mental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label sous_titre;
        private System.Windows.Forms.Label retour_accueil;
        private System.Windows.Forms.Button bouton_addition;
        private System.Windows.Forms.Button bouton_soustraction;
        private System.Windows.Forms.Button bouton_multiplication;
        private System.Windows.Forms.Button bouton_division;
        private System.Windows.Forms.TextBox reponse;
        private System.Windows.Forms.Button bouton_ok;
        private System.Windows.Forms.Label operation;
    }
}