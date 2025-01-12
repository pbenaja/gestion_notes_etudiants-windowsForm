namespace WindowsForms_note_etudiant
{
    partial class FormPrincipale
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterLesNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesPourcentagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.généralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individuelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterLesNotesToolStripMenuItem,
            this.afficherLesPourcentagesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ajouterLesNotesToolStripMenuItem
            // 
            this.ajouterLesNotesToolStripMenuItem.Name = "ajouterLesNotesToolStripMenuItem";
            this.ajouterLesNotesToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.ajouterLesNotesToolStripMenuItem.Text = "Ajouter les notes";
            this.ajouterLesNotesToolStripMenuItem.Click += new System.EventHandler(this.ajouterLesNotesToolStripMenuItem_Click);
            // 
            // afficherLesPourcentagesToolStripMenuItem
            // 
            this.afficherLesPourcentagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.généralToolStripMenuItem,
            this.individuelToolStripMenuItem});
            this.afficherLesPourcentagesToolStripMenuItem.Name = "afficherLesPourcentagesToolStripMenuItem";
            this.afficherLesPourcentagesToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.afficherLesPourcentagesToolStripMenuItem.Text = "Afficher les pourcentages";
            this.afficherLesPourcentagesToolStripMenuItem.Click += new System.EventHandler(this.afficherLesPourcentagesToolStripMenuItem_Click);
            // 
            // généralToolStripMenuItem
            // 
            this.généralToolStripMenuItem.Name = "généralToolStripMenuItem";
            this.généralToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.généralToolStripMenuItem.Text = "Général";
            // 
            // individuelToolStripMenuItem
            // 
            this.individuelToolStripMenuItem.Name = "individuelToolStripMenuItem";
            this.individuelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.individuelToolStripMenuItem.Text = "Individuel";
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipale";
            this.Text = "Interface Principale";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterLesNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesPourcentagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem généralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individuelToolStripMenuItem;
    }
}

