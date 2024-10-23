using System.Collections.Generic;

namespace KataPotter
{
    public class FindeTupleErgebnis(List<int> gefundeneBuecher, List<int> restBuecher)
    {
        public List<int> GefundeneBuecher { get; } = gefundeneBuecher;
        public List<int> RestBuecher { get; } = restBuecher;
    }
}
