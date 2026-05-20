using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace TruequeU.Models
{
    public class Images
    {
        //SE agrega el dataAnnotation de Key para que EF (Entity Framework) conozca cuál es la llave primaria
        [Key]
        //Se agrega DataAnnotation para que el ID se genere automáticamente con la propiedad NewID()
        // para columnas UNIQUEIDENTIFIER
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; } = Guid.NewGuid();
        [Required]
        public string url { get; set; }

        [Required]
        public Guid listing_id { get; set; }  //llave foranea

        [ForeignKey("listing_id")] //crea el constraint
        [JsonIgnore]
        public Listing? ListingAsc { get; set; } //referencia a la tabla
    }
}