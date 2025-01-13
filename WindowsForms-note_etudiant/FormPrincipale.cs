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
    public partial class FormPrincipale : Form
    {
        public FormPrincipale()
        {
            InitializeComponent();
        }

        private void ajouterLesNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouterNote formAjouterNote = new FormAjouterNote();
            formAjouterNote.MdiParent= this;
            formAjouterNote.Show();
        }

        private void afficherLesPourcentagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAfficherPourcentage formAfficherPourcentage=new FormAfficherPourcentage();
            formAfficherPourcentage.MdiParent= this;
            formAfficherPourcentage.Show();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
