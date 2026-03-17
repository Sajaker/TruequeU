using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TruequeU.Models
{
    public class Chat
    {
        //SE agrega el dataAnnotation de Key para que EF (Entity Framework) conozca cuál es la llave primaria
        [Key]
        //Se agrega DataAnnotation para que el ID se genere automáticamente con la propiedad NewID()
        // para columnas UNIQUEIDENTIFIER
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        //Listing que origina el chat
        [Required]
        public Guid ListingId { get; set; } //llave foranea

        [ForeignKey("ListingId")] //crea el constraint
        public Listing Listing { get; set; } //referencia a la tabla

        // Comprador
        [Required]
        public Guid BuyerId { get; set; } //llave foranea

        [ForeignKey("BuyerId")] //crea el constraint
        public User Buyer { get; set; } //referencia a la tabla

        // Vendedor
        [Required]
        public Guid SellerId { get; set; } //llave foranea

        [ForeignKey("SellerId")] //crea el constraint
        public User Seller { get; set; } //referencia a la tabla
        public List<Message> Messages { get; set; }
    }
}
