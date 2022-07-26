using System.Collections.Generic;

namespace MoviesDotNetCore.Model
{
    public class XRNode
    {
        public string id { get; set; }
        public List<string> labels { get; set; }
        public Properties properties { get; set; }

        public class Properties
        {
            public string tagline { get; set; }
            public string title { get; set; }
            public string released { get; set; }
            public string born { get; set; }
            public string name { get; set; }
        }
    }
}
