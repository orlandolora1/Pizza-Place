using Pizza_Place.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Pizza_Place.BLL
{
    public class PizzaBLL
    {
        public List<Pizza> Pizza { get; set; } = new List<Pizza>();
        public void Agregar(Pizza pizza) => this.Pizza.Add(pizza);
        public Pizza? ObtenerPizza(int pizzaId) => Pizza.SingleOrDefault(p => p.PizzaId == pizzaId);
    }
}
