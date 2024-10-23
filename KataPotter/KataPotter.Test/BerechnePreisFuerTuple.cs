using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace KataPotter.Test
{
    public class BerechnePreisFuerTuple
    {
        [Fact]
        public void Berechne_Preis_fuer_Tuple_1_Erwarte_8()
        {
            var tuple = new List<int> { 1 };
            Algorithmus.BerechnePreisFuerTuple(tuple).Should().Be(8);
        }

        [Fact]
        public void Berechne_Preis_fuer_Tuple_2_Erwarte_15_2()
        {
            var tuple = new List<int> { 1, 2 };
            Algorithmus.BerechnePreisFuerTuple(tuple).Should().Be(15.2);
        }

        [Fact]
        public void Berechne_Preis_fuer_Tuple_3_Erwarte_21_6()
        {
            var tuple = new List<int> { 1, 2, 3 };
            Algorithmus.BerechnePreisFuerTuple(tuple).Should().Be(21.6);
        }

        [Fact]
        public void Berechne_Preis_fuer_Tuple_4_Erwarte_25_6()
        {
            var tuple = new List<int> { 1, 2, 3, 4 };
            Algorithmus.BerechnePreisFuerTuple(tuple).Should().Be(25.6);
        }

        [Fact]
        public void Berechne_Preis_fuer_Tuple_5_Erwarte_30_0()
        {
            var tuple = new List<int> { 1, 2, 3, 4, 5 };
            Algorithmus.BerechnePreisFuerTuple(tuple).Should().Be(30.0);
        }
    }
}
