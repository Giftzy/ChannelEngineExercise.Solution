using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngineExercise.Core.Comparers
{
    public class LineComparer : IComparer<Line>
    {
        public int Compare(Line x, Line y)
        {
            if (x.Gtin.Equals(y.Gtin)) return 0;
            else if (x.Quantity < y.Quantity) return 1;
            else { return -1; }
            
        }
    }
}
