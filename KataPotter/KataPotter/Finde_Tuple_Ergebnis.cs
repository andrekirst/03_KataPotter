using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPotter
{
    public class Finde_Tuple_Ergebnis
    {
        public Finde_Tuple_Ergebnis()
        {
        }

        public Finde_Tuple_Ergebnis(List<int> gefundeneBuecher, List<int> restBuecher)
        {
            GefundeneBuecher = gefundeneBuecher;
            RestBuecher = restBuecher;
        }

        public List<int> GefundeneBuecher { get; set; }
        public List<int> RestBuecher { get; set; }
    }
}
