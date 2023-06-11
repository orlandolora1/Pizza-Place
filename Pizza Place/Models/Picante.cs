using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Pizza_Place.Models
{
    public enum Picante
    {
       [Key]
        Nada,
        Picante,
        Caliente,

    }
}
