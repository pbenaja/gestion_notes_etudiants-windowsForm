namespace WindowsForms_note_etudiant
{
    partial class FormAjouterNote
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_note_math = new System.Windows.Forms.TextBox();
            this.textBox_note_francais = new System.Windows.Forms.TextBox();
            this.textBox_note_culture = new System.Windows.Forms.TextBox();
            this.textBox_prenom_etud = new System.Windows.Forms.TextBox();
            this.bouton_enregistrer = new System.Windows.Forms.Button();
            this.bouton_renitialiser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Note en mathématique";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Note en français";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note en culture générale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prenom de l\'étudiant";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_note_math
            // 
            this.textBox_note_math.Location = new System.Drawing.Point(260, 148);
            this.textBox_note_math.Name = "textBox_note_math";
            this.textBox_note_math.Size = new System.Drawing.Size(58, 22);
            this.textBox_note_math.TabIndex = 4;
            // 
            // textBox_note_francais
            // 
            this.textBox_note_francais.Location = new System.Drawing.Point(260, 186);
            this.textBox_note_francais.Name = "textBox_note_francais";
            this.textBox_note_francais.Size = new System.Drawing.Size(58, 22);
            this.textBox_note_francais.TabIndex = 5;
            // 
            // textBox_note_culture
            // 
            this.textBox_note_culture.Location = new System.Drawing.Point(260, 231);
            this.textBox_note_culture.Name = "textBox_note_culture";
            this.textBox_note_culture.Size = new System.Drawing.Size(58, 22);
            this.textBox_note_culture.TabIndex = 6;
            // 
            // textBox_prenom_etud
            // 
            this.textBox_prenom_etud.Location = new System.Drawing.Point(337, 33);
            this.textBox_prenom_etud.Name = "textBox_prenom_etud";
            this.textBox_prenom_etud.Size = new System.Drawing.Size(144, 22);
            this.textBox_prenom_etud.TabIndex = 7;
            // 
            // bouton_enregistrer
            // 
            this.bouton_enregistrer.Location = new System.Drawing.Point(274, 324);
            this.bouton_enregistrer.Name = "bouton_enregistrer";
            this.bouton_enregistrer.Size = new System.Drawing.Size(88, 33);
            this.bouton_enregistrer.TabIndex = 8;
            this.bouton_enregistrer.Text = "Enregistrer";
            this.bouton_enregistrer.UseVisualStyleBackColor = true;
            this.bouton_enregistrer.Click += new System.EventHandler(this.bouton_enregistrer_Click);
            // 
            // bouton_renitialiser
            // 
            this.bouton_renitialiser.Location = new System.Drawing.Point(368, 324);
            this.bouton_renitialiser.Name = "bouton_renitialiser";
            this.bouton_renitialiser.Size = new System.Drawing.Size(90, 32);
            this.bouton_renitialiser.TabIndex = 9;
            this.bouton_renitialiser.Text = "Rénitialiser";
            this.bouton_renitialiser.UseVisualStyleBackColor = true;
            this.bouton_renitialiser.Click += new System.EventHandler(this.bouton_renitialiser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numéro d\'identification";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(337, 67);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(144, 22);
            this.textBox_id.TabIndex = 11;
            // 
            // FormAjouterNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bouton_renitialiser);
            this.Controls.Add(this.bouton_enregistrer);
            this.Controls.Add(this.textBox_prenom_etud);
            this.Controls.Add(this.textBox_note_culture);
            this.Controls.Add(this.textBox_note_francais);
            this.Controls.Add(this.textBox_note_math);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAjouterNote";
            this.Text = "Ajouter les notes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_note_math;
        private System.Windows.Forms.TextBox textBox_note_francais;
        private System.Windows.Forms.TextBox textBox_note_culture;
        private System.Windows.Forms.TextBox textBox_prenom_etud;
        private System.Windows.Forms.Button bouton_enregistrer;
        private System.Windows.Forms.Button bouton_renitialiser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_id;
    }
}