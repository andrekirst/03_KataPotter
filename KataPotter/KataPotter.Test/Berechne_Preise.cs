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
    public class Berechne_Preise
    {
        [TestMethod]
        public void Berechne_Preise_1_erwarte_1_Preis()
        {
            TreeItem treeItem = new TreeItem()
            {
                AktuellerBuchSatz = new List<int>() { 1 },
                RestBuecher = new List<int>(),
                BuecherSaetze = new List<TreeItem>()
            };

            List<double> expected = new List<double>()
            { 8 };

            List<double> actual = Algorithmus.Berechne_Preise(treeItem, new List<double>());

            Equalidator.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Berechne_Preise_1_2_erwarte_1_Preis()
        {
            TreeItem treeItem = new TreeItem()
            {
                AktuellerBuchSatz = new List<int>() { 1, 2 },
                RestBuecher = new List<int>(),
                BuecherSaetze = new List<TreeItem>()
            };

            List<double> expected = new List<double>()
            { 15.2 };

            List<double> actual = Algorithmus.Berechne_Preise(treeItem, new List<double>());

            Equalidator.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Berechne_Preise_1__2_erwarte_1_Preis()
        {
            TreeItem treeItem = new TreeItem()
            {
                AktuellerBuchSatz = new List<int>() { 1 },
                RestBuecher = new List<int>() { 2 },
                BuecherSaetze = new List<TreeItem>()
                {
                    new TreeItem()
                    {
                        AktuellerBuchSatz = new List<int>() { 2 },
                        RestBuecher = new List<int>(),
                        BuecherSaetze = new List<TreeItem>()
                    }
                }
            };

            List<double> expected = new List<double>()
            { 16 };

            List<double> actual = Algorithmus.Berechne_Preise(treeItem, new List<double>());

            Equalidator.AreEqual(actual, expected);
        }


        //[TestMethod]
        //public void Berechne_Preise_1_2_3_erwarte_3_Preise()
        //{
        //    List<int> buecherListe = new List<int>() { 1, 2, 3 };

        //    List<double> expected = new List<double>()
        //    { 21.6, 23.2, 24 };

        //    List<double> actual = Algorithmus.Berechne_Preise(buecherListe);

        //    Equalidator.AreEqual(actual, expected);
        //}
    }
}
