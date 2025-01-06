using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        private string chemin;
        private int num_id;
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
            this.Chemin= "C:\\Users\\bppch\\Documents\\prog_c#\\note_etudiant" +
            "\\WindowsForms-note_etudiant\\notes_etudiants.txt";
        }
        /// <summary>
        /// Enregistre les informations dans un fichier texte
        /// </summary>
        public void Enregistrer()
        {
            string fichier = ChargerDonnees();
            StreamWriter streamWriter = new StreamWriter(this.chemin);
            streamWriter.WriteLine(fichier);
            streamWriter.WriteLine($"{this.Num_id},{this.Prenom},{this.Note_math},{this.Note_francais},{this.Note_culture}");
            streamWriter.Close();
        }
        /// <summary>
        /// Récupère les données présentes dans le fichier de note
        /// </summary>
        /// <returns>Les données du fichier</returns>
        public string ChargerDonnees()
        {
            string fichier = "";
            StreamReader streamReader = new StreamReader(this.chemin);
            while(!streamReader.EndOfStream)
            {
                fichier += streamReader.ReadLine();
            }
            streamReader.Close();
            return fichier;
        }

        public string Prenom { get => prenom; private set => prenom = value; }
        public int Note_math { get => note_math; private set => note_math = value; }
        public int Note_francais { get => note_francais; private set => note_francais = value; }
        public int Note_culture { get => note_culture; private set => note_culture = value; }
        public string Chemin { get => chemin; private set => chemin = value; }
        public int Num_id { get => num_id; set => num_id = value; }
    }
}
