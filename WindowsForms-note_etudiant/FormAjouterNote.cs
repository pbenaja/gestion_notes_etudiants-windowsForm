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
        private void Enregistrer_information()
        {
           this.note_math= int.Parse(textBox_note_math.Text);
           this.note_francais= int.Parse(textBox_note_francais.Text);
           this.note_culture= int.Parse(textBox_note_culture.Text);
           

        }
        public int Note_math { get => note_math; private set => note_math = value; }
        public int Note_francais { get => note_francais; private set => note_francais = value; }
        public int Note_culture { get => note_culture; private set => note_culture = value; }

    }
}
