using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_note_etudiant
{
    public class OperationsDeDonnees
    {
        string chemin_donnees = "C:\\Users\\bppch\\Documents\\prog_c#\\note_etudiant" +
        "\\WindowsForms-note_etudiant\\notes_etudiants.txt";
        string chemin_pourcentages = "C:\\Users\\bppch\\Documents\\prog_c#\\note_etudiant\\" +
         "WindowsForms-note_etudiant\\Pourcentage_etudiants.txt";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nb1"></param>
        /// <param name="nb2"></param>
        /// <param name="nb3"></param>
        /// <returns></returns>
        public double CalculerPourcentage(int nb1, int nb2, int nb3)
        {
            double pourcentage = (nb1 + nb2 + nb3) / 3;
            return pourcentage;
        }
        /// <summary>
        /// Récupère les données présentes dans le fichier de note
        /// </summary>
        /// <returns>Les données du fichier</returns>
        public string ChargerDonnees(string chemin)
        {
            string donnees = File.ReadAllText(chemin);
            return donnees;
        }
        /// <summary>
        /// Calcule les pourcentages de tous les étudiants du fichier
        /// </summary>
        public void CalculerPourcGen()
        {
            string[] donnees = File.ReadAllLines(chemin_donnees);
            StreamWriter streamWriter = new StreamWriter(chemin_pourcentages);
            string[] temporaire = new string[5];
            int note_math = 0;
            int note_francais = 0;
            int note_culture = 0;
            string e = "";
            string pourcentage = "";

            for (int i = 1; i < donnees.Length; i++)
            {
                temporaire = donnees[i].Trim().Split(',');
                note_math = int.Parse(temporaire[2]);
                note_francais = int.Parse(temporaire[3]);
                note_culture = int.Parse(temporaire[4]);
                pourcentage =CalculerPourcentage(note_math, note_francais, note_culture).ToString("F2")+"%";
                streamWriter.WriteLine($"Id: {temporaire[0]},Prenom: {temporaire[1]},Pourcentage :{pourcentage}");
            }
            streamWriter.Close();
        }
    }
}
