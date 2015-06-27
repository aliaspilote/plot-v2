using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickGraph;
using System.Diagnostics;

namespace Modelisator.GraphSharpe
{
    [DebuggerDisplay("{Source.ID} -> {Target.ID}")]
    public class PocEdge : Edge<PocVertex>
    {
        public string ID
        {
            get;
            private set;
        }

        public PocEdge(string id, PocVertex source, PocVertex target)
            : base(source, target)
        {
            ID = id;
        }
    }
}
