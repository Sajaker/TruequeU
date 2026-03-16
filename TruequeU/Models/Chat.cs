namespace TruequeU.Models
{
    public class Chat
    {
        public int Id { get; set; }

        public int ListingId { get; set; }

        public Listing Listing { get; set; }

        public int BuyerId { get; set; }

        public int SellerId { get; set; }

        public List<Message> Messages { get; set; }
    }
}
