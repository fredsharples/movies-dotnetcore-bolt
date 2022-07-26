namespace MoviesDotNetCore.Model
{
    public class XREdge
    {
        public string id { get; set; }
        public string type { get; set; }
        public string startNode { get; set; }
        public string endNode { get; set; }
        public Properties2 properties { get; set; }

        public class Properties2
        {
            public string type { get; set; }
        }
    }
}
