using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace KataPotter.Test
{
    public class BerechnePfade
    {
        [Fact]
        public void Berechne_Pfade_1_Laenge_5()
        {
            var buecherliste = new List<int> { 1 };

            var actual = Algorithmus.Berechne_Pfade(buecherliste, 5);
            var expected = new List<TreeItem>
            {
                new()
                {
                    AktuellerBuchSatz = [1],
                    BuecherSaetze = [],
                    RestBuecher = []
                }
            };

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Berechne_Pfade_1_2_Laenge_5()
        {
            var buecherliste = new List<int> { 1, 2 };

            var actual = Algorithmus.Berechne_Pfade(buecherliste, 5);
            var expected = new List<TreeItem>
            {
                new()
                {
                    AktuellerBuchSatz = [1, 2],
                    BuecherSaetze = [],
                    RestBuecher = []
                },
                new()
                {
                    AktuellerBuchSatz = [1],
                    RestBuecher = [2],
                    BuecherSaetze =
                    [
                        new TreeItem
                        {
                            AktuellerBuchSatz = [2],
                            BuecherSaetze = [],
                            RestBuecher = []
                        }
                    ]
                }
            };

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Berechne_Pfade_1_2_3_Laenge_5()
        {
            var buecherliste = new List<int> { 1, 2, 3 };

            var actual = Algorithmus.Berechne_Pfade(buecherliste, 5);
            var expected = new List<TreeItem>
            {
                new()
                {
                    AktuellerBuchSatz = [1, 2, 3],
                    RestBuecher = [],
                    BuecherSaetze = []
                },
                new()
                {
                    AktuellerBuchSatz = [1, 2],
                    RestBuecher = [3],
                    BuecherSaetze =
                    [
                        new TreeItem
                        {
                            AktuellerBuchSatz = [3],
                            RestBuecher = [],
                            BuecherSaetze = []
                        }
                    ]
                },
                new()
                {
                    AktuellerBuchSatz = [1],
                    RestBuecher = [2, 3],
                    BuecherSaetze =
                    [
                        new TreeItem
                        {
                            AktuellerBuchSatz = [2],
                            RestBuecher = [3],
                            BuecherSaetze =
                            [
                                new TreeItem
                                {
                                    AktuellerBuchSatz = [3],
                                    RestBuecher = [],
                                    BuecherSaetze = []
                                }
                            ]
                        }
                    ]
                }
            };

            actual.Should().BeEquivalentTo(expected);
        }
        [Fact]
        public void Berechne_Pfade_1_2_2_Laenge_5()
        {
            var buecherliste = new List<int> { 1, 2, 2 };

            var actual = Algorithmus.Berechne_Pfade(buecherliste, 5);
            var expected = new List<TreeItem>
            {
                new()
                {
                    AktuellerBuchSatz = [1, 2],
                    RestBuecher = [2],
                    BuecherSaetze =
                    [
                        new TreeItem
                        {
                            AktuellerBuchSatz = [2],
                            RestBuecher = [],
                            BuecherSaetze = []
                        }
                    ]
                },
                new()
                {
                    AktuellerBuchSatz = [1],
                    RestBuecher = [2, 2],
                    BuecherSaetze =
                    [
                        new TreeItem
                        {
                            AktuellerBuchSatz = [2],
                            RestBuecher = [2],
                            BuecherSaetze =
                            [
                                new TreeItem
                                {
                                    AktuellerBuchSatz = [2],
                                    RestBuecher = [],
                                    BuecherSaetze = []
                                }
                            ]
                        }
                    ]
                }
            };

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
