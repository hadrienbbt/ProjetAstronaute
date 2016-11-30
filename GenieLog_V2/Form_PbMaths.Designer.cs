namespace GenieLog_V2
{
    partial class Form_PbMaths
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PbMaths));
            this.retour_accueil = new System.Windows.Forms.Label();
            this.sous_titre = new System.Windows.Forms.Label();
            this.titre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boutton_1 = new System.Windows.Forms.Button();
            this.boutton_2 = new System.Windows.Forms.Button();
            this.boutton_3 = new System.Windows.Forms.Button();
            this.boutton_4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // retour_accueil
            // 
            this.retour_accueil.AutoSize = true;
            this.retour_accueil.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour_accueil.Location = new System.Drawing.Point(12, 53);
            this.retour_accueil.Name = "retour_accueil";
            this.retour_accueil.Size = new System.Drawing.Size(63, 75);
            this.retour_accueil.TabIndex = 5;
            this.retour_accueil.Text = "<";
            this.retour_accueil.Click += new System.EventHandler(this.retour_accueil_Click);
            // 
            // sous_titre
            // 
            this.sous_titre.AutoSize = true;
            this.sous_titre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sous_titre.Location = new System.Drawing.Point(159, 144);
            this.sous_titre.Name = "sous_titre";
            this.sous_titre.Size = new System.Drawing.Size(103, 27);
            this.sous_titre.TabIndex = 4;
            this.sous_titre.Text = "Niveau x";
            this.sous_titre.Click += new System.EventHandler(this.sous_titre_Click);
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(66, 30);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(318, 98);
            this.titre.TabIndex = 3;
            this.titre.Text = "Test problèmes\r\nmathématiques";
            this.titre.Click += new System.EventHandler(this.titre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 91);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // boutton_1
            // 
            this.boutton_1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutton_1.Location = new System.Drawing.Point(62, 331);
            this.boutton_1.Name = "boutton_1";
            this.boutton_1.Size = new System.Drawing.Size(263, 62);
            this.boutton_1.TabIndex = 7;
            this.boutton_1.Text = "Choix 1 :";
            this.boutton_1.UseVisualStyleBackColor = true;
            // 
            // boutton_2
            // 
            this.boutton_2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutton_2.Location = new System.Drawing.Point(62, 421);
            this.boutton_2.Name = "boutton_2";
            this.boutton_2.Size = new System.Drawing.Size(263, 62);
            this.boutton_2.TabIndex = 8;
            this.boutton_2.Text = "Choix 2 :";
            this.boutton_2.UseVisualStyleBackColor = true;
            // 
            // boutton_3
            // 
            this.boutton_3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutton_3.Location = new System.Drawing.Point(62, 509);
            this.boutton_3.Name = "boutton_3";
            this.boutton_3.Size = new System.Drawing.Size(263, 62);
            this.boutton_3.TabIndex = 9;
            this.boutton_3.Text = "Choix 3 :";
            this.boutton_3.UseVisualStyleBackColor = true;
            // 
            // boutton_4
            // 
            this.boutton_4.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutton_4.Location = new System.Drawing.Point(62, 597);
            this.boutton_4.Name = "boutton_4";
            this.boutton_4.Size = new System.Drawing.Size(263, 62);
            this.boutton_4.TabIndex = 10;
            this.boutton_4.Text = "Choix 4 :";
            this.boutton_4.UseVisualStyleBackColor = true;
            // 
            // Form_PbMaths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 750);
            this.Controls.Add(this.boutton_4);
            this.Controls.Add(this.boutton_3);
            this.Controls.Add(this.boutton_2);
            this.Controls.Add(this.boutton_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retour_accueil);
            this.Controls.Add(this.sous_titre);
            this.Controls.Add(this.titre);
            this.Name = "Form_PbMaths";
            this.Text = "Form_PbMaths";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label retour_accueil;
        private System.Windows.Forms.Label sous_titre;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boutton_1;
        private System.Windows.Forms.Button boutton_2;
        private System.Windows.Forms.Button boutton_3;
        private System.Windows.Forms.Button boutton_4;
    }
}