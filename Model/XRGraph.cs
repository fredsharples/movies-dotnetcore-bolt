using System.Collections.Generic;

namespace MoviesDotNetCore.Model
{
    public class XRGraph
    {
        public XRGraph(List<XRNode> nodes, List<XREdge> edges)
        {
            NodesList = nodes;
            RelationshipsList = edges;
        }

        public IEnumerable<XRNode> NodesList { get; set; }
        public IEnumerable<XREdge> RelationshipsList { get; set; }

    }
    

}

