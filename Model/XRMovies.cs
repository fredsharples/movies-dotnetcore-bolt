using System.Collections.Generic;

namespace MoviesDotNetCore.Model
{
    public class XRMovies
    {
        public XRMovies(List<XRNode> nodes, List<XREdge> links)
        {
            
        }

        public IEnumerable<XRNode> NodesList { get; set; }
        public IEnumerable<XREdge> RelationshipsList { get; set; }

    }
    

}

