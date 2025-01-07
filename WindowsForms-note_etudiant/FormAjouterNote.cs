using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_note_etudiant
{
    public partial class FormAjouterNote : Form
    {
        private int note_math;
        private int note_francais;
        private int note_culture;
        private string prenom;
        private int num_id;
        int MIN=0, MAX=100;
        bool probleme_resolue=false;

        public FormAjouterNote()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Enregistre les informations quand le bouton "enregistrer est appuyé"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bouton_enregistrer_Click(object sender, EventArgs e)
        {
            Identification();
            Notes_etudiants();
            if(probleme_resolue)
            {
                GestionDonnees donnees = new GestionDonnees(this.Prenom, this.Note_math, this.Note_francais,
                this.Note_culture, this.Num_id);
                donnees.Enregistrer();
            }

        }
        private void bouton_renitialiser_Click(object sender, EventArgs e)
        {
            Renitialiser();
        }
        /// <summary>
        /// Valide le prénom de l'étudiant
        /// </summary>
        private void Identification()
        {
            try
            {
                this.num_id = int.Parse(textBox_id.Text);
                if (string.IsNullOrEmpty(textBox_prenom_etud.Text))
                {
                    MessageBox.Show("Vous devez inscrire le prénom de l'étudiant");
                    
                }
                if(textBox_id.Text.Length!=6)
                {
                    MessageBox.Show("Vous devez inscrire 6 chiffes pour le numéro d'identification");
                }
                if(textBox_id.Text.Length == 6 && !string.IsNullOrEmpty(textBox_prenom_etud.Text))  
                {
                    
                    this.prenom = textBox_prenom_etud.Text.ToLower();
                    probleme_resolue=true;
                }
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Vous devez inscrire uniquement des chiffes");
                probleme_resolue = false;
            }
        }
        /// <summary>
        /// Valide les notes des étudiants
        /// </summary>
        private void Notes_etudiants()
        {
            try
            {
                this.note_math = int.Parse(textBox_note_math.Text);
                this.note_francais = int.Parse(textBox_note_francais.Text);
                this.note_culture = int.Parse(textBox_note_culture.Text);
                if(this.note_math < MIN || this.note_math > 100)
                {
                    throw new NoteValideException(this.note_math, MIN,MAX);
                }
                if (this.note_francais < MIN || this.note_francais > 100)
                {
                    throw new NoteValideException(this.note_francais, MIN, MAX);
                }
                if (this.note_culture < MIN || this.note_culture > 100)
                {
                    throw new NoteValideException(this.note_culture, MIN, MAX);
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Vous devez inscrire des chiffres pour les notes");
                textBox_note_culture.Text = string.Empty;
                textBox_note_francais.Text = string.Empty;
                textBox_note_math.Text = string.Empty;
                probleme_resolue=false;

            }
            catch(NoteValideException e)
            {
                MessageBox.Show($"{e.Message}");
                textBox_note_culture.Text = string.Empty;
                textBox_note_francais.Text = string.Empty;
                textBox_note_math.Text = string.Empty;
                probleme_resolue = false;
            }
        }
        private void Renitialiser()
        {
            textBox_id.Text = string.Empty;
            textBox_note_culture.Text = string.Empty;
            textBox_note_francais.Text = string.Empty;
            textBox_note_math.Text = string.Empty;
            textBox_prenom_etud.Text = string.Empty;

        }
       

        public int Note_math
        {
            get => note_math; 
            private set
            {
                note_math = value;
            }
        }
        public int Note_francais { get => note_francais; private set => note_francais = value; }
        public int Note_culture { get => note_culture; private set => note_culture = value; }
        public string Prenom { get => prenom; private set => prenom = value; }

        public int Num_id { get => num_id; private set => num_id = value; }
    }
}
