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
    public class Berechne_Preis_fuer_Tuple
    {
        [TestMethod]
        public void Berechne_Preis_fuer_Tuple_1_Erwarte_8()
        {
            List<int> tuple = new List<int>() { 1 };

            double expected = 8;

            double actual = Algorithmus.Berechne_Preis_fuer_Tuple(tuple);

            Equalidator.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Berechne_Preis_fuer_Tuple_2_Erwarte_15_2()
        {
            List<int> tuple = new List<int>() { 1, 2 };

            double expected = 15.2;

            double actual = Algorithmus.Berechne_Preis_fuer_Tuple(tuple);

            Equalidator.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Berechne_Preis_fuer_Tuple_3_Erwarte_21_6()
        {
            List<int> tuple = new List<int>() { 1, 2, 3 };

            double expected = 21.6;

            double actual = Algorithmus.Berechne_Preis_fuer_Tuple(tuple);

            Equalidator.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Berechne_Preis_fuer_Tuple_4_Erwarte_25_6()
        {
            List<int> tuple = new List<int>() { 1, 2, 3, 4 };

            double expected = 25.6;

            double actual = Algorithmus.Berechne_Preis_fuer_Tuple(tuple);

            Equalidator.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Berechne_Preis_fuer_Tuple_5_Erwarte_30_0()
        {
            List<int> tuple = new List<int>() { 1, 2, 3, 4, 5 };

            double expected = 30.0;

            double actual = Algorithmus.Berechne_Preis_fuer_Tuple(tuple);

            Equalidator.AreEqual(actual, expected);
        }
    }
}
