using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace KataPotter.Test
{
    public class FindeTuple
    {
        [Fact]
        public void Finde_Tuple_Buecherliste_1_Laenge_5()
        {
            var buecherliste = new List<int> { 1 };
            var actual = Algorithmus.Finde_Tuple(buecherliste, 5);
            var expected = new FindeTupleErgebnis([1], []);

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Finde_Tuple_Buecherliste_1_2_Laenge_5()
        {
            var buecherliste = new List<int> { 1, 2 };
            var actual = Algorithmus.Finde_Tuple(buecherliste, 5);
            var expected =
                new FindeTupleErgebnis
                (
                    [1, 2],
                    []
                );

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Finde_Tuple_Buecherliste_1_1_2_Laenge_5()
        {
            var buecherliste = new List<int> { 1, 1, 2 };
            var actual = Algorithmus.Finde_Tuple(buecherliste, 5);
            var expected =
                new FindeTupleErgebnis
                (
                    [1, 2],
                    [1]
                );

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Finde_Tuple_Buecherliste_1_1_2_3_4_5_Laenge_5()
        {
            var buecherliste = new List<int> { 1, 1, 2, 3, 4, 5 };
            var actual = Algorithmus.Finde_Tuple(buecherliste, 5);
            var expected =
                new FindeTupleErgebnis
                (
                    [1, 2, 3, 4, 5],
                    [1]
                );

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Finde_Tuple_Buecherliste_1_2_3_4_5_1_2_3_4_5_Laenge_5()
        {
            var buecherliste = new List<int> { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            var actual = Algorithmus.Finde_Tuple(buecherliste, 5);
            var expected =
                new FindeTupleErgebnis
                (
                    [1, 2, 3, 4, 5],
                    [1, 2, 3, 4, 5]
                );

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Finde_Tuple_Buecherliste_1_2_3_4_5_1_2_3_4_5_1_Laenge_5()
        {
            var buecherliste = new List<int> { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1 };
            var actual = Algorithmus.Finde_Tuple(buecherliste, 5);
            var expected =
                new FindeTupleErgebnis
                (
                    [1, 2, 3, 4, 5],
                    [1, 2, 3, 4, 5, 1]
                );

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Finde_Tuple_Buecherliste_1_2_3_4_5_1_2_3_4_5_1_Laenge_4()
        {
            var buecherliste = new List<int> { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1 };
            var actual = Algorithmus.Finde_Tuple(buecherliste, 4);
            var expected =
                new FindeTupleErgebnis
                (
                    [1, 2, 3, 4],
                    [5, 1, 2, 3, 4, 5, 1]
                );

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
