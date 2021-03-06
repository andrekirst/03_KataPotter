﻿using equalidator;
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
                AktuellerBuchSatz = new List<int>() { 1 },
                BuecherSaetze = new List<TreeItem>(),
                RestBuecher = new List<int>()
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
                AktuellerBuchSatz = new List<int>() { 1, 2 },
                BuecherSaetze = new List<TreeItem>(),
                RestBuecher = new List<int>()
            });

            expected.Add(new TreeItem()
            {
                AktuellerBuchSatz = new List<int>() { 1 },
                RestBuecher = new List<int>() { 2 },
                BuecherSaetze = new List<TreeItem>()
                {
                    new TreeItem()
                    {
                        AktuellerBuchSatz = new List<int>() { 2 },
                        BuecherSaetze = new List<TreeItem>(),
                        RestBuecher = new List<int>()
                    }
                }
            });

            Equalidator.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Berechne_Pfade_1_2_3_Laenge_5()
        {
            List<int> buecherliste = new List<int>() { 1, 2, 3 };

            List<TreeItem> actual = Algorithmus.Berechne_Pfade(buecherliste, 5);
            List<TreeItem> expected = new List<TreeItem>();

            expected.Add(new TreeItem()
            {
                AktuellerBuchSatz = new List<int>() { 1, 2, 3 },
                RestBuecher = new List<int>(),
                BuecherSaetze = new List<TreeItem>()
            });

            expected.Add(new TreeItem()
            {
                AktuellerBuchSatz = new List<int>() { 1, 2 },
                RestBuecher = new List<int>() { 3 },
                BuecherSaetze = new List<TreeItem>()
                {
                    new TreeItem()
                    {
                        AktuellerBuchSatz = new List<int>() { 3 },
                        RestBuecher = new List<int>(),
                        BuecherSaetze = new List<TreeItem>()
                    }
                }
            });

            expected.Add(new TreeItem()
            {
                AktuellerBuchSatz = new List<int>() { 1 },
                RestBuecher = new List<int>() { 2, 3 },
                BuecherSaetze = new List<TreeItem>()
                {
                    new TreeItem()
                    {
                        AktuellerBuchSatz = new List<int>() { 2 },
                        RestBuecher = new List<int>() { 3 },
                        BuecherSaetze = new List<TreeItem>()
                        {
                            new TreeItem()
                            {
                                AktuellerBuchSatz = new List<int>() { 3 },
                                RestBuecher = new List<int>(),
                                BuecherSaetze = new List<TreeItem>()
                            }
                        }
                    }
                }
            });

            Equalidator.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Berechne_Pfade_1_2_2_Laenge_5()
        {
            List<int> buecherliste = new List<int>() { 1, 2, 2 };

            List<TreeItem> actual = Algorithmus.Berechne_Pfade(buecherliste, 5);
            List<TreeItem> expected = new List<TreeItem>();

            expected.Add(new TreeItem()
            {
                AktuellerBuchSatz = new List<int>() { 1, 2 },
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
            });

            expected.Add(new TreeItem()
            {
                AktuellerBuchSatz = new List<int>() { 1 },
                RestBuecher = new List<int>() { 2, 2 },
                BuecherSaetze = new List<TreeItem>()
                {
                    new TreeItem()
                    {
                        AktuellerBuchSatz = new List<int>() { 2 },
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
                    }
                }
            });

            Equalidator.AreEqual(actual, expected);
        }
    }
}
