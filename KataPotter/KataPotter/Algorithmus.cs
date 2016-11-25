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

        public static List<TreeItem> Berechne_Pfade(List<int> restSaetze, int tupleLaenge)
        {
            List<TreeItem> result = new List<TreeItem>();

            Finde_Tuple_Ergebnis ergebnis = Finde_Tuple(restSaetze, tupleLaenge);

            TreeItem item = new TreeItem() { AktuellerBuchSatz = ergebnis.GefundeneBuecher };
            item.BuecherSaetze = new List<TreeItem>();

            if (ergebnis.RestBuecher != null && ergebnis.RestBuecher.Count() > 0)
            {
                int start = Math.Min(tupleLaenge, ergebnis.RestBuecher.Count());
                for (int i = start; i >= 1; i--)
                {
                    TreeItem subItem = new TreeItem();
                    Finde_Tuple_Ergebnis subErgebnis = Finde_Tuple(ergebnis.RestBuecher, i);
                    subItem.AktuellerBuchSatz = subErgebnis.GefundeneBuecher;
                    subItem.RestBuecher = subErgebnis.RestBuecher;
                    item.BuecherSaetze.Add(subItem);
                } 
            }

            result.Add(item);
            return result;
        }
    }
}
