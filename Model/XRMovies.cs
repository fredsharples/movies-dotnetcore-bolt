using System.Collections.Generic;

namespace MoviesDotNetCore.Model
{
    public class XRMovies
    {
        public XRMovies(List<XRNode> nodes, List<XREdge> links)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<XRNode> NodesList { get; set; }
        public IEnumerable<XREdge> RelationshipsList { get; set; }

    }
    

}

