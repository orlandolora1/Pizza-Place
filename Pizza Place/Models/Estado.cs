using Pizza_Place.BLL;
using System.ComponentModel.DataAnnotations;

namespace Pizza_Place.Models
{
    public class Estado
    {
        [Key]
        public PizzaBLL PizzaBLL { get; set; } = new PizzaBLL();
        public Compra Compra { get; set; } = new Compra();
        public Usuario Usuario { get; set; } = new Usuario();
    }
}
