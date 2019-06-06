namespace ThreadsAndParellelism
{
    public class Server
    {
        public string Name { get; set; }
        public int Ram { get; set; }
        public bool Status { get; set; }
        public string Location { get; set; }

        // public override string ToString()
        // {
        //     return $"{Name} / {Ram} / {Location} / {Status} "; 
        // }

        public override string ToString() => $"{Name} / {Ram} / {Location} / {Status} "; 
    }
}