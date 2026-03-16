namespace TruequeU.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Program { get; set; }

        public double Rating { get; set; }

        public bool IsSuspended { get; set; }

        public List<Listing> Listings { get; set; }

        public List<Message> Messages { get; set; }
    }
}
