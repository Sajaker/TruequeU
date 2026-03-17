using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TruequeU.Models
{
    public class Listing
    {
        //SE agrega el dataAnnotation de Key para que EF (Entity Framework) conozca cuál es la llave primaria
        [Key]
        //Se agrega DataAnnotation para que el ID se genere automáticamente con la propiedad NewID()
        // para columnas UNIQUEIDENTIFIER
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Condition { get; set; }

        public decimal Price { get; set; }

        public string State { get; set; }

        public string Location { get; set; }

        public bool IsHidden { get; set; }

        [Required]
        public Guid UserId { get; set; } //llave foranea

        [ForeignKey("UserId")] //crea el constraint
        public User? User { get; set; } //referencia a la tabla

        public List<Chat> Chats { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}