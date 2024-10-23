using System.Collections.Generic;

namespace KataPotter
{
    public class TreeItem
    {
        /// <summary>
        /// Ist der Tupel von Bänden
        /// </summary>
        public List<int> AktuellerBuchSatz { get; init; }

        /// <summary>
        /// Die Buechersaetze unterhalb des aktuellen
        /// </summary>
        public List<TreeItem> BuecherSaetze { get; init; } = [];

        public List<int> RestBuecher { get; set; }
    }
}
