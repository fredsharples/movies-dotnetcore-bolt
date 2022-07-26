using System.Collections.Generic;

namespace MoviesDotNetCore.Model
{
    public class XREdge
    {
        public long EndNode { get; set; }
        public long Id { get; set; }
        public Dictionary<string, object> Properties { get; set; }
        public long StartNode { get; set; }
        public string Type { get; set; }

        
        

        public XREdge(long endNode, long id, Dictionary<string, object> properties, long startNode, string type)
        {
            Id = id;
            StartNode = startNode;
            EndNode = endNode;
            Type = type;
            Properties = properties;
        }
    }
}
