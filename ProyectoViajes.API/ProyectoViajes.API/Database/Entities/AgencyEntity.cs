using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoViajes.API.Database.Entities
{
    [Table("agencies", Schema ="dbo")]
    public class AgencyEntity
    {
        // Id
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        // Nombre
        [Required]
        [StringLength(50)]
        [Column("name")]
        public string Name { get; set; }

        // Ubicación
        [Required]
        [StringLength(50)]
        [Column("location")]
        public string Location { get; set; }

        // Email
        [Required]
        [StringLength(50)]
        [Column("email")]
        public string Email { get; set; }
    }
}