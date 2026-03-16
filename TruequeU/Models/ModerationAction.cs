namespace TruequeU.Models
{
    public class ModerationAction
    {
        public int Id { get; set; }

        public int AdminId { get; set; }

        public User Admin { get; set; }

        public int? ListingId { get; set; }

        public int? TargetUserId { get; set; }

        public string ActionType { get; set; }

        public string Reason { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
