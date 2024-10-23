using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace KataPotter.Test
{
    public class BerechnePreise
    {
        [Fact]
        public void Berechne_Preise_1_erwarte_1_Preis()
        {
            var treeItem = new TreeItem()
            {
                AktuellerBuchSatz = [1],
                RestBuecher = [],
                BuecherSaetze = []
            };

            var expected = new List<double> { 8 };

            var actual = Algorithmus.BerechnePreise(treeItem, []);
            
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Berechne_Preise_1_2_erwarte_1_Preis()
        {
            var treeItem = new TreeItem
            {
                AktuellerBuchSatz = [1, 2],
                RestBuecher = [],
                BuecherSaetze = []
            };

            var expected = new List<double> { 15.2 };

            var actual = Algorithmus.BerechnePreise(treeItem, []);

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Berechne_Preise_1__2_erwarte_1_Preis()
        {
            var treeItem = new TreeItem
            {
                AktuellerBuchSatz = [1],
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
            };

            var expected = new List<double> { 16 };

            var actual = Algorithmus.BerechnePreise(treeItem, []);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
