using System.ComponentModel.DataAnnotations;

namespace Pizza_Place.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string? Nombre { get; set; } 
        public string? Calle { get; set; } 
        public string? Ciudad { get; set; }
    }
}
