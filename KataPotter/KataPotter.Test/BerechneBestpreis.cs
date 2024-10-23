using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace KataPotter.Test
{
    public class BerechneBestpreis
    {
        [Fact]
        public void Berechne_Bestpreis_1_erwarte_8()
        {
            var buecherListe = new List<int> { 1 };
            
            Algorithmus.Berechne_Bestpreis(buecherListe).Should().Be(8.0);
        }

        [Fact]
        public void Berechne_Bestpreis_1_2_erwarte_15_2()
        {
            var buecherListe = new List<int> { 1, 2 };
            Algorithmus.Berechne_Bestpreis(buecherListe).Should().Be(15.2);
        }

        [Fact]
        public void Berechne_Bestpreis_1_2_2_erwarte_15_2()
        {
            var buecherListe = new List<int> { 1, 2, 2 };
            Algorithmus.Berechne_Bestpreis(buecherListe).Should().Be(23.2);
        }

        [Fact]
        public void Berechne_Bestpreis_1_2_3_4_5_1_2_3_erwarte_51_2()
        {
            var  buecherListe = new List<int> { 1, 2, 3, 4, 5, 1, 2, 3 };
            Algorithmus.Berechne_Bestpreis(buecherListe).Should().Be(51.2);
        }

        [Fact]
        public void Berechne_Bestpreis_1_2_3_4_5_1_2_3_4_5_3_4_5_erwarte_81_2()
        {
            var buecherListe = new List<int> { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 3, 4, 5 };
            Algorithmus.Berechne_Bestpreis(buecherListe).Should().Be(81.2);
        }
    }
}
