using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TruequeU.Models
{
    public class User
    {

        //SE agrega el dataAnnotation de Key para que EF (Entity Framework) conozca cuál es la llave primaria
        [Key]
        //Se agrega DataAnnotation para que el ID se genere automáticamente con la propiedad NewID()
        // para columnas UNIQUEIDENTIFIER
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Program { get; set; }

        public double Rating { get; set; }

        public bool IsSuspended { get; set; } = false;

        public List<Message> Messages { get; set; }

        // Se crea una "llave foránea" para relacionar el id de Identity User
        // con el registro del cliente, esto para poder hacer la validación
        // de que realmente el token del usuario que está loguueado pueda ver la información de
        // ese cliente en específico

        [Required]
        public string IdentityUserId { get; set; } = string.Empty;

        [ForeignKey("IdentityUserId")]
        public IdentityUser? IdentityUser { get; set; }
    }
}
