using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pizza_Place.Models
{
    public class Compra
    {
        [Key]
        public Cliente Cliente { get; set; }=new Cliente();
        public List<int> Pedidos { get; set; }=new List<int>();
        public bool Pagado { get; set; }

        public void Agregar(int PizzaId) 
        {
            Pedidos.Add(PizzaId);
        
        }
    }
}
