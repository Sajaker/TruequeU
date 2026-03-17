using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TruequeU.Models
{
    public class Favorite
    {
        //SE agrega el dataAnnotation de Key para que EF (Entity Framework) conozca cuál es la llave primaria
        [Key]
        //Se agrega DataAnnotation para que el ID se genere automáticamente con la propiedad NewID()
        // para columnas UNIQUEIDENTIFIER
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        // El usuario que marcó como favorito
        [Required]
        public Guid UserId { get; set; } //llave foranea

        [ForeignKey("UserId")] //crea el constraint
        public User User { get; set; } //referencia a la tabla

        // El listing que fue marcado como favorito
        [Required]
        public Guid ListingId { get; set; } //llave foranea

        [ForeignKey("ListingId")] //crea el constraint
        public Listing Listing { get; set; } //referencia a la tabla
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
