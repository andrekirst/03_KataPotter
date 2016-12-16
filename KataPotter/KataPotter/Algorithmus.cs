using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPotter
{
    public static class Algorithmus
    {
        public static Dictionary<int, double> Rabatte = new Dictionary<int, double>()
        {
            { 1, 1.0 },
            { 2, 0.95 },
            { 3, 0.9 },
            { 4, 0.8 },
            { 5, 0.75 }
        };

        public static Finde_Tuple_Ergebnis Finde_Tuple(List<int> buecherliste, int tupleLaenge)
        {
            int index = 0;
            int band = 0;
            List<int> ergebnisSatz = new List<int>();
            List<int> restBuecher = new List<int>();

            do
            {
                if (buecherliste[index] != band && ergebnisSatz.Count() < tupleLaenge)
                {
                    ergebnisSatz.Add(buecherliste[index]);
                    band = buecherliste[index++];
                }
                else
                {
                    restBuecher.Add(buecherliste[index++]);
                }
            } while (buecherliste.Count() > index);
            return new Finde_Tuple_Ergebnis(ergebnisSatz, restBuecher);
        }

        public static double Berechne_Bestpreis(List<int> buecherListe)
        {
            List<TreeItem> pfade = Berechne_Pfade(buecherListe, 5);

            List<double> preise = new List<double>();

            foreach (TreeItem pfad in pfade)
            {
                List<double> zwischenpreise = Berechne_Preise(pfad, new List<double>());
                preise.AddRange(zwischenpreise);
            }

            return preise.Min();
        }

        public static double Berechne_Preis_fuer_Tuple(List<int> tuple)
        {
            return Rabatte[tuple.Count()] * (double)tuple.Count() * 8.0;
        }

        public static List<double> Berechne_Preise(TreeItem currentTreeItem, List<double> preisListe, double zwischensumme = 0.0)
        {
            // sind wir das unterste Blatt des Pfades
            zwischensumme += Berechne_Preis_fuer_Tuple(currentTreeItem.AktuellerBuchSatz);

            if (currentTreeItem.BuecherSaetze.Count() == 0)
            {
                preisListe.Add(zwischensumme);
            }
            else
            {
                foreach (TreeItem kind in currentTreeItem.BuecherSaetze)
                {
                    Berechne_Preise(kind, preisListe, zwischensumme);
                }
            }

            return preisListe;
        }

        public static List<TreeItem> Berechne_Pfade(List<int> restSaetze, int geplanteTupleLaenge)
        {
            List<TreeItem> result = new List<TreeItem>();

            int tupleLaenge = Math.Min(geplanteTupleLaenge, restSaetze.Count());

            while (tupleLaenge > 0)
            {
                Finde_Tuple_Ergebnis ergebnis = Finde_Tuple(restSaetze, tupleLaenge);

                tupleLaenge = ergebnis.GefundeneBuecher.Count();

                result.Add(new TreeItem()
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
