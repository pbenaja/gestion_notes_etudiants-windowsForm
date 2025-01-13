using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsForms_note_etudiant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_note_etudiant.Tests
{
    [TestClass()]
    public class OperationsDeDonneesTests
    {
        [TestMethod()]
        public void CalculerPourcentageTest()
        {
            //---Arranger---//
            OperationsDeDonnees operationsDeDonnees = new OperationsDeDonnees();
            int nb1 = 78;
            int nb2 = 62;
            int nb3 = 70;
            //---Agir---//
            double pourcentage=operationsDeDonnees.CalculerPourcentage(nb1, nb2, nb3);
            //---Affirmer---//
            Assert.AreEqual(pourcentage, 70);
        }
    }
}