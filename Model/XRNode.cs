using System.Collections.Generic;

namespace MoviesDotNetCore.Model
{
    public class XRNode
    {
        public long Id { get; set; }
        public List<string> Labels { get; set; }
        public Dictionary<string, object> Properties { get; set; }

       
        public XRNode(long id, List<string> labels, Dictionary<string, object> properties)
        {   
            Id = id;
            Labels = labels;
            Properties = properties;
        }
    }
}
