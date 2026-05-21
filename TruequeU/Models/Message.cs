using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TruequeU.Models
{
    public class Message
    {
        //SE agrega el dataAnnotation de Key para que EF (Entity Framework) conozca cuál es la llave primaria
        [Key]
        //Se agrega DataAnnotation para que el ID se genere automáticamente con la propiedad NewID()
        // para columnas UNIQUEIDENTIFIER
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Guid ChatId { get; set; }
        [JsonIgnore]
        public Chat Chat { get; set; }

        public Guid SenderId { get; set; }

        public User Sender { get; set; }

        public string Content { get; set; }

        public DateTime SentAt { get; set; }
    }
}
