using System.ComponentModel.DataAnnotations;

namespace Pizza_Place.Models
{
    public class Pizza
    {

        [Key]
        public int PizzaId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Picante Picante { get; set; }
        public Pizza(int pizzaId, string nombre, decimal precio, Picante picante)
        {
            PizzaId = pizzaId;
            Nombre = nombre;
            Precio = precio;
            Picante = picante;
        }
    }
}
