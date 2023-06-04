using System.ComponentModel.DataAnnotations;

namespace Libros.Models
{
    public class Libro
    {
        [Key]

        public int LibrosId { get; set; }

        [Required(ErrorMessage = "El titulo debe ser obligatorio")]
        public string? Titulo { get; set; }

        public int Precio { get; set; }
    }
}
