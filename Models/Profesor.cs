using System.ComponentModel.DataAnnotations;

namespace SistemaGestionEscuelas.Models
{
    public class Profesor
    {
        [Key]
        public int ProfesorId { get; set; }  // Clave primaria

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [StringLength(100)]
        public string Especialidad { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }
    }
}