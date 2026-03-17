using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TruequeU.Models
{
    public class ModerationAction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        // ADMIN QUE REALIZA LA ACCIÓN
        [Required]
        public Guid AdminId { get; set; }
        [ForeignKey(("AdminId"))]
        public User Admin { get; set; }
        // LISTING AFECTADO (puede ser null)
        public Guid? ListingId { get; set; }
        [ForeignKey(("ListingId"))]
        public Listing Listing { get; set; }
        // USUARIO AFECTADO (puede ser null)
        public Guid? TargetUserId { get; set; }

        [ForeignKey(("TargetUserId"))]
        public User TargetUser { get; set; }

        // INFORMACIÓN DE LA ACCIÓN
        [Required]
        public string ActionType { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}