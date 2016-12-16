using equalidator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPotter.Test
{
    [TestClass]
    public class Berechne_Bestpreis
    {
        [TestMethod]
        public void Berechne_Bestpreis_1_erwarte_8()
        {
            List<int> buecherListe = new List<int>() { 1 };

            double expected = 8.0;

            double actual = Algorithmus.Berechne_Bestpreis(buecherListe);

            Equalidator.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Berechne_Bestpreis_1_2_erwarte_15_2()
        {
            List<int> buecherListe = new List<int>() { 1, 2 };

            double expected = 15.2;

            double actual = Algorithmus.Berechne_Bestpreis(buecherListe);

            Equalidator.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Berechne_Bestpreis_1_2_2_erwarte_15_2()
        {
            List<int> buecherListe = new List<int>() { 1, 2, 2 };

            double expected = 23.2;

            double actual = Algorithmus.Berechne_Bestpreis(buecherListe);

            Equalidator.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Berechne_Bestpreis_1_2_3_4_5_1_2_3_erwarte_51_2()
        {
            List<int> buecherListe = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3 };

            double expected = 51.2;

            double actual = Algorithmus.Berechne_Bestpreis(buecherListe);

            Equalidator.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Berechne_Bestpreis_1_2_3_4_5_1_2_3_4_5_3_4_5_erwarte_81_2()
        {
            List<int> buecherListe = new List<int>()
            { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 3, 4, 5 };

            double expected = 81.2;

            double actual = Algorithmus.Berechne_Bestpreis(buecherListe);

            Equalidator.AreEqual(actual, expected);
        }
    }
}
