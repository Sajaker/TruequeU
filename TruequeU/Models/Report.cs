namespace TruequeU.Models
{
    public class Report
    {
        public int Id { get; set; }

        public int ReporterId { get; set; }

        public User Reporter { get; set; }

        public int? ListingId { get; set; }

        public Listing Listing { get; set; }

        public int? ReportedUserId { get; set; }

        public User ReportedUser { get; set; }

        public string Reason { get; set; }

        public string Comment { get; set; }

        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
