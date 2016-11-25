using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPotter
{
    public static class Algorithmus
    {
        public static Tuple<List<int>, List<int>> Finde_Tuple(List<int> buecherliste, int tupleLaenge)
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
                    band = buecherliste[index];
                }
                else
                {
                    restBuecher.Add(buecherliste[index]);
                }
                index++;
            } while (buecherliste.Count() > index);
            return new Tuple<List<int>, List<int>>(ergebnisSatz, restBuecher);
        }
    }
}
