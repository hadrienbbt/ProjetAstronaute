using ProjetAstronaute;
using System.Drawing;

namespace GenieLog_V2
{
    partial class Form_Perception
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
            this.niveau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Arial", 18F);
            this.titre.Location = new System.Drawing.Point(111, 9);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(227, 54);
            this.titre.TabIndex = 0;
            this.titre.Text = "Test Perception et \r\nmémoire associative";
            this.titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // niveau
            // 
            this.niveau.AutoSize = true;
            this.niveau.Font = new System.Drawing.Font("Arial", 12F);
            this.niveau.Location = new System.Drawing.Point(192, 63);
            this.niveau.Name = "niveau";
            this.niveau.Size = new System.Drawing.Size(69, 18);
            this.niveau.TabIndex = 1;
            this.niveau.Text = "Niveau 1";
            // 
            // Form_Perception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 509);
            this.Controls.Add(this.niveau);
            this.Controls.Add(this.titre);
            this.Name = "Form_Perception";
            this.Text = "Form_Perception";
            this.Click += new System.EventHandler(this.Form_Perception_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label niveau;
    }
}