namespace ProjetAstronaute
{
    partial class Home
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
            this.Titre = new System.Windows.Forms.Label();
            this.Paragraphe = new System.Windows.Forms.Label();
            this.explications = new System.Windows.Forms.Label();
            this.typeTest1 = new System.Windows.Forms.Button();
            this.typeTest2 = new System.Windows.Forms.Button();
            this.typeTest3 = new System.Windows.Forms.Button();
            this.typeTest4 = new System.Windows.Forms.Button();
            this.typeTest5 = new System.Windows.Forms.Button();
            this.userInteraction = new System.Windows.Forms.Panel();
            this.valider = new System.Windows.Forms.Button();
            this.choixNiveau = new System.Windows.Forms.Panel();
            this.choixNiveau1 = new System.Windows.Forms.Button();
            this.choixNiveau2 = new System.Windows.Forms.Button();
            this.userInteraction.SuspendLayout();
            this.choixNiveau.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Arial", 32F);
            this.Titre.Location = new System.Drawing.Point(54, 9);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(312, 98);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Bienvenue sur \r\nCognitest !";
            this.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Paragraphe
            // 
            this.Paragraphe.AutoSize = true;
            this.Paragraphe.Location = new System.Drawing.Point(12, 137);
            this.Paragraphe.Name = "Paragraphe";
            this.Paragraphe.Size = new System.Drawing.Size(0, 13);
            this.Paragraphe.TabIndex = 1;
            // 
            // explications
            // 
            this.explications.AutoSize = true;
            this.explications.Font = new System.Drawing.Font("Arial", 9F);
            this.explications.Location = new System.Drawing.Point(77, 118);
            this.explications.Name = "explications";
            this.explications.Size = new System.Drawing.Size(247, 75);
            this.explications.TabIndex = 2;
            this.explications.Text = "Pour commencer veuillez choisir un type de \r\ntest et un niveau de difficulté.\r\n\r\n" +
    "Cliquez ensuite sur OK ! pour démarrer \r\nl\'épreuve.";
            this.explications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeTest1
            // 
            this.typeTest1.BackColor = System.Drawing.Color.White;
            this.typeTest1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.typeTest1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeTest1.Font = new System.Drawing.Font("Arial", 10F);
            this.typeTest1.Location = new System.Drawing.Point(0, 0);
            this.typeTest1.Name = "typeTest1";
            this.typeTest1.Size = new System.Drawing.Size(146, 58);
            this.typeTest1.TabIndex = 3;
            this.typeTest1.Text = "Perception et mémoire associative";
            this.typeTest1.UseVisualStyleBackColor = false;
            this.typeTest1.Click += new System.EventHandler(this.typeTest1_Click);
            // 
            // typeTest2
            // 
            this.typeTest2.BackColor = System.Drawing.Color.White;
            this.typeTest2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.typeTest2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeTest2.Font = new System.Drawing.Font("Arial", 10F);
            this.typeTest2.Location = new System.Drawing.Point(179, 0);
            this.typeTest2.Name = "typeTest2";
            this.typeTest2.Size = new System.Drawing.Size(146, 58);
            this.typeTest2.TabIndex = 4;
            this.typeTest2.Text = "Attention et concentration";
            this.typeTest2.UseVisualStyleBackColor = false;
            this.typeTest2.Click += new System.EventHandler(this.typeTest2_Click);
            // 
            // typeTest3
            // 
            this.typeTest3.BackColor = System.Drawing.Color.White;
            this.typeTest3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.typeTest3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeTest3.Font = new System.Drawing.Font("Arial", 10F);
            this.typeTest3.Location = new System.Drawing.Point(88, 178);
            this.typeTest3.Name = "typeTest3";
            this.typeTest3.Size = new System.Drawing.Size(146, 58);
            this.typeTest3.TabIndex = 5;
            this.typeTest3.Text = "Calcul mental";
            this.typeTest3.UseVisualStyleBackColor = false;
            this.typeTest3.Click += new System.EventHandler(this.typeTest3_Click);
            // 
            // typeTest4
            // 
            this.typeTest4.BackColor = System.Drawing.Color.White;
            this.typeTest4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.typeTest4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeTest4.Font = new System.Drawing.Font("Arial", 10F);
            this.typeTest4.Location = new System.Drawing.Point(0, 92);
            this.typeTest4.Name = "typeTest4";
            this.typeTest4.Size = new System.Drawing.Size(146, 58);
            this.typeTest4.TabIndex = 6;
            this.typeTest4.Text = "Problèmes mathématiques";
            this.typeTest4.UseVisualStyleBackColor = false;
            this.typeTest4.Click += new System.EventHandler(this.typeTest4_Click);
            // 
            // typeTest5
            // 
            this.typeTest5.BackColor = System.Drawing.Color.White;
            this.typeTest5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.typeTest5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeTest5.Font = new System.Drawing.Font("Arial", 10F);
            this.typeTest5.Location = new System.Drawing.Point(179, 92);
            this.typeTest5.Name = "typeTest5";
            this.typeTest5.Size = new System.Drawing.Size(146, 58);
            this.typeTest5.TabIndex = 7;
            this.typeTest5.Text = "Problèmes physiques";
            this.typeTest5.UseVisualStyleBackColor = false;
            this.typeTest5.Click += new System.EventHandler(this.typeTest5_Click);
            // 
            // userInteraction
            // 
            this.userInteraction.Controls.Add(this.valider);
            this.userInteraction.Controls.Add(this.choixNiveau);
            this.userInteraction.Controls.Add(this.typeTest1);
            this.userInteraction.Controls.Add(this.typeTest5);
            this.userInteraction.Controls.Add(this.typeTest2);
            this.userInteraction.Controls.Add(this.typeTest4);
            this.userInteraction.Controls.Add(this.typeTest3);
            this.userInteraction.Location = new System.Drawing.Point(41, 212);
            this.userInteraction.Name = "userInteraction";
            this.userInteraction.Size = new System.Drawing.Size(325, 428);
            this.userInteraction.TabIndex = 8;
            this.userInteraction.Click += new System.EventHandler(this.userInteraction_Click);
            // 
            // valider
            // 
            this.valider.BackColor = System.Drawing.Color.White;
            this.valider.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valider.Font = new System.Drawing.Font("Arial", 10F);
            this.valider.Location = new System.Drawing.Point(129, 316);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(63, 42);
            this.valider.TabIndex = 10;
            this.valider.Text = "OK !";
            this.valider.UseVisualStyleBackColor = false;
            this.valider.Visible = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // choixNiveau
            // 
            this.choixNiveau.Controls.Add(this.choixNiveau1);
            this.choixNiveau.Controls.Add(this.choixNiveau2);
            this.choixNiveau.Location = new System.Drawing.Point(39, 255);
            this.choixNiveau.Name = "choixNiveau";
            this.choixNiveau.Size = new System.Drawing.Size(243, 42);
            this.choixNiveau.TabIndex = 10;
            this.choixNiveau.Visible = false;
            // 
            // choixNiveau1
            // 
            this.choixNiveau1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.choixNiveau1.Font = new System.Drawing.Font("Arial", 10F);
            this.choixNiveau1.Location = new System.Drawing.Point(0, 0);
            this.choixNiveau1.Name = "choixNiveau1";
            this.choixNiveau1.Size = new System.Drawing.Size(94, 42);
            this.choixNiveau1.TabIndex = 8;
            this.choixNiveau1.Text = "Facile";
            this.choixNiveau1.UseVisualStyleBackColor = false;
            this.choixNiveau1.Click += new System.EventHandler(this.choixNiveau1_Click);
            this.choixNiveau1.MouseLeave += new System.EventHandler(this.choixNiveau1_MouseLeave);
            this.choixNiveau1.MouseHover += new System.EventHandler(this.choixNiveau1_MouseHover);
            // 
            // choixNiveau2
            // 
            this.choixNiveau2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.choixNiveau2.Font = new System.Drawing.Font("Arial", 10F);
            this.choixNiveau2.Location = new System.Drawing.Point(150, 0);
            this.choixNiveau2.Name = "choixNiveau2";
            this.choixNiveau2.Size = new System.Drawing.Size(94, 42);
            this.choixNiveau2.TabIndex = 9;
            this.choixNiveau2.Text = "Difficile";
            this.choixNiveau2.UseVisualStyleBackColor = false;
            this.choixNiveau2.Click += new System.EventHandler(this.choixNiveau2_Click);
            this.choixNiveau2.MouseLeave += new System.EventHandler(this.choixNiveau2_MouseLeave);
            this.choixNiveau2.MouseHover += new System.EventHandler(this.choixNiveau2_MouseHover);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 586);
            this.Controls.Add(this.userInteraction);
            this.Controls.Add(this.explications);
            this.Controls.Add(this.Paragraphe);
            this.Controls.Add(this.Titre);
            this.Name = "Home";
            this.Text = "Form1";
            this.userInteraction.ResumeLayout(false);
            this.choixNiveau.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label Paragraphe;
        private System.Windows.Forms.Label explications;
        private System.Windows.Forms.Button typeTest1;
        private System.Windows.Forms.Button typeTest3;
        private System.Windows.Forms.Button typeTest4;
        private System.Windows.Forms.Button typeTest5;
        private System.Windows.Forms.Panel userInteraction;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Panel choixNiveau;
        private System.Windows.Forms.Button choixNiveau1;
        private System.Windows.Forms.Button choixNiveau2;
        public System.Windows.Forms.Button typeTest2;
    }
}