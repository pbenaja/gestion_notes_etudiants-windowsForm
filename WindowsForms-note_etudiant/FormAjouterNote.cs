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
        int MIN=0, MAX=100;

        public FormAjouterNote()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bouton_enregistrer_Click(object sender, EventArgs e)
        {
            Enregistrer_information();
        }

        private void bouton_Annuler_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        private void Enregistrer_information()
        {
            Notes_etudiants();
            Prenom_etudiant();

        }
        /// <summary>
        /// Valide le prénom de l'étudiant
        /// </summary>
        private void Prenom_etudiant()
        {
            if(string.IsNullOrEmpty(textBox_prenom_etud.Text))
            {
                MessageBox.Show("Vous devez inscrire un prenom");
            }
            else
            {
                this.prenom = textBox_prenom_etud.Text;
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
                if(this.note_culture<MIN || this.note_culture>100)
                {
                    throw new NoteValideException(this.note_culture,MIN,MAX);
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Vous devez inscrire des chiffres pour les notes");
            }
            catch(NoteValideException e)
            {
                MessageBox.Show($"{e.Message}");
            }
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
        public string Prenom { get => prenom; set => prenom = value; }
    }
}
