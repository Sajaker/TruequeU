namespace TruequeU.Models
{
    public class Favorite
    {
        public int Id { get; set; }

        // El usuario que marcó como favorito
        public int UserId { get; set; }
        public User User { get; set; }

        // El listing que fue marcado como favorito
        public int ListingId { get; set; }
        public Listing Listing { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
