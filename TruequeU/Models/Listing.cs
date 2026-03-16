namespace TruequeU.Models
{
    public class Listing
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Condition { get; set; }

        public decimal Price { get; set; }

        public string State { get; set; }

        public string Location { get; set; }

        public bool IsHidden { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public List<Chat> Chats { get; set; }
    }
}