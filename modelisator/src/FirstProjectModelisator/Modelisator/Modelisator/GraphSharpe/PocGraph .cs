using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickGraph;

namespace Modelisator.GraphSharpe
{
    public class PocGraph : BidirectionalGraph<PocVertex, PocEdge>
    {
        public PocGraph() { }

        public PocGraph(bool allowParallelEdges)
            : base(allowParallelEdges) { }

        public PocGraph(bool allowParallelEdges, int vertexCapacity)
            : base(allowParallelEdges, vertexCapacity) { }
    }

}
