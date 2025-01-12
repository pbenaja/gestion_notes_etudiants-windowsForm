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
        private string chemin_donnees;
        private string chemin_pourcentages;
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
            this.chemin_donnees= "C:\\Users\\bppch\\Documents\\prog_c#\\note_etudiant" +
            "\\WindowsForms-note_etudiant\\notes_etudiants.txt";
            this.chemin_pourcentages = "C:\\Users\\bppch\\Documents\\prog_c#\\note_etudiant\\" +
             "WindowsForms-note_etudiant\\Pourcentage_etudiants.txt";
        }
        /// <summary>
        /// Enregistre les informations dans un fichier texte
        /// </summary>
        public void Enregistrer()
        {
            string fichier = ChargerDonnees();
            StreamWriter streamWriter = new StreamWriter(this.chemin_donnees);
            streamWriter.Write(fichier);
            streamWriter.WriteLine($"{this.Num_id},{this.Prenom},{this.Note_math},{this.Note_francais},{this.Note_culture}");
            streamWriter.Close();
        }
        /// <summary>
        /// Récupère les données présentes dans le fichier de note
        /// </summary>
        /// <returns>Les données du fichier</returns>
        public string ChargerDonnees()
        {
            string donnees = File.ReadAllText(this.chemin_donnees);
            return donnees;
        }
        /// <summary>
        /// Vérifie si le numéro d'identification inscrit est déjà attribué
        /// à une autre personne
        /// </summary>
        /// <returns>vrai ou faux</returns>
        public bool VerifierId()
        {
            string fichier=ChargerDonnees();
            bool present = fichier.Contains(this.Num_id.ToString());
            return present;
        }
        /// <summary>
        /// Calcule les pourcentages de tous les étudiants du fichier
        /// </summary>
        public void CalculerPourcGen()
        {
            string[] donnees=File.ReadAllLines(this.chemin_donnees);
            string[] temporaire = new string[5];
            int note_math = 0;
            int note_francais = 0;
            int note_culture = 0;
            string pourcentage = "";
           
            for (int i=1;i<donnees.Length;i++)
            {
                temporaire = donnees[i].Trim().Split(',');
                note_math = int.Parse(temporaire[2]);
                note_francais= int.Parse(temporaire[3]);
                note_culture = int.Parse(temporaire[4]);
                pourcentage=CalculerPourcentage(note_math,note_francais,note_culture).ToString("F2");
            }
        }
        /// <summary>
        /// Charge les pourcentages des étudiants contenu dans le fichier du pourcentage
        /// </summary>
        /// <returns>les pourcentages des étudiants</returns>
        public string ChargerPourcentages()
        {
            string pourcentages=File.ReadAllText(this.chemin_pourcentages);
            return pourcentages;
        }
        private double CalculerPourcentage(int nb1,int nb2,int nb3)
        {
            double pourcentage = (nb1 + nb2 + nb2 + nb3) / 3;
            return pourcentage;
        }


        public string Prenom { get => prenom; private set => prenom = value; }
        public int Note_math { get => note_math; private set => note_math = value; }
        public int Note_francais { get => note_francais; private set => note_francais = value; }
        public int Note_culture { get => note_culture; private set => note_culture = value; }
        public int Num_id { get => num_id; set => num_id = value; }
    }
}
