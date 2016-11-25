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
    public class Berechne_Pfade
    {
        [TestMethod]
        public void Berechne_Pfade_1_Laenge_5()
        {
            List<int> buecherliste = new List<int>() { 1 };

            List<TreeItem> actual = Algorithmus.Berechne_Pfade(buecherliste, 5);
            List<TreeItem> expected = new List<TreeItem>();
            expected.Add(new TreeItem()
            {
                AktuellerBuchSatz = new List<int>() { 1 }
            });

            Equalidator.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Berechne_Pfade_1_2_Laenge_5()
        {
            List<int> buecherliste = new List<int>() { 1, 2 };

            List<TreeItem> actual = Algorithmus.Berechne_Pfade(buecherliste, 5);
            List<TreeItem> expected = new List<TreeItem>();
            expected.Add(new TreeItem()
            {
                AktuellerBuchSatz = new List<int>() { 1, 2 }
            });

            Equalidator.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Berechne_Pfade_1_2_3_4_5_Laenge_5()
        {
            List<int> buecherliste = new List<int>() { 1, 2, 3, 4, 5 };

            List<TreeItem> actual = Algorithmus.Berechne_Pfade(buecherliste, 5);
            List<TreeItem> expected = new List<TreeItem>();
            expected.Add(new TreeItem()
            {
                AktuellerBuchSatz = new List<int>() { 1, 2, 3, 4, 5 }
            });

            Equalidator.AreEqual(actual, expected);
        }


        [TestMethod]
        public void Berechne_Pfade_1_2_3_4_5_1_Laenge_5()
        {
            List<int> buecherliste = new List<int>() { 1, 2, 3, 4, 5, 1 };

            List<TreeItem> actual = Algorithmus.Berechne_Pfade(buecherliste, 5);
            List<TreeItem> expected = new List<TreeItem>();
            expected.Add(new TreeItem()
            {
                AktuellerBuchSatz = new List<int>() { 1, 2, 3, 4, 5 },
                BuecherSaetze = new List<TreeItem>()
                {
                    new TreeItem() { AktuellerBuchSatz = new List<int>() { 1 } }
                }
            });

            Equalidator.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Berechne_Pfade_1_2_3_4_5_1_Laenge_4()
        {
            List<int> buecherliste = new List<int>() { 1, 2, 3, 4, 5, 1 };

            List<TreeItem> actual = Algorithmus.Berechne_Pfade(buecherliste, 4);
            List<TreeItem> expected = new List<TreeItem>();
            expected.Add(new TreeItem()
            {
                AktuellerBuchSatz = new List<int>() { 1, 2, 3, 4 },
                BuecherSaetze = new List<TreeItem>()
                {
                    new TreeItem() { AktuellerBuchSatz = new List<int>() { 5, 1 } }
                }
            });

            Equalidator.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Berechne_Pfade_1_2_3_4_5_1_2_3_4_5_Laenge_5()
        {
            List<int> buecherliste = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };

            List<TreeItem> actual = Algorithmus.Berechne_Pfade(buecherliste, 5);
            List<TreeItem> expected = new List<TreeItem>();
            expected.Add(new TreeItem()
            {
                AktuellerBuchSatz = new List<int>() { 1, 2, 3, 4, 5 },
                BuecherSaetze = new List<TreeItem>()
                {
                    new TreeItem() { AktuellerBuchSatz = new List<int>() { 1, 2, 3, 4, 5 } }
                }
            });

            Equalidator.AreEqual(actual, expected);
        }
    }
}
