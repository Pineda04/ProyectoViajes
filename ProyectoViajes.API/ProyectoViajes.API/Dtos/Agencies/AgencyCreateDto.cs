using System.ComponentModel.DataAnnotations;

namespace ProyectoViajes.API.Dtos.Agencies
{
    public class AgencyCreateDto
    {
        // Nombre
        [Display(Name ="nombre")]
        [Required(ErrorMessage = "El {0} de la agencia es requerido.")]
        [StringLength(50, ErrorMessage = "El {0} de la agencia debe tener menos de {1} caracteres.")]
        public string Name { get; set; }

        // Ubicación
        [Display(Name ="ubicacion")]
        [Required(ErrorMessage = "La {0} de la agencia es requerida.")]
        [StringLength(50, ErrorMessage = "La {0} de la agencia debe tener menos de {1} caracteres.")]
        public string Location { get; set; }

        // Email
        [Display(Name ="email")]
        [Required(ErrorMessage = "El {0} de la agencia es requerido.")]
        [StringLength(50, ErrorMessage = "El {0} de la agencia debe tener menos de {1} caracteres.")]
        public string Email { get; set; }
    }
}