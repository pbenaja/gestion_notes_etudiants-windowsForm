using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_note_etudiant
{
    public class GestionDonnees
    {
        private string prenom;
        private int note_math;
        private int note_francais;
        private int note_culture;
        private int num_id;
        string chemin_donnees = "C:\\Users\\bppch\\Documents\\prog_c#\\note_etudiant" +
        "\\WindowsForms-note_etudiant\\notes_etudiants.txt";
        string chemin_pourcentages = "C:\\Users\\bppch\\Documents\\prog_c#\\note_etudiant\\" +
         "WindowsForms-note_etudiant\\Pourcentage_etudiants.txt";
        /// <summary>
        /// Initialise les informations essentielles à enregistrer
        /// </summary>
        /// <param name="prenom">le prénom de l'étudiant</param>
        /// <param name="note_math">la note en math de l'étudiant</param>
        /// <param name="note_francais">la note en français de l'étudiant</param>
        /// <param name="note_culture">la note en culture générale de l'étudiant</param>
        /// <param name="num_id">le numéro d'identification de l'étudiant</param>
        public GestionDonnees(string prenom, int note_math, int note_francais, int note_culture,int num_id)
        {
            this.Prenom = prenom;
            this.Note_math = note_math;
            this.Note_francais = note_francais;
            this.Note_culture = note_culture;
            this.Num_id = num_id;
        }
        /// <summary>
        /// Enregistre les informations dans un fichier texte
        /// </summary>
        public void EnregistrerDonnees()
        {
            OperationsDeDonnees operations = new OperationsDeDonnees();
            string fichier = operations.ChargerDonnees(chemin_donnees);
            StreamWriter streamWriter = new StreamWriter(chemin_donnees);
            streamWriter.Write(fichier);
            streamWriter.WriteLine($"{this.Num_id},{this.Prenom},{this.Note_math},{this.Note_francais},{this.Note_culture}");
            streamWriter.Close();
        }

        /// <summary>
        /// Vérifie si le numéro d'identification inscrit est déjà attribué
        /// à une autre personne
        /// </summary>
        /// <returns>vrai ou faux</returns>
        public bool VerifierId()
        {
            OperationsDeDonnees operations = new OperationsDeDonnees();
            string fichier=operations.ChargerDonnees(chemin_donnees);
            bool present = fichier.Contains(this.Num_id.ToString());
            return present;
        }

        public string Prenom { get => prenom; private set => prenom = value; }
        public int Note_math { get => note_math; private set => note_math = value; }
        public int Note_francais { get => note_francais; private set => note_francais = value; }
        public int Note_culture { get => note_culture; private set => note_culture = value; }
        public int Num_id { get => num_id; set => num_id = value; }
    }
}
