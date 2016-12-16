using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPotter
{
    public static class Algorithmus
    {
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
