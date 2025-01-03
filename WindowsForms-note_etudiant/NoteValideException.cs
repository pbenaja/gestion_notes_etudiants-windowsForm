using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_note_etudiant
{
    public class NoteValideException:Exception
    {
        private int valeur;
        private int min;
        private int max;

        public NoteValideException(int valeur, int min, int max):base($"{valeur}" +
            $" n'est pas comprise entre {min} et {max}")
        {
            this.Valeur = valeur;
            this.Min = min;
            this.Max = max;
        }

        public int Valeur { get => valeur;private set => valeur = value; }
        public int Min { get => min; private set => min = value; }
        public int Max { get => max; private set => max = value; }
    }
}
