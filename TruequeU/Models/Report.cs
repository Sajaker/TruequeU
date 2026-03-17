using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TruequeU.Models
{
    public class Report
    {
        // PRIMARY KEY
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        // USUARIO QUE HACE EL REPORTE
        [Required]
        public Guid ReporterId { get; set; }

        [ForeignKey(("ReporterId"))]
        public User Reporter { get; set; }
        // LISTING REPORTADO (OPCIONAL)
        public Guid? ListingId { get; set; }

        [ForeignKey(("ListingId"))]
        public Listing Listing { get; set; }

        // USUARIO REPORTADO (OPCIONAL)
        public Guid? ReportedUserId { get; set; }
        [ForeignKey(("ReportedUserId"))]
        public User ReportedUser { get; set; }
        // INFORMACIÓN DEL REPORTE
        [Required]
        public string Reason { get; set; }
        public string Comment { get; set; }

        public string Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}