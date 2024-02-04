using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Dominio.Core
{
    public class Habitacion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHabitacion { get; set; } 

        public string NombreHabitacion { get; set; }

        public int IdTipoHabitacion { get; set; }

        public decimal ValorHabitacion { get; set; }
        
        public int IdUbicacion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }
    }
}
