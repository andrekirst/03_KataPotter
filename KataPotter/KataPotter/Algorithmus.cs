using System;
using System.Collections.Generic;
using System.Linq;

namespace KataPotter
{
    public static class Algorithmus
    {
        private static readonly Dictionary<int, double> Rabatte = new()
        {
            { 1, 1.0 },
            { 2, 0.95 },
            { 3, 0.9 },
            { 4, 0.8 },
            { 5, 0.75 }
        };

        public static FindeTupleErgebnis Finde_Tuple(List<int> buecherliste, int tupleLaenge)
        {
            var index = 0;
            var band = 0;
            var ergebnisSatz = new List<int>();
            var restBuecher = new List<int>();

            do
            {
                if (buecherliste[index] != band && ergebnisSatz.Count < tupleLaenge)
                {
                    ergebnisSatz.Add(buecherliste[index]);
                    band = buecherliste[index++];
                }
                else
                {
                    restBuecher.Add(buecherliste[index++]);
                }
            } while (buecherliste.Count > index);
            return new FindeTupleErgebnis(ergebnisSatz, restBuecher);
        }

        public static double Berechne_Bestpreis(List<int> buecherListe)
        {
            var pfade = Berechne_Pfade(buecherListe, 5);

            var preise = new List<double>();

            foreach (var zwischenpreise in pfade.Select(pfad => BerechnePreise(pfad, [])))
            {
                preise.AddRange(zwischenpreise);
            }

            return preise.Min();
        }

        public static double BerechnePreisFuerTuple(List<int> tuple) => Rabatte[tuple.Count] * tuple.Count * 8.0;

        public static List<double> BerechnePreise(TreeItem currentTreeItem, List<double> preisListe, double zwischensumme = 0.0)
        {
            zwischensumme += BerechnePreisFuerTuple(currentTreeItem.AktuellerBuchSatz);

            if (currentTreeItem.BuecherSaetze.Count == 0)
            {
                preisListe.Add(zwischensumme);
            }
            else
            {
                foreach (var kind in currentTreeItem.BuecherSaetze)
                {
                    BerechnePreise(kind, preisListe, zwischensumme);
                }
            }

            return preisListe;
        }

        public static List<TreeItem> Berechne_Pfade(List<int> restSaetze, int geplanteTupleLaenge)
        {
            var result = new List<TreeItem>();
        
            var tupleLaenge = Math.Min(geplanteTupleLaenge, restSaetze.Count);
        
            while (tupleLaenge > 0)
            {
                var ergebnis = Finde_Tuple(restSaetze, tupleLaenge);
        
                tupleLaenge = ergebnis.GefundeneBuecher.Count;
        
                result.Add(new TreeItem
                {
                    AktuellerBuchSatz = ergebnis.GefundeneBuecher,
                    BuecherSaetze = Berechne_Pfade(ergebnis.RestBuecher, tupleLaenge),
                    RestBuecher = ergebnis.RestBuecher
                });
                tupleLaenge--;
            }
        
            return result;
        }
    }
}
