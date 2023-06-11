using System.ComponentModel.DataAnnotations;

namespace Pizza_Place.Models
{
    public class Usuario
    {
        [Key]
        public bool MostrarCanasta { get; set; } = true;
    }
}
