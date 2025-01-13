using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_note_etudiant
{
    public partial class FormAfficherPourcentage : Form
    {
        string chemin_pourcentages = "C:\\Users\\bppch\\Documents\\prog_c#\\note_etudiant\\" +
         "WindowsForms-note_etudiant\\Pourcentage_etudiants.txt";
        public FormAfficherPourcentage()
        {
            InitializeComponent();
        }

        private void FormAfficherPourcentage_Load(object sender, EventArgs e)
        {

        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationsDeDonnees operations = new OperationsDeDonnees();
            operations.CalculerPourcGen();
            string contenu = File.ReadAllText(chemin_pourcentages);
            boite_text_pourcentage.Text = contenu;
        }
    }
}
