using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using equalidator;

namespace KataPotter.Test
{
    [TestClass]
    public class Finde_Tuple
    {
        [TestMethod]
        public void Finde_Tuple_Buecherliste_1_Laenge_5()
        {
            List<int> buecherliste = new List<int>() { 1 };
            Finde_Tuple_Ergebnis actual = Algorithmus.Finde_Tuple(buecherliste, 5);
            Finde_Tuple_Ergebnis expected = new Finde_Tuple_Ergebnis(new List<int>() { 1 }, new List<int>());

            Equalidator.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Finde_Tuple_Buecherliste_1_2_Laenge_5()
        {
            List<int> buecherliste = new List<int>() { 1, 2 };
            Finde_Tuple_Ergebnis actual = Algorithmus.Finde_Tuple(buecherliste, 5);
            Finde_Tuple_Ergebnis expected =
                new Finde_Tuple_Ergebnis
                (
                    new List<int>() { 1, 2 },
                    new List<int>()
                );

            Equalidator.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Finde_Tuple_Buecherliste_1_1_2_Laenge_5()
        {
            List<int> buecherliste = new List<int>() { 1, 1, 2 };
            Finde_Tuple_Ergebnis actual = Algorithmus.Finde_Tuple(buecherliste, 5);
            Finde_Tuple_Ergebnis expected =
                new Finde_Tuple_Ergebnis
                (
                    new List<int>() { 1, 2 },
                    new List<int>() { 1 }
                );

            Equalidator.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Finde_Tuple_Buecherliste_1_1_2_3_4_5_Laenge_5()
        {
            List<int> buecherliste = new List<int>() { 1, 1, 2, 3, 4, 5 };
            Finde_Tuple_Ergebnis actual = Algorithmus.Finde_Tuple(buecherliste, 5);
            Finde_Tuple_Ergebnis expected =
                new Finde_Tuple_Ergebnis
                (
                    new List<int>() { 1, 2, 3, 4, 5 },
                    new List<int>() { 1 }
                );

            Equalidator.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Finde_Tuple_Buecherliste_1_2_3_4_5_1_2_3_4_5_Laenge_5()
        {
            List<int> buecherliste = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            Finde_Tuple_Ergebnis actual = Algorithmus.Finde_Tuple(buecherliste, 5);
            Finde_Tuple_Ergebnis expected =
                new Finde_Tuple_Ergebnis
                (
                    new List<int>() { 1, 2, 3, 4, 5 },
                    new List<int>() { 1, 2, 3, 4, 5 }
                );

            Equalidator.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Finde_Tuple_Buecherliste_1_2_3_4_5_1_2_3_4_5_1_Laenge_5()
        {
            List<int> buecherliste = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1 };
            Finde_Tuple_Ergebnis actual = Algorithmus.Finde_Tuple(buecherliste, 5);
            Finde_Tuple_Ergebnis expected =
                new Finde_Tuple_Ergebnis
                (
                    new List<int>() { 1, 2, 3, 4, 5 },
                    new List<int>() { 1, 2, 3, 4, 5, 1 }
                );

            Equalidator.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Finde_Tuple_Buecherliste_1_2_3_4_5_1_2_3_4_5_1_Laenge_4()
        {
            List<int> buecherliste = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1 };
            Finde_Tuple_Ergebnis actual = Algorithmus.Finde_Tuple(buecherliste, 4);
            Finde_Tuple_Ergebnis expected =
                new Finde_Tuple_Ergebnis
                (
                    new List<int>() { 1, 2, 3, 4 },
                    new List<int>() { 5, 1, 2, 3, 4, 5, 1 }
                );

            Equalidator.AreEqual(expected, actual);
        }
    }
}
