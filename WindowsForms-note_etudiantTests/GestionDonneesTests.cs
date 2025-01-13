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
    public class GestionDonneesTests
    {
        [TestMethod()]
        public void CalculerPourcentageTest()
        {
            //---Arranger--//
            Gest
            int nb1 = 72;
            int nb2 = 59;
            int nb3 = 79;
            //--Agir--//
            double pourcentage= CalculerPourcentage(nb1,nb2 ,nb3);
            Assert.Fail();
        }
    }
}