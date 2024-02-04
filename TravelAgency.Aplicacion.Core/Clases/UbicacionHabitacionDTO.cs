using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Aplicacion.Core
{
    public class UbicacionHabitacionDTO
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUbicacionHabitacion { get; set; }
        public string Descripcion { get; set; }
    }
}
