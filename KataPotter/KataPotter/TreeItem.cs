using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPotter
{
    public class TreeItem
    {
        public TreeItem()
        {
            BuecherSaetze = new List<TreeItem>();
        }
        /// <summary>
        /// Ist der Tupel von Bänden
        /// </summary>
        public List<int> AktuellerBuchSatz { get; set; }

        /// <summary>
        /// Die Buechersaetze unterhalb des aktuellen
        /// </summary>
        public List<TreeItem> BuecherSaetze { get; set; }
        public List<int> RestBuecher { get; set; }
    }
}
